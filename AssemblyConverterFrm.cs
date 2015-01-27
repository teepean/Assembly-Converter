using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assembly_Converter
{
    public partial class AssemblyConverterFrm : Form
    {
        string input_file = null;
        string chain_file = null;
        string output_file = null;

        public AssemblyConverterFrm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://hgdownload.cse.ucsc.edu/downloads.html#liftover");
        }

        private void AssemblyConverterFrm_Load(object sender, EventArgs e)
        {

        }

        private void lnkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.y-str.org/");
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files|*.*";
            dlg.Multiselect = false;
            dlg.CheckFileExists = true;
            if(dlg.ShowDialog(this)==DialogResult.OK)
            {
                input_file = dlg.FileName;
                tb_Input.Text = input_file;
            }
        }

        private void btnChain_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "LiftOver Chain Files|*.over.chain.gz";
            dlg.Multiselect = false;
            dlg.CheckFileExists = true;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                chain_file = dlg.FileName;
                tb_Chain.Text = chain_file;
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "23andMe File Format|*.txt";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                output_file = dlg.FileName;
                tb_Output.Text = output_file;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(input_file==null)
            {
                MessageBox.Show("Please select an input file.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (chain_file == null)
            {
                MessageBox.Show("Please select the appropriate chain file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (output_file == null)
            {
                MessageBox.Show("Please enter an output file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnConvert.Enabled = false;
            statusStrip1.Visible = true;
            statusLbl.Text = "Processing ...";
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
           AssemblyUtil.convertAssembly(input_file, chain_file, output_file);
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusLbl.Text = "Done.";
            btnConvert.Enabled = true;
            statusStrip1.Visible = false;
            MessageBox.Show("Assembly/Build Successfully Converted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
