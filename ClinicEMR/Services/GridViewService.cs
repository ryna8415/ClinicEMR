using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicEMR.Controls;
using ClinicEMR.Helpers;

namespace ClinicEMR.Services
{
    internal static class GridViewService
    {
        private static readonly Dictionary<DataGridView, int> HoveredRows = new();
        private static readonly Dictionary<DataGridView, ThemedScrollBar> ScrollBindings = new();
        private const int ScrollBarThickness = 12;

        public static void MakeReadOnly(DataGridView grid)
        {
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ThemeService.StyleGrid(grid);
            grid.DataBindingComplete -= Grid_DataBindingComplete;
            grid.DataBindingComplete += Grid_DataBindingComplete;
            grid.CellMouseEnter -= Grid_CellMouseEnter;
            grid.CellMouseEnter += Grid_CellMouseEnter;
            grid.CellMouseLeave -= Grid_CellMouseLeave;
            grid.CellMouseLeave += Grid_CellMouseLeave;
            grid.MouseLeave -= Grid_MouseLeave;
            grid.MouseLeave += Grid_MouseLeave;
            EnsureCustomScrollbars(grid);
        }

        public static void ShowOnly(DataGridView grid, params string[] visibleColumns)
        {
            var allowed = new HashSet<string>(visibleColumns);

            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.Visible = allowed.Contains(column.Name);
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Resizable = DataGridViewTriState.False;
            }
        }

        public static void SetHeaders(DataGridView grid, IReadOnlyDictionary<string, string> headers)
        {
            foreach (var pair in headers.Where(pair => grid.Columns[pair.Key] != null))
            {
                grid.Columns[pair.Key].HeaderText = pair.Value;
            }
        }

        private static void Grid_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is not DataGridView grid)
                return;

            ClearSelection(grid);
            SyncScrollbars(grid);
        }

        public static void ClearSelection(DataGridView grid)
        {
            grid.ClearSelection();

            if (grid.Rows.Count > 0)
                grid.CurrentCell = null;
        }

        private static void Grid_CellMouseEnter(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is not DataGridView grid || e.RowIndex < 0)
                return;

            ResetHoveredRow(grid);
            HoveredRows[grid] = e.RowIndex;
            ApplyHoverStyle(grid, e.RowIndex);
        }

        private static void Grid_CellMouseLeave(object? sender, DataGridViewCellEventArgs e)
        {
            if (sender is not DataGridView grid || e.RowIndex < 0)
                return;

            ResetHoveredRow(grid, e.RowIndex);
        }

        private static void Grid_MouseLeave(object? sender, System.EventArgs e)
        {
            if (sender is not DataGridView grid)
                return;

            ResetHoveredRow(grid);
        }

        private static void EnsureCustomScrollbars(DataGridView grid)
        {
            if (ScrollBindings.ContainsKey(grid))
            {
                SyncScrollbars(grid);
                return;
            }

            grid.ScrollBars = ScrollBars.None;

            grid.ScrollBars = ScrollBars.None;

            ThemedScrollBar verticalBar = new()
            {
                Orientation = Orientation.Vertical,
                Width = ScrollBarThickness,
                Visible = false,
                TrackColor = UITheme.ScrollTrack,
                ThumbColor = UITheme.ScrollThumb,
                ThumbHoverColor = UITheme.ScrollThumbHover
            };

            ScrollBindings[grid] = verticalBar;

            verticalBar.ValueChanged += (_, _) => ApplyVerticalScroll(grid);

            grid.Controls.Add(verticalBar);
            verticalBar.BringToFront();

            grid.Resize -= Grid_LayoutChanged;
            grid.Resize += Grid_LayoutChanged;
            grid.Scroll -= Grid_Scroll;
            grid.Scroll += Grid_Scroll;
            grid.MouseWheel -= Grid_MouseWheel;
            grid.MouseWheel += Grid_MouseWheel;
            grid.RowsAdded -= Grid_RowsAdded;
            grid.RowsAdded += Grid_RowsAdded;
            grid.RowsRemoved -= Grid_RowsRemoved;
            grid.RowsRemoved += Grid_RowsRemoved;
            grid.ColumnAdded -= Grid_ColumnsChanged;
            grid.ColumnAdded += Grid_ColumnsChanged;
            grid.ColumnRemoved -= Grid_ColumnsChanged;
            grid.ColumnRemoved += Grid_ColumnsChanged;
            grid.ColumnWidthChanged -= Grid_ColumnWidthChanged;
            grid.ColumnWidthChanged += Grid_ColumnWidthChanged;
            grid.ColumnStateChanged -= Grid_ColumnStateChanged;
            grid.ColumnStateChanged += Grid_ColumnStateChanged;
            grid.Disposed -= Grid_Disposed;
            grid.Disposed += Grid_Disposed;

            SyncScrollbars(grid);
        }

        private static void Grid_LayoutChanged(object? sender, System.EventArgs e)
        {
            if (sender is DataGridView grid)
            {
                SyncScrollbars(grid);
            }
        }

        private static void Grid_Scroll(object? sender, ScrollEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                SyncScrollbars(grid);
            }
        }

        private static void Grid_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (sender is not DataGridView grid || grid.Rows.Count == 0)
                return;

            int currentRowIndex;
            try
            {
                currentRowIndex = grid.FirstDisplayedScrollingRowIndex;
            }
            catch
            {
                currentRowIndex = 0;
            }

            if (currentRowIndex < 0)
            {
                currentRowIndex = 0;
            }

            int rowsPerNotch = Math.Max(1, grid.DisplayedRowCount(false) / 3);
            int deltaRows = Math.Sign(e.Delta) * rowsPerNotch;
            int targetRowIndex = Math.Max(0, Math.Min(currentRowIndex - deltaRows, Math.Max(0, grid.Rows.Count - 1)));

            if (targetRowIndex != currentRowIndex)
            {
                try
                {
                    grid.FirstDisplayedScrollingRowIndex = targetRowIndex;
                }
                catch
                {
                }
            }

            SyncScrollbars(grid);
        }

        private static void Grid_ContentChanged(object? sender, System.EventArgs e)
        {
            if (sender is DataGridView grid)
            {
                SyncScrollbars(grid);
            }
        }

        private static void Grid_RowsAdded(object? sender, DataGridViewRowsAddedEventArgs e)
        {
            Grid_ContentChanged(sender, EventArgs.Empty);
        }

        private static void Grid_RowsRemoved(object? sender, DataGridViewRowsRemovedEventArgs e)
        {
            Grid_ContentChanged(sender, EventArgs.Empty);
        }

        private static void Grid_ColumnsChanged(object? sender, DataGridViewColumnEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                SyncScrollbars(grid);
            }
        }

        private static void Grid_ColumnWidthChanged(object? sender, DataGridViewColumnEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                SyncScrollbars(grid);
            }
        }

        private static void Grid_ColumnStateChanged(object? sender, DataGridViewColumnStateChangedEventArgs e)
        {
            if (sender is DataGridView grid)
            {
                SyncScrollbars(grid);
            }
        }

        private static void Grid_Disposed(object? sender, System.EventArgs e)
        {
            if (sender is not DataGridView grid)
            {
                return;
            }

            if (!ScrollBindings.Remove(grid, out ThemedScrollBar? verticalBar))
            {
                return;
            }

            verticalBar.Dispose();
        }

        private static void ApplyVerticalScroll(DataGridView grid)
        {
            if (!ScrollBindings.TryGetValue(grid, out ThemedScrollBar? verticalBar))
            {
                return;
            }

            if (grid.Rows.Count == 0 || !verticalBar.Visible || verticalBar.Tag is true)
            {
                return;
            }

            try
            {
                verticalBar.Tag = true;
                int rowIndex = Math.Max(0, Math.Min(verticalBar.Value, Math.Max(0, grid.Rows.Count - 1)));
                if (grid.FirstDisplayedScrollingRowIndex != rowIndex)
                {
                    grid.FirstDisplayedScrollingRowIndex = rowIndex;
                }
            }
            catch
            {
            }
            finally
            {
                verticalBar.Tag = false;
            }
        }

        private static void SyncScrollbars(DataGridView grid)
        {
            if (!ScrollBindings.TryGetValue(grid, out ThemedScrollBar? verticalBar))
            {
                return;
            }

            bool wasSyncing = verticalBar.Tag is true;
            verticalBar.Tag = true;

            try
            {
                int displayedRows = Math.Max(1, grid.DisplayedRowCount(false));
                int verticalMaximum = Math.Max(0, grid.Rows.Count - displayedRows);
                bool showVertical = grid.Rows.Count > displayedRows;
                int verticalHeight = Math.Max(0, grid.ClientSize.Height);

                verticalBar.Bounds = new System.Drawing.Rectangle(
                    Math.Max(0, grid.ClientSize.Width - ScrollBarThickness),
                    0,
                    ScrollBarThickness,
                    verticalHeight);

                verticalBar.Minimum = 0;
                verticalBar.Maximum = verticalMaximum;
                verticalBar.LargeChange = displayedRows;
                verticalBar.Visible = showVertical;

                if (showVertical)
                {
                    int rowIndex = grid.FirstDisplayedScrollingRowIndex < 0 ? 0 : grid.FirstDisplayedScrollingRowIndex;
                    verticalBar.Value = Math.Min(rowIndex, verticalMaximum);
                }

                verticalBar.BringToFront();
            }
            finally
            {
                verticalBar.Tag = wasSyncing;
            }
        }

        private static void ApplyHoverStyle(DataGridView grid, int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= grid.Rows.Count)
                return;

            DataGridViewRow row = grid.Rows[rowIndex];
            if (row.Selected)
                return;

            row.DefaultCellStyle.BackColor = UITheme.GridRowHover;
            row.DefaultCellStyle.SelectionBackColor = UITheme.GridRowSelect;
        }

        private static void ResetHoveredRow(DataGridView grid, int? expectedRowIndex = null)
        {
            if (!HoveredRows.TryGetValue(grid, out int rowIndex))
                return;

            if (expectedRowIndex.HasValue && expectedRowIndex.Value != rowIndex)
                return;

            if (rowIndex >= 0 && rowIndex < grid.Rows.Count)
            {
                DataGridViewRow row = grid.Rows[rowIndex];
                row.DefaultCellStyle.BackColor = rowIndex % 2 == 0
                    ? UITheme.GridRowOdd
                    : UITheme.GridRowEven;
                row.DefaultCellStyle.SelectionBackColor = UITheme.GridRowSelect;
            }

            HoveredRows.Remove(grid);
        }
    }
}
