using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chpt15.AsyncForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //DisplayLength();
            label1.Text = "fetching...";
            using (HttpClient client = new HttpClient())
            {
                string txt = await client.GetStringAsync("http://www.baidu.com");
                label1.Text = txt.Length.ToString();
            }
        }

        async void DisplayLength()
        {
            label1.Text = "fetching...";
            using (HttpClient client = new HttpClient())
            {
                string txt = await client.GetStringAsync("http://www.baidu.com");
                label1.Text = txt.Length.ToString();
            }
        }
    }
}
