using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker.Forms.Helpers
{
    public static class FormToggle
    {
        public static void RemoveAddControls(FlowLayoutPanel flowLayout, Button btnAdd_MCQ, Button btnAdd_ToF)
        {
            flowLayout.Controls.Remove(btnAdd_MCQ);
            flowLayout.Controls.Remove(btnAdd_ToF);
        }
        public static void RemoveSaveCancel(FlowLayoutPanel flowLayout, Button btnSave, Button btnCancel)
        {
            flowLayout.Controls.Remove(btnSave);
            flowLayout.Controls.Remove(btnCancel);
        }
        public static void AddAddControls(FlowLayoutPanel flowLayout, Button btnAdd_MCQ, Button btnAdd_ToF)
        {
            flowLayout.Controls.Add(btnAdd_MCQ);
            flowLayout.Controls.Add(btnAdd_ToF);
        }
        public static void AddSaveCancel(FlowLayoutPanel flowLayout, Button btnSave, Button btnCancel)
        {
            flowLayout.Controls.Add(btnSave);
            flowLayout.Controls.Add(btnCancel);
        }
        public static void ToggleMCQ(Panel mcqPanel, Panel tofPanel, TextBox textQuestion, NumericUpDown numPoints, bool enabled = true)
        {
            ShowMCQ(mcqPanel, tofPanel);
            EnableMCQ(mcqPanel: mcqPanel, tofPanel: tofPanel, textQuestion: textQuestion, numPoints: numPoints, enabled: enabled);;
        }

        public static void ToggleToF(Panel mcqPanel, Panel tofPanel, TextBox textQuestion, NumericUpDown numPoints, bool enabled = true)
        {
            ShowToF(mcqPanel, tofPanel);
            EnableToF(mcqPanel: mcqPanel, tofPanel: tofPanel, textQuestion: textQuestion, numPoints: numPoints);
        }
        public static void EnableMCQ(Panel mcqPanel, Panel tofPanel, TextBox textQuestion, NumericUpDown numPoints, bool enabled = true)
        {
            DisablePanels(mcqPanel, tofPanel);
            mcqPanel.Enabled = enabled;
            textQuestion.ReadOnly = !enabled;
            numPoints.ReadOnly = !enabled;
            tofPanel.Enabled = !enabled;
        }

        public static void EnableToF(Panel mcqPanel, Panel tofPanel, TextBox textQuestion, NumericUpDown numPoints, bool enabled = true)
        {
            DisablePanels(mcqPanel, tofPanel);
            mcqPanel.Enabled = !enabled;
            numPoints.ReadOnly = !enabled;
            textQuestion.ReadOnly = !enabled;
            tofPanel.Enabled = enabled;
        }

        public static void ShowMCQ(Panel mcqPanel, Panel tofPanel)
        {
            mcqPanel.Visible = true;
            tofPanel.Visible = !true;
        }

        public static void ShowToF(Panel mcqPanel, Panel tofPanel)
        {
            mcqPanel.Visible = !true;
            tofPanel.Visible = true;
        }

        public static void DisablePanels(Panel mcqPanel, Panel tofPanel)
        {
            mcqPanel.Enabled = false;
            tofPanel.Enabled = false;
        }

        public static void HidePanels(Panel mcqPanel, Panel tofPanel)
        {
            mcqPanel.Visible = false;
            tofPanel.Visible = false;
        }

        public static void ToggleButtons(Button save, Button cancel, Button addMCQ, Button addToF, bool editing = true)
        {
            save.Enabled = editing;
            save.Visible = editing;

            cancel.Enabled = editing;
            cancel.Visible = editing;

            addMCQ.Enabled = !editing;
            addToF.Enabled = !editing;
        }
    }
}
