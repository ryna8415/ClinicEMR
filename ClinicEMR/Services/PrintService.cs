using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicEMR.Services
{
    internal static class PrintService
    {
        private static readonly Font PrintFont = new("Consolas", 10F);

        public static void ShowPrintPreview(IWin32Window owner, string documentTitle, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show(owner, "There is nothing to print.", "Print Preview",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var document = CreateDocument(documentTitle, content);
            using var previewDialog = new PrintPreviewDialog
            {
                Document = document,
                Width = 1000,
                Height = 700,
                StartPosition = FormStartPosition.CenterParent,
                UseAntiAlias = true
            };

            previewDialog.ShowDialog(owner);
        }

        public static void AppendSection(StringBuilder builder, string heading, IEnumerable<string> lines)
        {
            var materializedLines = lines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .ToList();

            builder.AppendLine(heading);
            builder.AppendLine(new string('-', heading.Length));

            if (materializedLines.Count == 0)
            {
                builder.AppendLine("N/A");
            }
            else
            {
                foreach (var line in materializedLines)
                {
                    builder.AppendLine(line);
                }
            }

            builder.AppendLine();
        }

        public static string DisplayValue(string? value, string fallback = "N/A")
            => string.IsNullOrWhiteSpace(value) ? fallback : value.Trim();

        private static PrintDocument CreateDocument(string documentTitle, string content)
        {
            var document = new PrintDocument
            {
                DocumentName = documentTitle
            };

            var lines = NormalizeLines(content).ToArray();
            var currentLine = 0;

            document.BeginPrint += (_, _) => currentLine = 0;
            document.PrintPage += (_, e) =>
            {
                if (e.Graphics == null)
                {
                    e.HasMorePages = false;
                    return;
                }

                var graphics = e.Graphics;
                float y = e.MarginBounds.Top;
                float defaultLineHeight = PrintFont.GetHeight(graphics);

                while (currentLine < lines.Length)
                {
                    string line = lines[currentLine];
                    string measurementText = string.IsNullOrEmpty(line) ? " " : line;
                    var measured = graphics.MeasureString(measurementText, PrintFont, e.MarginBounds.Width);
                    float lineHeight = Math.Max(defaultLineHeight, measured.Height);

                    if (y + lineHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    var bounds = new RectangleF(
                        e.MarginBounds.Left,
                        y,
                        e.MarginBounds.Width,
                        lineHeight);

                    graphics.DrawString(line, PrintFont, Brushes.Black, bounds);
                    y += lineHeight;
                    currentLine++;
                }

                e.HasMorePages = false;
            };

            return document;
        }

        private static IEnumerable<string> NormalizeLines(string content)
        {
            return content
                .Replace("\r\n", "\n", StringComparison.Ordinal)
                .Replace('\r', '\n')
                .Split('\n');
        }
    }
}
