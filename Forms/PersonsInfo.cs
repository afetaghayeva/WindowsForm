using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Entities.Concrete;
using WindowsForm.Services.Abstract;
using WindowsForm.Utilities.DependencyInjection;

namespace WindowsForm.Forms
{
    public partial class PersonsInfo : Form
    {
        private DataGridViewRow _row;
        public PersonsInfo()
        {
            InitializeComponent();
        }

        private readonly IPersonService _personService = InstanceFactory.GetInstance<IPersonService>();
        private async void PersonsInfo_Load(object sender, EventArgs e)
        {
            await LoadPersons();
        }

        private async Task LoadPersons()
        {
            this.dgwPersons.DataSource = await _personService.GetPersonsAsync();
        }

        private void dgwPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _row = dgwPersons.CurrentRow;
            if (_row != null)
            {
                tbxAge.Text = _row.Cells[1].Value.ToString();
                tbxName.Text = _row.Cells[2].Value.ToString();
                tbxSurname.Text = _row.Cells[3].Value.ToString();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_row==null)
            {
                try
                {
                    var person = new PersonRequest()
                    {
                        age = Convert.ToInt32(tbxAge.Text),
                        personName = tbxName.Text,
                        personSurname = tbxSurname.Text,
                    };
                    await _personService.SavePersonsAsync(person);
                    await LoadPersons();
                    MessageBox.Show(@"Added" + @" " + person.personName);
                }
                catch 
                {
                    MessageBox.Show(@"Add operation didn't successfully");
                }
            }
            else
            {

                try
                {
                    var person = new PersonRequest()
                    {
                        age = Convert.ToInt32(tbxAge.Text),
                        personName = tbxName.Text,
                        personSurname = tbxSurname.Text
                    };
                    await _personService.UpdatePersonsAsync(person, Convert.ToInt32(_row.Cells[0].Value));
                    await LoadPersons();
                    MessageBox.Show(@"Update" + @" " + person.personName);
                }
                catch 
                {
                    MessageBox.Show(@"Update operation didn't successfully");
                }
            }
        }

    }
}
