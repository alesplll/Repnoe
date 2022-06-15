namespace repnoe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.TableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDateBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.HeaderText = "Индекс";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Book
            // 
            this.Book.HeaderText = "Книга";
            this.Book.MinimumWidth = 6;
            this.Book.Name = "Book";
            this.Book.Width = 125;
            // 
            // MainTable
            // 
            this.MainTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(164)))));
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableID,
            this.TableName,
            this.TableBook,
            this.PI,
            this.TableDateStart,
            this.TableDateBack});
            this.MainTable.Location = new System.Drawing.Point(223, 78);
            this.MainTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowHeadersWidth = 51;
            this.MainTable.RowTemplate.Height = 29;
            this.MainTable.Size = new System.Drawing.Size(814, 543);
            this.MainTable.TabIndex = 0;
            this.MainTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainTable_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(311, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(195, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "ПОКАЗАТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(72, 461);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 23);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 23);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 23);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(12, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 33);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(915, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 38);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(789, 23);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(111, 38);
            this.comboBox3.TabIndex = 14;
            // 
            // TableID
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableID.DefaultCellStyle = dataGridViewCellStyle4;
            this.TableID.HeaderText = "ID";
            this.TableID.MinimumWidth = 6;
            this.TableID.Name = "TableID";
            this.TableID.Width = 30;
            // 
            // TableName
            // 
            this.TableName.HeaderText = "ФИО";
            this.TableName.MinimumWidth = 6;
            this.TableName.Name = "TableName";
            this.TableName.Width = 200;
            // 
            // TableBook
            // 
            this.TableBook.HeaderText = "Книга";
            this.TableBook.MinimumWidth = 6;
            this.TableBook.Name = "TableBook";
            this.TableBook.Width = 200;
            // 
            // PI
            // 
            this.PI.HeaderText = "Номер паспорта";
            this.PI.MinimumWidth = 6;
            this.PI.Name = "PI";
            this.PI.Width = 80;
            // 
            // TableDateStart
            // 
            this.TableDateStart.HeaderText = "Дата";
            this.TableDateStart.MinimumWidth = 6;
            this.TableDateStart.Name = "TableDateStart";
            this.TableDateStart.Width = 125;
            // 
            // TableDateBack
            // 
            this.TableDateBack.HeaderText = "Дата возврата";
            this.TableDateBack.Name = "TableDateBack";
            this.TableDateBack.Width = 125;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(511, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(183, 35);
            this.textBox6.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 622);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MainTable);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Book;
        private DataGridView MainTable;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DataGridViewTextBoxColumn TableID;
        private DataGridViewTextBoxColumn TableName;
        private DataGridViewTextBoxColumn TableBook;
        private DataGridViewTextBoxColumn PI;
        private DataGridViewTextBoxColumn TableDateStart;
        private DataGridViewTextBoxColumn TableDateBack;
        private TextBox textBox6;
    }
}