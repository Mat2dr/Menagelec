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

namespace Menagelec
{
    public partial class FicheProduit : Form
    {
        public FicheProduit(string ID)
        {
            InitializeComponent();

            MySqlConnection con3 = new MySqlConnection("Server=localhost;Database=menagelec;Uid=root;Pwd=;");
            con3.Open();

            MySqlCommand comGet = new MySqlCommand("SELECT designation, description, prix, fichierImage FROM produit WHERE idProduit=" + ID, con3);
            MySqlDataReader reader = comGet.ExecuteReader();


            while (reader.Read())
            {
                labelNomProduit.Text = (reader["designation"].ToString());
                labelPrix.Text = (reader["prix"].ToString()) + "€";

                if (reader["description"].ToString() == "")
                {
                    labelDescriptionProduit.Text = "Aucune description";
                }
                else
                {
                    labelDescriptionProduit.Text = (reader["description"].ToString());
                }



                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = @"C:\Users\krako\source\repos\Menagelec\imagesProduit\" + (reader["fichierImage"].ToString());
            }

            reader.Close();
        }

        private void FicheProduit_Load(object sender, EventArgs e)
        {

        }
    }
}
