namespace Library
{
    partial class ListOfBooks
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
            this.Поиск = new System.Windows.Forms.Button();
            this.enterLabel1 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enterLabel2 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Поиск
            // 
            this.Поиск.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Поиск.BackgroundImage = global::Library.Properties.Resources.searchvsbackgr;
            this.Поиск.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Поиск.FlatAppearance.BorderSize = 0;
            this.Поиск.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Поиск.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.Поиск.ForeColor = System.Drawing.Color.White;
            this.Поиск.Location = new System.Drawing.Point(606, 452);
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(42, 40);
            this.Поиск.TabIndex = 12;
            this.Поиск.UseVisualStyleBackColor = false;
            this.Поиск.Click += new System.EventHandler(this.search_Click);
            // 
            // enterLabel1
            // 
            this.enterLabel1.AutoSize = true;
            this.enterLabel1.BackColor = System.Drawing.Color.Black;
            this.enterLabel1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.enterLabel1.ForeColor = System.Drawing.Color.White;
            this.enterLabel1.Location = new System.Drawing.Point(17, 399);
            this.enterLabel1.Name = "enterLabel1";
            this.enterLabel1.Size = new System.Drawing.Size(245, 29);
            this.enterLabel1.TabIndex = 11;
            this.enterLabel1.Text = "Введине название";
            // 
            // textbox
            // 
            this.textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textbox.Location = new System.Drawing.Point(27, 460);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(573, 25);
            this.textbox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 59);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список книг:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 7;
            // 
            // enterLabel2
            // 
            this.enterLabel2.AutoSize = true;
            this.enterLabel2.BackColor = System.Drawing.Color.Black;
            this.enterLabel2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.enterLabel2.ForeColor = System.Drawing.Color.White;
            this.enterLabel2.Location = new System.Drawing.Point(140, 428);
            this.enterLabel2.Name = "enterLabel2";
            this.enterLabel2.Size = new System.Drawing.Size(292, 29);
            this.enterLabel2.TabIndex = 14;
            this.enterLabel2.Text = "понравившейся книги";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(215, 109);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 16);
            this.count.TabIndex = 10;
            // 
            // booksListBox
            // 
            this.booksListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.booksListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksListBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksListBox.ForeColor = System.Drawing.Color.Black;
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.HorizontalExtent = 10;
            this.booksListBox.HorizontalScrollbar = true;
            this.booksListBox.ItemHeight = 21;
            this.booksListBox.Location = new System.Drawing.Point(14, 78);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(735, 315);
            this.booksListBox.TabIndex = 13;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.Location = new System.Drawing.Point(323, 399);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 29);
            this.errorLabel.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ListOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 499);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.enterLabel2);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.Поиск);
            this.Controls.Add(this.enterLabel1);
            this.Controls.Add(this.count);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListOfBooks";
            this.Text = "Список книг";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Поиск;
        private System.Windows.Forms.Label enterLabel1;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enterLabel2;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Timer timer1;
    }
}