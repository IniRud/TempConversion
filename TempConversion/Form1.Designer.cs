
namespace TempConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fer = new System.Windows.Forms.TextBox();
            this.txt_kel = new System.Windows.Forms.TextBox();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.btn_fer = new System.Windows.Forms.Button();
            this.btn_kel = new System.Windows.Forms.Button();
            this.btn_cel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(56, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ferhenheight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(135, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(147, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txt_fer
            // 
            this.txt_fer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_fer.Location = new System.Drawing.Point(368, 59);
            this.txt_fer.Name = "txt_fer";
            this.txt_fer.Size = new System.Drawing.Size(150, 45);
            this.txt_fer.TabIndex = 3;
            // 
            // txt_kel
            // 
            this.txt_kel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_kel.Location = new System.Drawing.Point(368, 220);
            this.txt_kel.Name = "txt_kel";
            this.txt_kel.Size = new System.Drawing.Size(150, 45);
            this.txt_kel.TabIndex = 4;
            // 
            // txt_cel
            // 
            this.txt_cel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cel.Location = new System.Drawing.Point(368, 131);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(150, 45);
            this.txt_cel.TabIndex = 5;
            // 
            // btn_fer
            // 
            this.btn_fer.Location = new System.Drawing.Point(657, 59);
            this.btn_fer.Name = "btn_fer";
            this.btn_fer.Size = new System.Drawing.Size(112, 45);
            this.btn_fer.TabIndex = 6;
            this.btn_fer.Text = "Convert";
            this.btn_fer.UseVisualStyleBackColor = true;
            this.btn_fer.Click += new System.EventHandler(this.btn_fer_Click);
            // 
            // btn_kel
            // 
            this.btn_kel.Location = new System.Drawing.Point(657, 220);
            this.btn_kel.Name = "btn_kel";
            this.btn_kel.Size = new System.Drawing.Size(112, 45);
            this.btn_kel.TabIndex = 7;
            this.btn_kel.Text = "Convert";
            this.btn_kel.UseVisualStyleBackColor = true;
            this.btn_kel.Click += new System.EventHandler(this.btn_kel_Click);
            // 
            // btn_cel
            // 
            this.btn_cel.Location = new System.Drawing.Point(657, 131);
            this.btn_cel.Name = "btn_cel";
            this.btn_cel.Size = new System.Drawing.Size(112, 45);
            this.btn_cel.TabIndex = 8;
            this.btn_cel.Text = "Convert";
            this.btn_cel.UseVisualStyleBackColor = true;
            this.btn_cel.Click += new System.EventHandler(this.btn_cel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cel);
            this.Controls.Add(this.btn_kel);
            this.Controls.Add(this.btn_fer);
            this.Controls.Add(this.txt_cel);
            this.Controls.Add(this.txt_kel);
            this.Controls.Add(this.txt_fer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fer;
        private System.Windows.Forms.TextBox txt_kel;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.Button btn_fer;
        private System.Windows.Forms.Button btn_kel;
        private System.Windows.Forms.Button btn_cel;
    }
}

