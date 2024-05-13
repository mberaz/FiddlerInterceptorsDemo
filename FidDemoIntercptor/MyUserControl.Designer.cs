namespace FidDemoIntercptor
{
    partial class MyUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnBodyOrHeaderSwitcher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(68, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(608, 315);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnBodyOrHeaderSwitcher
            // 
            this.btnBodyOrHeaderSwitcher.Location = new System.Drawing.Point(307, 40);
            this.btnBodyOrHeaderSwitcher.Name = "btnBodyOrHeaderSwitcher";
            this.btnBodyOrHeaderSwitcher.Size = new System.Drawing.Size(118, 23);
            this.btnBodyOrHeaderSwitcher.TabIndex = 1;
            this.btnBodyOrHeaderSwitcher.Text = "Body or Headers";
            this.btnBodyOrHeaderSwitcher.UseVisualStyleBackColor = true;
            this.btnBodyOrHeaderSwitcher.Click += new System.EventHandler(this.btnBodyOrHeaderSwitcher_Click);
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBodyOrHeaderSwitcher);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MyUserControl";
            this.Size = new System.Drawing.Size(724, 438);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnBodyOrHeaderSwitcher;
    }
}
