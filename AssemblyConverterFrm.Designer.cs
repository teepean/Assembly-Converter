namespace Assembly_Converter
{
    partial class AssemblyConverterFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssemblyConverterFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Input = new System.Windows.Forms.TextBox();
            this.tb_Chain = new System.Windows.Forms.TextBox();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnChain = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lnkWeb = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chain File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Output File";
            // 
            // tb_Input
            // 
            this.tb_Input.Location = new System.Drawing.Point(113, 23);
            this.tb_Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Input.Name = "tb_Input";
            this.tb_Input.ReadOnly = true;
            this.tb_Input.Size = new System.Drawing.Size(339, 26);
            this.tb_Input.TabIndex = 1;
            // 
            // tb_Chain
            // 
            this.tb_Chain.Location = new System.Drawing.Point(114, 97);
            this.tb_Chain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Chain.Name = "tb_Chain";
            this.tb_Chain.ReadOnly = true;
            this.tb_Chain.Size = new System.Drawing.Size(339, 26);
            this.tb_Chain.TabIndex = 1;
            // 
            // tb_Output
            // 
            this.tb_Output.Location = new System.Drawing.Point(114, 171);
            this.tb_Output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.ReadOnly = true;
            this.tb_Output.Size = new System.Drawing.Size(339, 26);
            this.tb_Output.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(458, 17);
            this.btnInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(34, 36);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "..";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnChain
            // 
            this.btnChain.Location = new System.Drawing.Point(459, 91);
            this.btnChain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChain.Name = "btnChain";
            this.btnChain.Size = new System.Drawing.Size(34, 36);
            this.btnChain.TabIndex = 2;
            this.btnChain.Text = "..";
            this.btnChain.UseVisualStyleBackColor = true;
            this.btnChain.Click += new System.EventHandler(this.btnChain_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(459, 165);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(34, 36);
            this.btnOutput.TabIndex = 2;
            this.btnOutput.Text = "..";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(111, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select an autosomal DNA file.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(111, 127);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(280, 18);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Please select appropriate LiftOver chain file.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(111, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Enter the output file.";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(201, 238);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(121, 49);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lnkWeb
            // 
            this.lnkWeb.AutoSize = true;
            this.lnkWeb.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkWeb.LinkColor = System.Drawing.Color.Gray;
            this.lnkWeb.Location = new System.Drawing.Point(435, 278);
            this.lnkWeb.Name = "lnkWeb";
            this.lnkWeb.Size = new System.Drawing.Size(58, 18);
            this.lnkWeb.TabIndex = 6;
            this.lnkWeb.TabStop = true;
            this.lnkWeb.Text = "y-str.org";
            this.lnkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWeb_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(518, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(38, 17);
            this.statusLbl.Text = "Done.";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // AssemblyConverterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 338);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lnkWeb);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnChain);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.tb_Chain);
            this.Controls.Add(this.tb_Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssemblyConverterFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assembly Converter";
            this.Load += new System.EventHandler(this.AssemblyConverterFrm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Input;
        private System.Windows.Forms.TextBox tb_Chain;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnChain;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.LinkLabel lnkWeb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

