using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagement.Forms
{
    public partial class FrmAuthors : Form
    {
        private readonly IServiceProvider serviceProvider;

        public FrmAuthors(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = serviceProvider.GetService<FrmBooks>();
            frm.Show();
        }

        private void FrmAuthors_Load(object sender, EventArgs e)
        {

        }
        
        private void FrmAuthors_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
