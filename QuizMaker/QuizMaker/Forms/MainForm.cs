using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            var createForm = new CreateQuizForm();
            createForm.ShowDialog();
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            var takeForm = new TakeQuizForm();
            takeForm.ShowDialog();
        }
    }
}
