﻿namespace Empires.forms
{
    partial class EditPackage
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
            this.tc_PackageEditor = new System.Windows.Forms.TabControl();
            this.tp_PackageDetails = new System.Windows.Forms.TabPage();
            this.tb_PackageID = new System.Windows.Forms.TextBox();
            this.tb_PackageVersion = new System.Windows.Forms.TextBox();
            this.tb_PackageAuthor = new System.Windows.Forms.TextBox();
            this.tb_PackageName = new System.Windows.Forms.TextBox();
            this.lbl_PackageAuthor = new System.Windows.Forms.Label();
            this.lbl_PackageVersion = new System.Windows.Forms.Label();
            this.lbl_PackageID = new System.Windows.Forms.Label();
            this.lbl_PackageName = new System.Windows.Forms.Label();
            this.tp_Materials = new System.Windows.Forms.TabPage();
            this.tb_GenerateInPlanets = new System.Windows.Forms.TextBox();
            this.tb_GenerateInPlanetsAmount = new System.Windows.Forms.TextBox();
            this.tb_GenerateInStars = new System.Windows.Forms.TextBox();
            this.tb_GenerateInStarsAmount = new System.Windows.Forms.TextBox();
            this.tb_MaterialName = new System.Windows.Forms.TextBox();
            this.lbl_GenerateInPlanets = new System.Windows.Forms.Label();
            this.lbl_GenerateInPlanetsAmount = new System.Windows.Forms.Label();
            this.lbl_GenerateInStars = new System.Windows.Forms.Label();
            this.lbl_GenerateInStarsAmount = new System.Windows.Forms.Label();
            this.lbl_MaterialName = new System.Windows.Forms.Label();
            this.lb_Materials = new System.Windows.Forms.ListBox();
            this.btn_SavePackage = new System.Windows.Forms.Button();
            this.btn_DeleteMaterial = new System.Windows.Forms.Button();
            this.btn_SaveMaterial = new System.Windows.Forms.Button();
            this.btn_NewMaterial = new System.Windows.Forms.Button();
            this.tc_PackageEditor.SuspendLayout();
            this.tp_PackageDetails.SuspendLayout();
            this.tp_Materials.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_PackageEditor
            // 
            this.tc_PackageEditor.Controls.Add(this.tp_PackageDetails);
            this.tc_PackageEditor.Controls.Add(this.tp_Materials);
            this.tc_PackageEditor.Location = new System.Drawing.Point(13, 13);
            this.tc_PackageEditor.Name = "tc_PackageEditor";
            this.tc_PackageEditor.SelectedIndex = 0;
            this.tc_PackageEditor.Size = new System.Drawing.Size(759, 507);
            this.tc_PackageEditor.TabIndex = 0;
            // 
            // tp_PackageDetails
            // 
            this.tp_PackageDetails.Controls.Add(this.tb_PackageID);
            this.tp_PackageDetails.Controls.Add(this.tb_PackageVersion);
            this.tp_PackageDetails.Controls.Add(this.tb_PackageAuthor);
            this.tp_PackageDetails.Controls.Add(this.tb_PackageName);
            this.tp_PackageDetails.Controls.Add(this.lbl_PackageAuthor);
            this.tp_PackageDetails.Controls.Add(this.lbl_PackageVersion);
            this.tp_PackageDetails.Controls.Add(this.lbl_PackageID);
            this.tp_PackageDetails.Controls.Add(this.lbl_PackageName);
            this.tp_PackageDetails.Location = new System.Drawing.Point(4, 22);
            this.tp_PackageDetails.Name = "tp_PackageDetails";
            this.tp_PackageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tp_PackageDetails.Size = new System.Drawing.Size(751, 481);
            this.tp_PackageDetails.TabIndex = 0;
            this.tp_PackageDetails.Text = "Package Details";
            this.tp_PackageDetails.UseVisualStyleBackColor = true;
            // 
            // tb_PackageID
            // 
            this.tb_PackageID.Location = new System.Drawing.Point(100, 85);
            this.tb_PackageID.Name = "tb_PackageID";
            this.tb_PackageID.Size = new System.Drawing.Size(645, 20);
            this.tb_PackageID.TabIndex = 23;
            // 
            // tb_PackageVersion
            // 
            this.tb_PackageVersion.Location = new System.Drawing.Point(100, 59);
            this.tb_PackageVersion.Name = "tb_PackageVersion";
            this.tb_PackageVersion.Size = new System.Drawing.Size(645, 20);
            this.tb_PackageVersion.TabIndex = 22;
            // 
            // tb_PackageAuthor
            // 
            this.tb_PackageAuthor.Location = new System.Drawing.Point(100, 33);
            this.tb_PackageAuthor.Name = "tb_PackageAuthor";
            this.tb_PackageAuthor.Size = new System.Drawing.Size(645, 20);
            this.tb_PackageAuthor.TabIndex = 21;
            // 
            // tb_PackageName
            // 
            this.tb_PackageName.Location = new System.Drawing.Point(100, 7);
            this.tb_PackageName.Name = "tb_PackageName";
            this.tb_PackageName.Size = new System.Drawing.Size(645, 20);
            this.tb_PackageName.TabIndex = 20;
            // 
            // lbl_PackageAuthor
            // 
            this.lbl_PackageAuthor.AutoSize = true;
            this.lbl_PackageAuthor.Location = new System.Drawing.Point(6, 36);
            this.lbl_PackageAuthor.Name = "lbl_PackageAuthor";
            this.lbl_PackageAuthor.Size = new System.Drawing.Size(84, 13);
            this.lbl_PackageAuthor.TabIndex = 19;
            this.lbl_PackageAuthor.Text = "Package Author";
            // 
            // lbl_PackageVersion
            // 
            this.lbl_PackageVersion.AutoSize = true;
            this.lbl_PackageVersion.Location = new System.Drawing.Point(6, 62);
            this.lbl_PackageVersion.Name = "lbl_PackageVersion";
            this.lbl_PackageVersion.Size = new System.Drawing.Size(88, 13);
            this.lbl_PackageVersion.TabIndex = 17;
            this.lbl_PackageVersion.Text = "Package Version";
            // 
            // lbl_PackageID
            // 
            this.lbl_PackageID.AutoSize = true;
            this.lbl_PackageID.Location = new System.Drawing.Point(6, 88);
            this.lbl_PackageID.Name = "lbl_PackageID";
            this.lbl_PackageID.Size = new System.Drawing.Size(64, 13);
            this.lbl_PackageID.TabIndex = 15;
            this.lbl_PackageID.Text = "Package ID";
            // 
            // lbl_PackageName
            // 
            this.lbl_PackageName.AutoSize = true;
            this.lbl_PackageName.Location = new System.Drawing.Point(6, 10);
            this.lbl_PackageName.Name = "lbl_PackageName";
            this.lbl_PackageName.Size = new System.Drawing.Size(81, 13);
            this.lbl_PackageName.TabIndex = 12;
            this.lbl_PackageName.Text = "Package Name";
            // 
            // tp_Materials
            // 
            this.tp_Materials.Controls.Add(this.btn_NewMaterial);
            this.tp_Materials.Controls.Add(this.btn_SaveMaterial);
            this.tp_Materials.Controls.Add(this.btn_DeleteMaterial);
            this.tp_Materials.Controls.Add(this.tb_GenerateInPlanets);
            this.tp_Materials.Controls.Add(this.tb_GenerateInPlanetsAmount);
            this.tp_Materials.Controls.Add(this.tb_GenerateInStars);
            this.tp_Materials.Controls.Add(this.tb_GenerateInStarsAmount);
            this.tp_Materials.Controls.Add(this.tb_MaterialName);
            this.tp_Materials.Controls.Add(this.lbl_GenerateInPlanets);
            this.tp_Materials.Controls.Add(this.lbl_GenerateInPlanetsAmount);
            this.tp_Materials.Controls.Add(this.lbl_GenerateInStars);
            this.tp_Materials.Controls.Add(this.lbl_GenerateInStarsAmount);
            this.tp_Materials.Controls.Add(this.lbl_MaterialName);
            this.tp_Materials.Controls.Add(this.lb_Materials);
            this.tp_Materials.Location = new System.Drawing.Point(4, 22);
            this.tp_Materials.Name = "tp_Materials";
            this.tp_Materials.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Materials.Size = new System.Drawing.Size(751, 481);
            this.tp_Materials.TabIndex = 1;
            this.tp_Materials.Text = "Materials";
            this.tp_Materials.UseVisualStyleBackColor = true;
            // 
            // tb_GenerateInPlanets
            // 
            this.tb_GenerateInPlanets.Location = new System.Drawing.Point(373, 32);
            this.tb_GenerateInPlanets.Name = "tb_GenerateInPlanets";
            this.tb_GenerateInPlanets.Size = new System.Drawing.Size(372, 20);
            this.tb_GenerateInPlanets.TabIndex = 12;
            // 
            // tb_GenerateInPlanetsAmount
            // 
            this.tb_GenerateInPlanetsAmount.Location = new System.Drawing.Point(373, 58);
            this.tb_GenerateInPlanetsAmount.Name = "tb_GenerateInPlanetsAmount";
            this.tb_GenerateInPlanetsAmount.Size = new System.Drawing.Size(372, 20);
            this.tb_GenerateInPlanetsAmount.TabIndex = 11;
            // 
            // tb_GenerateInStars
            // 
            this.tb_GenerateInStars.Location = new System.Drawing.Point(373, 84);
            this.tb_GenerateInStars.Name = "tb_GenerateInStars";
            this.tb_GenerateInStars.Size = new System.Drawing.Size(372, 20);
            this.tb_GenerateInStars.TabIndex = 10;
            // 
            // tb_GenerateInStarsAmount
            // 
            this.tb_GenerateInStarsAmount.Location = new System.Drawing.Point(373, 110);
            this.tb_GenerateInStarsAmount.Name = "tb_GenerateInStarsAmount";
            this.tb_GenerateInStarsAmount.Size = new System.Drawing.Size(372, 20);
            this.tb_GenerateInStarsAmount.TabIndex = 9;
            // 
            // tb_MaterialName
            // 
            this.tb_MaterialName.Location = new System.Drawing.Point(373, 6);
            this.tb_MaterialName.Name = "tb_MaterialName";
            this.tb_MaterialName.Size = new System.Drawing.Size(372, 20);
            this.tb_MaterialName.TabIndex = 7;
            // 
            // lbl_GenerateInPlanets
            // 
            this.lbl_GenerateInPlanets.AutoSize = true;
            this.lbl_GenerateInPlanets.Location = new System.Drawing.Point(227, 35);
            this.lbl_GenerateInPlanets.Name = "lbl_GenerateInPlanets";
            this.lbl_GenerateInPlanets.Size = new System.Drawing.Size(101, 13);
            this.lbl_GenerateInPlanets.TabIndex = 6;
            this.lbl_GenerateInPlanets.Text = "Generate In Planets";
            // 
            // lbl_GenerateInPlanetsAmount
            // 
            this.lbl_GenerateInPlanetsAmount.AutoSize = true;
            this.lbl_GenerateInPlanetsAmount.Location = new System.Drawing.Point(227, 61);
            this.lbl_GenerateInPlanetsAmount.Name = "lbl_GenerateInPlanetsAmount";
            this.lbl_GenerateInPlanetsAmount.Size = new System.Drawing.Size(140, 13);
            this.lbl_GenerateInPlanetsAmount.TabIndex = 4;
            this.lbl_GenerateInPlanetsAmount.Text = "Generate In Planets Amount";
            // 
            // lbl_GenerateInStars
            // 
            this.lbl_GenerateInStars.AutoSize = true;
            this.lbl_GenerateInStars.Location = new System.Drawing.Point(227, 87);
            this.lbl_GenerateInStars.Name = "lbl_GenerateInStars";
            this.lbl_GenerateInStars.Size = new System.Drawing.Size(90, 13);
            this.lbl_GenerateInStars.TabIndex = 3;
            this.lbl_GenerateInStars.Text = "Generate In Stars";
            // 
            // lbl_GenerateInStarsAmount
            // 
            this.lbl_GenerateInStarsAmount.AutoSize = true;
            this.lbl_GenerateInStarsAmount.Location = new System.Drawing.Point(227, 113);
            this.lbl_GenerateInStarsAmount.Name = "lbl_GenerateInStarsAmount";
            this.lbl_GenerateInStarsAmount.Size = new System.Drawing.Size(129, 13);
            this.lbl_GenerateInStarsAmount.TabIndex = 2;
            this.lbl_GenerateInStarsAmount.Text = "Generate In Stars Amount";
            // 
            // lbl_MaterialName
            // 
            this.lbl_MaterialName.AutoSize = true;
            this.lbl_MaterialName.Location = new System.Drawing.Point(227, 9);
            this.lbl_MaterialName.Name = "lbl_MaterialName";
            this.lbl_MaterialName.Size = new System.Drawing.Size(75, 13);
            this.lbl_MaterialName.TabIndex = 1;
            this.lbl_MaterialName.Text = "Material Name";
            // 
            // lb_Materials
            // 
            this.lb_Materials.FormattingEnabled = true;
            this.lb_Materials.Location = new System.Drawing.Point(7, 7);
            this.lb_Materials.Name = "lb_Materials";
            this.lb_Materials.Size = new System.Drawing.Size(214, 446);
            this.lb_Materials.TabIndex = 0;
            // 
            // btn_SavePackage
            // 
            this.btn_SavePackage.Location = new System.Drawing.Point(13, 526);
            this.btn_SavePackage.Name = "btn_SavePackage";
            this.btn_SavePackage.Size = new System.Drawing.Size(759, 23);
            this.btn_SavePackage.TabIndex = 1;
            this.btn_SavePackage.Text = "Save Package";
            this.btn_SavePackage.UseVisualStyleBackColor = true;
            this.btn_SavePackage.Click += new System.EventHandler(this.btn_SavePackage_Click);
            // 
            // btn_DeleteMaterial
            // 
            this.btn_DeleteMaterial.Location = new System.Drawing.Point(228, 452);
            this.btn_DeleteMaterial.Name = "btn_DeleteMaterial";
            this.btn_DeleteMaterial.Size = new System.Drawing.Size(258, 23);
            this.btn_DeleteMaterial.TabIndex = 13;
            this.btn_DeleteMaterial.Text = "Delete Material";
            this.btn_DeleteMaterial.UseVisualStyleBackColor = true;
            // 
            // btn_SaveMaterial
            // 
            this.btn_SaveMaterial.Location = new System.Drawing.Point(493, 452);
            this.btn_SaveMaterial.Name = "btn_SaveMaterial";
            this.btn_SaveMaterial.Size = new System.Drawing.Size(252, 23);
            this.btn_SaveMaterial.TabIndex = 14;
            this.btn_SaveMaterial.Text = "Save Material";
            this.btn_SaveMaterial.UseVisualStyleBackColor = true;
            // 
            // btn_NewMaterial
            // 
            this.btn_NewMaterial.Location = new System.Drawing.Point(7, 452);
            this.btn_NewMaterial.Name = "btn_NewMaterial";
            this.btn_NewMaterial.Size = new System.Drawing.Size(214, 23);
            this.btn_NewMaterial.TabIndex = 15;
            this.btn_NewMaterial.Text = "New Material";
            this.btn_NewMaterial.UseVisualStyleBackColor = true;
            // 
            // EditPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn_SavePackage);
            this.Controls.Add(this.tc_PackageEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditPackage";
            this.Text = "Package Editor";
            this.tc_PackageEditor.ResumeLayout(false);
            this.tp_PackageDetails.ResumeLayout(false);
            this.tp_PackageDetails.PerformLayout();
            this.tp_Materials.ResumeLayout(false);
            this.tp_Materials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_PackageEditor;
        private System.Windows.Forms.TabPage tp_PackageDetails;
        private System.Windows.Forms.TabPage tp_Materials;
        private System.Windows.Forms.TextBox tb_PackageID;
        private System.Windows.Forms.TextBox tb_PackageVersion;
        private System.Windows.Forms.TextBox tb_PackageAuthor;
        private System.Windows.Forms.TextBox tb_PackageName;
        private System.Windows.Forms.Label lbl_PackageAuthor;
        private System.Windows.Forms.Label lbl_PackageVersion;
        private System.Windows.Forms.Label lbl_PackageID;
        private System.Windows.Forms.Label lbl_PackageName;
        private System.Windows.Forms.Button btn_SavePackage;
        private System.Windows.Forms.ListBox lb_Materials;
        private System.Windows.Forms.TextBox tb_GenerateInPlanets;
        private System.Windows.Forms.TextBox tb_GenerateInPlanetsAmount;
        private System.Windows.Forms.TextBox tb_GenerateInStars;
        private System.Windows.Forms.TextBox tb_GenerateInStarsAmount;
        private System.Windows.Forms.TextBox tb_MaterialName;
        private System.Windows.Forms.Label lbl_GenerateInPlanets;
        private System.Windows.Forms.Label lbl_GenerateInPlanetsAmount;
        private System.Windows.Forms.Label lbl_GenerateInStars;
        private System.Windows.Forms.Label lbl_GenerateInStarsAmount;
        private System.Windows.Forms.Label lbl_MaterialName;
        private System.Windows.Forms.Button btn_NewMaterial;
        private System.Windows.Forms.Button btn_SaveMaterial;
        private System.Windows.Forms.Button btn_DeleteMaterial;
    }
}