using QuizMaker.Forms.Helpers;
using QuizMaker.Models;
using QuizMaker.Services;
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
    public partial class CreateQuizForm : Form
    {
        private Quiz _quiz;
        private QuizService _quizService;

        private enum questionType { mcq, tof};
        private questionType _questionType;

        public CreateQuizForm()
        {
            InitializeComponent();

            FormToggle.ShowMCQ(mcqPanel: mcqPanel, tofPanel: tofPanel);
            FormToggle.DisablePanels(mcqPanel: mcqPanel, tofPanel: tofPanel);

            string filePath = "quiz.json";

            if (System.IO.File.Exists(filePath))
            {
                _quiz = QuizStorage.LoadQuiz(filePath);
            }
            else
            {
                _quiz = new Quiz { Title = "My Quiz" };
            }

            _quizService = new QuizService(_quiz);

            foreach (var q in _quiz.Questions)
            {
                listBoxQuestions.Items.Add(q);
            }
        }

        private void RefreshComboBox()
        {
            cbCorrectAnswer.Items.Clear();

            if (!string.IsNullOrWhiteSpace(txtChoiceA.Text)) cbCorrectAnswer.Items.Add(txtChoiceA.Text);
            if (!string.IsNullOrWhiteSpace(txtChoiceB.Text)) cbCorrectAnswer.Items.Add(txtChoiceB.Text);
            if (!string.IsNullOrWhiteSpace(txtChoiceC.Text)) cbCorrectAnswer.Items.Add(txtChoiceC.Text);
            if (!string.IsNullOrWhiteSpace(txtChoiceD.Text)) cbCorrectAnswer.Items.Add(txtChoiceD.Text);
        }


        private void txtChoiceA_TextChanged(object sender, EventArgs e)
        {
            RefreshComboBox();
        }

        private void txtChoiceB_TextChanged(object sender, EventArgs e)
        {
            RefreshComboBox();
        }

        private void txtChoiceC_TextChanged(object sender, EventArgs e)
        {
            RefreshComboBox();
        }

        private void txtChoiceD_TextChanged(object sender, EventArgs e)
        {
            RefreshComboBox();
        }

        private void btnAddMCQ_Click(object sender, EventArgs e)
        {
            FormToggle.ToggleMCQ(mcqPanel: mcqPanel, tofPanel: tofPanel, textQuestion: txtQuestion, numPoints: numPoints);
            FormToggle.ToggleButtons(save: btnSave, cancel: btnCancel, addMCQ: btnAddMCQ, addToF: btnAddToF);
        }

        private void CreateQuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = "quiz.json";
            QuizStorage.SaveQuiz(_quiz, filePath);
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem is Question q)
            {
                txtQuestion.Text = q.QuestionText;
                numPoints.Value = q.Point;

                if (q is MultipleChoiceQuestion mcq)
                {
                    txtChoiceA.Text = mcq.QuestionChoices.Count > 0 ? mcq.QuestionChoices[0] : "";
                    txtChoiceB.Text = mcq.QuestionChoices.Count > 1 ? mcq.QuestionChoices[1] : "";
                    txtChoiceC.Text = mcq.QuestionChoices.Count > 2 ? mcq.QuestionChoices[2] : "";
                    txtChoiceD.Text = mcq.QuestionChoices.Count > 3 ? mcq.QuestionChoices[3] : "";

                    cbCorrectAnswer.Items.Clear();
                    foreach (var choice in mcq.QuestionChoices)
                        cbCorrectAnswer.Items.Add(choice);

                    cbCorrectAnswer.SelectedItem = mcq.CorrectAnswer;
                }

                else if (q is TrueOrFalseQuestion tff)
                {
                    
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_questionType == questionType.mcq)
            {
                var q = new MultipleChoiceQuestion
                {
                    QuestionText = txtQuestion.Text,
                    Point = (int)numPoints.Value,
                    QuestionChoices = new List<string>
                {
                    txtChoiceA.Text,
                    txtChoiceB.Text,
                    txtChoiceC.Text,
                    txtChoiceD.Text
                },
                    CorrectAnswer = cbCorrectAnswer.SelectedItem.ToString()
                };

                _quizService.AddQuestion(q);
                listBoxQuestions.Items.Add(q);
            }
            else if (_questionType == questionType.tof)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormToggle.ToggleMCQ(mcqPanel: mcqPanel, tofPanel: tofPanel, textQuestion: txtQuestion, numPoints: numPoints, enabled: false);
            FormToggle.ToggleButtons(save: btnSave, cancel: btnCancel, addMCQ: btnAddMCQ, addToF: btnAddToF, editing: false);
        }
    }
}
