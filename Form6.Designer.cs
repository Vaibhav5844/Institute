namespace institute1
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_add_id = new System.Windows.Forms.TextBox();
            this.txt_stud_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_pno = new System.Windows.Forms.TextBox();
            this.txt_fee = new System.Windows.Forms.TextBox();
            this.txt_b_time = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.ComboBox();
            this.txt_course = new System.Windows.Forms.ComboBox();
            this.txt_mode = new System.Windows.Forms.ComboBox();
            this.txt_fee_type = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instituteDataSet5 = new institute1.instituteDataSet5();
            this.txt_stud_id = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admission_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone_no";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Course_name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(526, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Batch_time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(526, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "FeeType";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(526, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Fee";
            // 
            // txt_add_id
            // 
            this.txt_add_id.Enabled = false;
            this.txt_add_id.Location = new System.Drawing.Point(173, 45);
            this.txt_add_id.Name = "txt_add_id";
            this.txt_add_id.Size = new System.Drawing.Size(198, 22);
            this.txt_add_id.TabIndex = 13;
            // 
            // txt_stud_name
            // 
            this.txt_stud_name.Location = new System.Drawing.Point(173, 186);
            this.txt_stud_name.Name = "txt_stud_name";
            this.txt_stud_name.Size = new System.Drawing.Size(198, 22);
            this.txt_stud_name.TabIndex = 15;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(173, 248);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(198, 22);
            this.txt_email.TabIndex = 16;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(173, 303);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(198, 22);
            this.txt_address.TabIndex = 17;
            // 
            // txt_pno
            // 
            this.txt_pno.Location = new System.Drawing.Point(173, 359);
            this.txt_pno.Name = "txt_pno";
            this.txt_pno.Size = new System.Drawing.Size(198, 22);
            this.txt_pno.TabIndex = 18;
            // 
            // txt_fee
            // 
            this.txt_fee.Location = new System.Drawing.Point(678, 329);
            this.txt_fee.Name = "txt_fee";
            this.txt_fee.Size = new System.Drawing.Size(198, 22);
            this.txt_fee.TabIndex = 19;
            // 
            // txt_b_time
            // 
            this.txt_b_time.Location = new System.Drawing.Point(678, 140);
            this.txt_b_time.Name = "txt_b_time";
            this.txt_b_time.Size = new System.Drawing.Size(198, 22);
            this.txt_b_time.TabIndex = 20;
            // 
            // txt_gender
            // 
            this.txt_gender.FormattingEnabled = true;
            this.txt_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txt_gender.Location = new System.Drawing.Point(173, 409);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(198, 24);
            this.txt_gender.TabIndex = 21;
            // 
            // txt_course
            // 
            this.txt_course.FormattingEnabled = true;
            this.txt_course.Location = new System.Drawing.Point(678, 79);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(198, 24);
            this.txt_course.TabIndex = 22;
            this.txt_course.SelectedIndexChanged += new System.EventHandler(this.txt_course_SelectedIndexChanged);
            // 
            // txt_mode
            // 
            this.txt_mode.FormattingEnabled = true;
            this.txt_mode.Items.AddRange(new object[] {
            "Offline",
            "Online"});
            this.txt_mode.Location = new System.Drawing.Point(678, 204);
            this.txt_mode.Name = "txt_mode";
            this.txt_mode.Size = new System.Drawing.Size(198, 24);
            this.txt_mode.TabIndex = 23;
            // 
            // txt_fee_type
            // 
            this.txt_fee_type.FormattingEnabled = true;
            this.txt_fee_type.Items.AddRange(new object[] {
            "One Time",
            "Installalment"});
            this.txt_fee_type.Location = new System.Drawing.Point(678, 265);
            this.txt_fee_type.Name = "txt_fee_type";
            this.txt_fee_type.Size = new System.Drawing.Size(198, 24);
            this.txt_fee_type.TabIndex = 24;
            this.txt_fee_type.SelectedIndexChanged += new System.EventHandler(this.txt_fee_type_SelectedIndexChanged);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(173, 140);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 22);
            this.txt_date.TabIndex = 25;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(287, 484);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(141, 40);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.instituteDataSet5;
            this.bindingSource1.Position = 0;
            // 
            // instituteDataSet5
            // 
            this.instituteDataSet5.DataSetName = "instituteDataSet5";
            this.instituteDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_stud_id
            // 
            this.txt_stud_id.FormattingEnabled = true;
            this.txt_stud_id.Location = new System.Drawing.Point(173, 89);
            this.txt_stud_id.Name = "txt_stud_id";
            this.txt_stud_id.Size = new System.Drawing.Size(198, 24);
            this.txt_stud_id.TabIndex = 27;
            this.txt_stud_id.SelectedIndexChanged += new System.EventHandler(this.txt_stud_id_SelectedIndexChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(536, 484);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 40);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(63, 484);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(123, 40);
            this.btn_new.TabIndex = 29;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 30;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_stud_id);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_fee_type);
            this.Controls.Add(this.txt_mode);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_b_time);
            this.Controls.Add(this.txt_fee);
            this.Controls.Add(this.txt_pno);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_stud_name);
            this.Controls.Add(this.txt_add_id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_add_id;
        private System.Windows.Forms.TextBox txt_stud_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_pno;
        private System.Windows.Forms.TextBox txt_fee;
        private System.Windows.Forms.TextBox txt_b_time;
        private System.Windows.Forms.ComboBox txt_gender;
        private System.Windows.Forms.ComboBox txt_course;
        private System.Windows.Forms.ComboBox txt_mode;
        private System.Windows.Forms.ComboBox txt_fee_type;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.BindingSource bindingSource1;
        private instituteDataSet5 instituteDataSet5;
        private System.Windows.Forms.ComboBox txt_stud_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button button1;
    }
}