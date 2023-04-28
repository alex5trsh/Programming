
namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DeleteRectangleButton = new System.Windows.Forms.Button();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.RectanglesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.RectanglesTableLayoutPanel.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesPanel.Location = new System.Drawing.Point(401, 3);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(392, 467);
            this.RectanglesPanel.TabIndex = 33;
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(11, 32);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(304, 134);
            this.RectanglesListBox.TabIndex = 20;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.Rectangles5ListBox_SelectedIndexChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(6, 16);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 21;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(66, 364);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 29;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(19, 367);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 27;
            this.HeightLabel.Text = "Height:";
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_button_png;
            this.AddRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Location = new System.Drawing.Point(44, 172);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(50, 50);
            this.AddRectangleButton.TabIndex = 18;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(8, 244);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(104, 13);
            this.SelectedRectangleLabel.TabIndex = 22;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(66, 338);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 30;
            // 
            // DeleteRectangleButton
            // 
            this.DeleteRectangleButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_delete_button_png;
            this.DeleteRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteRectangleButton.FlatAppearance.BorderSize = 0;
            this.DeleteRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRectangleButton.Location = new System.Drawing.Point(165, 172);
            this.DeleteRectangleButton.Name = "DeleteRectangleButton";
            this.DeleteRectangleButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteRectangleButton.TabIndex = 19;
            this.DeleteRectangleButton.UseVisualStyleBackColor = true;
            this.DeleteRectangleButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(22, 341);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 26;
            this.WidthLabel.Text = "Width:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(66, 312);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 20);
            this.YTextBox.TabIndex = 31;
            this.YTextBox.Click += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(41, 263);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 23;
            this.IdLabel.Text = "Id:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(66, 260);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 28;
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(43, 315);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 25;
            this.YLabel.Text = "Y:";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(66, 286);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 20);
            this.XTextBox.TabIndex = 32;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(43, 286);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 24;
            this.XLabel.Text = "X:";
            // 
            // RectanglesTableLayoutPanel
            // 
            this.RectanglesTableLayoutPanel.ColumnCount = 2;
            this.RectanglesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RectanglesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RectanglesTableLayoutPanel.Controls.Add(this.RectanglesPanel, 1, 0);
            this.RectanglesTableLayoutPanel.Controls.Add(this.RectanglesGroupBox, 0, 0);
            this.RectanglesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RectanglesTableLayoutPanel.Name = "RectanglesTableLayoutPanel";
            this.RectanglesTableLayoutPanel.RowCount = 1;
            this.RectanglesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RectanglesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RectanglesTableLayoutPanel.Size = new System.Drawing.Size(796, 473);
            this.RectanglesTableLayoutPanel.TabIndex = 34;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Controls.Add(this.HeightLabel);
            this.RectanglesGroupBox.Controls.Add(this.HeightTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesLabel);
            this.RectanglesGroupBox.Controls.Add(this.YLabel);
            this.RectanglesGroupBox.Controls.Add(this.IdLabel);
            this.RectanglesGroupBox.Controls.Add(this.XLabel);
            this.RectanglesGroupBox.Controls.Add(this.DeleteRectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.SelectedRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.AddRectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.YTextBox);
            this.RectanglesGroupBox.Controls.Add(this.IdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.XTextBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(392, 467);
            this.RectanglesGroupBox.TabIndex = 34;
            this.RectanglesGroupBox.TabStop = false;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesTableLayoutPanel);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(796, 473);
            this.Load += new System.EventHandler(this.RectanglesCollisionControl_Load);
            this.RectanglesTableLayoutPanel.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RectanglesPanel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Button DeleteRectangleButton;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TableLayoutPanel RectanglesTableLayoutPanel;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.ComponentModel.BackgroundWorker RectanglesBackgroundWorker;
    }
}
