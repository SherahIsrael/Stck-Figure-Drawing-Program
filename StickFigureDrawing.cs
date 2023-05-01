using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;//Calls Drawing Pen

namespace Stck_Figure_Drawing_Program
{
    public partial class StickFigureDrawing : Form
    {
        Pen drawingPen;
        int mouseX, mouseY, mouseX1, mouseY1;

        //boolean variables
        bool drawStickManStraight = false;
        bool drawStickManArmsUp = false; 
        bool drawStickManArmsDown = false;
        bool drawStickWoman = false;

        //To draw on the picture box
        Bitmap bitmapObject;
        Graphics graphicsObject;

        Rectangle rectangle1;

        public StickFigureDrawing()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsUp = true;
            drawStickManArmsDown = false;
            drawStickWoman = false;
        }

        private void radioDashed_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void StickFigureDrawing_Load(object sender, EventArgs e)
        {
            PbSurface.Cursor = Cursors.Cross;
            
            //To Allow Drawing
            bitmapObject = new Bitmap(PbSurface.Width, PbSurface.Height);
            graphicsObject = Graphics.FromImage(bitmapObject);

            drawStickManStraight = true;

            //Allows all known colours  to be accessed by the comboBox and removes the system colours
            foreach (KnownColor inbuiltColor in Enum.GetValues(typeof(KnownColor))) {
                
                Color loadColor = Color.FromKnownColor(inbuiltColor);

                if (loadColor.IsSystemColor == false)
                {
                    if (loadColor.Name != "Transparent")
                    {
                      cmbColours.Items.Add(loadColor);
                    }
                }
                
            }

            //Drawing Pen SetUp
            drawingPen = new Pen(Color.Black);
            drawingPen.DashStyle = DashStyle.Solid;
            drawingPen.Width = TrackBrushSize.Value;

        }

        private void cmbColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelColour.BackColor = Color.FromName(cmbColours.Text);
            drawingPen.Color = Color.FromName(cmbColours.Text);
        }


        //Colour Dialog Box
        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (ColorDB.ShowDialog() != DialogResult.Cancel)
            {
                labelColour.BackColor = ColorDB.Color;
                drawingPen.Color = ColorDB.Color;
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            labelColour.BackColor = Color.Blue;
            drawingPen.Color = Color.Blue;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            labelColour.BackColor = Color.Red;
            drawingPen.Color = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            labelColour.BackColor = Color.Lime;
            drawingPen.Color = Color.Lime;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            labelColour.BackColor = Color.Yellow;
            drawingPen.Color = Color.Yellow;
        }

        private void PbSurface_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void PbSurface_MouseUp(object sender, MouseEventArgs e)
        {
            
            if(e.Button == MouseButtons.Left)
            {
               mouseX1 = e.X;
               mouseY1 = e.Y;
            }

            graphicsObject.SmoothingMode = SmoothingMode.AntiAlias;
            if (drawStickWoman)
            {
                DrawStickLady();
            }
            else
            {
                DrawStickMan();
            }

            PbSurface.Invalidate();
        }

        private void labelColour_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnArmsStraight_Click(object sender, EventArgs e)
        {
            drawStickManStraight = true;
            drawStickManArmsUp = false;
            drawStickManArmsDown = false;
            drawStickWoman = false;
        }

        private void btnArmsUp_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsUp = true;
            drawStickManArmsDown = false;
            drawStickWoman = false;
        }

        private void btnArmsDown_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsUp = false;
            drawStickManArmsDown = true;
            drawStickWoman = false;
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            drawStickManStraight = false;
            drawStickManArmsUp = false;
            drawStickManArmsDown = false;
            drawStickWoman = true;

            
        }

        private void PbSurface_Click(object sender, EventArgs e)
        {

        }

        private void PbSurface_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmapObject, 0, 0);
            
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            labelColour.BackColor = Color.Black;
            drawingPen.Color = Color.Black;
        }

        private void bnGrey_Click(object sender, EventArgs e)
        {
            labelColour.BackColor = Color.Gray;
            drawingPen.Color = Color.Gray;
        }

        private void btnArmsStraight_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmapObject, 0, 0);
        }

        private void TrackBrushSize_Scroll(object sender, EventArgs e)
        {
            drawingPen.Width = TrackBrushSize.Value;
        }

        private void DrawStickMan()
        {
            graphicsObject.DrawEllipse(drawingPen, mouseX, mouseY, mouseY - mouseY1, mouseY - mouseY1);
        }

        private void DrawStickLady()
        {

        }
    }
}
