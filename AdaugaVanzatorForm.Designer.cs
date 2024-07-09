namespace Proiect_Vanzari
{
    partial class AdaugaVanzatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaVanzatorForm));
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.numeLabel = new System.Windows.Forms.Label();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.femininRadioButton = new System.Windows.Forms.RadioButton();
            this.masculinRadioButton = new System.Windows.Forms.RadioButton();
            this.sexGroupBox = new System.Windows.Forms.GroupBox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.salariuLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.salariuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataNastereTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.sexGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.Image")));
            this.avatarPictureBox.Location = new System.Drawing.Point(12, 13);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(133, 133);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Location = new System.Drawing.Point(168, 16);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(45, 17);
            this.numeLabel.TabIndex = 1;
            this.numeLabel.Text = "Nume";
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(269, 13);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(155, 22);
            this.numeTextBox.TabIndex = 2;
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Location = new System.Drawing.Point(472, 16);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(65, 17);
            this.prenumeLabel.TabIndex = 3;
            this.prenumeLabel.Text = "Prenume";
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(551, 13);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(155, 22);
            this.prenumeTextBox.TabIndex = 4;
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
            // sexGroupBox
            // 
            this.sexGroupBox.Controls.Add(this.femininRadioButton);
            this.sexGroupBox.Controls.Add(this.masculinRadioButton);
            this.sexGroupBox.Location = new System.Drawing.Point(197, 105);
            this.sexGroupBox.Name = "sexGroupBox";
            this.sexGroupBox.Size = new System.Drawing.Size(200, 41);
            this.sexGroupBox.TabIndex = 7;
            this.sexGroupBox.TabStop = false;
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(472, 69);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(56, 17);
            this.telefonLabel.TabIndex = 8;
            this.telefonLabel.Text = "Telefon";
            // 
            // salariuLabel
            // 
            this.salariuLabel.AutoSize = true;
            this.salariuLabel.Location = new System.Drawing.Point(472, 123);
            this.salariuLabel.Name = "salariuLabel";
            this.salariuLabel.Size = new System.Drawing.Size(52, 17);
            this.salariuLabel.TabIndex = 9;
            this.salariuLabel.Text = "Salariu";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(500, 172);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 50);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(606, 172);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(551, 66);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(155, 22);
            this.telefonTextBox.TabIndex = 12;
            // 
            // salariuTextBox
            // 
            this.salariuTextBox.Location = new System.Drawing.Point(551, 120);
            this.salariuTextBox.Name = "salariuTextBox";
            this.salariuTextBox.Size = new System.Drawing.Size(155, 22);
            this.salariuTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Nastere";
            // 
            // dataNastereTimePicker
            // 
            this.dataNastereTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dataNastereTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNastereTimePicker.Location = new System.Drawing.Point(269, 64);
            this.dataNastereTimePicker.Name = "dataNastereTimePicker";
            this.dataNastereTimePicker.Size = new System.Drawing.Size(155, 22);
            this.dataNastereTimePicker.TabIndex = 15;
            // 
            // AdaugaVanzatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 234);
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
            this.Name = "AdaugaVanzatorForm";
            this.Text = "Adauga vanzator";
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.sexGroupBox.ResumeLayout(false);
            this.sexGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.Label prenumeLabel;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.RadioButton femininRadioButton;
        private System.Windows.Forms.RadioButton masculinRadioButton;
        private System.Windows.Forms.GroupBox sexGroupBox;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Label salariuLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox salariuTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataNastereTimePicker;
    }
}