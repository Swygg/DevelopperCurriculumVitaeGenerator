namespace Generation.Classes
{
    public class ParagraphPart
    {
        public string Content { get; set; }
        public ParagraphStyle Style { get; set; }
        public bool JumpLine { get; set; }

        public ParagraphPart(string content, ParagraphStyle style, bool jumpLine = false)
        {
            this.Content = content;
            this.Style = style;
            this.JumpLine = jumpLine;
        }

        public ParagraphPart(string content) : this(content, new ParagraphStyle())
        {

        }
    }
}
