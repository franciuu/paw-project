namespace Proiect_Vanzari
{
    partial class ComenziForm
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
            this.comenziDataGridView = new System.Windows.Forms.DataGridView();
            this.produseDataGridView = new System.Windows.Forms.DataGridView();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.comenziLabel = new System.Windows.Forms.Label();
            this.produseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comenziDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comenziDataGridView
            // 
            this.comenziDataGridView.AllowUserToAddRows = false;
            this.comenziDataGridView.AllowUserToDeleteRows = false;
            this.comenziDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.comenziDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comenziDataGridView.Location = new System.Drawing.Point(13, 33);
            this.comenziDataGridView.Name = "comenziDataGridView";
            this.comenziDataGridView.ReadOnly = true;
            this.comenziDataGridView.RowHeadersWidth = 51;
            this.comenziDataGridView.RowTemplate.Height = 24;
            this.comenziDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comenziDataGridView.Size = new System.Drawing.Size(721, 189);
            this.comenziDataGridView.TabIndex = 0;
            this.comenziDataGridView.SelectionChanged += new System.EventHandler(this.comenziDataGridView_SelectionChanged);
            // 
            // produseDataGridView
            // 
            this.produseDataGridView.AllowUserToAddRows = false;
            this.produseDataGridView.AllowUserToDeleteRows = false;
            this.produseDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.produseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseDataGridView.Location = new System.Drawing.Point(13, 255);
            this.produseDataGridView.Name = "produseDataGridView";
            this.produseDataGridView.ReadOnly = true;
            this.produseDataGridView.RowHeadersWidth = 51;
            this.produseDataGridView.RowTemplate.Height = 24;
            this.produseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produseDataGridView.Size = new System.Drawing.Size(721, 213);
            this.produseDataGridView.TabIndex = 1;
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(740, 33);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(100, 50);
            this.adaugaButton.TabIndex = 2;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(740, 418);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 50);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // comenziLabel
            // 
            this.comenziLabel.AutoSize = true;
            this.comenziLabel.Location = new System.Drawing.Point(13, 13);
            this.comenziLabel.Name = "comenziLabel";
            this.comenziLabel.Size = new System.Drawing.Size(114, 17);
            this.comenziLabel.TabIndex = 5;
            this.comenziLabel.Text = "Lista comenzilor:";
            // 
            // produseLabel
            // 
            this.produseLabel.AutoSize = true;
            this.produseLabel.Location = new System.Drawing.Point(13, 236);
            this.produseLabel.Name = "produseLabel";
            this.produseLabel.Size = new System.Drawing.Size(161, 17);
            this.produseLabel.TabIndex = 6;
            this.produseLabel.Text = "Produsele din comanda:";
            // 
            // ComenziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 480);
            this.Controls.Add(this.produseLabel);
            this.Controls.Add(this.comenziLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.produseDataGridView);
            this.Controls.Add(this.comenziDataGridView);
            this.Name = "ComenziForm";
            this.Text = "Vizualizare comenzi";
            ((System.ComponentModel.ISupportInitialize)(this.comenziDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView comenziDataGridView;
        private System.Windows.Forms.DataGridView produseDataGridView;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label comenziLabel;
        private System.Windows.Forms.Label produseLabel;
    }
}