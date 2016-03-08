using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Common.Control
{
  public class CellCommon
  {

    public static void PasteData(AxCELL50Lib.AxCell grid)
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
        int colIndex = grid.GetCurrentCol();
        //获取当前选中单元格的行序号
        int rowIndex = grid.GetCurrentRow();
        //dgv_Test.Rows.Clear();
        for (int i = 0; i <= rownum; i++)
        {
          if (i + rowIndex >= grid.GetRows(0))
          {
            //DataGridViewRow row = (DataGridViewRow)dgv_Test.RowTemplate.Clone();
            //for (int j = 0; j <= colnum; j++)
            //{
            //  DataGridViewTextBoxCell cellid = new DataGridViewTextBoxCell();
            //  cellid.Value = data[i, j];
            //  row.Cells.Add(cellid);
            //}
            //dgv_Test.Rows.Add(row);
            grid.InsertRow(i + rowIndex, 1, 0);
            for (int j = 0; j <= colnum; j++)
            {
              int input = grid.GetCellInput(j + colIndex, i + rowIndex, 0);
              if (input == 5)
                return;
              int width = grid.GetColBestWidth(j + colIndex);
              grid.SetColWidth(1, width, j + colIndex, 0);
              grid.SetCellString(j + colIndex, i + rowIndex, 0, data[i, j].ToString());
            }
          }
          else
          {
            for (int j = 0; j <= colnum; j++)
            {
              //dgv_Test.Rows[i + rowIndex].Cells[j + colIndex].Value = data[i, j];
              int input = grid.GetCellInput(j + colIndex, i + rowIndex, 0);
              if (input == 5)
                return;
              int width = grid.GetColBestWidth(j + colIndex);
              grid.SetColWidth(1, width, j + colIndex, 0);
              grid.SetCellString(j + colIndex, i + rowIndex, 0, data[i, j].ToString());
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


  }
}
