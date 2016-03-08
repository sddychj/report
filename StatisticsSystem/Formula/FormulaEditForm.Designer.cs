namespace StatisticsSystem.Formula
{
  partial class FormulaEditForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaEditForm));
      this.listBoxNum = new System.Windows.Forms.ListBox();
      this.lbFormula = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.upDownMonth = new System.Windows.Forms.NumericUpDown();
      this.upDownYear = new System.Windows.Forms.NumericUpDown();
      this.cobDW = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtMonth = new System.Windows.Forms.TextBox();
      this.txtYear = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.listViewQuoteTable = new System.Windows.Forms.ListView();
      this.panel2 = new System.Windows.Forms.Panel();
      this.axCellQuoteTable = new AxCELL50Lib.AxCell();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.upDownMonth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.upDownYear)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axCellQuoteTable)).BeginInit();
      this.SuspendLayout();
      // 
      // listBoxNum
      // 
      this.listBoxNum.FormattingEnabled = true;
      this.listBoxNum.ItemHeight = 12;
      this.listBoxNum.Location = new System.Drawing.Point(24, 42);
      this.listBoxNum.Name = "listBoxNum";
      this.listBoxNum.Size = new System.Drawing.Size(94, 160);
      this.listBoxNum.TabIndex = 1;
      this.listBoxNum.SelectedIndexChanged += new System.EventHandler(this.listBoxNum_SelectedIndexChanged);
      // 
      // lbFormula
      // 
      this.lbFormula.AutoSize = true;
      this.lbFormula.Location = new System.Drawing.Point(45, 12);
      this.lbFormula.Name = "lbFormula";
      this.lbFormula.Size = new System.Drawing.Size(53, 12);
      this.lbFormula.TabIndex = 2;
      this.lbFormula.Text = "当前公式";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(147, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 3;
      this.label1.Text = "引用报表";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.upDownMonth);
      this.panel1.Controls.Add(this.upDownYear);
      this.panel1.Controls.Add(this.cobDW);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.txtMonth);
      this.panel1.Controls.Add(this.txtYear);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.listViewQuoteTable);
      this.panel1.Controls.Add(this.listBoxNum);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.lbFormula);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1050, 248);
      this.panel1.TabIndex = 4;
      // 
      // upDownMonth
      // 
      this.upDownMonth.Location = new System.Drawing.Point(742, 147);
      this.upDownMonth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.upDownMonth.Name = "upDownMonth";
      this.upDownMonth.Size = new System.Drawing.Size(120, 21);
      this.upDownMonth.TabIndex = 19;
      // 
      // upDownYear
      // 
      this.upDownYear.Location = new System.Drawing.Point(742, 84);
      this.upDownYear.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.upDownYear.Name = "upDownYear";
      this.upDownYear.Size = new System.Drawing.Size(120, 21);
      this.upDownYear.TabIndex = 18;
      // 
      // cobDW
      // 
      this.cobDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobDW.FormattingEnabled = true;
      this.cobDW.Location = new System.Drawing.Point(742, 53);
      this.cobDW.Name = "cobDW";
      this.cobDW.Size = new System.Drawing.Size(234, 20);
      this.cobDW.TabIndex = 17;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(659, 56);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(29, 12);
      this.label5.TabIndex = 16;
      this.label5.Text = "单位";
      // 
      // txtMonth
      // 
      this.txtMonth.Location = new System.Drawing.Point(742, 179);
      this.txtMonth.Name = "txtMonth";
      this.txtMonth.Size = new System.Drawing.Size(100, 21);
      this.txtMonth.TabIndex = 12;
      this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonth_KeyPress);
      // 
      // txtYear
      // 
      this.txtYear.Location = new System.Drawing.Point(742, 112);
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(100, 21);
      this.txtYear.TabIndex = 11;
      this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(659, 115);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(53, 12);
      this.label7.TabIndex = 10;
      this.label7.Text = "绝对年份";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(659, 182);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 12);
      this.label4.TabIndex = 7;
      this.label4.Text = "绝对月份";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(659, 149);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 12);
      this.label3.TabIndex = 6;
      this.label3.Text = "相对月份";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(659, 86);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 12);
      this.label2.TabIndex = 5;
      this.label2.Text = "相对年份";
      // 
      // listViewQuoteTable
      // 
      this.listViewQuoteTable.FullRowSelect = true;
      this.listViewQuoteTable.GridLines = true;
      this.listViewQuoteTable.HideSelection = false;
      this.listViewQuoteTable.Location = new System.Drawing.Point(149, 42);
      this.listViewQuoteTable.MultiSelect = false;
      this.listViewQuoteTable.Name = "listViewQuoteTable";
      this.listViewQuoteTable.Size = new System.Drawing.Size(449, 160);
      this.listViewQuoteTable.TabIndex = 1;
      this.listViewQuoteTable.UseCompatibleStateImageBehavior = false;
      this.listViewQuoteTable.View = System.Windows.Forms.View.Details;
      this.listViewQuoteTable.SelectedIndexChanged += new System.EventHandler(this.listViewQuoteTable_SelectedIndexChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.axCellQuoteTable);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 248);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1050, 414);
      this.panel2.TabIndex = 5;
      // 
      // axCellQuoteTable
      // 
      this.axCellQuoteTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axCellQuoteTable.Enabled = true;
      this.axCellQuoteTable.Location = new System.Drawing.Point(0, 0);
      this.axCellQuoteTable.Name = "axCellQuoteTable";
      this.axCellQuoteTable.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCellQuoteTable.OcxState")));
      this.axCellQuoteTable.Size = new System.Drawing.Size(1050, 414);
      this.axCellQuoteTable.TabIndex = 4;
      this.axCellQuoteTable.MenuStart += new AxCELL50Lib._DCell2000Events_MenuStartEventHandler(this.axCellQuoteTable_MenuStart);
      this.axCellQuoteTable.MenuCommand += new AxCELL50Lib._DCell2000Events_MenuCommandEventHandler(this.axCellQuoteTable_MenuCommand);
      // 
      // FormulaEditForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1050, 662);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "FormulaEditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "公式配置";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.upDownMonth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.upDownYear)).EndInit();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.axCellQuoteTable)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxNum;
    private System.Windows.Forms.Label lbFormula;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListView listViewQuoteTable;
    private System.Windows.Forms.TextBox txtMonth;
    private System.Windows.Forms.TextBox txtYear;
    private System.Windows.Forms.Panel panel2;
    private AxCELL50Lib.AxCell axCellQuoteTable;
    private System.Windows.Forms.NumericUpDown upDownMonth;
    private System.Windows.Forms.NumericUpDown upDownYear;
    private System.Windows.Forms.ComboBox cobDW;
    private System.Windows.Forms.Label label5;
  }
}