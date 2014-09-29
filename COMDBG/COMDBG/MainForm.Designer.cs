namespace COMDBG
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComListCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boaudRateCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataBitsCbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stopBitsCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parityCbx = new System.Windows.Forms.ComboBox();
            this.openCloseSpbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recHexRadiobtn = new System.Windows.Forms.RadioButton();
            this.recStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clearReceivebtn = new System.Windows.Forms.Button();
            this.clearSendbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sendtbx = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.sendHexRadiobtn = new System.Windows.Forms.RadioButton();
            this.sendStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.RxTbx = new System.Windows.Forms.TextBox();
            this.TxTbx = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Received Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Send Data:";
            // 
            // ComListCbx
            // 
            this.ComListCbx.FormattingEnabled = true;
            this.ComListCbx.Location = new System.Drawing.Point(24, 53);
            this.ComListCbx.Name = "ComListCbx";
            this.ComListCbx.Size = new System.Drawing.Size(69, 21);
            this.ComListCbx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "COM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Boaud Rate:";
            // 
            // boaudRateCbx
            // 
            this.boaudRateCbx.FormattingEnabled = true;
            this.boaudRateCbx.Location = new System.Drawing.Point(24, 98);
            this.boaudRateCbx.Name = "boaudRateCbx";
            this.boaudRateCbx.Size = new System.Drawing.Size(69, 21);
            this.boaudRateCbx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Bits:";
            // 
            // dataBitsCbx
            // 
            this.dataBitsCbx.FormattingEnabled = true;
            this.dataBitsCbx.Location = new System.Drawing.Point(24, 143);
            this.dataBitsCbx.Name = "dataBitsCbx";
            this.dataBitsCbx.Size = new System.Drawing.Size(69, 21);
            this.dataBitsCbx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stop Bits:";
            // 
            // stopBitsCbx
            // 
            this.stopBitsCbx.FormattingEnabled = true;
            this.stopBitsCbx.Location = new System.Drawing.Point(24, 188);
            this.stopBitsCbx.Name = "stopBitsCbx";
            this.stopBitsCbx.Size = new System.Drawing.Size(69, 21);
            this.stopBitsCbx.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Parity:";
            // 
            // parityCbx
            // 
            this.parityCbx.FormattingEnabled = true;
            this.parityCbx.Location = new System.Drawing.Point(24, 233);
            this.parityCbx.Name = "parityCbx";
            this.parityCbx.Size = new System.Drawing.Size(69, 21);
            this.parityCbx.TabIndex = 15;
            // 
            // openCloseSpbtn
            // 
            this.openCloseSpbtn.Location = new System.Drawing.Point(24, 271);
            this.openCloseSpbtn.Name = "openCloseSpbtn";
            this.openCloseSpbtn.Size = new System.Drawing.Size(69, 35);
            this.openCloseSpbtn.TabIndex = 17;
            this.openCloseSpbtn.Text = "Open";
            this.openCloseSpbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxTbx);
            this.groupBox1.Controls.Add(this.RxTbx);
            this.groupBox1.Controls.Add(this.sendHexRadiobtn);
            this.groupBox1.Controls.Add(this.sendStrRadiobtn);
            this.groupBox1.Controls.Add(this.recHexRadiobtn);
            this.groupBox1.Controls.Add(this.recStrRadiobtn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.clearReceivebtn);
            this.groupBox1.Controls.Add(this.clearSendbtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.sendtbx);
            this.groupBox1.Controls.Add(this.sendbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(115, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 289);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // recHexRadiobtn
            // 
            this.recHexRadiobtn.AutoSize = true;
            this.recHexRadiobtn.Location = new System.Drawing.Point(172, 12);
            this.recHexRadiobtn.Name = "recHexRadiobtn";
            this.recHexRadiobtn.Size = new System.Drawing.Size(44, 17);
            this.recHexRadiobtn.TabIndex = 15;
            this.recHexRadiobtn.TabStop = true;
            this.recHexRadiobtn.Text = "Hex";
            this.recHexRadiobtn.UseVisualStyleBackColor = true;
            // 
            // recStrRadiobtn
            // 
            this.recStrRadiobtn.AutoSize = true;
            this.recStrRadiobtn.Location = new System.Drawing.Point(111, 12);
            this.recStrRadiobtn.Name = "recStrRadiobtn";
            this.recStrRadiobtn.Size = new System.Drawing.Size(52, 17);
            this.recStrRadiobtn.TabIndex = 14;
            this.recStrRadiobtn.TabStop = true;
            this.recStrRadiobtn.Text = "String";
            this.recStrRadiobtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tx:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Rx:";
            // 
            // clearReceivebtn
            // 
            this.clearReceivebtn.Location = new System.Drawing.Point(288, 32);
            this.clearReceivebtn.Name = "clearReceivebtn";
            this.clearReceivebtn.Size = new System.Drawing.Size(58, 34);
            this.clearReceivebtn.TabIndex = 11;
            this.clearReceivebtn.Text = "Clear";
            this.clearReceivebtn.UseVisualStyleBackColor = true;
            // 
            // clearSendbtn
            // 
            this.clearSendbtn.Location = new System.Drawing.Point(288, 199);
            this.clearSendbtn.Name = "clearSendbtn";
            this.clearSendbtn.Size = new System.Drawing.Size(58, 35);
            this.clearSendbtn.TabIndex = 10;
            this.clearSendbtn.Text = "Clear";
            this.clearSendbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 135);
            this.textBox1.TabIndex = 9;
            // 
            // sendtbx
            // 
            this.sendtbx.Location = new System.Drawing.Point(13, 199);
            this.sendtbx.Multiline = true;
            this.sendtbx.Name = "sendtbx";
            this.sendtbx.Size = new System.Drawing.Size(252, 74);
            this.sendtbx.TabIndex = 8;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(288, 238);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(58, 35);
            this.sendbtn.TabIndex = 7;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            // 
            // sendHexRadiobtn
            // 
            this.sendHexRadiobtn.AutoSize = true;
            this.sendHexRadiobtn.Location = new System.Drawing.Point(172, 179);
            this.sendHexRadiobtn.Name = "sendHexRadiobtn";
            this.sendHexRadiobtn.Size = new System.Drawing.Size(44, 17);
            this.sendHexRadiobtn.TabIndex = 17;
            this.sendHexRadiobtn.TabStop = true;
            this.sendHexRadiobtn.Text = "Hex";
            this.sendHexRadiobtn.UseVisualStyleBackColor = true;
            // 
            // sendStrRadiobtn
            // 
            this.sendStrRadiobtn.AutoSize = true;
            this.sendStrRadiobtn.Location = new System.Drawing.Point(111, 179);
            this.sendStrRadiobtn.Name = "sendStrRadiobtn";
            this.sendStrRadiobtn.Size = new System.Drawing.Size(52, 17);
            this.sendStrRadiobtn.TabIndex = 16;
            this.sendStrRadiobtn.TabStop = true;
            this.sendStrRadiobtn.Text = "String";
            this.sendStrRadiobtn.UseVisualStyleBackColor = true;
            // 
            // RxTbx
            // 
            this.RxTbx.Location = new System.Drawing.Point(300, 126);
            this.RxTbx.Name = "RxTbx";
            this.RxTbx.ReadOnly = true;
            this.RxTbx.Size = new System.Drawing.Size(56, 20);
            this.RxTbx.TabIndex = 18;
            // 
            // TxTbx
            // 
            this.TxTbx.Location = new System.Drawing.Point(300, 150);
            this.TxTbx.Name = "TxTbx";
            this.TxTbx.ReadOnly = true;
            this.TxTbx.Size = new System.Drawing.Size(56, 20);
            this.TxTbx.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aboutToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(106, 48);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem1.Text = "about";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem2.Text = "、";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem2.Text = "About";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.openCloseSpbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.parityCbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stopBitsCbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataBitsCbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boaudRateCbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComListCbx);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Serial port debug assistant";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComListCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boaudRateCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dataBitsCbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stopBitsCbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox parityCbx;
        private System.Windows.Forms.Button openCloseSpbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton recHexRadiobtn;
        private System.Windows.Forms.RadioButton recStrRadiobtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearReceivebtn;
        private System.Windows.Forms.Button clearSendbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox sendtbx;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.RadioButton sendHexRadiobtn;
        private System.Windows.Forms.RadioButton sendStrRadiobtn;
        private System.Windows.Forms.TextBox TxTbx;
        private System.Windows.Forms.TextBox RxTbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

