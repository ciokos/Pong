namespace Pong
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
            this.ball = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.leftpadle = new System.Windows.Forms.Panel();
            this.rightpadle = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.leftscore = new System.Windows.Forms.Label();
            this.rightscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ball.Location = new System.Drawing.Point(380, 193);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // leftpadle
            // 
            this.leftpadle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftpadle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftpadle.Location = new System.Drawing.Point(30, 164);
            this.leftpadle.Name = "leftpadle";
            this.leftpadle.Size = new System.Drawing.Size(30, 100);
            this.leftpadle.TabIndex = 2;
            // 
            // rightpadle
            // 
            this.rightpadle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightpadle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightpadle.Location = new System.Drawing.Point(740, 164);
            this.rightpadle.Name = "rightpadle";
            this.rightpadle.Size = new System.Drawing.Size(30, 100);
            this.rightpadle.TabIndex = 3;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // leftscore
            // 
            this.leftscore.AutoSize = true;
            this.leftscore.Cursor = System.Windows.Forms.Cursors.Default;
            this.leftscore.Font = new System.Drawing.Font("Century Gothic", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftscore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.leftscore.Location = new System.Drawing.Point(109, 57);
            this.leftscore.Name = "leftscore";
            this.leftscore.Size = new System.Drawing.Size(281, 318);
            this.leftscore.TabIndex = 7;
            this.leftscore.Text = "0";
            this.leftscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightscore
            // 
            this.rightscore.AutoSize = true;
            this.rightscore.Cursor = System.Windows.Forms.Cursors.Default;
            this.rightscore.Font = new System.Drawing.Font("Century Gothic", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightscore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightscore.Location = new System.Drawing.Point(434, 57);
            this.rightscore.Name = "rightscore";
            this.rightscore.Size = new System.Drawing.Size(281, 318);
            this.rightscore.TabIndex = 8;
            this.rightscore.Text = "0";
            this.rightscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightscore);
            this.Controls.Add(this.leftscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightpadle);
            this.Controls.Add(this.leftpadle);
            this.Controls.Add(this.ball);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(808, 477);
            this.MinimumSize = new System.Drawing.Size(808, 477);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel leftpadle;
        private System.Windows.Forms.Panel rightpadle;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leftscore;
        private System.Windows.Forms.Label rightscore;
    }
}

