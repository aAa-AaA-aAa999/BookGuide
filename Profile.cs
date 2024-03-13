using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class Profile : Form
    {
        private Timer timer;
        public static Profile Instance { get; private set; }

        public Profile()
        {
            InitializeComponent();
            Paint += BackGround_Paint;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            count.BackColor = Color.Transparent;
            nameLabel.BackColor = Color.Transparent;
            count.Text = Convert.ToString(booksCounter());
            errorLabel.Visible = false;
            errorLabel.BackColor = Color.Transparent;
            errorLabel.Text = "Такой книги нет...";
            loadInf();
            timer = new Timer();
            timer.Interval = 5000; // Интервал 5 секунд
            timer.Tick += Timer_Tick; // Обработчик события таймера
            Instance = this;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
        private void BackGround_Paint(object sender, PaintEventArgs e)
        {
            // Устанавливаем начальный и конечный цвета для градиента
            Color startColor = Color.FromArgb(255, 255, 192, 128); // Начальный цвет (например, оранжевый)
            Color endColor = Color.FromArgb(255, 255, 100, 120);   // Конечный цвет (например, желтый)

            // Создаем градиентную кисть с горизонтальным направлением
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, startColor, endColor, LinearGradientMode.Horizontal);

            // Нарисовать градиентный фон на форме
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        public int booksCounter()
        {
            string queryList = "SELECT COUNT(*) FROM MainBooksInformation WHERE IsChosen = 1";
            int count = 0;
            DbConnection dbConnection = new DbConnection();
            SqlConnection sqlConnection = dbConnection.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(queryList, sqlConnection);
                dbConnection.openConnection();
                using (sqlConnection)
                {
                    SqlCommand command = new SqlCommand(queryList, sqlConnection);

                    count = (int)command.ExecuteScalar();

                }
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("данные не переданы");
                MessageBox.Show("Error: " + ex.Message);
                return 0;

            }
            finally
            {
                dbConnection.closedConnection();
            }
        }
        internal void loadInf() {
            string queryList = "SELECT MainBooksInformation.Title, AuthorInformation.Name " + 
            "FROM MainBooksInformation " +
            "INNER JOIN AuthorInformation ON MainBooksInformation.AuthorID = AuthorInformation.AuthorID " + 
            "WHERE MainBooksInformation.IsChosen = 1; ";



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

                        booksListBox.Items.Add($"Название: {title}");
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
            string userTitle = textBox.Text;


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
