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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.TableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableID,
            this.TableName,
            this.TableBook,
            this.PI,
            this.Date});
            this.MainTable.Location = new System.Drawing.Point(205, 109);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowHeadersWidth = 51;
            this.MainTable.RowTemplate.Height = 29;
            this.MainTable.Size = new System.Drawing.Size(751, 733);
            this.MainTable.TabIndex = 0;
            // 
            // TableID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableID.DefaultCellStyle = dataGridViewCellStyle1;
            this.TableID.HeaderText = "Индекс";
            this.TableID.MinimumWidth = 6;
            this.TableID.Name = "TableID";
            this.TableID.Width = 70;
            // 
            // TableName
            // 
            this.TableName.HeaderText = "Имя";
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
            this.PI.HeaderText = "Персональная информация";
            this.PI.MinimumWidth = 6;
            this.PI.Name = "PI";
            this.PI.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 854);
            this.Controls.Add(this.MainTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Book;
        private DataGridView MainTable;
        private DataGridViewTextBoxColumn TableID;
        private DataGridViewTextBoxColumn TableName;
        private DataGridViewTextBoxColumn TableBook;
        private DataGridViewTextBoxColumn PI;
        private DataGridViewTextBoxColumn Date;
    }
}