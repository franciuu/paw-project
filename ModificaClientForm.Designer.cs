namespace Proiect_Vanzari
{
    partial class ModificaClientForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dataNastereTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataLabel = new System.Windows.Forms.Label();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.numeLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(153, 284);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(34, 284);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 50);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(115, 236);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(155, 22);
            this.telefonTextBox.TabIndex = 23;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(115, 194);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(155, 22);
            this.emailTextBox.TabIndex = 22;
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(14, 239);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(56, 17);
            this.telefonLabel.TabIndex = 21;
            this.telefonLabel.Text = "Telefon";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(14, 197);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 20;
            this.emailLabel.Text = "Email";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(173, 17);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Modificati datele clientului:";
            // 
            // dataNastereTimePicker
            // 
            this.dataNastereTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dataNastereTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNastereTimePicker.Location = new System.Drawing.Point(115, 150);
            this.dataNastereTimePicker.Name = "dataNastereTimePicker";
            this.dataNastereTimePicker.Size = new System.Drawing.Size(155, 22);
            this.dataNastereTimePicker.TabIndex = 18;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(14, 155);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(93, 17);
            this.dataLabel.TabIndex = 17;
            this.dataLabel.Text = "Data nasterie";
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(115, 109);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(155, 22);
            this.prenumeTextBox.TabIndex = 16;
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(115, 64);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(155, 22);
            this.numeTextBox.TabIndex = 15;
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Location = new System.Drawing.Point(14, 112);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(65, 17);
            this.prenumeLabel.TabIndex = 14;
            this.prenumeLabel.Text = "Prenume";
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Location = new System.Drawing.Point(14, 67);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(45, 17);
            this.numeLabel.TabIndex = 13;
            this.numeLabel.Text = "Nume";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(41, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(90, 22);
            this.idTextBox.TabIndex = 34;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(11, 34);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 33;
            this.idLabel.Text = "ID:";
            // 
            // ModificaClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 356);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dataNastereTimePicker);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.prenumeLabel);
            this.Controls.Add(this.numeLabel);
            this.Name = "ModificaClientForm";
            this.Text = "Modifica client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DateTimePicker dataNastereTimePicker;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.Label prenumeLabel;
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
    }
}