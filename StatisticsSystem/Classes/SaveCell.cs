using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace StatisticsSystem.Classes
{
  public class SaveCell
  {
    /// <summary>
    /// 表头存为xml
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="Coordinates"></param>
    /// <param name="caption"></param>
    /// <param name="rowCount"></param>
    /// <param name="columnCount"></param>
    /// <param name="savePath"></param>
    public static void SaveXML(Model.XMLVERSION model,string version)
    {
      //string savePath = Path.GetPath(version);
      XmlDocument writeDoc = new XmlDocument();  //新的xml
      XmlNode root = null;
      string saveFileName = Path.GetPath(version);
      if (!File.Exists(saveFileName))//不存在文件
      {
        writeDoc.AppendChild(writeDoc.CreateXmlDeclaration("1.0", "utf-8", null));

        root = writeDoc.CreateElement("CellHeader");
        writeDoc.AppendChild(root);
      }
      else //存在文件
      {
        writeDoc.Load(saveFileName);
        root = writeDoc.DocumentElement;
        //XmlElement table = root[s_tableName];
        if (root[model.BBBM] != null)
          root.RemoveChild(root[model.BBBM]);
      }

      XmlElement tableNode = writeDoc.CreateElement(model.BBBM);
      root.AppendChild(tableNode);
      #region header
      //XmlElement headerNode = writeDoc.CreateElement("Header");
      //tableNode.AppendChild(headerNode);

      //XmlElement captionHeaderNode = writeDoc.CreateElement("caption");
      //captionHeaderNode.InnerText = "NULL";
      //headerNode.AppendChild(captionHeaderNode);

      //XmlElement coordinatesHeaderNode = writeDoc.CreateElement("Coordinates");
      //coordinatesHeaderNode.InnerText = "0,0,0,0";
      //headerNode.AppendChild(coordinatesHeaderNode);
      #endregion
      #region headercolumn
      XmlElement headerColumnNode = writeDoc.CreateElement("HeaderColumn");
      tableNode.AppendChild(headerColumnNode);

      XmlElement captionNode = writeDoc.CreateElement("caption");
      captionNode.InnerText = model.CAPTION;
      headerColumnNode.AppendChild(captionNode);

      XmlElement coordinatesNode = writeDoc.CreateElement("Coordinates");
      coordinatesNode.InnerText = model.COORDINATES;
      headerColumnNode.AppendChild(coordinatesNode);
      #endregion
      #region columnset
      XmlElement ColumnSetNode = writeDoc.CreateElement("ColumnSet");
      tableNode.AppendChild(ColumnSetNode);

      XmlElement HiddenColumnNode = writeDoc.CreateElement("HiddenColumn");
      HiddenColumnNode.InnerText = string.IsNullOrEmpty(model.HIDDENCOLUMN) ? "NULL" : model.HIDDENCOLUMN;
      ColumnSetNode.AppendChild(HiddenColumnNode);

      XmlElement HiddenRowNode = writeDoc.CreateElement("HiddenRow");
      HiddenRowNode.InnerText = string.IsNullOrEmpty(model.HIDDENROW) ? "NULL" : model.HIDDENROW;
      ColumnSetNode.AppendChild(HiddenRowNode);

      XmlElement NotAllowEditColumnNode = writeDoc.CreateElement("NotAllowEditColumn");
      NotAllowEditColumnNode.InnerText = string.IsNullOrEmpty(model.NotAllowEditColumn) ? "NULL" : model.NotAllowEditColumn;
      ColumnSetNode.AppendChild(NotAllowEditColumnNode);

      XmlElement NotAllowEditRowNode = writeDoc.CreateElement("NotAllowEditRow");
      NotAllowEditRowNode.InnerText = string.IsNullOrEmpty(model.NOTALLOWEDITROW) ? "NULL" : model.NOTALLOWEDITROW;
      ColumnSetNode.AppendChild(NotAllowEditRowNode);

      XmlElement LockCellNode = writeDoc.CreateElement("LockCell");
      LockCellNode.InnerText = model.LOCKCELL;
      ColumnSetNode.AppendChild(LockCellNode);

      XmlElement ColumnWidthNode = writeDoc.CreateElement("ColumnWidth");
      ColumnWidthNode.InnerText = "NULL";
      ColumnSetNode.AppendChild(ColumnWidthNode);

      XmlElement NameHierarchyNode = writeDoc.CreateElement("NameHierarchy");
      NameHierarchyNode.InnerText = "NULL";
      ColumnSetNode.AppendChild(NameHierarchyNode);

      var CData = writeDoc.CreateCDataSection(model.SELECTFIELD);

      XmlElement SelectFieldNode = writeDoc.CreateElement("SelectField");
      SelectFieldNode.AppendChild(CData);
      ColumnSetNode.AppendChild(SelectFieldNode);

      XmlElement OrderByNode = writeDoc.CreateElement("OrderBy");
      OrderByNode.InnerText = model.ORDERBY;
      ColumnSetNode.AppendChild(OrderByNode);

      XmlElement columnCountNode = writeDoc.CreateElement("ColumnCount");
      columnCountNode.InnerText = model.COLUMNCOUNT.ToString();
      ColumnSetNode.AppendChild(columnCountNode);

      XmlElement rowCountNode = writeDoc.CreateElement("RowCount");
      rowCountNode.InnerText = model.ROWCOUNT.ToString();
      ColumnSetNode.AppendChild(rowCountNode);
      #endregion
      XmlElement titleNode = writeDoc.CreateElement("Title");
      titleNode.InnerText = model.Title;
      tableNode.AppendChild(titleNode);

      writeDoc.Save(saveFileName);
    }

    /// <summary>
    /// 保存表头
    /// </summary>
    /// <param name="axCell1"></param>
    /// <param name="tableName"></param>
    public static void SaveCellHeader(AxCELL50Lib.AxCell axCell1, string tableName, ref string caption, ref string Coordinates)
    {
      int x = 1, xSpan = 1, y = 1, ySpan = 1;
      int startRow = 0, endRow = 0, startCol = 0, endCol = 0;
      //string caption = "", Coordinates = "";
      for (int row = 1; row < axCell1.GetRows(0); row++)
      {
        for (int col = 1; col < axCell1.GetCols(0); col++)
        {
          int isMerge = axCell1.GetMergeRange(col, row, ref startCol, ref startRow, ref endCol, ref endRow);
          if (isMerge == 1)
          {
            if ((col == startCol) && (row == startRow))//当此单元格为合并区域左上角单元格时
            {
              x = col - 1;
              y = row - 1;
              xSpan = endCol - startCol + 1;
              ySpan = endRow - startRow + 1;
              Coordinates += x.ToString() + "," + xSpan.ToString() + "," + y.ToString() + "," + ySpan.ToString() + "|";
              caption += axCell1.GetCellString(col, row, 0) + ",";
              col = endCol;
            }
          }
          else
          {
            x = col - 1;
            y = row - 1;
            xSpan = 1;
            ySpan = 1;
            Coordinates += x.ToString() + "," + xSpan.ToString() + "," + y.ToString() + "," + ySpan.ToString() + "|";
            caption += axCell1.GetCellString(col, row, 0) + ",";
          }
        }
      }
      //Coordinates += x.ToString() + "1," + y.ToString() + ",1";
      //caption += ",Rowid";
      Coordinates = Coordinates.Trim(new char[] { '|' });
      caption = caption.Substring(0, caption.Length - 1);
      //int rowCount = axCell1.GetRows(0);
      //int columnCount = axCell1.GetCols(0);
      //string savePath = Path.GetPath();
      //SaveCell.SaveXML(tableName, Coordinates, caption, rowCount.ToString(), columnCount.ToString(), savePath);
    }

    /// <summary>
    /// 表头最后一行不能有合并单元格
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public static bool IsCellLastRow(AxCELL50Lib.AxCell grid)
    {
      bool flag = true;
      int row = grid.GetRows(0) - 1;
      int startRow = 0, endRow = 0, startCol = 0, endCol = 0;
      for (int col = 1; col < grid.GetCols(0); col++)
      {
        int isMerge = grid.GetMergeRange(col, row, ref startCol, ref startRow, ref endCol, ref endRow);
        if (isMerge == 1)
        {
          if (endCol - startCol > 0)
          {
            flag = false;
            break;
          }
        }
      }
      return flag;
    }
  }
}
