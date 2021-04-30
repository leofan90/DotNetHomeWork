using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork9_winform
{
    public partial class Form1 : Form
    {
        private string startUrl;
        private string rightUrl;
        private string wrongUrl;
        SimpleCrawler myCrawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
            initialURLBox1.DataBindings.Add("Text", this, "startUrl");
            rightURLrichTextBox1.DataBindings.Add("Text", this, "rightUrl");
            wrongURLrichTextBox2.DataBindings.Add("Text", this, "wrongUrl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCrawler.Main(startUrl);
            for (int i = 0; i < myCrawler.rightUrls.Length; i++)
            {
                rightUrl = myCrawler.rightUrls[i];
                Console.WriteLine(rightUrl);
            }
            for (int j = 0; j < myCrawler.wrongUrls.Length; j++)
            {
                wrongUrl = myCrawler.wrongUrls[j];
                Console.WriteLine(wrongUrl);
            }
        }

        private void initialURLBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rightURLrichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wrongURLrichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        internal string[] rightUrls;
        internal string[] wrongUrls;
        internal void Main(string startUrl)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            int w = 0, r = 0;
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0)
                {
                    wrongUrls[w] = strRef;
                    w++;
                    continue;
                }
                if (urls[strRef] == null)
                {
                    rightUrls[r] = strRef;
                    r++;
                    urls[strRef] = false;
                }
            }
        }
    }
}
