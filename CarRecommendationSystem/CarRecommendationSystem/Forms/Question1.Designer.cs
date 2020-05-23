namespace CarRecommendationSystem.Forms
{
    partial class Question1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question1));
            this.btnNext = new System.Windows.Forms.Button();
            this.lblFirstQuestion = new System.Windows.Forms.Label();
            this.lblFirstQuestion2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVeryImportant = new System.Windows.Forms.CheckBox();
            this.cbImportant = new System.Windows.Forms.CheckBox();
            this.cbNeutral = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(521, 467);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 34);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblFirstQuestion
            // 
            this.lblFirstQuestion.AutoSize = true;
            this.lblFirstQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstQuestion.Location = new System.Drawing.Point(30, 33);
            this.lblFirstQuestion.Name = "lblFirstQuestion";
            this.lblFirstQuestion.Size = new System.Drawing.Size(499, 24);
            this.lblFirstQuestion.TabIndex = 8;
            this.lblFirstQuestion.Text = "How important is it to you that the car has very good driving";
            // 
            // lblFirstQuestion2
            // 
            this.lblFirstQuestion2.AutoSize = true;
            this.lblFirstQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstQuestion2.Location = new System.Drawing.Point(30, 57);
            this.lblFirstQuestion2.Name = "lblFirstQuestion2";
            this.lblFirstQuestion2.Size = new System.Drawing.Size(132, 24);
            this.lblFirstQuestion2.TabIndex = 9;
            this.lblFirstQuestion2.Text = "performance ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Only one option can be checked.";
            // 
            // cbVeryImportant
            // 
            this.cbVeryImportant.AutoSize = true;
            this.cbVeryImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeryImportant.Location = new System.Drawing.Point(80, 224);
            this.cbVeryImportant.Name = "cbVeryImportant";
            this.cbVeryImportant.Size = new System.Drawing.Size(131, 24);
            this.cbVeryImportant.TabIndex = 29;
            this.cbVeryImportant.Text = "Very important";
            this.cbVeryImportant.UseVisualStyleBackColor = true;
            // 
            // cbImportant
            // 
            this.cbImportant.AutoSize = true;
            this.cbImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImportant.Location = new System.Drawing.Point(80, 180);
            this.cbImportant.Name = "cbImportant";
            this.cbImportant.Size = new System.Drawing.Size(97, 24);
            this.cbImportant.TabIndex = 28;
            this.cbImportant.Text = "Important";
            this.cbImportant.UseVisualStyleBackColor = true;
            // 
            // cbNeutral
            // 
            this.cbNeutral.AutoSize = true;
            this.cbNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNeutral.Location = new System.Drawing.Point(80, 136);
            this.cbNeutral.Name = "cbNeutral";
            this.cbNeutral.Size = new System.Drawing.Size(182, 24);
            this.cbNeutral.TabIndex = 27;
            this.cbNeutral.Text = "It\'s all the same to me";
            this.cbNeutral.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(97, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 34);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(21, 471);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(55, 24);
            this.lblQuestionNumber.TabIndex = 34;
            this.lblQuestionNumber.Text = "1 / 14";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDesc.Location = new System.Drawing.Point(30, 93);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(459, 24);
            this.lblDesc.TabIndex = 36;
            this.lblDesc.Text = "Handling, suspension, steering, braking, acceleration.";
            // 
            // Question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 513);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVeryImportant);
            this.Controls.Add(this.cbImportant);
            this.Controls.Add(this.cbNeutral);
            this.Controls.Add(this.lblFirstQuestion2);
            this.Controls.Add(this.lblFirstQuestion);
            this.Controls.Add(this.btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 552);
            this.MinimumSize = new System.Drawing.Size(640, 552);
            this.Name = "Question1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question 1 - Driving";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblFirstQuestion;
        private System.Windows.Forms.Label lblFirstQuestion2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbVeryImportant;
        private System.Windows.Forms.CheckBox cbImportant;
        private System.Windows.Forms.CheckBox cbNeutral;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblDesc;
    }
}