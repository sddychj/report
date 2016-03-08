using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem.SystemConfig
{
  public partial class ChangePwdForm : Form
  {
    public ChangePwdForm()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtNewPwd.Text))
      {
        MessageBox.Show("新密码不能为空");
        return;
      }
      BLL.login bll_login = new BLL.login();
      if (!bll_login.checklogin("admin", Common.DEncrypt.DEncrypt.Encrypt(txtOldPwd.Text)))
      {
        MessageBox.Show("原密码不正确");
        return;
      }
      if (txtNewPwd.Text != txtConfirmPwd.Text)
      {
        MessageBox.Show("确认密码不一致");
        return;
      }
      if (bll_login.update("admin", Common.DEncrypt.DEncrypt.Encrypt(txtNewPwd.Text)))
      {
        MessageBox.Show("保存成功");

      }
      else
      { MessageBox.Show("保存失败"); }
    }
  }
}
