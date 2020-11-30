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
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.subcategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 16;
            this.resultListBox.Location = new System.Drawing.Point(28, 133);
            this.resultListBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(756, 356);
            this.resultListBox.TabIndex = 0;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(16, 27);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(159, 24);
            this.categoryComboBox.TabIndex = 1;
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(208, 27);
            this.subCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(136, 24);
            this.subCategoryComboBox.TabIndex = 2;
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
            this.subcategoryLabel.Location = new System.Drawing.Point(205, 7);
            this.subcategoryLabel.Name = "subcategoryLabel";
            this.subcategoryLabel.Size = new System.Drawing.Size(85, 16);
            this.subcategoryLabel.TabIndex = 5;
            this.subcategoryLabel.Text = "Subcategory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 521);
            this.Controls.Add(this.subcategoryLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.subCategoryComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.resultListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox subCategoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label subcategoryLabel;
    }
}

