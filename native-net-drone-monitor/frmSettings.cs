#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Syncfusion.WinForms;
using Syncfusion.Windows.Forms.Tools;

namespace native_net_drone_monitor
{
    public partial class frmSettings : Syncfusion.Windows.Forms.MetroForm
    {

        List<string> aspectRatio = new List<string>();
        List<VideoFormat> videoFormats = new List<VideoFormat>();
        public frmSettings()
        {
            InitializeComponent();
            aspectRatio.Add("4:3");
            aspectRatio.Add("16:9");
            aspectRatio.Add("16:10");

            var aviFormat = new VideoFormat();
            var mkvFormat = new VideoFormat();
            var mp4Format = new VideoFormat();
            var tsForamt = new VideoFormat();

            aviFormat.formatIdentifier = "AVI";
            aviFormat.fileExt = ".avi";
            mkvFormat.formatIdentifier = "MKV";
            mkvFormat.fileExt = ".mkv";
            mp4Format.formatIdentifier = "MP4";
            mp4Format.fileExt = ".mp4";
            tsForamt.formatIdentifier = "TS";
            tsForamt.fileExt = ".ts";

            videoFormats.Add(aviFormat);
            videoFormats.Add(mkvFormat);
            videoFormats.Add(mp4Format);
            videoFormats.Add(tsForamt);

            toggleSaveVideo.VisualStyle = ToggleButtonStyle.Office2016Colorful;
            cmbAspectRatio.DataSource = aspectRatio;

            var bindingList = new BindingList<VideoFormat>(videoFormats);
            var source = new BindingSource(bindingList, null);
            cmbVIdeoFormat.DataSource = source;
            cmbVIdeoFormat.DisplayMember = "formatIdentifier";
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void toggleSaveVideo_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            if (e.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
            {
                panelSaveVideo.Visible = true;
            } else
            {
                panelSaveVideo.Visible = false;
            }
        }

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            folderBrowserSave.ShowDialog();
            txtPathFolder.Text = folderBrowserSave.SelectedPath;
        }

        private void navSettings_SelectionChanged(Syncfusion.Windows.Forms.Tools.TreeNavigator sender, Syncfusion.Windows.Forms.Tools.SelectionStateChangedEventArgs e)
        {
            TreeMenuItem tm = e.SelectedItem;
            switch (tm.Text)
            {
                case "Video":
                    panelVideoSettings.Visible = true   ;
                    panelMapsSettings.Visible = false;
                    break;
                case "Maps":
                    panelVideoSettings.Visible = true;
                    panelMapsSettings.Visible = true;
                    break;
            }
        }

        private void cbUseDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseDefault.Checked)
            {
                txtPathFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            } else
            {
                txtPathFolder.Clear();
            }
        }

        private void cbUseDefaultCacheLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUseDefaultCacheLoc.Checked)
            {
                string tempPath = System.IO.Path.GetTempPath();
                txtCacheLocation.Text = tempPath;
            }
            else
            {
                txtCacheLocation.Clear();
            }
        }

        private void btnBrowseCacheLoc_Click(object sender, EventArgs e)
        {
            folderBrowserSave.ShowDialog();
            txtCacheLocation.Text = folderBrowserSave.SelectedPath;
        }
    }
}
