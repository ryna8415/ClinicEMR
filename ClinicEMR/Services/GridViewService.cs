using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicEMR.Services
{
    internal static class GridViewService
    {
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
    }
}
