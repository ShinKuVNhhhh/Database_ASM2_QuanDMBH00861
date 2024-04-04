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
using System.Windows.Input;

namespace DinhVanDong
{
    public partial class Attendance_Records : Form
    {
        public Attendance_Records()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Maincs form1 = new Maincs();
            form1.Show();
        }

        private void Attendance_Records_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            Getdata();
        }
        public void Getdata()
        {
            string connectionString = @"Data Source=ACER;Initial Catalog=Attendance_System;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Attendance_Records";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        

        private void btnadd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ACER;Initial Catalog=Attendance_System;Integrated Security=True;Encrypt=False";


            int recordId = Convert.ToInt32(txtrecordID.Text);
            int studentId = Convert.ToInt32(txtstudentID.Text); // Giả sử txtStudentId là TextBox chứa studentId
            int sessionId = Convert.ToInt32(txtsessionID.Text); // Giả sử txtSessionId là TextBox chứa sessionId
            string status = txtstatus.Text; // Giả sử txtStatus là TextBox chứa status

            // Kết nối và thực thi stored procedure
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("AddStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // Thêm các tham số cho stored procedure
                command.Parameters.AddWithValue("@recordid", recordId);
                command.Parameters.AddWithValue("@studentid", studentId);
                command.Parameters.AddWithValue("@sessionid", sessionId);
                command.Parameters.AddWithValue("@status", status);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sinh viên đã được thêm thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }
    }
    }

