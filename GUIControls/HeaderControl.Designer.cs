namespace GUIControls
{
    sealed partial class HeaderControl
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
            this.pbLeftGraphic = new System.Windows.Forms.PictureBox();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.lblSubText = new System.Windows.Forms.Label();
            this.lblInstructionsText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLeftGraphic
            // 
            this.pbLeftGraphic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLeftGraphic.Image = global::GUIControls.Properties.Resources.liberator_render_cycles_22;
            this.pbLeftGraphic.Location = new System.Drawing.Point(0, 0);
            this.pbLeftGraphic.Name = "pbLeftGraphic";
            this.pbLeftGraphic.Size = new System.Drawing.Size(143, 148);
            this.pbLeftGraphic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeftGraphic.TabIndex = 0;
            this.pbLeftGraphic.TabStop = false;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoEllipsis = true;
            this.lblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderText.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.LightGray;
            this.lblHeaderText.Location = new System.Drawing.Point(143, 0);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(718, 28);
            this.lblHeaderText.TabIndex = 1;
            this.lblHeaderText.Text = "Liberator OS Shell";
            // 
            // lblSubText
            // 
            this.lblSubText.AutoEllipsis = true;
            this.lblSubText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubText.ForeColor = System.Drawing.Color.Thistle;
            this.lblSubText.Location = new System.Drawing.Point(143, 28);
            this.lblSubText.Name = "lblSubText";
            this.lblSubText.Size = new System.Drawing.Size(718, 23);
            this.lblSubText.TabIndex = 2;
            this.lblSubText.Text = "The most private, anonymous, and safe computing system in the world";
            // 
            // lblInstructionsText
            // 
            this.lblInstructionsText.AutoEllipsis = true;
            this.lblInstructionsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInstructionsText.Location = new System.Drawing.Point(143, 51);
            this.lblInstructionsText.Name = "lblInstructionsText";
            this.lblInstructionsText.Size = new System.Drawing.Size(718, 97);
            this.lblInstructionsText.TabIndex = 3;
            this.lblInstructionsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblInstructionsText);
            this.Controls.Add(this.lblSubText);
            this.Controls.Add(this.lblHeaderText);
            this.Controls.Add(this.pbLeftGraphic);
            this.Name = "HeaderControl";
            this.Size = new System.Drawing.Size(861, 148);
            this.ParentChanged += new System.EventHandler(this.HeaderControl_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftGraphic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLeftGraphic;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.Label lblSubText;
        private System.Windows.Forms.Label lblInstructionsText;
    }
}
