namespace Proiect_Vanzari
{
    partial class ModificaVanzatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaVanzatorForm));
            this.dataNastereTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.salariuTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.salariuLabel = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.sexGroupBox = new System.Windows.Forms.GroupBox();
            this.femininRadioButton = new System.Windows.Forms.RadioButton();
            this.masculinRadioButton = new System.Windows.Forms.RadioButton();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.numeLabel = new System.Windows.Forms.Label();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.titluLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.sexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNastereTimePicker
            // 
            this.dataNastereTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dataNastereTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNastereTimePicker.Location = new System.Drawing.Point(268, 89);
            this.dataNastereTimePicker.Name = "dataNastereTimePicker";
            this.dataNastereTimePicker.Size = new System.Drawing.Size(155, 22);
            this.dataNastereTimePicker.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Data Nastere";
            // 
            // salariuTextBox
            // 
            this.salariuTextBox.Location = new System.Drawing.Point(550, 145);
            this.salariuTextBox.Name = "salariuTextBox";
            this.salariuTextBox.Size = new System.Drawing.Size(155, 22);
            this.salariuTextBox.TabIndex = 27;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(550, 91);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(155, 22);
            this.telefonTextBox.TabIndex = 26;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(605, 197);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(499, 197);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 50);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // salariuLabel
            // 
            this.salariuLabel.AutoSize = true;
            this.salariuLabel.Location = new System.Drawing.Point(471, 148);
            this.salariuLabel.Name = "salariuLabel";
            this.salariuLabel.Size = new System.Drawing.Size(52, 17);
            this.salariuLabel.TabIndex = 23;
            this.salariuLabel.Text = "Salariu";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(471, 94);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(56, 17);
            this.telefonLabel.TabIndex = 22;
            this.telefonLabel.Text = "Telefon";
            // 
            // sexGroupBox
            // 
            this.sexGroupBox.Controls.Add(this.femininRadioButton);
            this.sexGroupBox.Controls.Add(this.masculinRadioButton);
            this.sexGroupBox.Location = new System.Drawing.Point(196, 130);
            this.sexGroupBox.Name = "sexGroupBox";
            this.sexGroupBox.Size = new System.Drawing.Size(200, 41);
            this.sexGroupBox.TabIndex = 21;
            this.sexGroupBox.TabStop = false;
            // 
            // femininRadioButton
            // 
            this.femininRadioButton.AutoSize = true;
            this.femininRadioButton.Location = new System.Drawing.Point(19, 15);
            this.femininRadioButton.Name = "femininRadioButton";
            this.femininRadioButton.Size = new System.Drawing.Size(78, 21);
            this.femininRadioButton.TabIndex = 5;
            this.femininRadioButton.TabStop = true;
            this.femininRadioButton.Text = "Feminin";
            this.femininRadioButton.UseVisualStyleBackColor = true;
            // 
            // masculinRadioButton
            // 
            this.masculinRadioButton.AutoSize = true;
            this.masculinRadioButton.Location = new System.Drawing.Point(100, 15);
            this.masculinRadioButton.Name = "masculinRadioButton";
            this.masculinRadioButton.Size = new System.Drawing.Size(84, 21);
            this.masculinRadioButton.TabIndex = 6;
            this.masculinRadioButton.TabStop = true;
            this.masculinRadioButton.Text = "Masculin";
            this.masculinRadioButton.UseVisualStyleBackColor = true;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(550, 38);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(155, 22);
            this.prenumeTextBox.TabIndex = 20;
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Location = new System.Drawing.Point(471, 41);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(65, 17);
            this.prenumeLabel.TabIndex = 19;
            this.prenumeLabel.Text = "Prenume";
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(268, 38);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(155, 22);
            this.numeTextBox.TabIndex = 18;
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Location = new System.Drawing.Point(167, 41);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(45, 17);
            this.numeLabel.TabIndex = 17;
            this.numeLabel.Text = "Nume";
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.Image")));
            this.avatarPictureBox.Location = new System.Drawing.Point(15, 38);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(133, 133);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 16;
            this.avatarPictureBox.TabStop = false;
            // 
            // titluLabel
            // 
            this.titluLabel.AutoSize = true;
            this.titluLabel.Location = new System.Drawing.Point(12, 9);
            this.titluLabel.Name = "titluLabel";
            this.titluLabel.Size = new System.Drawing.Size(195, 17);
            this.titluLabel.TabIndex = 30;
            this.titluLabel.Text = "Modificati datele vanzatorului:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 180);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 31;
            this.idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(58, 177);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(90, 22);
            this.idTextBox.TabIndex = 32;
            // 
            // ModificaVanzatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 263);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.titluLabel);
            this.Controls.Add(this.dataNastereTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salariuTextBox);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.salariuLabel);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.sexGroupBox);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(this.prenumeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.numeLabel);
            this.Controls.Add(this.avatarPictureBox);
            this.Name = "ModificaVanzatorForm";
            this.Text = "Modifica vanzator";
            this.sexGroupBox.ResumeLayout(false);
            this.sexGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataNastereTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salariuTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label salariuLabel;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.GroupBox sexGroupBox;
        private System.Windows.Forms.RadioButton femininRadioButton;
        private System.Windows.Forms.RadioButton masculinRadioButton;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.Label prenumeLabel;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label titluLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
    }
}