using Generation.Enumerations;
using System.Drawing;

namespace Generation.Classes
{
    public class ParagraphStyle
    {
        public int Size { get; set; }
        public Color FontColor  { get; set; }
        public Color UnderlineColor  { get; set; }
        public bool Italic { get; set; }
        public bool Bold { get; set; }
        public bool Underline { get; set; }
        public AlignmentType Alignment { get; set; }

        public ParagraphStyle()
        {
            this.Size = 10;
            this.FontColor = Color.Black;
            this.UnderlineColor = Color.Black;
            this.Italic = false;
            this.Bold = false;
            this.Underline = false;
            this.Alignment = AlignmentType.Left;
        }
    }
}
