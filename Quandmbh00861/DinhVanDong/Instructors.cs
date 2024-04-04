﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhVanDong
{
    public partial class Instructors : Form
    {
        public Instructors()
        {
            InitializeComponent();
        }

        private void Instructors_Load(object sender, EventArgs e)
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

                string selectQuery = "SELECT * FROM Instructors";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // Create a new instance of the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Maincs form1 = new Maincs();
            form1.Show();
        }
    }
}