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
    public partial class addAgentsForm : Form
    {
        public addAgentsForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = sqlClass.conn;
        MySqlCommand command;
        string agentImg = "";
        private void agentIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Изображение агента";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";

                if (dlg.ShowDialog() == DialogResult.OK)
                { 
                    agentIcon.ImageLocation = dlg.FileName;
                    agentImg = dlg.FileName.Split('\\').Last();
                }                    
            }
        }
            
        private void addAgentBtn_Click_1(object sender, EventArgs e)
        {           
            try { connection.Open(); }
            catch { }
            string stringSql = $"INSERT INTO `agent` " +
                $"(`Title`, `AgentTypeID`, `Address`, `INN`, " +
                $"`KPP`, `DirectorName`, `Phone`, `Email`, " +
                $"`Logo`, `Priority`) VALUES " +
                $"('{agentTitleTextBox.Text}', " +
                $"'{agentTypeComboBox.SelectedIndex + 1}', " +
                $"'{agentAddressTextBox.Text}', " +
                $"'{agentINNNumUD.Value}', " +
                $"'{agentKPPNumUD.Value}', " +
                $"'{directorTextBox.Text}', " +
                $"'{agentPhoneNumberTextBox.Text}', " +
                $"'{agentEmailTextbox.Text}', " +
                $"'{agentIcon.ImageLocation.Split('\\').Last()}', " +
                $"'{agentPriorityNumUD.Value}');";

            command = new MySqlCommand(stringSql, connection);
            try
            {
                if (!File.Exists($"../../agentsIcons/{agentImg}") && agentImg != "")
                    agentIcon.Image.Save($"../../agentsIcons/{agentImg.Split('\\').Last()}",
                        System.Drawing.Imaging.ImageFormat.Png);
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Агент добавлен");

                this.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Не получилось добавить агента");
            }
            try { connection.Close(); }
            catch { }
        }

        private void addAgentsForm_Load(object sender, EventArgs e)
        {

        }

        private void agentIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
