namespace StatisticsSystem.DWPersonConfig
{
  partial class DW_ZBBBMConfigForm
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
      this.colZBBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colZBMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colBtnDw = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnSave = new System.Windows.Forms.Button();
      this.cobDW = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Tools
      // 
      this.Tools.Location = new System.Drawing.Point(0, 0);
      this.Tools.Name = "Tools";
      this.Tools.Size = new System.Drawing.Size(951, 25);
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
      this.dataGridView1.Location = new System.Drawing.Point(0, 61);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(616, 488);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // colZBBM
      // 
      this.colZBBM.DataPropertyName = "ZBBM";
      this.colZBBM.HeaderText = "指标编码";
      this.colZBBM.Name = "colZBBM";
      // 
      // colZBMC
      // 
      this.colZBMC.DataPropertyName = "ZBMC";
      this.colZBMC.HeaderText = "指标名称";
      this.colZBMC.Name = "colZBMC";
      this.colZBMC.Width = 230;
      // 
      // colBtnDw
      // 
      this.colBtnDw.DataPropertyName = "XSYC";
      this.colBtnDw.HeaderText = "是否隐藏";
      this.colBtnDw.Items.AddRange(new object[] {
            "显示",
            "隐藏"});
      this.colBtnDw.Name = "colBtnDw";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Controls.Add(this.cobDW);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(616, 55);
      this.panel1.TabIndex = 2;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(418, 19);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "保存";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // cobDW
      // 
      this.cobDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobDW.FormattingEnabled = true;
      this.cobDW.Location = new System.Drawing.Point(128, 19);
      this.cobDW.Name = "cobDW";
      this.cobDW.Size = new System.Drawing.Size(198, 20);
      this.cobDW.TabIndex = 1;
      this.cobDW.SelectedIndexChanged += new System.EventHandler(this.cobDW_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(60, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "选择单位";
      // 
      // DW_ZBBBMConfigForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(616, 549);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.Tools);
      this.Name = "DW_ZBBBMConfigForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "单位与指标编码对应配置";
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