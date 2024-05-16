namespace MarkdownRenderer
{
    partial class MarkdownRenderer
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
            this.textBoxMarkdown = new System.Windows.Forms.TextBox();
            this.comboBoxFlavor = new System.Windows.Forms.ComboBox();
            this.webBrowserPreview = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // textBoxMarkdown
            // 
            this.textBoxMarkdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxMarkdown.Location = new System.Drawing.Point(0, 0);
            this.textBoxMarkdown.Multiline = true;
            this.textBoxMarkdown.Name = "textBoxMarkdown";
            this.textBoxMarkdown.Size = new System.Drawing.Size(800, 388);
            this.textBoxMarkdown.TabIndex = 1;
            this.textBoxMarkdown.TextChanged += new System.EventHandler(this.textBoxMarkdown_TextChanged);
            // 
            // comboBoxFlavor
            // 
            this.comboBoxFlavor.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxFlavor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlavor.FormattingEnabled = true;
            this.comboBoxFlavor.Location = new System.Drawing.Point(0, 388);
            this.comboBoxFlavor.Name = "comboBoxFlavor";
            this.comboBoxFlavor.Size = new System.Drawing.Size(800, 21);
            this.comboBoxFlavor.TabIndex = 2;
            this.comboBoxFlavor.SelectedIndexChanged += new System.EventHandler(this.comboBoxFlavor_SelectedIndexChanged);
            // 
            // webBrowserPreview
            // 
            this.webBrowserPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPreview.Location = new System.Drawing.Point(0, 409);
            this.webBrowserPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPreview.Name = "webBrowserPreview";
            this.webBrowserPreview.Size = new System.Drawing.Size(800, 41);
            this.webBrowserPreview.TabIndex = 3;
            // 
            // MarkdownRenderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserPreview);
            this.Controls.Add(this.comboBoxFlavor);
            this.Controls.Add(this.textBoxMarkdown);
            this.Name = "MarkdownRenderer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarkdown;
        private System.Windows.Forms.ComboBox comboBoxFlavor;
        private System.Windows.Forms.WebBrowser webBrowserPreview;
    }
}

