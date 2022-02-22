using Generation.Classes;
using System.Collections.Generic;
using System.Linq;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Generation.Word
{
    public class WordGeneration
    {
        private string _fileName;
        private DocX _doc;

        public WordGeneration(string fileName)
        {
            this._fileName = fileName;
            _doc = DocX.Create(_fileName);
        }



        public void AddParagraph(string content)
        {
            AddParagraph(content, new ParagraphStyle());
        }

        public void AddParagraph(string content, ParagraphStyle paragraphStyle)
        {
            if (paragraphStyle == null)
                paragraphStyle = new ParagraphStyle();
            AddParagraph(new List<ParagraphPart>() { new ParagraphPart(content, paragraphStyle) });
        }

        public void AddParagraph(List<ParagraphPart> list)
        {
            var paragraph = _doc.InsertParagraph();
            foreach (var item in list)
            {
                var format = GetFormatting(item.Style);
                paragraph.Append(item.Content, format);
            }

            switch (list[0].Style.Alignment)
            {
                case Enumerations.AlignmentType.Left:
                    paragraph.Alignment = Alignment.left;
                    break;
                case Enumerations.AlignmentType.Center:
                    paragraph.Alignment = Alignment.center;
                    break;
                case Enumerations.AlignmentType.Right:
                    paragraph.Alignment = Alignment.right;
                    break;
                case Enumerations.AlignmentType.Justify:
                    paragraph.Alignment = Alignment.both;
                    break;
                default:
                    break;
            }
        }

        public void InsertLine()
        {
            var paragraph = _doc.InsertParagraph();
            paragraph.InsertHorizontalLine(HorizontalBorderPosition.top,
                BorderStyle.Tcbs_single);
        }

        public void InsertTable(TableOptions tableOptions)
        {
            List<ParagraphPart>[,] tableStr = tableOptions.Content;

            Table table = _doc.AddTable(tableStr.GetLength(0), tableStr.GetLength(1));
            table.Alignment = Alignment.center;
            //table.Design = TableDesign.ColorfulList;
            table.Design = TableDesign.None;

            foreach (var columnSize in tableOptions.ColumnsSize)
            {
                table.SetColumnWidth(columnSize.Index, columnSize.Size);
            }

            for (int i = 0; i < tableStr.GetLength(0); i++)
            {
                for (int j = 0; j < tableStr.GetLength(1); j++)
                {
                    foreach (var item in tableStr[i, j])
                    {
                        if (!item.JumpLine)
                            table.Rows[i].Cells[j].Paragraphs.First().Append(
                                item.Content,
                                GetFormatting(item.Style));
                        else
                            table.Rows[i].Cells[j].InsertParagraph(item.Content, false, GetFormatting(item.Style));
                    }
                }
            }
            _doc.InsertTable(table);
        }

        public void Save()
        {
            _doc.Save();
        }



        private Formatting GetFormatting(ParagraphStyle style)
        {
            var formatting = new Formatting();
            formatting.Size = style.Size;
            formatting.FontColor = style.FontColor;
            if (style.Underline)
            {
                formatting.UnderlineColor = style.UnderlineColor;
            }
            if (style.Bold)
                formatting.Bold = true;
            if (style.Italic)
                formatting.Italic = true;

            return formatting;
        }
    }
}
