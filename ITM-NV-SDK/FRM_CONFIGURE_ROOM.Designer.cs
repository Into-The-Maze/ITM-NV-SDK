namespace ITM_NV_SDK
{
    partial class FRM_CONFIGURE_ROOM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_CONFIGURE_ROOM));
            NUM_width = new NumericUpDown();
            NUM_height = new NumericUpDown();
            TXT_name = new TextBox();
            LBL_width = new Label();
            LBL_height = new Label();
            LBL_name = new Label();
            BTN_createRoom = new Button();
            ((System.ComponentModel.ISupportInitialize)NUM_width).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUM_height).BeginInit();
            SuspendLayout();
            // 
            // NUM_width
            // 
            NUM_width.Location = new Point(63, 12);
            NUM_width.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            NUM_width.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUM_width.Name = "NUM_width";
            NUM_width.Size = new Size(120, 23);
            NUM_width.TabIndex = 0;
            NUM_width.ThousandsSeparator = true;
            NUM_width.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NUM_height
            // 
            NUM_height.Location = new Point(63, 41);
            NUM_height.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            NUM_height.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUM_height.Name = "NUM_height";
            NUM_height.Size = new Size(120, 23);
            NUM_height.TabIndex = 1;
            NUM_height.ThousandsSeparator = true;
            NUM_height.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TXT_name
            // 
            TXT_name.Location = new Point(63, 70);
            TXT_name.Name = "TXT_name";
            TXT_name.PlaceholderText = "eg: L3-CAVE";
            TXT_name.Size = new Size(120, 23);
            TXT_name.TabIndex = 2;
            // 
            // LBL_width
            // 
            LBL_width.AutoSize = true;
            LBL_width.ForeColor = SystemColors.ControlLight;
            LBL_width.Location = new Point(12, 14);
            LBL_width.Name = "LBL_width";
            LBL_width.Size = new Size(39, 15);
            LBL_width.TabIndex = 3;
            LBL_width.Text = "Width";
            // 
            // LBL_height
            // 
            LBL_height.AutoSize = true;
            LBL_height.ForeColor = SystemColors.ControlLight;
            LBL_height.Location = new Point(12, 43);
            LBL_height.Name = "LBL_height";
            LBL_height.Size = new Size(43, 15);
            LBL_height.TabIndex = 4;
            LBL_height.Text = "Height";
            // 
            // LBL_name
            // 
            LBL_name.AutoSize = true;
            LBL_name.ForeColor = SystemColors.ControlLight;
            LBL_name.Location = new Point(12, 73);
            LBL_name.Name = "LBL_name";
            LBL_name.Size = new Size(39, 15);
            LBL_name.TabIndex = 5;
            LBL_name.Text = "Name";
            // 
            // BTN_createRoom
            // 
            BTN_createRoom.BackColor = SystemColors.ControlDark;
            BTN_createRoom.ForeColor = SystemColors.ControlLightLight;
            BTN_createRoom.Location = new Point(12, 186);
            BTN_createRoom.Name = "BTN_createRoom";
            BTN_createRoom.Size = new Size(171, 35);
            BTN_createRoom.TabIndex = 6;
            BTN_createRoom.Text = "Create";
            BTN_createRoom.UseVisualStyleBackColor = false;
            BTN_createRoom.Click += BTN_createRoom_Click;
            // 
            // FRM_CONFIGURE_ROOM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(195, 233);
            Controls.Add(BTN_createRoom);
            Controls.Add(LBL_name);
            Controls.Add(LBL_height);
            Controls.Add(LBL_width);
            Controls.Add(TXT_name);
            Controls.Add(NUM_height);
            Controls.Add(NUM_width);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FRM_CONFIGURE_ROOM";
            Text = "Configure Room";
            ((System.ComponentModel.ISupportInitialize)NUM_width).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUM_height).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NUM_width;
        private NumericUpDown NUM_height;
        private TextBox TXT_name;
        private Label LBL_width;
        private Label LBL_height;
        private Label LBL_name;
        private Button BTN_createRoom;
    }
}