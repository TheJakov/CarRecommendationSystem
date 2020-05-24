namespace CarRecommendationSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblGlavniNaslov = new System.Windows.Forms.Label();
            this.lblGradThes = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGlavniNaslov
            // 
            this.lblGlavniNaslov.AutoSize = true;
            this.lblGlavniNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlavniNaslov.Location = new System.Drawing.Point(133, 39);
            this.lblGlavniNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGlavniNaslov.Name = "lblGlavniNaslov";
            this.lblGlavniNaslov.Size = new System.Drawing.Size(351, 29);
            this.lblGlavniNaslov.TabIndex = 2;
            this.lblGlavniNaslov.Text = "Car recommendation system ";
            // 
            // lblGradThes
            // 
            this.lblGradThes.AutoSize = true;
            this.lblGradThes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradThes.Location = new System.Drawing.Point(11, 483);
            this.lblGradThes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradThes.Name = "lblGradThes";
            this.lblGradThes.Size = new System.Drawing.Size(239, 20);
            this.lblGradThes.TabIndex = 4;
            this.lblGradThes.Text = "Graduate thesis - Jakov Kristović";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.Image")));
            this.pictureBoxCar.Location = new System.Drawing.Point(116, 92);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(414, 264);
            this.pictureBoxCar.TabIndex = 5;
            this.pictureBoxCar.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(90, 343);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(435, 18);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "It should be noted that this is currently a prototype and works with";
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc2.Location = new System.Drawing.Point(161, 361);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(303, 18);
            this.lblDesc2.TabIndex = 7;
            this.lblDesc2.Text = "only 97 different cars available in the data set.";
            this.lblDesc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(173, 397);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(272, 53);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "I am ready to find a new car !";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 512);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDesc2);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.lblGradThes);
            this.Controls.Add(this.lblGlavniNaslov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(639, 551);
            this.MinimumSize = new System.Drawing.Size(639, 551);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Recommendation System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGlavniNaslov;
        private System.Windows.Forms.Label lblGradThes;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.Button btnStart;
    }
}

