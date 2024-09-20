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
            SPC_separator.Panel2.Controls.Add(CHK_wall);
            SPC_separator.Size = new Size(650, 417);
            SPC_separator.SplitterDistance = 416;
            SPC_separator.TabIndex = 0;
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
            // 
            // FRM_ROOM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(650, 417);
            Controls.Add(SPC_separator);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FRM_ROOM";
            Text = "Design Room";
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
    }
}