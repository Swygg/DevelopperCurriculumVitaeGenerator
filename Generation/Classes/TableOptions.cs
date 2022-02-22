using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generation.Classes
{
    public class TableOptions
    {
        public List<ParagraphPart>[,] Content { get; set; }
        public List<ColumnSize> ColumnsSize { get; set; }

        public TableOptions(List<ParagraphPart>[,] content) : this(content, new List<ColumnSize>())
        {
        }

        public TableOptions(List<ParagraphPart>[,] content, List<ColumnSize> columnSizes)
        {
            Content = content;
            ColumnsSize = columnSizes;
        }

    }

    public class ColumnSize
    {
        public int Index { get; set; }
        public int Size { get; set; }

        public ColumnSize(int index, int size)
        {
            this.Index = index;
            this.Size = size;
        }
    }
}
