namespace CarRecommendationSystem.Forms
{
    partial class Question2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question2));
            this.lblSecondQuestion = new System.Windows.Forms.Label();
            this.lblSecondQuestion2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVeryImportant = new System.Windows.Forms.CheckBox();
            this.cbImportant = new System.Windows.Forms.CheckBox();
            this.cbNeutral = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSecondQuestion
            // 
            this.lblSecondQuestion.AutoSize = true;
            this.lblSecondQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondQuestion.Location = new System.Drawing.Point(30, 33);
            this.lblSecondQuestion.Name = "lblSecondQuestion";
            this.lblSecondQuestion.Size = new System.Drawing.Size(557, 24);
            this.lblSecondQuestion.TabIndex = 9;
            this.lblSecondQuestion.Text = "How important is it to you that the car is comfortable and spacious ";
            // 
            // lblSecondQuestion2
            // 
            this.lblSecondQuestion2.AutoSize = true;
            this.lblSecondQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondQuestion2.Location = new System.Drawing.Point(30, 57);
            this.lblSecondQuestion2.Name = "lblSecondQuestion2";
            this.lblSecondQuestion2.Size = new System.Drawing.Size(167, 24);
            this.lblSecondQuestion2.TabIndex = 10;
            this.lblSecondQuestion2.Text = "to sit while driving?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Only one option can be checked.";
            // 
            // cbVeryImportant
            // 
            this.cbVeryImportant.AutoSize = true;
            this.cbVeryImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeryImportant.Location = new System.Drawing.Point(80, 223);
            this.cbVeryImportant.Name = "cbVeryImportant";
            this.cbVeryImportant.Size = new System.Drawing.Size(131, 24);
            this.cbVeryImportant.TabIndex = 33;
            this.cbVeryImportant.Text = "Very important";
            this.cbVeryImportant.UseVisualStyleBackColor = true;
            // 
            // cbImportant
            // 
            this.cbImportant.AutoSize = true;
            this.cbImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImportant.Location = new System.Drawing.Point(80, 179);
            this.cbImportant.Name = "cbImportant";
            this.cbImportant.Size = new System.Drawing.Size(97, 24);
            this.cbImportant.TabIndex = 32;
            this.cbImportant.Text = "Important";
            this.cbImportant.UseVisualStyleBackColor = true;
            // 
            // cbNeutral
            // 
            this.cbNeutral.AutoSize = true;
            this.cbNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNeutral.Location = new System.Drawing.Point(80, 134);
            this.cbNeutral.Name = "cbNeutral";
            this.cbNeutral.Size = new System.Drawing.Size(182, 24);
            this.cbNeutral.TabIndex = 31;
            this.cbNeutral.Text = "It\'s all the same to me";
            this.cbNeutral.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(521, 467);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 34);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(97, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 34);
            this.btnCancel.TabIndex = 36;
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
            this.lblQuestionNumber.TabIndex = 37;
            this.lblQuestionNumber.Text = "2 / 14";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDesc.Location = new System.Drawing.Point(30, 93);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(470, 24);
            this.lblDesc.TabIndex = 38;
            this.lblDesc.Text = "Seats quality, road noise, engine noise, climate system.";
            // 
            // Question2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 513);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVeryImportant);
            this.Controls.Add(this.cbImportant);
            this.Controls.Add(this.cbNeutral);
            this.Controls.Add(this.lblSecondQuestion2);
            this.Controls.Add(this.lblSecondQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 552);
            this.MinimumSize = new System.Drawing.Size(640, 552);
            this.Name = "Question2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question 2 - Comfort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecondQuestion;
        private System.Windows.Forms.Label lblSecondQuestion2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbVeryImportant;
        private System.Windows.Forms.CheckBox cbImportant;
        private System.Windows.Forms.CheckBox cbNeutral;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblDesc;
    }
}