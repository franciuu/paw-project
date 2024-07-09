namespace Proiect_Vanzari
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gestiuneGroupBox = new System.Windows.Forms.GroupBox();
            this.vanzatoriButton = new System.Windows.Forms.Button();
            this.produseButton = new System.Windows.Forms.Button();
            this.clientiButton = new System.Windows.Forms.Button();
            this.comenziButton = new System.Windows.Forms.Button();
            this.sistemLabel1 = new System.Windows.Forms.Label();
            this.sistemLabel2 = new System.Windows.Forms.Label();
            this.marketPictureBox = new System.Windows.Forms.PictureBox();
            this.gestiuneGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gestiuneGroupBox
            // 
            this.gestiuneGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.gestiuneGroupBox.Controls.Add(this.vanzatoriButton);
            this.gestiuneGroupBox.Controls.Add(this.produseButton);
            this.gestiuneGroupBox.Controls.Add(this.clientiButton);
            this.gestiuneGroupBox.Controls.Add(this.comenziButton);
            this.gestiuneGroupBox.Location = new System.Drawing.Point(489, 138);
            this.gestiuneGroupBox.Name = "gestiuneGroupBox";
            this.gestiuneGroupBox.Size = new System.Drawing.Size(318, 348);
            this.gestiuneGroupBox.TabIndex = 0;
            this.gestiuneGroupBox.TabStop = false;
            this.gestiuneGroupBox.Text = "Date disponibile";
            // 
            // vanzatoriButton
            // 
            this.vanzatoriButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.vanzatoriButton.Location = new System.Drawing.Point(6, 261);
            this.vanzatoriButton.Name = "vanzatoriButton";
            this.vanzatoriButton.Size = new System.Drawing.Size(306, 50);
            this.vanzatoriButton.TabIndex = 3;
            this.vanzatoriButton.Text = "Vanzatori";
            this.vanzatoriButton.UseVisualStyleBackColor = false;
            this.vanzatoriButton.Click += new System.EventHandler(this.vanzatoriButton_Click);
            // 
            // produseButton
            // 
            this.produseButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.produseButton.Location = new System.Drawing.Point(6, 187);
            this.produseButton.Name = "produseButton";
            this.produseButton.Size = new System.Drawing.Size(306, 50);
            this.produseButton.TabIndex = 2;
            this.produseButton.Text = "Produse";
            this.produseButton.UseVisualStyleBackColor = false;
            this.produseButton.Click += new System.EventHandler(this.produseButton_Click);
            // 
            // clientiButton
            // 
            this.clientiButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clientiButton.Location = new System.Drawing.Point(6, 111);
            this.clientiButton.Name = "clientiButton";
            this.clientiButton.Size = new System.Drawing.Size(306, 50);
            this.clientiButton.TabIndex = 1;
            this.clientiButton.Text = "Clienti";
            this.clientiButton.UseVisualStyleBackColor = false;
            this.clientiButton.Click += new System.EventHandler(this.clientiButton_Click);
            // 
            // comenziButton
            // 
            this.comenziButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comenziButton.Location = new System.Drawing.Point(6, 37);
            this.comenziButton.Name = "comenziButton";
            this.comenziButton.Size = new System.Drawing.Size(306, 50);
            this.comenziButton.TabIndex = 0;
            this.comenziButton.Text = "Comenzi";
            this.comenziButton.UseVisualStyleBackColor = false;
            this.comenziButton.Click += new System.EventHandler(this.comenziButton_Click);
            // 
            // sistemLabel1
            // 
            this.sistemLabel1.AutoSize = true;
            this.sistemLabel1.BackColor = System.Drawing.Color.Transparent;
            this.sistemLabel1.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sistemLabel1.Location = new System.Drawing.Point(105, 39);
            this.sistemLabel1.Name = "sistemLabel1";
            this.sistemLabel1.Size = new System.Drawing.Size(538, 35);
            this.sistemLabel1.TabIndex = 1;
            this.sistemLabel1.Text = "Sistem de management";
            // 
            // sistemLabel2
            // 
            this.sistemLabel2.AutoSize = true;
            this.sistemLabel2.BackColor = System.Drawing.Color.Transparent;
            this.sistemLabel2.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sistemLabel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sistemLabel2.Location = new System.Drawing.Point(18, 74);
            this.sistemLabel2.Name = "sistemLabel2";
            this.sistemLabel2.Size = new System.Drawing.Size(734, 35);
            this.sistemLabel2.TabIndex = 2;
            this.sistemLabel2.Text = "al vanzarilor in supermarket";
            // 
            // marketPictureBox
            // 
            this.marketPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("marketPictureBox.Image")));
            this.marketPictureBox.Location = new System.Drawing.Point(12, 39);
            this.marketPictureBox.Name = "marketPictureBox";
            this.marketPictureBox.Size = new System.Drawing.Size(454, 579);
            this.marketPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.marketPictureBox.TabIndex = 4;
            this.marketPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(831, 505);
            this.Controls.Add(this.sistemLabel2);
            this.Controls.Add(this.sistemLabel1);
            this.Controls.Add(this.gestiuneGroupBox);
            this.Controls.Add(this.marketPictureBox);
            this.Name = "MainForm";
            this.Text = "Bine ati venit!";
            this.gestiuneGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marketPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gestiuneGroupBox;
        private System.Windows.Forms.Button produseButton;
        private System.Windows.Forms.Button clientiButton;
        private System.Windows.Forms.Button comenziButton;
        private System.Windows.Forms.Button vanzatoriButton;
        private System.Windows.Forms.Label sistemLabel1;
        private System.Windows.Forms.Label sistemLabel2;
        private System.Windows.Forms.PictureBox marketPictureBox;
    }
}

