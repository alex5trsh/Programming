
namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.components = new System.ComponentModel.Container();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountNumberLabel = new System.Windows.Forms.Label();
            this.AddressControl = new ObjectOrientedPractics.View.Tabs.Controls.AddressControl();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Panel = new System.Windows.Forms.Panel();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 16);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.Size = new System.Drawing.Size(380, 457);
            this.OrdersDataGridView.TabIndex = 0;
            this.OrdersDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersDataGridView_RowHeaderMouseClick);
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Location = new System.Drawing.Point(3, 0);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(38, 13);
            this.OrdersLabel.TabIndex = 1;
            this.OrdersLabel.Text = "Orders";
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Location = new System.Drawing.Point(389, 0);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(78, 13);
            this.SelectedOrderLabel.TabIndex = 2;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(389, 29);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(389, 55);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 4;
            this.CreatedLabel.Text = "Created:";
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Location = new System.Drawing.Point(389, 263);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(64, 13);
            this.OrderItemsLabel.TabIndex = 5;
            this.OrderItemsLabel.Text = "Order Items:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(389, 81);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status:";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(442, 26);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(121, 20);
            this.IDTextBox.TabIndex = 7;
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(442, 52);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(121, 20);
            this.CreatedTextBox.TabIndex = 8;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(442, 78);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBox.TabIndex = 9;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.Enabled = false;
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.Location = new System.Drawing.Point(392, 279);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(435, 121);
            this.OrderItemsListBox.TabIndex = 10;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(763, 403);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(67, 17);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountNumberLabel
            // 
            this.AmountNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountNumberLabel.Location = new System.Drawing.Point(716, 420);
            this.AmountNumberLabel.Name = "AmountNumberLabel";
            this.AmountNumberLabel.Size = new System.Drawing.Size(111, 29);
            this.AmountNumberLabel.TabIndex = 13;
            this.AmountNumberLabel.Text = "0,0";
            this.AmountNumberLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(392, 114);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(435, 136);
            this.AddressControl.TabIndex = 11;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ObjectOrientedPractics.Model.Orders.Order);
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.DeliveryTimeComboBox);
            this.Panel.Controls.Add(this.DeliveryTimeLabel);
            this.Panel.Controls.Add(this.PriorityOptionsLabel);
            this.Panel.Location = new System.Drawing.Point(582, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(248, 103);
            this.Panel.TabIndex = 14;
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(86, 21);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.DeliveryTimeComboBox.TabIndex = 11;
            this.DeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(3, 24);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(77, 13);
            this.DeliveryTimeLabel.TabIndex = 10;
            this.DeliveryTimeLabel.Text = "Delivery Time::";
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(3, 0);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(77, 13);
            this.PriorityOptionsLabel.TabIndex = 3;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.AmountNumberLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.CreatedTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Controls.Add(this.OrdersLabel);
            this.Controls.Add(this.OrdersDataGridView);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(830, 501);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private Controls.AddressControl AddressControl;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AmountNumberLabel;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
    }
}
