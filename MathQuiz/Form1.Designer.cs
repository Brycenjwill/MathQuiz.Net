namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            plusSymbol = new Label();
            plusRightLabel = new Label();
            label2 = new Label();
            sum = new NumericUpDown();
            minusLeftLabel = new Label();
            minusRightLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            product = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            timesLeftLabel = new Label();
            dividedRightLabel = new Label();
            timesRightLabel = new Label();
            label8 = new Label();
            label7 = new Label();
            dividedLeftLabel = new Label();
            difference = new NumericUpDown();
            quotient = new NumericUpDown();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            curDate = new Label();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(272, 17);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(167, 18);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F);
            plusLeftLabel.Location = new Point(50, 53);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            plusLeftLabel.UseMnemonic = false;
            // 
            // plusSymbol
            // 
            plusSymbol.Font = new Font("Segoe UI", 18F);
            plusSymbol.Location = new Point(132, 53);
            plusSymbol.Name = "plusSymbol";
            plusSymbol.Size = new Size(60, 50);
            plusSymbol.TabIndex = 3;
            plusSymbol.Text = "+";
            plusSymbol.TextAlign = ContentAlignment.MiddleCenter;
            plusSymbol.UseMnemonic = false;
            plusSymbol.Click += label2_Click;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(206, 53);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 4;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            plusRightLabel.UseMnemonic = false;
            plusRightLabel.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(272, 53);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 5;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(338, 64);
            sum.Name = "sum";
            sum.Size = new Size(100, 39);
            sum.TabIndex = 1;
            sum.Enter += answer_Enter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F);
            minusLeftLabel.Location = new Point(50, 126);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            minusLeftLabel.UseMnemonic = false;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F);
            minusRightLabel.Location = new Point(206, 126);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 8;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            minusRightLabel.UseMnemonic = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(132, 126);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 9;
            label3.Text = "-";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(272, 126);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 10;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseMnemonic = false;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F);
            product.Location = new Point(338, 202);
            product.Name = "product";
            product.Size = new Size(100, 39);
            product.TabIndex = 3;
            product.Enter += answer_Enter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(272, 256);
            label5.Name = "label5";
            label5.Size = new Size(60, 50);
            label5.TabIndex = 12;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseMnemonic = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(272, 191);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 13;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.UseMnemonic = false;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F);
            timesLeftLabel.Location = new Point(50, 191);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 14;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            timesLeftLabel.UseMnemonic = false;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F);
            dividedRightLabel.Location = new Point(212, 256);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 15;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            dividedRightLabel.UseMnemonic = false;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F);
            timesRightLabel.Location = new Point(212, 191);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 16;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            timesRightLabel.UseMnemonic = false;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(132, 191);
            label8.Name = "label8";
            label8.Size = new Size(60, 50);
            label8.TabIndex = 17;
            label8.Text = "x";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.UseMnemonic = false;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(146, 256);
            label7.Name = "label7";
            label7.Size = new Size(60, 50);
            label7.TabIndex = 18;
            label7.Text = "÷";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.UseMnemonic = false;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F);
            dividedLeftLabel.Location = new Point(50, 256);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 19;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            dividedLeftLabel.UseMnemonic = false;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F);
            difference.Location = new Point(338, 133);
            difference.Name = "difference";
            difference.Size = new Size(100, 39);
            difference.TabIndex = 2;
            difference.ValueChanged += numericUpDown1_ValueChanged;
            difference.Enter += answer_Enter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F);
            quotient.Location = new Point(338, 263);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 39);
            quotient.TabIndex = 4;
            quotient.Enter += answer_Enter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(12, 18);
            startButton.Name = "startButton";
            startButton.Size = new Size(137, 35);
            startButton.TabIndex = 0;
            startButton.Text = "Start the quiz.";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // curDate
            // 
            curDate.AutoSize = true;
            curDate.Font = new Font("Segoe UI", 15.75F);
            curDate.Location = new Point(12, 322);
            curDate.Name = "curDate";
            curDate.Size = new Size(62, 30);
            curDate.TabIndex = 20;
            curDate.Text = "Date:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(curDate);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(difference);
            Controls.Add(dividedLeftLabel);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(timesRightLabel);
            Controls.Add(dividedRightLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(product);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(minusRightLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(label2);
            Controls.Add(plusRightLabel);
            Controls.Add(plusSymbol);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Brycen Williams Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label plusSymbol;
        private Label plusRightLabel;
        private Label label2;
        private NumericUpDown sum;
        private Label minusLeftLabel;
        private Label minusRightLabel;
        private Label label3;
        private Label label4;
        private NumericUpDown product;
        private Label label5;
        private Label label6;
        private Label timesLeftLabel;
        private Label dividedRightLabel;
        private Label timesRightLabel;
        private Label label8;
        private Label label7;
        private Label dividedLeftLabel;
        private NumericUpDown difference;
        private NumericUpDown quotient;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private Label curDate;
    }
}
