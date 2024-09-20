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

        public FRM_ROOM(int width, int height, string name) {
            InitializeComponent();

            this.width = width;
            this.height = height;
            this.name = name;

            TLP_roomContainer.Width = width * G.TLP_CELL_PIXEL_SIZE - ((width.ToString().Length > 1) ? int.Parse(width.ToString()[0].ToString()) + 1 : 1);
            TLP_roomContainer.Height = height * G.TLP_CELL_PIXEL_SIZE - ((height.ToString().Length > 1) ? int.Parse(height.ToString()[0].ToString()) + 1 : 1);

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
        }

        private void TLP_roomContainer_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {

        }
    }
}
