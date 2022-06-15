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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.TableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDateBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.MainTable.Location = new System.Drawing.Point(223, 85);
            this.MainTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowHeadersWidth = 51;
            this.MainTable.RowTemplate.Height = 29;
            this.MainTable.Size = new System.Drawing.Size(814, 536);
            this.MainTable.TabIndex = 0;
            this.MainTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainTable_CellContentClick);
            // 
            // TableID
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableID.DefaultCellStyle = dataGridViewCellStyle6;
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(310, 45);
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
            this.button1.Location = new System.Drawing.Point(831, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "ПОКАЗАТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 33);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(12, 139);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 58);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(511, 45);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(183, 35);
            this.textBox6.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(12, 292);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 33);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(12, 356);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 33);
            this.textBox4.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(12, 424);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(190, 33);
            this.textBox7.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "ФИО:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Название книги:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Номер паспорта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Дата взятия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Дата возврата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(197, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 35);
            this.label6.TabIndex = 24;
            this.label6.Text = "Фильтр:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 514);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 36);
            this.button3.TabIndex = 25;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 556);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 36);
            this.button4.TabIndex = 26;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 622);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
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
        private TextBox textBox2;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn TableID;
        private DataGridViewTextBoxColumn TableName;
        private DataGridViewTextBoxColumn TableBook;
        private DataGridViewTextBoxColumn PI;
        private DataGridViewTextBoxColumn TableDateStart;
        private DataGridViewTextBoxColumn TableDateBack;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button4;
    }
}