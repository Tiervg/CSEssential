namespace App3
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
            this.components = new System.ComponentModel.Container();
            this.hourDec = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.minDec = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.secDec = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourDec
            // 
            this.hourDec.AutoSize = true;
            this.hourDec.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourDec.Location = new System.Drawing.Point(12, 28);
            this.hourDec.Name = "hourDec";
            this.hourDec.Size = new System.Drawing.Size(67, 75);
            this.hourDec.TabIndex = 0;
            this.hourDec.Text = "0";
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hour.Location = new System.Drawing.Point(59, 28);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(67, 75);
            this.hour.TabIndex = 1;
            this.hour.Text = "0";
            // 
            // minDec
            // 
            this.minDec.AutoSize = true;
            this.minDec.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minDec.Location = new System.Drawing.Point(143, 28);
            this.minDec.Name = "minDec";
            this.minDec.Size = new System.Drawing.Size(67, 75);
            this.minDec.TabIndex = 2;
            this.minDec.Text = "0";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min.Location = new System.Drawing.Point(195, 28);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(67, 75);
            this.min.TabIndex = 3;
            this.min.Text = "0";
            // 
            // secDec
            // 
            this.secDec.AutoSize = true;
            this.secDec.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secDec.Location = new System.Drawing.Point(279, 28);
            this.secDec.Name = "secDec";
            this.secDec.Size = new System.Drawing.Size(67, 75);
            this.secDec.TabIndex = 4;
            this.secDec.Text = "0";
            this.secDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sec.Location = new System.Drawing.Point(334, 28);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(67, 75);
            this.sec.TabIndex = 5;
            this.sec.Text = "0";
            this.sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(407, 28);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 6;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(407, 58);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 7;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(407, 94);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 8;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 75);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 75);
            this.label2.TabIndex = 10;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 129);
            this.Controls.Add(this.secDec);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.min);
            this.Controls.Add(this.minDec);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.hourDec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label hourDec;
        public System.Windows.Forms.Label hour;
        public System.Windows.Forms.Label minDec;
        public System.Windows.Forms.Label min;
        public System.Windows.Forms.Label secDec;
        public System.Windows.Forms.Label sec;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        public System.Windows.Forms.Button button_Reset;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

