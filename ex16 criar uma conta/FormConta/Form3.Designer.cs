namespace ex16_criar_uma_conta.FormConta
{
    partial class Form3
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
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(300, 2);
            button2.Name = "button2";
            button2.Size = new Size(35, 24);
            button2.TabIndex = 18;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 19;
            label1.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 313);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Form3";
            Text = "Dados da Conta";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
    }
}