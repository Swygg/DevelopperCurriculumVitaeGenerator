using BLL.Extensions;
using BLL.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IHM
{
    public partial class SkillsForm : Form
    {
        private List<Skill> _skills;

        public SkillsForm(List<Skill> skills)
        {
            InitializeComponent();
            this._skills = skills;
            LoadDatas();
        }

        private void LoadDatas()
        {
            lb_List.DataSource = null;
            lb_List.DataSource = this._skills;
        }

        public List<Skill> GetDatas()
        {
            return this._skills;
        }

        private void Reset()
        {
            tb_ThemeName.Clear();
            tb_Content.Clear();
        }

        private Skill Get()
        {
            return new Skill(tb_ThemeName.Text)
            {
                Content = this.tb_Content.Text.Trim().Split(Environment.NewLine).ToList()
            };
        }

        private void Show(Skill skill)
        {
            tb_ThemeName.Text = skill.ThemeName;
            tb_Content.Clear();
            foreach (var item in skill.Content)
            {
                tb_Content.Text += item + Environment.NewLine;
            }
        }

        private void lb_List_Click(object sender, EventArgs e)
        {
            if (lb_List.SelectedIndex == -1) return;

            var skill = lb_List.SelectedItem as Skill;
            Show(skill);
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
            var newSkill = Get();
            this._skills.Add(newSkill);
            this.LoadDatas();
            Reset();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (lb_List.SelectedIndex == -1)
                return;

            var Skill = Get();
            this._skills[lb_List.SelectedIndex] = Skill;
            this.LoadDatas();
            Reset();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Reset();
            if (lb_List.SelectedIndex == -1)
                return;

            this._skills.RemoveAt(lb_List.SelectedIndex);
            LoadDatas();
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            var index = lb_List.SelectedIndex;
            if (index <= 0)
                return;

            _skills.Swap(index, index - 1);
            LoadDatas();
            lb_List.SelectedIndex = index - 1;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var index = lb_List.SelectedIndex;
            if (index >= _skills.Count - 1)
                return;

            _skills.Swap(index, index + 1);
            LoadDatas();
            lb_List.SelectedIndex = index + 1;
        }
    }
}
