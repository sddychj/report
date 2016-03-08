namespace StatisticsSystem.Formula
{
  partial class FormulaConditionChoice
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
      this.cbbDW = new System.Windows.Forms.ComboBox();
      this.cbbYear = new System.Windows.Forms.ComboBox();
      this.cbbMonth = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnConfirm = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cbbDW
      // 
      this.cbbDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbDW.FormattingEnabled = true;
      this.cbbDW.Location = new System.Drawing.Point(141, 38);
      this.cbbDW.Name = "cbbDW";
      this.cbbDW.Size = new System.Drawing.Size(235, 20);
      this.cbbDW.TabIndex = 0;
      // 
      // cbbYear
      // 
      this.cbbYear.FormattingEnabled = true;
      this.cbbYear.Location = new System.Drawing.Point(141, 82);
      this.cbbYear.Name = "cbbYear";
      this.cbbYear.Size = new System.Drawing.Size(235, 20);
      this.cbbYear.TabIndex = 1;
      // 
      // cbbMonth
      // 
      this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbbMonth.FormattingEnabled = true;
      this.cbbMonth.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
      this.cbbMonth.Location = new System.Drawing.Point(141, 129);
      this.cbbMonth.Name = "cbbMonth";
      this.cbbMonth.Size = new System.Drawing.Size(235, 20);
      this.cbbMonth.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(68, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 12);
      this.label1.TabIndex = 3;
      this.label1.Text = "单位";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(68, 85);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 12);
      this.label2.TabIndex = 4;
      this.label2.Text = "年份";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(68, 132);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 12);
      this.label3.TabIndex = 5;
      this.label3.Text = "月份";
      // 
      // btnConfirm
      // 
      this.btnConfirm.Location = new System.Drawing.Point(107, 199);
      this.btnConfirm.Name = "btnConfirm";
      this.btnConfirm.Size = new System.Drawing.Size(75, 23);
      this.btnConfirm.TabIndex = 6;
      this.btnConfirm.Text = "确定";
      this.btnConfirm.UseVisualStyleBackColor = true;
      this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(230, 199);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 7;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // FormulaConditionChoice
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(445, 270);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnConfirm);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbbMonth);
      this.Controls.Add(this.cbbYear);
      this.Controls.Add(this.cbbDW);
      this.Name = "FormulaConditionChoice";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "公式条件选择";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbbDW;
    private System.Windows.Forms.ComboBox cbbYear;
    private System.Windows.Forms.ComboBox cbbMonth;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnConfirm;
    private System.Windows.Forms.Button btnClose;
  }
}