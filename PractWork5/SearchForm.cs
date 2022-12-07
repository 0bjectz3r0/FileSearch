using System;
using System.IO;
using System.Windows.Forms;

namespace PractWork5
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            folderNameLabel.Text = Environment.CurrentDirectory;
        }

        private void DirectorySelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() != DialogResult.OK)
                return;
            folderNameLabel.Text = folderBrowser.SelectedPath;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (topDirectoryRadioButton.Checked)
                {
                    if (considerFileSizeCheckBox.Checked)
                    {
                        if (dateTimePicker.Checked)
                        {
                            listBox.Items.Clear();
                            var directory = new DirectoryInfo(folderNameLabel.Text);
                            var files = directory.GetFiles($"*{fileNameTetxBox.Text}*");
                            foreach (var file in files)
                            {
                                if (file.Length >> 10 >= minNumericUpDown.Value && file.Length >> 10 <= maxNumericUpDown.Value &&
                                    file.CreationTime.Date >= DateTime.Now.Date && file.CreationTime.Date <= DateTime.Now.Date)
                                {
                                    listBox.Items.Add(file.FullName);
                                }
                            }
                        }
                        else
                        {
                            listBox.Items.Clear();
                            var directory = new DirectoryInfo(folderNameLabel.Text);
                            var files = directory.GetFiles($"*{fileNameTetxBox.Text}*");
                            foreach (var file in files)
                            {
                                if ((file.Length >> 10) >= minNumericUpDown.Value && (file.Length >> 10) <= maxNumericUpDown.Value)
                                {
                                    listBox.Items.Add(file.FullName);
                                }
                            }
                        }
                    }
                    else
                    {
                        listBox.Items.Clear();
                        var files = Directory.GetFiles(folderNameLabel.Text, $"*{fileNameTetxBox.Text}*");
                        foreach (var file in files)
                        {
                            listBox.Items.Add(file);
                        }
                    }
                }
                else
                {
                    if (considerFileSizeCheckBox.Checked)
                    {
                        if (dateTimePicker.Checked)
                        {
                            listBox.Items.Clear();
                            var directory = new DirectoryInfo(folderNameLabel.Text);
                            var files = directory.GetFiles($"*{fileNameTetxBox.Text}*", SearchOption.AllDirectories);
                            foreach (var file in files)
                            {
                                if ((file.Length >> 10 >= minNumericUpDown.Value && file.Length >> 10 <= maxNumericUpDown.Value) &&
                                    (file.CreationTime.Date >= dateTimePicker.Value && file.CreationTime.Date <= DateTime.Now.Date))
                                {
                                    listBox.Items.Add(file.FullName);
                                }
                            }
                        }
                        else
                        {
                            listBox.Items.Clear();
                            var directory = new DirectoryInfo(folderNameLabel.Text);
                            var files = directory.GetFiles($"*{fileNameTetxBox.Text}*");
                            foreach (var file in files)
                            {
                                if ((file.Length >> 10) >= minNumericUpDown.Value && (file.Length >> 10) <= maxNumericUpDown.Value)
                                {
                                    listBox.Items.Add(file.FullName);
                                }
                            }
                        }
                    }
                    else
                    {
                        listBox.Items.Clear();
                        var files = Directory.GetFiles(folderNameLabel.Text, $"*{fileNameTetxBox.Text}*", SearchOption.AllDirectories);
                        foreach (var file in files)
                        {
                            listBox.Items.Add(file);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Warning!"); }

        }

        private void ConsiderFileSizeCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (considerFileSizeCheckBox.Checked)
            {
                minNumericUpDown.Enabled = true;
                maxNumericUpDown.Enabled = true;
            }
            else
            {
                minNumericUpDown.Enabled = false;
                maxNumericUpDown.Enabled = false;
            }

        }
    }
}
