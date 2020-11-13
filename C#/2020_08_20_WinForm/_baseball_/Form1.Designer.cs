namespace _baseball_
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lbRand1 = new System.Windows.Forms.Label();
            this.lbRand2 = new System.Windows.Forms.Label();
            this.lbRand3 = new System.Windows.Forms.Label();
            this.tbinput1 = new System.Windows.Forms.TextBox();
            this.tbinput2 = new System.Windows.Forms.TextBox();
            this.tbinput3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbStrike = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbBoll = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbRand1
            // 
            this.lbRand1.AutoSize = true;
            this.lbRand1.Location = new System.Drawing.Point(147, 165);
            this.lbRand1.Name = "lbRand1";
            this.lbRand1.Size = new System.Drawing.Size(15, 15);
            this.lbRand1.TabIndex = 1;
            this.lbRand1.Text = "?";
            // 
            // lbRand2
            // 
            this.lbRand2.AutoSize = true;
            this.lbRand2.Location = new System.Drawing.Point(292, 165);
            this.lbRand2.Name = "lbRand2";
            this.lbRand2.Size = new System.Drawing.Size(15, 15);
            this.lbRand2.TabIndex = 1;
            this.lbRand2.Text = "?";
            // 
            // lbRand3
            // 
            this.lbRand3.AutoSize = true;
            this.lbRand3.Location = new System.Drawing.Point(430, 165);
            this.lbRand3.Name = "lbRand3";
            this.lbRand3.Size = new System.Drawing.Size(15, 15);
            this.lbRand3.TabIndex = 1;
            this.lbRand3.Text = "?";
            // 
            // tbinput1
            // 
            this.tbinput1.Location = new System.Drawing.Point(104, 208);
            this.tbinput1.Name = "tbinput1";
            this.tbinput1.Size = new System.Drawing.Size(100, 25);
            this.tbinput1.TabIndex = 2;
            // 
            // tbinput2
            // 
            this.tbinput2.Location = new System.Drawing.Point(249, 208);
            this.tbinput2.Name = "tbinput2";
            this.tbinput2.Size = new System.Drawing.Size(100, 25);
            this.tbinput2.TabIndex = 2;
            // 
            // tbinput3
            // 
            this.tbinput3.Location = new System.Drawing.Point(387, 208);
            this.tbinput3.Name = "tbinput3";
            this.tbinput3.Size = new System.Drawing.Size(100, 25);
            this.tbinput3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "입력";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "카운트";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "정답";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(181, 63);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(15, 15);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "0";
            this.lbCount.Click += new System.EventHandler(this.label4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "스트라이크";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbStrike
            // 
            this.lbStrike.AutoSize = true;
            this.lbStrike.Location = new System.Drawing.Point(181, 345);
            this.lbStrike.Name = "lbStrike";
            this.lbStrike.Size = new System.Drawing.Size(15, 15);
            this.lbStrike.TabIndex = 1;
            this.lbStrike.Text = "0";
            this.lbStrike.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "볼";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbBoll
            // 
            this.lbBoll.AutoSize = true;
            this.lbBoll.Location = new System.Drawing.Point(181, 384);
            this.lbBoll.Name = "lbBoll";
            this.lbBoll.Size = new System.Drawing.Size(15, 15);
            this.lbBoll.TabIndex = 1;
            this.lbBoll.Text = "0";
            this.lbBoll.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 96);
            this.button2.TabIndex = 0;
            this.button2.Text = "다시 시작 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 433);
            this.Controls.Add(this.tbinput3);
            this.Controls.Add(this.tbinput2);
            this.Controls.Add(this.tbinput1);
            this.Controls.Add(this.lbRand3);
            this.Controls.Add(this.lbRand2);
            this.Controls.Add(this.lbBoll);
            this.Controls.Add(this.lbStrike);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbRand1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "sss";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbRand1;
        private System.Windows.Forms.Label lbRand2;
        private System.Windows.Forms.Label lbRand3;
        private System.Windows.Forms.TextBox tbinput1;
        private System.Windows.Forms.TextBox tbinput2;
        private System.Windows.Forms.TextBox tbinput3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbStrike;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbBoll;
        private System.Windows.Forms.Button button2;
    }
}

