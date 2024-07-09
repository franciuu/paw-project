namespace Proiect_Vanzari
{
    partial class AdaugaComandaForm
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
            this.detaliiLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.modalitateLabel = new System.Windows.Forms.Label();
            this.idClientLabel = new System.Windows.Forms.Label();
            this.idVanzatorLabel = new System.Windows.Forms.Label();
            this.modalitateComboBox = new System.Windows.Forms.ComboBox();
            this.dataTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.idVanzatorTextBox = new System.Windows.Forms.TextBox();
            this.produseLabel = new System.Windows.Forms.Label();
            this.produseDataGridView = new System.Windows.Forms.DataGridView();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // detaliiLabel
            // 
            this.detaliiLabel.AutoSize = true;
            this.detaliiLabel.Location = new System.Drawing.Point(13, 13);
            this.detaliiLabel.Name = "detaliiLabel";
            this.detaliiLabel.Size = new System.Drawing.Size(117, 17);
            this.detaliiLabel.TabIndex = 0;
            this.detaliiLabel.Text = "Detaliile comenzii";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(13, 43);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(38, 17);
            this.dataLabel.TabIndex = 1;
            this.dataLabel.Text = "Data";
            // 
            // modalitateLabel
            // 
            this.modalitateLabel.AutoSize = true;
            this.modalitateLabel.Location = new System.Drawing.Point(13, 78);
            this.modalitateLabel.Name = "modalitateLabel";
            this.modalitateLabel.Size = new System.Drawing.Size(73, 17);
            this.modalitateLabel.TabIndex = 2;
            this.modalitateLabel.Text = "Modalitate";
            // 
            // idClientLabel
            // 
            this.idClientLabel.AutoSize = true;
            this.idClientLabel.Location = new System.Drawing.Point(13, 113);
            this.idClientLabel.Name = "idClientLabel";
            this.idClientLabel.Size = new System.Drawing.Size(56, 17);
            this.idClientLabel.TabIndex = 3;
            this.idClientLabel.Text = "Id client";
            // 
            // idVanzatorLabel
            // 
            this.idVanzatorLabel.AutoSize = true;
            this.idVanzatorLabel.Location = new System.Drawing.Point(13, 149);
            this.idVanzatorLabel.Name = "idVanzatorLabel";
            this.idVanzatorLabel.Size = new System.Drawing.Size(78, 17);
            this.idVanzatorLabel.TabIndex = 4;
            this.idVanzatorLabel.Text = "Id vanzator";
            // 
            // modalitateComboBox
            // 
            this.modalitateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modalitateComboBox.FormattingEnabled = true;
            this.modalitateComboBox.Items.AddRange(new object[] {
            "Online",
            "Fizic"});
            this.modalitateComboBox.Location = new System.Drawing.Point(103, 75);
            this.modalitateComboBox.Name = "modalitateComboBox";
            this.modalitateComboBox.Size = new System.Drawing.Size(155, 24);
            this.modalitateComboBox.TabIndex = 5;
            // 
            // dataTimePicker
            // 
            this.dataTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dataTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataTimePicker.Location = new System.Drawing.Point(103, 38);
            this.dataTimePicker.Name = "dataTimePicker";
            this.dataTimePicker.Size = new System.Drawing.Size(155, 22);
            this.dataTimePicker.TabIndex = 6;
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.Location = new System.Drawing.Point(103, 110);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(155, 22);
            this.idClientTextBox.TabIndex = 7;
            // 
            // idVanzatorTextBox
            // 
            this.idVanzatorTextBox.Location = new System.Drawing.Point(103, 146);
            this.idVanzatorTextBox.Name = "idVanzatorTextBox";
            this.idVanzatorTextBox.Size = new System.Drawing.Size(155, 22);
            this.idVanzatorTextBox.TabIndex = 8;
            // 
            // produseLabel
            // 
            this.produseLabel.AutoSize = true;
            this.produseLabel.Location = new System.Drawing.Point(281, 13);
            this.produseLabel.Name = "produseLabel";
            this.produseLabel.Size = new System.Drawing.Size(118, 17);
            this.produseLabel.TabIndex = 9;
            this.produseLabel.Text = "Alegeti produsele";
            // 
            // produseDataGridView
            // 
            this.produseDataGridView.AllowUserToAddRows = false;
            this.produseDataGridView.AllowUserToDeleteRows = false;
            this.produseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produseDataGridView.Location = new System.Drawing.Point(284, 32);
            this.produseDataGridView.Name = "produseDataGridView";
            this.produseDataGridView.ReadOnly = true;
            this.produseDataGridView.RowHeadersWidth = 51;
            this.produseDataGridView.RowTemplate.Height = 24;
            this.produseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produseDataGridView.Size = new System.Drawing.Size(610, 213);
            this.produseDataGridView.TabIndex = 10;
            this.produseDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produseDataGridView_CellContentClick);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(16, 195);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 50);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(122, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // AdaugaComandaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 270);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.produseDataGridView);
            this.Controls.Add(this.produseLabel);
            this.Controls.Add(this.idVanzatorTextBox);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(this.dataTimePicker);
            this.Controls.Add(this.modalitateComboBox);
            this.Controls.Add(this.idVanzatorLabel);
            this.Controls.Add(this.idClientLabel);
            this.Controls.Add(this.modalitateLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.detaliiLabel);
            this.Name = "AdaugaComandaForm";
            this.Text = "Adauga comanda";
            ((System.ComponentModel.ISupportInitialize)(this.produseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detaliiLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label modalitateLabel;
        private System.Windows.Forms.Label idClientLabel;
        private System.Windows.Forms.Label idVanzatorLabel;
        private System.Windows.Forms.ComboBox modalitateComboBox;
        private System.Windows.Forms.DateTimePicker dataTimePicker;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.TextBox idVanzatorTextBox;
        private System.Windows.Forms.Label produseLabel;
        private System.Windows.Forms.DataGridView produseDataGridView;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}