namespace StatisticsSystem.WordExport
{
  partial class WordFormulaConfigForm
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnQuote = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.cobMB = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.colDOCJSXXID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDOCMC = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.colSQMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colJSMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
      this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
      this.label2 = new System.Windows.Forms.Label();
      this.txtMC = new System.Windows.Forms.TextBox();
      this.btnQuery = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnQuery);
      this.panel1.Controls.Add(this.txtMC);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.btnQuote);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.cobMB);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(822, 53);
      this.panel1.TabIndex = 0;
      // 
      // btnQuote
      // 
      this.btnQuote.Location = new System.Drawing.Point(715, 18);
      this.btnQuote.Name = "btnQuote";
      this.btnQuote.Size = new System.Drawing.Size(75, 23);
      this.btnQuote.TabIndex = 2;
      this.btnQuote.Text = "引用报表";
      this.btnQuote.UseVisualStyleBackColor = true;
      this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "选择模板";
      // 
      // cobMB
      // 
      this.cobMB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobMB.FormattingEnabled = true;
      this.cobMB.Location = new System.Drawing.Point(71, 20);
      this.cobMB.Name = "cobMB";
      this.cobMB.Size = new System.Drawing.Size(289, 20);
      this.cobMB.TabIndex = 0;
      this.cobMB.SelectedIndexChanged += new System.EventHandler(this.cobMB_SelectedIndexChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.dataGridView1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 53);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(822, 587);
      this.panel2.TabIndex = 1;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDOCJSXXID,
            this.colDOCMC,
            this.colSQMC,
            this.colJSMS,
            this.colEdit,
            this.colDel});
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(822, 587);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // colDOCJSXXID
      // 
      this.colDOCJSXXID.DataPropertyName = "DOCJSXXID";
      this.colDOCJSXXID.HeaderText = "ID";
      this.colDOCJSXXID.Name = "colDOCJSXXID";
      this.colDOCJSXXID.ReadOnly = true;
      // 
      // colDOCMC
      // 
      this.colDOCMC.DataPropertyName = "DOCMC";
      this.colDOCMC.HeaderText = "模板名称";
      this.colDOCMC.Name = "colDOCMC";
      this.colDOCMC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.colDOCMC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.colDOCMC.Visible = false;
      this.colDOCMC.Width = 260;
      // 
      // colSQMC
      // 
      this.colSQMC.DataPropertyName = "SQMC";
      this.colSQMC.HeaderText = "书签名称";
      this.colSQMC.Name = "colSQMC";
      this.colSQMC.Width = 200;
      // 
      // colJSMS
      // 
      this.colJSMS.DataPropertyName = "JSMS";
      this.colJSMS.HeaderText = "计算公式";
      this.colJSMS.Name = "colJSMS";
      this.colJSMS.Width = 200;
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
      // colDel
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.NullValue = "删除";
      this.colDel.DefaultCellStyle = dataGridViewCellStyle2;
      this.colDel.HeaderText = "删除";
      this.colDel.Name = "colDel";
      this.colDel.Width = 40;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(366, 23);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 12);
      this.label2.TabIndex = 3;
      this.label2.Text = "书签名称";
      // 
      // txtMC
      // 
      this.txtMC.Location = new System.Drawing.Point(425, 20);
      this.txtMC.Name = "txtMC";
      this.txtMC.Size = new System.Drawing.Size(119, 21);
      this.txtMC.TabIndex = 4;
      // 
      // btnQuery
      // 
      this.btnQuery.Location = new System.Drawing.Point(559, 18);
      this.btnQuery.Name = "btnQuery";
      this.btnQuery.Size = new System.Drawing.Size(75, 23);
      this.btnQuery.TabIndex = 5;
      this.btnQuery.Text = "查询";
      this.btnQuery.UseVisualStyleBackColor = true;
      this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
      // 
      // WordFormulaConfigForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(822, 640);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "WordFormulaConfigForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "模板管理";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnQuote;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cobMB;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDOCJSXXID;
    private System.Windows.Forms.DataGridViewComboBoxColumn colDOCMC;
    private System.Windows.Forms.DataGridViewTextBoxColumn colSQMC;
    private System.Windows.Forms.DataGridViewTextBoxColumn colJSMS;
    private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    private System.Windows.Forms.DataGridViewButtonColumn colDel;
    private System.Windows.Forms.Button btnQuery;
    private System.Windows.Forms.TextBox txtMC;
    private System.Windows.Forms.Label label2;
  }
}