namespace StatisticsSystem.Fetch
{
  partial class FetchEditForm
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lbTableNum = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cobTargetDW = new System.Windows.Forms.ComboBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.cobSourseDW = new System.Windows.Forms.ComboBox();
      this.cobTableType = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.cobTableNum = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lbTableNum);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.cobTargetDW);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(504, 99);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "目标表配置";
      // 
      // lbTableNum
      // 
      this.lbTableNum.AutoSize = true;
      this.lbTableNum.Location = new System.Drawing.Point(192, 27);
      this.lbTableNum.Name = "lbTableNum";
      this.lbTableNum.Size = new System.Drawing.Size(41, 12);
      this.lbTableNum.TabIndex = 3;
      this.lbTableNum.Text = "label3";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(93, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "表号";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(93, 55);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "单位";
      // 
      // cobTargetDW
      // 
      this.cobTargetDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobTargetDW.FormattingEnabled = true;
      this.cobTargetDW.Location = new System.Drawing.Point(192, 52);
      this.cobTargetDW.Name = "cobTargetDW";
      this.cobTargetDW.Size = new System.Drawing.Size(165, 20);
      this.cobTargetDW.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.cobSourseDW);
      this.groupBox2.Controls.Add(this.cobTableType);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.cobTableNum);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(0, 99);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(504, 255);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "源头表配置";
      // 
      // cobSourseDW
      // 
      this.cobSourseDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobSourseDW.FormattingEnabled = true;
      this.cobSourseDW.Location = new System.Drawing.Point(192, 33);
      this.cobSourseDW.Name = "cobSourseDW";
      this.cobSourseDW.Size = new System.Drawing.Size(165, 20);
      this.cobSourseDW.TabIndex = 6;
      // 
      // cobTableType
      // 
      this.cobTableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobTableType.FormattingEnabled = true;
      this.cobTableType.Location = new System.Drawing.Point(192, 65);
      this.cobTableType.Name = "cobTableType";
      this.cobTableType.Size = new System.Drawing.Size(165, 20);
      this.cobTableType.TabIndex = 5;
      this.cobTableType.SelectedIndexChanged += new System.EventHandler(this.cobTableType_SelectedIndexChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(93, 107);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(29, 12);
      this.label7.TabIndex = 4;
      this.label7.Text = "表号";
      // 
      // cobTableNum
      // 
      this.cobTableNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobTableNum.FormattingEnabled = true;
      this.cobTableNum.Location = new System.Drawing.Point(192, 99);
      this.cobTableNum.Name = "cobTableNum";
      this.cobTableNum.Size = new System.Drawing.Size(259, 20);
      this.cobTableNum.TabIndex = 3;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(93, 73);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(53, 12);
      this.label6.TabIndex = 2;
      this.label6.Text = "报表类型";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(93, 41);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(29, 12);
      this.label5.TabIndex = 1;
      this.label5.Text = "单位";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnDelete);
      this.panel1.Controls.Add(this.btnClose);
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 303);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(504, 51);
      this.panel1.TabIndex = 2;
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(304, 16);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(110, 16);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "保存";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(207, 16);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 2;
      this.btnDelete.Text = "删除";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // FetchEditForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(504, 354);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "FetchEditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "表格提取配置";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FetchEditForm_FormClosing);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cobTargetDW;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lbTableNum;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cobSourseDW;
    private System.Windows.Forms.ComboBox cobTableType;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox cobTableNum;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnDelete;
  }
}