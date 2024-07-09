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
using System.Windows.Forms.VisualStyles;

namespace Proiect_Vanzari
{
    public partial class ModificaVanzatorForm : Form
    {
        private VanzatorRepository _repository = new VanzatorRepository();
        private Vanzator _vanzator;
        public ModificaVanzatorForm(Vanzator vanzator)
        {
            InitializeComponent();
            _vanzator = vanzator;
            idTextBox.Text = _vanzator.Id.ToString();
            numeTextBox.Text = _vanzator.Nume;
            prenumeTextBox.Text = _vanzator.Prenume;
            telefonTextBox.Text = _vanzator.Telefon;
            salariuTextBox.Text = _vanzator.Salariu.ToString();
            dataNastereTimePicker.Value = _vanzator.DataNasterii;
            if(_vanzator.Sex == "F")
            {
                femininRadioButton.Checked = true;
            }
            else if(_vanzator.Sex == "M") 
            {
                masculinRadioButton.Checked = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool isEmpty(string textBox)
        {
            return textBox == string.Empty;
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            _vanzator.Id = Convert.ToInt32(idTextBox.Text);
            if (isEmpty(numeTextBox.Text))
                throw new FormatException("Specificati numele!");
            _vanzator.Nume = numeTextBox.Text;
            if (isEmpty(prenumeTextBox.Text))
                throw new FormatException("Specificati prenumele!");
            _vanzator.Prenume = prenumeTextBox.Text;
            if (masculinRadioButton.Checked)
            {
                _vanzator.Sex = "M";
            }
            else if (femininRadioButton.Checked)
            {
                _vanzator.Sex = "F";
            }
            else
                throw new FormatException("Specificati sexul!");
            if (isEmpty(telefonTextBox.Text))
                throw new FormatException("Specificati numarul de telefon!");
            _vanzator.Telefon = telefonTextBox.Text;
            if (isEmpty(salariuTextBox.Text))
                throw new FormatException("Specificati salariul!");
            if (!Double.TryParse(salariuTextBox.Text, out var salariu))
                throw new FormatException("Specificati un salariu valid!");
            _vanzator.Salariu = salariu;
            _vanzator.DataNasterii = dataNastereTimePicker.Value;
            _repository.ModificaVanzator(_vanzator);
            Close();
        }
    }
}
