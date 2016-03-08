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

namespace StatisticsSystem.SystemConfig
{
  public partial class DatabaseConfigForm : Form
  {
    public DatabaseConfigForm()
    {
      InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      //if (IsIP(txtIP.Text))
      //{
        //        Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //        appConfig.AppSettings.Settings["odp"].Value = @" Data Source=(DESCRIPTION=
        //          (ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + txtIP.Text + @")(PORT=1521)))
        //          (CONNECT_DATA=(SERVICE_NAME=ORA10G)));
        //          User Id=hbgctj;Password=hbgctj;";
        //        appConfig.Save();
        //        ConfigurationManager.RefreshSection("appSettings");
        //string s = @" Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + txtIP.Text + @")(PORT="
        //  + txtPort.Text + @")))(CONNECT_DATA=(SERVICE_NAME=" + txtService.Text + ")));User Id="
        //  + txtUsername.Text + ";Password=" + txtPWD.Text + ";";
        string username = Common.DEncrypt.DEncrypt.Encrypt(txtUsername.Text, "qq");
        SaveConfig(username, "username");
        string pwd = Common.DEncrypt.DEncrypt.Encrypt(txtPWD.Text, "qq");
        SaveConfig(pwd, "pwd");
        string port = Common.DEncrypt.DEncrypt.Encrypt(txtPort.Text, "qq");
        SaveConfig(port, "port");
        string ip = Common.DEncrypt.DEncrypt.Encrypt(txtIP.Text, "qq");
        SaveConfig(ip, "ip");
        string db = Common.DEncrypt.DEncrypt.Encrypt(txtService.Text, "qq");
        SaveConfig(db, "db");

        MessageBox.Show("保存成功");
      //}
      //else
      //{
      //  MessageBox.Show("格式不正确");
      //}
    }
    public bool IsIP(string ip)
    {
      //判断是否为IP
      return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
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
  }
}
