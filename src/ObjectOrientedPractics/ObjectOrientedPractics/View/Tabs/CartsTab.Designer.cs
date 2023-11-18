
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CartLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountNumberLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.DiscountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountAmountNumberLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.TotalNumberLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 16);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(263, 433);
            this.ItemsListBox.TabIndex = 0;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(3, 0);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(35, 13);
            this.ItemsLabel.TabIndex = 1;
            this.ItemsLabel.Text = "Items:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(288, 16);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(54, 13);
            this.CustomerLabel.TabIndex = 2;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(288, 75);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(29, 13);
            this.CartLabel.TabIndex = 3;
            this.CartLabel.Text = "Cart:";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCartButton.Location = new System.Drawing.Point(3, 455);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(91, 34);
            this.AddToCartButton.TabIndex = 4;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(742, 290);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(85, 30);
            this.ClearCartButton.TabIndex = 5;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Location = new System.Drawing.Point(291, 290);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(85, 30);
            this.CreateOrderButton.TabIndex = 6;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(651, 290);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(85, 30);
            this.RemoveItemButton.TabIndex = 7;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(348, 13);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(479, 21);
            this.CustomerComboBox.TabIndex = 8;
            this.CustomerComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerComboBox_SelectedIndexChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(763, 241);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(67, 17);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountNumberLabel
            // 
            this.AmountNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountNumberLabel.Location = new System.Drawing.Point(716, 258);
            this.AmountNumberLabel.Name = "AmountNumberLabel";
            this.AmountNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.AmountNumberLabel.TabIndex = 11;
            this.AmountNumberLabel.Text = "0,0";
            this.AmountNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(291, 91);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(536, 147);
            this.CartListBox.TabIndex = 12;
            // 
            // DiscountsCheckedListBox
            // 
            this.DiscountsCheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.DiscountsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountsCheckedListBox.CheckOnClick = true;
            this.DiscountsCheckedListBox.FormattingEnabled = true;
            this.DiscountsCheckedListBox.Location = new System.Drawing.Point(291, 353);
            this.DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            this.DiscountsCheckedListBox.Size = new System.Drawing.Size(178, 90);
            this.DiscountsCheckedListBox.TabIndex = 13;
            this.DiscountsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountsCheckedListBox_SelectedIndexChanged);
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Location = new System.Drawing.Point(288, 337);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(57, 13);
            this.DiscountsLabel.TabIndex = 14;
            this.DiscountsLabel.Text = "Discounts:";
            // 
            // DiscountAmountNumberLabel
            // 
            this.DiscountAmountNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountAmountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountNumberLabel.Location = new System.Drawing.Point(713, 368);
            this.DiscountAmountNumberLabel.Name = "DiscountAmountNumberLabel";
            this.DiscountAmountNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.DiscountAmountNumberLabel.TabIndex = 16;
            this.DiscountAmountNumberLabel.Text = "0,0";
            this.DiscountAmountNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountLabel.Location = new System.Drawing.Point(708, 353);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(119, 15);
            this.DiscountAmountLabel.TabIndex = 15;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // TotalNumberLabel
            // 
            this.TotalNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalNumberLabel.Location = new System.Drawing.Point(713, 463);
            this.TotalNumberLabel.Name = "TotalNumberLabel";
            this.TotalNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.TotalNumberLabel.TabIndex = 18;
            this.TotalNumberLabel.Text = "0,0";
            this.TotalNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLabel.Location = new System.Drawing.Point(763, 446);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(64, 17);
            this.TotalLabel.TabIndex = 17;
            this.TotalLabel.Text = "TOTAL:";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalNumberLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DiscountAmountNumberLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.DiscountsLabel);
            this.Controls.Add(this.DiscountsCheckedListBox);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.AmountNumberLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.ItemsListBox);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(830, 501);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AmountNumberLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.CheckedListBox DiscountsCheckedListBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.Label DiscountAmountNumberLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label TotalNumberLabel;
        private System.Windows.Forms.Label TotalLabel;
    }
}
