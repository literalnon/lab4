using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        private Polygon polygon;
        private bool addPoint;
        private bool editPoint;
        private Graphics g;
        private Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            polygon = new Polygon();
            addPoint = false;
            editPoint = false;
            bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point location = new Point(105, 57);
            labelCoordinates.Location = location;
            polygon.AddPoint(140, 100);
            polygon.AddPoint(150, 200);
            polygon.AddPoint(300, 200);
            polygon.AddPoint(250, 90);
            polygon.AddEdgeIndexes(polygon.Points[0], polygon.Points[1]);
            polygon.AddEdgeIndexes(polygon.Points[1], polygon.Points[2]);
            polygon.AddEdgeIndexes(polygon.Points[2], polygon.Points[3]);
            polygon.AddEdgeIndexes(polygon.Points[3], polygon.Points[0]);

            RefreshComboBoxes();
            DrawPolygon();
            pictureBox1.Refresh();
        }

        private void buttonAddPoint_Click(object sender, EventArgs e)
        {
            addPoint = true;
            ChangeEnableGroupBoxes(false);
        }

        private void ChangeEnableGroupBoxes(bool b)
        {
            groupBoxEdge.Enabled =
                groupBoxPoint.Enabled =
                groupBoxRotate.Enabled =
                groupBoxScaling.Enabled =
                groupBoxTranslation.Enabled = b;
        }

        //Добавить в выпадающие списки имеющиеся элементы
        private void RefreshComboBoxes()
        {
            comboBoxEPoint1.Items.Clear();
            comboBoxEPoint2.Items.Clear();
            comboBoxPPoint.Items.Clear();
            comboBoxEdges.Items.Clear();
            pointAboutBox.Items.Clear();
            intersectionBox1.Items.Clear();
            intersectionBox2.Items.Clear();
            pointPositionBox.Items.Clear();
            edgePositionBox.Items.Clear();
            // для точек
            string[] strs = polygon.PointsToString();
            for (int i = 0; i < strs.Length; ++i)
            {
                comboBoxEPoint1.Items.Add(strs[i]);
                comboBoxEPoint2.Items.Add(strs[i]);
                comboBoxPPoint.Items.Add(strs[i]);
                pointAboutBox.Items.Add(strs[i]);
                pointPositionBox.Items.Add(strs[i]);
            }
            // для ребер
            strs = polygon.EdgesToString();
            for (int i = 0; i < strs.Length; ++i)
            {
                comboBoxEdges.Items.Add(strs[i]);
                intersectionBox1.Items.Add(strs[i]);
                intersectionBox2.Items.Add(strs[i]);
                edgePositionBox.Items.Add(strs[i]);
            }
            comboBoxEdges.Text = comboBoxEPoint1.Text = 
                comboBoxEPoint2.Text = comboBoxPPoint.Text = 
                pointAboutBox.Text = intersectionBox1.Text = intersectionBox2.Text = "";
        }

        private bool PointOutOfRange(Point p)
        {
            return p.X < 0 || p.X >= bmp.Width || p.Y < 0 || p.Y >= bmp.Height;
        }

        private void DrawPolygon()
        {
            g.Clear(pictureBox1.BackColor);
            foreach (Point p in polygon.Points)
            {
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }
            foreach (EdgeIndexes e in polygon.EdgesIndexes)
            {
                int ind1 = e.Ind_from;
                int ind2 = e.Ind_to;
                Point p1 = polygon.Points[ind1];
                Point p2 = polygon.Points[ind2];

                if (p1.X < 0) p1.X = 0;
                else if (p1.X >= bmp.Width) p1.X = Width;
                if (p1.Y < 0) p1.Y = 0;
                else if (p1.Y >= bmp.Height) p1.Y = Height;

                if (p2.X < 0) p2.X = 0;
                else if (p2.X >= bmp.Width) p2.X = Width;
                if (p2.Y < 0) p2.Y = 0;
                else if (p2.Y >= bmp.Height) p2.Y = Height;
                g.DrawLine(Pens.Black, p1, p2);
                pictureBox1.Refresh();
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeEnableGroupBoxes(true);
            if (e.Button == MouseButtons.Left)
                if (addPoint)
                {
                    polygon.AddPoint(e.Location.X, e.Location.Y);
                    RefreshComboBoxes();
                }
                else
                    if (editPoint)
                    {
                        int i = comboBoxPPoint.SelectedIndex;
                        if (i != -1)
                        {
                            polygon.MovingPoint(polygon.Points[i], e.Location);
                            DrawPolygon();
                            RefreshComboBoxes();
                        }
                    }
        }

        private void buttonDeletePoint_Click(object sender, EventArgs e)
        {
            int ind = comboBoxPPoint.SelectedIndex;
            polygon.DeletePoint(ind);
            DrawPolygon();
            RefreshComboBoxes();
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            int angle = trackBar1.Value;
            polygon.Rotate(angle, pointAboutBox.SelectedIndex);
            DrawPolygon();
            RefreshComboBoxes();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            labelAngle.Text = trackBar1.Value.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelCoordinates.Text = "(" + e.Location.X.ToString() + "; " + e.Location.Y.ToString() + ")";
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            if (textBoxTrX.Text.Length != 0 && !int.TryParse(textBoxTrX.Text, out x) ||
               textBoxTrY.Text.Length != 0 && !int.TryParse(textBoxTrY.Text, out y))
            {
                MessageBox.Show("Enter int values");
                return;
            }
            polygon.Translate(x, y);
            DrawPolygon();
            RefreshComboBoxes();
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            double x = 1;
            double y = 1;
            if (textBoxScX.Text.Length != 0 && !double.TryParse(textBoxScX.Text, out x) ||
                textBoxScY.Text.Length != 0 && !double.TryParse(textBoxScY.Text, out y))
            {
                MessageBox.Show("Enter double values");
                return;
            }
            polygon.Scale(x, y);
            DrawPolygon();
            RefreshComboBoxes();
        }

        private void buttonAddEdge_Click(object sender, EventArgs e)
        {
            int ind1 = comboBoxEPoint1.SelectedIndex;
            int ind2 = comboBoxEPoint2.SelectedIndex;
            if (ind1 != -1 && ind2 != -1)
            {
                polygon.AddEdgeIndexes(ind1, ind2);
                DrawPolygon();
                RefreshComboBoxes();
            }
        }

        private void buttonEditPoint_Click(object sender, EventArgs e)
        {
            editPoint = true;
            ChangeEnableGroupBoxes(false);
        }

        private void buttonDeleteEdge_Click(object sender, EventArgs e)
        {
            polygon.DeleteEdge(comboBoxEdges.SelectedIndex);
            RefreshComboBoxes();
            DrawPolygon();
        }

        //private void buttonReflect_Click(object sender, EventArgs e)
        //{
        //    polygon.Reflect(axis);
        //    RefreshComboBoxes();
        //    DrawPolygon();
        //}

        //private void radioButtonX_CheckedChanged(object sender, EventArgs e)
        //{
        //   if (radioButtonX.Checked)
        //        axis = Polygon.Axis.X_axis;
        //    else
        //        if (radioButtonY.Checked)
        //            axis = Polygon.Axis.Y_axis;
        //}

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EdgeCenterRotation_Click(object sender, EventArgs e)
        {
            if (comboBoxEdges.SelectedIndex == -1)
            {
                MessageBox.Show("Choose the edge");
                return;
            }
            polygon.RotateEdge(comboBoxEdges.SelectedIndex);
        }

        private void findIntersection_Click(object sender, EventArgs e)
        {
            if (intersectionBox1.SelectedIndex == -1 || intersectionBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Choose two edges!");
                return;
            }

            if (intersectionBox1.SelectedIndex == intersectionBox2.SelectedIndex)
            {
                MessageBox.Show("Choose different edges!");
                return;
            }

            intersectionLabel.Text = polygon.FindIntersection(intersectionBox1.SelectedIndex, intersectionBox2.SelectedIndex).ToString();
        }

        private void belongsToRect_Click(object sender, EventArgs e)
        {
            if (pointPositionBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose the point");
                return;
            }
            if (polygon.pointInRect(pointPositionBox.SelectedIndex))
                pointInRect.Text = "Yes";
            else
                pointInRect.Text = "No";
        }

        private void pointPositionButton_Click(object sender, EventArgs e)
        {
            if (pointPositionBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose the point");
                return;
            }
            if (edgePositionBox.SelectedIndex == -1)
            {
                MessageBox.Show("Choose the edge");
                return;
            }
            int res = polygon.getPointPosition(pointPositionBox.SelectedIndex, edgePositionBox.SelectedIndex);
            if (res == 0)
                pointPosition.Text = "On the edge";
            if (res == -1)
                pointPosition.Text = "Right";
            if (res == 1)
                pointPosition.Text = "Left";

        }
    }
}
