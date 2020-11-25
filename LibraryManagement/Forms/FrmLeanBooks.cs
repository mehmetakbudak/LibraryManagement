using LibraryManagement.Data.Repositories;
using System;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class FrmLeanBooks : Form
    {
        private readonly IPersonRepository personRepository;

        public FrmLeanBooks(IPersonRepository personRepository)
        {
            InitializeComponent();
            this.personRepository = personRepository;
        }

        private void FrmLeanBooks_Load(object sender, EventArgs e)
        {
            var persons = personRepository.GetAll();
            cmbPerson.DataSource = persons;
        }

        private void btnLean_Click(object sender, EventArgs e)
        {

        }
    }
}
