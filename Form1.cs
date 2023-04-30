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

        //Allows all known colours  to be accessed by the comboBox and removes the system colours
        private void StickFigureDrawing_Load(object sender, EventArgs e)
        {
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
            labelColour.BackColor = Color.Green;
            drawingPen.Color = Color.Green;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            labelColour.BackColor = Color.Yellow;
            drawingPen.Color = Color.Yellow;
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

        private void TrackBrushSize_Scroll(object sender, EventArgs e)
        {
            drawingPen.Width = TrackBrushSize.Value;
        }
    }
}
