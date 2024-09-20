using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public FRM_ROOM(int width, int height, string name) {
            InitializeComponent();

            this.width = width;
            this.height = height;
            this.name = name;
            selectedCell = null;

            TLP_roomContainer.Width = width * G.TLP_CELL_PIXEL_SIZE + width + 1;
            TLP_roomContainer.Height = height * G.TLP_CELL_PIXEL_SIZE + height + 1;

            Debug.WriteLine($"{TLP_roomContainer.Width},{TLP_roomContainer.Height}");

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

            room = new Room(width, height, name);
            for (int i = 0;i < height;i++) {
                for (int j = 0; j < width; j++) {
                    room.cells[i, j] = new Cell(j, i);
                }
            }

            CHK_wall.Hide();
            CBX_art.Hide();
            BTN_edit.Hide();
            BTN_globalApply.Hide();

            foreach (string tileset in G_Tilesets.tilesetNames) {
                CBX_art.Items.Add(tileset);
            }
        }

        private void TLP_roomContainer_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            if (selectedCell != null) {
                if (selectedCell.Value.X == e.Column && selectedCell.Value.Y == e.Row) {
                    e.Graphics.FillRectangle(Brushes.LawnGreen, e.CellBounds);
                }
            }

            else if (room.cells[e.Row, e.Column].wall) //wall
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);

            else if (room.cells[e.Row, e.Column].EntitiesToSpawn.Count > 0) //cell with entities
                e.Graphics.FillEllipse(Brushes.Pink, e.CellBounds);

            else //empty floor
                e.Graphics.FillRectangle(Brushes.LightSlateGray, e.CellBounds);
        }

        private void TLP_roomContainer_MouseDown(object sender, MouseEventArgs e) {
            selectedCell = GetRowColIndex(TLP_roomContainer, TLP_roomContainer.PointToClient(Cursor.Position));

            if (selectedCell != null) {
                selectedRoomCell = room.cells[selectedCell.Value.Y, selectedCell.Value.X];
                CBX_art.SelectedValue = null;
                PullInfo();
            }
            else {
                CHK_wall.Hide();
                CBX_art.Hide();
                BTN_edit.Hide();
                BTN_globalApply.Hide();
            }

            TLP_roomContainer.Refresh();
        }

        private void PullInfo() {
            CHK_wall.Show();
            CBX_art.Show();
            BTN_edit.Show();
            BTN_globalApply.Show();

            CHK_wall.Checked = selectedRoomCell.wall;


            
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
    }
}
