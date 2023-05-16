using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class FormBook : Form
    {
        public Book TheBook;
        public FormBook(Book s)
        {
            TheBook = s;
            InitializeComponent();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            if(TheBook != null)
            {
                tbId.Text = TheBook.Id.ToString();
                tbName.Text = TheBook.Name;    
                tbAuthor.Text = TheBook.Author;
                tbYear.Text = TheBook.Year.ToString();
                tbGenre.Text = TheBook.Genre;
                tbCoverType.Text = TheBook.CoverType;
                tbRating.Text = TheBook.Rating.ToString("0.00");
                chbAgeLimit.Checked = TheBook.AgeLimit;
                chbCoAuthor.Checked = TheBook.CoAuthor;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(tbId.Text.Trim(), out id))
            {
                TheBook.Id = id;
            }
            else
            {
                MessageBox.Show("Неправильно введене число!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbId.Focus();
                return;
            }

            TheBook.Name = tbName.Text.Trim();
            TheBook.Author = tbAuthor.Text.Trim();

            int year;
            if (int.TryParse(tbYear.Text.Trim(), out year))
            {
                TheBook.Year = year;
            }
            else
            {
                MessageBox.Show("Неправильно введене число!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbYear.Focus();
                return;
            }

            TheBook.Genre = tbGenre.Text.Trim();
            TheBook.CoverType = tbCoverType.Text.Trim();

            double rating;
            if (double.TryParse(tbRating.Text.Trim(), out rating))
            {
                TheBook.Rating = rating;
            }
            else
            {
                MessageBox.Show("Неправильно введене число!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRating.Focus();
                return;
            }

            TheBook.AgeLimit = chbAgeLimit.Checked;
            TheBook.CoAuthor = chbCoAuthor.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
