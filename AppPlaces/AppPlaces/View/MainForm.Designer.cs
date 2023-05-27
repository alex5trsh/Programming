
namespace AppPlaces.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PlacesPanel = new AppPlaces.View.Panels.PlacesPanel();
            this.SuspendLayout();
            // 
            // PlacesPanel
            // 
            this.PlacesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlacesPanel.Location = new System.Drawing.Point(0, 0);
            this.PlacesPanel.Name = "PlacesPanel";
            this.PlacesPanel.Size = new System.Drawing.Size(825, 459);
            this.PlacesPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 459);
            this.Controls.Add(this.PlacesPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(841, 498);
            this.Name = "MainForm";
            this.Text = "AppPlaces";
            this.ResumeLayout(false);

        }

        #endregion

        private Panels.PlacesPanel PlacesPanel;
    }
}

