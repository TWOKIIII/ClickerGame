namespace ClickerGame
{
    partial class WinForm
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
            this.labelWin = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonWinExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWin.Location = new System.Drawing.Point(12, 9);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(277, 24);
            this.labelWin.TabIndex = 0;
            this.labelWin.Text = "\"Поздравляем! Вы выиграли!\"";
            // 
            // buttonRestart
            // 
            this.buttonRestart.AutoSize = true;
            this.buttonRestart.Location = new System.Drawing.Point(16, 74);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(92, 23);
            this.buttonRestart.TabIndex = 1;
            this.buttonRestart.Text = "Начать заново";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonWinExit
            // 
            this.buttonWinExit.Location = new System.Drawing.Point(197, 74);
            this.buttonWinExit.Name = "buttonWinExit";
            this.buttonWinExit.Size = new System.Drawing.Size(92, 23);
            this.buttonWinExit.TabIndex = 2;
            this.buttonWinExit.Text = "Выход";
            this.buttonWinExit.UseVisualStyleBackColor = true;
            this.buttonWinExit.Click += new System.EventHandler(this.buttonWinExit_Click);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 131);
            this.Controls.Add(this.buttonWinExit);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelWin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonWinExit;
    }
}