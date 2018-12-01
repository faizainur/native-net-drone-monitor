#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace native_net_drone_monitor
{
    partial class frmAddDevices
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSocket = new System.Windows.Forms.TextBox();
            this.radioSocket = new System.Windows.Forms.RadioButton();
            this.radioMavlink = new System.Windows.Forms.RadioButton();
            this.radioTcp = new System.Windows.Forms.RadioButton();
            this.radioRtsp = new System.Windows.Forms.RadioButton();
            this.txtIPDevices = new System.Windows.Forms.TextBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.btnCancelAdd = new Syncfusion.WinForms.Controls.SfButton();
            this.btnAddDevices = new Syncfusion.WinForms.Controls.SfButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSocket);
            this.groupBox1.Controls.Add(this.radioSocket);
            this.groupBox1.Controls.Add(this.radioMavlink);
            this.groupBox1.Controls.Add(this.radioTcp);
            this.groupBox1.Controls.Add(this.radioRtsp);
            this.groupBox1.Location = new System.Drawing.Point(53, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data transfer method";
            // 
            // txtSocket
            // 
            this.txtSocket.Enabled = false;
            this.txtSocket.Location = new System.Drawing.Point(164, 41);
            this.txtSocket.Name = "txtSocket";
            this.txtSocket.Size = new System.Drawing.Size(53, 20);
            this.txtSocket.TabIndex = 6;
            // 
            // radioSocket
            // 
            this.radioSocket.AutoSize = true;
            this.radioSocket.Location = new System.Drawing.Point(99, 42);
            this.radioSocket.Name = "radioSocket";
            this.radioSocket.Size = new System.Drawing.Size(59, 17);
            this.radioSocket.TabIndex = 4;
            this.radioSocket.TabStop = true;
            this.radioSocket.Text = "Socket";
            this.radioSocket.UseVisualStyleBackColor = true;
            this.radioSocket.CheckedChanged += new System.EventHandler(this.radioSocket_CheckedChanged);
            // 
            // radioMavlink
            // 
            this.radioMavlink.AutoSize = true;
            this.radioMavlink.Location = new System.Drawing.Point(99, 19);
            this.radioMavlink.Name = "radioMavlink";
            this.radioMavlink.Size = new System.Drawing.Size(68, 17);
            this.radioMavlink.TabIndex = 3;
            this.radioMavlink.TabStop = true;
            this.radioMavlink.Text = "MAVLink";
            this.radioMavlink.UseVisualStyleBackColor = true;
            // 
            // radioTcp
            // 
            this.radioTcp.AutoSize = true;
            this.radioTcp.Location = new System.Drawing.Point(7, 65);
            this.radioTcp.Name = "radioTcp";
            this.radioTcp.Size = new System.Drawing.Size(46, 17);
            this.radioTcp.TabIndex = 2;
            this.radioTcp.TabStop = true;
            this.radioTcp.Text = "TCP";
            this.radioTcp.UseVisualStyleBackColor = true;
            // 
            // radioRtsp
            // 
            this.radioRtsp.AutoSize = true;
            this.radioRtsp.Location = new System.Drawing.Point(7, 42);
            this.radioRtsp.Name = "radioRtsp";
            this.radioRtsp.Size = new System.Drawing.Size(54, 17);
            this.radioRtsp.TabIndex = 1;
            this.radioRtsp.TabStop = true;
            this.radioRtsp.Text = "RTSP";
            this.radioRtsp.UseVisualStyleBackColor = true;
            // 
            // txtIPDevices
            // 
            this.txtIPDevices.Location = new System.Drawing.Point(140, 62);
            this.txtIPDevices.Name = "txtIPDevices";
            this.txtIPDevices.Size = new System.Drawing.Size(140, 20);
            this.txtIPDevices.TabIndex = 4;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(140, 35);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(140, 20);
            this.txtProfileName.TabIndex = 5;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.AccessibleName = "Button";
            this.btnCancelAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCancelAdd.Location = new System.Drawing.Point(53, 191);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(108, 28);
            this.btnCancelAdd.TabIndex = 6;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnAddDevices
            // 
            this.btnAddDevices.AccessibleName = "Button";
            this.btnAddDevices.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAddDevices.Location = new System.Drawing.Point(176, 191);
            this.btnAddDevices.Name = "btnAddDevices";
            this.btnAddDevices.Size = new System.Drawing.Size(104, 28);
            this.btnAddDevices.TabIndex = 7;
            this.btnAddDevices.Text = "Add Device";
            this.btnAddDevices.Click += new System.EventHandler(this.btnAddDevices_Click);
            // 
            // frmAddDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 236);
            this.Controls.Add(this.btnAddDevices);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.txtIPDevices);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddDevices";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD DEVICES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSocket;
        private System.Windows.Forms.RadioButton radioSocket;
        private System.Windows.Forms.RadioButton radioMavlink;
        private System.Windows.Forms.RadioButton radioTcp;
        private System.Windows.Forms.RadioButton radioRtsp;
        private System.Windows.Forms.TextBox txtIPDevices;
        private System.Windows.Forms.TextBox txtProfileName;
        private Syncfusion.WinForms.Controls.SfButton btnCancelAdd;
        private Syncfusion.WinForms.Controls.SfButton btnAddDevices;
    }
}