namespace Labirinto
{
    partial class frmSala1
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
            btn1x9 = new Button();
            btn1x2 = new Button();
            btn1x8 = new Button();
            btn1xStart = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn1x9
            // 
            btn1x9.BackColor = Color.Transparent;
            btn1x9.FlatStyle = FlatStyle.Popup;
            btn1x9.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn1x9.ForeColor = Color.Red;
            btn1x9.Location = new Point(329, 12);
            btn1x9.Name = "btn1x9";
            btn1x9.Size = new Size(150, 84);
            btn1x9.TabIndex = 0;
            btn1x9.Text = "⬆";
            btn1x9.TextAlign = ContentAlignment.TopCenter;
            btn1x9.UseVisualStyleBackColor = false;
            // 
            // btn1x2
            // 
            btn1x2.BackColor = Color.Transparent;
            btn1x2.FlatStyle = FlatStyle.Popup;
            btn1x2.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn1x2.ForeColor = Color.Red;
            btn1x2.Location = new Point(329, 355);
            btn1x2.Name = "btn1x2";
            btn1x2.Size = new Size(150, 83);
            btn1x2.TabIndex = 1;
            btn1x2.Text = "⬇";
            btn1x2.TextAlign = ContentAlignment.BottomCenter;
            btn1x2.UseVisualStyleBackColor = false;
            btn1x2.Click += btn1x2_Click;
            // 
            // btn1x8
            // 
            btn1x8.BackColor = Color.Transparent;
            btn1x8.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btn1x8.FlatAppearance.BorderSize = 0;
            btn1x8.FlatStyle = FlatStyle.Popup;
            btn1x8.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn1x8.ForeColor = Color.Red;
            btn1x8.Location = new Point(638, 183);
            btn1x8.Name = "btn1x8";
            btn1x8.Size = new Size(150, 110);
            btn1x8.TabIndex = 2;
            btn1x8.Text = "⮕";
            btn1x8.UseVisualStyleBackColor = false;
            // 
            // btn1xStart
            // 
            btn1xStart.BackColor = Color.Transparent;
            btn1xStart.FlatStyle = FlatStyle.Popup;
            btn1xStart.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn1xStart.ForeColor = Color.Red;
            btn1xStart.Location = new Point(2, 183);
            btn1xStart.Name = "btn1xStart";
            btn1xStart.Size = new Size(150, 110);
            btn1xStart.TabIndex = 3;
            btn1xStart.Text = "⬅";
            btn1xStart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 12);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 4;
            label1.Text = "2";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(662, 394);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 5;
            button1.Text = "Desistir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmSala1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Dinner_Room;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btn1xStart);
            Controls.Add(btn1x8);
            Controls.Add(btn1x2);
            Controls.Add(btn1x9);
            ForeColor = Color.Red;
            Name = "frmSala1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSala1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1x9;
        private Button btn1x2;
        private Button btn1x8;
        private Button btn1xStart;
        private Label label1;
        private Button button1;
    }
}