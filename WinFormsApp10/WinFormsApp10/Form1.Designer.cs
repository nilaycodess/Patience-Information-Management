namespace WinFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(46, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 36;
            dataGridView1.Size = new Size(859, 235);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 329);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 34);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 387);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 34);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(509, 272);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 34);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(509, 329);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(223, 34);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(509, 378);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(223, 34);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(897, 266);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(209, 34);
            textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(897, 323);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(209, 34);
            textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(897, 378);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(209, 34);
            textBox9.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 281);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 10;
            label1.Text = "TC NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 335);
            label2.Name = "label2";
            label2.Size = new Size(43, 28);
            label2.TabIndex = 11;
            label2.Text = "AD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 390);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 12;
            label3.Text = "SOYAD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 278);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 13;
            label4.Text = "TELEFON:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 335);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 14;
            label5.Text = "DOĞUM TARİHİ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(350, 387);
            label6.Name = "label6";
            label6.Size = new Size(134, 28);
            label6.TabIndex = 15;
            label6.Text = "DOĞUM YERİ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(764, 272);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 16;
            label7.Text = "ADRES:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(764, 329);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 17;
            label8.Text = "HASTALIK:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(764, 384);
            label9.Name = "label9";
            label9.Size = new Size(93, 28);
            label9.TabIndex = 18;
            label9.Text = "İLAÇ ADI:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Location = new Point(89, 447);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 19;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Location = new Point(236, 447);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 20;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.Location = new Point(390, 447);
            button3.Name = "button3";
            button3.Size = new Size(94, 44);
            button3.TabIndex = 21;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSeaGreen;
            button4.Location = new Point(518, 445);
            button4.Name = "button4";
            button4.Size = new Size(103, 46);
            button4.TabIndex = 22;
            button4.Text = "Güncelle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 509);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
    }
}