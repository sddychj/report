using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem
{
  public partial class Form2 : Form,Form1.ICipherInputForm
  {//Tools为你子窗体的工具栏.注意将其Visible = false;
    public ToolStrip CipherToolStrip
    {
      get
      {
        return Tools;
      }
    }
    public Form2()
    {
      InitializeComponent();
    }
  }
}
