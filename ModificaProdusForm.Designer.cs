namespace Proiect_Vanzari
{
    partial class ModificaProdusForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.descriereRichTextBox = new System.Windows.Forms.RichTextBox();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.pretLabel = new System.Windows.Forms.Label();
            this.descriereLabel = new System.Windows.Forms.Label();
            this.denumireLabel = new System.Windows.Forms.Label();
            this.introducereLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.cantitateTextBox = new System.Windows.Forms.TextBox();
            this.cantitateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(206, 275);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 49);
            this.okButton.TabIndex = 19;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(287, 275);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 49);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pretTextBox
            // 
            this.pretTextBox.Location = new System.Drawing.Point(84, 247);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(85, 22);
            this.pretTextBox.TabIndex = 17;
            // 
            // descriereRichTextBox
            // 
            this.descriereRichTextBox.Location = new System.Drawing.Point(84, 97);
            this.descriereRichTextBox.Name = "descriereRichTextBox";
            this.descriereRichTextBox.Size = new System.Drawing.Size(278, 142);
            this.descriereRichTextBox.TabIndex = 16;
            this.descriereRichTextBox.Text = "";
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.Location = new System.Drawing.Point(84, 65);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(278, 22);
            this.denumireTextBox.TabIndex = 15;
            // 
            // pretLabel
            // 
            this.pretLabel.AutoSize = true;
            this.pretLabel.Location = new System.Drawing.Point(13, 250);
            this.pretLabel.Name = "pretLabel";
            this.pretLabel.Size = new System.Drawing.Size(34, 17);
            this.pretLabel.TabIndex = 14;
            this.pretLabel.Text = "Pret";
            // 
            // descriereLabel
            // 
            this.descriereLabel.AutoSize = true;
            this.descriereLabel.Location = new System.Drawing.Point(13, 97);
            this.descriereLabel.Name = "descriereLabel";
            this.descriereLabel.Size = new System.Drawing.Size(69, 17);
            this.descriereLabel.TabIndex = 13;
            this.descriereLabel.Text = "Descriere";
            // 
            // denumireLabel
            // 
            this.denumireLabel.AutoSize = true;
            this.denumireLabel.Location = new System.Drawing.Point(13, 68);
            this.denumireLabel.Name = "denumireLabel";
            this.denumireLabel.Size = new System.Drawing.Size(69, 17);
            this.denumireLabel.TabIndex = 12;
            this.denumireLabel.Text = "Denumire";
            // 
            // introducereLabel
            // 
            this.introducereLabel.AutoSize = true;
            this.introducereLabel.Location = new System.Drawing.Point(12, 9);
            this.introducereLabel.Name = "introducereLabel";
            this.introducereLabel.Size = new System.Drawing.Size(239, 17);
            this.introducereLabel.TabIndex = 11;
            this.introducereLabel.Text = "Modificati informatiile despre produs:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(43, 32);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(90, 22);
            this.idTextBox.TabIndex = 36;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(13, 35);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 35;
            this.idLabel.Text = "ID:";
            // 
            // cantitateTextBox
            // 
            this.cantitateTextBox.Location = new System.Drawing.Point(277, 247);
            this.cantitateTextBox.Name = "cantitateTextBox";
            this.cantitateTextBox.Size = new System.Drawing.Size(85, 22);
            this.cantitateTextBox.TabIndex = 21;
            // 
            // cantitateLabel
            // 
            this.cantitateLabel.AutoSize = true;
            this.cantitateLabel.Location = new System.Drawing.Point(180, 250);
            this.cantitateLabel.Name = "cantitateLabel";
            this.cantitateLabel.Size = new System.Drawing.Size(64, 17);
            this.cantitateLabel.TabIndex = 20;
            this.cantitateLabel.Text = "Cantitate";
            // 
            // ModificaProdusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 339);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cantitateTextBox);
            this.Controls.Add(this.cantitateLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.pretTextBox);
            this.Controls.Add(this.descriereRichTextBox);
            this.Controls.Add(this.denumireTextBox);
            this.Controls.Add(this.pretLabel);
            this.Controls.Add(this.descriereLabel);
            this.Controls.Add(this.denumireLabel);
            this.Controls.Add(this.introducereLabel);
            this.Name = "ModificaProdusForm";
            this.Text = "Modifica produs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox pretTextBox;
        private System.Windows.Forms.RichTextBox descriereRichTextBox;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.Label pretLabel;
        private System.Windows.Forms.Label descriereLabel;
        private System.Windows.Forms.Label denumireLabel;
        private System.Windows.Forms.Label introducereLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox cantitateTextBox;
        private System.Windows.Forms.Label cantitateLabel;
    }
}