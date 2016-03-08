namespace StatisticsSystem.Check
{
  partial class CheckTableQuote
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
      this.btnClose.Location = new System.Drawing.Point(795, 604);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 15;
      this.btnClose.Text = "关闭";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnFinish
      // 
      this.btnFinish.Location = new System.Drawing.Point(697, 604);
      this.btnFinish.Name = "btnFinish";
      this.btnFinish.Size = new System.Drawing.Size(75, 23);
      this.btnFinish.TabIndex = 14;
      this.btnFinish.Text = "保存";
      this.btnFinish.UseVisualStyleBackColor = true;
      this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
      // 
      // btnLeftAll
      // 
      this.btnLeftAll.Location = new System.Drawing.Point(420, 324);
      this.btnLeftAll.Name = "btnLeftAll";
      this.btnLeftAll.Size = new System.Drawing.Size(75, 23);
      this.btnLeftAll.TabIndex = 13;
      this.btnLeftAll.Text = "<<";
      this.btnLeftAll.UseVisualStyleBackColor = true;
      this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
      // 
      // btnLeft
      // 
      this.btnLeft.Location = new System.Drawing.Point(420, 281);
      this.btnLeft.Name = "btnLeft";
      this.btnLeft.Size = new System.Drawing.Size(75, 23);
      this.btnLeft.TabIndex = 12;
      this.btnLeft.Text = "<";
      this.btnLeft.UseVisualStyleBackColor = true;
      this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
      // 
      // btnRightAll
      // 
      this.btnRightAll.Location = new System.Drawing.Point(420, 226);
      this.btnRightAll.Name = "btnRightAll";
      this.btnRightAll.Size = new System.Drawing.Size(75, 23);
      this.btnRightAll.TabIndex = 11;
      this.btnRightAll.Text = ">>";
      this.btnRightAll.UseVisualStyleBackColor = true;
      this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
      // 
      // btnRight
      // 
      this.btnRight.Location = new System.Drawing.Point(420, 184);
      this.btnRight.Name = "btnRight";
      this.btnRight.Size = new System.Drawing.Size(75, 23);
      this.btnRight.TabIndex = 10;
      this.btnRight.Text = ">";
      this.btnRight.UseVisualStyleBackColor = true;
      this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
      // 
      // listViewTarget
      // 
      this.listViewTarget.AllowColumnReorder = true;
      this.listViewTarget.AllowDrop = true;
      this.listViewTarget.FullRowSelect = true;
      this.listViewTarget.Location = new System.Drawing.Point(528, 72);
      this.listViewTarget.Name = "listViewTarget";
      this.listViewTarget.Size = new System.Drawing.Size(357, 485);
      this.listViewTarget.TabIndex = 9;
      this.listViewTarget.UseCompatibleStateImageBehavior = false;
      this.listViewTarget.View = System.Windows.Forms.View.Details;
      this.listViewTarget.DoubleClick += new System.EventHandler(this.listViewTarget_DoubleClick);
      // 
      // listViewSourse
      // 
      this.listViewSourse.FullRowSelect = true;
      this.listViewSourse.Location = new System.Drawing.Point(25, 72);
      this.listViewSourse.Name = "listViewSourse";
      this.listViewSourse.Size = new System.Drawing.Size(357, 485);
      this.listViewSourse.TabIndex = 8;
      this.listViewSourse.UseCompatibleStateImageBehavior = false;
      this.listViewSourse.View = System.Windows.Forms.View.Details;
      this.listViewSourse.DoubleClick += new System.EventHandler(this.listViewSourse_DoubleClick);
      // 
      // CheckTableQuote
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(911, 699);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnFinish);
      this.Controls.Add(this.btnLeftAll);
      this.Controls.Add(this.btnLeft);
      this.Controls.Add(this.btnRightAll);
      this.Controls.Add(this.btnRight);
      this.Controls.Add(this.listViewTarget);
      this.Controls.Add(this.listViewSourse);
      this.Name = "CheckTableQuote";
      this.Text = "报表引用";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TableQuoteForm_FormClosing);
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