namespace Proiect_Vanzari
{
    partial class VanzatoriForm
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
            this.vanzatoriDataGridView = new System.Windows.Forms.DataGridView();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vanzatoriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vanzatoriDataGridView
            // 
            this.vanzatoriDataGridView.AllowUserToAddRows = false;
            this.vanzatoriDataGridView.AllowUserToDeleteRows = false;
            this.vanzatoriDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.vanzatoriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vanzatoriDataGridView.Location = new System.Drawing.Point(12, 12);
            this.vanzatoriDataGridView.MultiSelect = false;
            this.vanzatoriDataGridView.Name = "vanzatoriDataGridView";
            this.vanzatoriDataGridView.ReadOnly = true;
            this.vanzatoriDataGridView.RowHeadersWidth = 51;
            this.vanzatoriDataGridView.RowTemplate.Height = 24;
            this.vanzatoriDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vanzatoriDataGridView.Size = new System.Drawing.Size(870, 370);
            this.vanzatoriDataGridView.TabIndex = 0;
            this.vanzatoriDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vanzatoriDataGridView_CellContentClick);
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(676, 390);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(100, 50);
            this.adaugaButton.TabIndex = 1;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(782, 390);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 50);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // VanzatoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.vanzatoriDataGridView);
            this.Name = "VanzatoriForm";
            this.Text = "Vizualizare vanzatori";
            ((System.ComponentModel.ISupportInitialize)(this.vanzatoriDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vanzatoriDataGridView;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Button closeButton;
    }
}