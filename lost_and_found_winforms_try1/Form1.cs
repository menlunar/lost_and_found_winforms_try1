using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace lost_and_found_winforms_try1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable sqlData = new DataTable();            //creates a new data table

        //READ

        //shows data on gridview
        public void upLoadData()
        {
            string sqlConn = "server = localhost; port = 3306; database = lost_and_found; user = root; password = password";
            MySqlConnection conn = new MySqlConnection(sqlConn);


            conn.Open();

            string sql = "SELECT * FROM lost_and_found.lost_items";   //sql query
            MySqlCommand cmd = new MySqlCommand(sql, conn);         //creates sql query to connection and put it in variable "cmd"

            MySqlDataReader sqlRd = cmd.ExecuteReader();     //executes sql command (cmd data reader) to connect sql database to program database, reads sql data     

            sqlData.Load(sqlRd);                            //reads data on sql database and puts it in sqlData variable
            dataGridView1.DataSource = sqlData;             //shows data on grid view


            sqlRd.Close();                                 //closes read data

            conn.Close();

        }

        //uploads data when program initially loads
        private void Form1_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        //cell click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                textBox_itemID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); //puts the value of the first cell (cell[0]) of the selected row converted to string to the textBox item_id
                textBox_itemName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); //puts the value of the second cell (cell[0]) of the selected row converted to string to the textBox item_id
                textBox_ownerName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); //puts the value of the third cell (cell[0]) of the selected row converted to string to the textBox item_id
                textBox_locationFound.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(); //puts the value of the fourth cell (cell[0]) of the selected row converted to string to the textBox item_id
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //CREATE

        //Insert data to Database
        private void btn_submit_Click(object sender, EventArgs e)
        {

            string sqlConn = "server = localhost; port = 3306; database = lost_and_found; user = root; password = password";

            MySqlConnection conn = new MySqlConnection(sqlConn);

            try
            {

                conn.Open();

                string sql = "INSERT INTO lost_and_found.lost_items (item_ID, item_name, owner_name, found_location) VALUES " +
                    "(" + textBox_itemID.Text + ",' " + textBox_itemName.Text + "', '" + textBox_ownerName.Text + "', '" + textBox_locationFound.Text + "')"; //sql non-query

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                upLoadData();
                MessageBox.Show("Lost item added to database");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


 

        
        //DELETE

        //deletes items on database
      
        private void btn_claim_Click_1(object sender, EventArgs e)
        {
            string sqlConn = "server = localhost; port = 3306; database = lost_and_found; user = root; password = password";

            MySqlConnection conn = new MySqlConnection(sqlConn);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                
                cmd.CommandText = "DELETE FROM lost_and_found.lost_items WHERE (item_ID = '" +
                    textBox_itemID.Text + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                conn.Close();

                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }

                upLoadData();
                MessageBox.Show("Item claimed!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        //UPDATE
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string sqlConn = "server = localhost; port = 3306; database = lost_and_found; user = root; password = password";

            MySqlConnection conn = new MySqlConnection(sqlConn);

            try
            {
                conn.Open();

               
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "UPDATE lost_items SET item_id = '" + textBox_itemID.Text + "'" +
                    ", item_name = '" + textBox_itemName.Text + "'" +
                    ", owner_name = '" + textBox_ownerName.Text + "'" +
                    ", found_location = '" + textBox_locationFound.Text + "'" +
                    " WHERE item_id = '" + textBox_itemID.Text + "';";
                cmd.CommandType = CommandType.Text;
              
                cmd.Connection = conn;

                cmd.ExecuteNonQuery();
                conn.Close();

                upLoadData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataView dv = sqlData.DefaultView;
                dv.RowFilter = String.Format("item_name like '%{0}%'", textBox_Search.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
