using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCup
{
    public partial class ViewPlayers : Form
    {
        public ViewPlayers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewPlayers_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress; Initial Catalog=WorldCup; Integrated Security=True");
            var sqldataadapter = new SqlDataAdapter("SELECT * FROM Player", conn);
            try
            {
                DataSet players = new DataSet();
                sqldataadapter.Fill(players);
                dataGridView1.DataSource = players.Tables[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("There was error retriving players!");
            }
        }
    }
}
