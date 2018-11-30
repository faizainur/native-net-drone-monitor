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

namespace native_net_drone_monitor
{
    public partial class frmAddDevices : Syncfusion.Windows.Forms.MetroForm
    {
        public frmAddDevices()
        {
            InitializeComponent();
        }

        private void radioSocket_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSocket.Checked == true)
            {
                txtSocket.Enabled = true;
            }
            else
            {
                txtSocket.Enabled = false;
            }
        }

        private Boolean validateForm()
        {
            // TODO : Error validating radioButtons status
            if (txtIPDevices.Text == null)
            {
                return false;
            }
            if (txtProfileName.Text == null)
            {
                return false;
            }
            if (radioHttp.Checked == false || radioMavlink.Checked == false || radioRtsp.Checked == false  || radioTcp.Checked == false || txtSocket.Text == null)
            {
                return false;
            } 
            return true;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDevices_Click(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                MessageBox.Show("Please check again !!!", "Error");
            }
        }
    }
}
