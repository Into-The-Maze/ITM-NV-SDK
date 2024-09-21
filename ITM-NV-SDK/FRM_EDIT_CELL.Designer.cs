namespace ITM_NV_SDK
{
    partial class FRM_EDIT_CELL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EDIT_CELL));
            PNL_cell = new Panel();
            CBX_entityList = new ComboBox();
            BTN_spawn = new Button();
            CBX_select = new ComboBox();
            NUM_xPos = new NumericUpDown();
            NUM_yPos = new NumericUpDown();
            NUM_angle = new NumericUpDown();
            LBL_x = new Label();
            LBL_y = new Label();
            LBL_angle = new Label();
            BTN_commit = new Button();
            BTN_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)NUM_xPos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUM_yPos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUM_angle).BeginInit();
            SuspendLayout();
            // 
            // PNL_cell
            // 
            PNL_cell.BackColor = SystemColors.ControlDark;
            PNL_cell.BorderStyle = BorderStyle.FixedSingle;
            PNL_cell.Location = new Point(12, 12);
            PNL_cell.Name = "PNL_cell";
            PNL_cell.Size = new Size(100, 100);
            PNL_cell.TabIndex = 0;
            PNL_cell.Paint += PNL_cell_Paint;
            // 
            // CBX_entityList
            // 
            CBX_entityList.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_entityList.FormattingEnabled = true;
            CBX_entityList.Location = new Point(118, 12);
            CBX_entityList.Name = "CBX_entityList";
            CBX_entityList.Size = new Size(121, 23);
            CBX_entityList.TabIndex = 1;
            // 
            // BTN_spawn
            // 
            BTN_spawn.BackColor = SystemColors.ControlDark;
            BTN_spawn.ForeColor = SystemColors.ControlLightLight;
            BTN_spawn.Location = new Point(245, 12);
            BTN_spawn.Name = "BTN_spawn";
            BTN_spawn.Size = new Size(75, 23);
            BTN_spawn.TabIndex = 2;
            BTN_spawn.Text = "Spawn";
            BTN_spawn.UseVisualStyleBackColor = false;
            BTN_spawn.Click += BTN_spawn_Click;
            // 
            // CBX_select
            // 
            CBX_select.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_select.FormattingEnabled = true;
            CBX_select.Location = new Point(118, 41);
            CBX_select.Name = "CBX_select";
            CBX_select.Size = new Size(121, 23);
            CBX_select.TabIndex = 3;
            CBX_select.SelectedIndexChanged += CBX_select_SelectedIndexChanged;
            // 
            // NUM_xPos
            // 
            NUM_xPos.Location = new Point(368, 12);
            NUM_xPos.Name = "NUM_xPos";
            NUM_xPos.Size = new Size(120, 23);
            NUM_xPos.TabIndex = 4;
            NUM_xPos.ValueChanged += NUM_xPos_ValueChanged;
            // 
            // NUM_yPos
            // 
            NUM_yPos.Location = new Point(368, 47);
            NUM_yPos.Name = "NUM_yPos";
            NUM_yPos.Size = new Size(120, 23);
            NUM_yPos.TabIndex = 5;
            NUM_yPos.ValueChanged += NUM_yPos_ValueChanged;
            // 
            // NUM_angle
            // 
            NUM_angle.Location = new Point(368, 82);
            NUM_angle.Maximum = new decimal(new int[] { 359, 0, 0, 0 });
            NUM_angle.Name = "NUM_angle";
            NUM_angle.Size = new Size(120, 23);
            NUM_angle.TabIndex = 6;
            NUM_angle.ValueChanged += NUM_angle_ValueChanged;
            // 
            // LBL_x
            // 
            LBL_x.AutoSize = true;
            LBL_x.Location = new Point(326, 16);
            LBL_x.Name = "LBL_x";
            LBL_x.Size = new Size(36, 15);
            LBL_x.TabIndex = 7;
            LBL_x.Text = "X pos";
            // 
            // LBL_y
            // 
            LBL_y.AutoSize = true;
            LBL_y.Location = new Point(326, 49);
            LBL_y.Name = "LBL_y";
            LBL_y.Size = new Size(36, 15);
            LBL_y.TabIndex = 8;
            LBL_y.Text = "Y pos";
            // 
            // LBL_angle
            // 
            LBL_angle.AutoSize = true;
            LBL_angle.Location = new Point(326, 84);
            LBL_angle.Name = "LBL_angle";
            LBL_angle.Size = new Size(38, 15);
            LBL_angle.TabIndex = 9;
            LBL_angle.Text = "Angle";
            // 
            // BTN_commit
            // 
            BTN_commit.BackColor = SystemColors.ControlDark;
            BTN_commit.ForeColor = SystemColors.ControlLightLight;
            BTN_commit.Location = new Point(118, 70);
            BTN_commit.Name = "BTN_commit";
            BTN_commit.Size = new Size(202, 42);
            BTN_commit.TabIndex = 10;
            BTN_commit.Text = "Commit Entities";
            BTN_commit.UseVisualStyleBackColor = false;
            BTN_commit.Click += BTN_commit_Click;
            // 
            // BTN_delete
            // 
            BTN_delete.BackColor = SystemColors.ControlDark;
            BTN_delete.ForeColor = SystemColors.ControlLightLight;
            BTN_delete.Location = new Point(245, 41);
            BTN_delete.Name = "BTN_delete";
            BTN_delete.Size = new Size(75, 23);
            BTN_delete.TabIndex = 11;
            BTN_delete.Text = "Delete";
            BTN_delete.UseVisualStyleBackColor = false;
            BTN_delete.Click += BTN_delete_Click;
            // 
            // FRM_EDIT_CELL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(499, 122);
            Controls.Add(BTN_delete);
            Controls.Add(BTN_commit);
            Controls.Add(LBL_angle);
            Controls.Add(LBL_y);
            Controls.Add(LBL_x);
            Controls.Add(NUM_angle);
            Controls.Add(NUM_yPos);
            Controls.Add(NUM_xPos);
            Controls.Add(CBX_select);
            Controls.Add(BTN_spawn);
            Controls.Add(CBX_entityList);
            Controls.Add(PNL_cell);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FRM_EDIT_CELL";
            Text = "Edit Cell Entities";
            FormClosing += FRM_EDIT_CELL_FormClosing;
            ((System.ComponentModel.ISupportInitialize)NUM_xPos).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUM_yPos).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUM_angle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PNL_cell;
        private ComboBox CBX_entityList;
        private Button BTN_spawn;
        private ComboBox CBX_select;
        private NumericUpDown NUM_xPos;
        private NumericUpDown NUM_yPos;
        private NumericUpDown NUM_angle;
        private Label LBL_x;
        private Label LBL_y;
        private Label LBL_angle;
        private Button BTN_commit;
        private Button BTN_delete;
    }
}