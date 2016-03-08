using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.IO;

namespace ExcelExport
{
  public class ExcelExport
  {
    /// <summary>
    /// 获取excel格式xml字符串
    /// </summary>
    /// <param name="path">excel模板路径</param>
    /// <param name="dsData">excel数据，由多个datatalbe组成，tablename与excel中sheet名称存在对应关系</param>
    /// <returns>返回excel格式xml字符串</returns>
    public string GetExcelXml(string path, DataSet dsData)
    {
      string xml = "";
      if (!File.Exists(path))//不存在文件
      {
        return "不存在文件";
      }
      XmlDocument doc = new XmlDocument();  //新的xml
      doc.Load(path);
      XmlNode workbook = doc.DocumentElement;
      //xml命名空间，SelectSingleNode使用
      XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
      nsmgr.AddNamespace("a", "urn:schemas-microsoft-com:office:spreadsheet");
      nsmgr.AddNamespace("b", "urn:schemas-microsoft-com:office:spreadsheet");
      nsmgr.AddNamespace("c", "urn:schemas-microsoft-com:office:excel");

      XmlNodeList sheets = workbook.ChildNodes;
      //循环sheet
      for (int tableIndex = 0; tableIndex < dsData.Tables.Count; tableIndex++)
      {
        string tableName = dsData.Tables[tableIndex].TableName;
        foreach (XmlNode sheet in sheets)
        {
          if (sheet.Name == "Worksheet")
          {
            //先将所有sheet隐藏
            XmlElement workSheetOption = (XmlElement)sheet.SelectSingleNode("c:WorksheetOptions", nsmgr);
            XmlElement visible = doc.CreateElement("Visible", sheet.NamespaceURI);
            visible.InnerText = "SheetHidden";
            workSheetOption.InsertAfter(visible, workSheetOption.FirstChild);
            //取消select节点
            XmlElement select = (XmlElement)workSheetOption.SelectSingleNode("c:Selected", nsmgr);
            if (select != null)
            {
              workSheetOption.RemoveChild(select);
            }

            string sheetName = sheet.Attributes["ss:Name"].Value;
            //当dt中存在此sheet时，显示并初始化数据
            if (sheetName == tableName)
            {
              //取消隐藏
              workSheetOption.RemoveChild(visible);
              //设置隐藏
              workSheetOption.InsertAfter(select, workSheetOption.FirstChild);

              DataTable dt = dsData.Tables[tableIndex];
              //调整行数与列数
              XmlElement table = (XmlElement)sheet.SelectSingleNode("a:Table", nsmgr);
              XmlAttribute attTableColCount = table.GetAttributeNode("ss:ExpandedColumnCount");
              attTableColCount.Value = int.Parse(attTableColCount.Value) > dt.Columns.Count ?
                attTableColCount.Value : dt.Columns.Count.ToString();
              XmlAttribute attTableRowCount = table.GetAttributeNode("ss:ExpandedRowCount");
              attTableRowCount.Value = (int.Parse(attTableRowCount.Value) + dt.Rows.Count).ToString();
              //循环行数据
              foreach (DataRow dr in dt.Rows)
              {
                XmlElement row = doc.CreateElement("Row", table.NamespaceURI);
                table.AppendChild(row);
                XmlAttribute attRowHeight = doc.CreateAttribute("ss", "AutoFitHeight", row.NamespaceURI);
                attRowHeight.Value = "0";
                row.Attributes.Append(attRowHeight);
                //循环列
                for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                {
                  XmlElement cell = doc.CreateElement("Cell", table.NamespaceURI);
                  row.AppendChild(cell);
                  //XmlAttribute attCellID = doc.CreateAttribute("ss", "StyleID", table.NamespaceURI);
                  //attCellID.Value = "s40";
                  //cell.Attributes.Append(attCellID);
                  XmlElement data = doc.CreateElement("Data", table.NamespaceURI);
                  data.InnerText = dr[colIndex].ToString();
                  cell.AppendChild(data);
                  XmlAttribute attDataType = doc.CreateAttribute("ss", "Type", table.NamespaceURI);
                  string type = dt.Columns[colIndex].DataType.ToString();
                  attDataType.Value = type == "System.Int32" ? "Number" : "String";
                  data.Attributes.Append(attDataType);
                }
              }
            }
          }
        }
      }
      xml = doc.OuterXml;
      return xml;
    }
  }
}
