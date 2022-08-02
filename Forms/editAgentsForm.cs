using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace PopryzhenokPP06
{
    public partial class editAgentsForm : Form
    {
        int agentId;
        MySqlConnection connection = sqlClass.conn;
        MySqlCommand command;
        MySqlDataReader reader;
        string agentImg = "";
        public editAgentsForm(int id)
        {
            InitializeComponent();
            agentId = id;
        }

        private void editAgentsForm_Load(object sender, EventArgs e)
        {
            string stringSql = $"Select * from agent where ID = {agentId}";
            command = new MySqlCommand(stringSql, connection);
            connection.Open();
            using (reader = command.ExecuteReader())
            {                
                while (reader.Read())
                {
                    agentTitleTextBox.Text = reader.GetString(1);
                    agentAddressTextBox.Text = reader.GetString(3);
                    agentINNNumUD.Value = reader.GetInt64(4);
                    agentKPPNumUD.Value = reader.GetInt64(5);
                    directorTextBox.Text = reader.GetString(6);
                    agentPhoneNumberTextBox.Text = reader.GetString(7);
                    agentEmailTextbox.Text = reader.GetString(8);
                    agentPriorityNumUD.Value = reader.GetInt32(10);

                    agentTypeComboBox.SelectedIndex = reader.GetInt32(2) - 1;
                    
                    if (reader.GetString(9) != "")
                        agentIcon.ImageLocation = $"../../agentsIcons/{reader.GetString(9)}";
                    else
                        agentIcon.ImageLocation = $"../../agentsIcons/picture.png";
                }
            }
            connection.Close();
        }

        private void agentDeleteBtn_Click(object sender, EventArgs e)
        {
            try { connection.Open(); }
            catch { }
            string stringSql = $"DELETE FROM `agent` WHERE (`ID` = '{agentId}');";
            command = new MySqlCommand(stringSql,connection);
            try
            {                
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Агент удален");                
                this.Close();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Не получилось удалить агента\n" +
                    "Есть информация о реализации продукции");
            }
            try { connection.Close(); }
            catch { }
        }

        private void editAgentBtn_Click(object sender, EventArgs e)
        {
            try { connection.Open(); }
            catch { }
            string stringSql = $"UPDATE `agent` SET " +
                $"`Title` = '{agentTitleTextBox.Text}', " +
                $"`AgentTypeID` = '{agentTypeComboBox.SelectedIndex+1}', " +
                $"`Address` = '{agentAddressTextBox.Text}', " +
                $"`INN` = '{agentINNNumUD.Value}', " +
                $"`KPP` = '{agentKPPNumUD.Value}', " +
                $"`DirectorName` = '{directorTextBox.Text}', " +
                $"`Phone` = '{agentPhoneNumberTextBox.Text}', " +
                $"`Email` = '{agentEmailTextbox.Text}', " +
                $"`Logo` = '{agentIcon.ImageLocation.Split('\\').Last()}', " +
                $"`Priority` = '{agentPriorityNumUD.Value}' " +
                $" WHERE (`ID` = '{agentId}');";
            command = new MySqlCommand(stringSql, connection);
            try
            {                
                if (!File.Exists($"../../agentsIcons/{agentImg}") && agentImg != "")
                    agentIcon.Image.Save($"../../agentsIcons/{agentImg.Split('\\').Last()}", 
                        System.Drawing.Imaging.ImageFormat.Png);
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Агент изменен");
                
                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Не получилось изменить агента");
            }
            try { connection.Close(); }
            catch { }
        }

        private void agentIcon_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Изображение агента";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    agentIcon.ImageLocation = dlg.FileName;
                    agentImg = dlg.FileName.Split('\\').Last();
                    MessageBox.Show(agentImg);
                }
                    
            }
        }
    }
}
