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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.subcategoryLabel = new System.Windows.Forms.Label();
            this.resultListView = new System.Windows.Forms.ListView();
<<<<<<< HEAD
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.SizeLabel = new System.Windows.Forms.Label();
=======
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
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
            this.subCategoryComboBox.Location = new System.Drawing.Point(168, 27);
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
            this.subcategoryLabel.Location = new System.Drawing.Point(165, 7);
            this.subcategoryLabel.Name = "subcategoryLabel";
            this.subcategoryLabel.Size = new System.Drawing.Size(85, 16);
            this.subcategoryLabel.TabIndex = 5;
            this.subcategoryLabel.Text = "Subcategory";
            // 
            // resultListView
            // 
            this.resultListView.HideSelection = false;
            this.resultListView.Location = new System.Drawing.Point(29, 139);
            this.resultListView.Name = "resultListView";
<<<<<<< HEAD
            this.resultListView.Size = new System.Drawing.Size(762, 354);
=======
            this.resultListView.Size = new System.Drawing.Size(746, 354);
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
            this.resultListView.TabIndex = 6;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.List;
            // 
<<<<<<< HEAD
            // styleComboBox
            // 
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(312, 27);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(52, 24);
            this.styleComboBox.TabIndex = 7;
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Style";
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(388, 27);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(49, 24);
            this.sizeComboBox.TabIndex = 9;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(388, 8);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(34, 16);
            this.SizeLabel.TabIndex = 10;
            this.SizeLabel.Text = "Size";
            // 
=======
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 521);
<<<<<<< HEAD
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.styleComboBox);
=======
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.subcategoryLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.subCategoryComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox subCategoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label subcategoryLabel;
        private System.Windows.Forms.ListView resultListView;
<<<<<<< HEAD
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Label SizeLabel;
=======
>>>>>>> faa1180141c4e4c54ee49aadd8a4fa6db1bbef73
    }
}

