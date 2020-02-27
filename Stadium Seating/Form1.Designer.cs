namespace Stadium_Seating
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
            this.ticketsSoldLabel = new System.Windows.Forms.Label();
            this.aDescriptionLabel = new System.Windows.Forms.Label();
            this.bDescriptionLabel = new System.Windows.Forms.Label();
            this.cDescriptionLabel = new System.Windows.Forms.Label();
            this.userInputC = new System.Windows.Forms.TextBox();
            this.userInputB = new System.Windows.Forms.TextBox();
            this.userInputA = new System.Windows.Forms.TextBox();
            this.aRevenueLabel = new System.Windows.Forms.Label();
            this.bRevenueLabel = new System.Windows.Forms.Label();
            this.cRevenueLabel = new System.Windows.Forms.Label();
            this.totalDescriptionLabel = new System.Windows.Forms.Label();
            this.aRevenueOutput = new System.Windows.Forms.Label();
            this.bRevenueOutput = new System.Windows.Forms.Label();
            this.cRevenueOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.ticketsSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.revenueGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsSoldGroupBox.SuspendLayout();
            this.revenueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSoldLabel
            // 
            this.ticketsSoldLabel.Location = new System.Drawing.Point(23, 16);
            this.ticketsSoldLabel.Name = "ticketsSoldLabel";
            this.ticketsSoldLabel.Size = new System.Drawing.Size(164, 26);
            this.ticketsSoldLabel.TabIndex = 1;
            this.ticketsSoldLabel.Text = "Enter the number of tickets sold for each class of seats";
            // 
            // aDescriptionLabel
            // 
            this.aDescriptionLabel.AutoSize = true;
            this.aDescriptionLabel.Location = new System.Drawing.Point(27, 59);
            this.aDescriptionLabel.Name = "aDescriptionLabel";
            this.aDescriptionLabel.Size = new System.Drawing.Size(45, 13);
            this.aDescriptionLabel.TabIndex = 3;
            this.aDescriptionLabel.Text = "Class A:";
            // 
            // bDescriptionLabel
            // 
            this.bDescriptionLabel.AutoSize = true;
            this.bDescriptionLabel.Location = new System.Drawing.Point(27, 97);
            this.bDescriptionLabel.Name = "bDescriptionLabel";
            this.bDescriptionLabel.Size = new System.Drawing.Size(45, 13);
            this.bDescriptionLabel.TabIndex = 4;
            this.bDescriptionLabel.Text = "Class B:";
            // 
            // cDescriptionLabel
            // 
            this.cDescriptionLabel.AutoSize = true;
            this.cDescriptionLabel.Location = new System.Drawing.Point(27, 131);
            this.cDescriptionLabel.Name = "cDescriptionLabel";
            this.cDescriptionLabel.Size = new System.Drawing.Size(45, 13);
            this.cDescriptionLabel.TabIndex = 5;
            this.cDescriptionLabel.Text = "Class C:";
            // 
            // userInputC
            // 
            this.userInputC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputC.Location = new System.Drawing.Point(78, 128);
            this.userInputC.Name = "userInputC";
            this.userInputC.Size = new System.Drawing.Size(100, 20);
            this.userInputC.TabIndex = 3;
            // 
            // userInputB
            // 
            this.userInputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputB.Location = new System.Drawing.Point(78, 94);
            this.userInputB.Name = "userInputB";
            this.userInputB.Size = new System.Drawing.Size(100, 20);
            this.userInputB.TabIndex = 2;
            // 
            // userInputA
            // 
            this.userInputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputA.Location = new System.Drawing.Point(78, 56);
            this.userInputA.Name = "userInputA";
            this.userInputA.Size = new System.Drawing.Size(100, 20);
            this.userInputA.TabIndex = 1;
            // 
            // aRevenueLabel
            // 
            this.aRevenueLabel.AutoSize = true;
            this.aRevenueLabel.Location = new System.Drawing.Point(27, 29);
            this.aRevenueLabel.Name = "aRevenueLabel";
            this.aRevenueLabel.Size = new System.Drawing.Size(45, 13);
            this.aRevenueLabel.TabIndex = 9;
            this.aRevenueLabel.Text = "Class A:";
            // 
            // bRevenueLabel
            // 
            this.bRevenueLabel.AutoSize = true;
            this.bRevenueLabel.Location = new System.Drawing.Point(27, 61);
            this.bRevenueLabel.Name = "bRevenueLabel";
            this.bRevenueLabel.Size = new System.Drawing.Size(45, 13);
            this.bRevenueLabel.TabIndex = 10;
            this.bRevenueLabel.Text = "Class B:";
            // 
            // cRevenueLabel
            // 
            this.cRevenueLabel.AutoSize = true;
            this.cRevenueLabel.Location = new System.Drawing.Point(27, 97);
            this.cRevenueLabel.Name = "cRevenueLabel";
            this.cRevenueLabel.Size = new System.Drawing.Size(45, 13);
            this.cRevenueLabel.TabIndex = 11;
            this.cRevenueLabel.Text = "Class C:";
            // 
            // totalDescriptionLabel
            // 
            this.totalDescriptionLabel.AutoSize = true;
            this.totalDescriptionLabel.Location = new System.Drawing.Point(38, 128);
            this.totalDescriptionLabel.Name = "totalDescriptionLabel";
            this.totalDescriptionLabel.Size = new System.Drawing.Size(34, 13);
            this.totalDescriptionLabel.TabIndex = 12;
            this.totalDescriptionLabel.Text = "Total:";
            // 
            // aRevenueOutput
            // 
            this.aRevenueOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aRevenueOutput.Location = new System.Drawing.Point(78, 19);
            this.aRevenueOutput.Name = "aRevenueOutput";
            this.aRevenueOutput.Size = new System.Drawing.Size(100, 23);
            this.aRevenueOutput.TabIndex = 4;
            this.aRevenueOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bRevenueOutput
            // 
            this.bRevenueOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bRevenueOutput.Location = new System.Drawing.Point(78, 56);
            this.bRevenueOutput.Name = "bRevenueOutput";
            this.bRevenueOutput.Size = new System.Drawing.Size(100, 23);
            this.bRevenueOutput.TabIndex = 5;
            this.bRevenueOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cRevenueOutput
            // 
            this.cRevenueOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRevenueOutput.Location = new System.Drawing.Point(78, 92);
            this.cRevenueOutput.Name = "cRevenueOutput";
            this.cRevenueOutput.Size = new System.Drawing.Size(100, 23);
            this.cRevenueOutput.TabIndex = 6;
            this.cRevenueOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Location = new System.Drawing.Point(78, 126);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 23);
            this.totalOutput.TabIndex = 7;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticketsSoldGroupBox
            // 
            this.ticketsSoldGroupBox.Controls.Add(this.ticketsSoldLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.userInputA);
            this.ticketsSoldGroupBox.Controls.Add(this.userInputB);
            this.ticketsSoldGroupBox.Controls.Add(this.userInputC);
            this.ticketsSoldGroupBox.Controls.Add(this.aDescriptionLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.bDescriptionLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.cDescriptionLabel);
            this.ticketsSoldGroupBox.Location = new System.Drawing.Point(12, 33);
            this.ticketsSoldGroupBox.Name = "ticketsSoldGroupBox";
            this.ticketsSoldGroupBox.Size = new System.Drawing.Size(203, 181);
            this.ticketsSoldGroupBox.TabIndex = 17;
            this.ticketsSoldGroupBox.TabStop = false;
            this.ticketsSoldGroupBox.Text = "Tickets Sold";
            // 
            // revenueGroupBox
            // 
            this.revenueGroupBox.Controls.Add(this.aRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.bRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.totalOutput);
            this.revenueGroupBox.Controls.Add(this.cRevenueLabel);
            this.revenueGroupBox.Controls.Add(this.cRevenueOutput);
            this.revenueGroupBox.Controls.Add(this.totalDescriptionLabel);
            this.revenueGroupBox.Controls.Add(this.bRevenueOutput);
            this.revenueGroupBox.Controls.Add(this.aRevenueOutput);
            this.revenueGroupBox.Location = new System.Drawing.Point(244, 33);
            this.revenueGroupBox.Name = "revenueGroupBox";
            this.revenueGroupBox.Size = new System.Drawing.Size(200, 181);
            this.revenueGroupBox.TabIndex = 18;
            this.revenueGroupBox.TabStop = false;
            this.revenueGroupBox.Text = "Revenue Generated";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(90, 233);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 42);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(188, 233);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 42);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(285, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 42);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 330);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.revenueGroupBox);
            this.Controls.Add(this.ticketsSoldGroupBox);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ticketsSoldGroupBox.ResumeLayout(false);
            this.ticketsSoldGroupBox.PerformLayout();
            this.revenueGroupBox.ResumeLayout(false);
            this.revenueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ticketsSoldLabel;
        private System.Windows.Forms.Label aDescriptionLabel;
        private System.Windows.Forms.Label bDescriptionLabel;
        private System.Windows.Forms.Label cDescriptionLabel;
        private System.Windows.Forms.TextBox userInputC;
        private System.Windows.Forms.TextBox userInputB;
        private System.Windows.Forms.TextBox userInputA;
        private System.Windows.Forms.Label aRevenueLabel;
        private System.Windows.Forms.Label bRevenueLabel;
        private System.Windows.Forms.Label cRevenueLabel;
        private System.Windows.Forms.Label totalDescriptionLabel;
        private System.Windows.Forms.Label aRevenueOutput;
        private System.Windows.Forms.Label bRevenueOutput;
        private System.Windows.Forms.Label cRevenueOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.GroupBox ticketsSoldGroupBox;
        private System.Windows.Forms.GroupBox revenueGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

