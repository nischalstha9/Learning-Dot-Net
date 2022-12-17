using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorldCup
{
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            List <int> JerseyNos = new List<int> ();
            for (int i=1; i<=100; i++)
            {
                JerseyNos.Add (i);
            }
            PlayerJerseyNoComboBox.DataSource = JerseyNos;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress; Initial Catalog=WorldCup; Integrated Security=True");
            String pname = PlayerNameTextBox.Text;
            String position = PlayerPositionComboBox.Text;
            int jno = Convert.ToInt32(PlayerJerseyNoComboBox.Text);
            String stmt = $"Insert into Player (Name, Position, JerseyNo, CId) VALUES ('{pname}', '{position}', '{jno}', 1)";
            SqlCommand command = new SqlCommand(stmt, conn);
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Player added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("There was error inserting Player!");
            }
            finally {
                command.Connection.Close();
            }
            
        }

        private void DisplayPlayersBtn_Click(object sender, EventArgs e)
        {
            new ViewPlayers().Show();
        }
    }
}
