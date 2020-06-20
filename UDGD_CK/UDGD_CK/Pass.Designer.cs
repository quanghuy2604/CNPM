namespace UDGD_CK
{
    partial class Pass
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mxt = new System.Windows.Forms.TextBox();
            this.btn_guima = new System.Windows.Forms.Button();
            this.btn_xacnhan = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_passag = new System.Windows.Forms.TextBox();
            this.btn_mk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(138, 24);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(189, 20);
            this.txt_email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email xac thuc: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ma xac thuc : ";
            // 
            // txt_mxt
            // 
            this.txt_mxt.Location = new System.Drawing.Point(138, 63);
            this.txt_mxt.Name = "txt_mxt";
            this.txt_mxt.Size = new System.Drawing.Size(189, 20);
            this.txt_mxt.TabIndex = 3;
            // 
            // btn_guima
            // 
            this.btn_guima.Location = new System.Drawing.Point(252, 201);
            this.btn_guima.Name = "btn_guima";
            this.btn_guima.Size = new System.Drawing.Size(75, 23);
            this.btn_guima.TabIndex = 4;
            this.btn_guima.Text = "Gui ma";
            this.btn_guima.UseVisualStyleBackColor = true;
            this.btn_guima.Click += new System.EventHandler(this.btn_guima_Click);
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.Location = new System.Drawing.Point(160, 201);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(75, 23);
            this.btn_xacnhan.TabIndex = 5;
            this.btn_xacnhan.Text = "Xac nhan ma";
            this.btn_xacnhan.UseVisualStyleBackColor = true;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(138, 103);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(189, 20);
            this.txt_pass.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mat khau moi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhap lai mat khau : ";
            // 
            // txt_passag
            // 
            this.txt_passag.Location = new System.Drawing.Point(138, 139);
            this.txt_passag.Name = "txt_passag";
            this.txt_passag.Size = new System.Drawing.Size(189, 20);
            this.txt_passag.TabIndex = 9;
            // 
            // btn_mk
            // 
            this.btn_mk.Location = new System.Drawing.Point(33, 201);
            this.btn_mk.Name = "btn_mk";
            this.btn_mk.Size = new System.Drawing.Size(113, 23);
            this.btn_mk.TabIndex = 10;
            this.btn_mk.Text = "Xac nhan mat khau";
            this.btn_mk.UseVisualStyleBackColor = true;
            this.btn_mk.Click += new System.EventHandler(this.btn_mk_Click);
            // 
            // Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 253);
            this.Controls.Add(this.btn_mk);
            this.Controls.Add(this.txt_passag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.btn_guima);
            this.Controls.Add(this.txt_mxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Name = "Pass";
            this.Text = "Pass";
            this.Load += new System.EventHandler(this.Pass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mxt;
        private System.Windows.Forms.Button btn_guima;
        private System.Windows.Forms.Button btn_xacnhan;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_passag;
        private System.Windows.Forms.Button btn_mk;
    }
}