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

        //To UNDO and REDO
        readonly Stack<Bitmap> UndoStack = new Stack<Bitmap>();
        readonly Stack<Bitmap> RedoStack = new Stack<Bitmap>();

        public static string theText;
        public static Font theFont;
        public static Color theFontColor;


        public StickFigureDrawing()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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

            drawStickManArmsDown = true;

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
            if(e.Button == MouseButtons.Left)
            {
                mouseX = e.X;
                mouseY = e.Y;
            
                UndoStack.Push((Bitmap)bitmapObject.Clone());
                RedoStack.Clear();
            }
            else if(e.Button == MouseButtons.Right)
            {
                int rightClickX = e.X;
                int rightClickY = e.Y;

                FormText textForm = new FormText();

                if(textForm.ShowDialog() == DialogResult.OK)
                {
                    UndoStack.Push((Bitmap)bitmapObject.Clone());
                    RedoStack.Clear();

                    Font chosenFont = new Font(theFont.FontFamily, theFont.Size, theFont.Style);
                    Brush chosenBrush = new SolidBrush(theFontColor);
                    graphicsObject.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                    graphicsObject.DrawString(theText, chosenFont, chosenBrush, rightClickX, rightClickY);

                    PbSurface.Invalidate();
                }

                textForm.Dispose();
            }
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

        private void btnArmsDown_Click_1(object sender, EventArgs e)
        {
            
        }

        //Undo button
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if(UndoStack.Count > 0)
            {
                RedoStack.Push((Bitmap)bitmapObject.Clone());
                bitmapObject = UndoStack.Pop();
                graphicsObject = Graphics.FromImage(bitmapObject);
                PbSurface.Invalidate();

            }
            else
            {
                MessageBox.Show("Nothing to undo");
            }
        }

        //Redo button
        private void btnRedo_Click(object sender, EventArgs e)
        {
            if(RedoStack.Count > 0)
            {
                UndoStack.Push((Bitmap)bitmapObject.Clone());
                bitmapObject = RedoStack.Pop();
                graphicsObject= Graphics.FromImage(bitmapObject);
                PbSurface.Invalidate();
            }
            else
            {
                MessageBox.Show("Nothing to redo");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(saveDB.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveDB.FileName;
                Bitmap bmpImage = new Bitmap(bitmapObject);
                bmpImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
                bmpImage.Dispose();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int stackCount = UndoStack.Count;
            int loopCount = 0;

            if (UndoStack.Count > 0)
            {
                do
                {
                    bitmapObject = UndoStack.Pop();
                    graphicsObject = Graphics.FromImage(bitmapObject);
                    PbSurface.Invalidate();
                    loopCount++;
                }while(loopCount < stackCount);
            }
        }

        private void radioSolid_Click(object sender, EventArgs e)
        {
            drawingPen.DashStyle = DashStyle.Solid;
        }

        private void radioDashed_Click(object sender, EventArgs e)
        {
            drawingPen.DashStyle = DashStyle.Dash;
        }

        private void TrackBrushSize_Scroll(object sender, EventArgs e)
        {
            drawingPen.Width = TrackBrushSize.Value;
        }

        private void DrawStickMan()
        {
            
            StickFigureDimensions size = new StickFigureDimensions(mouseY, mouseY1);

            //Head
            graphicsObject.DrawEllipse(drawingPen, mouseX, mouseY, size.HeadDiameter, size.HeadDiameter);

            //Body
            graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                                mouseY + size.HeadDiameter,
                                                mouseX +  size.HeadRadius,
                                                mouseY + size.HeadDiameter + size.BodySize);

            //Right Leg
            graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                                mouseY + (size.HeadDiameter + size.BodySize),
                                                mouseX + (size.HeadRadius + size.BaseUnit * 2),
                                                mouseY + (size.HeadDiameter + size.BodySize + size.LegSize));

            //Left Leg
            graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                                mouseY + (size.HeadDiameter + size.BodySize),
                                                mouseX + (size.HeadRadius - size.BaseUnit * 2),
                                                mouseY + (size.HeadDiameter + size.BodySize + size.LegSize));

           

            if (drawStickManStraight)
            {
               //Left Arm
               graphicsObject.DrawLine(drawingPen, mouseX,
                                                   size.MidBody,
                                                   mouseX + size.HeadRadius,
                                                   size.MidBody);

               //Right Arm
               graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                                   size.MidBody,
                                                   mouseX + size.HeadDiameter,
                                                   size.MidBody);
            }
            else if(drawStickManArmsUp)
            {
                //Left Arm
                graphicsObject.DrawLine(drawingPen, mouseX,
                                                size.MidBody - (size.BaseUnit * 2),
                                                mouseX + size.HeadRadius,
                                                size.MidBody);

                //Right Arm
                graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                                size.MidBody,
                                                mouseX + size.HeadDiameter,
                                                size.MidBody - (size.BaseUnit * 2));
            }
            //=====================================================================================
            //=====================================================================================
            //THIS CODE FOR THE ARMS TO GO DOWN NEEDS FIXING
            //=====================================================================================
            //=====================================================================================
            else if(drawStickManArmsDown)
            {
                //Left Arm
                graphicsObject.DrawLine(drawingPen, mouseX,
                                                    size.MidBody + (size.BaseUnit * 2),
                                                    mouseX + size.HeadRadius,
                                                    size.MidBody);

                //Right Arm
                graphicsObject.DrawLine(drawingPen, mouseX + size.HeadRadius,
                                                    size.MidBody,
                                                    mouseX + size.HeadDiameter,
                                                    size.MidBody + (size.BaseUnit * 2));
            }
            //=========================================================================================
            //=========================================================================================
            //END OF CODE THAT NEEDS FIXING
            //=========================================================================================
            //=========================================================================================
        }

        //=========================================================================================
        //=========================================================================================
        //CODE FOR STICK WOMAN NEEDS FIXING
        //=========================================================================================
        //=========================================================================================
        private void DrawStickLady()
        {
            StickFigureDimensions size = new StickFigureDimensions(mouseY, mouseY1);

            //The Triangle
            Point[] polygonPoints = new Point[3];

            polygonPoints[0] = new Point(0, 0);
            polygonPoints[1] = new Point(0, 0);
            polygonPoints[2] = new Point(0, 0);

            polygonPoints[0].X = mouseX + size.HeadRadius;
            polygonPoints[0].Y = mouseY + (int)(size.HeadDiameter + drawingPen.Width);
            polygonPoints[1].X = mouseX + size.HeadDiameter;
            polygonPoints[1].Y = mouseY + (size.HeadDiameter + size.BodySize);
            polygonPoints[2].X = mouseX;
            polygonPoints[2].Y = mouseY + (size.HeadDiameter + size.BodySize);

            //Head
            graphicsObject.DrawEllipse(drawingPen, mouseX, 
                                                   mouseY, 
                                                   size.HeadDiameter, 
                                                   size.HeadDiameter);

            //Body
            graphicsObject.DrawPolygon(drawingPen, polygonPoints);

            //Left Arm
            graphicsObject.DrawLine(drawingPen, mouseX,
                                                size.MidBody,
                                                mouseX + size.HeadRadius / 2,
                                                size.MidBody);

            //Right Arm
            graphicsObject.DrawLine(drawingPen, mouseX + (int)(size.HeadDiameter * 0.75),
                                                size.MidBody,
                                                mouseX + size.HeadDiameter,
                                                size.MidBody);

            //Left Leg
            graphicsObject.DrawLine(drawingPen, mouseX + (size.HeadRadius / 2),
                                                mouseY + size.HeadDiameter + size.BodySize,
                                                mouseX + (size.HeadRadius / 2),
                                                mouseY + size.HeadDiameter + size.BodySize + size.LegSize);

            //Right Leg
            graphicsObject.DrawLine(drawingPen, mouseX + (int)(size.HeadDiameter * 0.75),
                                                mouseY + size.HeadDiameter + size.BodySize,
                                                mouseX + (int)(size.HeadDiameter * 0.75),
                                                mouseY + size.HeadDiameter + size.BodySize + size.LegSize);
        }
        //=========================================================================================
        //=========================================================================================
        //END OF CODE THAT NEEDS FIXING
        //=========================================================================================
        //=========================================================================================
    }
}
