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
using System.Threading;

namespace PopryzhenokPP06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        MySqlConnection connection = sqlClass.conn;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable agentsDt = new DataTable();

        int page = 1;
        int countPages;
        List<int> selectedAgents = new List<int>();


        private void MainForm_Load(object sender, EventArgs e)
        {         
            filterBox.SelectedIndex = 0;
            sortBox.SelectedIndex = 0;
            AscDescComboBox.SelectedIndex = 0;
        }

        void pageListUC_onlinkLabelClick(object obj, int page)
        {            
            render(page);
        }

        void agentEditOrDelete(object obj)
        {
            render();
        }

        void agentMouseDown(AgentUC obj, int id)
        {
            if (obj.BorderStyle == BorderStyle.Fixed3D)
                selectedAgents.Add(id);
            else if (obj.BorderStyle == BorderStyle.FixedSingle)
                try
                {
                    selectedAgents.Remove(id);
                }
                catch { }
            if(selectedAgents.Count > 0)
                changePriorityBtn.Visible = true;
            else
                changePriorityBtn.Visible = false;
        }

        void render(int page = 1)
        {
            agentsPanel.Controls.Clear();
            agentsDt.Rows.Clear();
            agentsDt.Columns.Clear();
            Control c = this.Controls.Find("pageListUC", true).FirstOrDefault();
            if(c != null)
                this.Controls.Remove(c);        
            command = new MySqlCommand(createSqlString(), connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(agentsDt);
            if(agentsDt.Rows.Count != 0)
            {
                agentsDt.Columns.Add("Discount", typeof(System.Int32));
                foreach (DataRow row in agentsDt.Rows)
                {
                    if (row[2].ToString() != "")
                    {
                        if (Convert.ToInt32(row[2]) < 10000)
                            row[9] = 0;
                        else if (10000 <= Convert.ToInt32(row[2]) && Convert.ToInt32(row[2]) < 50000)
                            row[9] = 5;
                        else if (50000 <= Convert.ToInt32(row[2]) && Convert.ToInt32(row[2]) < 150000)
                            row[9] = 10;
                        else if (150000 <= Convert.ToInt32(row[2]) && Convert.ToInt32(row[2]) < 500000)                        
                            row[9] = 20;                        
                        else if (500000 < Convert.ToInt32(row[2]))                        
                            row[9] = 25;                  
                    }
                    else
                        row[9] = 0;
                }
                countPages = Convert.ToInt32(Math.Ceiling(agentsDt.Rows.Count / 10.0));
                pageListUC pageListUC = new pageListUC(page, countPages);
                pageListUC.Location = new Point(425, 550);
                this.Controls.Add(pageListUC);
                pageListUC.onLinkLabelClick += new pageListUC.CallFormMethod(pageListUC_onlinkLabelClick);

                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        DataRow row = agentsDt.Rows[(page - 1) * 10 + i];

                        AgentUC agentUC = new AgentUC((int)row[0]);
                        agentUC.Controls["agentTitle"].Text = $"{row[5]} | {row[1]}";
                        if (row[6].ToString() != "")
                            agentUC.Controls["agentSales"].Text = $"{row[6]} Продаж за год";
                        else
                            agentUC.Controls["agentSales"].Text = $"0 Продаж за год";
                        agentUC.Controls["agentPhoneNumber"].Text = $"{row[3]}";
                        agentUC.Controls["agentPriority"].Text = $"Приоритетность: {row[7]}";
                        agentUC.Controls["agentDiscount"].Text = $"{row[9]} %";

                        if (row[8].ToString() != "" && File.Exists($"../../agentsIcons/{row[8]}"))
                            try
                            {
                                (agentUC.Controls["agentIcon"] as PictureBox).ImageLocation = $"../../agentsIcons/{row[8]}";
                            }
                            catch { }
                        else
                        {
                            (agentUC.Controls["agentIcon"] as PictureBox).ImageLocation = $"../../agentsIcons/picture.png";
                        }
                            
                        try
                        {
                            if (Convert.ToInt32(row[9]) >= 25)
                                agentUC.BackColor = System.Drawing.ColorTranslator.FromHtml("#46B29D");
                        }
                        catch { }

                        agentUC.agentEditOrDelete += new AgentUC.CallFormMethod(agentEditOrDelete);
                        agentUC.agentMouseDown += new AgentUC.selectAgent(agentMouseDown);

                        agentsPanel.Controls.Add(agentUC);
                    }
                    catch { }
                    pageView.Text = $"Страница: {page}/{countPages}";
                }
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
                searchBox.Text = "";
                sortBox.SelectedIndex = 0;
                filterBox.SelectedIndex = 0;
                AscDescComboBox.SelectedIndex = 0;
                render();
            }            
        }

        string createSqlString()
        {
            string sqlString = "Select * from agentsoutput";
            if (filterBox.SelectedIndex != 0)
                sqlString += $" where agentType = '{filterBox.Text}'";
            if (searchBox.Text != "")
                if (filterBox.SelectedIndex != 0)
                    sqlString += $" and (`Название Агента` like concat('%','{searchBox.Text}', '%'))" +
                        $" or (`Phone` like concat('%','{searchBox.Text}', '%'))" +
                        $" or (`Email` like concat('%','{searchBox.Text}', '%'))";
                else
                    sqlString += $" where (`Название Агента` like concat('%','{searchBox.Text}', '%'))" +
                                $" or (`Phone` like concat('%','{searchBox.Text}', '%'))" +
                                $" or (`Email` like concat('%','{searchBox.Text}', '%'))";
            if (sortBox.SelectedIndex == 0)
                sqlString += $" order by `Название Агента`";
            else if (sortBox.SelectedIndex == 1)
                sqlString += $" order by `Сумма продаж`";
            else if (sortBox.SelectedIndex == 2)
                sqlString += $" order by `Priority`";
            if (AscDescComboBox.SelectedIndex == 0)
                sqlString += $" ASC";
            else
                sqlString += $" DESC";
             return sqlString;
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAllComboBoxes();
        }

        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAllComboBoxes();
        }

        private void AscDescComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAllComboBoxes();
        }

        void checkAllComboBoxes()
        {
            if (filterBox.SelectedIndex != -1 &&
                sortBox.SelectedIndex != -1 &&
                AscDescComboBox.SelectedIndex != -1)
            {
                render();
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                render(page);
            }
        }

        private void addAgentButton_Click(object sender, EventArgs e)
        {
            addAgentsForm addAgentsForm = new addAgentsForm();
            if (addAgentsForm.ShowDialog() == DialogResult.Cancel)
            {
                render();
            }
        }

        private void changePriorityBtn_Click(object sender, EventArgs e)
        {
            changePriorityForm changePriorityForm = new changePriorityForm(selectedAgents);
            if(changePriorityForm.ShowDialog() == DialogResult.Cancel)
            {
                render();
            }
        }
    }
}
