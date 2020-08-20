namespace Menagelec
{
    partial class FicheProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheProduit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNomProduit = new System.Windows.Forms.Label();
            this.labelDescriptionProduit = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNomProduit
            // 
            this.labelNomProduit.AutoSize = true;
            this.labelNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelNomProduit.ForeColor = System.Drawing.Color.White;
            this.labelNomProduit.Location = new System.Drawing.Point(37, 23);
            this.labelNomProduit.Name = "labelNomProduit";
            this.labelNomProduit.Size = new System.Drawing.Size(53, 20);
            this.labelNomProduit.TabIndex = 1;
            this.labelNomProduit.Text = "label1";
            // 
            // labelDescriptionProduit
            // 
            this.labelDescriptionProduit.AutoSize = true;
            this.labelDescriptionProduit.ForeColor = System.Drawing.Color.White;
            this.labelDescriptionProduit.Location = new System.Drawing.Point(245, 91);
            this.labelDescriptionProduit.Name = "labelDescriptionProduit";
            this.labelDescriptionProduit.Size = new System.Drawing.Size(35, 13);
            this.labelDescriptionProduit.TabIndex = 2;
            this.labelDescriptionProduit.Text = "label1";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.ForeColor = System.Drawing.Color.White;
            this.labelPrix.Location = new System.Drawing.Point(25, 231);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(35, 13);
            this.labelPrix.TabIndex = 3;
            this.labelPrix.Text = "label1";
            // 
            // FicheProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(84)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(622, 282);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labelDescriptionProduit);
            this.Controls.Add(this.labelNomProduit);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FicheProduit";
            this.Text = "Fiche produit";
            this.Load += new System.EventHandler(this.FicheProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNomProduit;
        private System.Windows.Forms.Label labelDescriptionProduit;
        private System.Windows.Forms.Label labelPrix;
    }
}