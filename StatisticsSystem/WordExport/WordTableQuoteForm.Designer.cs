namespace StatisticsSystem.WordExport
{
  partial class WordTableQuoteForm
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
      this.btnFinish = new System.Windows.Forms.Button();
      this.btnLeftAll = new System.Windows.Forms.Button();
      this.btnLeft = new System.Windows.Forms.Button();
      this.btnRightAll = new System.Windows.Forms.Button();
      this.btnRight = new System.Windows.Forms.Button();
      this.listViewTarget = new System.Windows.Forms.ListView();
      this.listViewSourse = new System.Windows.Forms.ListView();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(813, 567);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 23;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnFinish
      // 
      this.btnFinish.Location = new System.Drawing.Point(715, 567);
      this.btnFinish.Name = "btnFinish";
      this.btnFinish.Size = new System.Drawing.Size(75, 23);
      this.btnFinish.TabIndex = 22;
      this.btnFinish.Text = "保存";
      this.btnFinish.UseVisualStyleBackColor = true;
      this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
      // 
      // btnLeftAll
      // 
      this.btnLeftAll.Location = new System.Drawing.Point(438, 287);
      this.btnLeftAll.Name = "btnLeftAll";
      this.btnLeftAll.Size = new System.Drawing.Size(75, 23);
      this.btnLeftAll.TabIndex = 21;
      this.btnLeftAll.Text = "<<";
      this.btnLeftAll.UseVisualStyleBackColor = true;
      this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
      // 
      // btnLeft
      // 
      this.btnLeft.Location = new System.Drawing.Point(438, 244);
      this.btnLeft.Name = "btnLeft";
      this.btnLeft.Size = new System.Drawing.Size(75, 23);
      this.btnLeft.TabIndex = 20;
      this.btnLeft.Text = "<";
      this.btnLeft.UseVisualStyleBackColor = true;
      this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
      // 
      // btnRightAll
      // 
      this.btnRightAll.Location = new System.Drawing.Point(438, 189);
      this.btnRightAll.Name = "btnRightAll";
      this.btnRightAll.Size = new System.Drawing.Size(75, 23);
      this.btnRightAll.TabIndex = 19;
      this.btnRightAll.Text = ">>";
      this.btnRightAll.UseVisualStyleBackColor = true;
      this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
      // 
      // btnRight
      // 
      this.btnRight.Location = new System.Drawing.Point(438, 147);
      this.btnRight.Name = "btnRight";
      this.btnRight.Size = new System.Drawing.Size(75, 23);
      this.btnRight.TabIndex = 18;
      this.btnRight.Text = ">";
      this.btnRight.UseVisualStyleBackColor = true;
      this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
      // 
      // listViewTarget
      // 
      this.listViewTarget.AllowColumnReorder = true;
      this.listViewTarget.AllowDrop = true;
      this.listViewTarget.FullRowSelect = true;
      this.listViewTarget.Location = new System.Drawing.Point(546, 35);
      this.listViewTarget.Name = "listViewTarget";
      this.listViewTarget.Size = new System.Drawing.Size(357, 485);
      this.listViewTarget.TabIndex = 17;
      this.listViewTarget.UseCompatibleStateImageBehavior = false;
      this.listViewTarget.View = System.Windows.Forms.View.Details;
      this.listViewTarget.DoubleClick += new System.EventHandler(this.listViewTarget_DoubleClick);
      // 
      // listViewSourse
      // 
      this.listViewSourse.FullRowSelect = true;
      this.listViewSourse.Location = new System.Drawing.Point(43, 35);
      this.listViewSourse.Name = "listViewSourse";
      this.listViewSourse.Size = new System.Drawing.Size(357, 485);
      this.listViewSourse.TabIndex = 16;
      this.listViewSourse.UseCompatibleStateImageBehavior = false;
      this.listViewSourse.View = System.Windows.Forms.View.Details;
      this.listViewSourse.DoubleClick += new System.EventHandler(this.listViewSourse_DoubleClick);
      // 
      // WordTableQuoteForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(947, 625);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnFinish);
      this.Controls.Add(this.btnLeftAll);
      this.Controls.Add(this.btnLeft);
      this.Controls.Add(this.btnRightAll);
      this.Controls.Add(this.btnRight);
      this.Controls.Add(this.listViewTarget);
      this.Controls.Add(this.listViewSourse);
      this.Name = "WordTableQuoteForm";
      this.Text = "模板引用报表";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnFinish;
    private System.Windows.Forms.Button btnLeftAll;
    private System.Windows.Forms.Button btnLeft;
    private System.Windows.Forms.Button btnRightAll;
    private System.Windows.Forms.Button btnRight;
    private System.Windows.Forms.ListView listViewTarget;
    private System.Windows.Forms.ListView listViewSourse;
  }
}