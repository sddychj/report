namespace StatisticsSystem
{
  partial class frm_Cell
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cell));
      this.axCell1 = new AxCELL50Lib.AxCell();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.gggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      ((System.ComponentModel.ISupportInitialize)(this.axCell1)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // axCell1
      // 
      this.axCell1.ContextMenuStrip = this.contextMenuStrip1;
      this.axCell1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axCell1.Enabled = true;
      this.axCell1.Location = new System.Drawing.Point(0, 24);
      this.axCell1.Name = "axCell1";
      this.axCell1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCell1.OcxState")));
      this.axCell1.Size = new System.Drawing.Size(813, 633);
      this.axCell1.TabIndex = 0;
      this.axCell1.CalcFunc += new AxCELL50Lib._DCell2000Events_CalcFuncEventHandler(this.axCell1_CalcFunc);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gggToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(89, 26);
      // 
      // gggToolStripMenuItem
      // 
      this.gggToolStripMenuItem.Name = "gggToolStripMenuItem";
      this.gggToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
      this.gggToolStripMenuItem.Text = "ggg";
      // 
      // 新建ToolStripMenuItem
      // 
      this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.报表ToolStripMenuItem});
      this.新建ToolStripMenuItem.MergeIndex = 100;
      this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
      this.新建ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
      this.新建ToolStripMenuItem.Text = "报表";
      // 
      // 报表ToolStripMenuItem
      // 
      this.报表ToolStripMenuItem.MergeIndex = 101;
      this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
      this.报表ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
      this.报表ToolStripMenuItem.Text = "新建";
      this.报表ToolStripMenuItem.Click += new System.EventHandler(this.报表ToolStripMenuItem_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.AllowDrop = true;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(813, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // frm_Cell
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(813, 657);
      this.Controls.Add(this.axCell1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "frm_Cell";
      this.ShowIcon = false;
      this.Text = "Form2";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Form2_Load);
      ((System.ComponentModel.ISupportInitialize)(this.axCell1)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private AxCELL50Lib.AxCell axCell1;
    private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem gggToolStripMenuItem;
  }
}