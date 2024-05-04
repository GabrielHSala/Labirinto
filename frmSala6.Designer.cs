namespace Labirinto
{
    partial class frmSala6
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
            btn6x4 = new Button();
            btn6x5 = new Button();
            btn6x12 = new Button();
            btn6x3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn6x4
            // 
            btn6x4.BackColor = Color.Transparent;
            btn6x4.FlatStyle = FlatStyle.Popup;
            btn6x4.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn6x4.ForeColor = Color.Red;
            btn6x4.Location = new Point(308, 344);
            btn6x4.Name = "btn6x4";
            btn6x4.Size = new Size(191, 94);
            btn6x4.TabIndex = 7;
            btn6x4.Text = "⬇";
            btn6x4.UseVisualStyleBackColor = false;
            btn6x4.Click += btn6x4_Click;
            // 
            // btn6x5
            // 
            btn6x5.BackColor = Color.Transparent;
            btn6x5.FlatStyle = FlatStyle.Popup;
            btn6x5.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn6x5.ForeColor = Color.Red;
            btn6x5.Location = new Point(12, 180);
            btn6x5.Name = "btn6x5";
            btn6x5.Size = new Size(191, 94);
            btn6x5.TabIndex = 6;
            btn6x5.Text = "⬅";
            btn6x5.UseVisualStyleBackColor = false;
            btn6x5.Click += btn6x5_Click;
            // 
            // btn6x12
            // 
            btn6x12.BackColor = Color.Transparent;
            btn6x12.FlatStyle = FlatStyle.Popup;
            btn6x12.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn6x12.ForeColor = Color.Red;
            btn6x12.Location = new Point(597, 180);
            btn6x12.Name = "btn6x12";
            btn6x12.Size = new Size(191, 94);
            btn6x12.TabIndex = 5;
            btn6x12.Text = "⮕";
            btn6x12.UseVisualStyleBackColor = false;
            btn6x12.Click += btn6x12_Click;
            // 
            // btn6x3
            // 
            btn6x3.BackColor = Color.Transparent;
            btn6x3.FlatStyle = FlatStyle.Popup;
            btn6x3.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn6x3.ForeColor = Color.Red;
            btn6x3.Location = new Point(308, 12);
            btn6x3.Name = "btn6x3";
            btn6x3.Size = new Size(191, 94);
            btn6x3.TabIndex = 4;
            btn6x3.Text = "⬆";
            btn6x3.UseVisualStyleBackColor = false;
            btn6x3.Click += btn6x3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(672, 401);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 8;
            button1.Text = "Desistir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmSala6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ShieldTrap;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn6x4);
            Controls.Add(btn6x5);
            Controls.Add(btn6x12);
            Controls.Add(btn6x3);
            Name = "frmSala6";
            Text = "frmSala6";
            Load += frmSala6_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn6x4;
        private Button btn6x5;
        private Button btn6x12;
        private Button btn6x3;
        private Button button1;
    }
}