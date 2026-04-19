using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClinicEMR.Helpers;

namespace ClinicEMR.Services
{
    internal static class GridViewService
    {
        private static readonly Dictionary<DataGridView, int> HoveredRows = new();

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
