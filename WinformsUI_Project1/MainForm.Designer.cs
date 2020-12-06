namespace WinformsUI_Project1
{
    partial class MainForm
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
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection1 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection1 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.subcategoryLabel = new System.Windows.Forms.Label();
            this.resultListView = new System.Windows.Forms.ListView();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.colourComboBox = new System.Windows.Forms.ComboBox();
            this.colourLabel = new System.Windows.Forms.Label();
            this.productLineComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.lenguageToggleButton = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.avaliableButton = new System.Windows.Forms.Button();
            this.nonAvaliableButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minLPTextBox = new System.Windows.Forms.TextBox();
            this.maxLPTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lenguageToggleButton)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(16, 27);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(125, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(149, 27);
            this.subCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(111, 24);
            this.subCategoryComboBox.TabIndex = 2;
            this.subCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.subCategoryComboBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(13, 7);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(63, 16);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category";
            // 
            // subcategoryLabel
            // 
            this.subcategoryLabel.AutoSize = true;
            this.subcategoryLabel.Location = new System.Drawing.Point(146, 7);
            this.subcategoryLabel.Name = "subcategoryLabel";
            this.subcategoryLabel.Size = new System.Drawing.Size(85, 16);
            this.subcategoryLabel.TabIndex = 5;
            this.subcategoryLabel.Text = "Subcategory";
            // 
            // resultListView
            // 
            this.resultListView.HideSelection = false;
            this.resultListView.Location = new System.Drawing.Point(16, 139);
            this.resultListView.MultiSelect = false;
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(654, 349);
            this.resultListView.TabIndex = 6;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.List;
            this.resultListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultListView_MouseDoubleClick);
            // 
            // styleComboBox
            // 
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(298, 27);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(49, 24);
            this.styleComboBox.TabIndex = 7;
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Style";
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(408, 27);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(49, 24);
            this.sizeComboBox.TabIndex = 9;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(405, 7);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(34, 16);
            this.SizeLabel.TabIndex = 10;
            this.SizeLabel.Text = "Size";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(353, 27);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(49, 24);
            this.classComboBox.TabIndex = 11;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(353, 7);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(42, 16);
            this.classLabel.TabIndex = 12;
            this.classLabel.Text = "Class";
            // 
            // colourComboBox
            // 
            this.colourComboBox.FormattingEnabled = true;
            this.colourComboBox.Location = new System.Drawing.Point(463, 27);
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(68, 24);
            this.colourComboBox.TabIndex = 13;
            this.colourComboBox.SelectedIndexChanged += new System.EventHandler(this.colourComboBox_SelectedIndexChanged);
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(463, 7);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(47, 16);
            this.colourLabel.TabIndex = 14;
            this.colourLabel.Text = "Colour";
            // 
            // productLineComboBox
            // 
            this.productLineComboBox.FormattingEnabled = true;
            this.productLineComboBox.Location = new System.Drawing.Point(537, 27);
            this.productLineComboBox.Name = "productLineComboBox";
            this.productLineComboBox.Size = new System.Drawing.Size(96, 24);
            this.productLineComboBox.TabIndex = 15;
            this.productLineComboBox.SelectedIndexChanged += new System.EventHandler(this.productLineComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "ProductLine";
            // 
            // queryTextBox
            // 
            this.queryTextBox.Location = new System.Drawing.Point(16, 99);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(215, 22);
            this.queryTextBox.TabIndex = 17;
            this.queryTextBox.TextChanged += new System.EventHandler(this.queryTextBox_TextChanged);
            // 
            // lenguageToggleButton
            // 
            activeStateCollection1.BackColor = System.Drawing.SystemColors.Window;
            activeStateCollection1.BorderColor = System.Drawing.Color.DarkGray;
            activeStateCollection1.ForeColor = System.Drawing.Color.Black;
            activeStateCollection1.HoverColor = System.Drawing.Color.WhiteSmoke;
            activeStateCollection1.Text = "FR";
            this.lenguageToggleButton.ActiveState = activeStateCollection1;
            this.lenguageToggleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lenguageToggleButton.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection1.BackColor = System.Drawing.SystemColors.Window;
            inactiveStateCollection1.BorderColor = System.Drawing.Color.DarkGray;
            inactiveStateCollection1.HoverColor = System.Drawing.Color.WhiteSmoke;
            inactiveStateCollection1.Text = "EN";
            this.lenguageToggleButton.InactiveState = inactiveStateCollection1;
            this.lenguageToggleButton.Location = new System.Drawing.Point(699, 409);
            this.lenguageToggleButton.MinimumSize = new System.Drawing.Size(52, 20);
            this.lenguageToggleButton.Name = "lenguageToggleButton";
            this.lenguageToggleButton.Size = new System.Drawing.Size(86, 28);
            sliderCollection1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lenguageToggleButton.Slider = sliderCollection1;
            this.lenguageToggleButton.TabIndex = 18;
            this.lenguageToggleButton.Click += new System.EventHandler(this.lenguageToggleButton_Click);
            // 
            // avaliableButton
            // 
            this.avaliableButton.Location = new System.Drawing.Point(690, 11);
            this.avaliableButton.Name = "avaliableButton";
            this.avaliableButton.Size = new System.Drawing.Size(116, 40);
            this.avaliableButton.TabIndex = 19;
            this.avaliableButton.Text = "Available Products";
            this.avaliableButton.UseVisualStyleBackColor = true;
            this.avaliableButton.Click += new System.EventHandler(this.avaliableButton_Click);
            // 
            // nonAvaliableButton
            // 
            this.nonAvaliableButton.Location = new System.Drawing.Point(689, 68);
            this.nonAvaliableButton.Name = "nonAvaliableButton";
            this.nonAvaliableButton.Size = new System.Drawing.Size(116, 41);
            this.nonAvaliableButton.TabIndex = 20;
            this.nonAvaliableButton.Text = "Non Avaliable Products";
            this.nonAvaliableButton.UseVisualStyleBackColor = true;
            this.nonAvaliableButton.Click += new System.EventHandler(this.nonAvaliableButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(690, 457);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 31);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Search ProducModel";
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(260, 99);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(212, 22);
            this.productTextBox.TabIndex = 23;
            this.productTextBox.TextChanged += new System.EventHandler(this.productTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Search Product";
            // 
            // minLPTextBox
            // 
            this.minLPTextBox.Location = new System.Drawing.Point(499, 99);
            this.minLPTextBox.Name = "minLPTextBox";
            this.minLPTextBox.Size = new System.Drawing.Size(60, 22);
            this.minLPTextBox.TabIndex = 25;
            // 
            // maxLPTextBox
            // 
            this.maxLPTextBox.Location = new System.Drawing.Point(573, 99);
            this.maxLPTextBox.Name = "maxLPTextBox";
            this.maxLPTextBox.Size = new System.Drawing.Size(60, 22);
            this.maxLPTextBox.TabIndex = 26;
            this.maxLPTextBox.TextChanged += new System.EventHandler(this.maxLPTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Min Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Max Price";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 521);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxLPTextBox);
            this.Controls.Add(this.minLPTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.nonAvaliableButton);
            this.Controls.Add(this.avaliableButton);
            this.Controls.Add(this.lenguageToggleButton);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productLineComboBox);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.subcategoryLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.subCategoryComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lenguageToggleButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox subCategoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label subcategoryLabel;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox colourComboBox;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.ComboBox productLineComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox queryTextBox;
        private Syncfusion.Windows.Forms.Tools.ToggleButton lenguageToggleButton;
        private System.Windows.Forms.Button avaliableButton;
        private System.Windows.Forms.Button nonAvaliableButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minLPTextBox;
        private System.Windows.Forms.TextBox maxLPTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

