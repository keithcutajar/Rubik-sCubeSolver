namespace CubeSolvingAssignment
{
    partial class MiniCubeSolver
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
            this.grpBoxInput = new System.Windows.Forms.GroupBox();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.cmbSide = new System.Windows.Forms.ComboBox();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.grpBoxProcess = new System.Windows.Forms.GroupBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.grpBoxSolution = new System.Windows.Forms.GroupBox();
            this.btnRotateSolve = new System.Windows.Forms.Button();
            this.listBoxSolution = new System.Windows.Forms.ListBox();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.pnl9 = new System.Windows.Forms.Panel();
            this.pnl11 = new System.Windows.Forms.Panel();
            this.pnl10 = new System.Windows.Forms.Panel();
            this.pnl0 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl16 = new System.Windows.Forms.Panel();
            this.pnl17 = new System.Windows.Forms.Panel();
            this.pnl20 = new System.Windows.Forms.Panel();
            this.pnl19 = new System.Windows.Forms.Panel();
            this.pnl12 = new System.Windows.Forms.Panel();
            this.pnl21 = new System.Windows.Forms.Panel();
            this.pnl18 = new System.Windows.Forms.Panel();
            this.pnl13 = new System.Windows.Forms.Panel();
            this.pnl23 = new System.Windows.Forms.Panel();
            this.pnl22 = new System.Windows.Forms.Panel();
            this.pnl15 = new System.Windows.Forms.Panel();
            this.pnl14 = new System.Windows.Forms.Panel();
            this.grpBoxCube = new System.Windows.Forms.GroupBox();
            this.cmbApproach = new System.Windows.Forms.ComboBox();
            this.grpBoxInput.SuspendLayout();
            this.grpBoxProcess.SuspendLayout();
            this.grpBoxSolution.SuspendLayout();
            this.grpBoxCube.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxInput
            // 
            this.grpBoxInput.Controls.Add(this.cmbApproach);
            this.grpBoxInput.Controls.Add(this.cmbDirection);
            this.grpBoxInput.Controls.Add(this.cmbSide);
            this.grpBoxInput.Controls.Add(this.btnRotate);
            this.grpBoxInput.Controls.Add(this.btnRestart);
            this.grpBoxInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxInput.Location = new System.Drawing.Point(0, 207);
            this.grpBoxInput.Name = "grpBoxInput";
            this.grpBoxInput.Size = new System.Drawing.Size(285, 158);
            this.grpBoxInput.TabIndex = 0;
            this.grpBoxInput.TabStop = false;
            this.grpBoxInput.Text = "Input";
            // 
            // cmbDirection
            // 
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Location = new System.Drawing.Point(7, 71);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(106, 21);
            this.cmbDirection.TabIndex = 1;
            // 
            // cmbSide
            // 
            this.cmbSide.FormattingEnabled = true;
            this.cmbSide.Location = new System.Drawing.Point(7, 20);
            this.cmbSide.Name = "cmbSide";
            this.cmbSide.Size = new System.Drawing.Size(106, 21);
            this.cmbSide.TabIndex = 1;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(119, 71);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 0;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(119, 19);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // grpBoxProcess
            // 
            this.grpBoxProcess.Controls.Add(this.btnSolve);
            this.grpBoxProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBoxProcess.Location = new System.Drawing.Point(0, 365);
            this.grpBoxProcess.Name = "grpBoxProcess";
            this.grpBoxProcess.Size = new System.Drawing.Size(285, 53);
            this.grpBoxProcess.TabIndex = 1;
            this.grpBoxProcess.TabStop = false;
            this.grpBoxProcess.Text = "Process";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(29, 19);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(144, 23);
            this.btnSolve.TabIndex = 0;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // grpBoxSolution
            // 
            this.grpBoxSolution.Controls.Add(this.btnRotateSolve);
            this.grpBoxSolution.Controls.Add(this.listBoxSolution);
            this.grpBoxSolution.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpBoxSolution.Location = new System.Drawing.Point(285, 0);
            this.grpBoxSolution.Name = "grpBoxSolution";
            this.grpBoxSolution.Size = new System.Drawing.Size(217, 418);
            this.grpBoxSolution.TabIndex = 2;
            this.grpBoxSolution.TabStop = false;
            this.grpBoxSolution.Text = "Solution";
            // 
            // btnRotateSolve
            // 
            this.btnRotateSolve.Location = new System.Drawing.Point(6, 310);
            this.btnRotateSolve.Name = "btnRotateSolve";
            this.btnRotateSolve.Size = new System.Drawing.Size(205, 23);
            this.btnRotateSolve.TabIndex = 0;
            this.btnRotateSolve.Text = "Rotate";
            this.btnRotateSolve.UseVisualStyleBackColor = true;
            this.btnRotateSolve.Click += new System.EventHandler(this.btnRotateSolve_Click);
            // 
            // listBoxSolution
            // 
            this.listBoxSolution.FormattingEnabled = true;
            this.listBoxSolution.Location = new System.Drawing.Point(6, 19);
            this.listBoxSolution.Name = "listBoxSolution";
            this.listBoxSolution.Size = new System.Drawing.Size(205, 277);
            this.listBoxSolution.TabIndex = 0;
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.SystemColors.Window;
            this.pnl4.Location = new System.Drawing.Point(63, 18);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(15, 15);
            this.pnl4.TabIndex = 3;
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.SystemColors.Window;
            this.pnl5.Location = new System.Drawing.Point(84, 18);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(15, 15);
            this.pnl5.TabIndex = 3;
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.SystemColors.Window;
            this.pnl7.Location = new System.Drawing.Point(84, 39);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(15, 15);
            this.pnl7.TabIndex = 3;
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.SystemColors.Window;
            this.pnl6.Location = new System.Drawing.Point(63, 39);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(15, 15);
            this.pnl6.TabIndex = 3;
            // 
            // pnl8
            // 
            this.pnl8.BackColor = System.Drawing.Color.Red;
            this.pnl8.Location = new System.Drawing.Point(63, 70);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(15, 15);
            this.pnl8.TabIndex = 3;
            // 
            // pnl9
            // 
            this.pnl9.BackColor = System.Drawing.Color.Red;
            this.pnl9.Location = new System.Drawing.Point(84, 70);
            this.pnl9.Name = "pnl9";
            this.pnl9.Size = new System.Drawing.Size(15, 15);
            this.pnl9.TabIndex = 3;
            // 
            // pnl11
            // 
            this.pnl11.BackColor = System.Drawing.Color.Red;
            this.pnl11.Location = new System.Drawing.Point(84, 91);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(15, 15);
            this.pnl11.TabIndex = 3;
            // 
            // pnl10
            // 
            this.pnl10.BackColor = System.Drawing.Color.Red;
            this.pnl10.Location = new System.Drawing.Point(63, 91);
            this.pnl10.Name = "pnl10";
            this.pnl10.Size = new System.Drawing.Size(15, 15);
            this.pnl10.TabIndex = 3;
            // 
            // pnl0
            // 
            this.pnl0.BackColor = System.Drawing.Color.Green;
            this.pnl0.Location = new System.Drawing.Point(13, 70);
            this.pnl0.Name = "pnl0";
            this.pnl0.Size = new System.Drawing.Size(15, 15);
            this.pnl0.TabIndex = 3;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Green;
            this.pnl1.Location = new System.Drawing.Point(34, 70);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(15, 15);
            this.pnl1.TabIndex = 3;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Green;
            this.pnl3.Location = new System.Drawing.Point(34, 91);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(15, 15);
            this.pnl3.TabIndex = 3;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Green;
            this.pnl2.Location = new System.Drawing.Point(13, 91);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(15, 15);
            this.pnl2.TabIndex = 3;
            // 
            // pnl16
            // 
            this.pnl16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl16.Location = new System.Drawing.Point(117, 70);
            this.pnl16.Name = "pnl16";
            this.pnl16.Size = new System.Drawing.Size(15, 15);
            this.pnl16.TabIndex = 3;
            // 
            // pnl17
            // 
            this.pnl17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl17.Location = new System.Drawing.Point(138, 70);
            this.pnl17.Name = "pnl17";
            this.pnl17.Size = new System.Drawing.Size(15, 15);
            this.pnl17.TabIndex = 3;
            // 
            // pnl20
            // 
            this.pnl20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnl20.Location = new System.Drawing.Point(173, 70);
            this.pnl20.Name = "pnl20";
            this.pnl20.Size = new System.Drawing.Size(15, 15);
            this.pnl20.TabIndex = 3;
            // 
            // pnl19
            // 
            this.pnl19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl19.Location = new System.Drawing.Point(138, 91);
            this.pnl19.Name = "pnl19";
            this.pnl19.Size = new System.Drawing.Size(15, 15);
            this.pnl19.TabIndex = 3;
            // 
            // pnl12
            // 
            this.pnl12.BackColor = System.Drawing.Color.Yellow;
            this.pnl12.Location = new System.Drawing.Point(63, 123);
            this.pnl12.Name = "pnl12";
            this.pnl12.Size = new System.Drawing.Size(15, 15);
            this.pnl12.TabIndex = 3;
            // 
            // pnl21
            // 
            this.pnl21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnl21.Location = new System.Drawing.Point(194, 70);
            this.pnl21.Name = "pnl21";
            this.pnl21.Size = new System.Drawing.Size(15, 15);
            this.pnl21.TabIndex = 3;
            // 
            // pnl18
            // 
            this.pnl18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl18.Location = new System.Drawing.Point(117, 91);
            this.pnl18.Name = "pnl18";
            this.pnl18.Size = new System.Drawing.Size(15, 15);
            this.pnl18.TabIndex = 3;
            // 
            // pnl13
            // 
            this.pnl13.BackColor = System.Drawing.Color.Yellow;
            this.pnl13.Location = new System.Drawing.Point(84, 123);
            this.pnl13.Name = "pnl13";
            this.pnl13.Size = new System.Drawing.Size(15, 15);
            this.pnl13.TabIndex = 3;
            // 
            // pnl23
            // 
            this.pnl23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnl23.Location = new System.Drawing.Point(194, 91);
            this.pnl23.Name = "pnl23";
            this.pnl23.Size = new System.Drawing.Size(15, 15);
            this.pnl23.TabIndex = 3;
            // 
            // pnl22
            // 
            this.pnl22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnl22.Location = new System.Drawing.Point(173, 91);
            this.pnl22.Name = "pnl22";
            this.pnl22.Size = new System.Drawing.Size(15, 15);
            this.pnl22.TabIndex = 3;
            // 
            // pnl15
            // 
            this.pnl15.BackColor = System.Drawing.Color.Yellow;
            this.pnl15.Location = new System.Drawing.Point(84, 144);
            this.pnl15.Name = "pnl15";
            this.pnl15.Size = new System.Drawing.Size(15, 15);
            this.pnl15.TabIndex = 3;
            // 
            // pnl14
            // 
            this.pnl14.BackColor = System.Drawing.Color.Yellow;
            this.pnl14.Location = new System.Drawing.Point(63, 144);
            this.pnl14.Name = "pnl14";
            this.pnl14.Size = new System.Drawing.Size(15, 15);
            this.pnl14.TabIndex = 3;
            // 
            // grpBoxCube
            // 
            this.grpBoxCube.Controls.Add(this.pnl0);
            this.grpBoxCube.Controls.Add(this.pnl1);
            this.grpBoxCube.Controls.Add(this.pnl2);
            this.grpBoxCube.Controls.Add(this.pnl3);
            this.grpBoxCube.Controls.Add(this.pnl4);
            this.grpBoxCube.Controls.Add(this.pnl5);
            this.grpBoxCube.Controls.Add(this.pnl6);
            this.grpBoxCube.Controls.Add(this.pnl7);
            this.grpBoxCube.Controls.Add(this.pnl8);
            this.grpBoxCube.Controls.Add(this.pnl9);
            this.grpBoxCube.Controls.Add(this.pnl10);
            this.grpBoxCube.Controls.Add(this.pnl11);
            this.grpBoxCube.Controls.Add(this.pnl12);
            this.grpBoxCube.Controls.Add(this.pnl13);
            this.grpBoxCube.Controls.Add(this.pnl14);
            this.grpBoxCube.Controls.Add(this.pnl15);
            this.grpBoxCube.Controls.Add(this.pnl16);
            this.grpBoxCube.Controls.Add(this.pnl17);
            this.grpBoxCube.Controls.Add(this.pnl18);
            this.grpBoxCube.Controls.Add(this.pnl19);
            this.grpBoxCube.Controls.Add(this.pnl20);
            this.grpBoxCube.Controls.Add(this.pnl21);
            this.grpBoxCube.Controls.Add(this.pnl22);
            this.grpBoxCube.Controls.Add(this.pnl23);
            this.grpBoxCube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxCube.Location = new System.Drawing.Point(0, 0);
            this.grpBoxCube.Name = "grpBoxCube";
            this.grpBoxCube.Size = new System.Drawing.Size(285, 365);
            this.grpBoxCube.TabIndex = 4;
            this.grpBoxCube.TabStop = false;
            this.grpBoxCube.Text = "Cube";
            // 
            // cmbApproach
            // 
            this.cmbApproach.FormattingEnabled = true;
            this.cmbApproach.Location = new System.Drawing.Point(7, 114);
            this.cmbApproach.Name = "cmbApproach";
            this.cmbApproach.Size = new System.Drawing.Size(106, 21);
            this.cmbApproach.TabIndex = 2;
            // 
            // MiniCubeSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 418);
            this.Controls.Add(this.grpBoxInput);
            this.Controls.Add(this.grpBoxCube);
            this.Controls.Add(this.grpBoxProcess);
            this.Controls.Add(this.grpBoxSolution);
            this.Name = "MiniCubeSolver";
            this.Text = "MiniCube Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MiniCubeSolver_SizeChanged);
            this.grpBoxInput.ResumeLayout(false);
            this.grpBoxProcess.ResumeLayout(false);
            this.grpBoxSolution.ResumeLayout(false);
            this.grpBoxCube.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxInput;
        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.ComboBox cmbSide;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.GroupBox grpBoxProcess;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.GroupBox grpBoxSolution;
        private System.Windows.Forms.Button btnRotateSolve;
        private System.Windows.Forms.ListBox listBoxSolution;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Panel pnl9;
        private System.Windows.Forms.Panel pnl11;
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Panel pnl0;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl16;
        private System.Windows.Forms.Panel pnl17;
        private System.Windows.Forms.Panel pnl20;
        private System.Windows.Forms.Panel pnl19;
        private System.Windows.Forms.Panel pnl12;
        private System.Windows.Forms.Panel pnl21;
        private System.Windows.Forms.Panel pnl18;
        private System.Windows.Forms.Panel pnl13;
        private System.Windows.Forms.Panel pnl23;
        private System.Windows.Forms.Panel pnl22;
        private System.Windows.Forms.Panel pnl15;
        private System.Windows.Forms.Panel pnl14;
        private System.Windows.Forms.GroupBox grpBoxCube;
        private System.Windows.Forms.ComboBox cmbApproach;
    }
}

