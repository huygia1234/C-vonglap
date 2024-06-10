namespace C__vonglap
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
            this.lblnhapso = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblgiaithua = new System.Windows.Forms.Label();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnhapso
            // 
            this.lblnhapso.AutoSize = true;
            this.lblnhapso.Location = new System.Drawing.Point(116, 89);
            this.lblnhapso.Name = "lblnhapso";
            this.lblnhapso.Size = new System.Drawing.Size(49, 13);
            this.lblnhapso.TabIndex = 0;
            this.lblnhapso.Text = "Nhập Số";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(566, 245);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 1;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(209, 82);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // lblgiaithua
            // 
            this.lblgiaithua.AutoSize = true;
            this.lblgiaithua.Location = new System.Drawing.Point(116, 151);
            this.lblgiaithua.Name = "lblgiaithua";
            this.lblgiaithua.Size = new System.Drawing.Size(53, 13);
            this.lblgiaithua.TabIndex = 3;
            this.lblgiaithua.Text = "Giai Thừa";
            // 
            // txtgt
            // 
            this.txtgt.Location = new System.Drawing.Point(209, 144);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(100, 20);
            this.txtgt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtgt);
            this.Controls.Add(this.lblgiaithua);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lblnhapso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhapso;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblgiaithua;
        private System.Windows.Forms.TextBox txtgt;
    }
}

