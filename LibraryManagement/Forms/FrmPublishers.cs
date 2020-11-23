using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class FrmPublishers : Form
    {
        public FrmPublishers()
        {
            InitializeComponent();
        }

        private void FrmPublishers_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
