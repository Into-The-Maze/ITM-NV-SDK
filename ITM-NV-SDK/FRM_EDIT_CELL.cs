using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITM_NV_SDK
{
    public partial class FRM_EDIT_CELL : Form
    {
        Cell selectedCell;
        RichTextBox RTB_console;

        int autoID = 1;
        int selectedShapeID;
        int selectedListID;
        bool commitSuccess;

        List<(int x, int y, int angle, string name, int id, Brush brush, Rectangle entityShape)> changes;
        readonly List<Brush> brushes = [ Brushes.Azure, Brushes.Green, Brushes.LawnGreen, Brushes.Magenta, Brushes.Orange, Brushes.SkyBlue,
            Brushes.Violet, Brushes.Yellow, Brushes.Pink ];
        Random rng = new();

        public FRM_EDIT_CELL(ref Cell selectedCell, RichTextBox rtb) {
            InitializeComponent();

            this.selectedCell = selectedCell;
            RTB_console = rtb;
            changes = [];

            NUM_angle.Enabled = false;
            NUM_xPos.Enabled = false;
            NUM_yPos.Enabled = false;
            commitSuccess = false;

            CBX_entityList.Items.Clear();
            foreach (var entity in G_Entities.entities) {
                CBX_entityList.Items.Add(entity.name);
            }
        }

        private void BTN_spawn_Click(object sender, EventArgs e) {
            if (CBX_entityList.Text == string.Empty) return;

            (int width, int height) temp = (-1, -1);
            foreach (var entity in G_Entities.entities) {
                if (CBX_entityList.Text == entity.name)
                    temp = (entity.width, entity.height);
                else
                    throw new Exception("Entity not found in database");
            }

            changes.Add((0, 0, 0, CBX_entityList.Text, autoID, brushes[rng.Next(0, brushes.Count)], new Rectangle(new Point(0, 0), new Size(temp.width, temp.height))));
            CBX_select.Items.Add($"{autoID} {CBX_entityList.Text}");
            autoID++;

            PNL_cell.Invalidate();
        }

        private void CBX_select_SelectedIndexChanged(object sender, EventArgs e) {
            if (CBX_select.SelectedIndex == -1) {
                NUM_angle.Enabled = false;
                NUM_xPos.Enabled = false;
                NUM_yPos.Enabled = false;
            }

            selectedShapeID = int.Parse(CBX_select.Text.Split(" ")[0]);
            selectedListID = -1;
            for (int i = 0; i < changes.Count; i++) {
                if (changes[i].id == selectedShapeID)
                    selectedListID = i;
            }

            NUM_angle.Enabled = true;
            NUM_xPos.Enabled = true;
            NUM_yPos.Enabled = true;

            NUM_angle.Value = changes[selectedListID].angle;
            NUM_xPos.Value = changes[selectedListID].x;
            NUM_yPos.Value = changes[selectedListID].y;
        }

        private void NUM_xPos_ValueChanged(object sender, EventArgs e) {
            var temp = changes[selectedListID];
            temp.x = (int)NUM_xPos.Value;
            temp.entityShape.X = (int)NUM_xPos.Value;
            changes[selectedListID] = temp;

            PNL_cell.Invalidate();
        }

        private void NUM_yPos_ValueChanged(object sender, EventArgs e) {
            var temp = changes[selectedListID];
            temp.y = (int)NUM_yPos.Value;
            temp.entityShape.Y = (int)NUM_yPos.Value;
            changes[selectedListID] = temp;

            PNL_cell.Invalidate();
        }

        private void NUM_angle_ValueChanged(object sender, EventArgs e) {
            var temp = changes[selectedListID];
            temp.angle = (int)NUM_angle.Value;
            changes[selectedListID] = temp;

            PNL_cell.Invalidate();
        }

        private void BTN_commit_Click(object sender, EventArgs e) {
            foreach (var change in changes) {
                selectedCell.EntitiesToSpawn.Add(new Entity(change.name, change.x, change.y, change.angle));
            }
            commitSuccess = true;
            Close();
        }

        private void PNL_cell_Paint(object sender, PaintEventArgs e) {
            foreach (var entity in changes) {
                e.Graphics.TranslateTransform(0, 100);
                e.Graphics.ScaleTransform(1, -1);

                float centerX = entity.entityShape.X;
                float centerY = entity.entityShape.Y;

                e.Graphics.TranslateTransform(centerX, centerY);

                e.Graphics.RotateTransform(-entity.angle);

                e.Graphics.FillRectangle(entity.brush, -entity.entityShape.Width / 2, -entity.entityShape.Height / 2, entity.entityShape.Width, entity.entityShape.Height);
                e.Graphics.DrawRectangle(Pens.Black, -entity.entityShape.Width / 2, -entity.entityShape.Height / 2, entity.entityShape.Width, entity.entityShape.Height);

                e.Graphics.ResetTransform();
            }
        }

        private void BTN_delete_Click(object sender, EventArgs e) {
            foreach (var entity in changes) {
                if (selectedShapeID == entity.id) {
                    changes.Remove(entity);

                    for (int i = 0; i < CBX_select.Items.Count; i++) {
                        if (int.Parse(CBX_select.Text.Split(" ")[0]) == selectedShapeID) {
                            CBX_select.Items.RemoveAt(i);
                            CBX_select.SelectedIndex = -1;
                            goto breakpoint;
                        }
                    }
                }
            }

        breakpoint:

            NUM_angle.Enabled = false;
            NUM_xPos.Enabled = false;
            NUM_yPos.Enabled = false;

            PNL_cell.Invalidate();
        }

        private void FRM_EDIT_CELL_FormClosing(object sender, FormClosingEventArgs e) {
            if (commitSuccess) 
                RTB_console.Text += "Cell edits successfully committed! Ending...\n";
            else
                RTB_console.Text += "Cell editing cancelled! Ending...\n";
        }
    }
}
