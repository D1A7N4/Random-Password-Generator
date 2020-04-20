namespace Random_Password_Generator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_Password = new System.Windows.Forms.TextBox();
            this.BTN_Randomise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Password Generator";
            // 
            // TBX_Password
            // 
            this.TBX_Password.Location = new System.Drawing.Point(21, 64);
            this.TBX_Password.Name = "TBX_Password";
            this.TBX_Password.ReadOnly = true;
            this.TBX_Password.Size = new System.Drawing.Size(345, 20);
            this.TBX_Password.TabIndex = 1;
            // 
            // BTN_Randomise
            // 
            this.BTN_Randomise.Location = new System.Drawing.Point(21, 106);
            this.BTN_Randomise.Name = "BTN_Randomise";
            this.BTN_Randomise.Size = new System.Drawing.Size(345, 43);
            this.BTN_Randomise.TabIndex = 2;
            this.BTN_Randomise.Text = "Randomise";
            this.BTN_Randomise.UseVisualStyleBackColor = true;
            this.BTN_Randomise.Click += new System.EventHandler(this.BTN_Randomise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.BTN_Randomise);
            this.Controls.Add(this.TBX_Password);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_Password;
        private System.Windows.Forms.Button BTN_Randomise;
    }
}

