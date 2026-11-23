using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace ViewWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                instagramToolStripMenuItem.Image = Image.FromFile("img/instagram.png");
                youtubeToolStripMenuItem.Image = Image.FromFile("img/youtube.png");
                facebookToolStripMenuItem.Image = Image.FromFile("img/facebook.png");
                telegramToolStripMenuItem.Image = Image.FromFile("img/telegram.png");
            }
            catch { }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.az");
        }

       
        private void instagramToolStripMenuItem_Click(object sender, EventArgs e) => webView21.Source = new Uri("https://www.instagram.com");
        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e) => webView21.Source = new Uri("https://www.youtube.com");
        private void facebookToolStripMenuItem_Click(object sender, EventArgs e) => webView21.Source = new Uri("https://www.facebook.com");
        private void telegramToolStripMenuItem_Click(object sender, EventArgs e) => webView21.Source = new Uri("https://www.telegram.org");

     
        private void arxaRengiDeyisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.BackColor = cd.Color;
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                    item.DropDown.BackColor = cd.Color;
            }
        }

        private void yaziRengiDeyisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.ForeColor = cd.Color;
                foreach (ToolStripMenuItem item in menuStrip1.Items)
                    item.DropDown.ForeColor = cd.Color;
            }
        }

      
        private void boyutToolStripMenuItem_Click(object sender, EventArgs e) => webView21.ZoomFactor += 0.1;

        private void kiciltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.ZoomFactor > 0.2)
                webView21.ZoomFactor -= 0.1;
        }

      
        private void capEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2?.ShowPrintUI(CoreWebView2PrintDialogKind.Browser);
        }

        private void cixisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıxış edilsinmi?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void haqqindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ViewWeb Brauzer Tətbiqi", "Əlaqə");
        }
    }
}
