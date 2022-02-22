
namespace IHM
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_UpdateAdministrativesDatas = new System.Windows.Forms.Button();
            this.gb_Actions = new System.Windows.Forms.GroupBox();
            this.btn_UpdateComplementaryInformation = new System.Windows.Forms.Button();
            this.btn_UpdateSkills = new System.Windows.Forms.Button();
            this.btn_UpdateLearnings = new System.Windows.Forms.Button();
            this.btn_UpdateProfessionalExperiences = new System.Windows.Forms.Button();
            this.gb_SaveAndLoad = new System.Windows.Forms.GroupBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_SaveFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Generation = new System.Windows.Forms.GroupBox();
            this.btn_WordGeneration = new System.Windows.Forms.Button();
            this.tb_GenerationFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_Actions.SuspendLayout();
            this.gb_SaveAndLoad.SuspendLayout();
            this.gb_Generation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_UpdateAdministrativesDatas
            // 
            this.btn_UpdateAdministrativesDatas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateAdministrativesDatas.Location = new System.Drawing.Point(6, 22);
            this.btn_UpdateAdministrativesDatas.Name = "btn_UpdateAdministrativesDatas";
            this.btn_UpdateAdministrativesDatas.Size = new System.Drawing.Size(471, 23);
            this.btn_UpdateAdministrativesDatas.TabIndex = 0;
            this.btn_UpdateAdministrativesDatas.Text = "Modifier les informations administratives";
            this.btn_UpdateAdministrativesDatas.UseVisualStyleBackColor = true;
            this.btn_UpdateAdministrativesDatas.Click += new System.EventHandler(this.btn_UpdateAdministrativesDatas_Click);
            // 
            // gb_Actions
            // 
            this.gb_Actions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Actions.Controls.Add(this.btn_UpdateComplementaryInformation);
            this.gb_Actions.Controls.Add(this.btn_UpdateSkills);
            this.gb_Actions.Controls.Add(this.btn_UpdateLearnings);
            this.gb_Actions.Controls.Add(this.btn_UpdateProfessionalExperiences);
            this.gb_Actions.Controls.Add(this.btn_UpdateAdministrativesDatas);
            this.gb_Actions.Location = new System.Drawing.Point(12, 12);
            this.gb_Actions.Name = "gb_Actions";
            this.gb_Actions.Size = new System.Drawing.Size(483, 166);
            this.gb_Actions.TabIndex = 1;
            this.gb_Actions.TabStop = false;
            this.gb_Actions.Text = "Actions";
            // 
            // btn_UpdateComplementaryInformation
            // 
            this.btn_UpdateComplementaryInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateComplementaryInformation.Location = new System.Drawing.Point(6, 137);
            this.btn_UpdateComplementaryInformation.Name = "btn_UpdateComplementaryInformation";
            this.btn_UpdateComplementaryInformation.Size = new System.Drawing.Size(471, 23);
            this.btn_UpdateComplementaryInformation.TabIndex = 4;
            this.btn_UpdateComplementaryInformation.Text = "Modifier les informations complémentaires";
            this.btn_UpdateComplementaryInformation.UseVisualStyleBackColor = true;
            this.btn_UpdateComplementaryInformation.Click += new System.EventHandler(this.btn_UpdateComplementaryInformation_Click);
            // 
            // btn_UpdateSkills
            // 
            this.btn_UpdateSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateSkills.Location = new System.Drawing.Point(6, 109);
            this.btn_UpdateSkills.Name = "btn_UpdateSkills";
            this.btn_UpdateSkills.Size = new System.Drawing.Size(471, 23);
            this.btn_UpdateSkills.TabIndex = 3;
            this.btn_UpdateSkills.Text = "Modifier les compétences informatiques";
            this.btn_UpdateSkills.UseVisualStyleBackColor = true;
            this.btn_UpdateSkills.Click += new System.EventHandler(this.btn_UpdateSkills_Click);
            // 
            // btn_UpdateLearnings
            // 
            this.btn_UpdateLearnings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateLearnings.Location = new System.Drawing.Point(6, 80);
            this.btn_UpdateLearnings.Name = "btn_UpdateLearnings";
            this.btn_UpdateLearnings.Size = new System.Drawing.Size(471, 23);
            this.btn_UpdateLearnings.TabIndex = 2;
            this.btn_UpdateLearnings.Text = "Modifier les formations";
            this.btn_UpdateLearnings.UseVisualStyleBackColor = true;
            this.btn_UpdateLearnings.Click += new System.EventHandler(this.btn_UpdateLearnings_Click);
            // 
            // btn_UpdateProfessionalExperiences
            // 
            this.btn_UpdateProfessionalExperiences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateProfessionalExperiences.Location = new System.Drawing.Point(6, 51);
            this.btn_UpdateProfessionalExperiences.Name = "btn_UpdateProfessionalExperiences";
            this.btn_UpdateProfessionalExperiences.Size = new System.Drawing.Size(471, 23);
            this.btn_UpdateProfessionalExperiences.TabIndex = 1;
            this.btn_UpdateProfessionalExperiences.Text = "Modifier les expériences professionnelles";
            this.btn_UpdateProfessionalExperiences.UseVisualStyleBackColor = true;
            this.btn_UpdateProfessionalExperiences.Click += new System.EventHandler(this.btn_UpdateProfessionalExperiences_Click);
            // 
            // gb_SaveAndLoad
            // 
            this.gb_SaveAndLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SaveAndLoad.Controls.Add(this.btn_Load);
            this.gb_SaveAndLoad.Controls.Add(this.btn_Save);
            this.gb_SaveAndLoad.Controls.Add(this.tb_SaveFilePath);
            this.gb_SaveAndLoad.Controls.Add(this.label1);
            this.gb_SaveAndLoad.Location = new System.Drawing.Point(12, 202);
            this.gb_SaveAndLoad.Name = "gb_SaveAndLoad";
            this.gb_SaveAndLoad.Size = new System.Drawing.Size(483, 111);
            this.gb_SaveAndLoad.TabIndex = 20;
            this.gb_SaveAndLoad.TabStop = false;
            this.gb_SaveAndLoad.Text = "Sauvegarde && chargement";
            // 
            // btn_Load
            // 
            this.btn_Load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Load.Location = new System.Drawing.Point(6, 77);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(471, 23);
            this.btn_Load.TabIndex = 23;
            this.btn_Load.Text = "Charger";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(6, 48);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(471, 23);
            this.btn_Save.TabIndex = 22;
            this.btn_Save.Text = "Sauvegarder";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_SaveFilePath
            // 
            this.tb_SaveFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SaveFilePath.Location = new System.Drawing.Point(161, 19);
            this.tb_SaveFilePath.Name = "tb_SaveFilePath";
            this.tb_SaveFilePath.Size = new System.Drawing.Size(316, 23);
            this.tb_SaveFilePath.TabIndex = 21;
            this.tb_SaveFilePath.Text = "C:/cv.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chemin et nom du fichier :";
            // 
            // gb_Generation
            // 
            this.gb_Generation.Controls.Add(this.btn_WordGeneration);
            this.gb_Generation.Controls.Add(this.tb_GenerationFilePath);
            this.gb_Generation.Controls.Add(this.label2);
            this.gb_Generation.Location = new System.Drawing.Point(12, 343);
            this.gb_Generation.Name = "gb_Generation";
            this.gb_Generation.Size = new System.Drawing.Size(483, 85);
            this.gb_Generation.TabIndex = 30;
            this.gb_Generation.TabStop = false;
            this.gb_Generation.Text = "Génération de fichier";
            // 
            // btn_WordGeneration
            // 
            this.btn_WordGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WordGeneration.Location = new System.Drawing.Point(6, 51);
            this.btn_WordGeneration.Name = "btn_WordGeneration";
            this.btn_WordGeneration.Size = new System.Drawing.Size(471, 23);
            this.btn_WordGeneration.TabIndex = 32;
            this.btn_WordGeneration.Text = "Document Word";
            this.btn_WordGeneration.UseVisualStyleBackColor = true;
            this.btn_WordGeneration.Click += new System.EventHandler(this.btn_WordGeneration_Click);
            // 
            // tb_GenerationFilePath
            // 
            this.tb_GenerationFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_GenerationFilePath.Location = new System.Drawing.Point(161, 22);
            this.tb_GenerationFilePath.Name = "tb_GenerationFilePath";
            this.tb_GenerationFilePath.Size = new System.Drawing.Size(316, 23);
            this.tb_GenerationFilePath.TabIndex = 21;
            this.tb_GenerationFilePath.Text = "C:/exempleWord.docx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chemin et nom du fichier :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 440);
            this.Controls.Add(this.gb_Generation);
            this.Controls.Add(this.gb_SaveAndLoad);
            this.Controls.Add(this.gb_Actions);
            this.Name = "MainForm";
            this.Text = "Menu principal";
            this.gb_Actions.ResumeLayout(false);
            this.gb_SaveAndLoad.ResumeLayout(false);
            this.gb_SaveAndLoad.PerformLayout();
            this.gb_Generation.ResumeLayout(false);
            this.gb_Generation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_UpdateAdministrativesDatas;
        private System.Windows.Forms.GroupBox gb_Actions;
        private System.Windows.Forms.GroupBox gb_SaveAndLoad;
        private System.Windows.Forms.TextBox tb_SaveFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_UpdateProfessionalExperiences;
        private System.Windows.Forms.Button btn_UpdateLearnings;
        private System.Windows.Forms.Button btn_UpdateComplementaryInformation;
        private System.Windows.Forms.Button btn_UpdateSkills;
        private System.Windows.Forms.GroupBox gb_Generation;
        private System.Windows.Forms.Button btn_WordGeneration;
        private System.Windows.Forms.TextBox tb_GenerationFilePath;
        private System.Windows.Forms.Label label2;
    }
}

