using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DD
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            GetData();
        }
        ConnectionDB con = new ConnectionDB();


        private static ArrayList ID = new ArrayList();
        private static ArrayList AuthorID = new ArrayList();
        private static ArrayList Title = new ArrayList();
        private static ArrayList VIzdID = new ArrayList();
        private static ArrayList IzdID = new ArrayList();
        private static ArrayList count = new ArrayList();
        private static ArrayList PlcIzdID = new ArrayList();
        private static ArrayList Date = new ArrayList();
        private void GetData()
        {
            try
            {
                con.Open();
                string query = "SELECT `книга_код`,`Фамилия`,`Название`,`Наименование`,`НаименованиеИ`,`Кол_Во_Страниц`,`Место`,`Дата_издания`FROM `книга`INNER JOIN `автор` ON `книга`.`автор_код`= `автор`.`Автор_код`INNER JOIN `вид_издания` ON `книга`.`ВидИздание`= `вид_издания`.`вид_издания_код`INNER JOIN `издательство` ON `книга`.`Издательство`= `издательство`.`издательство_код`INNER JOIN `местоиздан` ON `книга`.`МестоИзд_id`= `местоиздан`.`местоИздан_код`";


                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ID.Add(row["книга_код"].ToString());
                        AuthorID.Add(row["Фамилия"].ToString());
                        Title.Add(row["Название"].ToString());
                        VIzdID.Add(row["Наименование"].ToString());
                        IzdID.Add(row["НаименованиеИ"].ToString());
                        count.Add(row["Кол_Во_Страниц"].ToString());
                        PlcIzdID.Add(row["Место"].ToString());
                        Date.Add(row["Дата_издания"].ToString());

                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        private void updateDatagrid()
        {
            Archiv1.Rows.Clear();
            for (int i = 0; i < ID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(Archiv1);
                newRow.Cells[0].Value = ID[i];
                newRow.Cells[1].Value = AuthorID[i];
                newRow.Cells[2].Value = Title[i];
                newRow.Cells[3].Value = VIzdID[i];
                newRow.Cells[4].Value = IzdID[i];
                newRow.Cells[5].Value = count[i];
                newRow.Cells[6].Value = PlcIzdID[i];
                newRow.Cells[7].Value = Date[i];
                Archiv1.Rows.Add(newRow);
            }
        }
        Point Cordinate;
        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - Cordinate.X;
                this.Top += e.Y - Cordinate.Y;
            }
        }

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            Cordinate = new Point(e.X, e.Y);
        }

        private void srchbut_Click(object sender, EventArgs e)
        {
            String srchstring = Srchbar.Text;
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand srch = new MySqlCommand("SELECT * FROM `книга` WHERE `Название`= @s", db.getConnection());
            srch.Parameters.Add("@s", MySqlDbType.VarChar).Value = srchstring;
            adapter.SelectCommand = srch;
            adapter.Fill(table);



            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < Archiv1.RowCount; i++)
                {
                    Archiv1.Rows[i].Selected = false;
                    for (int j = 0; j < Archiv1.ColumnCount; j++)
                        if (Archiv1.Rows[i].Cells[j].Value != null)
                            if (Archiv1.Rows[i].Cells[j].Value.ToString().Contains(Srchbar.Text))
                            {

                                Archiv1.Rows[i].Selected = true;
                                Archiv1.Focus();
                                Archiv1.CurrentCell = Archiv1.Rows[i].Cells[3];
                                break;
                            }
                }


                MessageBox.Show("данные найдены!");
            }



            else
            {
                MessageBox.Show("данные не найдены!");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            GetData();
            if (ID.Count > 0)
            {
                updateDatagrid();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            String srchstring = Srchbar.Text;
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand srch = new MySqlCommand("DELETE FROM `книга` WHERE `книга`.`Название`= @s", db.getConnection());
            srch.Parameters.Add("@s", MySqlDbType.VarChar).Value = srchstring;
            adapter.SelectCommand = srch;
            adapter.Fill(table);
            MessageBox.Show("данные удалены!");
            this.Close();



           
                
            
        }
    }
    
}

