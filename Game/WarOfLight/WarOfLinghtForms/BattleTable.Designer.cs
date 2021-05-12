namespace WarOfLightModule
{
    partial class BattleTable
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
            this.Shot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Shot
            // 
            this.Shot.Location = new System.Drawing.Point(12, 235);
            this.Shot.Name = "Shot";
            this.Shot.Size = new System.Drawing.Size(163, 55);
            this.Shot.TabIndex = 0;
            this.Shot.Text = "Shot";
            this.Shot.UseVisualStyleBackColor = true;
            this.Shot.Click += new System.EventHandler(this.Shot_Click);
            // 
            // BattleTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Shot);
            this.Name = "BattleTable";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Shot;
    }
}