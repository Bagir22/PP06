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
    public partial class productSaleForm : Form
    {
        MySqlConnection connection = sqlClass.conn;
        MySqlCommand command;
        MySqlDataReader reader;
        int agentId;
        public productSaleForm(int id)
        {
            InitializeComponent();
            agentId = id;
        }

        private void productSaleForm_Load(object sender, EventArgs e)
        {
            render();
        }

        private void realizationListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && 
                realizationListBox.CheckedItems.Count >= 0)
                    deleteProductSaleBtn.Enabled = true;
            else if (e.NewValue == CheckState.Unchecked && 
                realizationListBox.CheckedItems.Count <= 1)
                    deleteProductSaleBtn.Enabled = false;
        }

        private void deleteProductSaleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in realizationListBox.CheckedItems)
                {
                    string id = item.ToString().Split(' ')[0];
                    try
                    {
                        connection.Open();
                        string sql = $"DELETE FROM `productsale` " +
                            $"WHERE (`ProductID` = '{id}');";
                        command = new MySqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        realizationListBox.Items.Remove(item);
                        MessageBox.Show($"Реализация продукта {id} удалена");
                        connection.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Не получилось удалить выбранный продукт");
                    }
                }
            }
            catch
            {
                this.Close();
            }
        }

        private void addProductSaleBtn_Click(object sender, EventArgs e)
        {
            addProductSaleForm addProductSaleForm = new addProductSaleForm(agentId);
            if (addProductSaleForm.ShowDialog() == DialogResult.Cancel)
            {
                render();
            }
        }

        void render()
        {
            try
            {
                realizationListBox.Items.Clear();
                string sql = $"SELECT ProductID, Title, SaleDate, ProductCount " +
                $"FROM pp06.productsale join product " +
                $"on productsale.ProductID = product.ID " +
                $"where agentID = {agentId} " +
                $"order by SaleDate";
                command = new MySqlCommand(sql, connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        realizationListBox.Items.Add($"{reader.GetValue(0)}" +
                            $" | {reader.GetValue(1)}" +
                            $" | {reader.GetValue(3)}" +
                            $" | {Convert.ToDateTime(reader.GetValue(2)).Date.ToShortDateString()}");
                    }
                }
                else
                {
                    MessageBox.Show("История реализации для\nданного агента не найдена");
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("История реализации для\nданного агента не найдена");
            }
        }
    }
}
