namespace ITM_NV_SDK
{
    partial class FRM_MAIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MAIN));
            LBL_header = new Label();
            BTN_selectRoom = new Button();
            SuspendLayout();
            // 
            // LBL_header
            // 
            LBL_header.AutoSize = true;
            LBL_header.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_header.Location = new Point(12, 9);
            LBL_header.Name = "LBL_header";
            LBL_header.Size = new Size(223, 50);
            LBL_header.TabIndex = 0;
            LBL_header.Text = "Select type:";
            // 
            // BTN_selectRoom
            // 
            BTN_selectRoom.BackColor = SystemColors.ControlDark;
            BTN_selectRoom.ForeColor = SystemColors.ControlLightLight;
            BTN_selectRoom.Location = new Point(12, 62);
            BTN_selectRoom.Name = "BTN_selectRoom";
            BTN_selectRoom.Size = new Size(221, 38);
            BTN_selectRoom.TabIndex = 1;
            BTN_selectRoom.Text = "Room";
            BTN_selectRoom.UseVisualStyleBackColor = false;
            BTN_selectRoom.Click += BTN_selectRoom_Click;
            // 
            // FRM_MAIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(245, 272);
            Controls.Add(BTN_selectRoom);
            Controls.Add(LBL_header);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FRM_MAIN";
            Text = "ITM-SDK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_header;
        private Button BTN_selectRoom;
    }
}
