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
        public static void ToggleMCQ(Panel mcqPanel, Panel tofPanel, TextBox textQuestion, NumericUpDown numPoints, bool enabled = true)
        {
            EnableMCQ(mcqPanel: mcqPanel, tofPanel: tofPanel, textQuestion: textQuestion, numPoints: numPoints, enabled: enabled);
            ShowMCQ(mcqPanel, tofPanel);
        }

        public static void ToggleToF(Panel mcqPanel, Panel tofPanel, TextBox textQuestion, NumericUpDown numPoints)
        {
            EnableToF(mcqPanel: mcqPanel, tofPanel: tofPanel, textQuestion: textQuestion, numPoints: numPoints);
            ShowToF(mcqPanel, tofPanel);
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

        public static void ShowMCQ(Panel mcqPanel, Panel tofPanel, bool visible = true)
        {
            mcqPanel.Visible = visible;
            tofPanel.Visible = !visible;
        }

        public static void ShowToF(Panel mcqPanel, Panel tofPanel, bool visible = true)
        {
            mcqPanel.Visible = !visible;
            tofPanel.Visible = visible;
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
