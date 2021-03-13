namespace DiscordPTT
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PTTButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // PTTButton
            // 
            this.PTTButton.BackgroundImage = global::DiscordPTT.Properties.Resources.mutedLight;
            this.PTTButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PTTButton.Location = new System.Drawing.Point(50, 51);
            this.PTTButton.Name = "PTTButton";
            this.PTTButton.Size = new System.Drawing.Size(96, 96);
            this.PTTButton.Style = MetroFramework.MetroColorStyle.Lime;
            this.PTTButton.TabIndex = 1;
            this.PTTButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PTTButton.UseSelectable = true;
            this.PTTButton.Click += new System.EventHandler(this.PTTButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.PTTButton);
            this.DisplayHeader = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Discord PTT";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton PTTButton;
    }
}

