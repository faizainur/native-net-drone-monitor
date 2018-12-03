#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace native_net_drone_monitor
{
    partial class frmSettings
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
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection1 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navSettings = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.menuGeneralSettings = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.menuApparances = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.menuVideoSettings = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuSaveSettings = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.subMenuVidQuality = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.subMenuImgProc = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.navSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(637, 528);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // navSettings
            // 
            this.navSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            headerCollection1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            headerCollection1.HeaderText = "Settings";
            this.navSettings.Header = headerCollection1;
            this.navSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.navSettings.Items.Add(this.menuGeneralSettings);
            this.navSettings.Items.Add(this.menuApparances);
            this.navSettings.Items.Add(this.menuVideoSettings);
            this.navSettings.Items.Add(this.menuSaveSettings);
            this.navSettings.Location = new System.Drawing.Point(0, 0);
            this.navSettings.MinimumSize = new System.Drawing.Size(150, 150);
            this.navSettings.Name = "navSettings";
            this.navSettings.Size = new System.Drawing.Size(212, 528);
            this.navSettings.TabIndex = 0;
            this.navSettings.Text = "treeNavigator1";
            // 
            // menuGeneralSettings
            // 
            this.menuGeneralSettings.BackColor = System.Drawing.SystemColors.Control;
            this.menuGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGeneralSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.menuGeneralSettings.Location = new System.Drawing.Point(0, 0);
            this.menuGeneralSettings.Name = "menuGeneralSettings";
            this.menuGeneralSettings.Size = new System.Drawing.Size(208, 50);
            this.menuGeneralSettings.TabIndex = 1;
            this.menuGeneralSettings.Text = "General";
            // 
            // menuApparances
            // 
            this.menuApparances.BackColor = System.Drawing.SystemColors.Control;
            this.menuApparances.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuApparances.ItemBackColor = System.Drawing.SystemColors.Control;
            this.menuApparances.Location = new System.Drawing.Point(0, 52);
            this.menuApparances.Name = "menuApparances";
            this.menuApparances.Size = new System.Drawing.Size(208, 50);
            this.menuApparances.TabIndex = 1;
            this.menuApparances.Text = "Apparances";
            // 
            // menuVideoSettings
            // 
            this.menuVideoSettings.BackColor = System.Drawing.SystemColors.Control;
            this.menuVideoSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVideoSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.menuVideoSettings.Items.Add(this.subMenuVidQuality);
            this.menuVideoSettings.Items.Add(this.subMenuImgProc);
            this.menuVideoSettings.Location = new System.Drawing.Point(0, 104);
            this.menuVideoSettings.Name = "menuVideoSettings";
            this.menuVideoSettings.Size = new System.Drawing.Size(208, 50);
            this.menuVideoSettings.TabIndex = 1;
            this.menuVideoSettings.Text = "Video Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 528);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personlize your settings";
            // 
            // menuSaveSettings
            // 
            this.menuSaveSettings.BackColor = System.Drawing.SystemColors.Control;
            this.menuSaveSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSaveSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.menuSaveSettings.Location = new System.Drawing.Point(0, 156);
            this.menuSaveSettings.Name = "menuSaveSettings";
            this.menuSaveSettings.Size = new System.Drawing.Size(208, 50);
            this.menuSaveSettings.TabIndex = 1;
            this.menuSaveSettings.Text = "Save Settings";
            // 
            // subMenuVidQuality
            // 
            this.subMenuVidQuality.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuVidQuality.ItemBackColor = System.Drawing.SystemColors.Control;
            this.subMenuVidQuality.Location = new System.Drawing.Point(0, 0);
            this.subMenuVidQuality.Name = "subMenuVidQuality";
            this.subMenuVidQuality.Size = new System.Drawing.Size(0, 0);
            this.subMenuVidQuality.TabIndex = 0;
            this.subMenuVidQuality.Text = "Video Quality";
            // 
            // subMenuImgProc
            // 
            this.subMenuImgProc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuImgProc.ItemBackColor = System.Drawing.SystemColors.Control;
            this.subMenuImgProc.Location = new System.Drawing.Point(0, 0);
            this.subMenuImgProc.Name = "subMenuImgProc";
            this.subMenuImgProc.Size = new System.Drawing.Size(0, 0);
            this.subMenuImgProc.TabIndex = 0;
            this.subMenuImgProc.Text = "Image Processing";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 528);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Syncfusion.Windows.Forms.Tools.TreeNavigator navSettings;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem menuGeneralSettings;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem menuApparances;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem menuVideoSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem subMenuVidQuality;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem subMenuImgProc;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem menuSaveSettings;
    }
}