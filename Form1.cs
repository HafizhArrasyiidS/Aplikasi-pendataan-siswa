using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobacoba
{
    public partial class Login : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Ada yang belum di isi");
            }
            else
            {
                Koneksi.conn.Open();
                String query = "SELECT * FROM `users` WHERE `email` = '" + txtusername.Text + "' AND `password` = '" + txtpassword.Text + "'";
                cmd = new MySqlCommand(query, Koneksi.conn);
                dr = cmd.ExecuteReader();

                try
                {
                    if (dr.Read())
                    {
                        new Dashboard().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ups! Username atau Password anda Salah");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Ups! Gagal Login");
                }

                Koneksi.conn.Close();
            }
        }
    }
}
