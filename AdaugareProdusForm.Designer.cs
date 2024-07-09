namespace Proiect_Vanzari
{
    partial class AdaugareProdusForm
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
            this.introducereLabel = new System.Windows.Forms.Label();
            this.denumireLabel = new System.Windows.Forms.Label();
            this.descriereLabel = new System.Windows.Forms.Label();
            this.pretLabel = new System.Windows.Forms.Label();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.descriereRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cantitateLabel = new System.Windows.Forms.Label();
            this.cantitateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // introducereLabel
            // 
            this.introducereLabel.AutoSize = true;
            this.introducereLabel.Location = new System.Drawing.Point(12, 9);
            this.introducereLabel.Name = "introducereLabel";
            this.introducereLabel.Size = new System.Drawing.Size(219, 17);
            this.introducereLabel.TabIndex = 0;
            this.introducereLabel.Text = "Introduceti urmatoarele informatii:";
            // 
            // denumireLabel
            // 
            this.denumireLabel.AutoSize = true;
            this.denumireLabel.Location = new System.Drawing.Point(13, 47);
            this.denumireLabel.Name = "denumireLabel";
            this.denumireLabel.Size = new System.Drawing.Size(69, 17);
            this.denumireLabel.TabIndex = 1;
            this.denumireLabel.Text = "Denumire";
            // 
            // descriereLabel
            // 
            this.descriereLabel.AutoSize = true;
            this.descriereLabel.Location = new System.Drawing.Point(13, 76);
            this.descriereLabel.Name = "descriereLabel";
            this.descriereLabel.Size = new System.Drawing.Size(69, 17);
            this.descriereLabel.TabIndex = 2;
            this.descriereLabel.Text = "Descriere";
            // 
            // pretLabel
            // 
            this.pretLabel.AutoSize = true;
            this.pretLabel.Location = new System.Drawing.Point(13, 229);
            this.pretLabel.Name = "pretLabel";
            this.pretLabel.Size = new System.Drawing.Size(34, 17);
            this.pretLabel.TabIndex = 3;
            this.pretLabel.Text = "Pret";
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.Location = new System.Drawing.Point(84, 44);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(278, 22);
            this.denumireTextBox.TabIndex = 4;
            // 
            // descriereRichTextBox
            // 
            this.descriereRichTextBox.Location = new System.Drawing.Point(84, 76);
            this.descriereRichTextBox.Name = "descriereRichTextBox";
            this.descriereRichTextBox.Size = new System.Drawing.Size(278, 142);
            this.descriereRichTextBox.TabIndex = 5;
            this.descriereRichTextBox.Text = "";
            // 
            // pretTextBox
            // 
            this.pretTextBox.Location = new System.Drawing.Point(84, 226);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(85, 22);
            this.pretTextBox.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(262, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 50);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(156, 260);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 50);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cantitateLabel
            // 
            this.cantitateLabel.AutoSize = true;
            this.cantitateLabel.Location = new System.Drawing.Point(180, 229);
            this.cantitateLabel.Name = "cantitateLabel";
            this.cantitateLabel.Size = new System.Drawing.Size(64, 17);
            this.cantitateLabel.TabIndex = 9;
            this.cantitateLabel.Text = "Cantitate";
            // 
            // cantitateTextBox
            // 
            this.cantitateTextBox.Location = new System.Drawing.Point(277, 226);
            this.cantitateTextBox.Name = "cantitateTextBox";
            this.cantitateTextBox.Size = new System.Drawing.Size(85, 22);
            this.cantitateTextBox.TabIndex = 10;
            // 
            // AdaugareProdusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 322);
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
            this.Name = "AdaugareProdusForm";
            this.Text = "Adauga produs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introducereLabel;
        private System.Windows.Forms.Label denumireLabel;
        private System.Windows.Forms.Label descriereLabel;
        private System.Windows.Forms.Label pretLabel;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.RichTextBox descriereRichTextBox;
        private System.Windows.Forms.TextBox pretTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label cantitateLabel;
        private System.Windows.Forms.TextBox cantitateTextBox;
    }
}