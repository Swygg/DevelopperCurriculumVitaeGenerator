using System;

namespace BLL.Objects
{
    [Serializable]
    public class Learning
    {
        public DateTime StartDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SchoolName { get; set; }
        public string SchoolCity { get; set; }
        public bool IsObtained { get; set; }

        public override string ToString()
        {
            return $"{StartDate.ToString("yyyy")} - {Name}";
        }
    }
}
