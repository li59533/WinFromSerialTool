namespace Serialtool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_comx = new System.Windows.Forms.ComboBox();
            this.btn_serial_sw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_revdata = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbx_senddata = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_serial_sw);
            this.groupBox1.Controls.Add(this.cbx_comx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial_Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM:";
            // 
            // cbx_comx
            // 
            this.cbx_comx.FormattingEnabled = true;
            this.cbx_comx.Location = new System.Drawing.Point(35, 28);
            this.cbx_comx.Name = "cbx_comx";
            this.cbx_comx.Size = new System.Drawing.Size(60, 20);
            this.cbx_comx.TabIndex = 1;
            // 
            // btn_serial_sw
            // 
            this.btn_serial_sw.Location = new System.Drawing.Point(101, 26);
            this.btn_serial_sw.Name = "btn_serial_sw";
            this.btn_serial_sw.Size = new System.Drawing.Size(57, 82);
            this.btn_serial_sw.TabIndex = 2;
            this.btn_serial_sw.Text = "Open";
            this.btn_serial_sw.UseVisualStyleBackColor = true;
            this.btn_serial_sw.Click += new System.EventHandler(this.btn_serial_sw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default:115200 8N1";
            // 
            // tbx_revdata
            // 
            this.tbx_revdata.Location = new System.Drawing.Point(15, 30);
            this.tbx_revdata.Multiline = true;
            this.tbx_revdata.Name = "tbx_revdata";
            this.tbx_revdata.Size = new System.Drawing.Size(602, 131);
            this.tbx_revdata.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(192, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 503);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbx_revdata);
            this.groupBox3.Location = new System.Drawing.Point(19, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 180);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rev";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_send);
            this.groupBox4.Controls.Add(this.tbx_senddata);
            this.groupBox4.Location = new System.Drawing.Point(19, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(623, 230);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send";
            // 
            // tbx_senddata
            // 
            this.tbx_senddata.Location = new System.Drawing.Point(15, 20);
            this.tbx_senddata.Name = "tbx_senddata";
            this.tbx_senddata.Size = new System.Drawing.Size(602, 21);
            this.tbx_senddata.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(15, 70);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(201, 116);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_serial_sw;
        private System.Windows.Forms.ComboBox cbx_comx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_revdata;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbx_senddata;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_send;
    }
}

