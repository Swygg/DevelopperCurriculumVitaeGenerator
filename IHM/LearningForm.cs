using BLL.Extensions;
using BLL.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class LearningForm : Form
    {

        private List<Learning> _learnings;

        public LearningForm(List<Learning> learning)
        {
            InitializeComponent();
            this._learnings = learning;
            LoadDatas();
        }

        private void LoadDatas()
        {
            lb_List.DataSource = null;
            lb_List.DataSource = this._learnings;
        }

        public List<Learning> GetDatas()
        {
            return this._learnings;
        }

        private void Reset()
        {
            dtp_DateStart.Value = DateTime.Today;
            tb_LearningName.Clear();
            tb_Description.Clear();
            tb_SchoolName.Clear();
            tb_SchoolCity.Clear();
            cb_Obtained.Checked = true;
        }

        private Learning Get()
        {
            return new Learning()
            {
                StartDate = dtp_DateStart.Value,
                Name = tb_LearningName.Text,
                Description = tb_Description.Text,
                SchoolName = tb_SchoolName.Text,
                SchoolCity = tb_SchoolCity.Text,
                IsObtained = cb_Obtained.Checked
            };
        }

        private void Show(Learning learning)
        {
            dtp_DateStart.Value = learning.StartDate;
            tb_LearningName.Text = learning.Name;
            tb_Description.Text = learning.Description;
            tb_SchoolName.Text = learning.SchoolName;
            tb_SchoolCity.Text = learning.SchoolCity;
            cb_Obtained.Checked = learning.IsObtained;
        }

        private void lb_List_Click(object sender, EventArgs e)
        {
            if (lb_List.SelectedIndex == -1) return;

            var learning = lb_List.SelectedItem as Learning;
            Show(learning);
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
            var newLearning = Get();
            this._learnings.Add(newLearning);
            this.LoadDatas();
            Reset();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (lb_List.SelectedIndex == -1)
                return;

            var learning = Get();
            this._learnings[lb_List.SelectedIndex] = learning;
            this.LoadDatas();
            Reset();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Reset();
            if (lb_List.SelectedIndex == -1)
                return;

            this._learnings.RemoveAt(lb_List.SelectedIndex);
            LoadDatas();
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            var index = lb_List.SelectedIndex;
            if (index <= 0)
                return;

            _learnings.Swap(index, index - 1);
            LoadDatas();
            lb_List.SelectedIndex = index - 1;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var index = lb_List.SelectedIndex;
            if (index >= _learnings.Count - 1)
                return;

            _learnings.Swap(index, index + 1);
            LoadDatas();
            lb_List.SelectedIndex = index + 1;
        }
    }
}
