using Proiect_Vanzari.Entities;
using Proiect_Vanzari.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Vanzari
{
    public partial class AdaugaClientForm : Form
    {
        private ClientRepository _repository = new ClientRepository();
        public AdaugaClientForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool isEmpty(string textBox)
        {
            return textBox == string.Empty;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            var client = new Client();
            if (isEmpty(numeTextBox.Text))
                throw new FormatException("Specificati numele!");
            client.Nume = numeTextBox.Text;
            if (isEmpty(prenumeTextBox.Text))
                throw new FormatException("Specificati prenumele!");
            client.Prenume = prenumeTextBox.Text;
            if (isEmpty(emailTextBox.Text))
                throw new FormatException("Specificati emailul!");
            client.Email = emailTextBox.Text;
            if (isEmpty(telefonTextBox.Text))
                throw new FormatException("Specificati numarul de telefon!");
            client.Telefon = telefonTextBox.Text;
            client.DataNastere = dataNastereTimePicker.Value;

            _repository.AdaugaClient(client);
            Close();
        }
    }
}
