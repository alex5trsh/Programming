namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonsComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WriteTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.TypeValueTextBox = new System.Windows.Forms.TextBox();
            this.TypeValueLabel = new System.Windows.Forms.Label();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.Lengthlabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.FindMaxRatingButton = new System.Windows.Forms.Button();
            this.YearOfReleaseLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.YearOfReleaseTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.Rectangles5ListBox = new System.Windows.Forms.ListBox();
            this.Rectangles5Label = new System.Windows.Forms.Label();
            this.Height5TextBox = new System.Windows.Forms.TextBox();
            this.Height5Label = new System.Windows.Forms.Label();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.Width5TextBox = new System.Windows.Forms.TextBox();
            this.DeleteRectangleButton = new System.Windows.Forms.Button();
            this.Width5Label = new System.Windows.Forms.Label();
            this.Y5TextBox = new System.Windows.Forms.TextBox();
            this.Id5Label = new System.Windows.Forms.Label();
            this.Id5TextBox = new System.Windows.Forms.TextBox();
            this.Y5Label = new System.Windows.Forms.Label();
            this.X5TextBox = new System.Windows.Forms.TextBox();
            this.X5Label = new System.Windows.Forms.Label();
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesTableLayoutPanel.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumsTabControl.Controls.Add(this.ClassesTabPage);
            this.EnumsTabControl.Controls.Add(this.RectanglesTabPage);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(797, 500);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(789, 474);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonsComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(319, 302);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(396, 131);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // SeasonsComboBox
            // 
            this.SeasonsComboBox.FormattingEnabled = true;
            this.SeasonsComboBox.Location = new System.Drawing.Point(18, 41);
            this.SeasonsComboBox.Name = "SeasonsComboBox";
            this.SeasonsComboBox.Size = new System.Drawing.Size(213, 21);
            this.SeasonsComboBox.TabIndex = 2;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(237, 39);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(82, 23);
            this.GoButton.TabIndex = 1;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(15, 25);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.ChooseSeasonLabel.TabIndex = 0;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayParsingGroupBox.Controls.Add(this.WriteTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.TypeValueTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.TypeValueLabel);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(3, 302);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(310, 131);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WriteTextBox
            // 
            this.WriteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WriteTextBox.Location = new System.Drawing.Point(3, 77);
            this.WriteTextBox.Name = "WriteTextBox";
            this.WriteTextBox.Size = new System.Drawing.Size(194, 13);
            this.WriteTextBox.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(201, 38);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(77, 23);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // TypeValueTextBox
            // 
            this.TypeValueTextBox.Location = new System.Drawing.Point(3, 41);
            this.TypeValueTextBox.Name = "TypeValueTextBox";
            this.TypeValueTextBox.Size = new System.Drawing.Size(192, 20);
            this.TypeValueTextBox.TabIndex = 1;
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.AutoSize = true;
            this.TypeValueLabel.Location = new System.Drawing.Point(2, 25);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(115, 13);
            this.TypeValueLabel.TabIndex = 0;
            this.TypeValueLabel.Text = "Type value for parsing:";
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumGroupBox.Controls.Add(this.ValueLabel);
            this.EnumGroupBox.Controls.Add(this.EnumLabel);
            this.EnumGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumGroupBox.Controls.Add(this.ValueListBox);
            this.EnumGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(712, 293);
            this.EnumGroupBox.TabIndex = 0;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(331, 39);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(156, 39);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Location = new System.Drawing.Point(6, 39);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumLabel.TabIndex = 3;
            this.EnumLabel.Text = "Choose enumaration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(334, 55);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(134, 20);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(159, 55);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.ScrollAlwaysVisible = true;
            this.ValueListBox.Size = new System.Drawing.Size(119, 160);
            this.ValueListBox.TabIndex = 1;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(9, 55);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(120, 160);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesTableLayoutPanel);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(789, 474);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTableLayoutPanel
            // 
            this.ClassesTableLayoutPanel.ColumnCount = 2;
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.Controls.Add(this.RectanglesGroupBox, 0, 0);
            this.ClassesTableLayoutPanel.Controls.Add(this.MoviesGroupBox, 1, 0);
            this.ClassesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ClassesTableLayoutPanel.Name = "ClassesTableLayoutPanel";
            this.ClassesTableLayoutPanel.RowCount = 1;
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 468F));
            this.ClassesTableLayoutPanel.Size = new System.Drawing.Size(783, 468);
            this.ClassesTableLayoutPanel.TabIndex = 20;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.IdLabel);
            this.RectanglesGroupBox.Controls.Add(this.YTextBox);
            this.RectanglesGroupBox.Controls.Add(this.XTextBox);
            this.RectanglesGroupBox.Controls.Add(this.YLabel);
            this.RectanglesGroupBox.Controls.Add(this.XLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Controls.Add(this.Lengthlabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(385, 462);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(6, 298);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 13;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 282);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 12;
            this.IdLabel.Text = "Id:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(137, 249);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.ReadOnly = true;
            this.YTextBox.Size = new System.Drawing.Size(100, 20);
            this.YTextBox.TabIndex = 11;
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(6, 249);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.ReadOnly = true;
            this.XTextBox.Size = new System.Drawing.Size(100, 20);
            this.XTextBox.TabIndex = 10;
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(134, 233);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 9;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(6, 233);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 8;
            this.XLabel.Text = "X:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(155, 199);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // Lengthlabel
            // 
            this.Lengthlabel.AutoSize = true;
            this.Lengthlabel.Location = new System.Drawing.Point(167, 19);
            this.Lengthlabel.Name = "Lengthlabel";
            this.Lengthlabel.Size = new System.Drawing.Size(43, 13);
            this.Lengthlabel.TabIndex = 1;
            this.Lengthlabel.Text = "Length:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(170, 35);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 4;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(167, 58);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(170, 74);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(167, 102);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 3;
            this.ColorLabel.Text = "Color:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(170, 118);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(170, 195);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 23);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Controls.Add(this.DurationTextBox);
            this.MoviesGroupBox.Controls.Add(this.DurationLabel);
            this.MoviesGroupBox.Controls.Add(this.FindMaxRatingButton);
            this.MoviesGroupBox.Controls.Add(this.YearOfReleaseLabel);
            this.MoviesGroupBox.Controls.Add(this.RatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.YearOfReleaseTextBox);
            this.MoviesGroupBox.Controls.Add(this.RatingLabel);
            this.MoviesGroupBox.Controls.Add(this.GenreLabel);
            this.MoviesGroupBox.Controls.Add(this.GenreTextBox);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesGroupBox.Location = new System.Drawing.Point(394, 3);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(386, 462);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(6, 19);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(150, 199);
            this.MoviesListBox.TabIndex = 8;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(162, 35);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(99, 20);
            this.DurationTextBox.TabIndex = 9;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(162, 19);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(50, 13);
            this.DurationLabel.TabIndex = 16;
            this.DurationLabel.Text = "Duration:";
            // 
            // FindMaxRatingButton
            // 
            this.FindMaxRatingButton.Location = new System.Drawing.Point(165, 195);
            this.FindMaxRatingButton.Name = "FindMaxRatingButton";
            this.FindMaxRatingButton.Size = new System.Drawing.Size(100, 23);
            this.FindMaxRatingButton.TabIndex = 17;
            this.FindMaxRatingButton.Text = "Find";
            this.FindMaxRatingButton.UseVisualStyleBackColor = true;
            this.FindMaxRatingButton.Click += new System.EventHandler(this.FindMaxRatingButton_Click);
            // 
            // YearOfReleaseLabel
            // 
            this.YearOfReleaseLabel.AutoSize = true;
            this.YearOfReleaseLabel.Location = new System.Drawing.Point(162, 58);
            this.YearOfReleaseLabel.Name = "YearOfReleaseLabel";
            this.YearOfReleaseLabel.Size = new System.Drawing.Size(88, 13);
            this.YearOfReleaseLabel.TabIndex = 15;
            this.YearOfReleaseLabel.Text = "Year Of Release:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(162, 157);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox.TabIndex = 12;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // YearOfReleaseTextBox
            // 
            this.YearOfReleaseTextBox.Location = new System.Drawing.Point(162, 74);
            this.YearOfReleaseTextBox.Name = "YearOfReleaseTextBox";
            this.YearOfReleaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.YearOfReleaseTextBox.TabIndex = 10;
            this.YearOfReleaseTextBox.TextChanged += new System.EventHandler(this.YearOfReleaseTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(162, 141);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 13;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(162, 102);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 14;
            this.GenreLabel.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(161, 118);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 11;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.RectanglesPanel);
            this.RectanglesTabPage.Controls.Add(this.Rectangles5ListBox);
            this.RectanglesTabPage.Controls.Add(this.Rectangles5Label);
            this.RectanglesTabPage.Controls.Add(this.Height5TextBox);
            this.RectanglesTabPage.Controls.Add(this.Height5Label);
            this.RectanglesTabPage.Controls.Add(this.AddRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.SelectedRectangleLabel);
            this.RectanglesTabPage.Controls.Add(this.Width5TextBox);
            this.RectanglesTabPage.Controls.Add(this.DeleteRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.Width5Label);
            this.RectanglesTabPage.Controls.Add(this.Y5TextBox);
            this.RectanglesTabPage.Controls.Add(this.Id5Label);
            this.RectanglesTabPage.Controls.Add(this.Id5TextBox);
            this.RectanglesTabPage.Controls.Add(this.Y5Label);
            this.RectanglesTabPage.Controls.Add(this.X5TextBox);
            this.RectanglesTabPage.Controls.Add(this.X5Label);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(789, 474);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Location = new System.Drawing.Point(339, 6);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(450, 431);
            this.RectanglesPanel.TabIndex = 17;
            // 
            // Rectangles5ListBox
            // 
            this.Rectangles5ListBox.FormattingEnabled = true;
            this.Rectangles5ListBox.Location = new System.Drawing.Point(11, 32);
            this.Rectangles5ListBox.Name = "Rectangles5ListBox";
            this.Rectangles5ListBox.Size = new System.Drawing.Size(304, 134);
            this.Rectangles5ListBox.TabIndex = 3;
            this.Rectangles5ListBox.SelectedIndexChanged += new System.EventHandler(this.Rectangles5ListBox_SelectedIndexChanged);
            // 
            // Rectangles5Label
            // 
            this.Rectangles5Label.AutoSize = true;
            this.Rectangles5Label.Location = new System.Drawing.Point(8, 16);
            this.Rectangles5Label.Name = "Rectangles5Label";
            this.Rectangles5Label.Size = new System.Drawing.Size(64, 13);
            this.Rectangles5Label.TabIndex = 4;
            this.Rectangles5Label.Text = "Rectangles:";
            // 
            // Height5TextBox
            // 
            this.Height5TextBox.Location = new System.Drawing.Point(65, 368);
            this.Height5TextBox.Name = "Height5TextBox";
            this.Height5TextBox.Size = new System.Drawing.Size(100, 20);
            this.Height5TextBox.TabIndex = 12;
            this.Height5TextBox.TextChanged += new System.EventHandler(this.Height5TextBox_TextChanged);
            // 
            // Height5Label
            // 
            this.Height5Label.AutoSize = true;
            this.Height5Label.Location = new System.Drawing.Point(18, 371);
            this.Height5Label.Name = "Height5Label";
            this.Height5Label.Size = new System.Drawing.Size(41, 13);
            this.Height5Label.TabIndex = 10;
            this.Height5Label.Text = "Height:";
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddRectangleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Location = new System.Drawing.Point(21, 172);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(51, 50);
            this.AddRectangleButton.TabIndex = 1;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(8, 237);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(104, 13);
            this.SelectedRectangleLabel.TabIndex = 5;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // Width5TextBox
            // 
            this.Width5TextBox.Location = new System.Drawing.Point(65, 342);
            this.Width5TextBox.Name = "Width5TextBox";
            this.Width5TextBox.Size = new System.Drawing.Size(100, 20);
            this.Width5TextBox.TabIndex = 13;
            this.Width5TextBox.TextChanged += new System.EventHandler(this.Width5TextBox_TextChanged);
            // 
            // DeleteRectangleButton
            // 
            this.DeleteRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRectangleButton.Location = new System.Drawing.Point(136, 172);
            this.DeleteRectangleButton.Name = "DeleteRectangleButton";
            this.DeleteRectangleButton.Size = new System.Drawing.Size(84, 62);
            this.DeleteRectangleButton.TabIndex = 2;
            this.DeleteRectangleButton.UseVisualStyleBackColor = true;
            this.DeleteRectangleButton.Click += new System.EventHandler(this.DeleteRectangleButton_Click);
            // 
            // Width5Label
            // 
            this.Width5Label.AutoSize = true;
            this.Width5Label.Location = new System.Drawing.Point(21, 345);
            this.Width5Label.Name = "Width5Label";
            this.Width5Label.Size = new System.Drawing.Size(38, 13);
            this.Width5Label.TabIndex = 9;
            this.Width5Label.Text = "Width:";
            // 
            // Y5TextBox
            // 
            this.Y5TextBox.Location = new System.Drawing.Point(65, 316);
            this.Y5TextBox.Name = "Y5TextBox";
            this.Y5TextBox.Size = new System.Drawing.Size(100, 20);
            this.Y5TextBox.TabIndex = 14;
            this.Y5TextBox.TextChanged += new System.EventHandler(this.Y5TextBox_TextChanged);
            // 
            // Id5Label
            // 
            this.Id5Label.AutoSize = true;
            this.Id5Label.Location = new System.Drawing.Point(40, 264);
            this.Id5Label.Name = "Id5Label";
            this.Id5Label.Size = new System.Drawing.Size(19, 13);
            this.Id5Label.TabIndex = 6;
            this.Id5Label.Text = "Id:";
            // 
            // Id5TextBox
            // 
            this.Id5TextBox.Location = new System.Drawing.Point(65, 264);
            this.Id5TextBox.Name = "Id5TextBox";
            this.Id5TextBox.ReadOnly = true;
            this.Id5TextBox.Size = new System.Drawing.Size(100, 20);
            this.Id5TextBox.TabIndex = 11;
            // 
            // Y5Label
            // 
            this.Y5Label.AutoSize = true;
            this.Y5Label.Location = new System.Drawing.Point(42, 319);
            this.Y5Label.Name = "Y5Label";
            this.Y5Label.Size = new System.Drawing.Size(17, 13);
            this.Y5Label.TabIndex = 8;
            this.Y5Label.Text = "Y:";
            // 
            // X5TextBox
            // 
            this.X5TextBox.Location = new System.Drawing.Point(65, 290);
            this.X5TextBox.Name = "X5TextBox";
            this.X5TextBox.Size = new System.Drawing.Size(100, 20);
            this.X5TextBox.TabIndex = 15;
            this.X5TextBox.TextChanged += new System.EventHandler(this.X5TextBox_TextChanged);
            // 
            // X5Label
            // 
            this.X5Label.AutoSize = true;
            this.X5Label.Location = new System.Drawing.Point(42, 293);
            this.X5Label.Name = "X5Label";
            this.X5Label.Size = new System.Drawing.Size(17, 13);
            this.X5Label.TabIndex = 7;
            this.X5Label.Text = "X:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.EnumsTabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesTableLayoutPanel.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EnumsTabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label EnumLabel;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.TextBox WriteTextBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox TypeValueTextBox;
        private System.Windows.Forms.Label TypeValueLabel;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.ComboBox SeasonsComboBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.Button FindMaxRatingButton;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label YearOfReleaseLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox YearOfReleaseTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label Lengthlabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.TableLayoutPanel ClassesTableLayoutPanel;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private System.Windows.Forms.TextBox X5TextBox;
        private System.Windows.Forms.TextBox Y5TextBox;
        private System.Windows.Forms.TextBox Width5TextBox;
        private System.Windows.Forms.TextBox Height5TextBox;
        private System.Windows.Forms.TextBox Id5TextBox;
        private System.Windows.Forms.Label Height5Label;
        private System.Windows.Forms.Label Width5Label;
        private System.Windows.Forms.Label Y5Label;
        private System.Windows.Forms.Label X5Label;
        private System.Windows.Forms.Label Id5Label;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Label Rectangles5Label;
        private System.Windows.Forms.ListBox Rectangles5ListBox;
        private System.Windows.Forms.Button DeleteRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Panel RectanglesPanel;
    }
}

