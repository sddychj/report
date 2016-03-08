using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculateTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DateTime now1 = System.DateTime.Now;
      for (int i = 0; i < 400; i++)
      {
        //string j = StatisticsSystem.Calculate.CalculateCell.calculate("CL0002", "CL00020007", "COL6", "HG", "2014", "12");
        StatisticsSystem.Calculate.CalculateCell.UpdateTest();
      }
      DateTime now2 = System.DateTime.Now;
      TimeSpan t = now2 - now1;
      MessageBox.Show(t.TotalMilliseconds.ToString());
    }
  }
}
