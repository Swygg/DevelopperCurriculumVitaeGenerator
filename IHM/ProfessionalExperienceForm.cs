using BLL.Extensions;
using BLL.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IHM
{
    public partial class ProfessionalExperienceForm : Form
    {
        private List<ProfessionalExperience> _experiences;

        public ProfessionalExperienceForm(List<ProfessionalExperience> experiences)
        {
            InitializeComponent();
            this._experiences = experiences;
            LoadDatas();
        }

        private void LoadDatas()
        {
            lb_List.DataSource = null;
            lb_List.DataSource = this._experiences;
        }

        public List<ProfessionalExperience> GetDatas()
        {
            return this._experiences;
        }

        private void Reset()
        {
            dtp_DateStart.Value = DateTime.Today;
            dtp_DateEnd.Value = DateTime.Today;
            tb_DurationLength.Clear();
            tb_Name.Clear();
            tb_CompanyName.Clear();
            tb_CompanyCity.Clear();
            tb_Missions.Clear();
            tb_ContractType.Clear();
            cb_IsDevelopperJob.Checked = true;
        }

        private ProfessionalExperience Get()
        {
            ProfessionalExperience experience;
            if (tb_DurationLength.Text.Length == 0)
            {
                experience = new ProfessionalExperience(dtp_DateStart.Value, dtp_DateEnd.Value);
            }
            else
            {
                experience = new ProfessionalExperience(dtp_DateStart.Value, tb_DurationLength.Text);
            }
            experience.Name = tb_Name.Text;
            experience.CompanyName = tb_CompanyName.Text;
            experience.CompanyCity = tb_CompanyCity.Text;
            experience.Missions = this.tb_Missions.Text.Trim().Split(Environment.NewLine).ToList();
            experience.IsDevelopperJob = cb_IsDevelopperJob.Checked;
            experience.ContractType = tb_ContractType.Text;

            return experience;
        }

        private void Show(ProfessionalExperience experience)
        {
            dtp_DateStart.Value = experience.StartDate;
            if (experience.EndDate.HasValue)
                dtp_DateEnd.Value = experience.EndDate.Value;
            else
                dtp_DateEnd.Value = DateTime.Now;
            tb_DurationLength.Text = experience.LengthDate;
            tb_Name.Text = experience.Name;
            tb_CompanyName.Text = experience.CompanyName;
            tb_CompanyCity.Text = experience.CompanyCity;
            tb_ContractType.Text = experience.ContractType;
            this.tb_Missions.Clear();
            foreach (var mission in experience.Missions)
            {
                this.tb_Missions.Text += mission + Environment.NewLine;
            }
            cb_IsDevelopperJob.Checked = experience.IsDevelopperJob;
        }

        private void lb_List_Click(object sender, EventArgs e)
        {
            if (lb_List.SelectedIndex == -1) return;

            var experience = lb_List.SelectedItem as ProfessionalExperience;
            Show(experience);
        }

        private void btn_SaveAndClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var newExperience = Get();
            this._experiences.Add(newExperience);
            this.LoadDatas();
            Reset();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (lb_List.SelectedIndex == -1)
                return;

            var newExperience = Get();
            this._experiences[lb_List.SelectedIndex] = newExperience;
            this.LoadDatas();
            Reset();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Reset();
            if (lb_List.SelectedIndex == -1)
                return;

            this._experiences.RemoveAt(lb_List.SelectedIndex);
            LoadDatas();
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            var index = lb_List.SelectedIndex;
            if (index <= 0)
                return;

            _experiences.Swap(index, index - 1);
            LoadDatas();
            lb_List.SelectedIndex = index - 1;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var index = lb_List.SelectedIndex;
            if (index >= _experiences.Count - 1)
                return;

            _experiences.Swap(index, index + 1);
            LoadDatas();
            lb_List.SelectedIndex = index + 1;
        }
    }
}
