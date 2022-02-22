using System;
using System.Collections.Generic;

namespace BLL.Objects
{
    [Serializable]
    public class ComplementaryInformation
    {
        public string ThemeName { get; set; }
        public List<string> Content { get; set; }

        public ComplementaryInformation(string name)
        {
            this.ThemeName = name;
            this.Content = new List<string>();
        }

        public override string ToString()
        {
            return $"{ThemeName}";
        }
    }
}
