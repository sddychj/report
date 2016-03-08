namespace StatisticsSystem.Formula
{
  partial class FormulaConfigFormCol
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaConfigFormCol));
      this.axCellFormulaConfig = new AxCELL50Lib.AxCell();
      this.menuStripFormula = new System.Windows.Forms.MenuStrip();
      this.menuTable = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
      this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
      this.Tools = new System.Windows.Forms.ToolStrip();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      ((System.ComponentModel.ISupportInitialize)(this.axCellFormulaConfig)).BeginInit();
      this.menuStripFormula.SuspendLayout();
      this.Tools.SuspendLayout();
      this.SuspendLayout();
      // 
      // axCellFormulaConfig
      // 
      this.axCellFormulaConfig.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axCellFormulaConfig.Enabled = true;
      this.axCellFormulaConfig.Location = new System.Drawing.Point(0, 0);
      this.axCellFormulaConfig.Name = "axCellFormulaConfig";
      this.axCellFormulaConfig.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCellFormulaConfig.OcxState")));
      this.axCellFormulaConfig.Size = new System.Drawing.Size(844, 537);
      this.axCellFormulaConfig.TabIndex = 4;
      this.axCellFormulaConfig.MenuStart += new AxCELL50Lib._DCell2000Events_MenuStartEventHandler(this.axCellFormulaConfig_MenuStart);
      this.axCellFormulaConfig.MenuCommand += new AxCELL50Lib._DCell2000Events_MenuCommandEventHandler(this.axCellFormulaConfig_MenuCommand);
      // 
      // menuStripFormula
      // 
      this.menuStripFormula.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTable});
      this.menuStripFormula.Location = new System.Drawing.Point(0, 0);
      this.menuStripFormula.Name = "menuStripFormula";
      this.menuStripFormula.Size = new System.Drawing.Size(844, 25);
      this.menuStripFormula.TabIndex = 5;
      this.menuStripFormula.Text = "menuStrip1";
      this.menuStripFormula.Visible = false;
      // 
      // menuTable
      // 
      this.menuTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.menuSave,
            this.menuClose});
      this.menuTable.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
      this.menuTable.Name = "menuTable";
      this.menuTable.Size = new System.Drawing.Size(44, 21);
      this.menuTable.Text = "报表";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.toolStripSeparator1.MergeIndex = 4;
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
      // 
      // menuSave
      // 
      this.menuSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.menuSave.MergeIndex = 5;
      this.menuSave.Name = "menuSave";
      this.menuSave.Size = new System.Drawing.Size(152, 22);
      this.menuSave.Text = "保存";
      // 
      // menuClose
      // 
      this.menuClose.MergeAction = System.Windows.Forms.MergeAction.Insert;
      this.menuClose.MergeIndex = 6;
      this.menuClose.Name = "menuClose";
      this.menuClose.Size = new System.Drawing.Size(152, 22);
      this.menuClose.Text = "关闭";
      this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
      // 
      // Tools
      // 
      this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
      this.Tools.Location = new System.Drawing.Point(0, 0);
      this.Tools.Name = "Tools";
      this.Tools.Size = new System.Drawing.Size(844, 25);
      this.Tools.TabIndex = 6;
      this.Tools.Text = "toolStrip1";
      this.Tools.Visible = false;
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.saveToolStripButton.Text = "保存";
      // 
      // FormulaConfigFormCol
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(844, 537);
      this.Controls.Add(this.menuStripFormula);
      this.Controls.Add(this.Tools);
      this.Controls.Add(this.axCellFormulaConfig);
      this.Name = "FormulaConfigFormCol";
      this.Text = "整列公式配置";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormulaConfigForm_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.axCellFormulaConfig)).EndInit();
      this.menuStripFormula.ResumeLayout(false);
      this.menuStripFormula.PerformLayout();
      this.Tools.ResumeLayout(false);
      this.Tools.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private AxCELL50Lib.AxCell axCellFormulaConfig;
    private System.Windows.Forms.MenuStrip menuStripFormula;
    private System.Windows.Forms.ToolStripMenuItem menuTable;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem menuSave;
    private System.Windows.Forms.ToolStripMenuItem menuClose;
    private System.Windows.Forms.ToolStrip Tools;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
  }
}