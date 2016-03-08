namespace StatisticsSystem.WordExport
{
  partial class WordConfigForm
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
      this.btnClose = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnDelete = new System.Windows.Forms.Button();
      this.colBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDOTMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colZQ = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.colDW = new System.Windows.Forms.DataGridViewComboBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(398, 328);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(82, 23);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(210, 328);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(82, 23);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "保存";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBM,
            this.colMC,
            this.colDOTMC,
            this.colZQ,
            this.colDW});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(772, 308);
      this.dataGridView1.TabIndex = 4;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(305, 328);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(82, 23);
      this.btnDelete.TabIndex = 7;
      this.btnDelete.Text = "删除";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // colBM
      // 
      this.colBM.DataPropertyName = "DOCBM";
      this.colBM.HeaderText = "编码";
      this.colBM.Name = "colBM";
      // 
      // colMC
      // 
      this.colMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colMC.DataPropertyName = "DOCMC";
      this.colMC.HeaderText = "模板名称";
      this.colMC.Name = "colMC";
      // 
      // colDOTMC
      // 
      this.colDOTMC.DataPropertyName = "DOTMC";
      this.colDOTMC.FillWeight = 150F;
      this.colDOTMC.HeaderText = "模板文件名称";
      this.colDOTMC.Name = "colDOTMC";
      // 
      // colZQ
      // 
      this.colZQ.DataPropertyName = "DOCZQ";
      this.colZQ.HeaderText = "周期";
      this.colZQ.Items.AddRange(new object[] {
            "",
            "月度",
            "年度"});
      this.colZQ.Name = "colZQ";
      // 
      // colDW
      // 
      this.colDW.DataPropertyName = "DWBM";
      this.colDW.HeaderText = "单位";
      this.colDW.Name = "colDW";
      this.colDW.Visible = false;
      this.colDW.Width = 200;
      // 
      // WordConfigForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(772, 366);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnDelete);
      this.Name = "WordConfigForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "模板配置";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableTypeConfigForm_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.DataGridViewTextBoxColumn colBM;
    private System.Windows.Forms.DataGridViewTextBoxColumn colMC;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDOTMC;
    private System.Windows.Forms.DataGridViewComboBoxColumn colZQ;
    private System.Windows.Forms.DataGridViewComboBoxColumn colDW;
  }
}