namespace WindowsFormsApplication3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDISP = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblBR = new System.Windows.Forms.Label();
            this.lblACC = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblMAR = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCS = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblState = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPausePlay = new System.Windows.Forms.Button();
            this.btnJog = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblInst = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInst2 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAPWET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(179, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Simple As Possible 1.0 Emulator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kozuka Gothic Pr6N R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(34, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "SAP-1 Architecture";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblDISP);
            this.groupBox1.Controls.Add(this.lblOR);
            this.groupBox1.Controls.Add(this.lblBR);
            this.groupBox1.Controls.Add(this.lblACC);
            this.groupBox1.Controls.Add(this.lblIR);
            this.groupBox1.Controls.Add(this.lblMAR);
            this.groupBox1.Controls.Add(this.lblPC);
            this.groupBox1.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(724, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
            // 
            // lblDISP
            // 
            this.lblDISP.AutoSize = true;
            this.lblDISP.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDISP.Location = new System.Drawing.Point(18, 164);
            this.lblDISP.Name = "lblDISP";
            this.lblDISP.Size = new System.Drawing.Size(76, 22);
            this.lblDISP.TabIndex = 6;
            this.lblDISP.Text = "DISP: N/A";
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblOR.Location = new System.Drawing.Point(18, 142);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(65, 22);
            this.lblOR.TabIndex = 5;
            this.lblOR.Text = "OR: N/A";
            // 
            // lblBR
            // 
            this.lblBR.AutoSize = true;
            this.lblBR.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBR.Location = new System.Drawing.Point(18, 120);
            this.lblBR.Name = "lblBR";
            this.lblBR.Size = new System.Drawing.Size(62, 22);
            this.lblBR.TabIndex = 4;
            this.lblBR.Text = "BR: N/A";
            this.lblBR.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblACC
            // 
            this.lblACC.AutoSize = true;
            this.lblACC.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblACC.Location = new System.Drawing.Point(18, 98);
            this.lblACC.Name = "lblACC";
            this.lblACC.Size = new System.Drawing.Size(74, 22);
            this.lblACC.TabIndex = 3;
            this.lblACC.Text = "ACC: N/A";
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblIR.Location = new System.Drawing.Point(18, 76);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(57, 22);
            this.lblIR.TabIndex = 2;
            this.lblIR.Text = "IR: N/A";
            // 
            // lblMAR
            // 
            this.lblMAR.AutoSize = true;
            this.lblMAR.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMAR.Location = new System.Drawing.Point(18, 54);
            this.lblMAR.Name = "lblMAR";
            this.lblMAR.Size = new System.Drawing.Size(77, 22);
            this.lblMAR.TabIndex = 1;
            this.lblMAR.Text = "MAR: N/A";
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPC.Location = new System.Drawing.Point(18, 32);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(63, 22);
            this.lblPC.TabIndex = 0;
            this.lblPC.Text = "PC: N/A";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblCS);
            this.groupBox2.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(724, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 59);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller/Sequencer";
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCS.Location = new System.Drawing.Point(22, 25);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(118, 22);
            this.lblCS.TabIndex = 0;
            this.lblCS.Text = "000000000000";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblState);
            this.groupBox3.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(724, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 167);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "State Description";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblState.Location = new System.Drawing.Point(15, 30);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(99, 22);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "No State Yet";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DimGray;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(725, 523);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(163, 30);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "LOAD MEM";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DimGray;
            this.btnPlay.Enabled = false;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(725, 559);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 30);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPausePlay
            // 
            this.btnPausePlay.BackColor = System.Drawing.Color.DimGray;
            this.btnPausePlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPausePlay.BackgroundImage")));
            this.btnPausePlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPausePlay.Enabled = false;
            this.btnPausePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausePlay.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausePlay.ForeColor = System.Drawing.Color.White;
            this.btnPausePlay.Location = new System.Drawing.Point(851, 559);
            this.btnPausePlay.Name = "btnPausePlay";
            this.btnPausePlay.Size = new System.Drawing.Size(37, 30);
            this.btnPausePlay.TabIndex = 11;
            this.btnPausePlay.UseVisualStyleBackColor = false;
            this.btnPausePlay.Click += new System.EventHandler(this.btnPausePlay_Click);
            // 
            // btnJog
            // 
            this.btnJog.BackColor = System.Drawing.Color.DimGray;
            this.btnJog.Enabled = false;
            this.btnJog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJog.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJog.ForeColor = System.Drawing.Color.White;
            this.btnJog.Location = new System.Drawing.Point(725, 595);
            this.btnJog.Name = "btnJog";
            this.btnJog.Size = new System.Drawing.Size(121, 30);
            this.btnJog.TabIndex = 12;
            this.btnJog.Text = "JOG";
            this.btnJog.UseVisualStyleBackColor = false;
            this.btnJog.Click += new System.EventHandler(this.btnJog_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DimGray;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(851, 595);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(37, 30);
            this.btnReset.TabIndex = 13;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(725, 631);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 30);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(393, 345);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 20);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "0000";
            // 
            // lblInst
            // 
            this.lblInst.AutoSize = true;
            this.lblInst.BackColor = System.Drawing.Color.Transparent;
            this.lblInst.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInst.ForeColor = System.Drawing.Color.White;
            this.lblInst.Location = new System.Drawing.Point(434, 345);
            this.lblInst.Name = "lblInst";
            this.lblInst.Size = new System.Drawing.Size(73, 20);
            this.lblInst.TabIndex = 15;
            this.lblInst.Text = "00000000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblInst2
            // 
            this.lblInst2.AutoSize = true;
            this.lblInst2.BackColor = System.Drawing.Color.Transparent;
            this.lblInst2.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInst2.ForeColor = System.Drawing.Color.White;
            this.lblInst2.Location = new System.Drawing.Point(123, 219);
            this.lblInst2.Name = "lblInst2";
            this.lblInst2.Size = new System.Drawing.Size(73, 20);
            this.lblInst2.TabIndex = 17;
            this.lblInst2.Text = "00000000";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress2.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.White;
            this.lblAddress2.Location = new System.Drawing.Point(76, 219);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(41, 20);
            this.lblAddress2.TabIndex = 18;
            this.lblAddress2.Text = "0000";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.ForeColor = System.Drawing.Color.White;
            this.lblOut.Location = new System.Drawing.Point(457, 611);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 46);
            this.lblOut.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(900, 710);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblInst2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblInst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnJog);
            this.Controls.Add(this.btnPausePlay);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAPWET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBR;
        private System.Windows.Forms.Label lblACC;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblMAR;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblDISP;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPausePlay;
        private System.Windows.Forms.Button btnJog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblInst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInst2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblOut;
    }
}

