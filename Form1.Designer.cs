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
            this.filePath_txtBox.Location = new System.Drawing.Point(14, 48);
            this.filePath_txtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filePath_txtBox.Name = "filePath_txtBox";
            this.filePath_txtBox.Size = new System.Drawing.Size(114, 27);
            this.filePath_txtBox.TabIndex = 0;
            // 
            // parseTxt_btn
            // 
            this.parseTxt_btn.Location = new System.Drawing.Point(14, 87);
            this.parseTxt_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.parseTxt_btn.Name = "parseTxt_btn";
            this.parseTxt_btn.Size = new System.Drawing.Size(86, 31);
            this.parseTxt_btn.TabIndex = 1;
            this.parseTxt_btn.Text = "Parse Text";
            this.parseTxt_btn.UseVisualStyleBackColor = true;
            this.parseTxt_btn.Click += new System.EventHandler(this.parseText_btnClick);
            // 
            // resultsView_txtBox
            // 
            this.resultsView_txtBox.Location = new System.Drawing.Point(159, 19);
            this.resultsView_txtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultsView_txtBox.Multiline = true;
            this.resultsView_txtBox.Name = "resultsView_txtBox";
            this.resultsView_txtBox.ReadOnly = true;
            this.resultsView_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsView_txtBox.Size = new System.Drawing.Size(258, 257);
            this.resultsView_txtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsView_txtBox);
            this.Controls.Add(this.parseTxt_btn);
            this.Controls.Add(this.filePath_txtBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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