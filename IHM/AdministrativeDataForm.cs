using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Objects;

namespace IHM
{
    public partial class AdministrativeDataForm : Form
    {
        public AdministrativeDataForm(AdministrativeDatas datas)
        {
            InitializeComponent();
            LoadDatas(datas);
        }

        public AdministrativeDatas GetDatas()
        {
            bool? vehiculeOwner = null;
            if (rb_Vehicule_Yes.Checked)
                vehiculeOwner = true;
            else if(rb_Vehicule_No.Checked)
                vehiculeOwner = false;

            return new AdministrativeDatas()
            {
                JobName = this.tb_CvTitle.Text,
                Description = this.tb_Description.Text,
                LastName = this.tb_LastName.Text,
                FirstName = this.tb_FirstName.Text,
                Adresse = this.tb_Address.Text,
                City = this.tb_City.Text,
                PhoneNumber = this.tb_PhoneNumber.Text,
                EmailAdress = this.tb_EmailAddress.Text,
                LicenseDriver = this.tb_LicencesDriver.Text.Trim().Split(Environment.NewLine).ToList(),
                BirthDate = this.dtp_BirthDate.Value,
                IsVehiculeOwner = vehiculeOwner
            };
        }

        private void LoadDatas(AdministrativeDatas datas)
        {
            this.tb_CvTitle.Text = datas.JobName;
            this.tb_Description.Text = datas.Description;
            this.tb_LastName.Text = datas.LastName;
            this.tb_FirstName.Text = datas.FirstName;
            this.tb_Address.Text = datas.Adresse;
            this.tb_City.Text = datas.City;
            this.tb_PhoneNumber.Text = datas.PhoneNumber;
            this.tb_EmailAddress.Text = datas.EmailAdress;
            foreach (var licence in datas.LicenseDriver)
            {
                this.tb_LicencesDriver.Text += licence + Environment.NewLine;
            }

            if (datas.IsVehiculeOwner.HasValue)
            {
                rb_Vehicule_Yes.Checked = datas.IsVehiculeOwner.Value;
                rb_Vehicule_No.Checked = !datas.IsVehiculeOwner.Value;
            }
            else
                rb_Vehicule_NotSpecified.Checked = true;

            if (datas.BirthDate.HasValue)
                this.dtp_BirthDate.Value = datas.BirthDate.Value;
            else
                this.dtp_BirthDate.Value = DateTime.Today;
        }

        private void btn_SaveAndClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
