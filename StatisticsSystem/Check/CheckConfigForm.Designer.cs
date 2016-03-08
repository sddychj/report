namespace StatisticsSystem.Check
{
	partial class CheckConfigForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnTableQuote = new System.Windows.Forms.Button();
      this.cobTable = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cobBBLX = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.openTableGrid = new System.Windows.Forms.DataGridView();
      this.XHCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TableCycleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colGX = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDW = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
      this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
      this.colSave = new System.Windows.Forms.DataGridViewButtonColumn();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.openTableGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnRefresh);
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Controls.Add(this.btnTableQuote);
      this.panel1.Controls.Add(this.cobTable);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.cobBBLX);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(957, 43);
      this.panel1.TabIndex = 3;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(787, 14);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 5;
      this.btnSave.Text = "保存";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnTableQuote
      // 
      this.btnTableQuote.Location = new System.Drawing.Point(706, 14);
      this.btnTableQuote.Name = "btnTableQuote";
      this.btnTableQuote.Size = new System.Drawing.Size(75, 23);
      this.btnTableQuote.TabIndex = 4;
      this.btnTableQuote.Text = "引用报表";
      this.btnTableQuote.UseVisualStyleBackColor = true;
      this.btnTableQuote.Click += new System.EventHandler(this.btnTableQuote_Click);
      // 
      // cobTable
      // 
      this.cobTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobTable.FormattingEnabled = true;
      this.cobTable.Location = new System.Drawing.Point(376, 16);
      this.cobTable.Name = "cobTable";
      this.cobTable.Size = new System.Drawing.Size(309, 20);
      this.cobTable.TabIndex = 3;
      this.cobTable.SelectedIndexChanged += new System.EventHandler(this.cobTable_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(341, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 12);
      this.label2.TabIndex = 2;
      this.label2.Text = "报表";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "报表类型";
      // 
      // cobBBLX
      // 
      this.cobBBLX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobBBLX.FormattingEnabled = true;
      this.cobBBLX.Location = new System.Drawing.Point(91, 16);
      this.cobBBLX.Name = "cobBBLX";
      this.cobBBLX.Size = new System.Drawing.Size(244, 20);
      this.cobBBLX.TabIndex = 0;
      this.cobBBLX.SelectedIndexChanged += new System.EventHandler(this.cobBBLX_SelectedIndexChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.openTableGrid);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 43);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(957, 371);
      this.panel2.TabIndex = 4;
      // 
      // openTableGrid
      // 
      this.openTableGrid.AllowUserToDeleteRows = false;
      this.openTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.openTableGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XHCol,
            this.TitleCol,
            this.TableCycleCol,
            this.colGX,
            this.colDW,
            this.colEdit,
            this.colDelete,
            this.colSave});
      this.openTableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.openTableGrid.Location = new System.Drawing.Point(0, 0);
      this.openTableGrid.Name = "openTableGrid";
      this.openTableGrid.RowTemplate.Height = 23;
      this.openTableGrid.Size = new System.Drawing.Size(957, 371);
      this.openTableGrid.TabIndex = 2;
      this.openTableGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.openTableGrid_CellContentClick);
      // 
      // XHCol
      // 
      this.XHCol.DataPropertyName = "JYXXID";
      this.XHCol.HeaderText = "id";
      this.XHCol.Name = "XHCol";
      this.XHCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.XHCol.Width = 50;
      // 
      // TitleCol
      // 
      this.TitleCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.TitleCol.DataPropertyName = "JYMC";
      this.TitleCol.HeaderText = "校验名称";
      this.TitleCol.Name = "TitleCol";
      // 
      // TableCycleCol
      // 
      this.TableCycleCol.DataPropertyName = "JYMS";
      this.TableCycleCol.HeaderText = "校验描述";
      this.TableCycleCol.Name = "TableCycleCol";
      // 
      // colGX
      // 
      this.colGX.DataPropertyName = "JYGX";
      this.colGX.HeaderText = "与零关系";
      this.colGX.Name = "colGX";
      this.colGX.ReadOnly = true;
      // 
      // colDW
      // 
      this.colDW.DataPropertyName = "DWMC";
      this.colDW.HeaderText = "单位名称";
      this.colDW.Name = "colDW";
      this.colDW.ReadOnly = true;
      // 
      // colEdit
      // 
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.NullValue = "公式编辑";
      this.colEdit.DefaultCellStyle = dataGridViewCellStyle1;
      this.colEdit.HeaderText = "公式编辑";
      this.colEdit.Name = "colEdit";
      this.colEdit.Text = "公式编辑";
      this.colEdit.Width = 70;
      // 
      // colDelete
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.NullValue = "删除";
      this.colDelete.DefaultCellStyle = dataGridViewCellStyle2;
      this.colDelete.HeaderText = "删除";
      this.colDelete.Name = "colDelete";
      this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.colDelete.Width = 40;
      // 
      // colSave
      // 
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.NullValue = "保存";
      this.colSave.DefaultCellStyle = dataGridViewCellStyle3;
      this.colSave.HeaderText = "保存";
      this.colSave.Name = "colSave";
      this.colSave.Text = "保存";
      this.colSave.Width = 40;
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(870, 14);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(75, 23);
      this.btnRefresh.TabIndex = 6;
      this.btnRefresh.Text = "刷新";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // CheckConfigForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(957, 414);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "CheckConfigForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "校验配置";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.openTableGrid)).EndInit();
      this.ResumeLayout(false);

		}

		#endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnTableQuote;
    private System.Windows.Forms.ComboBox cobTable;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cobBBLX;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.DataGridView openTableGrid;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.DataGridViewTextBoxColumn XHCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn TitleCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn TableCycleCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn colGX;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDW;
    private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    private System.Windows.Forms.DataGridViewButtonColumn colSave;
    private System.Windows.Forms.Button btnRefresh;


  }
}