namespace Stck_Figure_Drawing_Program
{
    partial class StickFigureDrawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StickFigureDrawing));
            this.PbSurface = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStickWoman = new System.Windows.Forms.Button();
            this.btnArmsDown = new System.Windows.Forms.Button();
            this.btnArmsUp = new System.Windows.Forms.Button();
            this.btnArmsStraight = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelColour = new System.Windows.Forms.Label();
            this.btnCustom = new System.Windows.Forms.Button();
            this.bnGrey = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.cmbColours = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.radioSolid = new System.Windows.Forms.RadioButton();
            this.radioDashed = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbSurface)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbSurface
            // 
            this.PbSurface.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PbSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbSurface.Location = new System.Drawing.Point(112, 103);
            this.PbSurface.Name = "PbSurface";
            this.PbSurface.Size = new System.Drawing.Size(918, 664);
            this.PbSurface.TabIndex = 0;
            this.PbSurface.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStickWoman);
            this.groupBox1.Controls.Add(this.btnArmsDown);
            this.groupBox1.Controls.Add(this.btnArmsUp);
            this.groupBox1.Controls.Add(this.btnArmsStraight);
            this.groupBox1.Location = new System.Drawing.Point(1062, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 674);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stick Figures";
            // 
            // btnStickWoman
            // 
            this.btnStickWoman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStickWoman.BackgroundImage")));
            this.btnStickWoman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStickWoman.Location = new System.Drawing.Point(235, 236);
            this.btnStickWoman.Name = "btnStickWoman";
            this.btnStickWoman.Size = new System.Drawing.Size(111, 119);
            this.btnStickWoman.TabIndex = 3;
            this.btnStickWoman.UseVisualStyleBackColor = true;
            // 
            // btnArmsDown
            // 
            this.btnArmsDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArmsDown.BackgroundImage")));
            this.btnArmsDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArmsDown.Location = new System.Drawing.Point(70, 236);
            this.btnArmsDown.Name = "btnArmsDown";
            this.btnArmsDown.Size = new System.Drawing.Size(111, 119);
            this.btnArmsDown.TabIndex = 2;
            this.btnArmsDown.UseVisualStyleBackColor = true;
            // 
            // btnArmsUp
            // 
            this.btnArmsUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArmsUp.BackgroundImage")));
            this.btnArmsUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArmsUp.Location = new System.Drawing.Point(235, 64);
            this.btnArmsUp.Name = "btnArmsUp";
            this.btnArmsUp.Size = new System.Drawing.Size(111, 119);
            this.btnArmsUp.TabIndex = 1;
            this.btnArmsUp.UseVisualStyleBackColor = true;
            this.btnArmsUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnArmsStraight
            // 
            this.btnArmsStraight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArmsStraight.BackgroundImage")));
            this.btnArmsStraight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnArmsStraight.Location = new System.Drawing.Point(70, 64);
            this.btnArmsStraight.Name = "btnArmsStraight";
            this.btnArmsStraight.Size = new System.Drawing.Size(111, 119);
            this.btnArmsStraight.TabIndex = 0;
            this.btnArmsStraight.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelColour);
            this.groupBox2.Controls.Add(this.btnCustom);
            this.groupBox2.Controls.Add(this.bnGrey);
            this.groupBox2.Controls.Add(this.btnBlack);
            this.groupBox2.Controls.Add(this.btnYellow);
            this.groupBox2.Controls.Add(this.btnGreen);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnBlue);
            this.groupBox2.Controls.Add(this.cmbColours);
            this.groupBox2.Location = new System.Drawing.Point(112, 800);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 287);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colours";
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColour.Location = new System.Drawing.Point(321, 45);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(88, 77);
            this.labelColour.TabIndex = 8;
            this.labelColour.Text = "   ";
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(16, 124);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(299, 43);
            this.btnCustom.TabIndex = 7;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            // 
            // bnGrey
            // 
            this.bnGrey.BackColor = System.Drawing.Color.Gray;
            this.bnGrey.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.bnGrey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnGrey.Location = new System.Drawing.Point(270, 45);
            this.bnGrey.Name = "bnGrey";
            this.bnGrey.Size = new System.Drawing.Size(45, 45);
            this.bnGrey.TabIndex = 6;
            this.bnGrey.UseVisualStyleBackColor = false;
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(219, 45);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(45, 45);
            this.btnBlack.TabIndex = 5;
            this.btnBlack.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(168, 45);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(45, 45);
            this.btnYellow.TabIndex = 4;
            this.btnYellow.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Lime;
            this.btnGreen.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(117, 45);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(45, 45);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(66, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(15, 45);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(45, 45);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.UseVisualStyleBackColor = false;
            // 
            // cmbColours
            // 
            this.cmbColours.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColours.FormattingEnabled = true;
            this.cmbColours.Location = new System.Drawing.Point(15, 210);
            this.cmbColours.Name = "cmbColours";
            this.cmbColours.Size = new System.Drawing.Size(367, 49);
            this.cmbColours.TabIndex = 0;
            this.cmbColours.Text = "Colour Selector";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Location = new System.Drawing.Point(571, 800);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 145);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brush Size";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioDashed);
            this.groupBox4.Controls.Add(this.radioSolid);
            this.groupBox4.Location = new System.Drawing.Point(571, 982);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(459, 105);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Line Style";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRedo);
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.btnUndo);
            this.groupBox5.Location = new System.Drawing.Point(1062, 800);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 287);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions";
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(42, 34);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(332, 53);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(42, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(332, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(42, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(332, 53);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Surface";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.Location = new System.Drawing.Point(42, 93);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(332, 53);
            this.btnRedo.TabIndex = 3;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            // 
            // radioSolid
            // 
            this.radioSolid.AutoSize = true;
            this.radioSolid.Checked = true;
            this.radioSolid.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSolid.Location = new System.Drawing.Point(63, 49);
            this.radioSolid.Name = "radioSolid";
            this.radioSolid.Size = new System.Drawing.Size(107, 35);
            this.radioSolid.TabIndex = 0;
            this.radioSolid.TabStop = true;
            this.radioSolid.Text = "Solid";
            this.radioSolid.UseVisualStyleBackColor = true;
            // 
            // radioDashed
            // 
            this.radioDashed.AutoSize = true;
            this.radioDashed.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDashed.Location = new System.Drawing.Point(250, 49);
            this.radioDashed.Name = "radioDashed";
            this.radioDashed.Size = new System.Drawing.Size(136, 35);
            this.radioDashed.TabIndex = 1;
            this.radioDashed.Text = "Dashed";
            this.radioDashed.UseVisualStyleBackColor = true;
            this.radioDashed.CheckedChanged += new System.EventHandler(this.radioDashed_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(19, 34);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(434, 101);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "20";
            // 
            // StickFigureDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 1118);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PbSurface);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StickFigureDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stick Figure Drawing";
            ((System.ComponentModel.ISupportInitialize)(this.PbSurface)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbSurface;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbColours;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnStickWoman;
        private System.Windows.Forms.Button btnArmsDown;
        private System.Windows.Forms.Button btnArmsUp;
        private System.Windows.Forms.Button btnArmsStraight;
        private System.Windows.Forms.Button bnGrey;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.RadioButton radioDashed;
        private System.Windows.Forms.RadioButton radioSolid;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

