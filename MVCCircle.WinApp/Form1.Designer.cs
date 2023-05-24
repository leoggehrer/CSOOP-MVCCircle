namespace MVCCircle.WinApp
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
            lblRadius = new Label();
            txbRadius = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lblRadius
            // 
            lblRadius.AutoSize = true;
            lblRadius.Location = new Point(12, 9);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(56, 20);
            lblRadius.TabIndex = 0;
            lblRadius.Text = "Radius:";
            // 
            // txbRadius
            // 
            txbRadius.Location = new Point(74, 6);
            txbRadius.Name = "txbRadius";
            txbRadius.Size = new Size(125, 27);
            txbRadius.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(218, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txbRadius);
            Controls.Add(lblRadius);
            Name = "Form1";
            Text = "Form1";
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadius;
        private TextBox txbRadius;
        private Button btnUpdate;
    }
}