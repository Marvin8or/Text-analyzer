namespace TextParser
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
            this.filePath_txtBox = new System.Windows.Forms.TextBox();
            this.parseTxt_btn = new System.Windows.Forms.Button();
            this.resultsView_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePath_txtBox
            // 
            this.filePath_txtBox.Location = new System.Drawing.Point(12, 36);
            this.filePath_txtBox.Name = "filePath_txtBox";
            this.filePath_txtBox.Size = new System.Drawing.Size(100, 23);
            this.filePath_txtBox.TabIndex = 0;
            // 
            // parseTxt_btn
            // 
            this.parseTxt_btn.Location = new System.Drawing.Point(12, 65);
            this.parseTxt_btn.Name = "parseTxt_btn";
            this.parseTxt_btn.Size = new System.Drawing.Size(75, 23);
            this.parseTxt_btn.TabIndex = 1;
            this.parseTxt_btn.Text = "Parse Text";
            this.parseTxt_btn.UseVisualStyleBackColor = true;
            this.parseTxt_btn.Click += new System.EventHandler(this.parseText_btnClick);
            // 
            // resultsView_txtBox
            // 
            this.resultsView_txtBox.Location = new System.Drawing.Point(139, 14);
            this.resultsView_txtBox.Multiline = true;
            this.resultsView_txtBox.Name = "resultsView_txtBox";
            this.resultsView_txtBox.ReadOnly = true;
            this.resultsView_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsView_txtBox.Size = new System.Drawing.Size(226, 194);
            this.resultsView_txtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsView_txtBox);
            this.Controls.Add(this.parseTxt_btn);
            this.Controls.Add(this.filePath_txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox filePath_txtBox;
        private Button parseTxt_btn;
        private TextBox resultsView_txtBox;
        private Label label1;
    }
}