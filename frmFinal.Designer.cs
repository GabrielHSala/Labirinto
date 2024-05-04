namespace Labirinto
{
    partial class frmFinal
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
            btnFinalizar = new Button();
            SuspendLayout();
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Transparent;
            btnFinalizar.FlatStyle = FlatStyle.Popup;
            btnFinalizar.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizar.Location = new Point(222, 198);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(329, 107);
            btnFinalizar.TabIndex = 0;
            btnFinalizar.Text = "Retry";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // frmFinal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.heliport;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizar);
            ForeColor = Color.Red;
            Name = "frmFinal";
            Text = "frmFinal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFinalizar;
    }
}