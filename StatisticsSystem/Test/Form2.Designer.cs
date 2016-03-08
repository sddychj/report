namespace StatisticsSystem
{
  partial class Form2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
      this.Tools = new System.Windows.Forms.ToolStrip();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.axCell1 = new AxCELL50Lib.AxCell();
      this.Tools.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axCell1)).BeginInit();
      this.SuspendLayout();
      // 
      // Tools
      // 
      this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
      this.Tools.Location = new System.Drawing.Point(0, 0);
      this.Tools.Name = "Tools";
      this.Tools.Size = new System.Drawing.Size(820, 25);
      this.Tools.TabIndex = 0;
      this.Tools.Text = "toolStrip1";
      this.Tools.Visible = false;
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton1";
      // 
      // axCell1
      // 
      this.axCell1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axCell1.Enabled = true;
      this.axCell1.Location = new System.Drawing.Point(0, 0);
      this.axCell1.Name = "axCell1";
      this.axCell1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCell1.OcxState")));
      this.axCell1.Size = new System.Drawing.Size(820, 644);
      this.axCell1.TabIndex = 0;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(820, 644);
      this.Controls.Add(this.Tools);
      this.Controls.Add(this.axCell1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.Tools.ResumeLayout(false);
      this.Tools.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axCell1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private AxCELL50Lib.AxCell axCell1;
    private System.Windows.Forms.ToolStrip Tools;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
  }
}