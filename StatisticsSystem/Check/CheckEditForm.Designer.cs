﻿namespace StatisticsSystem.Check
{
  partial class CheckEditForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckEditForm));
      this.upDownYear = new System.Windows.Forms.NumericUpDown();
      this.cobDW = new System.Windows.Forms.ComboBox();
      this.upDownMonth = new System.Windows.Forms.NumericUpDown();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cobO = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtMonth = new System.Windows.Forms.TextBox();
      this.txtYear = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.listViewQuoteTable = new System.Windows.Forms.ListView();
      this.listBoxNum = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lbFormula = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.axCellQuoteTable = new AxCELL50Lib.AxCell();
      this.txtMC = new System.Windows.Forms.TextBox();
      this.btnSerach = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.upDownYear)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.upDownMonth)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axCellQuoteTable)).BeginInit();
      this.SuspendLayout();
      // 
      // upDownYear
      // 
      this.upDownYear.Location = new System.Drawing.Point(749, 84);
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
      this.cobDW.Location = new System.Drawing.Point(749, 53);
      this.cobDW.Name = "cobDW";
      this.cobDW.Size = new System.Drawing.Size(234, 20);
      this.cobDW.TabIndex = 17;
      // 
      // upDownMonth
      // 
      this.upDownMonth.Location = new System.Drawing.Point(749, 147);
      this.upDownMonth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.upDownMonth.Name = "upDownMonth";
      this.upDownMonth.Size = new System.Drawing.Size(120, 21);
      this.upDownMonth.TabIndex = 19;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnSerach);
      this.panel1.Controls.Add(this.txtMC);
      this.panel1.Controls.Add(this.cobO);
      this.panel1.Controls.Add(this.label6);
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
      this.panel1.TabIndex = 6;
      // 
      // cobO
      // 
      this.cobO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobO.FormattingEnabled = true;
      this.cobO.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<="});
      this.cobO.Location = new System.Drawing.Point(748, 22);
      this.cobO.Name = "cobO";
      this.cobO.Size = new System.Drawing.Size(121, 20);
      this.cobO.TabIndex = 21;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(668, 25);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 12);
      this.label6.TabIndex = 20;
      this.label6.Text = "与零关系";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(666, 56);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(29, 12);
      this.label5.TabIndex = 16;
      this.label5.Text = "单位";
      // 
      // txtMonth
      // 
      this.txtMonth.Location = new System.Drawing.Point(749, 179);
      this.txtMonth.Name = "txtMonth";
      this.txtMonth.Size = new System.Drawing.Size(100, 21);
      this.txtMonth.TabIndex = 12;
      // 
      // txtYear
      // 
      this.txtYear.Location = new System.Drawing.Point(749, 112);
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(100, 21);
      this.txtYear.TabIndex = 11;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(666, 115);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(53, 12);
      this.label7.TabIndex = 10;
      this.label7.Text = "绝对年份";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(666, 182);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 12);
      this.label4.TabIndex = 7;
      this.label4.Text = "绝对月份";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(666, 149);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 12);
      this.label3.TabIndex = 6;
      this.label3.Text = "相对月份";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(666, 86);
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
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(147, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 3;
      this.label1.Text = "引用报表";
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
      // panel2
      // 
      this.panel2.Controls.Add(this.axCellQuoteTable);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 248);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1050, 414);
      this.panel2.TabIndex = 7;
      // 
      // axCellQuoteTable
      // 
      this.axCellQuoteTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axCellQuoteTable.Enabled = true;
      this.axCellQuoteTable.Location = new System.Drawing.Point(0, 0);
      this.axCellQuoteTable.Name = "axCellQuoteTable";
      this.axCellQuoteTable.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCellQuoteTable.OcxState")));
      this.axCellQuoteTable.Size = new System.Drawing.Size(1050, 414);
      this.axCellQuoteTable.TabIndex = 5;
      this.axCellQuoteTable.MenuStart += new AxCELL50Lib._DCell2000Events_MenuStartEventHandler(this.axCellQuoteTable_MenuStart);
      this.axCellQuoteTable.MenuCommand += new AxCELL50Lib._DCell2000Events_MenuCommandEventHandler(this.axCellQuoteTable_MenuCommand);
      // 
      // txtMC
      // 
      this.txtMC.Location = new System.Drawing.Point(670, 206);
      this.txtMC.Name = "txtMC";
      this.txtMC.Size = new System.Drawing.Size(100, 21);
      this.txtMC.TabIndex = 22;
      // 
      // btnSerach
      // 
      this.btnSerach.Location = new System.Drawing.Point(794, 204);
      this.btnSerach.Name = "btnSerach";
      this.btnSerach.Size = new System.Drawing.Size(75, 23);
      this.btnSerach.TabIndex = 23;
      this.btnSerach.Text = "搜索";
      this.btnSerach.UseVisualStyleBackColor = true;
      this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
      // 
      // CheckEditForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1050, 662);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "CheckEditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "校验配置";
      ((System.ComponentModel.ISupportInitialize)(this.upDownYear)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.upDownMonth)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.axCellQuoteTable)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NumericUpDown upDownYear;
    private System.Windows.Forms.ComboBox cobDW;
    private System.Windows.Forms.NumericUpDown upDownMonth;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtMonth;
    private System.Windows.Forms.TextBox txtYear;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListView listViewQuoteTable;
    private System.Windows.Forms.ListBox listBoxNum;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbFormula;
    private System.Windows.Forms.ComboBox cobO;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Panel panel2;
    private AxCELL50Lib.AxCell axCellQuoteTable;
    private System.Windows.Forms.Button btnSerach;
    private System.Windows.Forms.TextBox txtMC;
  }
}