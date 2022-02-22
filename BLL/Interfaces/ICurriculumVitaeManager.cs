namespace BLL.Interfaces
{
    public interface ICurriculumVitaeManager
    {
        public void CreateCV();

        public void Save(string path);

        public void Load(string path);
    }
}
