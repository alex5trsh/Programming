﻿
namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectedItemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.OrderByComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedItemTableLayoutPanel.SuspendLayout();
            this.SelectedItemsGroupBox.SuspendLayout();
            this.ItemsTableLayoutPanel.SuspendLayout();
            this.ItemsGroupBox.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedItemTableLayoutPanel
            // 
            this.SelectedItemTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemTableLayoutPanel.ColumnCount = 1;
            this.SelectedItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SelectedItemTableLayoutPanel.Controls.Add(this.SelectedItemsGroupBox, 0, 0);
            this.SelectedItemTableLayoutPanel.Location = new System.Drawing.Point(283, 3);
            this.SelectedItemTableLayoutPanel.Name = "SelectedItemTableLayoutPanel";
            this.SelectedItemTableLayoutPanel.RowCount = 1;
            this.SelectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 494F));
            this.SelectedItemTableLayoutPanel.Size = new System.Drawing.Size(542, 494);
            this.SelectedItemTableLayoutPanel.TabIndex = 0;
            // 
            // SelectedItemsGroupBox
            // 
            this.SelectedItemsGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedItemsGroupBox.Controls.Add(this.CategoryComboBox);
            this.SelectedItemsGroupBox.Controls.Add(this.NameLabel);
            this.SelectedItemsGroupBox.Controls.Add(this.DescriptionLabel);
            this.SelectedItemsGroupBox.Controls.Add(this.CostLabel);
            this.SelectedItemsGroupBox.Controls.Add(this.IdLabel);
            this.SelectedItemsGroupBox.Controls.Add(this.CostTextBox);
            this.SelectedItemsGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedItemsGroupBox.Controls.Add(this.InfoTextBox);
            this.SelectedItemsGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectedItemsGroupBox.Name = "SelectedItemsGroupBox";
            this.SelectedItemsGroupBox.Size = new System.Drawing.Size(536, 488);
            this.SelectedItemsGroupBox.TabIndex = 0;
            this.SelectedItemsGroupBox.TabStop = false;
            this.SelectedItemsGroupBox.Text = "Selected Item";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(6, 80);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 9;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(61, 77);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(149, 21);
            this.CategoryComboBox.TabIndex = 8;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 111);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 238);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Description:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(6, 52);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(31, 13);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 26);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "ID:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Location = new System.Drawing.Point(61, 49);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(149, 20);
            this.CostTextBox.TabIndex = 3;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(9, 127);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(524, 95);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.Location = new System.Drawing.Point(9, 254);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(524, 166);
            this.InfoTextBox.TabIndex = 1;
            this.InfoTextBox.TextChanged += new System.EventHandler(this.InfoTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(61, 23);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(149, 20);
            this.IdTextBox.TabIndex = 0;
            // 
            // ItemsTableLayoutPanel
            // 
            this.ItemsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsTableLayoutPanel.ColumnCount = 1;
            this.ItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsTableLayoutPanel.Controls.Add(this.ItemsGroupBox, 0, 0);
            this.ItemsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            this.ItemsTableLayoutPanel.RowCount = 1;
            this.ItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.ItemsTableLayoutPanel.Size = new System.Drawing.Size(274, 494);
            this.ItemsTableLayoutPanel.TabIndex = 1;
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsGroupBox.Controls.Add(this.OrderByComboBox);
            this.ItemsGroupBox.Controls.Add(this.OrderByLabel);
            this.ItemsGroupBox.Controls.Add(this.FindTextBox);
            this.ItemsGroupBox.Controls.Add(this.FindLabel);
            this.ItemsGroupBox.Controls.Add(this.ItemsListBox);
            this.ItemsGroupBox.Controls.Add(this.ButtonsTableLayoutPanel);
            this.ItemsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Size = new System.Drawing.Size(268, 488);
            this.ItemsGroupBox.TabIndex = 0;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Items";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Location = new System.Drawing.Point(42, 20);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(220, 20);
            this.FindTextBox.TabIndex = 4;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(6, 23);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find:";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 47);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(256, 368);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddButton, 0, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(0, 445);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(268, 43);
            this.ButtonsTableLayoutPanel.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(92, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(83, 37);
            this.RemoveButton.TabIndex = 0;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(83, 37);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OrderByLabel
            // 
            this.OrderByLabel.AutoSize = true;
            this.OrderByLabel.Location = new System.Drawing.Point(11, 421);
            this.OrderByLabel.Name = "OrderByLabel";
            this.OrderByLabel.Size = new System.Drawing.Size(51, 13);
            this.OrderByLabel.TabIndex = 5;
            this.OrderByLabel.Text = "Order By:";
            // 
            // OrderByComboBox
            // 
            this.OrderByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderByComboBox.FormattingEnabled = true;
            this.OrderByComboBox.Location = new System.Drawing.Point(68, 418);
            this.OrderByComboBox.Name = "OrderByComboBox";
            this.OrderByComboBox.Size = new System.Drawing.Size(194, 21);
            this.OrderByComboBox.TabIndex = 9;
            this.OrderByComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderByComboBox_SelectedIndexChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsTableLayoutPanel);
            this.Controls.Add(this.SelectedItemTableLayoutPanel);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(830, 501);
            this.SelectedItemTableLayoutPanel.ResumeLayout(false);
            this.SelectedItemsGroupBox.ResumeLayout(false);
            this.SelectedItemsGroupBox.PerformLayout();
            this.ItemsTableLayoutPanel.ResumeLayout(false);
            this.ItemsGroupBox.ResumeLayout(false);
            this.ItemsGroupBox.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel SelectedItemTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ItemsTableLayoutPanel;
        private System.Windows.Forms.GroupBox ItemsGroupBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.GroupBox SelectedItemsGroupBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.ComboBox OrderByComboBox;
        private System.Windows.Forms.Label OrderByLabel;
    }
}
