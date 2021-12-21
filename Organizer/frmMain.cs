using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class frmMain : Form
    {
        public static string connectionString = "Server=LAPTOP-0AFOURN8\\SQLEXPRESS;Database=Organizer;Trusted_Connection=True;";
        int themeID = 0;

        public frmMain()
        {
            InitializeComponent();
            SqlCommand commandRead = new SqlCommand(); //выполняем соединение и передачу id и темы
            commandRead.CommandText = "select * from tbl_Theme1";
            commandRead.Connection = new SqlConnection(frmMain.connectionString);
            commandRead.Connection.Open();
            SqlDataReader reader = commandRead.ExecuteReader();
            List<Theme> themes = new List<Theme>();
            while (reader.Read())
            {
                themes.Add(new Theme { ID = (int)reader["ID"], Name = (string)reader["Theme"] });

            }
            commandRead.Connection.Close();
            cbThemeID.DataSource = themes;
            cbThemeID.ValueMember = "ID";
            cbThemeID.DisplayMember = "Name";
            cbSelectColumns.SelectedIndexChanged += cbSelectColumns_SelectedIndexChanged;
            ShowData();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        //передавать название столбца из комбобокс и в нем искать то, что написано в текстбокс
        int columnValue;
        private void cbSelectColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            columnValue = cbSelectColumns.SelectedIndex;  
        }
        public void ShowData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (tbEventFilter.Text.Length > 0) //для поиск-фильтра
            {
                switch (columnValue)
                {
                    case 0:
                        {
                            adapter = new SqlDataAdapter("select * from tbl_Organizer left join tbl_Theme1 on tbl_Organizer.ThemeID=tbl_Theme1.ID where tbl_Theme1.Theme like '%" + tbEventFilter.Text + "%'", connectionString); //меняем индексы темы на названия тем
                            break;
                        }
                    case 1:
                        {
                            adapter = new SqlDataAdapter("select * from tbl_Organizer left join tbl_Theme1 on tbl_Organizer.ThemeID=tbl_Theme1.ID where tbl_Organizer.Event like '%" + tbEventFilter.Text + "%'", connectionString);
                            break;
                        }
                    case 2:
                        {
                            adapter = new SqlDataAdapter("select * from tbl_Organizer left join tbl_Theme1 on tbl_Organizer.ThemeID=tbl_Theme1.ID where tbl_Organizer.Remark like '%" + tbEventFilter.Text + "%'", connectionString);
                            break;
                        }
                    case 3:
                        {
                            adapter = new SqlDataAdapter("select * from tbl_Organizer left join tbl_Theme1 on tbl_Organizer.ThemeID=tbl_Theme1.ID where tbl_Organizer.Link like '%" + tbEventFilter.Text + "%'", connectionString);
                            break;
                        }
                    case 4:
                        {
                            adapter = new SqlDataAdapter("select * from tbl_Organizer left join tbl_Theme1 on tbl_Organizer.ThemeID=tbl_Theme1.ID where tbl_Organizer.Text like '%" + tbEventFilter.Text + "%'", connectionString);
                            break;
                        }
                }
            }
            else
            {
                adapter = new SqlDataAdapter("select * from tbl_Organizer left join tbl_Theme1 on tbl_Organizer.ThemeID=tbl_Theme1.ID", connectionString);
            }
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvData.DataSource = table;
            dgvData.Columns["ID"].Visible = false;
            dgvData.Columns["ID1"].Visible = false;
            dgvData.Columns["ThemeID"].Visible = false;
            dgvData.Columns["Date"].HeaderText = "Дата создания";
            dgvData.Columns["Theme"].HeaderText = "Тема";
            dgvData.Columns["Theme"].DisplayIndex = 2;
            dgvData.Columns["Event"].HeaderText = "Событие";
            dgvData.Columns["Remark"].HeaderText = "Примечание";
            dgvData.Columns["Link"].HeaderText = "Ссылка";
            dgvData.Columns["Text"].HeaderText = "Текст";
        }
        private void btn_TestConnection_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            //try
            //{
            //    connection.Open();
            //    MessageBox.Show("OK");
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btn_DataReader_Click(object sender, EventArgs e)
        {
        //    SqlCommand commandRead = new SqlCommand();
        //    commandRead.CommandText = "select * from tbl_Organizer where Event='День рождения'";
        //    commandRead.Connection = new SqlConnection(connectionString);
        //    commandRead.Connection.Open();
        //    SqlDataReader reader = commandRead.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Console.WriteLine(reader["ID"] + " " + reader["Name"]);
        //    }
        //    commandRead.Connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd(0);
            if (f.ShowDialog() == DialogResult.OK)
            {
                ShowData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ThisRow = dgvData.CurrentCell.RowIndex; //выбираем конкретную строку
            int ID = int.Parse(dgvData["ID", ThisRow].EditedFormattedValue.ToString());
            frmAdd frm = new frmAdd(ID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ShowData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ThisRow = dgvData.CurrentCell.RowIndex; //выбираем конкретную строку
            int ID = int.Parse(dgvData["ID", ThisRow].EditedFormattedValue.ToString());
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.Connection = new SqlConnection(connectionString);
            deleteCommand.CommandText = "delete from tbl_Organizer where ID=" + ID;
            deleteCommand.Connection.Open();
            deleteCommand.ExecuteNonQuery();
            deleteCommand.Connection.Close();

            ShowData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowData();
        }

       

        private void cbThemeID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            themeID = (int)cbThemeID.SelectedValue;
        }
        private void btnStoredProcedure_Click(object sender, EventArgs e) //встроенная процедура
        {
            SqlCommand commandProcedure = new SqlCommand();
            commandProcedure.CommandText = "GetCountTheme";
            commandProcedure.Connection = new SqlConnection(connectionString);
            commandProcedure.CommandType = CommandType.StoredProcedure;
            commandProcedure.Parameters.AddWithValue("@ThemeID", themeID); //передаем параметр

            SqlParameter pCountTheme = new SqlParameter();
            pCountTheme.ParameterName = "@CountTheme";
            pCountTheme.SqlDbType = SqlDbType.Decimal;
            pCountTheme.Direction = ParameterDirection.Output; //параметр, который мы получаем
            commandProcedure.Parameters.Add(pCountTheme);

            commandProcedure.Connection.Open();
            commandProcedure.ExecuteNonQuery();
            commandProcedure.Connection.Close();
            MessageBox.Show(pCountTheme.Value.ToString());
        }

        private void cbSelectColumns_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }
        
    }
}
