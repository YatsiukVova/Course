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
    public partial class FormFilter : Form
    {
        public double RatingMin;
        public double RatingMax;
        public FormFilter(double ratingMin, double ratingMax)
        {
            RatingMin = ratingMin;
            RatingMax = ratingMax;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(tbRatingMin.Text, out RatingMin))
            {
                MessageBox.Show("Неправильно введено число!", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                tbRatingMin.Focus();
                return;
            }
            if (!double.TryParse(tbRatingMax.Text, out RatingMax))
            {
                MessageBox.Show("Неправильно введено число!", "",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRatingMax.Focus(); 
                return;
            }
            DialogResult = DialogResult.OK;
        }
        private void FormFilter_Load(object sender, EventArgs e)
        {
            tbRatingMin.Text = RatingMin.ToString("0");
            tbRatingMax.Text = RatingMax.ToString("0");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
