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
    public partial class ProduseForm : Form
    {
        private ProdusRepository _repository = new ProdusRepository();
        private ComandaRepository _repo = new ComandaRepository();
        public ProduseForm()
        {
            InitializeComponent();
            produseDataGridView.AutoGenerateColumns = true;
            produseDataGridView.DataSource = _repository.ObtineProduse();
            AddButtonColumn("Edit", "Edit product", "EditColumn");
            AddButtonColumn("Delete", "Delete product", "DeleteColumn");
        }
        private void AddButtonColumn(string buttonText, string headerText, string columnName)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.UseColumnTextForButtonValue = true;
            column.Text = buttonText;
            column.HeaderText = headerText;
            column.Name = columnName;
            produseDataGridView.Columns.Add(column);
        }
        private void adaugaButton_Click(object sender, EventArgs e)
        {
            var adaugaProdus = new AdaugareProdusForm();
            adaugaProdus.StartPosition = FormStartPosition.CenterParent;
            adaugaProdus.ShowDialog();
            produseDataGridView.DataSource = _repository.ObtineProduse();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void produseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            var produs = (Produs)grid.Rows[e.RowIndex].DataBoundItem;
            if (columnName == "DeleteColumn")
            {
                var result = MessageBox.Show($"Confirmati stergerea produsului cu id-ul {produs.Id}? Stergerea va duce la anularea tuturor comenzilor asociate.", "Confirmati actiunea", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _repo.StergeComandaProdus(produs);
                    _repository.StergeProdus(produs);
                    produseDataGridView.DataSource = _repository.ObtineProduse();
                }
            }
            if (columnName == "EditColumn")
            {
                var modificaProdusForm = new ModificaProdusForm(produs);
                modificaProdusForm.StartPosition = FormStartPosition.CenterParent;
                modificaProdusForm.ShowDialog();
                produseDataGridView.DataSource = _repository.ObtineProduse();
            }
        }
    }
}
