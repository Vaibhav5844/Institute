namespace institute1
{
    partial class Form5
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.txt_pno = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.ComboBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_mode = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instituteDataSet4 = new institute1.instituteDataSet4();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone_no";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Batch_time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mode";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(377, 48);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(171, 22);
            this.txt_id.TabIndex = 8;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(377, 134);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(171, 22);
            this.txt_add.TabIndex = 9;
            // 
            // txt_pno
            // 
            this.txt_pno.Location = new System.Drawing.Point(377, 230);
            this.txt_pno.Name = "txt_pno";
            this.txt_pno.Size = new System.Drawing.Size(171, 22);
            this.txt_pno.TabIndex = 10;
            this.txt_pno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pno_KeyUp);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(377, 271);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(171, 22);
            this.txt_email.TabIndex = 11;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(377, 313);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(171, 22);
            this.txt_time.TabIndex = 12;
            // 
            // txt_gender
            // 
            this.txt_gender.FormattingEnabled = true;
            this.txt_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txt_gender.Location = new System.Drawing.Point(377, 183);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(171, 24);
            this.txt_gender.TabIndex = 13;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(377, 87);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(171, 22);
            this.txt_date.TabIndex = 14;
            // 
            // txt_mode
            // 
            this.txt_mode.FormattingEnabled = true;
            this.txt_mode.Items.AddRange(new object[] {
            "Online",
            "Offline"});
            this.txt_mode.Location = new System.Drawing.Point(377, 353);
            this.txt_mode.Name = "txt_mode";
            this.txt_mode.Size = new System.Drawing.Size(171, 24);
            this.txt_mode.TabIndex = 15;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(322, 415);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 32);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.instituteDataSet4;
            this.bindingSource1.Position = 0;
            // 
            // instituteDataSet4
            // 
            this.instituteDataSet4.DataSetName = "instituteDataSet4";
            this.instituteDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(210, 415);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 32);
            this.btn_new.TabIndex = 17;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(433, 415);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 32);
            this.btn_del.TabIndex = 18;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_mode);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_pno);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteDataSet4)).EndInit();
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
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.TextBox txt_pno;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.ComboBox txt_gender;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.ComboBox txt_mode;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.BindingSource bindingSource1;
        private instituteDataSet4 instituteDataSet4;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button button1;
    }
}