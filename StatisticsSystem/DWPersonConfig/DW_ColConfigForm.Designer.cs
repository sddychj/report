namespace StatisticsSystem.DWPersonConfig
{
  partial class DW_ColConfigForm
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
      this.Tools = new System.Windows.Forms.ToolStrip();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnSave = new System.Windows.Forms.Button();
      this.cobDW = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.colZBBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colZBMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colBtnDw = new System.Windows.Forms.DataGridViewComboBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Tools
      // 
      this.Tools.Location = new System.Drawing.Point(0, 0);
      this.Tools.Name = "Tools";
      this.Tools.Size = new System.Drawing.Size(978, 25);
      this.Tools.TabIndex = 0;
      this.Tools.Text = "toolStrip1";
      this.Tools.Visible = false;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colZBBM,
            this.colZBMC,
            this.colBtnDw});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dataGridView1.Location = new System.Drawing.Point(0, 68);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(688, 581);
      this.dataGridView1.TabIndex = 2;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Controls.Add(this.cobDW);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(688, 62);
      this.panel1.TabIndex = 3;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(458, 25);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "保存";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // cobDW
      // 
      this.cobDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobDW.FormattingEnabled = true;
      this.cobDW.Location = new System.Drawing.Point(168, 25);
      this.cobDW.Name = "cobDW";
      this.cobDW.Size = new System.Drawing.Size(198, 20);
      this.cobDW.TabIndex = 6;
      this.cobDW.SelectedIndexChanged += new System.EventHandler(this.cobDW_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(100, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 5;
      this.label1.Text = "选择单位";
      // 
      // colZBBM
      // 
      this.colZBBM.DataPropertyName = "ZD";
      this.colZBBM.HeaderText = "列编码";
      this.colZBBM.Name = "colZBBM";
      // 
      // colZBMC
      // 
      this.colZBMC.DataPropertyName = "ZDZS";
      this.colZBMC.HeaderText = "列名称";
      this.colZBMC.Name = "colZBMC";
      this.colZBMC.Width = 260;
      // 
      // colBtnDw
      // 
      this.colBtnDw.DataPropertyName = "SFYC";
      this.colBtnDw.HeaderText = "是否隐藏";
      this.colBtnDw.Items.AddRange(new object[] {
            "否",
            "是"});
      this.colBtnDw.Name = "colBtnDw";
      this.colBtnDw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // DW_ColConfigForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(688, 649);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.Tools);
      this.Name = "DW_ColConfigForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "单位与列对应配置";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip Tools;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.ComboBox cobDW;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridViewTextBoxColumn colZBBM;
    private System.Windows.Forms.DataGridViewTextBoxColumn colZBMC;
    private System.Windows.Forms.DataGridViewComboBoxColumn colBtnDw;
  }
}