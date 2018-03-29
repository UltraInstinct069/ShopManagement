namespace ShopManagement
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gvMember = new System.Windows.Forms.DataGridView();
            this.MemberUpdtBtn = new System.Windows.Forms.Button();
            this.MemberDelBtn = new System.Windows.Forms.Button();
            this.MemberAddBtn = new System.Windows.Forms.Button();
            this.MemberPhn = new System.Windows.Forms.TextBox();
            this.MemberAdd = new System.Windows.Forms.TextBox();
            this.MemberName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gvEmployee = new System.Windows.Forms.DataGridView();
            this.upBtn = new System.Windows.Forms.Button();
            this.DelEmpBtn = new System.Windows.Forms.Button();
            this.AddEmpBtn = new System.Windows.Forms.Button();
            this.EmpDeptId = new System.Windows.Forms.TextBox();
            this.EmpAdd = new System.Windows.Forms.TextBox();
            this.EmpNam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gvDepartment = new System.Windows.Forms.DataGridView();
            this.DelDeptBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DepartmentNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.gvMember);
            this.tabPage1.Controls.Add(this.MemberUpdtBtn);
            this.tabPage1.Controls.Add(this.MemberDelBtn);
            this.tabPage1.Controls.Add(this.MemberAddBtn);
            this.tabPage1.Controls.Add(this.MemberPhn);
            this.tabPage1.Controls.Add(this.MemberAdd);
            this.tabPage1.Controls.Add(this.MemberName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Member";
            // 
            // gvMember
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMember.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.gvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMember.Location = new System.Drawing.Point(69, 206);
            this.gvMember.Name = "gvMember";
            this.gvMember.Size = new System.Drawing.Size(433, 179);
            this.gvMember.TabIndex = 9;
            this.gvMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMember_CellClick);
            // 
            // MemberUpdtBtn
            // 
            this.MemberUpdtBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberUpdtBtn.Location = new System.Drawing.Point(265, 148);
            this.MemberUpdtBtn.Name = "MemberUpdtBtn";
            this.MemberUpdtBtn.Size = new System.Drawing.Size(92, 23);
            this.MemberUpdtBtn.TabIndex = 8;
            this.MemberUpdtBtn.Text = "Update Info";
            this.MemberUpdtBtn.UseVisualStyleBackColor = true;
            this.MemberUpdtBtn.Click += new System.EventHandler(this.MemberUpdtBtn_Click);
            // 
            // MemberDelBtn
            // 
            this.MemberDelBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberDelBtn.Location = new System.Drawing.Point(167, 148);
            this.MemberDelBtn.Name = "MemberDelBtn";
            this.MemberDelBtn.Size = new System.Drawing.Size(92, 23);
            this.MemberDelBtn.TabIndex = 7;
            this.MemberDelBtn.Text = "Delete Member";
            this.MemberDelBtn.UseVisualStyleBackColor = true;
            this.MemberDelBtn.Click += new System.EventHandler(this.MemberDelBtn_Click);
            // 
            // MemberAddBtn
            // 
            this.MemberAddBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberAddBtn.Location = new System.Drawing.Point(69, 148);
            this.MemberAddBtn.Name = "MemberAddBtn";
            this.MemberAddBtn.Size = new System.Drawing.Size(92, 23);
            this.MemberAddBtn.TabIndex = 6;
            this.MemberAddBtn.Text = "Add Member";
            this.MemberAddBtn.UseVisualStyleBackColor = true;
            this.MemberAddBtn.Click += new System.EventHandler(this.MemberAddBtn_Click);
            // 
            // MemberPhn
            // 
            this.MemberPhn.Location = new System.Drawing.Point(168, 88);
            this.MemberPhn.Name = "MemberPhn";
            this.MemberPhn.Size = new System.Drawing.Size(164, 20);
            this.MemberPhn.TabIndex = 5;
            // 
            // MemberAdd
            // 
            this.MemberAdd.Location = new System.Drawing.Point(168, 59);
            this.MemberAdd.Name = "MemberAdd";
            this.MemberAdd.Size = new System.Drawing.Size(164, 20);
            this.MemberAdd.TabIndex = 4;
            // 
            // MemberName
            // 
            this.MemberName.Location = new System.Drawing.Point(168, 30);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(164, 20);
            this.MemberName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Member Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Address : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Name :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.gvEmployee);
            this.tabPage2.Controls.Add(this.upBtn);
            this.tabPage2.Controls.Add(this.DelEmpBtn);
            this.tabPage2.Controls.Add(this.AddEmpBtn);
            this.tabPage2.Controls.Add(this.EmpDeptId);
            this.tabPage2.Controls.Add(this.EmpAdd);
            this.tabPage2.Controls.Add(this.EmpNam);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.gvDepartment);
            this.tabPage2.Controls.Add(this.DelDeptBtn);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.DepartmentNam);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee";
            // 
            // gvEmployee
            // 
            this.gvEmployee.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.gvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmployee.Location = new System.Drawing.Point(402, 252);
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.Size = new System.Drawing.Size(385, 191);
            this.gvEmployee.TabIndex = 15;
            this.gvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEmployee_CellClick);
            // 
            // upBtn
            // 
            this.upBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBtn.Location = new System.Drawing.Point(222, 374);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(84, 41);
            this.upBtn.TabIndex = 14;
            this.upBtn.Text = "Update Employee Info";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // DelEmpBtn
            // 
            this.DelEmpBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelEmpBtn.Location = new System.Drawing.Point(132, 374);
            this.DelEmpBtn.Name = "DelEmpBtn";
            this.DelEmpBtn.Size = new System.Drawing.Size(84, 41);
            this.DelEmpBtn.TabIndex = 13;
            this.DelEmpBtn.Text = "Delete Employee";
            this.DelEmpBtn.UseVisualStyleBackColor = true;
            this.DelEmpBtn.Click += new System.EventHandler(this.DelEmpBtn_Click);
            // 
            // AddEmpBtn
            // 
            this.AddEmpBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpBtn.Location = new System.Drawing.Point(37, 374);
            this.AddEmpBtn.Name = "AddEmpBtn";
            this.AddEmpBtn.Size = new System.Drawing.Size(84, 41);
            this.AddEmpBtn.TabIndex = 12;
            this.AddEmpBtn.Text = " Add   Employee";
            this.AddEmpBtn.UseVisualStyleBackColor = true;
            this.AddEmpBtn.Click += new System.EventHandler(this.AddEmpBtn_Click);
            // 
            // EmpDeptId
            // 
            this.EmpDeptId.Location = new System.Drawing.Point(144, 304);
            this.EmpDeptId.Name = "EmpDeptId";
            this.EmpDeptId.Size = new System.Drawing.Size(161, 20);
            this.EmpDeptId.TabIndex = 11;
            // 
            // EmpAdd
            // 
            this.EmpAdd.Location = new System.Drawing.Point(144, 275);
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.Size = new System.Drawing.Size(161, 20);
            this.EmpAdd.TabIndex = 10;
            // 
            // EmpNam
            // 
            this.EmpNam.Location = new System.Drawing.Point(145, 249);
            this.EmpNam.Name = "EmpNam";
            this.EmpNam.Size = new System.Drawing.Size(160, 20);
            this.EmpNam.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Employee Address :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Department ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Employee Name :";
            // 
            // gvDepartment
            // 
            this.gvDepartment.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.gvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDepartment.Location = new System.Drawing.Point(402, 16);
            this.gvDepartment.Name = "gvDepartment";
            this.gvDepartment.Size = new System.Drawing.Size(240, 150);
            this.gvDepartment.TabIndex = 5;
            this.gvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDepartment_CellClick);
            // 
            // DelDeptBtn
            // 
            this.DelDeptBtn.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelDeptBtn.Location = new System.Drawing.Point(221, 88);
            this.DelDeptBtn.Name = "DelDeptBtn";
            this.DelDeptBtn.Size = new System.Drawing.Size(84, 41);
            this.DelDeptBtn.TabIndex = 4;
            this.DelDeptBtn.Text = "Update Department";
            this.DelDeptBtn.UseVisualStyleBackColor = true;
            this.DelDeptBtn.Click += new System.EventHandler(this.DelDeptBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete Department";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Department";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepartmentNam
            // 
            this.DepartmentNam.Location = new System.Drawing.Point(144, 38);
            this.DepartmentNam.Name = "DepartmentNam";
            this.DepartmentNam.Size = new System.Drawing.Size(100, 20);
            this.DepartmentNam.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department Name :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 550);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button MemberUpdtBtn;
        private System.Windows.Forms.Button MemberDelBtn;
        private System.Windows.Forms.Button MemberAddBtn;
        private System.Windows.Forms.TextBox MemberPhn;
        private System.Windows.Forms.TextBox MemberAdd;
        private System.Windows.Forms.TextBox MemberName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvMember;
        private System.Windows.Forms.Button DelDeptBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DepartmentNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvDepartment;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button DelEmpBtn;
        private System.Windows.Forms.Button AddEmpBtn;
        private System.Windows.Forms.TextBox EmpDeptId;
        private System.Windows.Forms.TextBox EmpAdd;
        private System.Windows.Forms.TextBox EmpNam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvEmployee;
    }
}