
namespace OPPM
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
            this.Number_Entry = new System.Windows.Forms.NumericUpDown();
            this.buttonPUSH = new System.Windows.Forms.Button();
            this.buttonPOP = new System.Windows.Forms.Button();
            this.buttonPEEK = new System.Windows.Forms.Button();
            this.buttonCLEAR = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBoxStack = new System.Windows.Forms.ListBox();
            this.textBoxStack = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Number_Entry)).BeginInit();
            this.SuspendLayout();
            // 
            // Number_Entry
            // 
            this.Number_Entry.Location = new System.Drawing.Point(83, 55);
            this.Number_Entry.Name = "Number_Entry";
            this.Number_Entry.Size = new System.Drawing.Size(120, 25);
            this.Number_Entry.TabIndex = 0;
            // 
            // buttonPUSH
            // 
            this.buttonPUSH.Location = new System.Drawing.Point(83, 122);
            this.buttonPUSH.Name = "buttonPUSH";
            this.buttonPUSH.Size = new System.Drawing.Size(75, 23);
            this.buttonPUSH.TabIndex = 2;
            this.buttonPUSH.Text = "PUSH";
            this.buttonPUSH.UseVisualStyleBackColor = true;
            this.buttonPUSH.Click += new System.EventHandler(this.buttonPUSH_Click);
            // 
            // buttonPOP
            // 
            this.buttonPOP.Location = new System.Drawing.Point(83, 167);
            this.buttonPOP.Name = "buttonPOP";
            this.buttonPOP.Size = new System.Drawing.Size(75, 23);
            this.buttonPOP.TabIndex = 3;
            this.buttonPOP.Text = "POP";
            this.buttonPOP.UseVisualStyleBackColor = true;
            this.buttonPOP.Click += new System.EventHandler(this.buttonPOP_Click);
            // 
            // buttonPEEK
            // 
            this.buttonPEEK.Location = new System.Drawing.Point(83, 214);
            this.buttonPEEK.Name = "buttonPEEK";
            this.buttonPEEK.Size = new System.Drawing.Size(75, 23);
            this.buttonPEEK.TabIndex = 4;
            this.buttonPEEK.Text = "PEEK";
            this.buttonPEEK.UseVisualStyleBackColor = true;
            // 
            // buttonCLEAR
            // 
            this.buttonCLEAR.Location = new System.Drawing.Point(83, 260);
            this.buttonCLEAR.Name = "buttonCLEAR";
            this.buttonCLEAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCLEAR.TabIndex = 5;
            this.buttonCLEAR.Text = "CLEAR";
            this.buttonCLEAR.UseVisualStyleBackColor = true;
            // 
            // listBoxStack
            // 
            this.listBoxStack.FormattingEnabled = true;
            this.listBoxStack.ItemHeight = 15;
            this.listBoxStack.Location = new System.Drawing.Point(523, 55);
            this.listBoxStack.Name = "listBoxStack";
            this.listBoxStack.Size = new System.Drawing.Size(194, 319);
            this.listBoxStack.TabIndex = 6;
            // 
            // textBoxStack
            // 
            this.textBoxStack.Location = new System.Drawing.Point(289, 55);
            this.textBoxStack.Multiline = true;
            this.textBoxStack.Name = "textBoxStack";
            this.textBoxStack.Size = new System.Drawing.Size(100, 271);
            this.textBoxStack.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxStack);
            this.Controls.Add(this.listBoxStack);
            this.Controls.Add(this.buttonCLEAR);
            this.Controls.Add(this.buttonPEEK);
            this.Controls.Add(this.buttonPOP);
            this.Controls.Add(this.buttonPUSH);
            this.Controls.Add(this.Number_Entry);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Number_Entry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Number_Entry;
        private System.Windows.Forms.Button buttonPUSH;
        private System.Windows.Forms.Button buttonPOP;
        private System.Windows.Forms.Button buttonPEEK;
        private System.Windows.Forms.Button buttonCLEAR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBoxStack;
        private System.Windows.Forms.TextBox textBoxStack;
    }
}

