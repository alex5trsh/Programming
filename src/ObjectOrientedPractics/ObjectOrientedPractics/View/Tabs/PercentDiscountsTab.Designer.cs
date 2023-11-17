
namespace ObjectOrientedPractics.View.Tabs
{
    partial class PercentDiscountsTab
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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.DiscoutAmountNumberLabel = new System.Windows.Forms.Label();
            this.DiscoutAmoutLabel = new System.Windows.Forms.Label();
            this.ProductAmountNumberLabel = new System.Windows.Forms.Label();
            this.ProductAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(101, 87);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 29;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(20, 87);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 28;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(182, 87);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 27;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(17, 28);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(25, 13);
            this.InfoLabel.TabIndex = 26;
            this.InfoLabel.Text = "Info";
            // 
            // DiscoutAmountNumberLabel
            // 
            this.DiscoutAmountNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscoutAmountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscoutAmountNumberLabel.Location = new System.Drawing.Point(323, 87);
            this.DiscoutAmountNumberLabel.Name = "DiscoutAmountNumberLabel";
            this.DiscoutAmountNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.DiscoutAmountNumberLabel.TabIndex = 25;
            this.DiscoutAmountNumberLabel.Text = "0,0";
            this.DiscoutAmountNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DiscoutAmoutLabel
            // 
            this.DiscoutAmoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscoutAmoutLabel.AutoSize = true;
            this.DiscoutAmoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscoutAmoutLabel.Location = new System.Drawing.Point(308, 70);
            this.DiscoutAmoutLabel.Name = "DiscoutAmoutLabel";
            this.DiscoutAmoutLabel.Size = new System.Drawing.Size(126, 17);
            this.DiscoutAmoutLabel.TabIndex = 24;
            this.DiscoutAmoutLabel.Text = "Discout Amount:";
            // 
            // ProductAmountNumberLabel
            // 
            this.ProductAmountNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductAmountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductAmountNumberLabel.Location = new System.Drawing.Point(323, 28);
            this.ProductAmountNumberLabel.Name = "ProductAmountNumberLabel";
            this.ProductAmountNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.ProductAmountNumberLabel.TabIndex = 23;
            this.ProductAmountNumberLabel.Text = "0,0";
            this.ProductAmountNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ProductAmountLabel
            // 
            this.ProductAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductAmountLabel.AutoSize = true;
            this.ProductAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductAmountLabel.Location = new System.Drawing.Point(306, 11);
            this.ProductAmountLabel.Name = "ProductAmountLabel";
            this.ProductAmountLabel.Size = new System.Drawing.Size(128, 17);
            this.ProductAmountLabel.TabIndex = 22;
            this.ProductAmountLabel.Text = "Product Amount:";
            // 
            // PercentDiscountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.DiscoutAmountNumberLabel);
            this.Controls.Add(this.DiscoutAmoutLabel);
            this.Controls.Add(this.ProductAmountNumberLabel);
            this.Controls.Add(this.ProductAmountLabel);
            this.Name = "PercentDiscountsTab";
            this.Size = new System.Drawing.Size(450, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label DiscoutAmountNumberLabel;
        private System.Windows.Forms.Label DiscoutAmoutLabel;
        private System.Windows.Forms.Label ProductAmountNumberLabel;
        private System.Windows.Forms.Label ProductAmountLabel;
    }
}
