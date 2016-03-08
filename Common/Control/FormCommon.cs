using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Control
{
  public class FormCommon
  {
    public static void ShowSingleWindow(Type type, Form MdiForm,string text)
    {
      //foreach (Form f in this.MdiChildren)
      //{
      //  if (f.GetType() == type)
      //  {
      //    f.Activate();
      //    return;
      //  }
      //}
      Form frm = type.Assembly.CreateInstance(type.ToString()) as Form;
      frm.MdiParent = MdiForm;
      frm.WindowState = FormWindowState.Normal;
      //if (text == "")
      //  frm.Text = "新报表" + (MdiForm.MdiChildren.Length).ToString();
      //else
      //  frm.Text = text;
      frm.Show();
    }
  }
}
