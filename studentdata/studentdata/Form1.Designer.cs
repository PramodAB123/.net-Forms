namespace studentdata
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.genderbox = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.classbox = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.Label();
            this.agebox = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.insertbut = new System.Windows.Forms.Button();
            this.updatebut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.clearbut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(100, 91);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(239, 88);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(195, 22);
            this.namebox.TabIndex = 2;
            // 
            // genderbox
            // 
            this.genderbox.Location = new System.Drawing.Point(239, 136);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(195, 22);
            this.genderbox.TabIndex = 4;
            this.genderbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(100, 139);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(52, 16);
            this.Gender.TabIndex = 3;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.label3_Click);
            // 
            // classbox
            // 
            this.classbox.Location = new System.Drawing.Point(239, 219);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(195, 22);
            this.classbox.TabIndex = 6;
            this.classbox.TextChanged += new System.EventHandler(this.classbox_TextChanged);
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(100, 222);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(41, 16);
            this.Class.TabIndex = 5;
            this.Class.Text = "Class";
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(239, 176);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(195, 22);
            this.agebox.TabIndex = 8;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(100, 179);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(32, 16);
            this.Age.TabIndex = 7;
            this.Age.Text = "Age";
            this.Age.Click += new System.EventHandler(this.Age_Click);
            // 
            // insertbut
            // 
            this.insertbut.Location = new System.Drawing.Point(39, 286);
            this.insertbut.Name = "insertbut";
            this.insertbut.Size = new System.Drawing.Size(105, 42);
            this.insertbut.TabIndex = 9;
            this.insertbut.Text = "Insert";
            this.insertbut.UseVisualStyleBackColor = true;
            this.insertbut.Click += new System.EventHandler(this.insertbut_Click);
            // 
            // updatebut
            // 
            this.updatebut.Location = new System.Drawing.Point(199, 286);
            this.updatebut.Name = "updatebut";
            this.updatebut.Size = new System.Drawing.Size(105, 42);
            this.updatebut.TabIndex = 10;
            this.updatebut.Text = "Update";
            this.updatebut.UseVisualStyleBackColor = true;
            this.updatebut.Click += new System.EventHandler(this.updatebut_Click);
            this.updatebut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updatebut_MouseClick);
            // 
            // deletebut
            // 
            this.deletebut.Location = new System.Drawing.Point(346, 286);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(105, 42);
            this.deletebut.TabIndex = 11;
            this.deletebut.Text = "Delete";
            this.deletebut.UseVisualStyleBackColor = true;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // clearbut
            // 
            this.clearbut.Location = new System.Drawing.Point(481, 286);
            this.clearbut.Name = "clearbut";
            this.clearbut.Size = new System.Drawing.Size(105, 42);
            this.clearbut.TabIndex = 12;
            this.clearbut.Text = "Clear";
            this.clearbut.UseVisualStyleBackColor = true;
            this.clearbut.Click += new System.EventHandler(this.clearbut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 189);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(239, 50);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(195, 22);
            this.idbox.TabIndex = 15;
            this.idbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(100, 53);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 16);
            this.id.TabIndex = 14;
            this.id.Text = "id";
            this.id.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(608, 556);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearbut);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.updatebut);
            this.Controls.Add(this.insertbut);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.classbox);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox genderbox;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox classbox;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.TextBox agebox;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Button insertbut;
        private System.Windows.Forms.Button updatebut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.Button clearbut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label id;
    }
}

