
namespace Final_Exam_Sudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EZ = new System.Windows.Forms.RadioButton();
            this.NM = new System.Windows.Forms.RadioButton();
            this.H = new System.Windows.Forms.RadioButton();
            this.NewBtn = new System.Windows.Forms.Button();
            this.SEZ = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 468);
            this.panel1.TabIndex = 0;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBtn.Location = new System.Drawing.Point(561, 12);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(114, 63);
            this.CheckBtn.TabIndex = 1;
            this.CheckBtn.Text = "Kiểm tra";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // RestartBtn
            // 
            this.RestartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartBtn.Location = new System.Drawing.Point(561, 100);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(114, 64);
            this.RestartBtn.TabIndex = 2;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lever:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EZ
            // 
            this.EZ.AutoSize = true;
            this.EZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EZ.Location = new System.Drawing.Point(561, 306);
            this.EZ.Name = "EZ";
            this.EZ.Size = new System.Drawing.Size(58, 29);
            this.EZ.TabIndex = 4;
            this.EZ.TabStop = true;
            this.EZ.Text = "Dễ";
            this.EZ.UseVisualStyleBackColor = true;
            // 
            // NM
            // 
            this.NM.AutoSize = true;
            this.NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NM.Location = new System.Drawing.Point(561, 334);
            this.NM.Name = "NM";
            this.NM.Size = new System.Drawing.Size(65, 28);
            this.NM.TabIndex = 5;
            this.NM.TabStop = true;
            this.NM.Text = "Vừa";
            this.NM.UseVisualStyleBackColor = true;
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(561, 362);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(65, 28);
            this.H.TabIndex = 6;
            this.H.TabStop = true;
            this.H.Text = "Khó";
            this.H.UseVisualStyleBackColor = true;
            // 
            // NewBtn
            // 
            this.NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.Location = new System.Drawing.Point(561, 408);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(114, 72);
            this.NewBtn.TabIndex = 7;
            this.NewBtn.Text = "Chơi Mới";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // SEZ
            // 
            this.SEZ.AutoSize = true;
            this.SEZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEZ.Location = new System.Drawing.Point(561, 271);
            this.SEZ.Name = "SEZ";
            this.SEZ.Size = new System.Drawing.Size(111, 29);
            this.SEZ.TabIndex = 8;
            this.SEZ.TabStop = true;
            this.SEZ.Text = "Mới Chơi";
            this.SEZ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 499);
            this.Controls.Add(this.SEZ);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.H);
            this.Controls.Add(this.NM);
            this.Controls.Add(this.EZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestartBtn);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sudoku-The Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton EZ;
        private System.Windows.Forms.RadioButton NM;
        private System.Windows.Forms.RadioButton H;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.RadioButton SEZ;
    }
}