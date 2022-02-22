using BLL.Interfaces;
using BLL.Objects;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BLL.Managers

{
    public class CurriculumVitaeManager : ICurriculumVitaeManager
    {
        private IFormatter _formatter;
        public CurriculumVitae CV { get; set; }

        public CurriculumVitaeManager()
        {
            _formatter = new BinaryFormatter();
            CV = new CurriculumVitae();
        }

        public void CreateCV()
        {
            CV = new CurriculumVitae();
        }

        public void Save(string path)
        {

            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            _formatter.Serialize(stream, CV);
            stream.Close();
        }

        public void Load(string path)
        {
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            this.CV = (CurriculumVitae)_formatter.Deserialize(stream);
            stream.Close();
        }
    }
}
