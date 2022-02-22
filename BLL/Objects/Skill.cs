using System;
using System.Collections.Generic;

namespace BLL.Objects
{
    [Serializable]
    public class Skill 
    {
        public string ThemeName { get; set; }
        public List<string> Content { get; set; }

        public Skill(string name)
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
