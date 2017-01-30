namespace GUIControls
{
    partial class InputValidControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbValidationdisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidationdisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pbValidationdisplay
            // 
            this.pbValidationdisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbValidationdisplay.Image = global::GUIControls.Properties.Resources.Alarm_Tick_icon;
            this.pbValidationdisplay.Location = new System.Drawing.Point(0, 0);
            this.pbValidationdisplay.Name = "pbValidationdisplay";
            this.pbValidationdisplay.Size = new System.Drawing.Size(20, 20);
            this.pbValidationdisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbValidationdisplay.TabIndex = 0;
            this.pbValidationdisplay.TabStop = false;
            // 
            // InputValidControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbValidationdisplay);
            this.Name = "InputValidControl";
            this.Size = new System.Drawing.Size(20, 20);
            ((System.ComponentModel.ISupportInitialize)(this.pbValidationdisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbValidationdisplay;
    }
}
