using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Library
{
    public partial class ListOfBooks : Form
    {
        private Timer timer;
        public ListOfBooks()
        {
            InitializeComponent();
            Paint += BackGround_Paint;
            label2.BackColor = Color.Transparent;
            enterLabel1.BackColor = Color.Transparent;
            enterLabel2.BackColor = Color.Transparent;
            errorLabel.Visible = false;
            errorLabel.BackColor = Color.Transparent;
            errorLabel.Text = "Упс! Такой книги не найдено...";
            loadListBooks();
            timer = new Timer();
            timer.Interval = 5000; // Интервал 5 секунд
            timer.Tick += Timer_Tick; // Обработчик события таймера
        }
        private void BackGround_Paint(object sender, PaintEventArgs e)
        {

            // Определение цветов для градиента
            Color startColor = Color.FromArgb(255, 245, 134, 52);
            Color endColor = Color.FromArgb(255, 236, 38, 143);

            // Создание градиентной кисти с углом 45 градусов
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, startColor, endColor, 45f);

            // Нарисовать градиентный фон на форме
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        private void loadListBooks()
        {
            string queryList = "SELECT MainBooksInformation.Title, MainBooksInformation.Genre, MainBooksInformation.PageCount, AuthorInformation.Name " +
                             "FROM MainBooksInformation " +
                             "INNER JOIN AuthorInformation ON MainBooksInformation.AuthorID = AuthorInformation.AuthorID";


            DbConnection dbConnection = new DbConnection();
            SqlConnection sqlConnection = dbConnection.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(queryList, sqlConnection);
                dbConnection.openConnection();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    booksListBox.Items.Clear();
                    while (reader.Read())
                    {
                        string title = reader["Title"].ToString();
                        string nameAuthor = reader["Name"].ToString();
                        string genre = reader["Genre"].ToString();
                        string pagecount = reader["PageCount"].ToString();


                        /*Console.WriteLine($"Название: {title}");
                        booksListBox.Items.Add($"Название: {title}");*/

                        booksListBox.Items.Add($"Название: {title},  Жанр: {genre},  Страницы: {pagecount}");
                        booksListBox.Items.Add($"     ◌ Автор: {nameAuthor}");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("данные не переданы");
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbConnection.closedConnection();
            }

        }
        private void search_Click(object sender, EventArgs e)
        {
            string queryList = /*"SELECT mbi.Title, mbi.Genre, mbi.PageCount, mbi.Description, mbi.IsChosen, ai.Name " +
                "FROM MainBooksInformation as mbi " +
                "INNER JOIN AuthorInformation as ai ON mbi.AuthorID = ai.AuthorID " +
                "WHERE mbi.Title = @SearchText;";*/

            "SELECT MainBooksInformation.Title, MainBooksInformation.Genre, MainBooksInformation.PageCount, MainBooksInformation.Description, MainBooksInformation.IsChosen, AuthorInformation.Name " +
            "FROM MainBooksInformation " +
            "INNER JOIN AuthorInformation ON MainBooksInformation.AuthorID = AuthorInformation.AuthorID " +
            "WHERE MainBooksInformation.Title = @SearchText; ";
            string userTitle = textbox.Text;


            DbConnection dbConnection = new DbConnection();
            SqlConnection sqlConnection = dbConnection.getConnection();
            try
            {
                dbConnection.openConnection();
                SqlCommand cmd = new SqlCommand(queryList, sqlConnection);
                cmd.Parameters.AddWithValue("@SearchText", userTitle);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Определение, что есть совпадения
                        while (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            string nameAuthor = reader["Name"].ToString();
                            string genre = reader["Genre"].ToString();
                            string pagecount = reader["PageCount"].ToString();
                            string description = reader["Description"].ToString();
                            bool isChosen = Convert.ToBoolean(reader["IsChosen"]);

                            InfBook book = new InfBook(title, nameAuthor, genre, pagecount, description, isChosen);
                            book.Show();
                        }
                    }
                    else
                    {
                        // Совпадений не найдено
                        ShowErrorLabel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbConnection.closedConnection();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            errorLabel.Visible = false; // Скрываем Label после 5 секунд
            timer.Stop();
        }
        private void ShowErrorLabel()
        {
            errorLabel.Visible = true; // Показываем Label
            timer.Start(); // Запускаем таймер
        }
    }
}
