namespace StatisticsSystem
{
  partial class LoginForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.txtName = new System.Windows.Forms.TextBox();
      this.errorProviderUser = new System.Windows.Forms.ErrorProvider(this.components);
      this.label3 = new System.Windows.Forms.Label();
      this.cobVersion = new System.Windows.Forms.ComboBox();
      this.btnIP = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).BeginInit();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.Control;
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.Location = new System.Drawing.Point(84, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 12);
      this.label2.TabIndex = 17;
      this.label2.Text = "帐 号：";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.Control;
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(84, 93);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 12);
      this.label1.TabIndex = 18;
      this.label1.Text = "密 码：";
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.Location = new System.Drawing.Point(176, 150);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(55, 23);
      this.btnCancel.TabIndex = 16;
      this.btnCancel.Text = "取消";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(155, 90);
      this.txtPassword.MaxLength = 50;
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(174, 21);
      this.txtPassword.TabIndex = 14;
      this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
      this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
      this.btnLogin.Location = new System.Drawing.Point(96, 150);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(55, 23);
      this.btnLogin.TabIndex = 15;
      this.btnLogin.Text = "确认";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(155, 38);
      this.txtName.MaxLength = 20;
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(174, 21);
      this.txtName.TabIndex = 13;
      // 
      // errorProviderUser
      // 
      this.errorProviderUser.ContainerControl = this;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(149, 207);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 12);
      this.label3.TabIndex = 19;
      this.label3.Text = "版本号：";
      this.label3.Visible = false;
      // 
      // cobVersion
      // 
      this.cobVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobVersion.FormattingEnabled = true;
      this.cobVersion.Location = new System.Drawing.Point(208, 204);
      this.cobVersion.Name = "cobVersion";
      this.cobVersion.Size = new System.Drawing.Size(121, 20);
      this.cobVersion.TabIndex = 20;
      this.cobVersion.Visible = false;
      // 
      // btnIP
      // 
      this.btnIP.Location = new System.Drawing.Point(254, 149);
      this.btnIP.Name = "btnIP";
      this.btnIP.Size = new System.Drawing.Size(75, 23);
      this.btnIP.TabIndex = 21;
      this.btnIP.Text = "服务器IP";
      this.btnIP.UseVisualStyleBackColor = true;
      this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::StatisticsSystem.Properties.Resources.headerbg;
      this.ClientSize = new System.Drawing.Size(448, 233);
      this.Controls.Add(this.btnIP);
      this.Controls.Add(this.cobVersion);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "统计报表配置平台";
      ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.ErrorProvider errorProviderUser;
    private System.Windows.Forms.ComboBox cobVersion;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnIP;
  }
}