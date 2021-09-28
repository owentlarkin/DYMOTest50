
namespace DYMOTest50
{
 partial class Form1
 {
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
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
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   this.TB1 = new System.Windows.Forms.TextBox();
   this.RTB1 = new System.Windows.Forms.RichTextBox();
   this.SuspendLayout();
   // 
   // TB1
   // 
   this.TB1.Location = new System.Drawing.Point(12, 12);
   this.TB1.Name = "TB1";
   this.TB1.Size = new System.Drawing.Size(330, 23);
   this.TB1.TabIndex = 0;
   // 
   // RTB1
   // 
   this.RTB1.Location = new System.Drawing.Point(12, 52);
   this.RTB1.Name = "RTB1";
   this.RTB1.Size = new System.Drawing.Size(740, 373);
   this.RTB1.TabIndex = 1;
   this.RTB1.Text = "";
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.RTB1);
   this.Controls.Add(this.TB1);
   this.Name = "Form1";
   this.Text = "DYMOTest50";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.TextBox TB1;
  private System.Windows.Forms.RichTextBox RTB1;
 }
}

