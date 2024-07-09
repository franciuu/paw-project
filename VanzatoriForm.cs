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
    public partial class VanzatoriForm : Form
    {
        private VanzatorRepository _repository = new VanzatorRepository();
        private ComandaRepository _repo = new ComandaRepository();
        public VanzatoriForm()
        {
            InitializeComponent();
            vanzatoriDataGridView.AutoGenerateColumns = true;
            vanzatoriDataGridView.DataSource = _repository.ObtineVanzatori();
            AddButtonColumn("Edit", "Edit sellers", "EditColumn");
            AddButtonColumn("Delete", "Delete sellers", "DeleteColumn");
        }
        public void AddButtonColumn(string buttonText, string headerText, string columnName)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.UseColumnTextForButtonValue = true;
            column.Text = buttonText;
            column.HeaderText = headerText;
            column.Name = columnName;
            vanzatoriDataGridView.Columns.Add(column);
        }
        private void adaugaButton_Click(object sender, EventArgs e)
        {
            var adaugaVanzatori = new AdaugaVanzatorForm();
            adaugaVanzatori.StartPosition = FormStartPosition.CenterParent;
            adaugaVanzatori.ShowDialog();
            vanzatoriDataGridView.DataSource = _repository.ObtineVanzatori();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vanzatoriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            var vanzator = (Vanzator)grid.Rows[e.RowIndex].DataBoundItem;
            if (columnName == "DeleteColumn")
            {
                var result = MessageBox.Show($"Confirmati stergerea vanzatorului cu id-ul {vanzator.Id}? Stergerea va duce la anularea tuturor comenzilor asociate.", "Confirmati actiunea", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _repo.StergeComandaVanzator(vanzator);
                    _repository.StergeVanzator(vanzator);
                    vanzatoriDataGridView.DataSource = _repository.ObtineVanzatori();
                }
            }
            if(columnName == "EditColumn")
            {
                var modificaVanzatorForm = new ModificaVanzatorForm(vanzator);
                modificaVanzatorForm.StartPosition = FormStartPosition.CenterParent;
                modificaVanzatorForm.ShowDialog();
                vanzatoriDataGridView.DataSource = _repository.ObtineVanzatori();
            }
        }
    }
}
