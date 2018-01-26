namespace UAVsRelayChanGenTool
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
            this.grpRecvPos = new System.Windows.Forms.GroupBox();
            this.txtRecvPosY = new System.Windows.Forms.TextBox();
            this.lalRecvPosYUnit = new System.Windows.Forms.Label();
            this.lalRecvPosY = new System.Windows.Forms.Label();
            this.txtRecvPosX = new System.Windows.Forms.TextBox();
            this.lalRecvPosX = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCnl = new System.Windows.Forms.Button();
            this.grpRecvPos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRecvPos
            // 
            this.grpRecvPos.BackColor = System.Drawing.Color.Transparent;
            this.grpRecvPos.Controls.Add(this.txtRecvPosY);
            this.grpRecvPos.Controls.Add(this.lalRecvPosYUnit);
            this.grpRecvPos.Controls.Add(this.lalRecvPosY);
            this.grpRecvPos.Controls.Add(this.txtRecvPosX);
            this.grpRecvPos.Controls.Add(this.lalRecvPosX);
            this.grpRecvPos.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.grpRecvPos.ForeColor = System.Drawing.Color.Black;
            this.grpRecvPos.Location = new System.Drawing.Point(12, 12);
            this.grpRecvPos.Name = "grpRecvPos";
            this.grpRecvPos.Size = new System.Drawing.Size(304, 104);
            this.grpRecvPos.TabIndex = 97;
            this.grpRecvPos.TabStop = false;
            this.grpRecvPos.Text = "地空链路";
            // 
            // txtRecvPosY
            // 
            this.txtRecvPosY.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtRecvPosY.Location = new System.Drawing.Point(186, 65);
            this.txtRecvPosY.Name = "txtRecvPosY";
            this.txtRecvPosY.Size = new System.Drawing.Size(85, 29);
            this.txtRecvPosY.TabIndex = 98;
            this.txtRecvPosY.Text = "1";
            this.txtRecvPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalRecvPosYUnit
            // 
            this.lalRecvPosYUnit.AutoSize = true;
            this.lalRecvPosYUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalRecvPosYUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvPosYUnit.ForeColor = System.Drawing.Color.Black;
            this.lalRecvPosYUnit.Location = new System.Drawing.Point(271, 68);
            this.lalRecvPosYUnit.Name = "lalRecvPosYUnit";
            this.lalRecvPosYUnit.Size = new System.Drawing.Size(31, 23);
            this.lalRecvPosYUnit.TabIndex = 97;
            this.lalRecvPosYUnit.Text = "dB";
            // 
            // lalRecvPosY
            // 
            this.lalRecvPosY.AutoSize = true;
            this.lalRecvPosY.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvPosY.ForeColor = System.Drawing.Color.Black;
            this.lalRecvPosY.Location = new System.Drawing.Point(10, 69);
            this.lalRecvPosY.Name = "lalRecvPosY";
            this.lalRecvPosY.Size = new System.Drawing.Size(150, 21);
            this.lalRecvPosY.TabIndex = 96;
            this.lalRecvPosY.Text = "阴影衰落标准差";
            // 
            // txtRecvPosX
            // 
            this.txtRecvPosX.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtRecvPosX.Location = new System.Drawing.Point(186, 30);
            this.txtRecvPosX.Name = "txtRecvPosX";
            this.txtRecvPosX.Size = new System.Drawing.Size(85, 29);
            this.txtRecvPosX.TabIndex = 95;
            this.txtRecvPosX.Text = "3";
            this.txtRecvPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lalRecvPosX
            // 
            this.lalRecvPosX.AutoSize = true;
            this.lalRecvPosX.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalRecvPosX.ForeColor = System.Drawing.Color.Black;
            this.lalRecvPosX.Location = new System.Drawing.Point(10, 34);
            this.lalRecvPosX.Name = "lalRecvPosX";
            this.lalRecvPosX.Size = new System.Drawing.Size(174, 21);
            this.lalRecvPosX.TabIndex = 85;
            this.lalRecvPosX.Text = "Nakagami衰落因子";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 104);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "空地链路";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(186, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 29);
            this.textBox1.TabIndex = 98;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(271, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 97;
            this.label1.Text = "dB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 96;
            this.label2.Text = "阴影衰落标准差";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(186, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 29);
            this.textBox2.TabIndex = 95;
            this.textBox2.Text = "3";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 85;
            this.label3.Text = "Nakagami衰落因子";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(155, 241);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 100;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCnl
            // 
            this.btnCnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCnl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCnl.Location = new System.Drawing.Point(241, 241);
            this.btnCnl.Name = "btnCnl";
            this.btnCnl.Size = new System.Drawing.Size(75, 32);
            this.btnCnl.TabIndex = 101;
            this.btnCnl.Text = "取消";
            this.btnCnl.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(326, 285);
            this.Controls.Add(this.btnCnl);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpRecvPos);
            this.Font = new System.Drawing.Font("华文楷体", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "通信场景设置";
            this.grpRecvPos.ResumeLayout(false);
            this.grpRecvPos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRecvPos;
        private System.Windows.Forms.TextBox txtRecvPosY;
        private System.Windows.Forms.Label lalRecvPosYUnit;
        private System.Windows.Forms.Label lalRecvPosY;
        private System.Windows.Forms.TextBox txtRecvPosX;
        private System.Windows.Forms.Label lalRecvPosX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCnl;
    }
}