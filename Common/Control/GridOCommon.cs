using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Control
{
  public class GridOCommon
  {
    /// <summary>
    /// 实现粘贴功能，将剪贴板中的内容粘贴到DataGridView中
    /// </summary>
    /// <param name="dgv_Test"></param>  
    public static void PasteData(DataGridView dgv_Test)
    {
      try
      {
        string clipboardText = Clipboard.GetText(); //获取剪贴板中的内容
        if (string.IsNullOrEmpty(clipboardText))
        {
          return;
        }
        int colnum = 0;
        int rownum = 0;
        for (int i = 0; i < clipboardText.Length; i++)
        {
          if (clipboardText.Substring(i, 1) == "\t")
          {
            colnum++;
          }
          if (clipboardText.Substring(i, 1) == "\n")
          {
            rownum++;
          }
        }
        //粘贴板上的数据来源于EXCEL时，每行末尾都有\n，来源于DataGridView是，最后一行末尾没有\n
        if (clipboardText.Substring(clipboardText.Length - 1, 1) == "\n")
        {
          rownum--;
        }
        colnum = colnum / (rownum + 1);
        object[,] data; //定义object类型的二维数组
        data = new object[rownum + 1, colnum + 1];  //根据剪贴板的行列数实例化数组
        string rowStr = "";
        //对数组各元素赋值
        for (int i = 0; i <= rownum; i++)
        {
          for (int j = 0; j <= colnum; j++)
          {
            //一行中的其它列
            if (j != colnum)
            {
              rowStr = clipboardText.Substring(0, clipboardText.IndexOf("\t"));
              clipboardText = clipboardText.Substring(clipboardText.IndexOf("\t") + 1);
            }
            //一行中的最后一列
            if (j == colnum && clipboardText.IndexOf("\r") != -1)
            {
              rowStr = clipboardText.Substring(0, clipboardText.IndexOf("\r"));
            }
            //最后一行的最后一列
            if (j == colnum && clipboardText.IndexOf("\r") == -1)
            {
              rowStr = clipboardText.Substring(0);
            }
            data[i, j] = rowStr;
          }
          //截取下一行及以后的数据
          clipboardText = clipboardText.Substring(clipboardText.IndexOf("\n") + 1);
        }
        //获取当前选中单元格的列序号
        int colIndex = dgv_Test.CurrentRow.Cells.IndexOf(dgv_Test.CurrentCell);
        //获取当前选中单元格的行序号
        int rowIndex = dgv_Test.CurrentRow.Index;
        //dgv_Test.Rows.Clear();
        for (int i = 0; i <= rownum; i++)
        {
          if (i + rowIndex >= dgv_Test.Rows.Count - 1)
          {
            DataGridViewRow row = (DataGridViewRow)dgv_Test.RowTemplate.Clone();
            for (int j = 0; j <= colnum; j++)
            {
              DataGridViewTextBoxCell cellid = new DataGridViewTextBoxCell();
              cellid.Value = data[i, j];
              row.Cells.Add(cellid);
            }
            dgv_Test.Rows.Add(row);
          }
          else
          {
            for (int j = 0; j <= colnum; j++)
            {
              dgv_Test.Rows[i + rowIndex].Cells[j + colIndex].Value = data[i, j];
            }
          }
        }
      }
      catch
      {
        System.Windows.Forms.MessageBox.Show("粘贴区域大小不一致");
        return;
      }
    }
    /// <summary>
    /// 实现复制功能，将DataGridView中选定单元格的值复制到剪贴板中
    /// </summary>
    /// <param name="dgv_Test"></param>
    public static void CopyData(DataGridView dgv_Test)
    {
      Clipboard.SetDataObject(dgv_Test.GetClipboardContent());
    }
    /// <summary>
    /// 实现剪切功能，将DataGridView中选定单元格的值复制到剪贴板中，并将选中的单元格的值清空
    /// </summary>
    /// <param name="dgv_Test"></param>
    public static void CutData(DataGridView dgv_Test)
    {
      //将选定单元格的值复制到剪贴板中
      Clipboard.SetDataObject(dgv_Test.GetClipboardContent());

      string clipboardText = Clipboard.GetText(); //获取剪贴板的内容
      if (string.IsNullOrEmpty(clipboardText))
      {
        return;
      }
      int colnum = 0;
      int rownum = 0;
      for (int i = 0; i < clipboardText.Length; i++)
      {
        if (clipboardText.Substring(i, 1) == "\t")
        {
          colnum++;
        }
        if (clipboardText.Substring(i, 1) == "\n")
        {
          rownum++;
        }
      }
      //粘贴板上的数据来源于EXCEL时，每行末尾都有\n，来源于DataGridView是，最后一行末尾没有\n
      if (clipboardText.Substring(clipboardText.Length - 1, 1) == "\n")
      {
        rownum--;
      }
      colnum = colnum / (rownum + 1);
      //获取当前选中的最后一个单元格的列、行序号
      int colIndex = dgv_Test.SelectedCells[0].ColumnIndex;
      int rowIndex = dgv_Test.SelectedCells[0].RowIndex;
      for (int i = 0; i <= rownum; i++)
      {
        for (int j = 0; j <= colnum; j++)
        {
          dgv_Test.Rows[rowIndex - i].Cells[colIndex - j].Value = "";
        }
      }
    }
    public static void GridSort(DataGridView grid)
    {
      for (int i = 0; i < grid.Columns.Count; i++)//禁止列排序
      {
        grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
      }
    }
  }
}
