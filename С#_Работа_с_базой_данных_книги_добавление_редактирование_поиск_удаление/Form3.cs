using MySql.Data.MySqlClient;
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

namespace DD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            GetData();

        }
        //kolectia vvod-------------------------------

        ConnectionDB con = new ConnectionDB();

        //arraylist to getter and setter data  
        private static ArrayList ID = new ArrayList();
        private static ArrayList Firstname = new ArrayList();
        private static ArrayList scndname = new ArrayList();
        private static ArrayList thidname = new ArrayList();
        
        //kolectia---------------------------------------
        Point Cordinate;
        private void Form3_MouseDown_1(object sender, MouseEventArgs e)
        {
            Cordinate = new Point(e.X, e.Y);
        }

        private void Form3_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - Cordinate.X;
                this.Top += e.Y - Cordinate.Y;
            }
        }

        
        private void ConfirmButton_Click(object sender, EventArgs e)
        {


            
        //    String AuO = AuthorO.Text;
        //    DB db = new DB();

        //    DataTable table = new DataTable();
         //   MySqlDataAdapter adapter = new MySqlDataAdapter();
        //    MySqlCommand srch = new MySqlCommand("SELECT `Автор_код`,`Фамилия`,`Имя`,`Отчество` FROM `автор`WHERE `Фамилия`=@f AND `Имя`=@n AND `Отчество`=@o", db.getConnection());

            
        //    srch.Parameters.Add("@o", MySqlDbType.VarChar).Value = AuO;
        //    adapter.SelectCommand = srch;
        //    adapter.Fill(table);



         //   if (table.Rows.Count > 0)
         //   {
                //NAXOJDENIE ID----------------------------------
     //           ConnectionDB con = new ConnectionDB();
       //         con.Open();
              //  string query = "SELECT `Автор_код`,`Фамилия`,`Имя`,`Отчество` FROM `автор`WHERE `Фамилия`='" + AuF + "'AND `Имя`='" + AuN + "' AND `Отчество`= '" + AuO + "'";

        //        MySqlDataReader row;
            //    row = con.ExecuteReader(query);
         //       if (row.HasRows)
          //      {

         //       }
                //NAXOJDENIE ID----------------------------------DOBOVLENIE ID V DB
                //MySqlCommand add = new MySqlCommand("INSERT INTO `книга`(`автор_код`)VALUES("+ID+ ")", db.getConnection());
                //   adapter.SelectCommand = add;
                //   adapter.Fill(table);

         //   }
      //  }

      //  private void button1_Click(object sender, EventArgs e)
     //   {

          //  String AuF = AuthorF.Text;
           // String AuN = AuthorN.Text;
       //     String AuO = AuthorO.Text;
       //     ConnectionDB con = new ConnectionDB();

        //    con.Open();
       //     string query = "SELECT `автор_код`,`Фамилия`,`Имя`,`Отчество` FROM `автор`";


            //MySqlDataReader row;  
        //    MySqlDataReader row;
       //     row = con.ExecuteReader(query);
       //     if (row.HasRows)
        //    {
        //        while (row.Read())
       //         {
        //            ID.Add(row["автор_код"].ToString());

      //          }
       //     }
       //     else
       //     {
       //         MessageBox.Show("Data not found");
      //      }

           



        //    AUt.Rows.Clear();
       //     for (int i = 0; i < ID.Count; i++)
        //    {
        //        DataGridViewRow newRow = new DataGridViewRow();

       //         newRow.CreateCells(AUt);
       //         newRow.Cells[0].Value = ID[i];


        //    }
       }

        private void Form3_Load(object sender, EventArgs e)
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
        private void GetData()
        {
            try
            {
                con.Open();
                string query = " SELECT `автор_код`,`Фамилия`,`Имя`,`Отчество` FROM `автор`";

                //MySqlDataReader row;  
                MySqlDataReader row;
                row = con.ExecuteReader(query);
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ID.Add(row["автор_код"].ToString());
                        Firstname.Add(row["Фамилия"].ToString());
                        scndname.Add(row["Имя"].ToString());
                        thidname.Add(row["Отчество"].ToString());
                        
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
            AUt.Rows.Clear();
            for (int i = 0; i < ID.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(AUt);
                newRow.Cells[0].Value =  ID[i];
                newRow.Cells[1].Value = Firstname[i];
                newRow.Cells[2].Value = scndname[i];
                newRow.Cells[3].Value = thidname[i];
                
            }
        }

        private void BookTi_TextChanged(object sender, EventArgs e)
        {

        }

        private void VidIz_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }          
}
          
