namespace WeatherUI
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
            btn_close = new Button();
            TbCity = new TextBox();
            label1 = new Label();
            btn_search = new Button();
            picIcon = new PictureBox();
            labCondition = new Label();
            labDetail = new Label();
            labSunrise = new Label();
            labSunset = new Label();
            labWind = new Label();
            labPressure = new Label();
            labSunriseOut = new Label();
            labSunsetOut = new Label();
            labWindSpeed = new Label();
            labPressureSpeed = new Label();
            label2 = new Label();
            labTemp = new Label();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Transparent;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(1144, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(52, 49);
            btn_close.TabIndex = 0;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // TbCity
            // 
            TbCity.BackColor = Color.FromArgb(64, 64, 64);
            TbCity.Font = new Font("MS Gothic", 14F, FontStyle.Bold);
            TbCity.ForeColor = Color.White;
            TbCity.Location = new Point(426, 120);
            TbCity.Name = "TbCity";
            TbCity.Size = new Size(423, 35);
            TbCity.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(325, 120);
            label1.Name = "label1";
            label1.Size = new Size(77, 34);
            label1.TabIndex = 2;
            label1.Text = "City:";
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Transparent;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("MS Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(865, 108);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(152, 55);
            btn_search.TabIndex = 3;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.Transparent;
            picIcon.BackgroundImageLayout = ImageLayout.None;
            picIcon.BorderStyle = BorderStyle.FixedSingle;
            picIcon.Location = new Point(661, 247);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(143, 112);
            picIcon.TabIndex = 4;
            picIcon.TabStop = false;
            // 
            // labCondition
            // 
            labCondition.AutoSize = true;
            labCondition.BackColor = Color.Transparent;
            labCondition.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCondition.ForeColor = Color.White;
            labCondition.Location = new Point(661, 191);
            labCondition.Name = "labCondition";
            labCondition.Size = new Size(158, 34);
            labCondition.TabIndex = 5;
            labCondition.Text = "Condition:";
            // 
            // labDetail
            // 
            labDetail.AutoSize = true;
            labDetail.BackColor = Color.Transparent;
            labDetail.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDetail.ForeColor = Color.White;
            labDetail.Location = new Point(661, 376);
            labDetail.Name = "labDetail";
            labDetail.Size = new Size(103, 34);
            labDetail.TabIndex = 6;
            labDetail.Text = "Detail:";
            // 
            // labSunrise
            // 
            labSunrise.AutoSize = true;
            labSunrise.BackColor = Color.Transparent;
            labSunrise.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labSunrise.ForeColor = Color.White;
            labSunrise.Location = new Point(251, 430);
            labSunrise.Name = "labSunrise";
            labSunrise.Size = new Size(114, 34);
            labSunrise.TabIndex = 7;
            labSunrise.Text = "Sunrise:";
            // 
            // labSunset
            // 
            labSunset.AutoSize = true;
            labSunset.BackColor = Color.Transparent;
            labSunset.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labSunset.ForeColor = Color.White;
            labSunset.Location = new Point(251, 509);
            labSunset.Name = "labSunset";
            labSunset.Size = new Size(109, 34);
            labSunset.TabIndex = 8;
            labSunset.Text = "Sunset:";
            // 
            // labWind
            // 
            labWind.AutoSize = true;
            labWind.BackColor = Color.Transparent;
            labWind.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labWind.ForeColor = Color.White;
            labWind.Location = new Point(251, 268);
            labWind.Name = "labWind";
            labWind.Size = new Size(180, 34);
            labWind.TabIndex = 9;
            labWind.Text = "WindSpeed:";
            // 
            // labPressure
            // 
            labPressure.AutoSize = true;
            labPressure.BackColor = Color.Transparent;
            labPressure.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labPressure.ForeColor = Color.White;
            labPressure.Location = new Point(251, 357);
            labPressure.Name = "labPressure";
            labPressure.Size = new Size(130, 34);
            labPressure.TabIndex = 10;
            labPressure.Text = "Pressure:";
            // 
            // labSunriseOut
            // 
            labSunriseOut.AutoSize = true;
            labSunriseOut.BackColor = Color.Transparent;
            labSunriseOut.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labSunriseOut.ForeColor = Color.White;
            labSunriseOut.Location = new Point(371, 430);
            labSunriseOut.Name = "labSunriseOut";
            labSunriseOut.Size = new Size(69, 34);
            labSunriseOut.TabIndex = 11;
            labSunriseOut.Text = "N/A";
            // 
            // labSunsetOut
            // 
            labSunsetOut.AutoSize = true;
            labSunsetOut.BackColor = Color.Transparent;
            labSunsetOut.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labSunsetOut.ForeColor = Color.White;
            labSunsetOut.Location = new Point(371, 509);
            labSunsetOut.Name = "labSunsetOut";
            labSunsetOut.Size = new Size(69, 34);
            labSunsetOut.TabIndex = 12;
            labSunsetOut.Text = "N/A";
            // 
            // labWindSpeed
            // 
            labWindSpeed.AutoSize = true;
            labWindSpeed.BackColor = Color.Transparent;
            labWindSpeed.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labWindSpeed.ForeColor = Color.White;
            labWindSpeed.Location = new Point(430, 268);
            labWindSpeed.Name = "labWindSpeed";
            labWindSpeed.Size = new Size(69, 34);
            labWindSpeed.TabIndex = 13;
            labWindSpeed.Text = "N/A";
            // 
            // labPressureSpeed
            // 
            labPressureSpeed.AutoSize = true;
            labPressureSpeed.BackColor = Color.Transparent;
            labPressureSpeed.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labPressureSpeed.ForeColor = Color.White;
            labPressureSpeed.Location = new Point(430, 357);
            labPressureSpeed.Name = "labPressureSpeed";
            labPressureSpeed.Size = new Size(69, 34);
            labPressureSpeed.TabIndex = 14;
            labPressureSpeed.Text = "N/A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(251, 191);
            label2.Name = "label2";
            label2.Size = new Size(194, 34);
            label2.TabIndex = 15;
            label2.Text = "Temperature:";
            label2.Click += label2_Click;
            // 
            // labTemp
            // 
            labTemp.AutoSize = true;
            labTemp.BackColor = Color.Transparent;
            labTemp.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labTemp.ForeColor = Color.White;
            labTemp.Location = new Point(441, 191);
            labTemp.Name = "labTemp";
            labTemp.Size = new Size(69, 34);
            labTemp.TabIndex = 16;
            labTemp.Text = "N/A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1197, 794);
            Controls.Add(labTemp);
            Controls.Add(label2);
            Controls.Add(labPressureSpeed);
            Controls.Add(labWindSpeed);
            Controls.Add(labSunsetOut);
            Controls.Add(labSunriseOut);
            Controls.Add(labPressure);
            Controls.Add(labWind);
            Controls.Add(labSunset);
            Controls.Add(labSunrise);
            Controls.Add(labDetail);
            Controls.Add(labCondition);
            Controls.Add(picIcon);
            Controls.Add(btn_search);
            Controls.Add(label1);
            Controls.Add(TbCity);
            Controls.Add(btn_close);
            DoubleBuffered = true;
            ForeColor = Color.Snow;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_close;
        private TextBox TbCity;
        private Label label1;
        private Button btn_search;
        private PictureBox picIcon;
        private Label labCondition;
        private Label labDetail;
        private Label labSunrise;
        private Label labSunset;
        private Label labWind;
        private Label labPressure;
        private Label labSunriseOut;
        private Label labSunsetOut;
        private Label labWindSpeed;
        private Label labPressureSpeed;
        private Label label2;
        private Label labTemp;
    }
}
