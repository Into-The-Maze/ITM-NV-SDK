using Newtonsoft.Json;

namespace ITM_NV_SDK
{
    public partial class FRM_ROOM : Form
    {
        private readonly int width;
        private readonly int height;
        private readonly string name;

        private Point? selectedCell;
        private Room room;
        private Cell selectedRoomCell;

        private bool dontUpdateConsole;

        public FRM_ROOM(int width, int height, string name) {
            InitializeComponent();

            Text = $"Design room: {name}";

            this.width = width;
            this.height = height;
            this.name = name;
            selectedCell = null;
            dontUpdateConsole = false;

            TLP_roomContainer.Width = width * G.TLP_CELL_PIXEL_SIZE + width + 1;
            TLP_roomContainer.Height = height * G.TLP_CELL_PIXEL_SIZE + height + 1;

            TLP_roomContainer.ColumnCount = width;
            TLP_roomContainer.RowCount = height;

            TLP_roomContainer.ColumnStyles.Clear();
            for (int i = 0; i < width; i++) {
                TLP_roomContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, G.TLP_CELL_PIXEL_SIZE));
            }

            TLP_roomContainer.RowStyles.Clear();
            for (int i = 0; i < height; i++) {
                TLP_roomContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, G.TLP_CELL_PIXEL_SIZE));
            }

            room = new Room(this.width, this.height, this.name);
            for (int i = 0; i < room.height; i++) {
                for (int j = 0; j < room.width; j++) {
                    room.cells[i, j] = new Cell(j, i);
                }
            }

            CHK_wall.Enabled = false;
            CBX_art.Enabled = false;
            BTN_edit.Enabled = false;
            BTN_globalApply.Enabled = false;

            CBX_art.DataSource = G_Tilesets.tilesetNames;
        }

        private void TLP_roomContainer_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            if (room.cells[e.Row, e.Column].wall) //wall
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);

            else if (room.cells[e.Row, e.Column].EntitiesToSpawn.Count > 0) //cell with entities
                e.Graphics.FillEllipse(Brushes.HotPink, e.CellBounds);

            else //empty floor
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);

            if (selectedCell != null) {
                if (selectedCell.Value.X == e.Column && selectedCell.Value.Y == e.Row) {
                    e.Graphics.FillRectangle(Brushes.LawnGreen, e.CellBounds);
                }
            }
        }

        private void TLP_roomContainer_MouseDown(object sender, MouseEventArgs e) {
            selectedCell = GetRowColIndex(TLP_roomContainer, TLP_roomContainer.PointToClient(Cursor.Position));

            if (selectedCell != null) {
                selectedRoomCell = room.cells[selectedCell.Value.Y, selectedCell.Value.X];

                PullInfo();
            }
            else {
                CHK_wall.Enabled = false;
                CBX_art.Enabled = false;
                BTN_edit.Enabled = false;
                BTN_globalApply.Enabled = false;
                CBX_art.SelectedIndex = -1;
            }

            TLP_roomContainer.Refresh();
        }

        private void PullInfo() {
            CHK_wall.Enabled = true;
            CBX_art.Enabled = true;
            BTN_edit.Enabled = true;
            BTN_globalApply.Enabled = true;

            dontUpdateConsole = true;
            CHK_wall.Checked = selectedRoomCell.wall;
            dontUpdateConsole = false;

            if (selectedRoomCell.wall)
                BTN_edit.Enabled = false;
            else
                BTN_edit.Enabled = true;

            if (selectedRoomCell.tilesetName == string.Empty) {
                CBX_art.SelectedIndex = -1;
            }
            else {
                for (int i = 0; i < CBX_art.Items.Count; i++) {
                    if (selectedRoomCell.tilesetName == (string)CBX_art.Items[i]) {
                        CBX_art.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        Point? GetRowColIndex(TableLayoutPanel tlp, Point point) {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }

        private void CHK_wall_CheckedChanged(object sender, EventArgs e) {
            selectedRoomCell.wall = CHK_wall.Checked;
            if (selectedRoomCell.wall) {
                selectedRoomCell.EntitiesToSpawn.Clear(); //remove entites on becoming wall
                BTN_edit.Enabled = false;
            }
            else {
                BTN_edit.Enabled = true;
            }

            if (!dontUpdateConsole)
                RTB_console.Text += $"Cell at x:{selectedRoomCell.x}, y:{selectedRoomCell.y} successfully changed to {(CHK_wall.Checked ? "wall" : "floor")}!\n";
        }

        private void CBX_art_SelectedIndexChanged(object sender, EventArgs e) {
            if (selectedRoomCell == null) return;
            if (CBX_art.Text == string.Empty) return;

            selectedRoomCell.tilesetName = CBX_art.Text;
            RTB_console.Text += $"Tileset {selectedRoomCell.tilesetName} successfully applied to cell at x:{selectedRoomCell.x}, y:{selectedRoomCell.y}!\n";
        }

        private void BTN_globalApply_Click(object sender, EventArgs e) {
            if (selectedRoomCell.wall) {
                foreach (var cell in room.cells) {
                    if (cell.wall)
                        cell.tilesetName = selectedRoomCell.tilesetName;
                }

                RTB_console.Text += $"Tileset {selectedRoomCell.tilesetName} successfully applied to walls!\n";
            }
            else {
                foreach (var cell in room.cells) {
                    if (!cell.wall)
                        cell.tilesetName = selectedRoomCell.tilesetName;
                }

                RTB_console.Text += $"Tileset {selectedRoomCell.tilesetName} successfully applied to floors!\n";
            }
        }

        private void RTB_console_TextChanged(object sender, EventArgs e) {
            RTB_console.SelectionStart = RTB_console.Text.Length;
            RTB_console.ScrollToCaret();
        }

        private void BTN_edit_Click(object sender, EventArgs e) {
            selectedRoomCell.EntitiesToSpawn.Clear();
            FRM_EDIT_CELL editor = new(ref selectedRoomCell, RTB_console);
            RTB_console.Text += $"Editing cell at x:{selectedRoomCell.x}, y:{selectedRoomCell.y}!\n";
            editor.ShowDialog();
            RTB_console.Text += "Ended!\n";

        }

        private void BTN_Export_Click(object sender, EventArgs e) {
            string roomJSON = JsonConvert.SerializeObject(room);
            Clipboard.SetText(roomJSON);
            RTB_console.Text += "Room copied to clipboard!\n";
        }

        private void BTN_deselect_Click(object sender, EventArgs e) {
            selectedCell = null;
            selectedRoomCell = null;
            CHK_wall.Enabled = false;
            CBX_art.Enabled = false;
            BTN_edit.Enabled = false;
            BTN_globalApply.Enabled = false;
            CBX_art.SelectedIndex = -1;
            TLP_roomContainer.Refresh();
        }

        #region keyHandlers
        private void FRM_ROOM_KeyDown(object sender, KeyEventArgs e) {
            if (selectedCell == null) return;
            HandleWASD(e);
        }

        private void SPC_separator_KeyDown(object sender, KeyEventArgs e) {
            if (selectedCell == null) return;
            HandleWASD(e);
        }

        private void CHK_wall_KeyDown(object sender, KeyEventArgs e) {
            if (selectedCell == null) return;
            HandleWASD(e);
        }

        private void CBX_art_KeyDown(object sender, KeyEventArgs e) {
            if (selectedCell == null) return;
            HandleWASD(e);
        }

        private void BTN_globalApply_KeyDown(object sender, KeyEventArgs e) {
            if (selectedCell == null) return;
            HandleWASD(e);
        }

        private void BTN_edit_KeyDown(object sender, KeyEventArgs e) {
            if (selectedCell == null) return;
            HandleWASD(e);
        }

        private void BTN_deselect_KeyDown(object sender, KeyEventArgs e) {
            if (selectedCell == null) return;
            HandleWASD(e);
        }

        private void RTB_console_KeyDown(object sender, KeyEventArgs e) {
            if (selectedCell == null) return;
            HandleWASD(e);
        }

        private void BTN_Export_KeyDown(object sender, KeyEventArgs e) {
            if (selectedCell == null) return;
            HandleWASD(e);
        }
        #endregion

        private void HandleWASD(KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.W:
                    if (selectedCell.Value.Y - 1 >= 0) {
                        selectedCell = new Point(selectedCell.Value.X, selectedCell.Value.Y - 1);
                    }
                    break;

                case Keys.A:
                    if (selectedCell.Value.X - 1 >= 0) {
                        selectedCell = new Point(selectedCell.Value.X - 1, selectedCell.Value.Y);
                    }
                    break;

                case Keys.S:
                    if (selectedCell.Value.Y + 1 <= room.height - 1) {
                        selectedCell = new Point(selectedCell.Value.X, selectedCell.Value.Y + 1);
                    }
                    break;

                case Keys.D:
                    if (selectedCell.Value.X + 1 <= room.width - 1) {
                        selectedCell = new Point(selectedCell.Value.X + 1, selectedCell.Value.Y);
                    }
                    break;

                default:
                    break;
            }

            if (selectedCell != null) {
                selectedRoomCell = room.cells[selectedCell.Value.Y, selectedCell.Value.X];

                PullInfo();
            }
            else {
                CHK_wall.Enabled = false;
                CBX_art.Enabled = false;
                BTN_edit.Enabled = false;
                BTN_globalApply.Enabled = false;
                CBX_art.SelectedIndex = -1;
            }

            TLP_roomContainer.Refresh();
        }
    }
}
