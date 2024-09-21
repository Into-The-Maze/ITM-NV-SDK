namespace ITM_NV_SDK
{
    partial class FRM_ROOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ROOM));
            SPC_separator = new SplitContainer();
            TLP_roomContainer = new TableLayoutPanel();
            BTN_deselect = new Button();
            RTB_console = new RichTextBox();
            LBL_info = new Label();
            BTN_Export = new Button();
            BTN_edit = new Button();
            CBX_art = new ComboBox();
            BTN_globalApply = new Button();
            CHK_wall = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)SPC_separator).BeginInit();
            SPC_separator.Panel1.SuspendLayout();
            SPC_separator.Panel2.SuspendLayout();
            SPC_separator.SuspendLayout();
            SuspendLayout();
            // 
            // SPC_separator
            // 
            SPC_separator.Dock = DockStyle.Fill;
            SPC_separator.Location = new Point(0, 0);
            SPC_separator.Name = "SPC_separator";
            // 
            // SPC_separator.Panel1
            // 
            SPC_separator.Panel1.Controls.Add(TLP_roomContainer);
            // 
            // SPC_separator.Panel2
            // 
            SPC_separator.Panel2.Controls.Add(BTN_deselect);
            SPC_separator.Panel2.Controls.Add(RTB_console);
            SPC_separator.Panel2.Controls.Add(LBL_info);
            SPC_separator.Panel2.Controls.Add(BTN_Export);
            SPC_separator.Panel2.Controls.Add(BTN_edit);
            SPC_separator.Panel2.Controls.Add(CBX_art);
            SPC_separator.Panel2.Controls.Add(BTN_globalApply);
            SPC_separator.Panel2.Controls.Add(CHK_wall);
            SPC_separator.Size = new Size(684, 461);
            SPC_separator.SplitterDistance = 457;
            SPC_separator.TabIndex = 0;
            SPC_separator.KeyDown += SPC_separator_KeyDown;
            // 
            // TLP_roomContainer
            // 
            TLP_roomContainer.BackColor = SystemColors.ControlLight;
            TLP_roomContainer.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TLP_roomContainer.ColumnCount = 2;
            TLP_roomContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_roomContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_roomContainer.Location = new Point(12, 12);
            TLP_roomContainer.Name = "TLP_roomContainer";
            TLP_roomContainer.RowCount = 2;
            TLP_roomContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_roomContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_roomContainer.Size = new Size(200, 100);
            TLP_roomContainer.TabIndex = 0;
            TLP_roomContainer.CellPaint += TLP_roomContainer_CellPaint;
            TLP_roomContainer.MouseDown += TLP_roomContainer_MouseDown;
            // 
            // BTN_deselect
            // 
            BTN_deselect.BackColor = SystemColors.ControlDark;
            BTN_deselect.ForeColor = SystemColors.ControlLightLight;
            BTN_deselect.Location = new Point(15, 235);
            BTN_deselect.Name = "BTN_deselect";
            BTN_deselect.Size = new Size(203, 28);
            BTN_deselect.TabIndex = 7;
            BTN_deselect.Text = "Deselect";
            BTN_deselect.UseVisualStyleBackColor = false;
            BTN_deselect.Click += BTN_deselect_Click;
            BTN_deselect.KeyDown += BTN_deselect_KeyDown;
            // 
            // RTB_console
            // 
            RTB_console.BackColor = SystemColors.ControlDark;
            RTB_console.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RTB_console.ForeColor = SystemColors.Window;
            RTB_console.Location = new Point(15, 269);
            RTB_console.Name = "RTB_console";
            RTB_console.ReadOnly = true;
            RTB_console.ScrollBars = RichTextBoxScrollBars.None;
            RTB_console.Size = new Size(203, 128);
            RTB_console.TabIndex = 6;
            RTB_console.Text = "";
            RTB_console.TextChanged += RTB_console_TextChanged;
            RTB_console.KeyDown += RTB_console_KeyDown;
            // 
            // LBL_info
            // 
            LBL_info.AutoSize = true;
            LBL_info.ForeColor = SystemColors.ControlLight;
            LBL_info.Location = new Point(15, 97);
            LBL_info.Name = "LBL_info";
            LBL_info.Size = new Size(189, 135);
            LBL_info.TabIndex = 5;
            LBL_info.Text = resources.GetString("LBL_info.Text");
            // 
            // BTN_Export
            // 
            BTN_Export.BackColor = SystemColors.ControlDark;
            BTN_Export.ForeColor = SystemColors.ControlLightLight;
            BTN_Export.Location = new Point(15, 403);
            BTN_Export.Name = "BTN_Export";
            BTN_Export.Size = new Size(203, 46);
            BTN_Export.TabIndex = 4;
            BTN_Export.Text = "Export as JSON to clipboard";
            BTN_Export.UseVisualStyleBackColor = false;
            BTN_Export.Click += BTN_Export_Click;
            BTN_Export.KeyDown += BTN_Export_KeyDown;
            // 
            // BTN_edit
            // 
            BTN_edit.BackColor = SystemColors.ControlDark;
            BTN_edit.ForeColor = SystemColors.ControlLightLight;
            BTN_edit.Location = new Point(15, 68);
            BTN_edit.Name = "BTN_edit";
            BTN_edit.Size = new Size(203, 23);
            BTN_edit.TabIndex = 3;
            BTN_edit.Text = "Edit entities";
            BTN_edit.UseVisualStyleBackColor = false;
            BTN_edit.Click += BTN_edit_Click;
            BTN_edit.KeyDown += BTN_edit_KeyDown;
            // 
            // CBX_art
            // 
            CBX_art.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_art.FormattingEnabled = true;
            CBX_art.Location = new Point(75, 10);
            CBX_art.Name = "CBX_art";
            CBX_art.Size = new Size(143, 23);
            CBX_art.TabIndex = 2;
            CBX_art.SelectedIndexChanged += CBX_art_SelectedIndexChanged;
            CBX_art.KeyDown += CBX_art_KeyDown;
            // 
            // BTN_globalApply
            // 
            BTN_globalApply.BackColor = SystemColors.ControlDark;
            BTN_globalApply.ForeColor = SystemColors.ControlLightLight;
            BTN_globalApply.Location = new Point(15, 39);
            BTN_globalApply.Name = "BTN_globalApply";
            BTN_globalApply.Size = new Size(203, 23);
            BTN_globalApply.TabIndex = 1;
            BTN_globalApply.Text = "Apply this tileset to all similar tiles";
            BTN_globalApply.UseVisualStyleBackColor = false;
            BTN_globalApply.Click += BTN_globalApply_Click;
            BTN_globalApply.KeyDown += BTN_globalApply_KeyDown;
            // 
            // CHK_wall
            // 
            CHK_wall.AutoSize = true;
            CHK_wall.ForeColor = SystemColors.ControlLightLight;
            CHK_wall.Location = new Point(15, 12);
            CHK_wall.Name = "CHK_wall";
            CHK_wall.Size = new Size(54, 19);
            CHK_wall.TabIndex = 0;
            CHK_wall.Text = "Wall?";
            CHK_wall.UseVisualStyleBackColor = true;
            CHK_wall.CheckedChanged += CHK_wall_CheckedChanged;
            CHK_wall.KeyDown += CHK_wall_KeyDown;
            // 
            // FRM_ROOM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(684, 461);
            Controls.Add(SPC_separator);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FRM_ROOM";
            Text = "Design Room";
            KeyDown += FRM_ROOM_KeyDown;
            SPC_separator.Panel1.ResumeLayout(false);
            SPC_separator.Panel2.ResumeLayout(false);
            SPC_separator.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SPC_separator).EndInit();
            SPC_separator.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer SPC_separator;
        private TableLayoutPanel TLP_roomContainer;
        private CheckBox CHK_wall;
        private ComboBox CBX_art;
        private Button BTN_globalApply;
        private Button BTN_edit;
        private Button BTN_Export;
        private Label LBL_info;
        private RichTextBox RTB_console;
        private Button BTN_deselect;
    }
}