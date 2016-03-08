namespace StatisticsSystem.SystemConfig
{
  partial class ExportExcelForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnExport = new System.Windows.Forms.Button();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.cobYear = new System.Windows.Forms.ComboBox();
      this.cobMonth = new System.Windows.Forms.ComboBox();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.worker = new System.ComponentModel.BackgroundWorker();
      this.lbPro = new System.Windows.Forms.Label();
      this.lbPath = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(157, 86);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "年份";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(157, 127);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "月份";
      // 
      // btnExport
      // 
      this.btnExport.Location = new System.Drawing.Point(272, 207);
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new System.Drawing.Size(75, 23);
      this.btnExport.TabIndex = 4;
      this.btnExport.Text = "选择文件";
      this.btnExport.UseVisualStyleBackColor = true;
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // openFileDialog
      // 
      this.openFileDialog.FileName = "openFileDialog1";
      // 
      // cobYear
      // 
      this.cobYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobYear.FormattingEnabled = true;
      this.cobYear.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015"});
      this.cobYear.Location = new System.Drawing.Point(301, 83);
      this.cobYear.Name = "cobYear";
      this.cobYear.Size = new System.Drawing.Size(121, 20);
      this.cobYear.TabIndex = 5;
      // 
      // cobMonth
      // 
      this.cobMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobMonth.FormattingEnabled = true;
      this.cobMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
      this.cobMonth.Location = new System.Drawing.Point(301, 124);
      this.cobMonth.Name = "cobMonth";
      this.cobMonth.Size = new System.Drawing.Size(121, 20);
      this.cobMonth.TabIndex = 6;
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(145, 279);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(358, 23);
      this.progressBar1.TabIndex = 7;
      // 
      // worker
      // 
      this.worker.WorkerReportsProgress = true;
      this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
      this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
      this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
      // 
      // lbPro
      // 
      this.lbPro.AutoSize = true;
      this.lbPro.Location = new System.Drawing.Point(145, 261);
      this.lbPro.Name = "lbPro";
      this.lbPro.Size = new System.Drawing.Size(0, 12);
      this.lbPro.TabIndex = 8;
      // 
      // lbPath
      // 
      this.lbPath.AutoSize = true;
      this.lbPath.Location = new System.Drawing.Point(159, 158);
      this.lbPath.Name = "lbPath";
      this.lbPath.Size = new System.Drawing.Size(41, 12);
      this.lbPath.TabIndex = 9;
      this.lbPath.Text = "label3";
      // 
      // ExportExcelForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(686, 352);
      this.Controls.Add(this.lbPath);
      this.Controls.Add(this.lbPro);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.cobMonth);
      this.Controls.Add(this.cobYear);
      this.Controls.Add(this.btnExport);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "ExportExcelForm";
      this.Text = "excel导入";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnExport;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ComboBox cobYear;
    private System.Windows.Forms.ComboBox cobMonth;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.ComponentModel.BackgroundWorker worker;
    private System.Windows.Forms.Label lbPro;
    private System.Windows.Forms.Label lbPath;
  }
}