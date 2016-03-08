namespace StatisticsSystem.TableConfig
{
  partial class OpenForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.cobBBLX = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.openTableGrid = new System.Windows.Forms.DataGridView();
      this.XHCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TableNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TableCycleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.openTableGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.cobBBLX);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(844, 43);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "报表类型";
      // 
      // cobBBLX
      // 
      this.cobBBLX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobBBLX.FormattingEnabled = true;
      this.cobBBLX.Location = new System.Drawing.Point(114, 12);
      this.cobBBLX.Name = "cobBBLX";
      this.cobBBLX.Size = new System.Drawing.Size(176, 20);
      this.cobBBLX.TabIndex = 0;
      this.cobBBLX.SelectedIndexChanged += new System.EventHandler(this.cobBBLX_SelectedIndexChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.openTableGrid);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 43);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(844, 442);
      this.panel2.TabIndex = 1;
      // 
      // openTableGrid
      // 
      this.openTableGrid.AllowUserToAddRows = false;
      this.openTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.openTableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XHCol,
            this.TableNumCol,
            this.tableNoCol,
            this.TitleCol,
            this.TableCycleCol});
      this.openTableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.openTableGrid.Location = new System.Drawing.Point(0, 0);
      this.openTableGrid.Name = "openTableGrid";
      this.openTableGrid.ReadOnly = true;
      this.openTableGrid.RowTemplate.Height = 23;
      this.openTableGrid.Size = new System.Drawing.Size(844, 442);
      this.openTableGrid.TabIndex = 1;
      this.openTableGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.openTableGrid_CellClick);
      this.openTableGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.openTableGrid_CellDoubleClick);
      this.openTableGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.openTableGrid_UserDeletingRow);
      // 
      // XHCol
      // 
      this.XHCol.DataPropertyName = "PXXH";
      this.XHCol.HeaderText = "序号";
      this.XHCol.Name = "XHCol";
      this.XHCol.ReadOnly = true;
      // 
      // TableNumCol
      // 
      this.TableNumCol.DataPropertyName = "BBBM";
      this.TableNumCol.HeaderText = "报表编码";
      this.TableNumCol.Name = "TableNumCol";
      this.TableNumCol.ReadOnly = true;
      // 
      // tableNoCol
      // 
      this.tableNoCol.DataPropertyName = "BBWH";
      this.tableNoCol.HeaderText = "报表文号";
      this.tableNoCol.Name = "tableNoCol";
      this.tableNoCol.ReadOnly = true;
      // 
      // TitleCol
      // 
      this.TitleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.TitleCol.DataPropertyName = "BBMC";
      this.TitleCol.HeaderText = "标题名称";
      this.TitleCol.Name = "TitleCol";
      this.TitleCol.ReadOnly = true;
      // 
      // TableCycleCol
      // 
      this.TableCycleCol.DataPropertyName = "BBZQ";
      this.TableCycleCol.HeaderText = "报表周期";
      this.TableCycleCol.Name = "TableCycleCol";
      this.TableCycleCol.ReadOnly = true;
      // 
      // OpenForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(844, 485);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "OpenForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "报表列表";
      this.Shown += new System.EventHandler(this.OpenForm_Shown);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.openTableGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ComboBox cobBBLX;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.DataGridView openTableGrid;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn XHCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn TableNumCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn tableNoCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn TableCycleCol;

  }
}