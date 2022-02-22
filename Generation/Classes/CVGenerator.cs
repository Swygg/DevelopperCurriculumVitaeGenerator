using BLL.Objects;
using Generation.Enumerations;
using Generation.Word;

namespace Generation.Classes
{
    public static class CVGenerator
    {
        public static void Generate(CurriculumVitae cv,
            string path, 
            FileType fileType )
        {

            switch (fileType)
            {
                case FileType.Word:
                    var adaptater = new WordAdaptater(cv, path);
                    break;
                default:
                    break;
            }
        }
    }
}
