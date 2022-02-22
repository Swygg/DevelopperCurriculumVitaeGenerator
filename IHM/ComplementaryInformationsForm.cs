using BLL.Extensions;
using BLL.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IHM
{
    public partial class ComplementaryInformationForm : Form
    {

        private List<ComplementaryInformation> _complementaryInformations;

        public ComplementaryInformationForm(List<ComplementaryInformation> complementaryInformations)
        {
            InitializeComponent();
            this._complementaryInformations = complementaryInformations;
            LoadDatas();
        }

        private void LoadDatas()
        {
            lb_List.DataSource = null;
            lb_List.DataSource = this._complementaryInformations;
        }

        public List<ComplementaryInformation> GetDatas()
        {
            return this._complementaryInformations;
        }

        private void Reset()
        {
            tb_ThemeName.Clear();
            tb_Content.Clear();
        }

        private ComplementaryInformation Get()
        {
            return new ComplementaryInformation(tb_ThemeName.Text)
            {
                Content = this.tb_Content.Text.Trim().Split(Environment.NewLine).ToList()
            };
        }

        private void Show(ComplementaryInformation complementaryInformation)
        {
            tb_ThemeName.Text = complementaryInformation.ThemeName;
            tb_Content.Clear();
            foreach (var item in complementaryInformation.Content)
            {
                tb_Content.Text += item + Environment.NewLine;
            }
        }

        private void lb_List_Click(object sender, EventArgs e)
        {
            if (lb_List.SelectedIndex == -1) return;

            var complementaryInformation = lb_List.SelectedItem as ComplementaryInformation;
            Show(complementaryInformation);
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
            var newComplementaryInformation = Get();
            this._complementaryInformations.Add(newComplementaryInformation);
            this.LoadDatas();
            Reset();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (lb_List.SelectedIndex == -1)
                return;

            var ComplementaryInformation = Get();
            this._complementaryInformations[lb_List.SelectedIndex] = ComplementaryInformation;
            this.LoadDatas();
            Reset();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Reset();
            if (lb_List.SelectedIndex == -1)
                return;

            this._complementaryInformations.RemoveAt(lb_List.SelectedIndex);
            LoadDatas();
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            var index = lb_List.SelectedIndex;
            if (index <= 0)
                return;

            _complementaryInformations.Swap(index, index - 1);
            LoadDatas();
            lb_List.SelectedIndex = index - 1;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var index = lb_List.SelectedIndex;
            if (index >= _complementaryInformations.Count - 1)
                return;

            _complementaryInformations.Swap(index, index + 1);
            LoadDatas();
            lb_List.SelectedIndex = index + 1;
        }
    }
}
