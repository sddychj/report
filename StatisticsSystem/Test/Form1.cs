using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using System.Reflection;
using System.Net;
using System.IO;

//[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace StatisticsSystem
{
  public partial class Form1 : Form
  {
    public interface ICipherInputForm
    {
      ToolStrip CipherToolStrip
      {
        get;
      }
    }
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //c_calculate.calculate();
      //double d = c_calculate.GetCalculateResult("1+2+3+4");
      //DateTime now1 = System.DateTime.Now;
      //string i = StatisticsSystem.Calculate.CalculateCell.calculate("CL0017", "CL00170002", "COL3", "HG", "2013", "12");
      //DateTime now2 = System.DateTime.Now;
      //TimeSpan t = now2 - now1;
      //MessageBox.Show(i);
      //MessageBox.Show(getPage("http://10.67.221.1:7777"));
      //Calculate.WriteUpdateInfor write = new Calculate.WriteUpdateInfor();
      //MessageBox.Show(write.write());

    }
    public string getPage(String url)
    {
      WebResponse result = null;

      WebRequest req = WebRequest.Create(url);
      result = req.GetResponse();
      Stream ReceiveStream = result.GetResponseStream();

      //read the stream into a string
      StreamReader sr = new StreamReader(ReceiveStream);
      string resultstring = sr.ReadToEnd();
      result.Close();
      return resultstring;
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      Form2 f = new Form2();
      f.MdiParent = this;
      f.Show();

    }

    private void Form1_MdiChildActivate(object sender, EventArgs e)
    {
      //CTools为MDI窗体工具栏
      ToolStripManager.RevertMerge(CTools);
      if (this.ActiveMdiChild != null)
      {
        if ((ActiveMdiChild as ICipherInputForm).CipherToolStrip != null)
        {
          ToolStripManager.Merge((ActiveMdiChild as ICipherInputForm).CipherToolStrip, CTools);
        }
      }
      //若子窗体无工具栏时,隐藏该工具栏
      if (CTools.Items.Count > 0)
        CTools.Visible = true;
      else
        CTools.Visible = false;
    }
  }
}
