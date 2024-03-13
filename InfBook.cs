using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class InfBook : Form
    {
        public InfBook()
        {

        }

        private string infTitle;
        private string infNameAuthor;
        private string infgGenre;
        private string infPagecount;
        private string infDescription;
        bool infIsChosen;

        public InfBook(string title, string nameAuthor, string genre, string pagecount, string Description, bool isChosen)
        {
            InitializeComponent();
            infTitle = title;
            infNameAuthor = nameAuthor;
            infgGenre = genre;
            infPagecount = pagecount;
            infDescription = Description;
            infIsChosen = isChosen;

            titleLabel.Text = "• " + infTitle;
            authorLabel.Text = "• " + infNameAuthor;
            genreLabel.Text = "• " + infgGenre;
            pagesLabel.Text = "• " + infPagecount;
            descritionLabel.Text = "• " + infDescription;

            GradientLabel gradientLabel = new GradientLabel();
            gradientLabel.Text = titleLabel.Text;
            gradientLabel.Font = new Font("Century Gothic", 30, FontStyle.Bold);
            gradientLabel.Location = new Point(55, 28);
            gradientLabel.Size = new Size(440, 150);
            gradientLabel.StartColor = Color.FromArgb(245, 134, 52);
            gradientLabel.EndColor = Color.FromArgb(236, 38, 143);
            gradientLabel.BackColor = Color.Transparent;
            this.Controls.Add(gradientLabel);

            // Перемещаем элемент на передний план
            gradientLabel.BringToFront();


            heart(infIsChosen);
        }

        public void heart(bool choose) {
            if (choose) { heartLabel.Text = "✿";
                //если isChosen == true
            }
            else { heartLabel.Text = "♡";
                //если isChosen == false
            }
        }

        private void heartLabel_Click(object sender, System.EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            SqlConnection sqlConnection = dbConnection.getConnection();
            SqlTransaction transaction = null;
            string h = heartLabel.Text;
            try
            {
                using (sqlConnection)
                {
                    dbConnection.openConnection();
                    string query = "";
                    // В зависимости от значения userText формируем SQL запрос
                    if (h == "♡")
                    {
                        query = "UPDATE MainBooksInformation " +
                            "SET IsChosen = 1 " +
                            "WHERE Title = @title;";
                        heartLabel.Text = "✿";
                        //MessageBox.Show("установка 1...");
                    }
                    else if (h == "✿")
                    {
                        query = "UPDATE MainBooksInformation " +
                            "SET IsChosen = 0 " +
                            "WHERE Title = @title;";
                        heartLabel.Text = "♡";
                        //MessageBox.Show("установка 0...");
                    }

                    // Начинаем транзакцию
                    using (transaction = sqlConnection.BeginTransaction())
                    {
                        // Выполняем SQL запрос с инициализированной транзакцией
                        using (SqlCommand command = new SqlCommand(query, sqlConnection, transaction))
                        {
                            command.Parameters.AddWithValue("@Title", infTitle);

                            int rowsAffected = command.ExecuteNonQuery();

                            // Фиксируем транзакцию
                            transaction.Commit();
                        }
                    }
                    try {
                        Profile openedProfile = Profile.Instance;
                        if (openedProfile != null)
                        {
                            openedProfile.loadInf();
                            openedProfile.count.Text = Convert.ToString(openedProfile.booksCounter());
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception err){
                        MessageBox.Show("Error: " + err.Message);
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                transaction?.Rollback();
            }
            finally
            {
                dbConnection.closedConnection();
            }
        }
    }
}
