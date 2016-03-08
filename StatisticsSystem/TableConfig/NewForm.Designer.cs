namespace StatisticsSystem.TableConfig
{
  partial class NewForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewForm));
      this.Tools = new System.Windows.Forms.ToolStrip();
      this.dialogChoiceExcel = new System.Windows.Forms.OpenFileDialog();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.tabListTableConfig = new System.Windows.Forms.TabControl();
      this.tabTableBasisConfig = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.cbISSpecia = new System.Windows.Forms.CheckBox();
      this.cobIsMerge = new System.Windows.Forms.CheckBox();
      this.dropTableState = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.isAddRow = new System.Windows.Forms.CheckBox();
      this.dropTableCycle = new System.Windows.Forms.ComboBox();
      this.tableIndexUpDown = new System.Windows.Forms.NumericUpDown();
      this.isPreCompute = new System.Windows.Forms.CheckBox();
      this.dropTableType = new System.Windows.Forms.ComboBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtTableHeader = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtTableNo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTableNum = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabTableHeaderConfig = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.axcellTableHeader = new AxCELL50Lib.AxCell();
      this.tabTableColumnConfig = new System.Windows.Forms.TabPage();
      this.axCellTableColumn = new AxCELL50Lib.AxCell();
      this.tabTableIndexConfig = new System.Windows.Forms.TabPage();
      this.axCellTableIndex = new AxCELL50Lib.AxCell();
      this.tabTableCellPreConfig = new System.Windows.Forms.TabPage();
      this.axCellTableCellPre = new AxCELL50Lib.AxCell();
      this.btnPre = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnNext = new System.Windows.Forms.Button();
      this.btnFinish = new System.Windows.Forms.Button();
      this.exportPre = new System.Windows.Forms.NumericUpDown();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.tabListTableConfig.SuspendLayout();
      this.tabTableBasisConfig.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tableIndexUpDown)).BeginInit();
      this.tabTableHeaderConfig.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axcellTableHeader)).BeginInit();
      this.tabTableColumnConfig.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axCellTableColumn)).BeginInit();
      this.tabTableIndexConfig.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axCellTableIndex)).BeginInit();
      this.tabTableCellPreConfig.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axCellTableCellPre)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.exportPre)).BeginInit();
      this.SuspendLayout();
      // 
      // Tools
      // 
      this.Tools.Location = new System.Drawing.Point(0, 0);
      this.Tools.Name = "Tools";
      this.Tools.Size = new System.Drawing.Size(820, 25);
      this.Tools.TabIndex = 0;
      this.Tools.Text = "toolStrip1";
      this.Tools.Visible = false;
      // 
      // dialogChoiceExcel
      // 
      this.dialogChoiceExcel.FileName = "openFileDialog1";
      this.dialogChoiceExcel.Filter = "Xml文件|*.xml";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.tabListTableConfig);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.btnPre);
      this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
      this.splitContainer1.Panel2.Controls.Add(this.btnNext);
      this.splitContainer1.Panel2.Controls.Add(this.btnFinish);
      this.splitContainer1.Size = new System.Drawing.Size(792, 566);
      this.splitContainer1.SplitterDistance = 492;
      this.splitContainer1.TabIndex = 0;
      // 
      // tabListTableConfig
      // 
      this.tabListTableConfig.Controls.Add(this.tabTableBasisConfig);
      this.tabListTableConfig.Controls.Add(this.tabTableHeaderConfig);
      this.tabListTableConfig.Controls.Add(this.tabTableColumnConfig);
      this.tabListTableConfig.Controls.Add(this.tabTableIndexConfig);
      this.tabListTableConfig.Controls.Add(this.tabTableCellPreConfig);
      this.tabListTableConfig.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabListTableConfig.Location = new System.Drawing.Point(0, 0);
      this.tabListTableConfig.Name = "tabListTableConfig";
      this.tabListTableConfig.SelectedIndex = 0;
      this.tabListTableConfig.Size = new System.Drawing.Size(792, 492);
      this.tabListTableConfig.TabIndex = 10;
      this.tabListTableConfig.SelectedIndexChanged += new System.EventHandler(this.tabListTableConfig_SelectedIndexChanged);
      // 
      // tabTableBasisConfig
      // 
      this.tabTableBasisConfig.Controls.Add(this.groupBox1);
      this.tabTableBasisConfig.Location = new System.Drawing.Point(4, 22);
      this.tabTableBasisConfig.Name = "tabTableBasisConfig";
      this.tabTableBasisConfig.Padding = new System.Windows.Forms.Padding(3);
      this.tabTableBasisConfig.Size = new System.Drawing.Size(784, 466);
      this.tabTableBasisConfig.TabIndex = 0;
      this.tabTableBasisConfig.Text = "报表基础配置";
      this.tabTableBasisConfig.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.exportPre);
      this.groupBox1.Controls.Add(this.cbISSpecia);
      this.groupBox1.Controls.Add(this.cobIsMerge);
      this.groupBox1.Controls.Add(this.dropTableState);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.isAddRow);
      this.groupBox1.Controls.Add(this.dropTableCycle);
      this.groupBox1.Controls.Add(this.tableIndexUpDown);
      this.groupBox1.Controls.Add(this.isPreCompute);
      this.groupBox1.Controls.Add(this.dropTableType);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.label12);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.txtTableHeader);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtTableNo);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtTableNum);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(778, 401);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // cbISSpecia
      // 
      this.cbISSpecia.AutoSize = true;
      this.cbISSpecia.Location = new System.Drawing.Point(309, 176);
      this.cbISSpecia.Name = "cbISSpecia";
      this.cbISSpecia.Size = new System.Drawing.Size(108, 16);
      this.cbISSpecia.TabIndex = 78;
      this.cbISSpecia.Text = "是否不规则报表";
      this.cbISSpecia.UseVisualStyleBackColor = true;
      // 
      // cobIsMerge
      // 
      this.cobIsMerge.AutoSize = true;
      this.cobIsMerge.Location = new System.Drawing.Point(568, 292);
      this.cobIsMerge.Name = "cobIsMerge";
      this.cobIsMerge.Size = new System.Drawing.Size(96, 16);
      this.cobIsMerge.TabIndex = 77;
      this.cobIsMerge.Text = "是否合并显示";
      this.cobIsMerge.UseVisualStyleBackColor = true;
      // 
      // dropTableState
      // 
      this.dropTableState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.dropTableState.FormattingEnabled = true;
      this.dropTableState.Items.AddRange(new object[] {
            "启用",
            "禁用"});
      this.dropTableState.Location = new System.Drawing.Point(373, 232);
      this.dropTableState.Name = "dropTableState";
      this.dropTableState.Size = new System.Drawing.Size(121, 20);
      this.dropTableState.TabIndex = 74;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(307, 236);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(53, 12);
      this.label9.TabIndex = 73;
      this.label9.Text = "报表状态";
      // 
      // isAddRow
      // 
      this.isAddRow.AutoSize = true;
      this.isAddRow.Location = new System.Drawing.Point(466, 292);
      this.isAddRow.Name = "isAddRow";
      this.isAddRow.Size = new System.Drawing.Size(84, 16);
      this.isAddRow.TabIndex = 66;
      this.isAddRow.Text = "自增行报表";
      this.isAddRow.UseVisualStyleBackColor = true;
      // 
      // dropTableCycle
      // 
      this.dropTableCycle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.dropTableCycle.FormattingEnabled = true;
      this.dropTableCycle.Items.AddRange(new object[] {
            "月度",
            "季度",
            "半年度",
            "年度",
            "月报变年报"});
      this.dropTableCycle.Location = new System.Drawing.Point(117, 174);
      this.dropTableCycle.Name = "dropTableCycle";
      this.dropTableCycle.Size = new System.Drawing.Size(165, 20);
      this.dropTableCycle.TabIndex = 64;
      // 
      // tableIndexUpDown
      // 
      this.tableIndexUpDown.Location = new System.Drawing.Point(117, 292);
      this.tableIndexUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.tableIndexUpDown.Name = "tableIndexUpDown";
      this.tableIndexUpDown.Size = new System.Drawing.Size(83, 21);
      this.tableIndexUpDown.TabIndex = 63;
      // 
      // isPreCompute
      // 
      this.isPreCompute.AutoSize = true;
      this.isPreCompute.Location = new System.Drawing.Point(309, 292);
      this.isPreCompute.Name = "isPreCompute";
      this.isPreCompute.Size = new System.Drawing.Size(144, 16);
      this.isPreCompute.TabIndex = 59;
      this.isPreCompute.Text = "是否根据显示精度计算";
      this.isPreCompute.UseVisualStyleBackColor = true;
      // 
      // dropTableType
      // 
      this.dropTableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.dropTableType.FormattingEnabled = true;
      this.dropTableType.Location = new System.Drawing.Point(117, 232);
      this.dropTableType.Name = "dropTableType";
      this.dropTableType.Size = new System.Drawing.Size(165, 20);
      this.dropTableType.TabIndex = 58;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(28, 296);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(77, 12);
      this.label10.TabIndex = 56;
      this.label10.Text = "报表排序序号";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(52, 236);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(53, 12);
      this.label12.TabIndex = 54;
      this.label12.Text = "报表类型";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(52, 178);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 12);
      this.label4.TabIndex = 50;
      this.label4.Text = "报表周期";
      // 
      // txtTableHeader
      // 
      this.txtTableHeader.Location = new System.Drawing.Point(117, 116);
      this.txtTableHeader.Name = "txtTableHeader";
      this.txtTableHeader.Size = new System.Drawing.Size(465, 21);
      this.txtTableHeader.TabIndex = 49;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(52, 120);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 12);
      this.label3.TabIndex = 48;
      this.label3.Text = "报表标题";
      // 
      // txtTableNo
      // 
      this.txtTableNo.Location = new System.Drawing.Point(373, 58);
      this.txtTableNo.Name = "txtTableNo";
      this.txtTableNo.Size = new System.Drawing.Size(246, 21);
      this.txtTableNo.TabIndex = 47;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(307, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 12);
      this.label2.TabIndex = 46;
      this.label2.Text = "报表表号";
      // 
      // txtTableNum
      // 
      this.txtTableNum.Enabled = false;
      this.txtTableNum.Location = new System.Drawing.Point(118, 58);
      this.txtTableNum.Name = "txtTableNum";
      this.txtTableNum.Size = new System.Drawing.Size(138, 21);
      this.txtTableNum.TabIndex = 45;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(52, 62);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 44;
      this.label1.Text = "报表编号";
      // 
      // tabTableHeaderConfig
      // 
      this.tabTableHeaderConfig.Controls.Add(this.panel1);
      this.tabTableHeaderConfig.Location = new System.Drawing.Point(4, 22);
      this.tabTableHeaderConfig.Name = "tabTableHeaderConfig";
      this.tabTableHeaderConfig.Size = new System.Drawing.Size(784, 466);
      this.tabTableHeaderConfig.TabIndex = 5;
      this.tabTableHeaderConfig.Text = "报表表头配置";
      this.tabTableHeaderConfig.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.axcellTableHeader);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(784, 466);
      this.panel1.TabIndex = 0;
      // 
      // axcellTableHeader
      // 
      this.axcellTableHeader.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axcellTableHeader.Enabled = true;
      this.axcellTableHeader.Location = new System.Drawing.Point(0, 0);
      this.axcellTableHeader.Name = "axcellTableHeader";
      this.axcellTableHeader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axcellTableHeader.OcxState")));
      this.axcellTableHeader.Size = new System.Drawing.Size(784, 466);
      this.axcellTableHeader.TabIndex = 3;
      this.axcellTableHeader.MenuStart += new AxCELL50Lib._DCell2000Events_MenuStartEventHandler(this.axcellTableHeader_MenuStart);
      this.axcellTableHeader.MenuCommand += new AxCELL50Lib._DCell2000Events_MenuCommandEventHandler(this.axcellTableHeader_MenuCommand);
      // 
      // tabTableColumnConfig
      // 
      this.tabTableColumnConfig.Controls.Add(this.axCellTableColumn);
      this.tabTableColumnConfig.Location = new System.Drawing.Point(4, 22);
      this.tabTableColumnConfig.Name = "tabTableColumnConfig";
      this.tabTableColumnConfig.Size = new System.Drawing.Size(784, 466);
      this.tabTableColumnConfig.TabIndex = 6;
      this.tabTableColumnConfig.Text = "报表列配置";
      this.tabTableColumnConfig.UseVisualStyleBackColor = true;
      // 
      // axCellTableColumn
      // 
      this.axCellTableColumn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axCellTableColumn.Enabled = true;
      this.axCellTableColumn.Location = new System.Drawing.Point(0, 0);
      this.axCellTableColumn.Name = "axCellTableColumn";
      this.axCellTableColumn.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCellTableColumn.OcxState")));
      this.axCellTableColumn.Size = new System.Drawing.Size(784, 466);
      this.axCellTableColumn.TabIndex = 0;
      // 
      // tabTableIndexConfig
      // 
      this.tabTableIndexConfig.Controls.Add(this.axCellTableIndex);
      this.tabTableIndexConfig.Location = new System.Drawing.Point(4, 22);
      this.tabTableIndexConfig.Name = "tabTableIndexConfig";
      this.tabTableIndexConfig.Size = new System.Drawing.Size(784, 466);
      this.tabTableIndexConfig.TabIndex = 2;
      this.tabTableIndexConfig.Text = "报表指标配置";
      this.tabTableIndexConfig.UseVisualStyleBackColor = true;
      // 
      // axCellTableIndex
      // 
      this.axCellTableIndex.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axCellTableIndex.Enabled = true;
      this.axCellTableIndex.Location = new System.Drawing.Point(0, 0);
      this.axCellTableIndex.Name = "axCellTableIndex";
      this.axCellTableIndex.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCellTableIndex.OcxState")));
      this.axCellTableIndex.Size = new System.Drawing.Size(784, 466);
      this.axCellTableIndex.TabIndex = 0;
      this.axCellTableIndex.MenuStart += new AxCELL50Lib._DCell2000Events_MenuStartEventHandler(this.tableIndexCell_MenuStart);
      this.axCellTableIndex.MenuCommand += new AxCELL50Lib._DCell2000Events_MenuCommandEventHandler(this.tableIndexCell_MenuCommand);
      // 
      // tabTableCellPreConfig
      // 
      this.tabTableCellPreConfig.Controls.Add(this.axCellTableCellPre);
      this.tabTableCellPreConfig.Location = new System.Drawing.Point(4, 22);
      this.tabTableCellPreConfig.Name = "tabTableCellPreConfig";
      this.tabTableCellPreConfig.Size = new System.Drawing.Size(784, 466);
      this.tabTableCellPreConfig.TabIndex = 3;
      this.tabTableCellPreConfig.Text = "报表单元格配置";
      this.tabTableCellPreConfig.UseVisualStyleBackColor = true;
      // 
      // axCellTableCellPre
      // 
      this.axCellTableCellPre.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axCellTableCellPre.Enabled = true;
      this.axCellTableCellPre.Location = new System.Drawing.Point(0, 0);
      this.axCellTableCellPre.Name = "axCellTableCellPre";
      this.axCellTableCellPre.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCellTableCellPre.OcxState")));
      this.axCellTableCellPre.Size = new System.Drawing.Size(784, 466);
      this.axCellTableCellPre.TabIndex = 0;
      // 
      // btnPre
      // 
      this.btnPre.Enabled = false;
      this.btnPre.Location = new System.Drawing.Point(214, 22);
      this.btnPre.Name = "btnPre";
      this.btnPre.Size = new System.Drawing.Size(75, 23);
      this.btnPre.TabIndex = 14;
      this.btnPre.Text = "上一步";
      this.btnPre.UseVisualStyleBackColor = true;
      this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(514, 22);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 13;
      this.btnCancel.Text = "取消";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnNext
      // 
      this.btnNext.Location = new System.Drawing.Point(314, 22);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(75, 23);
      this.btnNext.TabIndex = 11;
      this.btnNext.Text = "下一步";
      this.btnNext.UseVisualStyleBackColor = true;
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // btnFinish
      // 
      this.btnFinish.Enabled = false;
      this.btnFinish.Location = new System.Drawing.Point(414, 22);
      this.btnFinish.Name = "btnFinish";
      this.btnFinish.Size = new System.Drawing.Size(75, 23);
      this.btnFinish.TabIndex = 12;
      this.btnFinish.Text = "完成";
      this.btnFinish.UseVisualStyleBackColor = true;
      this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
      // 
      // exportPre
      // 
      this.exportPre.Location = new System.Drawing.Point(517, 175);
      this.exportPre.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.exportPre.Name = "exportPre";
      this.exportPre.Size = new System.Drawing.Size(83, 21);
      this.exportPre.TabIndex = 79;
      this.exportPre.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(458, 180);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 12);
      this.label5.TabIndex = 80;
      this.label5.Text = "打印比例";
      // 
      // NewForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(792, 566);
      this.Controls.Add(this.Tools);
      this.Controls.Add(this.splitContainer1);
      this.KeyPreview = true;
      this.Name = "NewForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "报表设置向导";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewForm_FormClosing);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.tabListTableConfig.ResumeLayout(false);
      this.tabTableBasisConfig.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tableIndexUpDown)).EndInit();
      this.tabTableHeaderConfig.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.axcellTableHeader)).EndInit();
      this.tabTableColumnConfig.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.axCellTableColumn)).EndInit();
      this.tabTableIndexConfig.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.axCellTableIndex)).EndInit();
      this.tabTableCellPreConfig.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.axCellTableCellPre)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.exportPre)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip Tools;
    private System.Windows.Forms.OpenFileDialog dialogChoiceExcel;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TabControl tabListTableConfig;
    private System.Windows.Forms.TabPage tabTableBasisConfig;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox dropTableState;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.CheckBox isAddRow;
    private System.Windows.Forms.ComboBox dropTableCycle;
    private System.Windows.Forms.NumericUpDown tableIndexUpDown;
    private System.Windows.Forms.CheckBox isPreCompute;
    private System.Windows.Forms.ComboBox dropTableType;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtTableHeader;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtTableNo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTableNum;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tabTableHeaderConfig;
    private System.Windows.Forms.Panel panel1;
    private AxCELL50Lib.AxCell axcellTableHeader;
    private System.Windows.Forms.TabPage tabTableColumnConfig;
    private AxCELL50Lib.AxCell axCellTableColumn;
    private System.Windows.Forms.TabPage tabTableIndexConfig;
    private AxCELL50Lib.AxCell axCellTableIndex;
    private System.Windows.Forms.TabPage tabTableCellPreConfig;
    private AxCELL50Lib.AxCell axCellTableCellPre;
    private System.Windows.Forms.Button btnPre;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnFinish;
    private System.Windows.Forms.CheckBox cobIsMerge;
    private System.Windows.Forms.CheckBox cbISSpecia;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown exportPre;

  }
}