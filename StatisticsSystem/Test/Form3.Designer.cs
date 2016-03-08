namespace StatisticsSystem
{
    partial class Form3
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
      this.axCell1 = new AxCELL50Lib.AxCell();
      ((System.ComponentModel.ISupportInitialize)(this.axCell1)).BeginInit();
      this.SuspendLayout();
      // 
      // axCell1
      // 
      this.axCell1.Enabled = true;
      this.axCell1.Location = new System.Drawing.Point(77, 54);
      this.axCell1.Name = "axCell1";
      this.axCell1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCell1.OcxState")));
      this.axCell1.Size = new System.Drawing.Size(378, 215);
      this.axCell1.TabIndex = 0;
      // 
      // Form3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(546, 410);
      this.Controls.Add(this.axCell1);
      this.Name = "Form3";
      this.Text = "Form3";
      ((System.ComponentModel.ISupportInitialize)(this.axCell1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private AxCELL50Lib.AxCell axCell1;
    }
}