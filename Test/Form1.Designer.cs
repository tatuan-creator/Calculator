namespace Test
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbPhepTinh = new System.Windows.Forms.ComboBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng";
            // 
            // txtNumA
            // 
            this.txtNumA.Location = new System.Drawing.Point(134, 37);
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(100, 22);
            this.txtNumA.TabIndex = 3;
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(134, 76);
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(100, 22);
            this.txtNumB.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(134, 199);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 5;
            // 
            // cmbPhepTinh
            // 
            this.cmbPhepTinh.FormattingEnabled = true;
            this.cmbPhepTinh.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbPhepTinh.Location = new System.Drawing.Point(134, 121);
            this.cmbPhepTinh.Name = "cmbPhepTinh";
            this.cmbPhepTinh.Size = new System.Drawing.Size(121, 24);
            this.cmbPhepTinh.TabIndex = 6;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(134, 162);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "Tính";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 280);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.cmbPhepTinh);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumB);
            this.Controls.Add(this.txtNumA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbPhepTinh;
        private System.Windows.Forms.Button btnProcess;
    }
}

