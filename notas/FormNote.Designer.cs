namespace notas
{
    partial class FormNote
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNote));
      this.txtRichMain = new System.Windows.Forms.RichTextBox();
      this.txtRchLog = new System.Windows.Forms.RichTextBox();
      this.txtBoxMain = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtRichMain
      // 
      this.txtRichMain.AcceptsTab = true;
      this.txtRichMain.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtRichMain.Location = new System.Drawing.Point(12, 50);
      this.txtRichMain.Name = "txtRichMain";
      this.txtRichMain.Size = new System.Drawing.Size(588, 638);
      this.txtRichMain.TabIndex = 1;
      this.txtRichMain.TabStop = false;
      this.txtRichMain.Text = "";
      this.txtRichMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRichMain_KeyDown);
      this.txtRichMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRichMain_KeyPress);
      this.txtRichMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRichMain_KeyUp);
      // 
      // txtRchLog
      // 
      this.txtRchLog.Enabled = false;
      this.txtRchLog.Location = new System.Drawing.Point(12, 694);
      this.txtRchLog.Name = "txtRchLog";
      this.txtRchLog.Size = new System.Drawing.Size(588, 31);
      this.txtRchLog.TabIndex = 2;
      this.txtRchLog.TabStop = false;
      this.txtRchLog.Text = "";
      // 
      // txtBoxMain
      // 
      this.txtBoxMain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.txtBoxMain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.txtBoxMain.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBoxMain.Location = new System.Drawing.Point(12, 12);
      this.txtBoxMain.Name = "txtBoxMain";
      this.txtBoxMain.Size = new System.Drawing.Size(588, 32);
      this.txtBoxMain.TabIndex = 3;
      this.txtBoxMain.Enter += new System.EventHandler(this.txtBoxMain_Enter);
      this.txtBoxMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMain_KeyPress);
      this.txtBoxMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxMain_KeyUp);
      // 
      // FormNote
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(612, 737);
      this.Controls.Add(this.txtBoxMain);
      this.Controls.Add(this.txtRchLog);
      this.Controls.Add(this.txtRichMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormNote";
      this.Text = "FormNote";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNote_FormClosing);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormNote_KeyUp);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtRichMain;
        private System.Windows.Forms.RichTextBox txtRchLog;
    private System.Windows.Forms.TextBox txtBoxMain;
  }
}