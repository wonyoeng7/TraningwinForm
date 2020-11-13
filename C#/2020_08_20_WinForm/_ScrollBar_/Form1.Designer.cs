namespace _ScrollBar_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scrR = new System.Windows.Forms.HScrollBar();
            this.scrG = new System.Windows.Forms.HScrollBar();
            this.scrB = new System.Windows.Forms.HScrollBar();
            this.textR = new System.Windows.Forms.TextBox();
            this.textG = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(82, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 190);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue";
            // 
            // scrR
            // 
            this.scrR.Location = new System.Drawing.Point(182, 234);
            this.scrR.Name = "scrR";
            this.scrR.Size = new System.Drawing.Size(400, 31);
            this.scrR.TabIndex = 4;
            this.scrR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.srcR_Scroll);
            // 
            // scrG
            // 
            this.scrG.Location = new System.Drawing.Point(182, 286);
            this.scrG.Name = "scrG";
            this.scrG.Size = new System.Drawing.Size(400, 31);
            this.scrG.TabIndex = 4;
            this.scrG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.srcG_Scroll);
            // 
            // scrB
            // 
            this.scrB.Location = new System.Drawing.Point(182, 338);
            this.scrB.Name = "scrB";
            this.scrB.Size = new System.Drawing.Size(400, 31);
            this.scrB.TabIndex = 4;
            this.scrB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.srcB_Scroll);
            // 
            // textR
            // 
            this.textR.Location = new System.Drawing.Point(639, 240);
            this.textR.Name = "textR";
            this.textR.Size = new System.Drawing.Size(100, 25);
            this.textR.TabIndex = 5;
            this.textR.TextChanged += new System.EventHandler(this.textR_TextChanged);
            // 
            // textG
            // 
            this.textG.Location = new System.Drawing.Point(639, 292);
            this.textG.Name = "textG";
            this.textG.Size = new System.Drawing.Size(100, 25);
            this.textG.TabIndex = 5;
            this.textG.TextChanged += new System.EventHandler(this.textG_TextChanged);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(639, 337);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 25);
            this.textB.TabIndex = 5;
            this.textB.TextChanged += new System.EventHandler(this.textB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textG);
            this.Controls.Add(this.textR);
            this.Controls.Add(this.scrB);
            this.Controls.Add(this.scrG);
            this.Controls.Add(this.scrR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RGB ScrollBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar scrR;
        private System.Windows.Forms.HScrollBar scrG;
        private System.Windows.Forms.HScrollBar scrB;
        private System.Windows.Forms.TextBox textR;
        private System.Windows.Forms.TextBox textG;
        private System.Windows.Forms.TextBox textB;
    }
}

