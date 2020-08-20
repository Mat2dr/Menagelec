namespace Menagelec
{
    partial class GestionCommande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCommande));
            this.labelGestionCommandes2 = new System.Windows.Forms.Label();
            this.labellistecommandes = new System.Windows.Forms.Label();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.checkBoxPayer = new System.Windows.Forms.CheckBox();
            this.checkBoxExpedition = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelCp = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCivilite = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOkExpedition = new System.Windows.Forms.Button();
            this.buttonOkPaiement = new System.Windows.Forms.Button();
            this.pictureBoxExpedition = new System.Windows.Forms.PictureBox();
            this.pictureBoxPaiement = new System.Windows.Forms.PictureBox();
            this.labelExpedition = new System.Windows.Forms.Label();
            this.labelPaiement = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelElement1 = new System.Windows.Forms.Label();
            this.labelCommandeSelect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.textBoxCommande = new System.Windows.Forms.TextBox();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDocument = new System.Windows.Forms.Label();
            this.buttonColissage = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.labelElement2 = new System.Windows.Forms.Label();
            this.labelContentCommande = new System.Windows.Forms.Label();
            this.labelContentClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpedition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaiement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGestionCommandes2
            // 
            this.labelGestionCommandes2.AutoSize = true;
            this.labelGestionCommandes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionCommandes2.ForeColor = System.Drawing.Color.White;
            this.labelGestionCommandes2.Location = new System.Drawing.Point(366, 9);
            this.labelGestionCommandes2.Name = "labelGestionCommandes2";
            this.labelGestionCommandes2.Size = new System.Drawing.Size(220, 24);
            this.labelGestionCommandes2.TabIndex = 0;
            this.labelGestionCommandes2.Text = "Gestion des commandes";
            // 
            // labellistecommandes
            // 
            this.labellistecommandes.AutoSize = true;
            this.labellistecommandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellistecommandes.ForeColor = System.Drawing.Color.White;
            this.labellistecommandes.Location = new System.Drawing.Point(54, 76);
            this.labellistecommandes.Name = "labellistecommandes";
            this.labellistecommandes.Size = new System.Drawing.Size(164, 20);
            this.labellistecommandes.TabIndex = 1;
            this.labellistecommandes.Text = "Liste des commandes";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.ForeColor = System.Drawing.Color.White;
            this.checkBoxAll.Location = new System.Drawing.Point(22, 115);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(48, 17);
            this.checkBoxAll.TabIndex = 2;
            this.checkBoxAll.Text = "Tout";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // checkBoxPayer
            // 
            this.checkBoxPayer.AutoSize = true;
            this.checkBoxPayer.ForeColor = System.Drawing.Color.White;
            this.checkBoxPayer.Location = new System.Drawing.Point(96, 115);
            this.checkBoxPayer.Name = "checkBoxPayer";
            this.checkBoxPayer.Size = new System.Drawing.Size(62, 17);
            this.checkBoxPayer.TabIndex = 3;
            this.checkBoxPayer.Text = "A payer";
            this.checkBoxPayer.UseVisualStyleBackColor = true;
            this.checkBoxPayer.CheckedChanged += new System.EventHandler(this.checkBoxPayer_CheckedChanged);
            // 
            // checkBoxExpedition
            // 
            this.checkBoxExpedition.AutoSize = true;
            this.checkBoxExpedition.ForeColor = System.Drawing.Color.White;
            this.checkBoxExpedition.Location = new System.Drawing.Point(177, 115);
            this.checkBoxExpedition.Name = "checkBoxExpedition";
            this.checkBoxExpedition.Size = new System.Drawing.Size(76, 17);
            this.checkBoxExpedition.TabIndex = 4;
            this.checkBoxExpedition.Text = "A expédier";
            this.checkBoxExpedition.UseVisualStyleBackColor = true;
            this.checkBoxExpedition.CheckedChanged += new System.EventHandler(this.checkBoxExpedition_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 151);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(292, 444);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelTel);
            this.groupBox1.Controls.Add(this.labelMail);
            this.groupBox1.Controls.Add(this.labelVille);
            this.groupBox1.Controls.Add(this.labelCp);
            this.groupBox1.Controls.Add(this.labelAdresse);
            this.groupBox1.Controls.Add(this.labelPrenom);
            this.groupBox1.Controls.Add(this.labelNom);
            this.groupBox1.Controls.Add(this.labelCivilite);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(371, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 175);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "fffffff";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(6, 159);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(67, 13);
            this.labelTel.TabIndex = 7;
            this.labelTel.Text = "Teléphone : ";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(6, 133);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(75, 13);
            this.labelMail.TabIndex = 6;
            this.labelMail.Text = "Adresse mail : ";
            // 
            // labelVille
            // 
            this.labelVille.AutoSize = true;
            this.labelVille.Location = new System.Drawing.Point(80, 101);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(48, 13);
            this.labelVille.TabIndex = 5;
            this.labelVille.Text = "labelVille";
            // 
            // labelCp
            // 
            this.labelCp.AutoSize = true;
            this.labelCp.Location = new System.Drawing.Point(6, 101);
            this.labelCp.Name = "labelCp";
            this.labelCp.Size = new System.Drawing.Size(42, 13);
            this.labelCp.TabIndex = 4;
            this.labelCp.Text = "labelCp";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Location = new System.Drawing.Point(6, 69);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(67, 13);
            this.labelAdresse.TabIndex = 3;
            this.labelAdresse.Text = "labelAdresse";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(150, 31);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(65, 13);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "labelPrenom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(80, 31);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(51, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "labelNom";
            // 
            // labelCivilite
            // 
            this.labelCivilite.AutoSize = true;
            this.labelCivilite.Location = new System.Drawing.Point(6, 31);
            this.labelCivilite.Name = "labelCivilite";
            this.labelCivilite.Size = new System.Drawing.Size(59, 13);
            this.labelCivilite.TabIndex = 0;
            this.labelCivilite.Text = "labelCivilite";
            this.labelCivilite.Click += new System.EventHandler(this.labelCivilite_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonOkExpedition);
            this.groupBox2.Controls.Add(this.buttonOkPaiement);
            this.groupBox2.Controls.Add(this.pictureBoxExpedition);
            this.groupBox2.Controls.Add(this.pictureBoxPaiement);
            this.groupBox2.Controls.Add(this.labelExpedition);
            this.groupBox2.Controls.Add(this.labelPaiement);
            this.groupBox2.Controls.Add(this.labelDate);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(370, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 106);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // buttonOkExpedition
            // 
            this.buttonOkExpedition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOkExpedition.Location = new System.Drawing.Point(88, 77);
            this.buttonOkExpedition.Name = "buttonOkExpedition";
            this.buttonOkExpedition.Size = new System.Drawing.Size(32, 19);
            this.buttonOkExpedition.TabIndex = 13;
            this.buttonOkExpedition.Text = "ok";
            this.buttonOkExpedition.UseVisualStyleBackColor = true;
            this.buttonOkExpedition.Visible = false;
            this.buttonOkExpedition.Click += new System.EventHandler(this.buttonOkExpedition_Click);
            // 
            // buttonOkPaiement
            // 
            this.buttonOkPaiement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOkPaiement.Location = new System.Drawing.Point(88, 49);
            this.buttonOkPaiement.Name = "buttonOkPaiement";
            this.buttonOkPaiement.Size = new System.Drawing.Size(32, 19);
            this.buttonOkPaiement.TabIndex = 12;
            this.buttonOkPaiement.Text = "ok";
            this.buttonOkPaiement.UseVisualStyleBackColor = true;
            this.buttonOkPaiement.Visible = false;
            this.buttonOkPaiement.Click += new System.EventHandler(this.buttonOkPaiement_Click);
            // 
            // pictureBoxExpedition
            // 
            this.pictureBoxExpedition.Location = new System.Drawing.Point(68, 80);
            this.pictureBoxExpedition.Name = "pictureBoxExpedition";
            this.pictureBoxExpedition.Size = new System.Drawing.Size(14, 13);
            this.pictureBoxExpedition.TabIndex = 11;
            this.pictureBoxExpedition.TabStop = false;
            // 
            // pictureBoxPaiement
            // 
            this.pictureBoxPaiement.Location = new System.Drawing.Point(68, 52);
            this.pictureBoxPaiement.Name = "pictureBoxPaiement";
            this.pictureBoxPaiement.Size = new System.Drawing.Size(14, 13);
            this.pictureBoxPaiement.TabIndex = 10;
            this.pictureBoxPaiement.TabStop = false;
            // 
            // labelExpedition
            // 
            this.labelExpedition.AutoSize = true;
            this.labelExpedition.Location = new System.Drawing.Point(10, 80);
            this.labelExpedition.Name = "labelExpedition";
            this.labelExpedition.Size = new System.Drawing.Size(56, 13);
            this.labelExpedition.TabIndex = 9;
            this.labelExpedition.Text = "Expédition";
            // 
            // labelPaiement
            // 
            this.labelPaiement.AutoSize = true;
            this.labelPaiement.Location = new System.Drawing.Point(10, 52);
            this.labelPaiement.Name = "labelPaiement";
            this.labelPaiement.Size = new System.Drawing.Size(51, 13);
            this.labelPaiement.TabIndex = 8;
            this.labelPaiement.Text = "Paiement";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(10, 24);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(28, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "date";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(372, 450);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(253, 150);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // labelElement1
            // 
            this.labelElement1.AutoSize = true;
            this.labelElement1.ForeColor = System.Drawing.Color.White;
            this.labelElement1.Location = new System.Drawing.Point(12, 135);
            this.labelElement1.Name = "labelElement1";
            this.labelElement1.Size = new System.Drawing.Size(107, 13);
            this.labelElement1.TabIndex = 10;
            this.labelElement1.Text = "Nombre d\'élement :   ";
            // 
            // labelCommandeSelect
            // 
            this.labelCommandeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommandeSelect.ForeColor = System.Drawing.Color.White;
            this.labelCommandeSelect.Location = new System.Drawing.Point(311, 76);
            this.labelCommandeSelect.Name = "labelCommandeSelect";
            this.labelCommandeSelect.Size = new System.Drawing.Size(313, 20);
            this.labelCommandeSelect.TabIndex = 6;
            this.labelCommandeSelect.Text = "Informations de la commande sélectionnée";
            this.labelCommandeSelect.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelCommandeSelect.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(683, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Recherche spécifique";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxClient
            // 
            this.textBoxClient.Location = new System.Drawing.Point(661, 180);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(184, 20);
            this.textBoxClient.TabIndex = 12;
            // 
            // textBoxCommande
            // 
            this.textBoxCommande.Location = new System.Drawing.Point(662, 228);
            this.textBoxCommande.Name = "textBoxCommande";
            this.textBoxCommande.Size = new System.Drawing.Size(184, 20);
            this.textBoxCommande.TabIndex = 13;
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.ForeColor = System.Drawing.Color.White;
            this.labelRechercher.Location = new System.Drawing.Point(661, 164);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(106, 13);
            this.labelRechercher.TabIndex = 14;
            this.labelRechercher.Text = "Rechercher un client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(665, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rechercher une commande";
            // 
            // labelDocument
            // 
            this.labelDocument.AutoSize = true;
            this.labelDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocument.ForeColor = System.Drawing.Color.White;
            this.labelDocument.Location = new System.Drawing.Point(713, 271);
            this.labelDocument.Name = "labelDocument";
            this.labelDocument.Size = new System.Drawing.Size(91, 20);
            this.labelDocument.TabIndex = 16;
            this.labelDocument.Text = "Documents";
            this.labelDocument.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // buttonColissage
            // 
            this.buttonColissage.Location = new System.Drawing.Point(661, 323);
            this.buttonColissage.Name = "buttonColissage";
            this.buttonColissage.Size = new System.Drawing.Size(184, 38);
            this.buttonColissage.TabIndex = 17;
            this.buttonColissage.Text = "Liste de colisage";
            this.buttonColissage.UseVisualStyleBackColor = true;
            this.buttonColissage.Click += new System.EventHandler(this.buttonColissage_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(823, 555);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(87, 38);
            this.buttonMenu.TabIndex = 18;
            this.buttonMenu.Text = "Retour au menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(851, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(852, 234);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // labelElement2
            // 
            this.labelElement2.AutoSize = true;
            this.labelElement2.Location = new System.Drawing.Point(369, 434);
            this.labelElement2.Name = "labelElement2";
            this.labelElement2.Size = new System.Drawing.Size(35, 13);
            this.labelElement2.TabIndex = 21;
            this.labelElement2.Text = "label1";
            // 
            // labelContentCommande
            // 
            this.labelContentCommande.AutoSize = true;
            this.labelContentCommande.Location = new System.Drawing.Point(299, 30);
            this.labelContentCommande.Name = "labelContentCommande";
            this.labelContentCommande.Size = new System.Drawing.Size(35, 13);
            this.labelContentCommande.TabIndex = 22;
            this.labelContentCommande.Text = "label1";
            this.labelContentCommande.Visible = false;
            // 
            // labelContentClient
            // 
            this.labelContentClient.AutoSize = true;
            this.labelContentClient.Location = new System.Drawing.Point(227, 30);
            this.labelContentClient.Name = "labelContentClient";
            this.labelContentClient.Size = new System.Drawing.Size(35, 13);
            this.labelContentClient.TabIndex = 23;
            this.labelContentClient.Text = "label4";
            this.labelContentClient.Visible = false;
            // 
            // GestionCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(84)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(922, 605);
            this.Controls.Add(this.labelContentClient);
            this.Controls.Add(this.labelContentCommande);
            this.Controls.Add(this.labelElement2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonColissage);
            this.Controls.Add(this.labelDocument);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRechercher);
            this.Controls.Add(this.textBoxCommande);
            this.Controls.Add(this.textBoxClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelElement1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCommandeSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxExpedition);
            this.Controls.Add(this.checkBoxPayer);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.labellistecommandes);
            this.Controls.Add(this.labelGestionCommandes2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionCommande";
            this.Text = "Gestion des commandes";
            this.Load += new System.EventHandler(this.GestionCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpedition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaiement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGestionCommandes2;
        private System.Windows.Forms.Label labellistecommandes;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.CheckBox checkBoxPayer;
        private System.Windows.Forms.CheckBox checkBoxExpedition;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelElement1;
        private System.Windows.Forms.Label labelCommandeSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.TextBox textBoxCommande;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDocument;
        private System.Windows.Forms.Button buttonColissage;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label labelElement2;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelCp;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCivilite;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelExpedition;
        private System.Windows.Forms.Label labelPaiement;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBoxExpedition;
        private System.Windows.Forms.PictureBox pictureBoxPaiement;
        private System.Windows.Forms.Button buttonOkExpedition;
        private System.Windows.Forms.Button buttonOkPaiement;
        private System.Windows.Forms.Label labelContentCommande;
        private System.Windows.Forms.Label labelContentClient;
    }
}