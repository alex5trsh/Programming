
namespace Programming.View.Panels
{
    partial class WeekdayParsingPanel
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
            this.WriteTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.TypeValueTextBox = new System.Windows.Forms.TextBox();
            this.TypeValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WriteTextBox
            // 
            this.WriteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WriteTextBox.Location = new System.Drawing.Point(6, 42);
            this.WriteTextBox.Name = "WriteTextBox";
            this.WriteTextBox.Size = new System.Drawing.Size(194, 13);
            this.WriteTextBox.TabIndex = 7;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(204, 15);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(82, 21);
            this.ParseButton.TabIndex = 6;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // TypeValueTextBox
            // 
            this.TypeValueTextBox.Location = new System.Drawing.Point(6, 16);
            this.TypeValueTextBox.Name = "TypeValueTextBox";
            this.TypeValueTextBox.Size = new System.Drawing.Size(192, 20);
            this.TypeValueTextBox.TabIndex = 5;
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.AutoSize = true;
            this.TypeValueLabel.Location = new System.Drawing.Point(3, 0);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(115, 13);
            this.TypeValueLabel.TabIndex = 4;
            this.TypeValueLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WriteTextBox);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.TypeValueTextBox);
            this.Controls.Add(this.TypeValueLabel);
            this.Name = "WeekdayParsingPanel";
            this.Size = new System.Drawing.Size(350, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WriteTextBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox TypeValueTextBox;
        private System.Windows.Forms.Label TypeValueLabel;
    }
}
