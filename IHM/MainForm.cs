using BLL.Managers;
using System;
using System.Windows.Forms;
using Generation.Word;

namespace IHM
{
    public partial class MainForm : Form
    {
        private CurriculumVitaeManager _curriculumVitaeManager;

        private AdministrativeDataForm _administrativeDataForm;
        private ProfessionalExperienceForm _professionalExperienceForm;
        private LearningForm _learningForm;
        private SkillsForm _skillsForm;
        private ComplementaryInformationForm _complementaryInformationForm;


        public MainForm()
        {
            InitializeComponent();

            _curriculumVitaeManager = new CurriculumVitaeManager();
        }

        private void btn_UpdateAdministrativesDatas_Click(object sender, EventArgs e)
        {
            this._administrativeDataForm = new AdministrativeDataForm(_curriculumVitaeManager.CV.AdministrativeDatas);
            this._administrativeDataForm.ShowDialog();
            _curriculumVitaeManager.CV.AdministrativeDatas = this._administrativeDataForm.GetDatas();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this._curriculumVitaeManager.Save(tb_SaveFilePath.Text);
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            this._curriculumVitaeManager.Load(tb_SaveFilePath.Text);
        }

        private void btn_UpdateProfessionalExperiences_Click(object sender, EventArgs e)
        {
            this._professionalExperienceForm = new ProfessionalExperienceForm(_curriculumVitaeManager.CV.ProfessionnalExperiences);
            this._professionalExperienceForm.ShowDialog();
            _curriculumVitaeManager.CV.ProfessionnalExperiences = this._professionalExperienceForm.GetDatas();
        }

        private void btn_UpdateLearnings_Click(object sender, EventArgs e)
        {
            this._learningForm = new LearningForm(_curriculumVitaeManager.CV.Learnings);
            this._learningForm.ShowDialog();
            _curriculumVitaeManager.CV.Learnings = this._learningForm.GetDatas();
        }

        private void btn_UpdateSkills_Click(object sender, EventArgs e)
        {
            this._skillsForm = new SkillsForm(_curriculumVitaeManager.CV.Skills);
            this._skillsForm.ShowDialog();
            _curriculumVitaeManager.CV.Skills = this._skillsForm.GetDatas();
        }

        private void btn_UpdateComplementaryInformation_Click(object sender, EventArgs e)
        {
            this._complementaryInformationForm = new ComplementaryInformationForm(_curriculumVitaeManager.CV.ComplementaryInformations);
            this._complementaryInformationForm.ShowDialog();
            _curriculumVitaeManager.CV.ComplementaryInformations = this._complementaryInformationForm.GetDatas();
        }

        private void btn_WordGeneration_Click(object sender, EventArgs e)
        {
            var wordAdaptater = new WordAdaptater(this._curriculumVitaeManager.CV, tb_GenerationFilePath.Text);
        }
    }
}
