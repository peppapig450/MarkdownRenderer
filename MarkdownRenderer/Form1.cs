using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;

namespace MarkdownRenderer
{
    public partial class MarkdownRenderer : Form
    {
        public MarkdownRenderer()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Populate the ComboBox with Markdown flavors
            comboBoxFlavor.Items.AddRange(new string[] { "CommonMark", "Github" });
            comboBoxFlavor.SelectedIndex = 0; // set default flavor
         }

        private MarkdownPipeline GetPipelineForFlavor(string flavor)
        {
            var pipelineBuilder = new MarkdownPipelineBuilder();

            switch (flavor.ToLower())
            {
                case "commonmark":
                    pipelineBuilder = pipelineBuilder.UseAdvancedExtensions();
                    break;
                case "github":
                    pipelineBuilder = pipelineBuilder.UseAdvancedExtensions().UseSoftlineBreakAsHardlineBreak();
                    break;
                default:
                    break;
            }

            return pipelineBuilder.Build();
        }

        private void RenderMarkdown()
        {
            string markdown = textBoxMarkdown.Text;
            string flavor = comboBoxFlavor.SelectedItem.ToString();
            var pipeline = GetPipelineForFlavor(flavor);
            string html = Markdown.ToHtml(markdown, pipeline);
            webBrowserPreview.DocumentText = html;
        }

        private void textBoxMarkdown_TextChanged(object sender, EventArgs e)
        {
            RenderMarkdown();
        }

        private void comboBoxFlavor_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderMarkdown();
        }
    }
}
