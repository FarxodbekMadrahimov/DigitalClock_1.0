
namespace DigitalClock_1._0
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
            this.lbl24Time = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl24Time
            // 
            this.lbl24Time.AutoSize = true;
            this.lbl24Time.BackColor = System.Drawing.Color.Black;
            this.lbl24Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl24Time.ForeColor = System.Drawing.Color.Red;
            this.lbl24Time.Location = new System.Drawing.Point(31, 103);
            this.lbl24Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl24Time.Name = "lbl24Time";
            this.lbl24Time.Size = new System.Drawing.Size(289, 108);
            this.lbl24Time.TabIndex = 0;
            this.lbl24Time.Text = "00:00";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.BackColor = System.Drawing.Color.Black;
            this.lblsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.ForeColor = System.Drawing.Color.Red;
            this.lblsec.Location = new System.Drawing.Point(376, 124);
            this.lblsec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(115, 82);
            this.lblsec.TabIndex = 1;
            this.lblsec.Text = "00";
            this.lblsec.Click += new System.EventHandler(this.lblsec_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(532, 315);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.lbl24Time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl24Time;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Timer timer1;
    }
}

