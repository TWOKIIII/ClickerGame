namespace ClickerGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelScore = new System.Windows.Forms.Label();
            this.pictureBoxCharacter = new System.Windows.Forms.PictureBox();
            this.buttonCustomize = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBoostX2 = new System.Windows.Forms.Button();
            this.buttonBoostX4 = new System.Windows.Forms.Button();
            this.buttonAutoClicker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(420, 8);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(24, 26);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "0";
            // 
            // pictureBoxCharacter
            // 
            this.pictureBoxCharacter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCharacter.Image")));
            this.pictureBoxCharacter.Location = new System.Drawing.Point(91, 199);
            this.pictureBoxCharacter.Name = "pictureBoxCharacter";
            this.pictureBoxCharacter.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCharacter.TabIndex = 1;
            this.pictureBoxCharacter.TabStop = false;
            this.pictureBoxCharacter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCharacter_MouseDown);
            // 
            // buttonCustomize
            // 
            this.buttonCustomize.AutoSize = true;
            this.buttonCustomize.Location = new System.Drawing.Point(12, 12);
            this.buttonCustomize.Name = "buttonCustomize";
            this.buttonCustomize.Size = new System.Drawing.Size(91, 23);
            this.buttonCustomize.TabIndex = 2;
            this.buttonCustomize.Text = "Кастомизация";
            this.buttonCustomize.UseVisualStyleBackColor = true;
            this.buttonCustomize.Click += new System.EventHandler(this.buttonCustomize_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 42);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Сброс счёта";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 100);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(91, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(12, 71);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(91, 23);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.Text = "Инфа о игре";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAutoClicker);
            this.groupBox1.Controls.Add(this.buttonBoostX4);
            this.groupBox1.Controls.Add(this.buttonBoostX2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(137, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Бустеры";
            // 
            // buttonBoostX2
            // 
            this.buttonBoostX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBoostX2.Location = new System.Drawing.Point(6, 23);
            this.buttonBoostX2.Name = "buttonBoostX2";
            this.buttonBoostX2.Size = new System.Drawing.Size(75, 23);
            this.buttonBoostX2.TabIndex = 0;
            this.buttonBoostX2.Text = "x2 клик";
            this.buttonBoostX2.UseVisualStyleBackColor = true;
            this.buttonBoostX2.Click += new System.EventHandler(this.buttonBoostX2_Click);
            // 
            // buttonBoostX4
            // 
            this.buttonBoostX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBoostX4.Location = new System.Drawing.Point(88, 23);
            this.buttonBoostX4.Name = "buttonBoostX4";
            this.buttonBoostX4.Size = new System.Drawing.Size(75, 23);
            this.buttonBoostX4.TabIndex = 1;
            this.buttonBoostX4.Text = "x4 клик";
            this.buttonBoostX4.UseVisualStyleBackColor = true;
            this.buttonBoostX4.Click += new System.EventHandler(this.buttonBoostX4_Click);
            // 
            // buttonAutoClicker
            // 
            this.buttonAutoClicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAutoClicker.Location = new System.Drawing.Point(169, 23);
            this.buttonAutoClicker.Name = "buttonAutoClicker";
            this.buttonAutoClicker.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoClicker.TabIndex = 2;
            this.buttonAutoClicker.Text = "Автоклик";
            this.buttonAutoClicker.UseVisualStyleBackColor = true;
            this.buttonAutoClicker.Click += new System.EventHandler(this.buttonAutoClicker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCustomize);
            this.Controls.Add(this.pictureBoxCharacter);
            this.Controls.Add(this.labelScore);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClickerGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxCharacter;
        private System.Windows.Forms.Button buttonCustomize;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAutoClicker;
        private System.Windows.Forms.Button buttonBoostX4;
        private System.Windows.Forms.Button buttonBoostX2;
    }
}

