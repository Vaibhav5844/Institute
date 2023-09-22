namespace institute1
{
    partial class Form7
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
            this.txt_id = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pno = new System.Windows.Forms.TextBox();
            this.txt_course = new System.Windows.Forms.TextBox();
            this.txt_fee_type = new System.Windows.Forms.TextBox();
            this.txt_mode = new System.Windows.Forms.TextBox();
            this.txt_total_fee = new System.Windows.Forms.TextBox();
            this.txt_currently_paying = new System.Windows.Forms.TextBox();
            this.txt_paid_fee = new System.Windows.Forms.TextBox();
            this.txt_balance_fee = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instituteDataSet6 = new institute1.instituteDataSet6();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Addmission ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student_name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone_no";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Course_name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(657, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fees_type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(657, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total_fee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(657, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Currently_paying";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(657, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total paid fee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(657, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Balance_fee";
            // 
            // txt_id
            // 
            this.txt_id.FormattingEnabled = true;
            this.txt_id.Location = new System.Drawing.Point(265, 137);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(171, 24);
            this.txt_id.TabIndex = 12;
            this.txt_id.SelectedIndexChanged += new System.EventHandler(this.txt_id_SelectedIndexChanged);
            // 
            // txt_name
            // 
            this.txt_name.FormattingEnabled = true;
            this.txt_name.Location = new System.Drawing.Point(265, 250);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(171, 24);
            this.txt_name.TabIndex = 13;
            this.txt_name.SelectedIndexChanged += new System.EventHandler(this.txt_name_SelectedIndexChanged);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(265, 190);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(171, 22);
            this.txt_date.TabIndex = 14;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(265, 302);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(171, 22);
            this.txt_email.TabIndex = 15;
            // 
            // txt_pno
            // 
            this.txt_pno.Location = new System.Drawing.Point(265, 368);
            this.txt_pno.Name = "txt_pno";
            this.txt_pno.Size = new System.Drawing.Size(171, 22);
            this.txt_pno.TabIndex = 16;
            // 
            // txt_course
            // 
            this.txt_course.Location = new System.Drawing.Point(265, 418);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(171, 22);
            this.txt_course.TabIndex = 17;
            // 
            // txt_fee_type
            // 
            this.txt_fee_type.Location = new System.Drawing.Point(807, 137);
            this.txt_fee_type.Name = "txt_fee_type";
            this.txt_fee_type.Size = new System.Drawing.Size(171, 22);
            this.txt_fee_type.TabIndex = 18;
            // 
            // txt_mode
            // 
            this.txt_mode.Location = new System.Drawing.Point(807, 194);
            this.txt_mode.Name = "txt_mode";
            this.txt_mode.Size = new System.Drawing.Size(171, 22);
            this.txt_mode.TabIndex = 19;
            // 
            // txt_total_fee
            // 
            this.txt_total_fee.Location = new System.Drawing.Point(807, 250);
            this.txt_total_fee.Name = "txt_total_fee";
            this.txt_total_fee.Size = new System.Drawing.Size(171, 22);
            this.txt_total_fee.TabIndex = 20;
            // 
            // txt_currently_paying
            // 
            this.txt_currently_paying.Location = new System.Drawing.Point(807, 302);
            this.txt_currently_paying.Name = "txt_currently_paying";
            this.txt_currently_paying.Size = new System.Drawing.Size(171, 22);
            this.txt_currently_paying.TabIndex = 21;
            this.txt_currently_paying.TextChanged += new System.EventHandler(this.txt_currently_paying_TextChanged);
            // 
            // txt_paid_fee
            // 
            this.txt_paid_fee.Location = new System.Drawing.Point(807, 368);
            this.txt_paid_fee.Name = "txt_paid_fee";
            this.txt_paid_fee.Size = new System.Drawing.Size(171, 22);
            this.txt_paid_fee.TabIndex = 22;
            this.txt_paid_fee.TextChanged += new System.EventHandler(this.txt_paid_fee_TextChanged);
            // 
            // txt_balance_fee
            // 
            this.txt_balance_fee.Location = new System.Drawing.Point(807, 418);
            this.txt_balance_fee.Name = "txt_balance_fee";
            this.txt_balance_fee.Size = new System.Drawing.Size(171, 22);
            this.txt_balance_fee.TabIndex = 23;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.instituteDataSet6;
            this.bindingSource1.Position = 0;
            // 
            // instituteDataSet6
            // 
            this.instituteDataSet6.DataSetName = "instituteDataSet6";
            this.instituteDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(297, 549);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(139, 53);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 52);
            this.button1.TabIndex = 25;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 758);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_balance_fee);
            this.Controls.Add(this.txt_paid_fee);
            this.Controls.Add(this.txt_currently_paying);
            this.Controls.Add(this.txt_total_fee);
            this.Controls.Add(this.txt_mode);
            this.Controls.Add(this.txt_fee_type);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.txt_pno);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
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
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet6)).EndInit();
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
        private System.Windows.Forms.ComboBox txt_id;
        private System.Windows.Forms.ComboBox txt_name;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pno;
        private System.Windows.Forms.TextBox txt_course;
        private System.Windows.Forms.TextBox txt_fee_type;
        private System.Windows.Forms.TextBox txt_mode;
        private System.Windows.Forms.TextBox txt_total_fee;
        private System.Windows.Forms.TextBox txt_currently_paying;
        private System.Windows.Forms.TextBox txt_paid_fee;
        private System.Windows.Forms.TextBox txt_balance_fee;
        private System.Windows.Forms.BindingSource bindingSource1;
        private instituteDataSet6 instituteDataSet6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
    }
}