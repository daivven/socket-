﻿namespace Client
{
    partial class MainlForm
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
            this.lst_Receive = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst_Receive
            // 
            this.lst_Receive.FormattingEnabled = true;
            this.lst_Receive.ItemHeight = 12;
            this.lst_Receive.Location = new System.Drawing.Point(12, 12);
            this.lst_Receive.Name = "lst_Receive";
            this.lst_Receive.Size = new System.Drawing.Size(260, 232);
            this.lst_Receive.TabIndex = 1;
            // 
            // MainlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lst_Receive);
            this.Name = "MainlForm";
            this.Text = "接收端";
            this.Load += new System.EventHandler(this.MainlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Receive;
    }
}

