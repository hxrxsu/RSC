namespace RSC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            авторToolStripMenuItem = new ToolStripMenuItem();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 186);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(341, 175);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 1;
            button1.Text = "Клубы";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { авторToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // авторToolStripMenuItem
            // 
            авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            авторToolStripMenuItem.Size = new Size(52, 20);
            авторToolStripMenuItem.Text = "Автор";
            авторToolStripMenuItem.Click += авторToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Location = new Point(341, 219);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 3;
            button2.Text = "Тренеры";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Location = new Point(341, 258);
            button3.Name = "button3";
            button3.Size = new Size(94, 34);
            button3.TabIndex = 4;
            button3.Text = "Залы";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Location = new Point(341, 298);
            button4.Name = "button4";
            button4.Size = new Size(94, 34);
            button4.TabIndex = 5;
            button4.Text = "Игроки";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(130, 82);
            label2.Name = "label2";
            label2.Size = new Size(529, 32);
            label2.TabIndex = 6;
            label2.Text = "Добро пожаловать в областной спорткомитет";
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Location = new Point(341, 338);
            button5.Name = "button5";
            button5.Size = new Size(94, 34);
            button5.TabIndex = 7;
            button5.Text = "Транспорт";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(317, 137);
            button6.Name = "button6";
            button6.Size = new Size(141, 32);
            button6.TabIndex = 8;
            button6.Text = "Назначить тренировку";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Областной спорткомитет";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private MenuStrip menuStrip1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Button button5;
        private Button button6;
        private ToolStripMenuItem авторToolStripMenuItem;
    }
}