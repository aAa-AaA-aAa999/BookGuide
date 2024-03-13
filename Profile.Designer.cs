namespace Library
{
    partial class Profile
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Поиск = new System.Windows.Forms.Button();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "добавленных\r\n в избранное";
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
            this.label2.TabIndex = 1;
            this.label2.Text = "Список книг,";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox.Location = new System.Drawing.Point(27, 463);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(317, 25);
            this.textBox.TabIndex = 2;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.count.ForeColor = System.Drawing.Color.White;
            this.count.Location = new System.Drawing.Point(424, 88);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 31);
            this.count.TabIndex = 3;
            this.count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Black;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(24, 427);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(320, 29);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Введине название книги";
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
            this.Поиск.Location = new System.Drawing.Point(364, 452);
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(42, 40);
            this.Поиск.TabIndex = 5;
            this.Поиск.UseVisualStyleBackColor = false;
            this.Поиск.Click += new System.EventHandler(this.search_Click);
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
            this.booksListBox.Location = new System.Drawing.Point(16, 143);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(444, 273);
            this.booksListBox.TabIndex = 6;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.errorLabel.Location = new System.Drawing.Point(236, 105);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 19);
            this.errorLabel.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 499);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.Поиск);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.count);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button Поиск;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label count;
    }
}