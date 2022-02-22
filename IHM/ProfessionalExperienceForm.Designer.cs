
namespace IHM
{
    partial class ProfessionalExperienceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SaveAndClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Item = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cb_IsDevelopperJob = new System.Windows.Forms.CheckBox();
            this.tb_Missions = new System.Windows.Forms.TextBox();
            this.tb_ContractType = new System.Windows.Forms.TextBox();
            this.tb_CompanyCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_CompanyName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_DurationLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_DateStart = new System.Windows.Forms.DateTimePicker();
            this.lb_List = new System.Windows.Forms.ListBox();
            this.gb_List = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.gb_Item.SuspendLayout();
            this.gb_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SaveAndClose
            // 
            this.btn_SaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveAndClose.Location = new System.Drawing.Point(875, 369);
            this.btn_SaveAndClose.Name = "btn_SaveAndClose";
            this.btn_SaveAndClose.Size = new System.Drawing.Size(150, 23);
            this.btn_SaveAndClose.TabIndex = 99;
            this.btn_SaveAndClose.Text = "Sauvegarder et fermer";
            this.btn_SaveAndClose.UseVisualStyleBackColor = true;
            this.btn_SaveAndClose.Click += new System.EventHandler(this.btn_SaveAndClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date de début :";
            // 
            // gb_Item
            // 
            this.gb_Item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Item.Controls.Add(this.btn_Reset);
            this.gb_Item.Controls.Add(this.cb_IsDevelopperJob);
            this.gb_Item.Controls.Add(this.tb_Missions);
            this.gb_Item.Controls.Add(this.tb_ContractType);
            this.gb_Item.Controls.Add(this.tb_CompanyCity);
            this.gb_Item.Controls.Add(this.label8);
            this.gb_Item.Controls.Add(this.label7);
            this.gb_Item.Controls.Add(this.label9);
            this.gb_Item.Controls.Add(this.tb_CompanyName);
            this.gb_Item.Controls.Add(this.label6);
            this.gb_Item.Controls.Add(this.tb_Name);
            this.gb_Item.Controls.Add(this.label5);
            this.gb_Item.Controls.Add(this.tb_DurationLength);
            this.gb_Item.Controls.Add(this.label4);
            this.gb_Item.Controls.Add(this.dtp_DateEnd);
            this.gb_Item.Controls.Add(this.label3);
            this.gb_Item.Controls.Add(this.label2);
            this.gb_Item.Controls.Add(this.dtp_DateStart);
            this.gb_Item.Controls.Add(this.label1);
            this.gb_Item.Location = new System.Drawing.Point(12, 12);
            this.gb_Item.Name = "gb_Item";
            this.gb_Item.Size = new System.Drawing.Size(550, 360);
            this.gb_Item.TabIndex = 10;
            this.gb_Item.TabStop = false;
            this.gb_Item.Text = "Expérience professionnelle";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.Location = new System.Drawing.Point(159, 324);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 20;
            this.btn_Reset.Text = "Nettoyer";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // cb_IsDevelopperJob
            // 
            this.cb_IsDevelopperJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_IsDevelopperJob.AutoSize = true;
            this.cb_IsDevelopperJob.Checked = true;
            this.cb_IsDevelopperJob.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_IsDevelopperJob.Location = new System.Drawing.Point(159, 299);
            this.cb_IsDevelopperJob.Name = "cb_IsDevelopperJob";
            this.cb_IsDevelopperJob.Size = new System.Drawing.Size(15, 14);
            this.cb_IsDevelopperJob.TabIndex = 19;
            this.cb_IsDevelopperJob.UseVisualStyleBackColor = true;
            // 
            // tb_Missions
            // 
            this.tb_Missions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Missions.Location = new System.Drawing.Point(158, 229);
            this.tb_Missions.Multiline = true;
            this.tb_Missions.Name = "tb_Missions";
            this.tb_Missions.Size = new System.Drawing.Size(386, 64);
            this.tb_Missions.TabIndex = 18;
            // 
            // tb_ContractType
            // 
            this.tb_ContractType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ContractType.Location = new System.Drawing.Point(159, 200);
            this.tb_ContractType.Name = "tb_ContractType";
            this.tb_ContractType.Size = new System.Drawing.Size(386, 23);
            this.tb_ContractType.TabIndex = 17;
            // 
            // tb_CompanyCity
            // 
            this.tb_CompanyCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_CompanyCity.Location = new System.Drawing.Point(159, 171);
            this.tb_CompanyCity.Name = "tb_CompanyCity";
            this.tb_CompanyCity.Size = new System.Drawing.Size(386, 23);
            this.tb_CompanyCity.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Job de développeur :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Missions confiées :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Type de contrat :";
            // 
            // tb_CompanyName
            // 
            this.tb_CompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_CompanyName.Location = new System.Drawing.Point(158, 142);
            this.tb_CompanyName.Name = "tb_CompanyName";
            this.tb_CompanyName.Size = new System.Drawing.Size(386, 23);
            this.tb_CompanyName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ville de l\'entreprise :";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Location = new System.Drawing.Point(158, 113);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(386, 23);
            this.tb_Name.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nom de l\'entreprise :";
            // 
            // tb_DurationLength
            // 
            this.tb_DurationLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_DurationLength.Location = new System.Drawing.Point(158, 84);
            this.tb_DurationLength.Name = "tb_DurationLength";
            this.tb_DurationLength.Size = new System.Drawing.Size(386, 23);
            this.tb_DurationLength.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Intitulé du poste :";
            // 
            // dtp_DateEnd
            // 
            this.dtp_DateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DateEnd.Location = new System.Drawing.Point(158, 55);
            this.dtp_DateEnd.Name = "dtp_DateEnd";
            this.dtp_DateEnd.Size = new System.Drawing.Size(386, 23);
            this.dtp_DateEnd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Durée :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date de fin :";
            // 
            // dtp_DateStart
            // 
            this.dtp_DateStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DateStart.Location = new System.Drawing.Point(158, 26);
            this.dtp_DateStart.Name = "dtp_DateStart";
            this.dtp_DateStart.Size = new System.Drawing.Size(386, 23);
            this.dtp_DateStart.TabIndex = 11;
            // 
            // lb_List
            // 
            this.lb_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_List.FormattingEnabled = true;
            this.lb_List.ItemHeight = 15;
            this.lb_List.Location = new System.Drawing.Point(19, 22);
            this.lb_List.Name = "lb_List";
            this.lb_List.Size = new System.Drawing.Size(351, 259);
            this.lb_List.TabIndex = 31;
            this.lb_List.Click += new System.EventHandler(this.lb_List_Click);
            // 
            // gb_List
            // 
            this.gb_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_List.Controls.Add(this.btnDown);
            this.gb_List.Controls.Add(this.btn_Up);
            this.gb_List.Controls.Add(this.btn_Delete);
            this.gb_List.Controls.Add(this.btn_Update);
            this.gb_List.Controls.Add(this.btn_Add);
            this.gb_List.Controls.Add(this.lb_List);
            this.gb_List.Location = new System.Drawing.Point(568, 12);
            this.gb_List.Name = "gb_List";
            this.gb_List.Size = new System.Drawing.Size(457, 310);
            this.gb_List.TabIndex = 30;
            this.gb_List.TabStop = false;
            this.gb_List.Text = "Liste";
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(376, 166);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 34;
            this.btnDown.Text = "Baisser";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Up.Location = new System.Drawing.Point(376, 137);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(75, 23);
            this.btn_Up.TabIndex = 34;
            this.btn_Up.Text = "Monter";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Location = new System.Drawing.Point(376, 80);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 34;
            this.btn_Delete.Text = "Supprimer";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Location = new System.Drawing.Point(376, 51);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 33;
            this.btn_Update.Text = "Modifier";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Location = new System.Drawing.Point(376, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 32;
            this.btn_Add.Text = "Ajouter";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ProfessionalExperienceForm
            // 
            this.AcceptButton = this.btn_SaveAndClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 404);
            this.Controls.Add(this.gb_List);
            this.Controls.Add(this.gb_Item);
            this.Controls.Add(this.btn_SaveAndClose);
            this.MaximumSize = new System.Drawing.Size(1053, 443);
            this.MinimizeBox = false;
            this.Name = "ProfessionalExperienceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expériences professionnelles";
            this.gb_Item.ResumeLayout(false);
            this.gb_Item.PerformLayout();
            this.gb_List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveAndClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Item;
        private System.Windows.Forms.CheckBox cb_IsDevelopperJob;
        private System.Windows.Forms.TextBox tb_Missions;
        private System.Windows.Forms.TextBox tb_CompanyCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_CompanyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_DurationLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_DateEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_DateStart;
        private System.Windows.Forms.ListBox lb_List;
        private System.Windows.Forms.GroupBox gb_List;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox tb_ContractType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btn_Up;
    }
}