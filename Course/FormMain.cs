using System.Globalization;
using System.Text;

namespace Course
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tsslFileName.Text = tsslRating.Text = "";
            gvBooks.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Id";
            column.HeaderText = "id";
            gvBooks.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.HeaderText = "Назва";
            gvBooks.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Author";
            column.HeaderText = "Автор";
            gvBooks.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Year";
            column.HeaderText = "Рік випуску";
            gvBooks.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Genre";
            column.HeaderText = "Жанр";
            gvBooks.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CoverType";
            column.HeaderText = "Тип обкладинки";
            gvBooks.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "AgeLimit";
            column.HeaderText = "Вік обмеження ";
            gvBooks.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CoAuthor";
            column.HeaderText = "Співавтор";
            column.Width = 80;
            gvBooks.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Rating";
            column.HeaderText = "Рейтинг";
            gvBooks.Columns.Add(column);

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 10 * btnAdd.Width + 4 * tsSeparator1.Width + tslSortBy.Width + tslcbSortBy.Width + tslFind.Width + tsltbSearch.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            FormBook fb = new FormBook(book);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                gvBooks.DataSource = bindScrBooks;
                bindScrBooks.Add(book);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bindScrBooks.List.Count == 0) return;
            Book book = (Book)bindScrBooks.List[bindScrBooks.Position];
            FormBook fb = new FormBook(book);
            if (fb.ShowDialog() == DialogResult.OK)
            {
                bindScrBooks.List[bindScrBooks.Position] = book;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bindScrBooks.List.Count == 0) return;
            if (MessageBox.Show("Видалити поточний запис?",
            "Видалення запису", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindScrBooks.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (bindScrBooks.List.Count == 0) return;
            if (MessageBox.Show("Очистити таблицю?\n\n" +
            "Всі дані будуть втрачені", "Очищення даних",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindScrBooks.Clear();
            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Файли даних (*.books)|*.books|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у бінарному форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            BinaryReader br;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindScrBooks.Clear();
                br = new BinaryReader(openFileDialog.OpenFile());
                try
                {
                    Book book;
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        book = new Book();
                        for (int i = 1; i <= 10; i++)
                        {
                            switch (i)

                            {

                                case 1:
                                    book.Id = br.ReadInt32();

                                    break;
                                case 2:
                                    book.Name = br.ReadString();

                                    break;
                                case 3:
                                    book.Author = br.ReadString();

                                    break;
                                case 4:
                                    book.Year = br.ReadInt32();

                                    break;
                                case 5:
                                    book.Genre = br.ReadString();

                                    break;
                                case 6:
                                    book.CoverType = br.ReadString();

                                    break;
                                case 7:
                                    book.AgeLimit = br.ReadBoolean();

                                    break;
                                case 8:
                                    book.CoAuthor = br.ReadBoolean();

                                    break;
                                case 9:
                                    book.Rating = br.ReadDouble();

                                    break; 
                            }
                        }
                        bindScrBooks.Add(book);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    br.Close();
                }
                tsslFileName.Text = openFileDialog.SafeFileName;
            }
            gvBooks.DataSource = bindScrBooks;
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            if (bindScrBooks.List.Count == 0) return;
            saveFileDialog.Filter = "Файли даних (*.books)|*.books|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());
                try
                {
                    foreach (Book book in bindScrBooks.List)
                    {
                        bw.Write(book.Id);
                        bw.Write(book.Name);
                        bw.Write(book.Author);
                        bw.Write(book.Year);
                        bw.Write(book.Genre);
                        bw.Write(book.CoverType);
                        bw.Write(book.AgeLimit);
                        bw.Write(book.CoAuthor);
                        bw.Write(book.Rating);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bw.Close();
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindScrBooks.Clear();
                sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Book book = new Book(int.Parse(split[0]), split[1], split[2], 
                        int.Parse(split[3]), split[4], split[5],
                        bool.Parse(split[6]), bool.Parse(split[7]),
                        double.Parse(split[8]));
                        bindScrBooks.Add(book);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
                tsslFileName.Text = openFileDialog.SafeFileName;
            }
            gvBooks.DataSource = bindScrBooks;
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            if (bindScrBooks.List.Count == 0) return;
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName,
                false, Encoding.UTF8);
                try
                {
                    foreach (Book book in bindScrBooks.List)
                    {
                        sw.Write(book.Id + "\t" + book.Name + "\t" +
                        book.Author + "\t" + book.Year + "\t" +
                        book.Genre + "\t" + book.CoverType + "\t" +
                        book.AgeLimit + "\t" + book.CoAuthor + "\t" +
                        book.Rating + "\t\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (bindScrBooks.List.Count == 0) return;
            double ratingMin = ((Book)bindScrBooks.List[0]).Rating;
            double ratingMax = ((Book)bindScrBooks.List[0]).Rating;
            foreach (Book book in bindScrBooks.List)
            {
                if (book.Rating < ratingMin) ratingMin = book.Rating;
                if (book.Rating > ratingMax) ratingMax = book.Rating;
            }
            FormFilter ft = new FormFilter(ratingMin, ratingMax);
            if (ft.ShowDialog() == DialogResult.OK)
            {
            StartOfLoop:
                for (int i = 0; i < bindScrBooks.Count; i++)
                {
                    if ((((Book)bindScrBooks.List[i]).Rating < ft.RatingMin) ||
                    (((Book)bindScrBooks.List[i]).Rating > ft.RatingMax))
                    {
                        bindScrBooks.RemoveAt(i);
                        goto StartOfLoop;
                    }
                }
            }
        }
        private void tslcbSortBy_Click(object sender, EventArgs e){}

        public BooksSortOrder SortOrder;
        private void tslcbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bindScrBooks.List.Count == 0) return;
            switch (tslcbSortBy.SelectedIndex)
            {
                case 0:
                    SortOrder = BooksSortOrder.SortById;
                    break;
                case 1:
                    SortOrder = BooksSortOrder.SortByName;
                    break;
                case 2:
                    SortOrder = BooksSortOrder.SortByAuthor;
                    break;
                case 3:
                    SortOrder = BooksSortOrder.SortByYear;
                    break;
                case 4:
                    SortOrder = BooksSortOrder.SortByGenre;
                    break;
                case 5:
                    SortOrder = BooksSortOrder.SortByRating;
                    break;
                default:
                    SortOrder = BooksSortOrder.SortById;
                    break;
            }
            foreach (Book book in bindScrBooks.List)
                book.SortOrder = SortOrder;
            List<Book> books = new List<Book>();
            foreach (Book book in bindScrBooks.List)
                books.Add(book);
            books.Sort();
            bindScrBooks.Clear();
            foreach (Book book in books)
                bindScrBooks.Add(book);
            gvBooks.Focus();
            gvBooks.DataSource = bindScrBooks;
        }

        private void tsltbSearch_TextChanged(object sender, EventArgs e)
        {
            if (bindScrBooks.List.Count == 0) return;
            string findText = tsltbSearch.Text;
            if (findText.Trim() == "") return;
            gvBooks.ClearSelection();
            CultureInfo culture = new CultureInfo("uk-UA");
            for (int i = 0; i < bindScrBooks.Count; i++)
            {
                if (((Book)bindScrBooks.List[i]).Name.StartsWith(findText, true, culture))
                {
                    gvBooks.CurrentCell = gvBooks.Rows[i].Cells[0];
                    break;
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question) == DialogResult.OK)
                e.Cancel = false;
            else e.Cancel = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gvBooks_CurrentCellChanged(object sender, EventArgs e)
        {
            Book book = (Book)bindScrBooks.List[bindScrBooks.Position];
            tsslRating.Text = string.Format("Рейтинг:{0:0.0}", book.Ratings());
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Застосунок демонструє зразок " +
           "виконання курсової роботи\n" +
           "з курсу 'Об'єктно-орієнтоване програмування'\n\n" +
           "Розробив: студ. гр. КБІКС-у-22-1  Харківського національного  " +
           "університету радіоелектроніки  \nЯцюк В. А.",
           "Про програму", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}