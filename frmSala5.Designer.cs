namespace Labirinto
{
    partial class frmSala5
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
            btn5x2 = new Button();
            btn5x6 = new Button();
            btn5x7 = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn5x2
            // 
            btn5x2.BackColor = Color.Transparent;
            btn5x2.FlatStyle = FlatStyle.Popup;
            btn5x2.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn5x2.ForeColor = Color.Red;
            btn5x2.Location = new Point(308, 12);
            btn5x2.Name = "btn5x2";
            btn5x2.Size = new Size(191, 94);
            btn5x2.TabIndex = 0;
            btn5x2.Text = "⬆";
            btn5x2.UseVisualStyleBackColor = false;
            // 
            // btn5x6
            // 
            btn5x6.BackColor = Color.Transparent;
            btn5x6.FlatStyle = FlatStyle.Popup;
            btn5x6.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn5x6.ForeColor = Color.Red;
            btn5x6.Location = new Point(597, 180);
            btn5x6.Name = "btn5x6";
            btn5x6.Size = new Size(191, 94);
            btn5x6.TabIndex = 1;
            btn5x6.Text = "⮕";
            btn5x6.UseVisualStyleBackColor = false;
            btn5x6.Click += button1_Click;
            // 
            // btn5x7
            // 
            btn5x7.BackColor = Color.Transparent;
            btn5x7.FlatStyle = FlatStyle.Popup;
            btn5x7.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn5x7.ForeColor = Color.Red;
            btn5x7.Location = new Point(12, 180);
            btn5x7.Name = "btn5x7";
            btn5x7.Size = new Size(191, 94);
            btn5x7.TabIndex = 2;
            btn5x7.Text = "⬅";
            btn5x7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(308, 344);
            button3.Name = "button3";
            button3.Size = new Size(191, 94);
            button3.TabIndex = 3;
            button3.Text = "⬇";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(675, 401);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 6;
            button1.Text = "Desistir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // frmSala5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.First_ladder;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(btn5x7);
            Controls.Add(btn5x6);
            Controls.Add(btn5x2);
            Name = "frmSala5";
            Text = "frmSala5";
            ResumeLayout(false);
        }

        #endregion

        private Button btn5x2;
        private Button btn5x6;
        private Button btn5x7;
        private Button button3;
        private Button button1;
    }
}