namespace Server
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.remoteIp = new System.Windows.Forms.TextBox();
            this.remotePort = new System.Windows.Forms.TextBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remoteIp
            // 
            this.remoteIp.Location = new System.Drawing.Point(89, 51);
            this.remoteIp.Name = "remoteIp";
            this.remoteIp.Size = new System.Drawing.Size(100, 21);
            this.remoteIp.TabIndex = 0;
            this.remoteIp.Text = "127.0.0.1";
            // 
            // remotePort
            // 
            this.remotePort.Location = new System.Drawing.Point(89, 90);
            this.remotePort.Name = "remotePort";
            this.remotePort.Size = new System.Drawing.Size(100, 21);
            this.remotePort.TabIndex = 1;
            this.remotePort.Text = "8008";
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(89, 128);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(100, 21);
            this.textMsg.TabIndex = 1;
            this.textMsg.Text = "capturepic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "远程IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "远程Port：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "消息内容：";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(89, 171);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 239);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.remotePort);
            this.Controls.Add(this.remoteIp);
            this.Name = "MainForm";
            this.Text = "UDP发送端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remoteIp;
        private System.Windows.Forms.TextBox remotePort;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
    }
}

