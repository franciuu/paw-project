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
    public partial class AdaugaVanzatorForm : Form
    {
        private VanzatorRepository _repository = new VanzatorRepository();
        public AdaugaVanzatorForm()
        {
            InitializeComponent();
        }

        private bool isEmpty(string textBox)
        {
            return textBox == string.Empty;
        }
        private void adaugaButton_Click(object sender, EventArgs e)
        {
            var vanzator = new Vanzator();
            if (isEmpty(numeTextBox.Text))
                throw new FormatException("Specificati numele!");
            vanzator.Nume = numeTextBox.Text;
            if(isEmpty(prenumeTextBox.Text))
                throw new FormatException("Specificati prenumele!");
            vanzator.Prenume = prenumeTextBox.Text;
            if (masculinRadioButton.Checked)
            {
                vanzator.Sex = "M";
            }
            else if(femininRadioButton.Checked)
            {
                vanzator.Sex = "F";
            }
            else
                throw new FormatException("Specificati sexul!");
            if (isEmpty(telefonTextBox.Text))
                throw new FormatException("Specificati numarul de telefon!");
            vanzator.Telefon = telefonTextBox.Text;
            if (isEmpty(salariuTextBox.Text))
                throw new FormatException("Specificati salariul!");
            if (!Double.TryParse(salariuTextBox.Text, out var salariu))
                throw new FormatException("Specificati un salariu valid!");
            vanzator.Salariu = salariu;
            vanzator.DataNasterii = dataNastereTimePicker.Value;
            _repository.AdaugaVanzator(vanzator);
            Close();
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
