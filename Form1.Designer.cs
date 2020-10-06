namespace Timer
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Begin = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.TextBox();
            this.Hello = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 242);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(768, 54);
            this.progressBar1.TabIndex = 0;
            // 
            // Begin
            // 
            this.Begin.Location = new System.Drawing.Point(83, 363);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(269, 50);
            this.Begin.TabIndex = 1;
            this.Begin.Text = "Старт";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(336, 145);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(129, 22);
            this.Second.TabIndex = 2;
            this.Second.Text = "Введите значение";
            this.Second.Click += new System.EventHandler(this.Second_Click);
            // 
            // Hello
            // 
            this.Hello.Location = new System.Drawing.Point(267, 88);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(267, 27);
            this.Hello.TabIndex = 3;
            this.Hello.Text = "Введите количество секунд";
            this.Hello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(444, 363);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(269, 50);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Стоп";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // TimeLeft
            // 
            this.TimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.TimeLeft.Location = new System.Drawing.Point(228, 192);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(339, 35);
            this.TimeLeft.TabIndex = 5;
            this.TimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Таймер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.TextBox Second;
        private System.Windows.Forms.Label Hello;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label TimeLeft;
    }
}

