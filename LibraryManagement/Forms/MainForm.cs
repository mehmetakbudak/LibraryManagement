using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
        }

        private void menuItemBooks_Click(object sender, EventArgs e)
        {
            var frm = serviceProvider.GetService<FrmBooks>();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void menuItemAuthor_Click(object sender, EventArgs e)
        {
            var frm = serviceProvider.GetService<FrmAuthors>();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void menuItemPublisher_Click(object sender, EventArgs e)
        {
            var frm = serviceProvider.GetService<FrmPublishers>();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
