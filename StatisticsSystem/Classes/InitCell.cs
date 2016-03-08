using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;
//using myMultiColHeaderDgv;

namespace StatisticsSystem.Classes
{
  public class InitCell
  {
    public static string ExcelToXml(string sheetName, string tableName, string savePath)
    {
      string s_return = "";
      string sousePath = Application.StartupPath + "\\GridHeader.xml";
      if (!File.Exists(sousePath))
      {
        return "文件不存在";
      }

      XmlDocument xmlDoc = new XmlDocument(); //加载的xml
      xmlDoc.Load(sousePath);

      XmlNodeList nodeList_ws = xmlDoc.GetElementsByTagName("Worksheet");
      string workSheet = "";
      foreach (XmlElement node_ws in nodeList_ws) //循环worksheet
      {
        if (sheetName == node_ws.GetAttribute("ss:Name")) //当前worksheet
        {
          workSheet = node_ws.GetAttribute("ss:Name");

          XmlDocument xmlDoc_write = new XmlDocument();  //新的xml
          XmlNode root = null;
          string s_saveName = savePath + "\\" + "GridHeader.xml";
          if (!File.Exists(s_saveName))//不存在文件
          {
            xmlDoc_write.AppendChild(xmlDoc_write.CreateXmlDeclaration("1.0", "utf-8", null));

            root = xmlDoc_write.CreateElement("CellHeader");
            xmlDoc_write.AppendChild(root);
          }
          else //存在文件
          {
            xmlDoc_write.Load(s_saveName);
            root = xmlDoc_write.DocumentElement;
            //XmlElement table = root[s_tableName];
            root.RemoveChild(root[tableName]);
          }

          XmlElement table = xmlDoc_write.CreateElement(tableName);
          root.AppendChild(table);

          XmlElement headerColumn = xmlDoc_write.CreateElement("HeaderColumn");
          table.AppendChild(headerColumn);

          XmlElement table_reade = node_ws["Table"];

          XmlElement columnCount = xmlDoc_write.CreateElement("ColumnCount");
          columnCount.InnerText = table_reade.GetAttribute("ss:ExpandedColumnCount");
          headerColumn.AppendChild(columnCount);
          XmlElement rowCount = xmlDoc_write.CreateElement("RowCount");
          rowCount.InnerText = table_reade.GetAttribute("ss:ExpandedRowCount");
          headerColumn.AppendChild(rowCount);

          XmlNodeList nodeList_row = table_reade.ChildNodes;
          string sCaption = "", sCoordinates = "";
          int x = 0, y = 0, x_span = 0, y_span = 0;
          string s_x = "", s_y = "";
          foreach (XmlNode node_row in nodeList_row)//循环row节点
          {
            if (node_row.Name == "Row")
            {
              XmlNodeList nodeList_cell = node_row.ChildNodes;
              foreach (XmlElement node_cell in nodeList_cell)//循环cell节点
              {
                sCaption += string.IsNullOrEmpty(node_cell.InnerText) ? " " : node_cell.InnerText + ",";

                s_x = node_cell.GetAttribute("ss:Index");
                if (!string.IsNullOrEmpty(s_x))
                  x = Convert.ToInt32(s_x) - 1;
                s_x = node_cell.GetAttribute("ss:MergeAcross");
                x_span = string.IsNullOrEmpty(s_x) ? 1 : Convert.ToInt32(s_x) + 1;
                s_y = node_cell.GetAttribute("ss:MergeDown");
                y_span = string.IsNullOrEmpty(s_y) ? 1 : Convert.ToInt32(s_y) + 1;
                sCoordinates += x.ToString() + "," + x_span.ToString() + "," + y.ToString() + "," + y_span.ToString() + "|";
                x += x_span;
              }
              y++;
              x = 0;
            }
          }

          XmlElement caption = xmlDoc_write.CreateElement("Caption");
          caption.InnerText = sCaption.Trim(new char[] { ',' });
          headerColumn.AppendChild(caption);

          XmlElement coordinates = xmlDoc_write.CreateElement("Coordinates");
          coordinates.InnerText = sCoordinates.Trim(new char[] { '|' });
          headerColumn.AppendChild(coordinates);

          xmlDoc_write.Save(s_saveName);
          s_return = "保存成功";
        }
      }
      if (workSheet == "")
      {
        s_return = "Excel中没有此Sheet名";
      }
      return s_return;

    }

    private bool isHeader(AxCELL50Lib.AxCell grid)
    {
      bool flag = false;

      int startRow = 0, startCol = 0, endRow = 0, endCol = 0;
      grid.GetSelectRange(ref startCol, ref startRow, ref endCol, ref endRow);
      for (int i = 1; i < grid.GetCols(0); i++)
      {
        int input = grid.GetCellInput(i, startRow, 0);
        if (input == 5)
        {
          return true;
        }
      }
      return flag;
    }

    public static string CreateTreeView(string sousePath, TreeView treeView2, string tableName)
    {
      if (!File.Exists(sousePath))
      {
        return "文件不存在";
      }
      XmlDocument xmlDoc = new XmlDocument(); //加载的xml
      xmlDoc.Load(sousePath);

      XmlElement xe_root = xmlDoc.DocumentElement;
      XmlElement xe_table = xe_root[tableName];
      XmlElement xe_HeaderColumn = xe_table["HeaderColumn"];
      XmlElement xe_Caption = xe_HeaderColumn["Caption"];
      XmlElement xe_Coordinates = xe_HeaderColumn["Coordinates"];

      XmlElement columnCountXE = xe_HeaderColumn["ColumnCount"];
      string columnCountStr = columnCountXE.InnerText;
      for (int i = 0; i < Convert.ToInt32(columnCountStr); i++)
      {

      }

      string s_Caption = xe_Caption.InnerText;
      string s_Coordinates = xe_Coordinates.InnerText;
      string[] sl_Caption = s_Caption.Split(new char[] { ',' });
      string[] sl_Coordinates = s_Coordinates.Split(new char[] { '|' });

      treeView2.Nodes.Clear();
      TreeNode[] node_list = new TreeNode[sl_Coordinates.Length];
      for (int i = 0; i < sl_Coordinates.Length; i++)
      {
        TreeNode node0 = new TreeNode();
        string[] sl_Coordinates_Cell = sl_Coordinates[i].Split(new char[] { ',' });
        if (sl_Coordinates_Cell[2] == "0") //当第一行时
        {
          node0.Text = sl_Caption[i];
          treeView2.Nodes.Add(node0);
          node_list[i] = node0;
        }
        else //当不为第一行时
        {
          node0 = node_list[i];
        }
        int x = Convert.ToInt32(sl_Coordinates_Cell[0]);
        int x_span = Convert.ToInt32(sl_Coordinates_Cell[1]);
        int y = Convert.ToInt32(sl_Coordinates_Cell[2]);
        for (int j = i + 1; j < sl_Coordinates.Length; j++)
        {
          string[] sl_next = sl_Coordinates[j].Split(new char[] { ',' });
          int x_next = Convert.ToInt32(sl_next[0]);
          int y_next = Convert.ToInt32(sl_next[2]);
          if ((x_next >= x) && x_next < (x + x_span) && (y == y_next - 1))//当此处单元格为上一节点子节点时
          {
            TreeNode node1 = new TreeNode();
            node1.Text = sl_Caption[j];
            node0.Nodes.Add(node1);
            node_list[j] = node1;
          }
        }
      }
      return "";
    }

    /// <summary>
    /// 初始化表头
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="tableName">表名</param>
    /// <param name="cellHeaderRowCount">返回表头行数</param>
    /// <returns></returns>
    public static string InitCellHeaderFromXml(AxCELL50Lib.AxCell grid, string tableName, ref int cellHeaderRowCount)
    {
      string returnStr = "";
      string sousePath = Path.GetPath(MainForm.Current.Version.ToString());
      if (!File.Exists(sousePath))
      {
        return "文件不存在";
      }
      XmlDocument xmlDoc = new XmlDocument(); //加载的xml
      xmlDoc.Load(sousePath);

      XmlElement root = xmlDoc.DocumentElement;
      XmlElement tableNode = root[tableName];
      if (tableNode == null)
      {
        return "节点不存在";
      }
      XmlElement headerColumn = tableNode["HeaderColumn"];
      XmlElement caption = headerColumn["Caption"];
      XmlElement coordinates = headerColumn["Coordinates"];
      XmlElement columnCount = headerColumn["ColumnCount"];
      XmlElement rowCount = headerColumn["RowCount"];
      cellHeaderRowCount = Convert.ToInt32(rowCount.InnerText);
      string captionStr = caption.InnerText;
      string coordinatesStr = coordinates.InnerText;
      string[] captionList = captionStr.Split(new char[] { ',' });
      string[] coordinatesList = coordinatesStr.Split(new char[] { '|' });
      for (int i = 0; i < coordinatesList.Length; i++)
      {
        string[] sl_Coordinates_Cell = coordinatesList[i].Split(new char[] { ',' });
        int x = Convert.ToInt32(sl_Coordinates_Cell[0]);
        int x_span = Convert.ToInt32(sl_Coordinates_Cell[1]);
        int y = Convert.ToInt32(sl_Coordinates_Cell[2]);
        int y_span = Convert.ToInt32(sl_Coordinates_Cell[3]);
        grid.MergeCells(x + 1, y + 1, x + x_span, y + y_span);
        grid.SetCellString(x + 1, y + 1, 0, captionList[i]);
        grid.SetCellAlign(x + 1, y + 1, 0, 4);
        grid.SetCellFontSize(x + 1, y + 1, 0, 15);
        grid.SetCellInput(x + 1, y + 1, 0, 5);
      }
      for (int i = 0; i < grid.GetRows(0); i++)
      {
        int width = grid.GetColBestWidth(i);
        grid.SetColWidth(1, width, i, 0);
      }
      for (int i = 0; i < grid.GetCols(0); i++)
      {
        int height = grid.GetRowBestHeight(i);
        grid.SetRowHeight(1, height, i, 0);
      }
      grid.SetCols(Convert.ToInt32(columnCount.InnerText) + 1 + 1, 0);//增加一列，指标编码

      return returnStr;
    }

    public static void InitCellHeader(AxCELL50Lib.AxCell grid, Model.XMLVERSION model)
    {
      string captionStr = model.CAPTION;
      string coordinatesStr = model.COORDINATES;
      string[] captionList = captionStr.Split(new char[] { ',' });
      string[] coordinatesList = coordinatesStr.Split(new char[] { '|' });
      //int color = ((51 * 256) + 177) * 256 + 204;
      for (int i = 0; i < coordinatesList.Length; i++)
      {
        string[] sl_Coordinates_Cell = coordinatesList[i].Split(new char[] { ',' });
        int x = Convert.ToInt32(sl_Coordinates_Cell[0]);
        int x_span = Convert.ToInt32(sl_Coordinates_Cell[1]);
        int y = Convert.ToInt32(sl_Coordinates_Cell[2]);
        int y_span = Convert.ToInt32(sl_Coordinates_Cell[3]);
        grid.MergeCells(x + 1, y + 1, x + x_span, y + y_span);
        grid.SetCellString(x + 1, y + 1, 0, captionList[i]);
        grid.SetCellAlign(x + 1, y + 1, 0, 4);
        grid.SetCellFontSize(x + 1, y + 1, 0, 12);

        //grid.SetCellInput(x + 1, y + 1, 0, 5);

        //grid.SetCellBackColor(x + 1, y + 1, 0, grid.FindColorIndex(color, 1));
      }
      for (int i = 0; i < grid.GetRows(0); i++)
      {
        int height = grid.GetRowBestHeight(i);
        grid.SetRowHeight(1, height, i, 0);
      }
      for (int i = 0; i < grid.GetCols(0); i++)
      {
        int width = grid.GetColBestWidth(i);
        grid.SetColWidth(1, width, i, 0);
      }
      grid.SetFixedRow(1, model.ROWCOUNT);
      //grid.SetCols(Convert.ToInt32(model.COLUMNCOUNT) + 1 + 1, 0);//增加一列，指标编码

    }

    /// <summary>
    /// 初始化指标
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="tableNum"></param>
    /// <param name="rowCount"></param>
    public static void InitCellIndex(AxCELL50Lib.AxCell grid, string tableNum, int rowCount)
    {
      BLL.ENCO_ZBBMB bll = new BLL.ENCO_ZBBMB();
      List<Model.ENCO_ZBBMB> modelList = bll.GetModelList(" bbbm='" + tableNum + "' ");
      for (int startRow = 0; startRow < modelList.Count; startRow++)
      {
        grid.SetRows(modelList.Count + 1 + rowCount, 0);
        Model.ENCO_ZBBMB model = modelList[startRow];
        if (model == null)
          return;
        grid.SetCellString(5, startRow + 1 + rowCount, 0, model.ZBMC);
        grid.SetCellString(grid.GetCols(0) - 1, startRow + 1 + rowCount, 0, model.ZBBM);
      }
    }

    /// <summary>
    /// 初始化公式
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="BBBM"></param>
    /// <param name="columnName"></param>
    /// <param name="cellHeaderRowCount"></param>
    public static void InitCellFormula(AxCELL50Lib.AxCell grid, string BBBM, string year, string month, string dwbm,
      string[] columnName, int cellHeaderRowCount, int[,] jsxxid)
    {
      StatisticsSystem.BLL.ENCO_JSXX bll = new BLL.ENCO_JSXX();
      Dictionary<string, Model.ENCO_JSXX> jsxx = bll.GetJSxxHash(BBBM, year, month, dwbm);
      string key = "";
      Model.ENCO_JSXX value = new Model.ENCO_JSXX();
      for (int startRow = cellHeaderRowCount + 1; startRow < grid.GetRows(0); startRow++)
      {
        for (int startCol = 0; startCol < columnName.Length; startCol++)
        {
          key = BBBM + "|" + grid.GetCellString(grid.GetCols(0) - 1, startRow, 0) + "|" + columnName[startCol];
          if (jsxx.ContainsKey(key))
          {
            value = jsxx[key];
            grid.SetCellString(startCol + 1, startRow, 0, value.JSMS);
            jsxxid[startRow, startCol + 1] = Convert.ToInt32(value.JSXXID);
          }
        }
      }
    }
    /// <summary>
    /// 整列公式
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="BBBM"></param>
    /// <param name="year"></param>
    /// <param name="month"></param>
    /// <param name="dwbm"></param>
    /// <param name="columnName"></param>
    /// <param name="cellHeaderRowCount"></param>
    /// <param name="jsxxid"></param>
    public static void InitCellFormulaCol(AxCELL50Lib.AxCell grid, string BBBM, string year, string month, string dwbm,
      string[] columnName, int cellHeaderRowCount, int[,] jsxxid)
    {
      StatisticsSystem.BLL.ENCO_JSXX_COL bll = new BLL.ENCO_JSXX_COL();
      Dictionary<string, Model.ENCO_JSXX_COL> jsxx = bll.GetJSxxHash(BBBM, year, month, dwbm);
      string key = "";
      Model.ENCO_JSXX_COL value = new Model.ENCO_JSXX_COL();
      for (int startRow = cellHeaderRowCount + 1; startRow < cellHeaderRowCount + 2; startRow++)
      {
        for (int startCol = 0; startCol < columnName.Length; startCol++)
        {
          key = BBBM + "|" + columnName[startCol];
          if (jsxx.ContainsKey(key))
          {
            value = jsxx[key];
            grid.SetCellString(startCol + 1, startRow, 0, value.JSMS);
            jsxxid[0, startCol + 1] = Convert.ToInt32(value.JSXXID);
          }
        }
      }
    }

    //根据数字顺序号得到字母
    public static string GetChar(int num)
    {
      string s = "";
      char c = 'A';
      if (num / 26 > 0)
      {
        for (int i = 0; i < num / 26; i++)
        {
          c = Convert.ToChar('A' + i);
        }
        s += c;
      }
      for (int j = 0; j < num % 26; j++)
      {
        c = Convert.ToChar('A' + j);
      }
      s += c;
      return s.ToString();
    }

    /// <summary>
    /// 校验公式
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="BBBM"></param>
    /// <param name="columnName"></param>
    /// <param name="cellHeaderRowCount"></param>
    /// <param name="jsxxid"></param>
    //public static void InitCellCheck(AxCELL50Lib.AxCell grid, string BBBM, string[] columnName, int cellHeaderRowCount, int[,] jsxxid)
    //{
    //  StatisticsSystem.BLL.ENCO_JSXX bll = new BLL.ENCO_JSXX();
    //  Dictionary<string, Model.ENCO_JSXX> jsxx = bll.GetHash(BBBM);
    //  string key = "";
    //  Model.ENCO_JSXX value = new Model.ENCO_JSXX();
    //  for (int startRow = cellHeaderRowCount + 1; startRow < grid.GetRows(0); startRow++)
    //  {
    //    for (int startCol = 0; startCol < columnName.Length; startCol++)
    //    {
    //      key = BBBM + "|" + grid.GetCellString(grid.GetCols(0) - 1, startRow, 0) + "|" + columnName[startCol];
    //      if (jsxx.ContainsKey(key))
    //      {
    //        value = jsxx[key];
    //        grid.SetCellString(startCol + 1, startRow, 0, value.JSMS);
    //        jsxxid[startRow, startCol + 1] = Convert.ToInt32(value.JSXXID);
    //      }
    //    }
    //  }
    //}
  }
}
