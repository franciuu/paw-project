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
    public partial class ModificaClientForm : Form
    {
        private ClientRepository _repository = new ClientRepository();
        private Client _client;
        public ModificaClientForm(Client client)
        {
            InitializeComponent();
            _client = client;
            idTextBox.Text = _client.Id.ToString();
            numeTextBox.Text = _client.Nume;
            prenumeTextBox.Text = _client.Prenume;
            dataNastereTimePicker.Value = _client.DataNastere;
            telefonTextBox.Text = _client.Telefon;
            emailTextBox.Text = _client.Email;
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
            _client.Id = Convert.ToInt32(idTextBox.Text);
            if (isEmpty(numeTextBox.Text))
                throw new FormatException("Specificati numele!");
            _client.Nume = numeTextBox.Text;
            if (isEmpty(prenumeTextBox.Text))
                throw new FormatException("Specificati prenumele!");
            _client.Prenume = prenumeTextBox.Text;
            _client.DataNastere = dataNastereTimePicker.Value;
            if (isEmpty(telefonTextBox.Text))
                throw new FormatException("Specificati numarul de telefon!");
            _client.Telefon = telefonTextBox.Text;
            if (isEmpty(emailTextBox.Text))
                throw new FormatException("Specificati emailul!");
            _client.Email = emailTextBox.Text;
            _repository.ModificaClient(_client);
            Close();
        }
    }
}
