namespace SALES
{
    partial class Sales
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInput = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.RichTextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.submit = new System.Windows.Forms.Button();
            this.inputInfo = new System.Windows.Forms.Button();
            this.outputInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.labelInput.Location = new System.Drawing.Point(15, 9);
            this.labelInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(63, 26);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input:";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.input.Location = new System.Drawing.Point(12, 38);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(760, 150);
            this.input.TabIndex = 1;
            this.input.Text = "";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.labelOutput.Location = new System.Drawing.Point(15, 200);
            this.labelOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(78, 26);
            this.labelOutput.TabIndex = 2;
            this.labelOutput.Text = "Output:";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.output.Location = new System.Drawing.Point(12, 229);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(760, 150);
            this.output.TabIndex = 3;
            this.output.Text = "";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.submit.Location = new System.Drawing.Point(12, 397);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(760, 52);
            this.submit.TabIndex = 4;
            this.submit.Text = "CALCULATE SALES TAXES";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // inputInfo
            // 
            this.inputInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.inputInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.inputInfo.Location = new System.Drawing.Point(747, 7);
            this.inputInfo.Name = "inputInfo";
            this.inputInfo.Size = new System.Drawing.Size(25, 25);
            this.inputInfo.TabIndex = 5;
            this.inputInfo.Text = "?";
            this.inputInfo.UseVisualStyleBackColor = false;
            this.inputInfo.Click += new System.EventHandler(this.inputInfo_Click);
            // 
            // outputInfo
            // 
            this.outputInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.outputInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outputInfo.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.outputInfo.Location = new System.Drawing.Point(747, 198);
            this.outputInfo.Name = "outputInfo";
            this.outputInfo.Size = new System.Drawing.Size(25, 25);
            this.outputInfo.TabIndex = 6;
            this.outputInfo.Text = "?";
            this.outputInfo.UseVisualStyleBackColor = false;
            this.outputInfo.Click += new System.EventHandler(this.outputInfo_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.outputInfo);
            this.Controls.Add(this.inputInfo);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.output);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.input);
            this.Controls.Add(this.labelInput);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Sales";
            this.Text = "Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button inputInfo;
        private System.Windows.Forms.Button outputInfo;
    }
}

