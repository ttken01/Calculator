namespace Calculator
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
            this.btnCong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(270, 293);
            this.btnCong.Margin = new System.Windows.Forms.Padding(6);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(150, 45);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cong";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.AutoSizeChanged += new System.EventHandler(this.btnCong_Click);
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "So a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "So b ";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(217, 64);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(485, 38);
            this.txtSoa.TabIndex = 2;
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(217, 137);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(485, 38);
            this.txtSob.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ket Qua";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(217, 205);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(485, 38);
            this.txtKetQua.TabIndex = 2;
            this.txtKetQua.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(95, 293);
            this.btnTru.Margin = new System.Windows.Forms.Padding(6);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(150, 45);
            this.btnTru.TabIndex = 0;
            this.btnTru.Text = "Tru";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.AutoSizeChanged += new System.EventHandler(this.btnCong_Click);
            this.btnTru.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.AutoSizeChanged += new System.EventHandler(this.btnCong_Click);
            this.button1.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 293);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 45);
            this.button2.TabIndex = 0;
            this.button2.Text = "Nhan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.AutoSizeChanged += new System.EventHandler(this.btnCong_Click);
            this.button2.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(750, 137);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(86, 31);
            this.path.TabIndex = 3;
            this.path.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.path);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label path;
    }
}

