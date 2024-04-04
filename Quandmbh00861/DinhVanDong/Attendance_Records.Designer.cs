namespace DinhVanDong
{
    partial class Attendance_Records
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtrecordID = new System.Windows.Forms.TextBox();
            this.txtstudentID = new System.Windows.Forms.TextBox();
            this.txtsessionID = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "RecordID";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(12, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Status";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Uighur", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.Location = new System.Drawing.Point(12, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "SessionID";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Uighur", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button5.Location = new System.Drawing.Point(12, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "StudentID";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtrecordID
            // 
            this.txtrecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtrecordID.Location = new System.Drawing.Point(123, 26);
            this.txtrecordID.Name = "txtrecordID";
            this.txtrecordID.Size = new System.Drawing.Size(131, 27);
            this.txtrecordID.TabIndex = 6;
            // 
            // txtstudentID
            // 
            this.txtstudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtstudentID.Location = new System.Drawing.Point(123, 116);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(131, 27);
            this.txtstudentID.TabIndex = 7;
            // 
            // txtsessionID
            // 
            this.txtsessionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtsessionID.Location = new System.Drawing.Point(123, 74);
            this.txtsessionID.Name = "txtsessionID";
            this.txtsessionID.Size = new System.Drawing.Size(131, 27);
            this.txtsessionID.TabIndex = 8;
            // 
            // txtstatus
            // 
            this.txtstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtstatus.Location = new System.Drawing.Point(123, 163);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(131, 27);
            this.txtstatus.TabIndex = 9;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(765, 12);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 35);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Uighur", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(782, 198);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(59, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Uighur", 12.75F);
            this.btndelete.Location = new System.Drawing.Point(782, 240);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(68, 26);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Uighur", 12.75F);
            this.button3.Location = new System.Drawing.Point(782, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 26);
            this.button3.TabIndex = 13;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Uighur", 12.75F);
            this.button6.Location = new System.Drawing.Point(782, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 26);
            this.button6.TabIndex = 14;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Attendance_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(852, 448);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtsessionID);
            this.Controls.Add(this.txtstudentID);
            this.Controls.Add(this.txtrecordID);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Attendance_Records";
            this.Text = "Attendance_Records";
            this.Load += new System.EventHandler(this.Attendance_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtrecordID;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.TextBox txtsessionID;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
    }
}