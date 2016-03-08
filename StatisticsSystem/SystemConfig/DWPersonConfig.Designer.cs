namespace StatisticsSystem.SystemConfig
{
  partial class DWPersonConfig
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
      this.cobDW = new System.Windows.Forms.ComboBox();
      this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.COLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(417, 12);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(204, 12);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "添加";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.COLName});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dataGridView1.Location = new System.Drawing.Point(0, 57);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(607, 345);
      this.dataGridView1.TabIndex = 4;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(324, 12);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 7;
      this.btnDelete.Text = "删除";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // cobDW
      // 
      this.cobDW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobDW.FormattingEnabled = true;
      this.cobDW.Location = new System.Drawing.Point(58, 12);
      this.cobDW.Name = "cobDW";
      this.cobDW.Size = new System.Drawing.Size(121, 20);
      this.cobDW.TabIndex = 8;
      // 
      // ColId
      // 
      this.ColId.DataPropertyName = "ID";
      this.ColId.HeaderText = "编码";
      this.ColId.Name = "ColId";
      this.ColId.Visible = false;
      // 
      // COLName
      // 
      this.COLName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.COLName.DataPropertyName = "DWMC";
      this.COLName.HeaderText = "单位名称";
      this.COLName.Name = "COLName";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnDelete);
      this.panel1.Controls.Add(this.cobDW);
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Controls.Add(this.btnClose);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(607, 51);
      this.panel1.TabIndex = 9;
      // 
      // DWPersonConfig
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(607, 402);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "DWPersonConfig";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "单位个性化配置";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
    private System.Windows.Forms.DataGridViewTextBoxColumn COLName;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.ComboBox cobDW;
    private System.Windows.Forms.Panel panel1;

  }
}