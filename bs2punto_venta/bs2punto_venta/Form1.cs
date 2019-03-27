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

namespace bs2punto_venta
{
    public partial class Form1 : Form
    {
        MySqlConnection mySqlConnecion;
        MySqlCommand mySqlCommand;
        MySqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }
        private void cargadatos()
        {
            try
            {
                dataGridView1.Rows.Clear();
                mySqlConnecion = new MySqlConnection("host=localhost;user=root;password=1234;database=punto_ventas;"); // String de connexion
                mySqlConnecion.Open();
                mySqlCommand = new MySqlCommand("SELECT * FROM productos", mySqlConnecion);
                reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetString(0), (reader.GetString(1)), (reader.GetString(2)), (reader.GetString(3)));
                }
                mySqlConnecion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargadatos();  
        }
    }
}
