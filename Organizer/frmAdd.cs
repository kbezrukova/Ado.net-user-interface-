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
    
    public partial class frmAdd : Form
    {
        int themeID = 0;
        int editednotesID = 0;
        public frmAdd(int ID)
        {
            InitializeComponent();
            editednotesID = ID;
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
            cbTheme.DataSource = themes;
            cbTheme.ValueMember = "ID";
            cbTheme.DisplayMember = "Name";

            if (editednotesID != 0) //для передачи информации со строки
            {
                SqlCommand commandReadData = new SqlCommand();
                commandReadData.CommandText = "select * from tbl_Organizer where ID="+ID.ToString();
                commandReadData.Connection = new SqlConnection(frmMain.connectionString);
                commandReadData.Connection.Open();
                SqlDataReader readerData = commandReadData.ExecuteReader();
                while (readerData.Read())
                {
                    tbEvent.Text = (string)readerData["Event"];
                    tbRemark.Text = (string)readerData["Remark"];
                    tbLink.Text = (string)readerData["Link"];
                    tbText.Text = (string)readerData["Text"];
                    dtpDate.Value = (DateTime)readerData["Date"];
                    themeID = (int)readerData["ThemeID"]; //находим порядковый индекс темы
                    int theme_index =themes.IndexOf(themes.Where(m => m.ID == themeID).Single());
                    cbTheme.SelectedIndex = theme_index;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (editednotesID == 0)
            {
                //команда без параметров
                //SqlCommand sqlAddCommand = new SqlCommand();
                //sqlAddCommand.Connection = new SqlConnection(frmMain.connectionString);
                //sqlAddCommand.CommandText = "insert into tbl_Organizer (Date, ThemeID, Event, Remark, Link, Text) values ('" + dtpDate.Value + "','" + themeID + "','" + tbEvent.Text + "', '" + tbRemark.Text + "', '" + tbLink.Text + "', '" + tbText.Text + "')";
                //sqlAddCommand.Connection.Open();
                //sqlAddCommand.ExecuteNonQuery();
                //sqlAddCommand.Connection.Close();
                //this.DialogResult = DialogResult.OK;

                //команда с использованием параметров
                SqlCommand sqlAddCommand = new SqlCommand();
                sqlAddCommand.Connection = new SqlConnection(frmMain.connectionString);
                sqlAddCommand.CommandText = "insert into tbl_Organizer (Date, ThemeID, Event, Remark, Link, Text) values (@Date,@ThemeID,@Event,@Remark,@Link,@Text)";
                SqlParameter parDate = new SqlParameter();
                parDate.SqlDbType = SqlDbType.Date;
                parDate.ParameterName = "@Date";
                parDate.Value = dtpDate.Value;
                sqlAddCommand.Parameters.Add(parDate);

                SqlParameter parThemeID = new SqlParameter();
                parThemeID.SqlDbType = SqlDbType.Int;
                parThemeID.ParameterName = "@ThemeID";
                parThemeID.Value = themeID;
                sqlAddCommand.Parameters.Add(parThemeID);

                SqlParameter parEvent = new SqlParameter();
                parEvent.SqlDbType = SqlDbType.NVarChar;
                parEvent.ParameterName = "@Event";
                parEvent.Value = tbEvent.Text;
                sqlAddCommand.Parameters.Add(parEvent);

                SqlParameter parRemark = new SqlParameter();
                parRemark.SqlDbType = SqlDbType.NVarChar;
                parRemark.ParameterName = "@Remark";
                parRemark.Value = tbRemark.Text;
                sqlAddCommand.Parameters.Add(parRemark);

                SqlParameter parLink = new SqlParameter();
                parLink.SqlDbType = SqlDbType.NVarChar;
                parLink.ParameterName = "@Link";
                parLink.Value = tbLink.Text;
                sqlAddCommand.Parameters.Add(parLink);

                SqlParameter parText = new SqlParameter();
                parText.SqlDbType = SqlDbType.NVarChar;
                parText.ParameterName = "@Text";
                parText.Value = tbText.Text;
                sqlAddCommand.Parameters.Add(parText);

                sqlAddCommand.Connection.Open();
                sqlAddCommand.ExecuteNonQuery();
                sqlAddCommand.Connection.Close();
                this.DialogResult = DialogResult.OK;
            }
            else //update - обновление
            {
                //команда без параметров
                //SqlCommand updateCommand = new SqlCommand();
                //updateCommand.Connection = new SqlConnection(frmMain.connectionString);
                //updateCommand.CommandText = "update tbl_Organizer set Event='" + tbEvent.Text + "', Remark='" + tbRemark.Text + "', Link='" + tbLink.Text + "', Text='" + tbText.Text + "',ThemeID=" + themeID + " where ID=" + editednotesID;
                //updateCommand.Connection.Open();
                //updateCommand.ExecuteNonQuery();
                //updateCommand.Connection.Close();
                //this.DialogResult = DialogResult.OK;

                //команда с параметрами
                SqlCommand updateCommand = new SqlCommand();
                updateCommand.Connection = new SqlConnection(frmMain.connectionString);
                updateCommand.CommandText = "update tbl_Organizer set Event=@Event, Remark=@Remark, Link=@Link, Text=@Text,ThemeID=@ThemeID where ID=@ID";
                updateCommand.Parameters.AddWithValue("@Event", tbEvent.Text);
                updateCommand.Parameters.AddWithValue("@Remark", tbRemark.Text);
                updateCommand.Parameters.AddWithValue("@Link", tbLink.Text);
                updateCommand.Parameters.AddWithValue("@Text", tbText.Text);
                updateCommand.Parameters.AddWithValue("@ThemeID", themeID);
                updateCommand.Parameters.AddWithValue("@ID", editednotesID);

                updateCommand.Connection.Open();
                updateCommand.ExecuteNonQuery();
                updateCommand.Connection.Close();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cbTheme_SelectionChangeCommitted(object sender, EventArgs e)
        {
            themeID = (int)cbTheme.SelectedValue;
        }
    }
}
