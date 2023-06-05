
namespace AppPlaces.View.Panels
{
    partial class PlacesPanel
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
            this.PlacesListBox = new System.Windows.Forms.ListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.SelectecPlaceGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.AddressErrorLabel = new System.Windows.Forms.Label();
            this.CategoryErrorLabel = new System.Windows.Forms.Label();
            this.RatingErrorLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SelectecPlaceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlacesListBox
            // 
            this.PlacesListBox.FormattingEnabled = true;
            this.PlacesListBox.Location = new System.Drawing.Point(3, 3);
            this.PlacesListBox.Name = "PlacesListBox";
            this.PlacesListBox.Size = new System.Drawing.Size(246, 394);
            this.PlacesListBox.TabIndex = 0;
            this.PlacesListBox.SelectedIndexChanged += new System.EventHandler(this.PlacesListBox_SelectedIndexChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(20, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(10, 61);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(6, 103);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category:";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(17, 144);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 7;
            this.RatingLabel.Text = "Rating:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.Location = new System.Drawing.Point(64, 58);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(424, 20);
            this.AddressTextBox.TabIndex = 8;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // SelectecPlaceGroupBox
            // 
            this.SelectecPlaceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectecPlaceGroupBox.Controls.Add(this.RatingErrorLabel);
            this.SelectecPlaceGroupBox.Controls.Add(this.CategoryErrorLabel);
            this.SelectecPlaceGroupBox.Controls.Add(this.AddressErrorLabel);
            this.SelectecPlaceGroupBox.Controls.Add(this.NameErrorLabel);
            this.SelectecPlaceGroupBox.Controls.Add(this.CategoryComboBox);
            this.SelectecPlaceGroupBox.Controls.Add(this.RatingTextBox);
            this.SelectecPlaceGroupBox.Controls.Add(this.NameTextBox);
            this.SelectecPlaceGroupBox.Controls.Add(this.NameLabel);
            this.SelectecPlaceGroupBox.Controls.Add(this.AddressLabel);
            this.SelectecPlaceGroupBox.Controls.Add(this.RatingLabel);
            this.SelectecPlaceGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectecPlaceGroupBox.Controls.Add(this.AddressTextBox);
            this.SelectecPlaceGroupBox.Location = new System.Drawing.Point(255, 3);
            this.SelectecPlaceGroupBox.Name = "SelectecPlaceGroupBox";
            this.SelectecPlaceGroupBox.Size = new System.Drawing.Size(494, 188);
            this.SelectecPlaceGroupBox.TabIndex = 12;
            this.SelectecPlaceGroupBox.TabStop = false;
            this.SelectecPlaceGroupBox.Text = "Selected Place";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(64, 100);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(190, 21);
            this.CategoryComboBox.TabIndex = 15;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(64, 141);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(190, 20);
            this.RatingTextBox.TabIndex = 14;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(64, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(424, 20);
            this.NameTextBox.TabIndex = 12;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.Location = new System.Drawing.Point(61, 42);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(247, 13);
            this.NameErrorLabel.TabIndex = 15;
            this.NameErrorLabel.Text = "Поле должно содержать от 1 до 200 символов.";
            // 
            // AddressErrorLabel
            // 
            this.AddressErrorLabel.AutoSize = true;
            this.AddressErrorLabel.Location = new System.Drawing.Point(61, 81);
            this.AddressErrorLabel.Name = "AddressErrorLabel";
            this.AddressErrorLabel.Size = new System.Drawing.Size(247, 13);
            this.AddressErrorLabel.TabIndex = 16;
            this.AddressErrorLabel.Text = "Поле должно содержать от 1 до 100 символов.";
            // 
            // CategoryErrorLabel
            // 
            this.CategoryErrorLabel.AutoSize = true;
            this.CategoryErrorLabel.Location = new System.Drawing.Point(61, 125);
            this.CategoryErrorLabel.Name = "CategoryErrorLabel";
            this.CategoryErrorLabel.Size = new System.Drawing.Size(47, 13);
            this.CategoryErrorLabel.TabIndex = 17;
            this.CategoryErrorLabel.Text = "Ошибка";
            // 
            // RatingErrorLabel
            // 
            this.RatingErrorLabel.AutoSize = true;
            this.RatingErrorLabel.Location = new System.Drawing.Point(61, 164);
            this.RatingErrorLabel.Name = "RatingErrorLabel";
            this.RatingErrorLabel.Size = new System.Drawing.Size(214, 13);
            this.RatingErrorLabel.TabIndex = 18;
            this.RatingErrorLabel.Text = "Поле должно содержать числа от 0 до 5.";
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImage = global::AppPlaces.Properties.Resources.place_cancel_button_100_png;
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(223, 403);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(49, 46);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackgroundImage = global::AppPlaces.Properties.Resources.place_apply_button_100_png;
            this.ApplyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApplyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ApplyButton.FlatAppearance.BorderSize = 0;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Location = new System.Drawing.Point(168, 403);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(49, 46);
            this.ApplyButton.TabIndex = 13;
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::AppPlaces.Properties.Resources.place_delete_button_100_png;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(113, 403);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(49, 46);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackgroundImage = global::AppPlaces.Properties.Resources.place_edit_button_100_png;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Location = new System.Drawing.Point(58, 403);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(49, 46);
            this.EditButton.TabIndex = 2;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = global::AppPlaces.Properties.Resources.place_add_button_100_png;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Location = new System.Drawing.Point(3, 403);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(49, 46);
            this.AddButton.TabIndex = 1;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PlacesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.SelectecPlaceGroupBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PlacesListBox);
            this.Name = "PlacesPanel";
            this.Size = new System.Drawing.Size(752, 456);
            this.SelectecPlaceGroupBox.ResumeLayout(false);
            this.SelectecPlaceGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PlacesListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.GroupBox SelectecPlaceGroupBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label RatingErrorLabel;
        private System.Windows.Forms.Label CategoryErrorLabel;
        private System.Windows.Forms.Label AddressErrorLabel;
        private System.Windows.Forms.Label NameErrorLabel;
    }
}
