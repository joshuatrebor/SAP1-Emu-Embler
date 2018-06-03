using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3 {
    public partial class Form1 : Form {

        private String regPC, regMAR, regIR, regACC, regBR, regOR, disp, conSeq;
        int state;

        private void btnLoad_Click(object sender, EventArgs e) {
            load();
            btnPlay.Enabled = true;
            btnJog.Enabled = true;
        }

        private String []ram = new string[16];

        private void btnPlay_Click(object sender, EventArgs e) {
            state = 1;
            btnPlay.Enabled = false;
            btnJog.Enabled = false;
            btnLoad.Enabled = false;
            btnReset.Enabled = false;
            btnPausePlay.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            executeState(false);
            state++;
        }

        private void btnReset_Click(object sender, EventArgs e) {
            lblOut.Text = "";
            btnPlay.Enabled = true;
            btnJog.Enabled = true;
            btnReset.Enabled = false;
            btnPausePlay.Enabled = false;
            btnLoad.Enabled = true;
            regPC = "0000";
            regMAR = "N/A";
            regIR = "N/A";
            regACC = "N/A";
            regBR = "N/A";
            regOR = "N/A";
            disp = "N/A";
            conSeq = "N/A";
            pictureBox1.ImageLocation = "off.png";
            updateGUI();
            regIR = null;
            state = 1;
        }

        private void btnJog_Click(object sender, EventArgs e) {
            btnPlay.Enabled = false;
            btnPausePlay.Enabled = false;
            btnLoad.Enabled = false;
            btnReset.Enabled = true;
            executeState(true);
            state++;
        }

        private bool paused = false;

        private void btnPausePlay_Click(object sender, EventArgs e) {
            if (!paused) {
                paused = true;
                timer1.Stop();
            } else {
                paused = false;
                timer1.Start();
            }
        }

        private Label createLabel(int x, int y, String text) {
            Label label = new Label();
            label.AutoSize = true;
            label.BackColor = System.Drawing.Color.Transparent;
            label.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = System.Drawing.Color.Turquoise;
            label.Location = new System.Drawing.Point(555, 279);
            label.Name = "label4";
            label.Size = new System.Drawing.Size(x, y);
            label.TabIndex = 19;
            label.Text = text;
            return label;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            initRAM();
            lblInst2.BackColor = Color.Transparent;
            lblAddress2.BackColor = Color.Transparent;
        }

        private void initRAM() {
            lblAddress2.Text = "";
            lblInst2.Text = "";
            for(int i = 0; i < 16; i++) {
                lblAddress2.Text += Convert.ToString(i, 2).PadLeft(4, '0') + "\n";
                lblInst2.Text += "00000000\n";
                
            }
        }

        private void load() {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "SAP-1 Bin|*.bin";
            openDialog.Title = "Open SAP-1 Bin File";
            openDialog.ShowDialog();

            String[] lines = File.ReadAllLines(openDialog.FileName);

            foreach (String line in lines) {
                String strAddr = line.Substring(1, 4);
                String instr = line.Substring(5, 8);
                int address = Convert.ToInt32(strAddr, 2);
                ram[address] = instr;
            }
            lblInst2.Text = "";
            foreach (String inst in ram) {
                lblInst2.Text += inst + "\n";
            }
            lblPC.Text = "PC: 0000";
            regPC = "0000";
        }

        private void executeState(bool jog) {
            String inst = "";
            if (regIR != null)
                inst = regIR.Substring(0, 4);
            if (inst.Equals("1111")) {
                timer1.Stop();
                state = 1;
                btnReset.Enabled = true;
                btnJog.Enabled = false;
                btnPausePlay.Enabled = false;
                MessageBox.Show("Execution Successful");
                return;
            }

            if (state == 1) {
                lblState.Text = "T1: Address State\nInstruction of \nMAR will load to RAM";
                regMAR = regPC;
                pictureBox1.ImageLocation = "t1.png";
                conSeq = "110111100011";
            } else if (state == 2) {
                lblState.Text = "T2: Increment State\nThe program counter \nwill be incremented by 1";
                int ipc = Convert.ToInt32(regPC, 2);
                ipc++;
                regPC = Convert.ToString(ipc, 2).PadLeft(4, '0');
                pictureBox1.ImageLocation = "t2.png";
                conSeq = "111111100011";
            } else if (state == 3) {
                lblState.Text = "T3: Memory State\nThe Instruction of RAM \nwill be passed to the instruction register";
                int address = Convert.ToInt32(regMAR, 2);
                regIR = ram[address];
                pictureBox1.ImageLocation = "t3.png";

                if (inst.Equals("1111")) {
                    state = 0;
                }
                conSeq = "000000100011";
            } else if (state == 4) {
                if (inst.Equals("0000") || inst.Equals("0001") || inst.Equals("0010")) {
                    lblState.Text = "T4\nThe upper nibble will\nbe passed to MAR";
                    String address = regIR.Substring(4, 4);
                    regMAR = address;
                    pictureBox1.ImageLocation = "t4_load.png";
                    if (inst.Equals("0000")) {
                        conSeq = "000100010011";
                    } else if (inst.Equals("0001") || inst.Equals("0010")) {
                        conSeq = "000100100001";
                    }
                } else if (inst.Equals("1110")) {
                    lblState.Text = "T4\nThe Accumulator will pass\nit's content to output register";
                    regOR = regACC;
                    disp = regOR;
                    pictureBox1.ImageLocation = "t4_out.png";
                    conSeq = "001100010010";
                    lblOut.Text = regOR;
                }

                if (inst.Equals("1110") || inst.Equals("1111")) {
                    state = 0;
                }
            } else if (state == 5) {
                if (inst.Equals("0000")) {
                    lblState.Text = "T5\nThe data in RAM will be\n will be passed to accumulator";
                    lblState.Text = "T5";
                    int address = Convert.ToInt32(regMAR, 2);
                    regACC = ram[address];
                    conSeq = "000011010011";
                    pictureBox1.ImageLocation = "t5_load.png";
                } else if (inst.Equals("0001") || inst.Equals("0010")) {
                    lblState.Text = "T5\nThe data in RAM will be\npassed to the B-Register";
                    int address = Convert.ToInt32(regMAR, 2);
                    regBR = ram[address];
                    pictureBox1.ImageLocation = "t5_br.png";
                    conSeq = "000011100001";
                }

                if (inst.Equals("0000") || inst.Equals("1111") || inst.Equals("1110")) {
                    state = 0;
                }
            } else if (state == 6) {
                lblState.Text = "T6";
                lblState.Text = "T6\nThe operation will be executed";
                int iacc = Convert.ToInt32(regACC, 2);
                int ibr = Convert.ToInt32(regBR, 2);
                int result = 0;
                pictureBox1.ImageLocation = "t6.png";
                if (inst.Equals("0001")) {
                    result = iacc + ibr;
                    regACC = Convert.ToString(result, 2).PadLeft(8, '0');
                    conSeq = "001111011001";
                } else if (inst.Equals("0010")) {
                    result = iacc - ibr;
                    regACC = Convert.ToString(result, 2).PadLeft(8, '0');
                    conSeq = "001111011101";
                }

                state = 0;
            }
            updateGUI();
        }

        private void updateGUI() {
            lblPC.Text = "PC: " + regPC;
            lblMAR.Text = "MAR: " + regMAR;
            lblIR.Text = "IR: " + regIR;
            lblACC.Text = "ACC: " + regACC;
            lblBR.Text = "BR: " + regBR;
            lblOR.Text = "OR: " + regOR;
            lblDISP.Text = "DISP: " + disp;
            lblCS.Text = "C/S: " + conSeq;
        }

        private void label8_Click(object sender, EventArgs e) {

        }
    }
}
