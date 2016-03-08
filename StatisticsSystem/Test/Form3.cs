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
  public partial class Form3 : Form
  {
    public Form3()
    {
      InitializeComponent();
      test();
    }

    public void test()
    {
      string xml = @" <?xml version=""1.0"" encoding=""utf-8""?> <Database Version=""1""> <Table> <Row> <Col>name</Col> 
        <Col Type=""Integer"">18</Col> <Col>jijiji</Col> </Row> <Row> <Col>name2</Col> <Col Type=""Integer"">23</Col> 
      <Col>chengmeng</Col> </Row> <Row> <Col>name</Col> <Col Type=""Integer"">11</Col> <Col>xiao</Col> </Row> 
        </Table> </Database></P> 
";
      string path = Application.StartupPath + "\\XMLFile1.xml";
      int n = axCell1.RSDefXmlSet("aaa", xml, 2);
      axCell1.SetDropwndCell(1, 1, 0, n, 0, 1);
      //axCell1.SetDroplistCell2(1, 1, 0, 0, 1);
    }
  }
}
