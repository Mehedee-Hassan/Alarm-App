namespace Alarm_App
{
    partial class AlarmForm
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
            this.components = new System.ComponentModel.Container();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.setTimeLabel = new System.Windows.Forms.Label();
            this.setHourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.setTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.amPmComboBox = new System.Windows.Forms.ComboBox();
            this.secondTitleLabel = new System.Windows.Forms.Label();
            this.minuteTitleLabel = new System.Windows.Forms.Label();
            this.hourTitleLabel = new System.Windows.Forms.Label();
            this.secondNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.setAlarmButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.setAlarmToZerCheckBox = new System.Windows.Forms.CheckBox();
            this.stopAlarmButton = new System.Windows.Forms.Button();
            this.lockAlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.addMessageButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.setHourNumericUpDown)).BeginInit();
            this.setTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alarmTimer
            // 
            this.alarmTimer.Interval = 1000;
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // setTimeLabel
            // 
            this.setTimeLabel.AutoSize = true;
            this.setTimeLabel.Font = new System.Drawing.Font("OCR A Std", 10F);
            this.setTimeLabel.Location = new System.Drawing.Point(6, 25);
            this.setTimeLabel.Name = "setTimeLabel";
            this.setTimeLabel.Size = new System.Drawing.Size(107, 15);
            this.setTimeLabel.TabIndex = 1;
            this.setTimeLabel.Text = "Set Time :";
            // 
            // setHourNumericUpDown
            // 
            this.setHourNumericUpDown.Font = new System.Drawing.Font("OCR A Std", 9F);
            this.setHourNumericUpDown.Location = new System.Drawing.Point(119, 19);
            this.setHourNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.setHourNumericUpDown.Name = "setHourNumericUpDown";
            this.setHourNumericUpDown.Size = new System.Drawing.Size(51, 22);
            this.setHourNumericUpDown.TabIndex = 1;
            this.setHourNumericUpDown.Tag = "Hours";
            // 
            // setTimeGroupBox
            // 
            this.setTimeGroupBox.Controls.Add(this.amPmComboBox);
            this.setTimeGroupBox.Controls.Add(this.secondTitleLabel);
            this.setTimeGroupBox.Controls.Add(this.minuteTitleLabel);
            this.setTimeGroupBox.Controls.Add(this.hourTitleLabel);
            this.setTimeGroupBox.Controls.Add(this.secondNumericUpDown);
            this.setTimeGroupBox.Controls.Add(this.minuteNumericUpDown);
            this.setTimeGroupBox.Controls.Add(this.setTimeLabel);
            this.setTimeGroupBox.Controls.Add(this.setHourNumericUpDown);
            this.setTimeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.setTimeGroupBox.Name = "setTimeGroupBox";
            this.setTimeGroupBox.Size = new System.Drawing.Size(378, 75);
            this.setTimeGroupBox.TabIndex = 4;
            this.setTimeGroupBox.TabStop = false;
            this.setTimeGroupBox.Text = "Set Time";
            // 
            // amPmComboBox
            // 
            this.amPmComboBox.Font = new System.Drawing.Font("OCR A Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amPmComboBox.FormattingEnabled = true;
            this.amPmComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.amPmComboBox.Location = new System.Drawing.Point(323, 18);
            this.amPmComboBox.Name = "amPmComboBox";
            this.amPmComboBox.Size = new System.Drawing.Size(49, 22);
            this.amPmComboBox.TabIndex = 8;
            this.amPmComboBox.Text = "AM";
            // 
            // secondTitleLabel
            // 
            this.secondTitleLabel.AutoSize = true;
            this.secondTitleLabel.Location = new System.Drawing.Point(268, 43);
            this.secondTitleLabel.Name = "secondTitleLabel";
            this.secondTitleLabel.Size = new System.Drawing.Size(21, 13);
            this.secondTitleLabel.TabIndex = 7;
            this.secondTitleLabel.Text = "SS";
            // 
            // minuteTitleLabel
            // 
            this.minuteTitleLabel.AutoSize = true;
            this.minuteTitleLabel.Location = new System.Drawing.Point(201, 44);
            this.minuteTitleLabel.Name = "minuteTitleLabel";
            this.minuteTitleLabel.Size = new System.Drawing.Size(25, 13);
            this.minuteTitleLabel.TabIndex = 6;
            this.minuteTitleLabel.Text = "MM";
            // 
            // hourTitleLabel
            // 
            this.hourTitleLabel.AutoSize = true;
            this.hourTitleLabel.Location = new System.Drawing.Point(133, 44);
            this.hourTitleLabel.Name = "hourTitleLabel";
            this.hourTitleLabel.Size = new System.Drawing.Size(23, 13);
            this.hourTitleLabel.TabIndex = 5;
            this.hourTitleLabel.Text = "HH";
            // 
            // secondNumericUpDown
            // 
            this.secondNumericUpDown.Font = new System.Drawing.Font("OCR A Std", 9F);
            this.secondNumericUpDown.Location = new System.Drawing.Point(257, 18);
            this.secondNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondNumericUpDown.Name = "secondNumericUpDown";
            this.secondNumericUpDown.Size = new System.Drawing.Size(51, 22);
            this.secondNumericUpDown.TabIndex = 3;
            this.secondNumericUpDown.Tag = "Hours";
            // 
            // minuteNumericUpDown
            // 
            this.minuteNumericUpDown.Font = new System.Drawing.Font("OCR A Std", 9F);
            this.minuteNumericUpDown.Location = new System.Drawing.Point(189, 19);
            this.minuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumericUpDown.Name = "minuteNumericUpDown";
            this.minuteNumericUpDown.Size = new System.Drawing.Size(51, 22);
            this.minuteNumericUpDown.TabIndex = 2;
            this.minuteNumericUpDown.Tag = "";
            // 
            // hourToolTip
            // 
            this.hourToolTip.ToolTipTitle = "Hour";
            // 
            // setAlarmButton
            // 
            this.setAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAlarmButton.Location = new System.Drawing.Point(12, 93);
            this.setAlarmButton.Name = "setAlarmButton";
            this.setAlarmButton.Size = new System.Drawing.Size(378, 28);
            this.setAlarmButton.TabIndex = 5;
            this.setAlarmButton.Text = "Set Alarm";
            this.setAlarmButton.UseVisualStyleBackColor = true;
            this.setAlarmButton.Click += new System.EventHandler(this.setAlarmButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(9, 42);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(161, 32);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // setAlarmToZerCheckBox
            // 
            this.setAlarmToZerCheckBox.AutoSize = true;
            this.setAlarmToZerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAlarmToZerCheckBox.Location = new System.Drawing.Point(31, 16);
            this.setAlarmToZerCheckBox.Name = "setAlarmToZerCheckBox";
            this.setAlarmToZerCheckBox.Size = new System.Drawing.Size(114, 20);
            this.setAlarmToZerCheckBox.TabIndex = 7;
            this.setAlarmToZerCheckBox.Text = "Reset To Zero";
            this.setAlarmToZerCheckBox.UseVisualStyleBackColor = true;
            this.setAlarmToZerCheckBox.CheckedChanged += new System.EventHandler(this.setAlarmToZerCheckBox_CheckedChanged);
            // 
            // stopAlarmButton
            // 
            this.stopAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopAlarmButton.Location = new System.Drawing.Point(204, 42);
            this.stopAlarmButton.Name = "stopAlarmButton";
            this.stopAlarmButton.Size = new System.Drawing.Size(162, 32);
            this.stopAlarmButton.TabIndex = 8;
            this.stopAlarmButton.Text = "Stop Alarm";
            this.stopAlarmButton.UseVisualStyleBackColor = true;
            this.stopAlarmButton.Click += new System.EventHandler(this.stopAlarmButton_Click);
            // 
            // lockAlarmCheckBox
            // 
            this.lockAlarmCheckBox.AutoSize = true;
            this.lockAlarmCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockAlarmCheckBox.Location = new System.Drawing.Point(239, 16);
            this.lockAlarmCheckBox.Name = "lockAlarmCheckBox";
            this.lockAlarmCheckBox.Size = new System.Drawing.Size(94, 20);
            this.lockAlarmCheckBox.TabIndex = 9;
            this.lockAlarmCheckBox.Text = "Lock Alarm";
            this.lockAlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // addMessageButton
            // 
            this.addMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMessageButton.Location = new System.Drawing.Point(12, 127);
            this.addMessageButton.Name = "addMessageButton";
            this.addMessageButton.Size = new System.Drawing.Size(378, 30);
            this.addMessageButton.TabIndex = 10;
            this.addMessageButton.Text = "Add Message";
            this.addMessageButton.UseVisualStyleBackColor = true;
            this.addMessageButton.Click += new System.EventHandler(this.addMessageButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.setAlarmToZerCheckBox);
            this.groupBox1.Controls.Add(this.lockAlarmCheckBox);
            this.groupBox1.Controls.Add(this.stopAlarmButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(401, 287);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addMessageButton);
            this.Controls.Add(this.setAlarmButton);
            this.Controls.Add(this.setTimeGroupBox);
            this.Name = "AlarmForm";
            this.Text = "Alarm ";
            this.Load += new System.EventHandler(this.AlarmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.setHourNumericUpDown)).EndInit();
            this.setTimeGroupBox.ResumeLayout(false);
            this.setTimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer alarmTimer;
        private System.Windows.Forms.Label setTimeLabel;
        private System.Windows.Forms.NumericUpDown setHourNumericUpDown;
        private System.Windows.Forms.GroupBox setTimeGroupBox;
        private System.Windows.Forms.ToolTip hourToolTip;
        private System.Windows.Forms.NumericUpDown secondNumericUpDown;
        private System.Windows.Forms.NumericUpDown minuteNumericUpDown;
        private System.Windows.Forms.Label secondTitleLabel;
        private System.Windows.Forms.Label minuteTitleLabel;
        private System.Windows.Forms.Label hourTitleLabel;
        private System.Windows.Forms.Button setAlarmButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox setAlarmToZerCheckBox;
        private System.Windows.Forms.ComboBox amPmComboBox;
        private System.Windows.Forms.Button stopAlarmButton;
        private System.Windows.Forms.CheckBox lockAlarmCheckBox;
        private System.Windows.Forms.Button addMessageButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

