using PdfSharpCore.Drawing;

namespace HtmlRenderer.NetCore.PdfSharp
{
    public class PdfPaginationConfig
    {
        public string FontName { get; set; } = "Calibri";

        public double FontSize { get; set; } = 12;

        public XKnownColor Color { get; set; } = XKnownColor.Black;

        public double X { get; set; } = 10;

        public double Y { get; set; } = 10;

        public string Format { get; set; } = "Page {0} of {1}";
    }
}