namespace StatisticsSystem.SystemConfig
{
  partial class ChangePwdForm
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
      this.txtOldPwd = new System.Windows.Forms.TextBox();
      this.txtConfirmPwd = new System.Windows.Forms.TextBox();
      this.txtNewPwd = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(104, 39);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "原密码";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(104, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "新密码";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(104, 125);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "确认密码";
      // 
      // txtOldPwd
      // 
      this.txtOldPwd.Location = new System.Drawing.Point(187, 36);
      this.txtOldPwd.Name = "txtOldPwd";
      this.txtOldPwd.Size = new System.Drawing.Size(162, 21);
      this.txtOldPwd.TabIndex = 3;
      // 
      // txtConfirmPwd
      // 
      this.txtConfirmPwd.Location = new System.Drawing.Point(187, 122);
      this.txtConfirmPwd.Name = "txtConfirmPwd";
      this.txtConfirmPwd.Size = new System.Drawing.Size(162, 21);
      this.txtConfirmPwd.TabIndex = 4;
      this.txtConfirmPwd.UseSystemPasswordChar = true;
      // 
      // txtNewPwd
      // 
      this.txtNewPwd.Location = new System.Drawing.Point(187, 80);
      this.txtNewPwd.Name = "txtNewPwd";
      this.txtNewPwd.Size = new System.Drawing.Size(162, 21);
      this.txtNewPwd.TabIndex = 5;
      this.txtNewPwd.UseSystemPasswordChar = true;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(119, 190);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "保存";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(240, 190);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 7;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // ChangePwdForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 251);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtNewPwd);
      this.Controls.Add(this.txtConfirmPwd);
      this.Controls.Add(this.txtOldPwd);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "ChangePwdForm";
      this.Text = "修改密码";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtOldPwd;
    private System.Windows.Forms.TextBox txtConfirmPwd;
    private System.Windows.Forms.TextBox txtNewPwd;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnClose;
  }
}