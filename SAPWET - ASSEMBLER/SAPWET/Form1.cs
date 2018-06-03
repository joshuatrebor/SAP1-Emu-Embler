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

namespace SAPWET{
    public partial class assembler : Form{
        public assembler(){
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e){
            TabPage tabPage = createTabPage();
            assemblerTab.SelectedTab = tabPage;
        }

        private TabPage createTabPage() {
            TabPage tabPage = new TabPage("untitled (" + (assemblerTab.TabCount) + ")");
            RichTextBox textBox = new RichTextBox();
            textBox.SetBounds(6, 6, 368, 325);
            textBox.BackColor = Color.Linen;
            textBox.BorderStyle = BorderStyle.None;
            tabPage.BackColor = Color.DarkSalmon;
            assemblerTab.TabPages.Add(tabPage);
            tabPage.Controls.Add(textBox);
            return tabPage;
        }

        private String toBinary(String[] memory) {
            String machineCode = "";
            for (int i = 0; i < memory.Length; i++) {
                int inst = Convert.ToInt32(memory[i], 16);
                machineCode += Int32.Parse(Convert.ToString(i, 2)).ToString("0000") + " " +
                    Int32.Parse(Convert.ToString(inst, 2)).ToString("00000000") + "\n";
                Console.WriteLine("A" + inst + memory[i]);
            }
            return machineCode;

        }

        private String[] parseCode(String code){

            Dictionary<String, String> codeBlocks = scanCodeBlocks(code);   //Mapping of codeblock to its name
            List<String> lines = new List<String>();
            lines.AddRange(code.Split('\n'));   //split the code into lines of codes
            String[] memory = new String[16];   //Create a memory with a capacity of 16
            //initialize the memory to all 00
            for (int i = 0; i < 16; i++)
                memory[i] = "00";
            //iterate each line
            foreach (String line in lines){
                //if line has the ORD command then...
                if (line.Contains("ORG")){
                    String[] comVal = line.Split(',');  //split each line into command and value
                    String strAddress = comVal[0].Split(' ')[1].Trim(); //address is the 2nd half of the command
                    strAddress = strAddress.Remove(strAddress.Length - 1, 1);   //remove H
                    int address = Convert.ToInt32(strAddress, 16);  //convert to int
                    //if value is an address (not codeblock reference)
                    if (comVal[1].ElementAt(comVal[1].Length-1) == 'H'){ 
                        String value = comVal[1].Trim();    //cleanup
                        value = value.Remove(value.Length - 1); //remove H
                        memory[address] = value;    //add to memory at index address
                    }
                    //if value is a codeblock reference
                    else{
                        String codeBlock;
                        //retrieve codeblock with its name(comVal[1]) from codeblocks
                        if(codeBlocks.TryGetValue(comVal[1].Trim(), out codeBlock)){
                            List<String> bLines = new List<String>();
                            bLines.AddRange(codeBlock.Split('\n')); //split the codeblock into lines of codes
                            //iterate each line
                            foreach (String bLine in bLines){
                                if (bLine.Trim().Equals("")) continue;  //skip garbage
                                String[] codeAdd = bLine.Split(' ');    //split line into opcode and address
                                String inst = toOpCode(codeAdd[0].Trim()) + //instruction = opcode + address in hexa
                                    (codeAdd.Length >= 2 ? codeAdd[1].ElementAt(1) : '0');  //remove H on address
                                memory[address++] = inst;   //add to memory on index address then increment address
                            }
                        }
                        else
                            Console.WriteLine("Error: Undefined Codeblock");
                    }
                    
                }
            }
            return memory;

        }

        private String toOpCode(String mnemonic){
            if (mnemonic.Equals("LDA"))
                return "0";
            else if (mnemonic.Equals("ADD"))
                return "1";
            else if (mnemonic.Equals("SUB"))
                return "2";
            else if (mnemonic.Equals("OUT"))
                return "E";
            else if (mnemonic.Equals("HLT"))
                return "F";
            else
                return "ER";
        }

        private Dictionary<String,String> scanCodeBlocks(String code){
            Dictionary<String, String> codeBlocks = new Dictionary<String, String>();
            List<String> lines = new List<String>();
            lines.AddRange(code.Split('\n'));
            String key = null;
            foreach (String line in lines){
                if (line.Contains(":")){
                    key = line.Remove(line.Length - 1, 1);
                    codeBlocks.Add(key, "");
                    //Console.WriteLine(key);
                }
                else if (line.Trim().Equals("")) { }
                else if (line.Contains("ORG")){
                    key = null;
                }
                else if (key != null){
                    String codeBlock;
                    codeBlocks.TryGetValue(key, out codeBlock);
                    codeBlock += line;
                    codeBlocks.Remove(key);
                    codeBlocks.Add(key, codeBlock+"\n");
                    //Console.WriteLine(line);
                }
            }
            String cb;
            codeBlocks.TryGetValue("MAIN", out cb);
            //Console.Write(cb);
            return codeBlocks;
        }

        private void assembleToolStripMenuItem_Click(object sender, EventArgs e){
            assemble();
        }

        private void assemble() {
            String[] memory = parseCode(assemblerTab.SelectedTab.Controls[0].Text);
            String machineCode = toBinary(memory);
            Console.WriteLine(machineCode);
            File.WriteAllText(assemblerTab.SelectedTab.Text.Split('.')[0] 
                + ".bin", machineCode);
            MessageBox.Show("Assembly Success!");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "SAP-1 File|*.sap";
            saveDialog.Title = "Save SAP-1 File";
            TabPage tab = assemblerTab.SelectedTab;
            saveDialog.FileName = tab.Text;
            saveDialog.ShowDialog();
            File.WriteAllText(saveDialog.FileName, assemblerTab.SelectedTab.Controls[0].Text);
            String []fileNames = saveDialog.FileName.Split('\\');
            tab.Text = fileNames[fileNames.Length - 1];
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "SAP-1 File|*.sap";
            openDialog.Title = "Open SAP-1 File";
            openDialog.ShowDialog();
            TabPage tab = createTabPage();
            tab.Controls[0].Text = File.ReadAllText(openDialog.FileName);
            tab.Text = openDialog.SafeFileName;
            assemblerTab.SelectedTab = tab;
        }

        private void btnAssemble_Click(object sender, EventArgs e) {
            assemble();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            assemblerTab.TabPages.Remove(assemblerTab.SelectedTab);
        }

        private void aboutSAP1ToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 box = new AboutBox1();
            box.Show();        

        }

        private void glossaryToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2 form = new Form2();
            form.Show();
        }
    }
}