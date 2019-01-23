namespace CirceAmplitudeVisualiser
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._panel = new System.Windows.Forms.Panel();
            this._cbDevice = new System.Windows.Forms.ComboBox();
            this._trbMulti = new System.Windows.Forms.TrackBar();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._trbMulti)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panel.Location = new System.Drawing.Point(13, 65);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(775, 373);
            this._panel.TabIndex = 0;
            this._panel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPanelPaint);
            this._panel.Resize += new System.EventHandler(this.OnPanelResize);
            // 
            // _cbDevice
            // 
            this._cbDevice.FormattingEnabled = true;
            this._cbDevice.Location = new System.Drawing.Point(13, 21);
            this._cbDevice.Name = "_cbDevice";
            this._cbDevice.Size = new System.Drawing.Size(121, 21);
            this._cbDevice.TabIndex = 1;
            // 
            // _trbMulti
            // 
            this._trbMulti.Location = new System.Drawing.Point(140, 12);
            this._trbMulti.Maximum = 5;
            this._trbMulti.Minimum = 1;
            this._trbMulti.Name = "_trbMulti";
            this._trbMulti.Size = new System.Drawing.Size(104, 45);
            this._trbMulti.TabIndex = 2;
            this._trbMulti.Value = 1;
            // 
            // _timer
            // 
            this._timer.Interval = 10;
            this._timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._trbMulti);
            this.Controls.Add(this._cbDevice);
            this.Controls.Add(this._panel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._trbMulti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.ComboBox _cbDevice;
        private System.Windows.Forms.TrackBar _trbMulti;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Label label1;
    }
}

