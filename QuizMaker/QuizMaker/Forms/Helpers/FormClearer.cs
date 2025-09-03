using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker.Forms.Helpers
{
    public static class FormClearer
    {
        public static void ClearText(TextBox txtQuestion)
        {
            txtQuestion.Text = "";
        }

        public static void ClearTextChoices(TextBox txtChoiceA, TextBox txtChoiceB, TextBox txtChoiceC, TextBox txtChoiceD)
        {
            txtChoiceA.Text = "";
            txtChoiceB.Text = "";
            txtChoiceC.Text = "";
            txtChoiceD.Text = "";
        }

        public static void ClearRadioButton(RadioButton rbTrue, RadioButton rbFalse)
        {
            rbTrue.Checked = false;
            rbFalse.Checked = false;
        }

        public static void ClearNumPoints(NumericUpDown numPoints)
        {
            numPoints.ResetText();
            numPoints.Value = 0;
        }

        public static void ClearCorrectAnswer(ComboBox cbCorrectAnswer)
        {
            cbCorrectAnswer.Text = "";
            cbCorrectAnswer.Items.Clear();
        }
    }
}
