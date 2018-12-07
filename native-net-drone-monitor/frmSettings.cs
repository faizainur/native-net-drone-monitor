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
using System.Configuration;
using System.Diagnostics;

namespace native_net_drone_monitor
{
    public partial class frmSettings : Syncfusion.Windows.Forms.MetroForm
    {
        string aspectRatioVal, saveVideoState, videoFormat, savePath, mapsModeVal, cacheLocation, mapLocation;

        AppSettingsVal settingsVal = new AppSettingsVal();

        List<string> aspectRatio = new List<string>();
        List<VideoFormat> videoFormats = new List<VideoFormat>();
        List<string> mapsMode = new List<string>();

        public frmSettings(AppSettingsVal settingsValParam)
        {
            InitializeComponent();
            settingsVal = settingsValParam;

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
            tsForamt.formatIdentifier = "TS";
            tsForamt.fileExt = ".ts";

            videoFormats.Add(aviFormat);
            videoFormats.Add(mkvFormat);
            videoFormats.Add(tsForamt);

            toggleSaveVideo.VisualStyle = ToggleButtonStyle.Office2016Colorful;
            cmbAspectRatio.DataSource = aspectRatio;

            var bindingList = new BindingList<VideoFormat>(videoFormats);
            var source = new BindingSource(bindingList, null);
            cmbVIdeoFormat.DataSource = source;
            cmbVIdeoFormat.DisplayMember = "formatIdentifier";

            mapsMode.Add("Offline");
            mapsMode.Add("Online");
            mapsMode.Add("Dowload");
            cmbMapMode.DataSource = mapsMode;

            
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            var main = new frmMain();

            loadSettings();
        }

        private void loadSettings()
        {
            txtCacheLocation.Text = settingsVal.cacheLocation;
            txtPathFolder.Text = settingsVal.savePath;
            txtMapLocation.Text = settingsVal.mapLocation;

            if (settingsVal.saveVideoState)
            {
                toggleSaveVideo.ToggleState = ToggleButtonState.Active;
            } else
            {
                toggleSaveVideo.ToggleState = ToggleButtonState.Inactive;
            }

            switch (settingsVal.aspectRatio)
            {
                case "4:3":
                    cmbAspectRatio.SelectedIndex = 0;
                    break;
                case "16:9":
                    cmbAspectRatio.SelectedIndex = 1;
                    break;
                case "16:10":
                    cmbAspectRatio.SelectedIndex = 2;
                    break;
            }

            switch (settingsVal.videoFormat)
            {
                case ".avi":
                    cmbVIdeoFormat.SelectedIndex = 0;
                    break;
                case ".mkv":
                    cmbVIdeoFormat.SelectedIndex = 1;
                    break;
                case ".ts":
                    cmbVIdeoFormat.SelectedIndex = 2;
                    break;
            }

            switch (settingsVal.mapsMode)
            {
                case "Offline":
                    cmbMapMode.SelectedIndex = 0;
                    break;
                case "Online":
                    cmbMapMode.SelectedIndex = 1;
                    break;
                case "Download":
                    cmbMapMode.SelectedIndex = 2;
                    break;
            }

        }

        private void toggleSaveVideo_ToggleStateChanged(object sender, Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventArgs e)
        {
            if (e.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active)
            {
                panelSaveVideo.Visible = true;
            } else
            {
                panelSaveVideo.Visible = false;
                cmbVIdeoFormat.SelectedItem = null;
                txtPathFolder.Clear();
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
                txtPathFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            var main = new frmMain();

            if (!applyAllSettings())
            {
                MessageBox.Show("Error updating app settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                var result = MessageBox.Show("Updating settings seccesfull, you need to restart app to take effect", "Need for restart application", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.OK:

                        // Application restarted
                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                        this.Close();
                        Application.ExitThread();
                        Process.GetCurrentProcess().Kill();
                        break;
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
                this.Close();
                
                
            }
        }

        public bool updateSettings(string key, string value)
        {
            try
            {
                var settingsFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = settingsFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }

                settingsFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(settingsFile.AppSettings.SectionInformation.Name);
                return true;
            } catch (ConfigurationErrorsException)
            {
                return false;
            }
        }

        public bool applyAllSettings()
        {
            switch (cmbAspectRatio.SelectedIndex)
            {
                case 0:
                    aspectRatioVal = "4:3";
                    break;
                case 1:
                    aspectRatioVal = "16:9";
                    break;
                case 2:
                    aspectRatioVal = "16:10";
                    break;
            }

            switch (cmbMapMode.SelectedIndex)
            {
                case 0:
                    mapsModeVal = "Offline";
                    break;
                case 1:
                    mapsModeVal = "Online";
                    break;
                case 2:
                    mapsModeVal = "Download";
                    break;
            }

            switch (cmbVIdeoFormat.SelectedIndex)
            {
                case 0:
                    videoFormat = ".avi";
                    break;
                case 1:
                    videoFormat = ".mkv";
                    break;
                case 2:
                    videoFormat = ".mp4";
                    break;
                case 3:
                    videoFormat = ".ts";
                    break;
            }

            switch (toggleSaveVideo.ToggleState)
            {
                case ToggleButtonState.Active:
                    saveVideoState = "true";
                    break;
                case ToggleButtonState.Inactive:
                    saveVideoState = "false";
                    break;
            }

            savePath = txtPathFolder.Text;
            cacheLocation = txtCacheLocation.Text;
            mapLocation = txtMapLocation.Text;

            if (updateSettings("aspect-ratio", aspectRatioVal) && 
                updateSettings("save-video-state", saveVideoState) &&
                updateSettings("video-format", videoFormat) &&
                updateSettings("save-path", savePath)&&
                updateSettings("maps-mode", mapsModeVal)&&
                updateSettings("cache-location", cacheLocation) &&
                updateSettings("maps-location", mapLocation))
            {
                return true;
            } else
            {
                return false;
            }

        }
    }
}
