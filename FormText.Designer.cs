namespace Stck_Figure_Drawing_Program
{
    partial class FormText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormText));
            this.txtBoxStickFigure = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbFontFamily = new System.Windows.Forms.ComboBox();
            this.SpinFontSize = new System.Windows.Forms.NumericUpDown();
            this.radioRegular = new System.Windows.Forms.RadioButton();
            this.radioBold = new System.Windows.Forms.RadioButton();
            this.radioItalic = new System.Windows.Forms.RadioButton();
            this.btnFontColour = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelColour = new System.Windows.Forms.Label();
            this.colourDB = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxStickFigure
            // 
            this.txtBoxStickFigure.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStickFigure.Location = new System.Drawing.Point(24, 23);
            this.txtBoxStickFigure.Multiline = true;
            this.txtBoxStickFigure.Name = "txtBoxStickFigure";
            this.txtBoxStickFigure.Size = new System.Drawing.Size(364, 75);
            this.txtBoxStickFigure.TabIndex = 0;
            this.txtBoxStickFigure.Text = "Default Text";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpinFontSize);
            this.groupBox1.Controls.Add(this.CmbFontFamily);
            this.groupBox1.Location = new System.Drawing.Point(24, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Family and Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioItalic);
            this.groupBox2.Controls.Add(this.radioBold);
            this.groupBox2.Controls.Add(this.radioRegular);
            this.groupBox2.Location = new System.Drawing.Point(24, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Style";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelColour);
            this.groupBox3.Controls.Add(this.btnFontColour);
            this.groupBox3.Location = new System.Drawing.Point(24, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Font Colour";
            // 
            // CmbFontFamily
            // 
            this.CmbFontFamily.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFontFamily.FormattingEnabled = true;
            this.CmbFontFamily.Location = new System.Drawing.Point(15, 34);
            this.CmbFontFamily.Name = "CmbFontFamily";
            this.CmbFontFamily.Size = new System.Drawing.Size(243, 49);
            this.CmbFontFamily.TabIndex = 0;
            this.CmbFontFamily.SelectedIndexChanged += new System.EventHandler(this.CmbFontFamily_SelectedIndexChanged);
            // 
            // SpinFontSize
            // 
            this.SpinFontSize.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinFontSize.Location = new System.Drawing.Point(273, 34);
            this.SpinFontSize.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.SpinFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.SpinFontSize.Name = "SpinFontSize";
            this.SpinFontSize.Size = new System.Drawing.Size(85, 55);
            this.SpinFontSize.TabIndex = 1;
            this.SpinFontSize.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.SpinFontSize.ValueChanged += new System.EventHandler(this.SpinFontSize_ValueChanged);
            // 
            // radioRegular
            // 
            this.radioRegular.AutoSize = true;
            this.radioRegular.Checked = true;
            this.radioRegular.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioRegular.Location = new System.Drawing.Point(9, 34);
            this.radioRegular.Name = "radioRegular";
            this.radioRegular.Size = new System.Drawing.Size(142, 39);
            this.radioRegular.TabIndex = 0;
            this.radioRegular.TabStop = true;
            this.radioRegular.Text = "regular";
            this.radioRegular.UseVisualStyleBackColor = true;
            this.radioRegular.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBold
            // 
            this.radioBold.AutoSize = true;
            this.radioBold.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBold.Location = new System.Drawing.Point(136, 34);
            this.radioBold.Name = "radioBold";
            this.radioBold.Size = new System.Drawing.Size(118, 39);
            this.radioBold.TabIndex = 1;
            this.radioBold.Text = "Bold";
            this.radioBold.UseVisualStyleBackColor = true;
            // 
            // radioItalic
            // 
            this.radioItalic.AutoSize = true;
            this.radioItalic.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioItalic.Location = new System.Drawing.Point(253, 34);
            this.radioItalic.Name = "radioItalic";
            this.radioItalic.Size = new System.Drawing.Size(114, 39);
            this.radioItalic.TabIndex = 2;
            this.radioItalic.Text = "italic";
            this.radioItalic.UseVisualStyleBackColor = true;
            // 
            // btnFontColour
            // 
            this.btnFontColour.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFontColour.Location = new System.Drawing.Point(15, 34);
            this.btnFontColour.Name = "btnFontColour";
            this.btnFontColour.Size = new System.Drawing.Size(243, 66);
            this.btnFontColour.TabIndex = 0;
            this.btnFontColour.Text = "Font Colour";
            this.btnFontColour.UseVisualStyleBackColor = true;
            this.btnFontColour.Click += new System.EventHandler(this.btnFontColour_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(24, 442);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(174, 52);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 52);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColour.Font = new System.Drawing.Font("Georgia", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColour.Location = new System.Drawing.Point(264, 34);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(78, 91);
            this.labelColour.TabIndex = 1;
            this.labelColour.Text = "  ";
            // 
            // FormText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 521);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxStickFigure);
            this.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Text For Drawing";
            this.Load += new System.EventHandler(this.FormText_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxStickFigure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown SpinFontSize;
        private System.Windows.Forms.ComboBox CmbFontFamily;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioItalic;
        private System.Windows.Forms.RadioButton radioBold;
        private System.Windows.Forms.RadioButton radioRegular;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.Button btnFontColour;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColorDialog colourDB;
    }
}