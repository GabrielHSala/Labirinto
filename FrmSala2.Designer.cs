namespace Labirinto
{
    partial class frmSala2
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
            btn2x5 = new Button();
            btn2x1 = new Button();
            btn2x3 = new Button();
            btn2x4 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn2x5
            // 
            btn2x5.BackColor = Color.Transparent;
            btn2x5.FlatStyle = FlatStyle.Popup;
            btn2x5.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn2x5.Location = new Point(333, 362);
            btn2x5.Name = "btn2x5";
            btn2x5.Size = new Size(124, 76);
            btn2x5.TabIndex = 0;
            btn2x5.Text = "⬇";
            btn2x5.TextAlign = ContentAlignment.BottomCenter;
            btn2x5.UseVisualStyleBackColor = false;
            btn2x5.Click += btn2x5_Click;
            // 
            // btn2x1
            // 
            btn2x1.BackColor = Color.Transparent;
            btn2x1.FlatStyle = FlatStyle.Popup;
            btn2x1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn2x1.Location = new Point(333, 12);
            btn2x1.Name = "btn2x1";
            btn2x1.Size = new Size(124, 76);
            btn2x1.TabIndex = 1;
            btn2x1.Text = "⬆";
            btn2x1.TextAlign = ContentAlignment.BottomCenter;
            btn2x1.UseVisualStyleBackColor = false;
            // 
            // btn2x3
            // 
            btn2x3.BackColor = Color.Transparent;
            btn2x3.FlatStyle = FlatStyle.Popup;
            btn2x3.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn2x3.Location = new Point(664, 209);
            btn2x3.Name = "btn2x3";
            btn2x3.Size = new Size(124, 76);
            btn2x3.TabIndex = 2;
            btn2x3.Text = "⮕";
            btn2x3.TextAlign = ContentAlignment.BottomCenter;
            btn2x3.UseVisualStyleBackColor = false;
            // 
            // btn2x4
            // 
            btn2x4.BackColor = Color.Transparent;
            btn2x4.FlatStyle = FlatStyle.Popup;
            btn2x4.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btn2x4.Location = new Point(12, 209);
            btn2x4.Name = "btn2x4";
            btn2x4.Size = new Size(124, 76);
            btn2x4.TabIndex = 3;
            btn2x4.Text = "⬅";
            btn2x4.TextAlign = ContentAlignment.BottomCenter;
            btn2x4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(674, 406);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 6;
            button1.Text = "Desistir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmSala2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.first_zombie;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn2x4);
            Controls.Add(btn2x3);
            Controls.Add(btn2x1);
            Controls.Add(btn2x5);
            ForeColor = Color.Red;
            Name = "frmSala2";
            Text = "FrmSala2";
            ResumeLayout(false);
        }

        #endregion

        private Button btn2x5;
        private Button btn2x1;
        private Button btn2x3;
        private Button btn2x4;
        private Button button1;
    }
}