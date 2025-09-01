namespace QuizMaker.Forms
{
    partial class CreateQuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMCQ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddToF = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mcqPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.txtChoiceD = new System.Windows.Forms.TextBox();
            this.txtChoiceC = new System.Windows.Forms.TextBox();
            this.txtChoiceB = new System.Windows.Forms.TextBox();
            this.txtChoiceA = new System.Windows.Forms.TextBox();
            this.tofPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.mcqPanel.SuspendLayout();
            this.tofPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 16;
            this.listBoxQuestions.Location = new System.Drawing.Point(-4, 0);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(160, 548);
            this.listBoxQuestions.TabIndex = 0;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(266, 244);
            this.numPoints.Name = "numPoints";
            this.numPoints.ReadOnly = true;
            this.numPoints.Size = new System.Drawing.Size(120, 22);
            this.numPoints.TabIndex = 1;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(165, 104);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(657, 134);
            this.txtQuestion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Question #";
            // 
            // btnAddMCQ
            // 
            this.btnAddMCQ.Location = new System.Drawing.Point(165, 59);
            this.btnAddMCQ.Name = "btnAddMCQ";
            this.btnAddMCQ.Size = new System.Drawing.Size(95, 23);
            this.btnAddMCQ.TabIndex = 9;
            this.btnAddMCQ.Text = "Add MCQ";
            this.btnAddMCQ.UseVisualStyleBackColor = true;
            this.btnAddMCQ.Click += new System.EventHandler(this.btnAddMCQ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Create Quiz";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(165, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddToF
            // 
            this.btnAddToF.Location = new System.Drawing.Point(266, 59);
            this.btnAddToF.Name = "btnAddToF";
            this.btnAddToF.Size = new System.Drawing.Size(100, 23);
            this.btnAddToF.TabIndex = 10;
            this.btnAddToF.Text = "Add ToF";
            this.btnAddToF.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(271, 513);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mcqPanel
            // 
            this.mcqPanel.Controls.Add(this.tofPanel);
            this.mcqPanel.Controls.Add(this.label3);
            this.mcqPanel.Controls.Add(this.cbCorrectAnswer);
            this.mcqPanel.Controls.Add(this.txtChoiceD);
            this.mcqPanel.Controls.Add(this.txtChoiceC);
            this.mcqPanel.Controls.Add(this.txtChoiceB);
            this.mcqPanel.Controls.Add(this.txtChoiceA);
            this.mcqPanel.Location = new System.Drawing.Point(166, 272);
            this.mcqPanel.Name = "mcqPanel";
            this.mcqPanel.Size = new System.Drawing.Size(656, 235);
            this.mcqPanel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Multiple Choice Question";
            // 
            // cbCorrectAnswer
            // 
            this.cbCorrectAnswer.FormattingEnabled = true;
            this.cbCorrectAnswer.Location = new System.Drawing.Point(100, 184);
            this.cbCorrectAnswer.Name = "cbCorrectAnswer";
            this.cbCorrectAnswer.Size = new System.Drawing.Size(553, 24);
            this.cbCorrectAnswer.TabIndex = 12;
            // 
            // txtChoiceD
            // 
            this.txtChoiceD.Location = new System.Drawing.Point(100, 151);
            this.txtChoiceD.Name = "txtChoiceD";
            this.txtChoiceD.Size = new System.Drawing.Size(553, 22);
            this.txtChoiceD.TabIndex = 11;
            // 
            // txtChoiceC
            // 
            this.txtChoiceC.Location = new System.Drawing.Point(100, 114);
            this.txtChoiceC.Name = "txtChoiceC";
            this.txtChoiceC.Size = new System.Drawing.Size(553, 22);
            this.txtChoiceC.TabIndex = 10;
            // 
            // txtChoiceB
            // 
            this.txtChoiceB.Location = new System.Drawing.Point(100, 77);
            this.txtChoiceB.Name = "txtChoiceB";
            this.txtChoiceB.Size = new System.Drawing.Size(553, 22);
            this.txtChoiceB.TabIndex = 9;
            // 
            // txtChoiceA
            // 
            this.txtChoiceA.Location = new System.Drawing.Point(100, 39);
            this.txtChoiceA.Name = "txtChoiceA";
            this.txtChoiceA.Size = new System.Drawing.Size(553, 22);
            this.txtChoiceA.TabIndex = 8;
            // 
            // tofPanel
            // 
            this.tofPanel.Controls.Add(this.rbFalse);
            this.tofPanel.Controls.Add(this.rbTrue);
            this.tofPanel.Controls.Add(this.label4);
            this.tofPanel.Enabled = false;
            this.tofPanel.Location = new System.Drawing.Point(0, 0);
            this.tofPanel.Name = "tofPanel";
            this.tofPanel.Size = new System.Drawing.Size(656, 235);
            this.tofPanel.TabIndex = 16;
            this.tofPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "True or False";
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Location = new System.Drawing.Point(97, 41);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(56, 20);
            this.rbTrue.TabIndex = 16;
            this.rbTrue.TabStop = true;
            this.rbTrue.Text = "True";
            this.rbTrue.UseVisualStyleBackColor = true;
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Location = new System.Drawing.Point(97, 79);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(62, 20);
            this.rbFalse.TabIndex = 17;
            this.rbFalse.TabStop = true;
            this.rbFalse.Text = "False";
            this.rbFalse.UseVisualStyleBackColor = true;
            // 
            // CreateQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 548);
            this.Controls.Add(this.mcqPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddToF);
            this.Controls.Add(this.btnAddMCQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.listBoxQuestions);
            this.Name = "CreateQuizForm";
            this.Text = "CreateQuizForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateQuizForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.mcqPanel.ResumeLayout(false);
            this.mcqPanel.PerformLayout();
            this.tofPanel.ResumeLayout(false);
            this.tofPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMCQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddToF;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel mcqPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCorrectAnswer;
        private System.Windows.Forms.TextBox txtChoiceD;
        private System.Windows.Forms.TextBox txtChoiceC;
        private System.Windows.Forms.TextBox txtChoiceB;
        private System.Windows.Forms.TextBox txtChoiceA;
        private System.Windows.Forms.Panel tofPanel;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.Label label4;
    }
}