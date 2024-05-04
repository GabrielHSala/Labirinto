namespace Labirinto
{
    partial class frmSala12
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
            btn12x6 = new Button();
            btn12x3 = new Button();
            btn12x13 = new Button();
            btn12x14 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn12x6
            // 
            btn12x6.BackColor = Color.Transparent;
            btn12x6.FlatStyle = FlatStyle.Popup;
            btn12x6.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn12x6.ForeColor = Color.Red;
            btn12x6.Location = new Point(308, 344);
            btn12x6.Name = "btn12x6";
            btn12x6.Size = new Size(191, 94);
            btn12x6.TabIndex = 11;
            btn12x6.Text = "⬇";
            btn12x6.UseVisualStyleBackColor = false;
            btn12x6.Click += btn12x6_Click;
            // 
            // btn12x3
            // 
            btn12x3.BackColor = Color.Transparent;
            btn12x3.FlatStyle = FlatStyle.Popup;
            btn12x3.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn12x3.ForeColor = Color.Red;
            btn12x3.Location = new Point(12, 180);
            btn12x3.Name = "btn12x3";
            btn12x3.Size = new Size(191, 94);
            btn12x3.TabIndex = 10;
            btn12x3.Text = "⬅";
            btn12x3.UseVisualStyleBackColor = false;
            btn12x3.Click += btn12x3_Click;
            // 
            // btn12x13
            // 
            btn12x13.BackColor = Color.Transparent;
            btn12x13.FlatStyle = FlatStyle.Popup;
            btn12x13.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn12x13.ForeColor = Color.Red;
            btn12x13.Location = new Point(597, 180);
            btn12x13.Name = "btn12x13";
            btn12x13.Size = new Size(191, 94);
            btn12x13.TabIndex = 9;
            btn12x13.Text = "⮕";
            btn12x13.UseVisualStyleBackColor = false;
            btn12x13.Click += btn12x13_Click;
            // 
            // btn12x14
            // 
            btn12x14.BackColor = Color.Transparent;
            btn12x14.FlatStyle = FlatStyle.Popup;
            btn12x14.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn12x14.ForeColor = Color.Red;
            btn12x14.Location = new Point(308, 12);
            btn12x14.Name = "btn12x14";
            btn12x14.Size = new Size(191, 94);
            btn12x14.TabIndex = 8;
            btn12x14.Text = "⬆";
            btn12x14.UseVisualStyleBackColor = false;
            btn12x14.Click += btn12x14_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(676, 404);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 12;
            button1.Text = "Desistir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmSala12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.second_floor;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn12x6);
            Controls.Add(btn12x3);
            Controls.Add(btn12x13);
            Controls.Add(btn12x14);
            Name = "frmSala12";
            Text = "frmSala12";
            ResumeLayout(false);
        }

        #endregion

        private Button btn12x6;
        private Button btn12x3;
        private Button btn12x13;
        private Button btn12x14;
        private Button button1;
    }
}