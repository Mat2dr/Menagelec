using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Menagelec
{
    public partial class GestionCommande : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=menagelec;Uid=root;Pwd=;");

        public GestionCommande()
        {
            InitializeComponent();
            checkBoxAll.Checked = true;
            labelElement1.Text = labelElement1.Text + dataGridView1.Rows.Count.ToString();
          
            
           


        }

        private BindingSource load(string sql)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;
            DataSet ds = new DataSet();
            BindingSource bs = new BindingSource();

            cmd = new MySqlCommand(sql, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);

            bs.DataSource = ds.Tables[0];

            return bs;
            
        }

        

        private void GestionCommande_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            
            
      
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                dataGridView1.DataSource = load("SELECT id,date,client FROM commande WHERE client =" + textBoxClient.Text);
                textBoxClient.BackColor = Color.Purple;
                groupBox1.ForeColor = Color.Purple;
                groupBox1.Text = "Client(Recherche spécifique)";
            }
            else
            {
                
                textBoxClient.BackColor = Color.White;
                groupBox1.ForeColor = Color.FromArgb(192, 64, 0);
                checkBoxAll.Checked = false;
                checkBoxPayer.Checked = false;
                checkBoxExpedition.Checked = false;
                checkBoxAll.Checked = true;

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[0].Selected == true)
            {
                FicheProduit form = new FicheProduit(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                form.Show();
            }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView2.DataSource = load("SELECT produit,quantite FROM lignecommande WHERE commande =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            labelElement2.Text = "Nombre de références dans la commande : " + dataGridView2.Rows.Count.ToString();

            //Insertion des élements dans le groupBox 1 ( Concerne le client)
            labelContentClient.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            groupBox1.Text = "Client " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


            //Insertion dans la groupeBox2 (Concerne la commande)
            labelContentCommande.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            groupBox2.Text = "Commande n°" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Requete pour recuperer tous les élements recherché (Client)
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=menagelec;Uid=root;Pwd=;"))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM CLIENT INNER JOIN commande ON client.idClient = commande.client WHERE idClient = " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " AND commande.id ="+ dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() , connection);
                MySqlDataReader readere = command.ExecuteReader();
                while (readere.Read())
                {
                    //Partie client
                    labelCivilite.Text = (readere["civilite"].ToString());
                    labelNom.Text = (readere["nom"].ToString());
                    labelPrenom.Text = (readere["prenom"].ToString());
                    labelAdresse.Text = (readere["adresse"].ToString());
                    labelVille.Text = (readere["ville"].ToString());
                    labelCp.Text = (readere["cp"].ToString());
                    labelMail.Text = "Mail : " + (readere["mail"].ToString());
                    labelTel.Text = "Télephone : " + (readere["tel"].ToString());

                    //Partie commande
                    labelDate.Text = "date     " + (readere["date"].ToString());

                    //Condition d'attribution de l'image dans nos pictureBox

                    if ((readere["estPayee"].ToString()) == "False")
                    {
                        pictureBoxPaiement.ImageLocation = @"C:\Users\krako\source\repos\Menagelec\Image\etatNotOk.png";
                    }
                    else
                    {
                        pictureBoxPaiement.ImageLocation = @"C:\Users\krako\source\repos\Menagelec\Image\etatOk.png";
                    }

                    if ((readere["estExpediee"].ToString()) == "False")
                    {
                        pictureBoxExpedition.ImageLocation = @"C:\Users\krako\source\repos\Menagelec\Image\etatNotOk.png";
                    }
                    else
                    {
                        pictureBoxExpedition.ImageLocation = @"C:\Users\krako\source\repos\Menagelec\Image\etatOk.png";
                    }

                    //On permet a un bouton, cacher par default de s'afficher si l'élement est en false, puis de se cacher une fois fait

                    if ((readere["estPayee"].ToString()) == "False")
                    {
                        buttonOkPaiement.Visible = true;
                    }
                    else
                    {
                        buttonOkPaiement.Visible = false;

                    }

                    if ((readere["estExpediee"].ToString()) == "False" && (readere["estPayee"].ToString()) == "True")
                    {
                        buttonOkExpedition.Visible = true;
                    }
                    else
                    {
                        buttonOkExpedition.Visible = false;

                    }


                }

            }

            
           


           
           




        }

        private void checkBoxPayer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPayer.Checked == true)
            {
                dataGridView1.DataSource = load("SELECT id,date,client FROM commande WHERE estPayee = 0");
                checkBoxAll.Checked = false;
                checkBoxExpedition.Checked = false;
                labelElement1.Text = "Nombre de références dans la commande : " + dataGridView1.Rows.Count.ToString();
            }
        }

        private void checkBoxExpedition_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExpedition.Checked == true)
            {
                dataGridView1.DataSource = load("SELECT id,date,client FROM commande WHERE estExpediee = 0");
                checkBoxPayer.Checked = false;
                checkBoxAll.Checked = false;
                labelElement1.Text = "Nombre de références dans la commande : " + dataGridView1.Rows.Count.ToString();
            }

        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked == true)
            {
                dataGridView1.DataSource = load("SELECT id,date,client FROM commande");
                checkBoxPayer.Checked = false;
                checkBoxExpedition.Checked = false;
                labelElement1.Text = "Nombre de références dans la commande : " + dataGridView1.Rows.Count.ToString();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void labelCivilite_Click(object sender, EventArgs e)
        {

        }

        
        

        private void buttonOkPaiement_Click(object sender, EventArgs e)
        {
            MySqlConnection con3 = new MySqlConnection("Server=localhost;Database=menagelec;Uid=root;Pwd=;");
            con3.Open();
            MySqlCommand com3 = new MySqlCommand("UPDATE commande SET estPayee = true WHERE id="+labelContentCommande.Text + "",con3);
            com3.ExecuteNonQuery();

            MySqlCommand comGet = new MySqlCommand("SELECT nbCommandeExpediee FROM statistiques WHERE id=1", con3);
            MySqlDataReader reader = comGet.ExecuteReader();

            int nbCommande = 0;

            while (reader.Read())
            {
                nbCommande = Convert.ToInt32(reader["nbCommandeExpediee"].ToString());
            }

            reader.Close();

            nbCommande++;

            MySqlCommand com4 = new MySqlCommand("UPDATE statistiques SET nbCommandeExpediee = " + nbCommande + " WHERE id= 1", con3);
            com4.ExecuteNonQuery();

            checkBoxAll.Checked = false;
            checkBoxExpedition.Checked = false;
            checkBoxPayer.Checked = false;

            checkBoxExpedition.Checked = true;
        }

        private void buttonOkExpedition_Click(object sender, EventArgs e)
        {
            MySqlConnection con3 = new MySqlConnection("Server=localhost;Database=menagelec;Uid=root;Pwd=;");
            con3.Open();
            MySqlCommand com3 = new MySqlCommand("UPDATE commande SET estExpediee = true WHERE id=" + labelContentCommande.Text + "", con3);
            com3.ExecuteNonQuery();

            MySqlCommand comGet = new MySqlCommand("SELECT nbCommandeExpediee FROM statistiques WHERE id=1", con3);
            MySqlDataReader reader = comGet.ExecuteReader();

            int nbCommande = 0;

            while (reader.Read())
            {
                nbCommande = Convert.ToInt32(reader["nbCommandeExpediee"].ToString());
            }

            reader.Close();

            nbCommande++;

            MySqlCommand com4 = new MySqlCommand("UPDATE statistiques SET nbCommandeExpediee = " + nbCommande + " WHERE id= 1", con3);
            com4.ExecuteNonQuery();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                dataGridView1.DataSource = load("SELECT id,date,client FROM commande WHERE id =" + textBoxCommande.Text);
                textBoxCommande.BackColor = Color.Purple;
                groupBox2.ForeColor = Color.Purple;
                groupBox2.Text = "Client(Recherche spécifique)";
            }
            else
            {

                textBoxCommande.BackColor = Color.White;
                groupBox2.ForeColor = Color.FromArgb(192, 64, 0);
                checkBoxAll.Checked = false;
                checkBoxPayer.Checked = false;
                checkBoxExpedition.Checked = false;
                checkBoxAll.Checked = true;

            }
        }

        private void buttonColissage_Click(object sender, EventArgs e)
        {
            //Creer un document en format PDF en spécifiant les marges 
            Document doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,30,30);
            //Creer le fichier dans l'instance en spécifiant comme nom le numéro de la commande
            PdfWriter write = PdfWriter.GetInstance(doc, new FileStream("Commande_"+labelContentCommande.Text+".pdf", FileMode.Create));
            //Ouvre le document afin d'écrire a l'intérieur
            doc.Open();
            Paragraph paragraph = new Paragraph("Contenu de la commande n° " + labelContentCommande.Text);
            paragraph.Alignment = Element.ALIGN_CENTER;
            doc.Add(paragraph);
            //Saut de ligne
            doc.Add(new Chunk("\n"));

            //Creation de la table sur 3 colonne avec attribution des nom
            PdfPTable table = new PdfPTable(3);
            table.AddCell("Reference du produit");
            table.AddCell("Designation");
            table.AddCell("Quantité");

            //Commande qui retrouve toute les produit disponible dans la commande puis les place dans les cellules
            MySqlCommand command = new MySqlCommand("SELECT produit,designation,quantite FROM lignecommande INNER JOIN produit ON lignecommande.produit = produit.idProduit WHERE commande =" + labelContentCommande.Text, con);
            con.Open();
            MySqlDataReader readere = command.ExecuteReader();

            while (readere.Read())
            {
                table.AddCell((readere["produit"].ToString()));
                table.AddCell((readere["designation"].ToString()));
                table.AddCell((readere["quantite"].ToString()));
            }

            readere.Close();

            //Ajout de la table dans le document
            doc.Add(table);


            //Fermeture du document
            doc.Close();

            //Ouverture de notre fichier
            System.Diagnostics.Process.Start("Commande_" + labelContentCommande.Text + ".pdf");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}


