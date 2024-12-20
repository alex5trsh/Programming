﻿
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.CustomersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SelectedCustomerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.IsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.AddressControl = new ObjectOrientedPractics.View.Tabs.Controls.AddressControl();
            this.CustomersTableLayoutPanel.SuspendLayout();
            this.CustomersGroupBox.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.SelectedCustomerTableLayoutPanel.SuspendLayout();
            this.SelectedCustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersTableLayoutPanel
            // 
            this.CustomersTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersTableLayoutPanel.ColumnCount = 1;
            this.CustomersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomersTableLayoutPanel.Controls.Add(this.CustomersGroupBox, 0, 0);
            this.CustomersTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            this.CustomersTableLayoutPanel.RowCount = 1;
            this.CustomersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomersTableLayoutPanel.Size = new System.Drawing.Size(276, 495);
            this.CustomersTableLayoutPanel.TabIndex = 0;
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Controls.Add(this.ButtonsTableLayoutPanel);
            this.CustomersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(270, 489);
            this.CustomersGroupBox.TabIndex = 1;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 21);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(258, 420);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
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
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(0, 446);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(270, 43);
            this.ButtonsTableLayoutPanel.TabIndex = 0;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(93, 3);
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
            // SelectedCustomerTableLayoutPanel
            // 
            this.SelectedCustomerTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerTableLayoutPanel.ColumnCount = 1;
            this.SelectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SelectedCustomerTableLayoutPanel.Controls.Add(this.SelectedCustomerGroupBox, 0, 0);
            this.SelectedCustomerTableLayoutPanel.Location = new System.Drawing.Point(282, 3);
            this.SelectedCustomerTableLayoutPanel.Name = "SelectedCustomerTableLayoutPanel";
            this.SelectedCustomerTableLayoutPanel.RowCount = 1;
            this.SelectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.SelectedCustomerTableLayoutPanel.Size = new System.Drawing.Size(545, 495);
            this.SelectedCustomerTableLayoutPanel.TabIndex = 1;
            // 
            // SelectedCustomerGroupBox
            // 
            this.SelectedCustomerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerGroupBox.Controls.Add(this.DiscountsListBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.RemoveDiscountButton);
            this.SelectedCustomerGroupBox.Controls.Add(this.AddDiscountButton);
            this.SelectedCustomerGroupBox.Controls.Add(this.DiscountsLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.IsPriorityCheckBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.AddressControl);
            this.SelectedCustomerGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.IdLabel);
            this.SelectedCustomerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            this.SelectedCustomerGroupBox.Size = new System.Drawing.Size(539, 489);
            this.SelectedCustomerGroupBox.TabIndex = 1;
            this.SelectedCustomerGroupBox.TabStop = false;
            this.SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // IsPriorityCheckBox
            // 
            this.IsPriorityCheckBox.AutoSize = true;
            this.IsPriorityCheckBox.Location = new System.Drawing.Point(69, 84);
            this.IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            this.IsPriorityCheckBox.Size = new System.Drawing.Size(68, 17);
            this.IsPriorityCheckBox.TabIndex = 14;
            this.IsPriorityCheckBox.Text = "Is Priority";
            this.IsPriorityCheckBox.UseVisualStyleBackColor = true;
            this.IsPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(69, 51);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(464, 20);
            this.NameTextBox.TabIndex = 12;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(69, 25);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(112, 20);
            this.IdTextBox.TabIndex = 11;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(6, 54);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 8;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 28);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(21, 13);
            this.IdLabel.TabIndex = 5;
            this.IdLabel.Text = "ID:";
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Location = new System.Drawing.Point(6, 263);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(54, 13);
            this.DiscountsLabel.TabIndex = 15;
            this.DiscountsLabel.Text = "Discounts";
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(262, 279);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(87, 37);
            this.AddDiscountButton.TabIndex = 16;
            this.AddDiscountButton.Text = "Add";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(262, 322);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(87, 37);
            this.RemoveDiscountButton.TabIndex = 17;
            this.RemoveDiscountButton.Text = "Remove";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.Location = new System.Drawing.Point(0, 279);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(256, 108);
            this.DiscountsListBox.TabIndex = 18;
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Location = new System.Drawing.Point(6, 107);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(533, 136);
            this.AddressControl.TabIndex = 13;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedCustomerTableLayoutPanel);
            this.Controls.Add(this.CustomersTableLayoutPanel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(830, 501);
            this.CustomersTableLayoutPanel.ResumeLayout(false);
            this.CustomersGroupBox.ResumeLayout(false);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.SelectedCustomerTableLayoutPanel.ResumeLayout(false);
            this.SelectedCustomerGroupBox.ResumeLayout(false);
            this.SelectedCustomerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CustomersTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel SelectedCustomerTableLayoutPanel;
        private System.Windows.Forms.GroupBox SelectedCustomerGroupBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.GroupBox CustomersGroupBox;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.CheckBox IsPriorityCheckBox;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.Button RemoveDiscountButton;
        private System.Windows.Forms.Button AddDiscountButton;
        private System.Windows.Forms.Label DiscountsLabel;
    }
}
