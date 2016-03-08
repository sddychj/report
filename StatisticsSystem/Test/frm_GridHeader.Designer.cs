namespace StatisticsSystem
{
  partial class frm_GridHeader
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
      this.btn_Excel = new System.Windows.Forms.Button();
      this.txt_SheetName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btn_Close = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txt_BBBH = new System.Windows.Forms.TextBox();
      this.txt_BMMC = new System.Windows.Forms.TextBox();
      this.lb_bbxz = new System.Windows.Forms.Label();
      this.txt_BBXZ = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btn_Excel
      // 
      this.btn_Excel.Location = new System.Drawing.Point(89, 186);
      this.btn_Excel.Name = "btn_Excel";
      this.btn_Excel.Size = new System.Drawing.Size(137, 23);
      this.btn_Excel.TabIndex = 0;
      this.btn_Excel.Text = "选择Excel文件";
      this.btn_Excel.UseVisualStyleBackColor = true;
      this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
      // 
      // txt_SheetName
      // 
      this.txt_SheetName.Location = new System.Drawing.Point(246, 117);
      this.txt_SheetName.Name = "txt_SheetName";
      this.txt_SheetName.Size = new System.Drawing.Size(100, 21);
      this.txt_SheetName.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(90, 120);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(125, 12);
      this.label1.TabIndex = 5;
      this.label1.Text = "请输入Excel中Sheet名";
      // 
      // btn_Close
      // 
      this.btn_Close.Location = new System.Drawing.Point(257, 186);
      this.btn_Close.Name = "btn_Close";
      this.btn_Close.Size = new System.Drawing.Size(75, 23);
      this.btn_Close.TabIndex = 6;
      this.btn_Close.Text = "关闭";
      this.btn_Close.UseVisualStyleBackColor = true;
      this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(90, 30);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 12);
      this.label2.TabIndex = 7;
      this.label2.Text = "报表编号";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(90, 60);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 12);
      this.label3.TabIndex = 8;
      this.label3.Text = "报表名称";
      // 
      // txt_BBBH
      // 
      this.txt_BBBH.Location = new System.Drawing.Point(246, 27);
      this.txt_BBBH.Name = "txt_BBBH";
      this.txt_BBBH.Size = new System.Drawing.Size(208, 21);
      this.txt_BBBH.TabIndex = 9;
      // 
      // txt_BMMC
      // 
      this.txt_BMMC.Location = new System.Drawing.Point(246, 57);
      this.txt_BMMC.Name = "txt_BMMC";
      this.txt_BMMC.Size = new System.Drawing.Size(100, 21);
      this.txt_BMMC.TabIndex = 10;
      // 
      // lb_bbxz
      // 
      this.lb_bbxz.AutoSize = true;
      this.lb_bbxz.Location = new System.Drawing.Point(90, 90);
      this.lb_bbxz.Name = "lb_bbxz";
      this.lb_bbxz.Size = new System.Drawing.Size(53, 12);
      this.lb_bbxz.TabIndex = 11;
      this.lb_bbxz.Text = "报表性质";
      // 
      // txt_BBXZ
      // 
      this.txt_BBXZ.Location = new System.Drawing.Point(246, 87);
      this.txt_BBXZ.Name = "txt_BBXZ";
      this.txt_BBXZ.Size = new System.Drawing.Size(100, 21);
      this.txt_BBXZ.TabIndex = 12;
      // 
      // frm_GridHeader
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(486, 261);
      this.Controls.Add(this.txt_BBXZ);
      this.Controls.Add(this.lb_bbxz);
      this.Controls.Add(this.txt_BMMC);
      this.Controls.Add(this.txt_BBBH);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btn_Close);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txt_SheetName);
      this.Controls.Add(this.btn_Excel);
      this.Name = "frm_GridHeader";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "新建表头";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_Excel;
    private System.Windows.Forms.TextBox txt_SheetName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_Close;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txt_BBBH;
    private System.Windows.Forms.TextBox txt_BMMC;
    private System.Windows.Forms.Label lb_bbxz;
    private System.Windows.Forms.TextBox txt_BBXZ;

  }
}