namespace BestWeatherSource
{
    partial class FrmWeatherSource
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            pbWeatherStatus = new PictureBox();
            lblValue = new Label();
            pnlAdd = new Panel();
            lblAdd = new Label();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWeatherStatus).BeginInit();
            pnlAdd.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pbWeatherStatus);
            pnlMain.Controls.Add(lblValue);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 450);
            pnlMain.TabIndex = 2;
            // 
            // pbWeatherStatus
            // 
            pbWeatherStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbWeatherStatus.BackColor = SystemColors.AppWorkspace;
            pbWeatherStatus.BorderStyle = BorderStyle.Fixed3D;
            pbWeatherStatus.Location = new Point(663, 316);
            pbWeatherStatus.Name = "pbWeatherStatus";
            pbWeatherStatus.Size = new Size(125, 90);
            pbWeatherStatus.TabIndex = 2;
            pbWeatherStatus.TabStop = false;
            // 
            // lblValue
            // 
            lblValue.Dock = DockStyle.Fill;
            lblValue.Font = new Font("Segoe UI", 48F);
            lblValue.Location = new Point(0, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(800, 450);
            lblValue.TabIndex = 1;
            lblValue.Text = "lblValue";
            lblValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAdd
            // 
            pnlAdd.Controls.Add(lblAdd);
            pnlAdd.Dock = DockStyle.Bottom;
            pnlAdd.Location = new Point(0, 412);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(800, 38);
            pnlAdd.TabIndex = 3;
            // 
            // lblAdd
            // 
            lblAdd.Dock = DockStyle.Fill;
            lblAdd.Location = new Point(0, 0);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(800, 38);
            lblAdd.TabIndex = 0;
            lblAdd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmWeatherSource
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlAdd);
            Controls.Add(pnlMain);
            Name = "FrmWeatherSource";
            Text = "Погода в Москве";
            Load += FrmWeatherSource_Load;
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbWeatherStatus).EndInit();
            pnlAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private PictureBox pbWeatherStatus;
        private Label lblValue;
        private Panel pnlAdd;
        private Label lblAdd;
    }
}
