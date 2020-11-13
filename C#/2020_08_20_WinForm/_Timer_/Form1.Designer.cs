namespace _Timer_
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DispM = new System.Windows.Forms.Label();
            this.DispS = new System.Windows.Forms.Label();
            this.DispMS = new System.Windows.Forms.Label();
            this.UnitM = new System.Windows.Forms.Label();
            this.UnitS = new System.Windows.Forms.Label();
            this.UnitMS = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DispM
            // 
            this.DispM.AutoSize = true;
            this.DispM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DispM.Location = new System.Drawing.Point(140, 67);
            this.DispM.Name = "DispM";
            this.DispM.Size = new System.Drawing.Size(16, 15);
            this.DispM.TabIndex = 0;
            this.DispM.Text = "0";
            // 
            // DispS
            // 
            this.DispS.AutoSize = true;
            this.DispS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DispS.Location = new System.Drawing.Point(140, 109);
            this.DispS.Name = "DispS";
            this.DispS.Size = new System.Drawing.Size(16, 15);
            this.DispS.TabIndex = 0;
            this.DispS.Text = "0";
            // 
            // DispMS
            // 
            this.DispMS.AutoSize = true;
            this.DispMS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DispMS.Location = new System.Drawing.Point(140, 158);
            this.DispMS.Name = "DispMS";
            this.DispMS.Size = new System.Drawing.Size(16, 15);
            this.DispMS.TabIndex = 0;
            this.DispMS.Text = "0";
            // 
            // UnitM
            // 
            this.UnitM.AutoSize = true;
            this.UnitM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UnitM.Location = new System.Drawing.Point(219, 67);
            this.UnitM.Name = "UnitM";
            this.UnitM.Size = new System.Drawing.Size(23, 15);
            this.UnitM.TabIndex = 0;
            this.UnitM.Text = "분";
            // 
            // UnitS
            // 
            this.UnitS.AutoSize = true;
            this.UnitS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UnitS.Location = new System.Drawing.Point(219, 109);
            this.UnitS.Name = "UnitS";
            this.UnitS.Size = new System.Drawing.Size(23, 15);
            this.UnitS.TabIndex = 0;
            this.UnitS.Text = "초";
            // 
            // UnitMS
            // 
            this.UnitMS.AutoSize = true;
            this.UnitMS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UnitMS.Location = new System.Drawing.Point(219, 158);
            this.UnitMS.Name = "UnitMS";
            this.UnitMS.Size = new System.Drawing.Size(55, 15);
            this.UnitMS.TabIndex = 0;
            this.UnitMS.Text = "밀리초";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "시작 / 정지";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "리셋";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 329);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UnitMS);
            this.Controls.Add(this.UnitS);
            this.Controls.Add(this.UnitM);
            this.Controls.Add(this.DispMS);
            this.Controls.Add(this.DispS);
            this.Controls.Add(this.DispM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DispM;
        private System.Windows.Forms.Label DispS;
        private System.Windows.Forms.Label DispMS;
        private System.Windows.Forms.Label UnitM;
        private System.Windows.Forms.Label UnitS;
        private System.Windows.Forms.Label UnitMS;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

