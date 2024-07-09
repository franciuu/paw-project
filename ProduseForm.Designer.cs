namespace Proiect_Vanzari
{
    partial class ProduseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.produseDataGridView = new System.Windows.Forms.DataGridView();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.produseLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produseDataGridView
            // 
            this.produseDataGridView.AllowUserToAddRows = false;
            this.produseDataGridView.AllowUserToDeleteRows = false;
            this.produseDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.produseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseDataGridView.Location = new System.Drawing.Point(12, 31);
            this.produseDataGridView.MultiSelect = false;
            this.produseDataGridView.Name = "produseDataGridView";
            this.produseDataGridView.ReadOnly = true;
            this.produseDataGridView.RowHeadersWidth = 51;
            this.produseDataGridView.RowTemplate.Height = 24;
            this.produseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produseDataGridView.Size = new System.Drawing.Size(873, 473);
            this.produseDataGridView.TabIndex = 0;
            this.produseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produseDataGridView_CellContentClick);
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(891, 31);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(100, 50);
            this.adaugaButton.TabIndex = 1;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // produseLabel
            // 
            this.produseLabel.AutoSize = true;
            this.produseLabel.Location = new System.Drawing.Point(12, 12);
            this.produseLabel.Name = "produseLabel";
            this.produseLabel.Size = new System.Drawing.Size(147, 17);
            this.produseLabel.TabIndex = 3;
            this.produseLabel.Text = "Produsele disponibile:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(891, 454);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 50);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ProduseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 516);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.produseLabel);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.produseDataGridView);
            this.Name = "ProduseForm";
            this.Text = "Vizualizare produse";
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView produseDataGridView;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Label produseLabel;
        private System.Windows.Forms.Button closeButton;
    }
}