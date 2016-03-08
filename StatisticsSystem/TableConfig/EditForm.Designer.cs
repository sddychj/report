namespace StatisticsSystem.TableConfig
{
  partial class EditForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
      this.tablePersonConfigTab = new System.Windows.Forms.TabPage();
      this.tableStateDrop = new System.Windows.Forms.ComboBox();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.label9 = new System.Windows.Forms.Label();
      this.choiceExcelBtn = new System.Windows.Forms.Button();
      this.tableCountUpDown = new System.Windows.Forms.NumericUpDown();
      this.label11 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.tableArrangeDrop = new System.Windows.Forms.ComboBox();
      this.tableHeaderCell = new AxCELL50Lib.AxCell();
      this.isAutoAddRowCheck = new System.Windows.Forms.CheckBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.sheetNameTxt = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.tableColumnConfigTab = new System.Windows.Forms.TabPage();
      this.tableColumnCell = new AxCELL50Lib.AxCell();
      this.tableCycleDrop = new System.Windows.Forms.ComboBox();
      this.preBtn = new System.Windows.Forms.Button();
      this.tableIndexUpDown = new System.Windows.Forms.NumericUpDown();
      this.isUnitCheck = new System.Windows.Forms.CheckBox();
      this.isAcountCheck = new System.Windows.Forms.CheckBox();
      this.cancelBtn = new System.Windows.Forms.Button();
      this.finishBtn = new System.Windows.Forms.Button();
      this.tableTypeDrop = new System.Windows.Forms.ComboBox();
      this.tableDateDrop = new System.Windows.Forms.ComboBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.nextBtn = new System.Windows.Forms.Button();
      this.label10 = new System.Windows.Forms.Label();
      this.choiceExcelDialog = new System.Windows.Forms.OpenFileDialog();
      this.label12 = new System.Windows.Forms.Label();
      this.tableHeaderConfigTab = new System.Windows.Forms.TabPage();
      this.tableBasisConfigTab = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label6 = new System.Windows.Forms.Label();
      this.tableDaysTxt = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.tableHeaderTxt = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tableNoTxt = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tableNumTxt = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tableCellConfigTab = new System.Windows.Forms.TabPage();
      this.tableCellCell = new AxCELL50Lib.AxCell();
      this.tableConfigTabList = new System.Windows.Forms.TabControl();
      this.tableIndexConfigTab = new System.Windows.Forms.TabPage();
      this.tableIndexCell = new AxCELL50Lib.AxCell();
      ((System.ComponentModel.ISupportInitialize)(this.tableCountUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableHeaderCell)).BeginInit();
      this.panel1.SuspendLayout();
      this.tableColumnConfigTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tableColumnCell)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableIndexUpDown)).BeginInit();
      this.panel3.SuspendLayout();
      this.tableHeaderConfigTab.SuspendLayout();
      this.tableBasisConfigTab.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tableCellConfigTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tableCellCell)).BeginInit();
      this.tableConfigTabList.SuspendLayout();
      this.tableIndexConfigTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tableIndexCell)).BeginInit();
      this.SuspendLayout();
      // 
      // tablePersonConfigTab
      // 
      this.tablePersonConfigTab.Location = new System.Drawing.Point(4, 21);
      this.tablePersonConfigTab.Name = "tablePersonConfigTab";
      this.tablePersonConfigTab.Size = new System.Drawing.Size(908, 546);
      this.tablePersonConfigTab.TabIndex = 4;
      this.tablePersonConfigTab.Text = "报表个性化配置";
      this.tablePersonConfigTab.UseVisualStyleBackColor = true;
      // 
      // tableStateDrop
      // 
      this.tableStateDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.tableStateDrop.FormattingEnabled = true;
      this.tableStateDrop.Items.AddRange(new object[] {
            "启用",
            "禁用"});
      this.tableStateDrop.Location = new System.Drawing.Point(336, 232);
      this.tableStateDrop.Name = "tableStateDrop";
      this.tableStateDrop.Size = new System.Drawing.Size(121, 20);
      this.tableStateDrop.TabIndex = 74;
      // 
      // treeView1
      // 
      this.treeView1.Location = new System.Drawing.Point(626, 24);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(89, 23);
      this.treeView1.TabIndex = 9;
      this.treeView1.Visible = false;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(270, 236);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(53, 12);
      this.label9.TabIndex = 73;
      this.label9.Text = "报表状态";
      // 
      // choiceExcelBtn
      // 
      this.choiceExcelBtn.Location = new System.Drawing.Point(373, 24);
      this.choiceExcelBtn.Name = "choiceExcelBtn";
      this.choiceExcelBtn.Size = new System.Drawing.Size(137, 23);
      this.choiceExcelBtn.TabIndex = 8;
      this.choiceExcelBtn.Text = "导入Xml文件";
      this.choiceExcelBtn.UseVisualStyleBackColor = true;
      this.choiceExcelBtn.Click += new System.EventHandler(this.choiceExcelBtn_Click);
      // 
      // tableCountUpDown
      // 
      this.tableCountUpDown.Location = new System.Drawing.Point(117, 352);
      this.tableCountUpDown.Name = "tableCountUpDown";
      this.tableCountUpDown.Size = new System.Drawing.Size(83, 21);
      this.tableCountUpDown.TabIndex = 68;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(270, 356);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(53, 12);
      this.label11.TabIndex = 75;
      this.label11.Text = "指标排列";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(65, 29);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(125, 12);
      this.label8.TabIndex = 7;
      this.label8.Text = "请输入Excel中Sheet名";
      // 
      // tableArrangeDrop
      // 
      this.tableArrangeDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.tableArrangeDrop.FormattingEnabled = true;
      this.tableArrangeDrop.Items.AddRange(new object[] {
            "横向",
            "纵向"});
      this.tableArrangeDrop.Location = new System.Drawing.Point(335, 352);
      this.tableArrangeDrop.Name = "tableArrangeDrop";
      this.tableArrangeDrop.Size = new System.Drawing.Size(121, 20);
      this.tableArrangeDrop.TabIndex = 76;
      // 
      // tableHeaderCell
      // 
      this.tableHeaderCell.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableHeaderCell.Enabled = true;
      this.tableHeaderCell.Location = new System.Drawing.Point(0, 59);
      this.tableHeaderCell.Name = "tableHeaderCell";
      this.tableHeaderCell.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tableHeaderCell.OcxState")));
      this.tableHeaderCell.Size = new System.Drawing.Size(908, 487);
      this.tableHeaderCell.TabIndex = 2;
      // 
      // isAutoAddRowCheck
      // 
      this.isAutoAddRowCheck.AutoSize = true;
      this.isAutoAddRowCheck.Location = new System.Drawing.Point(469, 292);
      this.isAutoAddRowCheck.Name = "isAutoAddRowCheck";
      this.isAutoAddRowCheck.Size = new System.Drawing.Size(84, 16);
      this.isAutoAddRowCheck.TabIndex = 66;
      this.isAutoAddRowCheck.Text = "自增行报表";
      this.isAutoAddRowCheck.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.treeView1);
      this.panel1.Controls.Add(this.choiceExcelBtn);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.sheetNameTxt);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(908, 59);
      this.panel1.TabIndex = 1;
      // 
      // sheetNameTxt
      // 
      this.sheetNameTxt.Location = new System.Drawing.Point(221, 26);
      this.sheetNameTxt.Name = "sheetNameTxt";
      this.sheetNameTxt.Size = new System.Drawing.Size(100, 21);
      this.sheetNameTxt.TabIndex = 6;
      this.sheetNameTxt.Text = "Sheet1";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(52, 356);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(53, 12);
      this.label7.TabIndex = 67;
      this.label7.Text = "报表栏数";
      // 
      // tableColumnConfigTab
      // 
      this.tableColumnConfigTab.Controls.Add(this.tableColumnCell);
      this.tableColumnConfigTab.Location = new System.Drawing.Point(4, 21);
      this.tableColumnConfigTab.Name = "tableColumnConfigTab";
      this.tableColumnConfigTab.Size = new System.Drawing.Size(908, 546);
      this.tableColumnConfigTab.TabIndex = 6;
      this.tableColumnConfigTab.Text = "报表列配置";
      this.tableColumnConfigTab.UseVisualStyleBackColor = true;
      // 
      // tableColumnCell
      // 
      this.tableColumnCell.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableColumnCell.Enabled = true;
      this.tableColumnCell.Location = new System.Drawing.Point(0, 0);
      this.tableColumnCell.Name = "tableColumnCell";
      this.tableColumnCell.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tableColumnCell.OcxState")));
      this.tableColumnCell.Size = new System.Drawing.Size(908, 546);
      this.tableColumnCell.TabIndex = 0;
      // 
      // tableCycleDrop
      // 
      this.tableCycleDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.tableCycleDrop.FormattingEnabled = true;
      this.tableCycleDrop.Items.AddRange(new object[] {
            "旬报",
            "月报",
            "季报",
            "年报"});
      this.tableCycleDrop.Location = new System.Drawing.Point(117, 174);
      this.tableCycleDrop.Name = "tableCycleDrop";
      this.tableCycleDrop.Size = new System.Drawing.Size(121, 20);
      this.tableCycleDrop.TabIndex = 64;
      // 
      // preBtn
      // 
      this.preBtn.Enabled = false;
      this.preBtn.Location = new System.Drawing.Point(225, 17);
      this.preBtn.Name = "preBtn";
      this.preBtn.Size = new System.Drawing.Size(75, 23);
      this.preBtn.TabIndex = 9;
      this.preBtn.Text = "上一步";
      this.preBtn.UseVisualStyleBackColor = true;
      this.preBtn.Click += new System.EventHandler(this.preBtn_Click);
      // 
      // tableIndexUpDown
      // 
      this.tableIndexUpDown.Location = new System.Drawing.Point(117, 292);
      this.tableIndexUpDown.Name = "tableIndexUpDown";
      this.tableIndexUpDown.Size = new System.Drawing.Size(83, 21);
      this.tableIndexUpDown.TabIndex = 63;
      // 
      // isUnitCheck
      // 
      this.isUnitCheck.AutoSize = true;
      this.isUnitCheck.Location = new System.Drawing.Point(370, 292);
      this.isUnitCheck.Name = "isUnitCheck";
      this.isUnitCheck.Size = new System.Drawing.Size(72, 16);
      this.isUnitCheck.TabIndex = 60;
      this.isUnitCheck.Text = "计量单位";
      this.isUnitCheck.UseVisualStyleBackColor = true;
      // 
      // isAcountCheck
      // 
      this.isAcountCheck.AutoSize = true;
      this.isAcountCheck.Location = new System.Drawing.Point(272, 292);
      this.isAcountCheck.Name = "isAcountCheck";
      this.isAcountCheck.Size = new System.Drawing.Size(72, 16);
      this.isAcountCheck.TabIndex = 59;
      this.isAcountCheck.Text = "是否台账";
      this.isAcountCheck.UseVisualStyleBackColor = true;
      // 
      // cancelBtn
      // 
      this.cancelBtn.Location = new System.Drawing.Point(525, 17);
      this.cancelBtn.Name = "cancelBtn";
      this.cancelBtn.Size = new System.Drawing.Size(75, 23);
      this.cancelBtn.TabIndex = 8;
      this.cancelBtn.Text = "取消";
      this.cancelBtn.UseVisualStyleBackColor = true;
      this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
      // 
      // finishBtn
      // 
      this.finishBtn.Enabled = false;
      this.finishBtn.Location = new System.Drawing.Point(425, 17);
      this.finishBtn.Name = "finishBtn";
      this.finishBtn.Size = new System.Drawing.Size(75, 23);
      this.finishBtn.TabIndex = 7;
      this.finishBtn.Text = "完成";
      this.finishBtn.UseVisualStyleBackColor = true;
      this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
      // 
      // tableTypeDrop
      // 
      this.tableTypeDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.tableTypeDrop.FormattingEnabled = true;
      this.tableTypeDrop.Items.AddRange(new object[] {
            "总公司报表",
            "分公司报表"});
      this.tableTypeDrop.Location = new System.Drawing.Point(117, 232);
      this.tableTypeDrop.Name = "tableTypeDrop";
      this.tableTypeDrop.Size = new System.Drawing.Size(121, 20);
      this.tableTypeDrop.TabIndex = 58;
      // 
      // tableDateDrop
      // 
      this.tableDateDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.tableDateDrop.FormattingEnabled = true;
      this.tableDateDrop.Items.AddRange(new object[] {
            "旬后",
            "月后",
            "季后",
            "年后"});
      this.tableDateDrop.Location = new System.Drawing.Point(336, 174);
      this.tableDateDrop.Name = "tableDateDrop";
      this.tableDateDrop.Size = new System.Drawing.Size(63, 20);
      this.tableDateDrop.TabIndex = 57;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.preBtn);
      this.panel3.Controls.Add(this.cancelBtn);
      this.panel3.Controls.Add(this.finishBtn);
      this.panel3.Controls.Add(this.nextBtn);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel3.Location = new System.Drawing.Point(0, 515);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(916, 56);
      this.panel3.TabIndex = 3;
      // 
      // nextBtn
      // 
      this.nextBtn.Location = new System.Drawing.Point(325, 17);
      this.nextBtn.Name = "nextBtn";
      this.nextBtn.Size = new System.Drawing.Size(75, 23);
      this.nextBtn.TabIndex = 6;
      this.nextBtn.Text = "下一步";
      this.nextBtn.UseVisualStyleBackColor = true;
      this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
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
      // choiceExcelDialog
      // 
      this.choiceExcelDialog.FileName = "openFileDialog1";
      this.choiceExcelDialog.Filter = "Xml文件|*.xml";
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
      // tableHeaderConfigTab
      // 
      this.tableHeaderConfigTab.Controls.Add(this.tableHeaderCell);
      this.tableHeaderConfigTab.Controls.Add(this.panel1);
      this.tableHeaderConfigTab.Location = new System.Drawing.Point(4, 21);
      this.tableHeaderConfigTab.Name = "tableHeaderConfigTab";
      this.tableHeaderConfigTab.Size = new System.Drawing.Size(908, 546);
      this.tableHeaderConfigTab.TabIndex = 5;
      this.tableHeaderConfigTab.Text = "报表表头配置";
      this.tableHeaderConfigTab.UseVisualStyleBackColor = true;
      // 
      // tableBasisConfigTab
      // 
      this.tableBasisConfigTab.Controls.Add(this.groupBox1);
      this.tableBasisConfigTab.Location = new System.Drawing.Point(4, 21);
      this.tableBasisConfigTab.Name = "tableBasisConfigTab";
      this.tableBasisConfigTab.Padding = new System.Windows.Forms.Padding(3);
      this.tableBasisConfigTab.Size = new System.Drawing.Size(908, 546);
      this.tableBasisConfigTab.TabIndex = 0;
      this.tableBasisConfigTab.Text = "报表基础配置";
      this.tableBasisConfigTab.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tableArrangeDrop);
      this.groupBox1.Controls.Add(this.label11);
      this.groupBox1.Controls.Add(this.tableStateDrop);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.tableCountUpDown);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.isAutoAddRowCheck);
      this.groupBox1.Controls.Add(this.tableCycleDrop);
      this.groupBox1.Controls.Add(this.tableIndexUpDown);
      this.groupBox1.Controls.Add(this.isUnitCheck);
      this.groupBox1.Controls.Add(this.isAcountCheck);
      this.groupBox1.Controls.Add(this.tableTypeDrop);
      this.groupBox1.Controls.Add(this.tableDateDrop);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.label12);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.tableDaysTxt);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.tableHeaderTxt);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.tableNoTxt);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.tableNumTxt);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(902, 401);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(413, 178);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(29, 12);
      this.label6.TabIndex = 53;
      this.label6.Text = "日数";
      // 
      // tableDaysTxt
      // 
      this.tableDaysTxt.Location = new System.Drawing.Point(453, 174);
      this.tableDaysTxt.Name = "tableDaysTxt";
      this.tableDaysTxt.Size = new System.Drawing.Size(60, 21);
      this.tableDaysTxt.TabIndex = 52;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(270, 178);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 12);
      this.label5.TabIndex = 51;
      this.label5.Text = "上报日期";
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
      // tableHeaderTxt
      // 
      this.tableHeaderTxt.Location = new System.Drawing.Point(117, 116);
      this.tableHeaderTxt.Name = "tableHeaderTxt";
      this.tableHeaderTxt.Size = new System.Drawing.Size(465, 21);
      this.tableHeaderTxt.TabIndex = 49;
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
      // tableNoTxt
      // 
      this.tableNoTxt.Location = new System.Drawing.Point(336, 58);
      this.tableNoTxt.Name = "tableNoTxt";
      this.tableNoTxt.Size = new System.Drawing.Size(246, 21);
      this.tableNoTxt.TabIndex = 47;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(270, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 12);
      this.label2.TabIndex = 46;
      this.label2.Text = "报表文号";
      // 
      // tableNumTxt
      // 
      this.tableNumTxt.Location = new System.Drawing.Point(118, 58);
      this.tableNumTxt.Name = "tableNumTxt";
      this.tableNumTxt.Size = new System.Drawing.Size(120, 21);
      this.tableNumTxt.TabIndex = 45;
      this.tableNumTxt.TextChanged += new System.EventHandler(this.tableNumTxt_TextChanged);
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
      // tableCellConfigTab
      // 
      this.tableCellConfigTab.Controls.Add(this.tableCellCell);
      this.tableCellConfigTab.Location = new System.Drawing.Point(4, 21);
      this.tableCellConfigTab.Name = "tableCellConfigTab";
      this.tableCellConfigTab.Size = new System.Drawing.Size(908, 546);
      this.tableCellConfigTab.TabIndex = 3;
      this.tableCellConfigTab.Text = "报表单元格配置";
      this.tableCellConfigTab.UseVisualStyleBackColor = true;
      // 
      // tableCellCell
      // 
      this.tableCellCell.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableCellCell.Enabled = true;
      this.tableCellCell.Location = new System.Drawing.Point(0, 0);
      this.tableCellCell.Name = "tableCellCell";
      this.tableCellCell.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tableCellCell.OcxState")));
      this.tableCellCell.Size = new System.Drawing.Size(908, 546);
      this.tableCellCell.TabIndex = 0;
      // 
      // tableConfigTabList
      // 
      this.tableConfigTabList.Controls.Add(this.tableBasisConfigTab);
      this.tableConfigTabList.Controls.Add(this.tableHeaderConfigTab);
      this.tableConfigTabList.Controls.Add(this.tableColumnConfigTab);
      this.tableConfigTabList.Controls.Add(this.tableIndexConfigTab);
      this.tableConfigTabList.Controls.Add(this.tableCellConfigTab);
      this.tableConfigTabList.Controls.Add(this.tablePersonConfigTab);
      this.tableConfigTabList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableConfigTabList.Location = new System.Drawing.Point(0, 0);
      this.tableConfigTabList.Name = "tableConfigTabList";
      this.tableConfigTabList.SelectedIndex = 0;
      this.tableConfigTabList.Size = new System.Drawing.Size(916, 571);
      this.tableConfigTabList.TabIndex = 2;
      // 
      // tableIndexConfigTab
      // 
      this.tableIndexConfigTab.Controls.Add(this.tableIndexCell);
      this.tableIndexConfigTab.Location = new System.Drawing.Point(4, 21);
      this.tableIndexConfigTab.Name = "tableIndexConfigTab";
      this.tableIndexConfigTab.Size = new System.Drawing.Size(908, 546);
      this.tableIndexConfigTab.TabIndex = 2;
      this.tableIndexConfigTab.Text = "报表指标配置";
      this.tableIndexConfigTab.UseVisualStyleBackColor = true;
      // 
      // tableIndexCell
      // 
      this.tableIndexCell.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableIndexCell.Enabled = true;
      this.tableIndexCell.Location = new System.Drawing.Point(0, 0);
      this.tableIndexCell.Name = "tableIndexCell";
      this.tableIndexCell.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tableIndexCell.OcxState")));
      this.tableIndexCell.Size = new System.Drawing.Size(908, 546);
      this.tableIndexCell.TabIndex = 0;
      // 
      // EditForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(916, 571);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.tableConfigTabList);
      this.Name = "EditForm";
      this.Text = "EditForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewForm_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.tableCountUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableHeaderCell)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tableColumnConfigTab.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tableColumnCell)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tableIndexUpDown)).EndInit();
      this.panel3.ResumeLayout(false);
      this.tableHeaderConfigTab.ResumeLayout(false);
      this.tableBasisConfigTab.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tableCellConfigTab.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tableCellCell)).EndInit();
      this.tableConfigTabList.ResumeLayout(false);
      this.tableIndexConfigTab.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tableIndexCell)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabPage tablePersonConfigTab;
    private System.Windows.Forms.ComboBox tableStateDrop;
    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button choiceExcelBtn;
    private System.Windows.Forms.NumericUpDown tableCountUpDown;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ComboBox tableArrangeDrop;
    private AxCELL50Lib.AxCell tableHeaderCell;
    private System.Windows.Forms.CheckBox isAutoAddRowCheck;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox sheetNameTxt;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TabPage tableColumnConfigTab;
    private AxCELL50Lib.AxCell tableColumnCell;
    private System.Windows.Forms.ComboBox tableCycleDrop;
    private System.Windows.Forms.Button preBtn;
    private System.Windows.Forms.NumericUpDown tableIndexUpDown;
    private System.Windows.Forms.CheckBox isUnitCheck;
    private System.Windows.Forms.CheckBox isAcountCheck;
    private System.Windows.Forms.Button cancelBtn;
    private System.Windows.Forms.Button finishBtn;
    private System.Windows.Forms.ComboBox tableTypeDrop;
    private System.Windows.Forms.ComboBox tableDateDrop;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button nextBtn;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.OpenFileDialog choiceExcelDialog;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TabPage tableHeaderConfigTab;
    private System.Windows.Forms.TabPage tableBasisConfigTab;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tableDaysTxt;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tableHeaderTxt;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tableNoTxt;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tableNumTxt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tableCellConfigTab;
    private AxCELL50Lib.AxCell tableCellCell;
    private System.Windows.Forms.TabControl tableConfigTabList;
    private System.Windows.Forms.TabPage tableIndexConfigTab;
    private AxCELL50Lib.AxCell tableIndexCell;
  }
}