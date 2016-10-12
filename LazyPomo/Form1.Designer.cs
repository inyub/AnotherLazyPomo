namespace LazyPomo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblPomoTotal = new System.Windows.Forms.Label();
            this.lblLazyTotal = new System.Windows.Forms.Label();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.lblPomoCount = new System.Windows.Forms.Label();
            this.lblCountDownDivider = new System.Windows.Forms.Label();
            this.lblCountdownSec = new System.Windows.Forms.Label();
            this.lblCountdownMin = new System.Windows.Forms.Label();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pnlEditTimebox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditLazy = new System.Windows.Forms.TextBox();
            this.txtEditPomo = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.tmMenuDown = new System.Windows.Forms.Timer(this.components);
            this.tmMenuUp = new System.Windows.Forms.Timer(this.components);
            this.tmPomo = new System.Windows.Forms.Timer(this.components);
            this.tmLazy = new System.Windows.Forms.Timer(this.components);
            this.tmLazyTotal = new System.Windows.Forms.Timer(this.components);
            this.tmPomoTotal = new System.Windows.Forms.Timer(this.components);
            this.rtxtSave = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbProgressbar = new LazyPomo.Code.CircularProgressbar();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlEditTimebox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.pnlTimer);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Controls.Add(this.pnlEditTimebox);
            this.pnlMain.Controls.Add(this.btnAbout);
            this.pnlMain.Controls.Add(this.btnOpen);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(200, 240);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Silver;
            this.pnlFooter.Controls.Add(this.lblPomoTotal);
            this.pnlFooter.Controls.Add(this.lblLazyTotal);
            this.pnlFooter.Location = new System.Drawing.Point(0, 220);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(200, 20);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblPomoTotal
            // 
            this.lblPomoTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomoTotal.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPomoTotal.Location = new System.Drawing.Point(130, 4);
            this.lblPomoTotal.Name = "lblPomoTotal";
            this.lblPomoTotal.Size = new System.Drawing.Size(70, 20);
            this.lblPomoTotal.TabIndex = 1;
            this.lblPomoTotal.Text = "Total Pomo";
            // 
            // lblLazyTotal
            // 
            this.lblLazyTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLazyTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLazyTotal.Location = new System.Drawing.Point(3, 4);
            this.lblLazyTotal.Name = "lblLazyTotal";
            this.lblLazyTotal.Size = new System.Drawing.Size(65, 20);
            this.lblLazyTotal.TabIndex = 0;
            this.lblLazyTotal.Text = "Total Lazy";
            // 
            // pnlTimer
            // 
            this.pnlTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTimer.Controls.Add(this.lblPomoCount);
            this.pnlTimer.Controls.Add(this.lblCountDownDivider);
            this.pnlTimer.Controls.Add(this.lblCountdownSec);
            this.pnlTimer.Controls.Add(this.lblCountdownMin);
            this.pnlTimer.Controls.Add(this.btnPin);
            this.pnlTimer.Controls.Add(this.btnSound);
            this.pnlTimer.Controls.Add(this.pbProgressbar);
            this.pnlTimer.Location = new System.Drawing.Point(0, 20);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(200, 200);
            this.pnlTimer.TabIndex = 1;
            // 
            // lblPomoCount
            // 
            this.lblPomoCount.Location = new System.Drawing.Point(43, 63);
            this.lblPomoCount.Name = "lblPomoCount";
            this.lblPomoCount.Size = new System.Drawing.Size(111, 23);
            this.lblPomoCount.TabIndex = 6;
            this.lblPomoCount.Text = "Pomo Session";
            this.lblPomoCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountDownDivider
            // 
            this.lblCountDownDivider.BackColor = System.Drawing.Color.Transparent;
            this.lblCountDownDivider.Font = new System.Drawing.Font("Myriad Pro Light", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDownDivider.Location = new System.Drawing.Point(89, 79);
            this.lblCountDownDivider.Name = "lblCountDownDivider";
            this.lblCountDownDivider.Size = new System.Drawing.Size(16, 36);
            this.lblCountDownDivider.TabIndex = 5;
            this.lblCountDownDivider.Text = ":";
            this.lblCountDownDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountdownSec
            // 
            this.lblCountdownSec.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdownSec.Font = new System.Drawing.Font("Myriad Pro Light", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdownSec.Location = new System.Drawing.Point(100, 79);
            this.lblCountdownSec.Name = "lblCountdownSec";
            this.lblCountdownSec.Size = new System.Drawing.Size(54, 36);
            this.lblCountdownSec.TabIndex = 4;
            this.lblCountdownSec.Text = "ss";
            this.lblCountdownSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountdownMin
            // 
            this.lblCountdownMin.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdownMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdownMin.Location = new System.Drawing.Point(46, 79);
            this.lblCountdownMin.Name = "lblCountdownMin";
            this.lblCountdownMin.Size = new System.Drawing.Size(50, 36);
            this.lblCountdownMin.TabIndex = 3;
            this.lblCountdownMin.Text = "05";
            this.lblCountdownMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPin
            // 
            this.btnPin.Location = new System.Drawing.Point(164, 7);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(31, 27);
            this.btnPin.TabIndex = 1;
            this.btnPin.Text = "Pin";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(6, 7);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(31, 27);
            this.btnSound.TabIndex = 0;
            this.btnSound.Text = "Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.Controls.Add(this.btnClose);
            this.pnlMenu.Controls.Add(this.btnEdit);
            this.pnlMenu.Controls.Add(this.btnMain);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 20);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseDown);
            this.pnlMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseMove);
            this.pnlMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMenu_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Location = new System.Drawing.Point(155, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.Location = new System.Drawing.Point(52, -2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 25);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnMain
            // 
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMain.Location = new System.Drawing.Point(0, -2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(50, 25);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // pnlEditTimebox
            // 
            this.pnlEditTimebox.BackColor = System.Drawing.Color.DarkGray;
            this.pnlEditTimebox.Controls.Add(this.label2);
            this.pnlEditTimebox.Controls.Add(this.label1);
            this.pnlEditTimebox.Controls.Add(this.txtEditLazy);
            this.pnlEditTimebox.Controls.Add(this.txtEditPomo);
            this.pnlEditTimebox.Location = new System.Drawing.Point(0, 20);
            this.pnlEditTimebox.Name = "pnlEditTimebox";
            this.pnlEditTimebox.Size = new System.Drawing.Size(200, 24);
            this.pnlEditTimebox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lazy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pomo";
            // 
            // txtEditLazy
            // 
            this.txtEditLazy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLazy.Location = new System.Drawing.Point(149, 0);
            this.txtEditLazy.Name = "txtEditLazy";
            this.txtEditLazy.Size = new System.Drawing.Size(28, 21);
            this.txtEditLazy.TabIndex = 1;
            this.txtEditLazy.Text = "5";
            // 
            // txtEditPomo
            // 
            this.txtEditPomo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPomo.Location = new System.Drawing.Point(51, 0);
            this.txtEditPomo.Name = "txtEditPomo";
            this.txtEditPomo.Size = new System.Drawing.Size(28, 21);
            this.txtEditPomo.TabIndex = 0;
            this.txtEditPomo.Text = "2";
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(147, 18);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(50, 27);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(74, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(50, 27);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStartPause
            // 
            this.btnStartPause.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStartPause.FlatAppearance.BorderSize = 0;
            this.btnStartPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPause.Location = new System.Drawing.Point(75, 209);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(50, 50);
            this.btnStartPause.TabIndex = 3;
            this.btnStartPause.Text = "NoText";
            this.btnStartPause.UseVisualStyleBackColor = false;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // tmMenuDown
            // 
            this.tmMenuDown.Interval = 10;
            this.tmMenuDown.Tick += new System.EventHandler(this.tmControl_Tick);
            // 
            // tmMenuUp
            // 
            this.tmMenuUp.Interval = 10;
            this.tmMenuUp.Tick += new System.EventHandler(this.tmMenuUp_Tick);
            // 
            // tmPomo
            // 
            this.tmPomo.Tick += new System.EventHandler(this.tmPomo_Tick);
            // 
            // tmLazy
            // 
            this.tmLazy.Interval = 1000;
            this.tmLazy.Tick += new System.EventHandler(this.tmLazy_Tick);
            // 
            // tmLazyTotal
            // 
            this.tmLazyTotal.Enabled = true;
            this.tmLazyTotal.Tick += new System.EventHandler(this.tmLazyTotal_Tick);
            // 
            // tmPomoTotal
            // 
            this.tmPomoTotal.Interval = 1000;
            this.tmPomoTotal.Tick += new System.EventHandler(this.tmPomoTotal_Tick);
            // 
            // rtxtSave
            // 
            this.rtxtSave.Location = new System.Drawing.Point(3, 262);
            this.rtxtSave.Name = "rtxtSave";
            this.rtxtSave.Size = new System.Drawing.Size(194, 23);
            this.rtxtSave.TabIndex = 4;
            this.rtxtSave.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbProgressbar
            // 
            this.pbProgressbar.Location = new System.Drawing.Point(0, 0);
            this.pbProgressbar.Margin = new System.Windows.Forms.Padding(30);
            this.pbProgressbar.Name = "pbProgressbar";
            this.pbProgressbar.Size = new System.Drawing.Size(195, 195);
            this.pbProgressbar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(414, 290);
            this.Controls.Add(this.rtxtSave);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlTimer.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlEditTimebox.ResumeLayout(false);
            this.pnlEditTimebox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnStartPause;
        private System.Windows.Forms.Label lblPomoTotal;
        private System.Windows.Forms.Label lblLazyTotal;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer tmMenuDown;
        private System.Windows.Forms.Timer tmMenuUp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Timer tmPomo;
        private Code.CircularProgressbar pbProgressbar;
        private System.Windows.Forms.Timer tmLazy;
        private System.Windows.Forms.Timer tmLazyTotal;
        private System.Windows.Forms.Label lblCountdownMin;
        private System.Windows.Forms.Timer tmPomoTotal;
        private System.Windows.Forms.Label lblCountdownSec;
        private System.Windows.Forms.Label lblCountDownDivider;
        private System.Windows.Forms.Panel pnlEditTimebox;
        private System.Windows.Forms.TextBox txtEditLazy;
        private System.Windows.Forms.TextBox txtEditPomo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPomoCount;
        private System.Windows.Forms.RichTextBox rtxtSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

