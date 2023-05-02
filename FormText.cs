using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stck_Figure_Drawing_Program
{
    public partial class FormText : Form
    {
        bool isFontColorSet;
        decimal fontSize;
        string FontFamily;
        Color fontColor;
        FontStyle style;

        public FormText()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormText_Load(object sender, EventArgs e)
        {
            //Calls system fonts
            InstalledFontCollection systemFonts = new InstalledFontCollection();

            FontFamily[] font = systemFonts.Families.ToArray();

            for (int i = 0; i < font.Length; i++)
            {
                CmbFontFamily.Items.Add(font[i].Name);
            }

            isFontColorSet = false;
            fontSize = 14;
            systemFonts.Dispose();
        }

        private void SpinFontSize_ValueChanged(object sender, EventArgs e)
        {
            fontSize = SpinFontSize.Value;
        }

        private void CmbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily = CmbFontFamily.Text;
        }

        private void btnFontColour_Click(object sender, EventArgs e)
        {
            if(colourDB.ShowDialog() != DialogResult.Cancel)
            {
                fontColor = colourDB.Color;
                labelColour.BackColor = colourDB.Color;
                isFontColorSet = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(isFontColorSet == false)
            {
                MessageBox.Show("The Font Colour is not set");
                return;
            }

            if (radioRegular.Checked)
            {
                style = FontStyle.Regular;
            }
            else if (radioBold.Checked)
            {
                style = FontStyle.Bold;
            }
            else if (radioItalic.Checked)
            {
                style = FontStyle.Italic;
            }

            Font fontObject = new Font(FontFamily, (float)fontSize, style);

            StickFigureDrawing.theFont = fontObject;
            StickFigureDrawing.theText = txtBoxStickFigure.Text;
            StickFigureDrawing.theFontColor = fontColor;

            DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
