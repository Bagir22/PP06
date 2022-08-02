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

namespace PopryzhenokPP06
{
    public partial class changePriorityForm : Form
    {
        MySqlConnection connection = sqlClass.conn;
        MySqlCommand command;
        List<int> changedAgents;
        public changePriorityForm(List<int> agents)
        {
            InitializeComponent();
            changedAgents = agents;
        }

        private void changePriorityForm_Load(object sender, EventArgs e)
        {

        }

        private void changePriorityBtn_Click(object sender, EventArgs e)
        {
            foreach(int agent in changedAgents)
            {
                try
                {
                    string sql = $"UPDATE `agent` SET " +
                                        $"`Priority` = '{PriorityValue.Value}' " +
                                        $"WHERE (`ID` = '{agent}');";
                    command = new MySqlCommand(sql, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Приоритет агента изменен");
                }
                catch
                {
                    MessageBox.Show("Не получилось изменить\nприоритет агента");
                }
            }
        }
    }
}
