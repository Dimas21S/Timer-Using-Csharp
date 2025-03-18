namespace Timer
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
            labelHour = new Label();
            buttonStart = new Button();
            buttonStop = new Button();
            buttonReset = new Button();
            labelMinute = new Label();
            labelSeconds = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonHourMin = new Button();
            buttonHourMax = new Button();
            buttonMinuteMax = new Button();
            buttonMinuteMin = new Button();
            buttonSecondsMax = new Button();
            buttonSecondsMin = new Button();
            SuspendLayout();
            // 
            // labelHour
            // 
            labelHour.AutoSize = true;
            labelHour.Font = new Font("Bookman Old Style", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHour.Location = new Point(227, 134);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(82, 56);
            labelHour.TabIndex = 0;
            labelHour.Text = "00";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(227, 303);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(357, 303);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(94, 29);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(481, 303);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelMinute
            // 
            labelMinute.AutoSize = true;
            labelMinute.Font = new Font("Bookman Old Style", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMinute.Location = new Point(357, 134);
            labelMinute.Name = "labelMinute";
            labelMinute.Size = new Size(82, 56);
            labelMinute.TabIndex = 4;
            labelMinute.Text = "00";
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Bookman Old Style", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSeconds.Location = new Point(493, 134);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(82, 56);
            labelSeconds.TabIndex = 5;
            labelSeconds.Text = "00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // buttonHourMin
            // 
            buttonHourMin.Location = new Point(227, 193);
            buttonHourMin.Name = "buttonHourMin";
            buttonHourMin.Size = new Size(32, 28);
            buttonHourMin.TabIndex = 6;
            buttonHourMin.Text = "-";
            buttonHourMin.UseVisualStyleBackColor = true;
            buttonHourMin.Click += buttonMinimum_Click;
            // 
            // buttonHourMax
            // 
            buttonHourMax.Location = new Point(277, 193);
            buttonHourMax.Name = "buttonHourMax";
            buttonHourMax.Size = new Size(32, 28);
            buttonHourMax.TabIndex = 7;
            buttonHourMax.Text = "+";
            buttonHourMax.UseVisualStyleBackColor = true;
            buttonHourMax.Click += buttonHourMax_Click;
            // 
            // buttonMinuteMax
            // 
            buttonMinuteMax.Location = new Point(407, 193);
            buttonMinuteMax.Name = "buttonMinuteMax";
            buttonMinuteMax.Size = new Size(32, 28);
            buttonMinuteMax.TabIndex = 9;
            buttonMinuteMax.Text = "+";
            buttonMinuteMax.UseVisualStyleBackColor = true;
            buttonMinuteMax.Click += buttonMinuteMax_Click;
            // 
            // buttonMinuteMin
            // 
            buttonMinuteMin.Location = new Point(357, 193);
            buttonMinuteMin.Name = "buttonMinuteMin";
            buttonMinuteMin.Size = new Size(32, 28);
            buttonMinuteMin.TabIndex = 8;
            buttonMinuteMin.Text = "-";
            buttonMinuteMin.UseVisualStyleBackColor = true;
            buttonMinuteMin.Click += buttonMinuteMin_Click;
            // 
            // buttonSecondsMax
            // 
            buttonSecondsMax.Location = new Point(543, 193);
            buttonSecondsMax.Name = "buttonSecondsMax";
            buttonSecondsMax.Size = new Size(32, 28);
            buttonSecondsMax.TabIndex = 11;
            buttonSecondsMax.Text = "+";
            buttonSecondsMax.UseVisualStyleBackColor = true;
            buttonSecondsMax.Click += buttonSecondsMax_Click;
            // 
            // buttonSecondsMin
            // 
            buttonSecondsMin.Location = new Point(493, 193);
            buttonSecondsMin.Name = "buttonSecondsMin";
            buttonSecondsMin.Size = new Size(32, 28);
            buttonSecondsMin.TabIndex = 10;
            buttonSecondsMin.Text = "-";
            buttonSecondsMin.UseVisualStyleBackColor = true;
            buttonSecondsMin.Click += buttonSecondsMin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSecondsMax);
            Controls.Add(buttonSecondsMin);
            Controls.Add(buttonMinuteMax);
            Controls.Add(buttonMinuteMin);
            Controls.Add(buttonHourMax);
            Controls.Add(buttonHourMin);
            Controls.Add(labelSeconds);
            Controls.Add(labelMinute);
            Controls.Add(buttonReset);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Controls.Add(labelHour);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHour;
        private Button buttonStart;
        private Button buttonStop;
        private Button buttonReset;
        private Label labelMinute;
        private Label labelSeconds;
        private System.Windows.Forms.Timer timer1;
        private Button buttonHourMin;
        private Button buttonHourMax;
        private Button buttonMinuteMax;
        private Button buttonMinuteMin;
        private Button buttonSecondsMax;
        private Button buttonSecondsMin;
    }
}
