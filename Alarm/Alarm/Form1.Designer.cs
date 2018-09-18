namespace Alarm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txbH = new System.Windows.Forms.TextBox();
            this.txbM = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.lbl_sun = new System.Windows.Forms.Label();
            this.lbl_mon = new System.Windows.Forms.Label();
            this.lbl_tue = new System.Windows.Forms.Label();
            this.lbl_wed = new System.Windows.Forms.Label();
            this.lbl_fri = new System.Windows.Forms.Label();
            this.lbl_thu = new System.Windows.Forms.Label();
            this.lbl_sat = new System.Windows.Forms.Label();
            this.lblSetSat = new System.Windows.Forms.Label();
            this.lblSetThu = new System.Windows.Forms.Label();
            this.lblSetFri = new System.Windows.Forms.Label();
            this.lblSetWed = new System.Windows.Forms.Label();
            this.lblSetTue = new System.Windows.Forms.Label();
            this.lblSetMon = new System.Windows.Forms.Label();
            this.lblSetSun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(46, 158);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(154, 158);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Location = new System.Drawing.Point(378, 30);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(35, 13);
            this.lblTimeNow.TabIndex = 4;
            this.lblTimeNow.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txbH
            // 
            this.txbH.Location = new System.Drawing.Point(486, 158);
            this.txbH.Name = "txbH";
            this.txbH.Size = new System.Drawing.Size(100, 20);
            this.txbH.TabIndex = 5;
            // 
            // txbM
            // 
            this.txbM.Location = new System.Drawing.Point(592, 158);
            this.txbM.Name = "txbM";
            this.txbM.Size = new System.Drawing.Size(100, 20);
            this.txbM.TabIndex = 6;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(535, 199);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lbl_sun
            // 
            this.lbl_sun.AutoSize = true;
            this.lbl_sun.Location = new System.Drawing.Point(475, 74);
            this.lbl_sun.Name = "lbl_sun";
            this.lbl_sun.Size = new System.Drawing.Size(24, 13);
            this.lbl_sun.TabIndex = 8;
            this.lbl_sun.Text = "sun";
            // 
            // lbl_mon
            // 
            this.lbl_mon.AutoSize = true;
            this.lbl_mon.Location = new System.Drawing.Point(304, 74);
            this.lbl_mon.Name = "lbl_mon";
            this.lbl_mon.Size = new System.Drawing.Size(27, 13);
            this.lbl_mon.TabIndex = 9;
            this.lbl_mon.Text = "mon";
            // 
            // lbl_tue
            // 
            this.lbl_tue.AutoSize = true;
            this.lbl_tue.Location = new System.Drawing.Point(337, 74);
            this.lbl_tue.Name = "lbl_tue";
            this.lbl_tue.Size = new System.Drawing.Size(22, 13);
            this.lbl_tue.TabIndex = 10;
            this.lbl_tue.Text = "tue";
            // 
            // lbl_wed
            // 
            this.lbl_wed.AutoSize = true;
            this.lbl_wed.Location = new System.Drawing.Point(365, 74);
            this.lbl_wed.Name = "lbl_wed";
            this.lbl_wed.Size = new System.Drawing.Size(27, 13);
            this.lbl_wed.TabIndex = 11;
            this.lbl_wed.Text = "wed";
            // 
            // lbl_fri
            // 
            this.lbl_fri.AutoSize = true;
            this.lbl_fri.Location = new System.Drawing.Point(427, 74);
            this.lbl_fri.Name = "lbl_fri";
            this.lbl_fri.Size = new System.Drawing.Size(15, 13);
            this.lbl_fri.TabIndex = 12;
            this.lbl_fri.Text = "fri";
            // 
            // lbl_thu
            // 
            this.lbl_thu.AutoSize = true;
            this.lbl_thu.Location = new System.Drawing.Point(399, 74);
            this.lbl_thu.Name = "lbl_thu";
            this.lbl_thu.Size = new System.Drawing.Size(22, 13);
            this.lbl_thu.TabIndex = 13;
            this.lbl_thu.Text = "thu";
            // 
            // lbl_sat
            // 
            this.lbl_sat.AutoSize = true;
            this.lbl_sat.Location = new System.Drawing.Point(448, 74);
            this.lbl_sat.Name = "lbl_sat";
            this.lbl_sat.Size = new System.Drawing.Size(21, 13);
            this.lbl_sat.TabIndex = 14;
            this.lbl_sat.Text = "sat";

            // 
            // lblSetSat
            // 
            this.lblSetSat.AutoSize = true;
            this.lblSetSat.Location = new System.Drawing.Point(637, 128);
            this.lblSetSat.Name = "lblSetSat";
            this.lblSetSat.Size = new System.Drawing.Size(21, 13);
            this.lblSetSat.TabIndex = 21;
            this.lblSetSat.Text = "sat";
            this.lblSetSat.Click += new System.EventHandler(this.lblSetSat_Click);
            // 
            // lblSetThu
            // 
            this.lblSetThu.AutoSize = true;
            this.lblSetThu.Location = new System.Drawing.Point(588, 128);
            this.lblSetThu.Name = "lblSetThu";
            this.lblSetThu.Size = new System.Drawing.Size(22, 13);
            this.lblSetThu.TabIndex = 20;
            this.lblSetThu.Text = "thu";
            this.lblSetThu.Click += new System.EventHandler(this.lblSetThu_Click);
            // 
            // lblSetFri
            // 
            this.lblSetFri.AutoSize = true;
            this.lblSetFri.Location = new System.Drawing.Point(616, 128);
            this.lblSetFri.Name = "lblSetFri";
            this.lblSetFri.Size = new System.Drawing.Size(15, 13);
            this.lblSetFri.TabIndex = 19;
            this.lblSetFri.Text = "fri";
            this.lblSetFri.Click += new System.EventHandler(this.lblSetFri_Click);
            // 
            // lblSetWed
            // 
            this.lblSetWed.AutoSize = true;
            this.lblSetWed.Location = new System.Drawing.Point(554, 128);
            this.lblSetWed.Name = "lblSetWed";
            this.lblSetWed.Size = new System.Drawing.Size(27, 13);
            this.lblSetWed.TabIndex = 18;
            this.lblSetWed.Text = "wed";
            this.lblSetWed.Click += new System.EventHandler(this.lblSetWed_Click);
            // 
            // lblSetTue
            // 
            this.lblSetTue.AutoSize = true;
            this.lblSetTue.Location = new System.Drawing.Point(526, 128);
            this.lblSetTue.Name = "lblSetTue";
            this.lblSetTue.Size = new System.Drawing.Size(22, 13);
            this.lblSetTue.TabIndex = 17;
            this.lblSetTue.Text = "tue";
            this.lblSetTue.Click += new System.EventHandler(this.lblSetTue_Click);
            // 
            // lblSetMon
            // 
            this.lblSetMon.AutoSize = true;
            this.lblSetMon.Location = new System.Drawing.Point(493, 128);
            this.lblSetMon.Name = "lblSetMon";
            this.lblSetMon.Size = new System.Drawing.Size(27, 13);
            this.lblSetMon.TabIndex = 16;
            this.lblSetMon.Text = "mon";
            this.lblSetMon.Click += new System.EventHandler(this.lblSetMon_Click);
            // 
            // lblSetSun
            // 
            this.lblSetSun.AutoSize = true;
            this.lblSetSun.Location = new System.Drawing.Point(664, 128);
            this.lblSetSun.Name = "lblSetSun";
            this.lblSetSun.Size = new System.Drawing.Size(24, 13);
            this.lblSetSun.TabIndex = 15;
            this.lblSetSun.Text = "sun";
            this.lblSetSun.Click += new System.EventHandler(this.lblSetSun_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSetSat);
            this.Controls.Add(this.lblSetThu);
            this.Controls.Add(this.lblSetFri);
            this.Controls.Add(this.lblSetWed);
            this.Controls.Add(this.lblSetTue);
            this.Controls.Add(this.lblSetMon);
            this.Controls.Add(this.lblSetSun);
            this.Controls.Add(this.lbl_sat);
            this.Controls.Add(this.lbl_thu);
            this.Controls.Add(this.lbl_fri);
            this.Controls.Add(this.lbl_wed);
            this.Controls.Add(this.lbl_tue);
            this.Controls.Add(this.lbl_mon);
            this.Controls.Add(this.lbl_sun);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txbM);
            this.Controls.Add(this.txbH);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txbH;
        private System.Windows.Forms.TextBox txbM;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lbl_sun;
        private System.Windows.Forms.Label lbl_mon;
        private System.Windows.Forms.Label lbl_tue;
        private System.Windows.Forms.Label lbl_wed;
        private System.Windows.Forms.Label lbl_fri;
        private System.Windows.Forms.Label lbl_thu;
        private System.Windows.Forms.Label lbl_sat;
        private System.Windows.Forms.Label lblSetSat;
        private System.Windows.Forms.Label lblSetThu;
        private System.Windows.Forms.Label lblSetFri;
        private System.Windows.Forms.Label lblSetWed;
        private System.Windows.Forms.Label lblSetTue;
        private System.Windows.Forms.Label lblSetMon;
        private System.Windows.Forms.Label lblSetSun;
    }
}

