using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BodyMedia.WinFormsControls;
using BodyMedia.CoreClient;
using BodyMedia.CoreClient.Entities;
using System.IO;
using System.Threading;

namespace BodyMedia.WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OutputFolderTextBox.Text = Path.Combine(Environment.CurrentDirectory, "Output");
            bodyMediaAuthControl1.OnAuthenticated += (s, a) =>
                {
                    AuthenticateButton.Enabled = false;
                    bodyMediaAuthControl1.Enabled = false;

                    StartDate.Enabled = true;
                    EndDate.Enabled = true;
                    SleepButton.Enabled = true;
                    BurnButton.Enabled = true;
                    StepButton.Enabled = true;
                };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartDate.MaxDate = DateTime.Now.Date.AddDays(-1);
            StartDate.ValueChanged += OnStartDateChanged;
            EndDate.MaxDate = DateTime.Now.Date.AddDays(-1);
            EndDate.MinDate = StartDate.Value;
        }

        void OnStartDateChanged(object sender, EventArgs e)
        {
            if (EndDate.Value < StartDate.Value)
                EndDate.Value = StartDate.Value;
            EndDate.MinDate = StartDate.Value;
        }

        private void AuthenticateButton_Click(object sender, EventArgs e)
        {
            AuthenticateButton.Enabled = false;
            bodyMediaAuthControl1.Visible = true;
            bodyMediaAuthControl1.Initialize();
        }

        private void SleepButton_Click(object sender, EventArgs e)
        {
            var manager = new SleepManager(new RequestManager(bodyMediaAuthControl1.Manager));
            var dt = StartDate.Value;
            while (dt <= EndDate.Value)
            {
                var path = Path.Combine(OutputFolderTextBox.Text, string.Format("Sleep.{0}.xml", dt.ToString("yyyyMMdd")));
                if (!File.Exists(path))
                {
                    var data = manager.GetData(dt);
                    WriteToFile(path, data);
                }

                Thread.Sleep(500);
                dt = dt.AddDays(1);
            }

            MessageBox.Show("Done with sleep.");
        }

        private void BurnButton_Click(object sender, EventArgs e)
        {
            var manager = new BurnManager(new RequestManager(bodyMediaAuthControl1.Manager));
            var dt = StartDate.Value;
            while (dt <= EndDate.Value)
            {
                var path = Path.Combine(OutputFolderTextBox.Text, string.Format("Burn.{0}.xml", dt.ToString("yyyyMMdd")));
                if (!File.Exists(path))
                {
                    var data = manager.GetData(dt);
                    WriteToFile(path, data);
                }

                Thread.Sleep(500);
                dt = dt.AddDays(1);
            }

            MessageBox.Show("Done with burn.");
        }


        private void WriteToFile(string path, IXmlEntity entity)
        {
            var fi = new FileInfo(path);
            if (!fi.Directory.Exists)
                fi.Directory.Create();

            using (var file = new StreamWriter(path))
            {
                file.Write(entity.Xml);
            }
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            var manager = new StepManager(new RequestManager(bodyMediaAuthControl1.Manager));
            var dt = StartDate.Value;
            while (dt <= EndDate.Value)
            {
                var path = Path.Combine(OutputFolderTextBox.Text, string.Format("Step.{0}.xml", dt.ToString("yyyyMMdd")));
                if (!File.Exists(path))
                {
                    var data = manager.GetData(dt);
                    WriteToFile(path, data);
                }

                Thread.Sleep(500);
                dt = dt.AddDays(1);
            }

            MessageBox.Show("Done with steps.");
        }
    }
}
