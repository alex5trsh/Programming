
namespace Programming.View.Panels
{
    partial class EnumerationsValuePanel
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
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(388, 9);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(196, 9);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Location = new System.Drawing.Point(3, 9);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumLabel.TabIndex = 3;
            this.EnumLabel.Text = "Choose enumeration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(391, 25);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(134, 20);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // ValueListBox
            // 
            this.ValueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(199, 25);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.ScrollAlwaysVisible = true;
            this.ValueListBox.Size = new System.Drawing.Size(163, 225);
            this.ValueListBox.TabIndex = 1;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(6, 25);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(163, 225);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumerationsValuePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueListBox);
            this.Controls.Add(this.IntValueTextBox);
            this.Controls.Add(this.EnumsListBox);
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.EnumLabel);
            this.Name = "EnumerationsValuePanel";
            this.Size = new System.Drawing.Size(683, 279);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label EnumLabel;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
    }
}
