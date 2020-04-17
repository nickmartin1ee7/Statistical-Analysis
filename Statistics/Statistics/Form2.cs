using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void Form2_LoadAsync(object sender, EventArgs e)
        {
            var ds = Form1.DataSet;
            if (ds.Count > 100000)
                loadLabel.Text += $"{Environment.NewLine}{ds.Count:G} data points.";
            await Task.Run(() => { PopulateTextBox2(ds); });
            MessageBox.Show("Ping!");
        }

        private async Task PopulateTextBox(List<int> ds)
        {
            string dsVal = string.Empty;
            foreach (int s in ds)
            {
                await Task.Run(() =>
                {
                    dsVal += $"{s}{Environment.NewLine}";
                });
            }
            tBox.Text = dsVal;
            loadLabel.Visible = false;
            tBox.Visible = true;
        }
        private async Task PopulateTextBox2(List<int> ds)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ds.Count; i++)
            {
                await Task.Run(() =>
                {
                    sb.AppendLine($"{ds[i]}");
                });
                if (ds.Count > 250000 && i == ds.Count / 8)
                {
                    loadLabel.Visible = false;
                    tBox.Visible = true;
                    tBox.Text = sb.ToString();
                    tBox.Text += $"End of peak: {ds.Count / 8}";
                    break;
                }
            }
            loadLabel.Visible = false;
            tBox.Visible = true;
            tBox.Text = sb.ToString();
            sb.Clear();
        }
    }
}
