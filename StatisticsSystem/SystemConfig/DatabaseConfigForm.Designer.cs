namespace StatisticsSystem.SystemConfig
{
  partial class DatabaseConfigForm
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
      this.lable1 = new System.Windows.Forms.Label();
      this.txtIP = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtService = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPWD = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lable1
      // 
      this.lable1.AutoSize = true;
      this.lable1.Location = new System.Drawing.Point(101, 23);
      this.lable1.Name = "lable1";
      this.lable1.Size = new System.Drawing.Size(65, 12);
      this.lable1.TabIndex = 0;
      this.lable1.Text = "服务器地址";
      // 
      // txtIP
      // 
      this.txtIP.Location = new System.Drawing.Point(194, 20);
      this.txtIP.Name = "txtIP";
      this.txtIP.Size = new System.Drawing.Size(152, 21);
      this.txtIP.TabIndex = 1;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(116, 186);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "保存";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(241, 186);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 8;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(101, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 12);
      this.label1.TabIndex = 5;
      this.label1.Text = "服务名";
      // 
      // txtService
      // 
      this.txtService.Location = new System.Drawing.Point(194, 54);
      this.txtService.Name = "txtService";
      this.txtService.Size = new System.Drawing.Size(100, 21);
      this.txtService.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(101, 86);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 12);
      this.label2.TabIndex = 7;
      this.label2.Text = "端口";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(101, 117);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 12);
      this.label3.TabIndex = 8;
      this.label3.Text = "用户名";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(101, 147);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 12);
      this.label4.TabIndex = 9;
      this.label4.Text = "密码";
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(194, 86);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(100, 21);
      this.txtPort.TabIndex = 3;
      // 
      // txtUsername
      // 
      this.txtUsername.Location = new System.Drawing.Point(194, 117);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(100, 21);
      this.txtUsername.TabIndex = 4;
      // 
      // txtPWD
      // 
      this.txtPWD.Location = new System.Drawing.Point(194, 147);
      this.txtPWD.Name = "txtPWD";
      this.txtPWD.Size = new System.Drawing.Size(100, 21);
      this.txtPWD.TabIndex = 5;
      // 
      // DatabaseConfigForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(466, 245);
      this.Controls.Add(this.txtPWD);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.txtPort);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtService);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtIP);
      this.Controls.Add(this.lable1);
      this.Name = "DatabaseConfigForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "服务器连接配置";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lable1;
    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtService;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPort;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPWD;
  }
}