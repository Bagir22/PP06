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
    public partial class addProductSaleForm : Form
    {
        MySqlConnection connection = sqlClass.conn;
        MySqlCommand command;
        MySqlDataReader reader;
        int agentId;
        public addProductSaleForm(int id)
        {
            InitializeComponent();
            agentId = id;
        }


        private void addProductSaleForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void addRealizationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"INSERT INTO `productsale` (`AgentID`, `ProductID`, " +
                    $"`SaleDate`, `ProductCount`) " +
                    $"VALUES ('{agentId}', '{productsList.SelectedIndex + 1}', " +
                    $"'{productSaleDate.Value.Date.ToString("yyyy-MM-dd")}', " +
                    $"'{productCountNUD.Value}');";
                command = new MySqlCommand(sql,connection);
                connection.Open();
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Реализация продукции добавлена");
                    this.Close();
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Не получилось добавить\nреализацию продукции");
                this.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                load();
            }
        }

        void load()
        {
            try
            {
                productsList.Items.Clear();
                string sql = $"select id, Title from product";
                if (productSearch.Text != "")
                    sql += $" where Title like concat('%','{productSearch.Text}', '%')";
                command = new MySqlCommand(sql, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    productsList.Items.Add(reader.GetString(1));
                }
                connection.Close();

                agentName.Text = agentId.ToString();
                productsList.SelectedIndex = 0;
                productSaleDate.MinDate = DateTime.Today;
            }
            catch
            {
                MessageBox.Show("Продукт не найден");
                productSearch.Text = "";
                load();
            }
        }
    }
}
