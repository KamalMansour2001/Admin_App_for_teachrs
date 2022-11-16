using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using DataTable = System.Data.DataTable;
using ExcelDataReader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace importera_exportera_kunskapcampinet
{
    public partial class Admin : Form
    {
        MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; userid = root; port = 3308; password = ; database = test; Convert Zero Datetime = True;");
        MySqlCommand? cmd;
        DataTable dt = new DataTable();
        List<string> elevlista = new List<string>(6);

        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 80);
            listView1.Columns.Add("Naman", 170);
            listView1.Columns.Add("Inloggning", 130);
            listView1.Columns.Add("Utloggning", 130);
            this.listView1.View = View.Details;
        }

        private void btnXlsSkrivare_Click(object sender, EventArgs e)
        {
            var temp = conn.State.ToString();
            if (temp == "Open")
            {
                savfDatan.InitialDirectory = "B:";
                savfDatan.Title = "Save as excel fil";
                savfDatan.FileName = "eleverinfo";
                savfDatan.Filter = "Excel File(2003)|*.xls";

                if (savfDatan.ShowDialog() != DialogResult.Cancel && txtID.Text.Length == 0)
                {
                    object misvalue = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Visible = false;
                    Microsoft.Office.Interop.Excel.Workbook wb = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;


                    cmd = new MySqlCommand("select * from kunskapscompaniet_elever", conn);
                    MySqlDataAdapter sda = new MySqlDataAdapter();  //byt till adapter sen
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    sda.Update(dt);

                    ws = (Worksheet)ExcelApp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                    ws.Name = "kunskapscompaniet_elever";

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                        }
                    }

                    wb.SaveAs(savfDatan.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);
                    wb.Close(true, misvalue, misvalue);
                    ExcelApp.Quit();

                    MessageBox.Show("Klart!");
                }

                else if (savfDatan.ShowDialog() != DialogResult.Cancel && txtID.Text.Length >= 1)
                {
                    object misvalue = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Visible = false;

                    Microsoft.Office.Interop.Excel.Workbook wb = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;


                    cmd = new MySqlCommand("select * from kunskapscompaniet_elever WHERE ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    MySqlDataAdapter sda = new MySqlDataAdapter();  //byt till adapter sen
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    sda.Update(dt);

                    ws = (Worksheet)ExcelApp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                    ws.Name = "kunskapscompaniet_elever";

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                        }
                    }

                    wb.SaveAs(savfDatan.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);
                    wb.Close(true, misvalue, misvalue);
                    ExcelApp.Quit();

                    MessageBox.Show("Klart!");
                }
            }
            else
            {
                conn.Open();
                savfDatan.InitialDirectory = "B:";
                savfDatan.Title = "Save as excel fil";
                savfDatan.FileName = "eleverinfo";
                savfDatan.Filter = "Excel File(2003)|*.xls";

                if (savfDatan.ShowDialog() != DialogResult.Cancel && txtID.Text.Length == 0)
                {
                    object misvalue = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Visible = false;
                    Microsoft.Office.Interop.Excel.Workbook wb = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;


                    cmd = new MySqlCommand("select * from kunskapscompaniet_elever", conn);
                    MySqlDataAdapter sda = new MySqlDataAdapter();  //byt till adapter sen
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    sda.Update(dt);

                    ws = (Worksheet)ExcelApp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                    ws.Name = "kunskapscompaniet_elever";

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                        }
                    }

                    wb.SaveAs(savfDatan.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);
                    wb.Close(true, misvalue, misvalue);
                    ExcelApp.Quit();

                    MessageBox.Show("Klart!");
                }

                else if (savfDatan.ShowDialog() != DialogResult.Cancel && txtID.Text.Length >= 1)
                {
                    object misvalue = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    ExcelApp.Visible = false;

                    Microsoft.Office.Interop.Excel.Workbook wb = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;


                    cmd = new MySqlCommand("select * from kunskapscompaniet_elever WHERE ID = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    MySqlDataAdapter sda = new MySqlDataAdapter();  //byt till adapter sen
                    sda.SelectCommand = cmd;
                    sda.Fill(dt);
                    sda.Update(dt);

                    ws = (Worksheet)ExcelApp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                    ws.Name = "kunskapscompaniet_elever";

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                        }
                    }

                    wb.SaveAs(savfDatan.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);
                    wb.Close(true, misvalue, misvalue);
                    ExcelApp.Quit();

                    MessageBox.Show("Klart!");
                }
            }

        }

        private void btnNyElev_Click(object sender, EventArgs e)
        {
            string insertQury = "INSERT INTO kunskapcompaniet_elev_info (id, namn, password) VALUES('" + txtID.Text + "','" + txtNamn.Text + "'," + int.Parse(txtPassword.Text) + ")";
            var temp = conn.State.ToString();
            if (temp == "Open")
            {
                cmd = new MySqlCommand(insertQury, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Ny elev skapades är sparad!");
                    txtID.Clear();
                    txtNamn.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Fel påträffad");
                }
                   conn.Close();
            }
            else
            {
                conn.Open();
                cmd = new MySqlCommand(insertQury, conn);

                if (cmd.ExecuteNonQuery() == 1)
                {
                   MessageBox.Show("Ny elev skapades är sparad!");
                   txtID.Clear();
                   txtNamn.Clear();
                   txtPassword.Clear();
                }
                else
                {
                   MessageBox.Show("Fel påträffad");
                }
                   conn.Close();
                
            }
            

        }

        private void btnVisaElev_Click(object sender, EventArgs e)
        {
            
            var temp = conn.State.ToString();
            if (temp == "Open") //Kollar ifall conniction med databasen är open.
            {
                listView1.Items.Clear();
                MySqlCommand alldata = new MySqlCommand("select * from kunskapcompaniet_elev_info", conn); //Selectar data från tabellen
                alldata = new MySqlCommand("select * from kunskapscompaniet_elever WHERE ID = @ID", conn);//Sätter en filter med hjäp av ID
                alldata.Parameters.AddWithValue("@ID", txtID.Text);

                MySqlDataReader dataReader = alldata.ExecuteReader();
                
                while (dataReader.Read()) //En loop som går igenom varje rad i tabellen.
                {
                    int ID = (int)dataReader["ID"];
                    string namn = (string)dataReader["namn"];
                    DateTime inloggning = (DateTime)dataReader["inloggning"];
                    DateTime utloggning = (DateTime)dataReader["utloggning"];
                    
                    
                    ListViewItem item = new ListViewItem(new String[] { ID.ToString(), namn, inloggning.ToString(), utloggning.ToString() });
                    item.Tag = item;
                    listView1.Items.Add(item);

                }
                dataReader.Close();
            }
            else
            {
                conn.Open();
                listView1.Items.Clear();
                MySqlCommand alldata = new MySqlCommand("select * from kunskapcompaniet_elev_info", conn);
                alldata = new MySqlCommand("select * from kunskapscompaniet_elever WHERE ID = @ID", conn);
                alldata.Parameters.AddWithValue("@ID", txtID.Text);

                MySqlDataReader dataReader = alldata.ExecuteReader();
                while (dataReader.Read())
                {
                    int ID = (int)dataReader["ID"];
                    string namn = (string)dataReader["namn"];
                    DateTime inloggning = (DateTime)dataReader["inloggning"];
                    DateTime utloggning = (DateTime)dataReader["utloggning"];


                    ListViewItem item = new ListViewItem(new String[] { ID.ToString(), namn, inloggning.ToString(), utloggning.ToString() });
                    item.Tag = item;
                    listView1.Items.Add(item);

                }
                dataReader.Close();
                conn.Close();

            }

        }


    }
}