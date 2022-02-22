
namespace IHM
{
    partial class ComplementaryInformationForm
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
            this.gb_Item = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tb_Content = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ThemeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_List = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lb_List = new System.Windows.Forms.ListBox();
            this.btn_SaveAndClose = new System.Windows.Forms.Button();
            this.gb_Item.SuspendLayout();
            this.gb_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Item
            // 
            this.gb_Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Item.Controls.Add(this.btn_Reset);
            this.gb_Item.Controls.Add(this.tb_Content);
            this.gb_Item.Controls.Add(this.label2);
            this.gb_Item.Controls.Add(this.tb_ThemeName);
            this.gb_Item.Controls.Add(this.label1);
            this.gb_Item.Location = new System.Drawing.Point(12, 12);
            this.gb_Item.Name = "gb_Item";
            this.gb_Item.Size = new System.Drawing.Size(370, 209);
            this.gb_Item.TabIndex = 0;
            this.gb_Item.TabStop = false;
            this.gb_Item.Text = "Information additionnelle";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Reset.Location = new System.Drawing.Point(129, 180);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Nettoyer";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // tb_Content
            // 
            this.tb_Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Content.Location = new System.Drawing.Point(129, 54);
            this.tb_Content.Multiline = true;
            this.tb_Content.Name = "tb_Content";
            this.tb_Content.Size = new System.Drawing.Size(235, 120);
            this.tb_Content.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contenu :";
            // 
            // tb_ThemeName
            // 
            this.tb_ThemeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ThemeName.Location = new System.Drawing.Point(129, 25);
            this.tb_ThemeName.Name = "tb_ThemeName";
            this.tb_ThemeName.Size = new System.Drawing.Size(235, 23);
            this.tb_ThemeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thème :";
            // 
            // gb_List
            // 
            this.gb_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_List.Controls.Add(this.btnDown);
            this.gb_List.Controls.Add(this.btn_Up);
            this.gb_List.Controls.Add(this.btn_Delete);
            this.gb_List.Controls.Add(this.btn_Update);
            this.gb_List.Controls.Add(this.btn_Add);
            this.gb_List.Controls.Add(this.lb_List);
            this.gb_List.Location = new System.Drawing.Point(388, 12);
            this.gb_List.Name = "gb_List";
            this.gb_List.Size = new System.Drawing.Size(370, 209);
            this.gb_List.TabIndex = 2;
            this.gb_List.TabStop = false;
            this.gb_List.Text = "Liste";
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Location = new System.Drawing.Point(289, 168);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 42;
            this.btnDown.Text = "Baisser";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Up.Location = new System.Drawing.Point(289, 139);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(75, 23);
            this.btn_Up.TabIndex = 43;
            this.btn_Up.Text = "Monter";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Location = new System.Drawing.Point(289, 82);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 44;
            this.btn_Delete.Text = "Supprimer";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.Location = new System.Drawing.Point(289, 53);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 41;
            this.btn_Update.Text = "Modifier";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Location = new System.Drawing.Point(289, 24);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 40;
            this.btn_Add.Text = "Ajouter";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_List
            // 
            this.lb_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_List.FormattingEnabled = true;
            this.lb_List.ItemHeight = 15;
            this.lb_List.Location = new System.Drawing.Point(17, 22);
            this.lb_List.Name = "lb_List";
            this.lb_List.Size = new System.Drawing.Size(266, 169);
            this.lb_List.TabIndex = 11;
            this.lb_List.Click += new System.EventHandler(this.lb_List_Click);
            // 
            // btn_SaveAndClose
            // 
            this.btn_SaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveAndClose.Location = new System.Drawing.Point(638, 231);
            this.btn_SaveAndClose.Name = "btn_SaveAndClose";
            this.btn_SaveAndClose.Size = new System.Drawing.Size(150, 23);
            this.btn_SaveAndClose.TabIndex = 101;
            this.btn_SaveAndClose.Text = "Sauvegarder et fermer";
            this.btn_SaveAndClose.UseVisualStyleBackColor = true;
            this.btn_SaveAndClose.Click += new System.EventHandler(this.btn_SaveAndClose_Click);
            // 
            // ComplementaryInformationForm
            // 
            this.AcceptButton = this.btn_SaveAndClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.btn_SaveAndClose);
            this.Controls.Add(this.gb_List);
            this.Controls.Add(this.gb_Item);
            this.MaximumSize = new System.Drawing.Size(816, 305);
            this.MinimizeBox = false;
            this.Name = "ComplementaryInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informations additionnelles";
            this.gb_Item.ResumeLayout(false);
            this.gb_Item.PerformLayout();
            this.gb_List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Item;
        private System.Windows.Forms.TextBox tb_Content;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ThemeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_List;
        private System.Windows.Forms.ListBox lb_List;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_SaveAndClose;
        private System.Windows.Forms.Button btn_Reset;
    }
}