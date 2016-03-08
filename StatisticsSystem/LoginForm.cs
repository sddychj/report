using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Xml;
using StatisticsSystem.TableConfig;
using StatisticsSystem.SystemConfig;

namespace StatisticsSystem
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
      BindVersion();
      InitIP();
    }

    private void BindVersion()
    {
      string[] versionList = System.Configuration.ConfigurationManager.AppSettings["Version"].ToString().Split(new char[] { ',' });
      for (int i = 0; i < versionList.Length; i++)
      {
        cobVersion.Items.Add(versionList[i]);
      }
      //BLL.XMLVERSION bll = new BLL.XMLVERSION();
      //DataSet ds = bll.GetListVersion();
      ////for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      ////{
      ////  cobVersion.Items.Add(ds.Tables[0].Rows[i]["year"].ToString());
      ////}

      //cobVersion.DataSource = ds;
      //cobVersion.DisplayMember = "DS.YEAR";
      //cobVersion.ValueMember = "DS.YEAR";
      if (cobVersion.Items.Count > 0)
      {
        cobVersion.SelectedIndex = 0;
      }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      //string s = Common.DEncrypt.DEncrypt.Encrypt("hbgctj", "qq");
      //s = Common.DEncrypt.DEncrypt.Decrypt(s, "qq");
      //MessageBox.Show(s);
      //return;
      BLL.login bll_login = new BLL.login();
      string pwd = Common.DEncrypt.DEncrypt.Encrypt(txtPassword.Text);
      if (!bll_login.checklogin(txtName.Text, pwd))
      {
        MessageBox.Show("用户名密码不正确");
        return;
      }
      //if (cobVersion.Items.Count == 0)
      //  return;
      //if (cobVersion.SelectedItem.ToString() == "")
      //{
      //  MessageBox.Show("请选择版本号");
      //  return;
      //}
      //if (IsIP(txtIP.Text))
      //{
      //  string s = @" Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + txtIP.Text + @")(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=ORA10G)));User Id=hbgctj;Password=hbgctj;";
      //  SaveConfig(s, "odp");
      //  SaveConfig(txtIP.Text, "IP");
      //  //MessageBox.Show("保存成功");
      //}
      //else
      //{
      //  MessageBox.Show("ip格式不正确");
      //  return;
      //}
      BLL.XMLVERSION bll = new BLL.XMLVERSION();
      string version = ConfigurationManager.AppSettings["csVersion"].ToString();
      if (!bll.IsQY(version))
      {
        MessageBox.Show("此版本已无效，请更新");
        return;
      }
      //DataSet ds = bll.GetMaxVersion();
      //ds.WriteXml("d;\\a.xml");
      //string version = "";
      //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      //{
      //  version += ds.Tables[0].Rows[i]["year"].ToString() + ",";
      //}
      //version = version.Trim(new char[] { ',' });
      //SaveConfig(version, "Version");
      this.Hide();
      MainForm.Current.Version = Convert.ToInt32(ConfigurationManager.AppSettings["version"].ToString());
      MainForm.Current.Loginname = txtName.Text;
      MainForm.Current.ShowDialog();
      Common.Control.FormCommon.ShowSingleWindow(typeof(NewForm), MainForm.Current, "");
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();

    }

    private void txtPassword_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        btnLogin_Click(this, null);
      }

    }

    private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.errorProviderUser.Clear();

    }

    private void InitIP()
    {
      //string ip = System.Configuration.ConfigurationManager.AppSettings["IP"].ToString();
      //txtIP.Text = ip;
    }

    public bool IsIP(string ip)
    {
      //判断是否为IP
      return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
    }

    //第一个参数是xml文件中的add节点的value，第二个参数是add节点的key  
    private void SaveConfig(string ConnenctionString, string strKey)
    {
      XmlDocument doc = new XmlDocument();
      //获得配置文件的全路径  
      //string strFileName = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
      string strFileName = AppDomain.CurrentDomain.BaseDirectory + "\\StatisticsSystem.exe.config";
      doc.Load(strFileName);
      //找出名称为“add”的所有元素  
      XmlNodeList nodes = doc.GetElementsByTagName("add");
      for (int i = 0; i < nodes.Count; i++)
      {
        //获得将当前元素的key属性  
        XmlAttribute att = nodes[i].Attributes["key"];
        //根据元素的第一个属性来判断当前的元素是不是目标元素  
        if (att.Value == strKey)
        {
          //对目标元素中的第二个属性赋值  
          att = nodes[i].Attributes["value"];
          att.Value = ConnenctionString;
          break;
        }
      }
      //保存上面的修改  
      doc.Save(strFileName);
      System.Configuration.ConfigurationManager.RefreshSection("appSettings");
    }

    private void btnIP_Click(object sender, EventArgs e)
    {
      DatabaseConfigForm form = new DatabaseConfigForm();
      form.ShowDialog();
      this.Close();
    }
  }
}
