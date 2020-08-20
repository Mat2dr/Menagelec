namespace Menagelec
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonGestionCommandes = new System.Windows.Forms.Button();
            this.labelGestionCommandes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGestionCommandes
            // 
            this.buttonGestionCommandes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGestionCommandes.BackgroundImage")));
            this.buttonGestionCommandes.Location = new System.Drawing.Point(26, 30);
            this.buttonGestionCommandes.Name = "buttonGestionCommandes";
            this.buttonGestionCommandes.Size = new System.Drawing.Size(66, 66);
            this.buttonGestionCommandes.TabIndex = 0;
            this.buttonGestionCommandes.UseVisualStyleBackColor = true;
            this.buttonGestionCommandes.Click += new System.EventHandler(this.buttonGestionCommandes_Click);
            // 
            // labelGestionCommandes
            // 
            this.labelGestionCommandes.AutoSize = true;
            this.labelGestionCommandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionCommandes.ForeColor = System.Drawing.Color.White;
            this.labelGestionCommandes.Location = new System.Drawing.Point(109, 52);
            this.labelGestionCommandes.Name = "labelGestionCommandes";
            this.labelGestionCommandes.Size = new System.Drawing.Size(186, 20);
            this.labelGestionCommandes.TabIndex = 1;
            this.labelGestionCommandes.Text = "Gestion des commandes";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(84)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(318, 262);
            this.Controls.Add(this.labelGestionCommandes);
            this.Controls.Add(this.buttonGestionCommandes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGestionCommandes;
        private System.Windows.Forms.Label labelGestionCommandes;
    }
}