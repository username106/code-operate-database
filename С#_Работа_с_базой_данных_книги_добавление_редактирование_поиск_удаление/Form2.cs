using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DD
{
    public partial class Form2 : Form
    {

        
        public Form2()
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
            Archiv.Rows.Clear();
            for (int i = 0; i < ID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(Archiv);
                newRow.Cells[0].Value = ID[i];
                newRow.Cells[1].Value = AuthorID[i];
                newRow.Cells[2].Value = Title[i];
                newRow.Cells[3].Value = VIzdID[i];
                newRow.Cells[4].Value = IzdID[i];
                newRow.Cells[5].Value = count[i];
                newRow.Cells[6].Value = PlcIzdID[i];
                newRow.Cells[7].Value = Date[i];
                Archiv.Rows.Add(newRow);
            }
        }
        Point Cordinate;
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - Cordinate.X;
                this.Top += e.Y - Cordinate.Y;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            Cordinate = new Point(e.X, e.Y);
        }

        private void Form2_Load(object sender, EventArgs e)
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
    }
}

