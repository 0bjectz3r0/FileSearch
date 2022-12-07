namespace PractWork5
{
    partial class SearchForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileNameTetxBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.directorySelectButton = new System.Windows.Forms.Button();
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topDirectoryRadioButton = new System.Windows.Forms.RadioButton();
            this.allDirectoriesRadioButton = new System.Windows.Forms.RadioButton();
            this.considerFileSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.minNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fileNameTetxBox
            // 
            this.fileNameTetxBox.Location = new System.Drawing.Point(147, 36);
            this.fileNameTetxBox.Name = "fileNameTetxBox";
            this.fileNameTetxBox.Size = new System.Drawing.Size(239, 22);
            this.fileNameTetxBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(147, 76);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(89, 27);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // directorySelectButton
            // 
            this.directorySelectButton.Location = new System.Drawing.Point(252, 76);
            this.directorySelectButton.Name = "directorySelectButton";
            this.directorySelectButton.Size = new System.Drawing.Size(134, 27);
            this.directorySelectButton.TabIndex = 2;
            this.directorySelectButton.Text = "Select a directory";
            this.directorySelectButton.UseVisualStyleBackColor = true;
            this.directorySelectButton.Click += new System.EventHandler(this.DirectorySelectButton_Click);
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Location = new System.Drawing.Point(144, 8);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(44, 16);
            this.folderNameLabel.TabIndex = 3;
            this.folderNameLabel.Text = "label1";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 191);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(776, 244);
            this.listBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Indicate a file name:";
            // 
            // topDirectoryRadioButton
            // 
            this.topDirectoryRadioButton.AutoSize = true;
            this.topDirectoryRadioButton.Checked = true;
            this.topDirectoryRadioButton.Location = new System.Drawing.Point(413, 30);
            this.topDirectoryRadioButton.Name = "topDirectoryRadioButton";
            this.topDirectoryRadioButton.Size = new System.Drawing.Size(136, 20);
            this.topDirectoryRadioButton.TabIndex = 6;
            this.topDirectoryRadioButton.TabStop = true;
            this.topDirectoryRadioButton.Text = "Top directory only";
            this.topDirectoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // allDirectoriesRadioButton
            // 
            this.allDirectoriesRadioButton.AutoSize = true;
            this.allDirectoriesRadioButton.Location = new System.Drawing.Point(413, 56);
            this.allDirectoriesRadioButton.Name = "allDirectoriesRadioButton";
            this.allDirectoriesRadioButton.Size = new System.Drawing.Size(109, 20);
            this.allDirectoriesRadioButton.TabIndex = 7;
            this.allDirectoriesRadioButton.Text = "All directories";
            this.allDirectoriesRadioButton.UseVisualStyleBackColor = true;
            // 
            // considerFileSizeCheckBox
            // 
            this.considerFileSizeCheckBox.AutoSize = true;
            this.considerFileSizeCheckBox.Location = new System.Drawing.Point(615, 10);
            this.considerFileSizeCheckBox.Name = "considerFileSizeCheckBox";
            this.considerFileSizeCheckBox.Size = new System.Drawing.Size(158, 20);
            this.considerFileSizeCheckBox.TabIndex = 8;
            this.considerFileSizeCheckBox.Text = "Consider file size (KB)";
            this.considerFileSizeCheckBox.UseVisualStyleBackColor = true;
            this.considerFileSizeCheckBox.CheckStateChanged += new System.EventHandler(this.ConsiderFileSizeCheckBox_CheckStateChanged);
            // 
            // minNumericUpDown
            // 
            this.minNumericUpDown.Enabled = false;
            this.minNumericUpDown.Location = new System.Drawing.Point(628, 36);
            this.minNumericUpDown.Name = "minNumericUpDown";
            this.minNumericUpDown.Size = new System.Drawing.Size(130, 22);
            this.minNumericUpDown.TabIndex = 9;
            // 
            // maxNumericUpDown
            // 
            this.maxNumericUpDown.Enabled = false;
            this.maxNumericUpDown.Location = new System.Drawing.Point(628, 65);
            this.maxNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.maxNumericUpDown.Name = "maxNumericUpDown";
            this.maxNumericUpDown.Size = new System.Drawing.Size(130, 22);
            this.maxNumericUpDown.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Max:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(558, 102);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 13;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxNumericUpDown);
            this.Controls.Add(this.minNumericUpDown);
            this.Controls.Add(this.considerFileSizeCheckBox);
            this.Controls.Add(this.allDirectoriesRadioButton);
            this.Controls.Add(this.topDirectoryRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.folderNameLabel);
            this.Controls.Add(this.directorySelectButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fileNameTetxBox);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameTetxBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button directorySelectButton;
        private System.Windows.Forms.Label folderNameLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton topDirectoryRadioButton;
        private System.Windows.Forms.RadioButton allDirectoriesRadioButton;
        private System.Windows.Forms.CheckBox considerFileSizeCheckBox;
        private System.Windows.Forms.NumericUpDown minNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

