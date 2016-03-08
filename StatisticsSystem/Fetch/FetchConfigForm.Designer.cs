namespace StatisticsSystem.Fetch
{
  partial class FetchConfigForm
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.cobBBLX = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.colTarBBBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTarBBBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTarBBMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colTarDW = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSourBBBm = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSourBBBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSourBBMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSourDW = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colSourBBLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.cobBBLX);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1160, 51);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(38, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 3;
      this.label1.Text = "报表类型";
      // 
      // cobBBLX
      // 
      this.cobBBLX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobBBLX.FormattingEnabled = true;
      this.cobBBLX.Location = new System.Drawing.Point(120, 16);
      this.cobBBLX.Name = "cobBBLX";
      this.cobBBLX.Size = new System.Drawing.Size(121, 20);
      this.cobBBLX.TabIndex = 2;
      this.cobBBLX.SelectedValueChanged += new System.EventHandler(this.cobBBLX_SelectedValueChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.dataGridView1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 51);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1160, 482);
      this.panel2.TabIndex = 1;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTarBBBM,
            this.colTarBBBH,
            this.colTarBBMC,
            this.colTarDW,
            this.colSourBBBm,
            this.colSourBBBH,
            this.colSourBBMC,
            this.colSourDW,
            this.colSourBBLX});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(1160, 482);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
      // 
      // colTarBBBM
      // 
      this.colTarBBBM.DataPropertyName = "TARGETBBBM";
      this.colTarBBBM.HeaderText = "目标报表编码";
      this.colTarBBBM.Name = "colTarBBBM";
      this.colTarBBBM.ReadOnly = true;
      this.colTarBBBM.Visible = false;
      // 
      // colTarBBBH
      // 
      this.colTarBBBH.DataPropertyName = "targetBBBH";
      this.colTarBBBH.HeaderText = "目标报表表号";
      this.colTarBBBH.Name = "colTarBBBH";
      this.colTarBBBH.ReadOnly = true;
      // 
      // colTarBBMC
      // 
      this.colTarBBMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colTarBBMC.DataPropertyName = "TARGETBBMC";
      this.colTarBBMC.HeaderText = "目标报表名称";
      this.colTarBBMC.Name = "colTarBBMC";
      this.colTarBBMC.ReadOnly = true;
      // 
      // colTarDW
      // 
      this.colTarDW.DataPropertyName = "TARGETDWMC";
      this.colTarDW.HeaderText = "目标单位";
      this.colTarDW.Name = "colTarDW";
      this.colTarDW.ReadOnly = true;
      // 
      // colSourBBBm
      // 
      this.colSourBBBm.DataPropertyName = "SOURSEBBBM";
      this.colSourBBBm.HeaderText = "源头报表编码";
      this.colSourBBBm.Name = "colSourBBBm";
      this.colSourBBBm.ReadOnly = true;
      this.colSourBBBm.Visible = false;
      // 
      // colSourBBBH
      // 
      this.colSourBBBH.DataPropertyName = "SOURSEBBBH";
      this.colSourBBBH.HeaderText = "源头报表表号";
      this.colSourBBBH.Name = "colSourBBBH";
      this.colSourBBBH.ReadOnly = true;
      // 
      // colSourBBMC
      // 
      this.colSourBBMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.colSourBBMC.DataPropertyName = "SOURSEBBMC";
      this.colSourBBMC.HeaderText = "源头报表名称";
      this.colSourBBMC.Name = "colSourBBMC";
      this.colSourBBMC.ReadOnly = true;
      // 
      // colSourDW
      // 
      this.colSourDW.DataPropertyName = "SOURSEDWMC";
      this.colSourDW.HeaderText = "源头单位";
      this.colSourDW.Name = "colSourDW";
      this.colSourDW.ReadOnly = true;
      // 
      // colSourBBLX
      // 
      this.colSourBBLX.DataPropertyName = "SOURSEBBLX";
      this.colSourBBLX.HeaderText = "源头报表类型";
      this.colSourBBLX.Name = "colSourBBLX";
      this.colSourBBLX.ReadOnly = true;
      // 
      // FetchConfigForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1160, 533);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "FetchConfigForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "表格提取配置";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cobBBLX;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTarBBBM;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTarBBBH;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTarBBMC;
    private System.Windows.Forms.DataGridViewTextBoxColumn colTarDW;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSourBBBm;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSourBBBH;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSourBBMC;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSourDW;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSourBBLX;
  }
}