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
            this.treeGeneralSettings = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeVideoSettings = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeMapsSettings = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuApparances = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
            this.treeApply = new Syncfusion.Windows.Forms.Tools.TreeMenuItem();
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
            this.navSettings.Items.Add(this.treeGeneralSettings);
            this.navSettings.Items.Add(this.treeVideoSettings);
            this.navSettings.Items.Add(this.treeMapsSettings);
            this.navSettings.Items.Add(this.treeApply);
            this.navSettings.Location = new System.Drawing.Point(0, 0);
            this.navSettings.MinimumSize = new System.Drawing.Size(150, 150);
            this.navSettings.Name = "navSettings";
            this.navSettings.Size = new System.Drawing.Size(212, 528);
            this.navSettings.TabIndex = 0;
            this.navSettings.Text = "treeNavigator1";
            // 
            // treeGeneralSettings
            // 
            this.treeGeneralSettings.BackColor = System.Drawing.SystemColors.Control;
            this.treeGeneralSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeGeneralSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeGeneralSettings.Location = new System.Drawing.Point(0, 0);
            this.treeGeneralSettings.Name = "treeGeneralSettings";
            this.treeGeneralSettings.Size = new System.Drawing.Size(210, 50);
            this.treeGeneralSettings.TabIndex = 1;
            this.treeGeneralSettings.Text = "General";
            // 
            // treeVideoSettings
            // 
            this.treeVideoSettings.BackColor = System.Drawing.SystemColors.Control;
            this.treeVideoSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeVideoSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeVideoSettings.Location = new System.Drawing.Point(0, 52);
            this.treeVideoSettings.Name = "treeVideoSettings";
            this.treeVideoSettings.Size = new System.Drawing.Size(210, 50);
            this.treeVideoSettings.TabIndex = 1;
            this.treeVideoSettings.Text = "Video Settings";
            // 
            // treeMapsSettings
            // 
            this.treeMapsSettings.BackColor = System.Drawing.SystemColors.Control;
            this.treeMapsSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMapsSettings.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeMapsSettings.Location = new System.Drawing.Point(0, 104);
            this.treeMapsSettings.Name = "treeMapsSettings";
            this.treeMapsSettings.Size = new System.Drawing.Size(210, 50);
            this.treeMapsSettings.TabIndex = 1;
            this.treeMapsSettings.Text = "Maps";
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
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personalize your settings";
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
            // treeApply
            // 
            this.treeApply.BackColor = System.Drawing.SystemColors.Control;
            this.treeApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeApply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeApply.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeApply.Location = new System.Drawing.Point(0, 427);
            this.treeApply.Name = "treeApply";
            this.treeApply.Size = new System.Drawing.Size(210, 50);
            this.treeApply.TabIndex = 1;
            this.treeApply.Text = "Apply";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 528);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
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
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeGeneralSettings;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeVideoSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeMapsSettings;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem menuApparances;
        private Syncfusion.Windows.Forms.Tools.TreeMenuItem treeApply;
    }
}