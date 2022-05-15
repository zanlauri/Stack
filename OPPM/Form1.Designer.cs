
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
            this.buttonPUSH = new System.Windows.Forms.Button();
            this.buttonPOP = new System.Windows.Forms.Button();
            this.buttonPEEK = new System.Windows.Forms.Button();
            this.buttonCLEAR = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxStack = new System.Windows.Forms.TextBox();
            this.buttonStackBegin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxPush = new System.Windows.Forms.TextBox();
            this.labelPop = new System.Windows.Forms.Label();
            this.labelPeek = new System.Windows.Forms.Label();
            this.labelStartUpChoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.buttonPEEK.Click += new System.EventHandler(this.buttonPEEK_Click);
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
            // textBoxStack
            // 
            this.textBoxStack.Location = new System.Drawing.Point(289, 55);
            this.textBoxStack.Multiline = true;
            this.textBoxStack.Name = "textBoxStack";
            this.textBoxStack.Size = new System.Drawing.Size(100, 271);
            this.textBoxStack.TabIndex = 7;
            // 
            // buttonStackBegin
            // 
            this.buttonStackBegin.Location = new System.Drawing.Point(12, 12);
            this.buttonStackBegin.Name = "buttonStackBegin";
            this.buttonStackBegin.Size = new System.Drawing.Size(75, 23);
            this.buttonStackBegin.TabIndex = 8;
            this.buttonStackBegin.Text = "Begin Stack";
            this.buttonStackBegin.UseVisualStyleBackColor = true;
            this.buttonStackBegin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 25);
            this.textBox1.TabIndex = 9;
            // 
            // textBoxPush
            // 
            this.textBoxPush.Location = new System.Drawing.Point(165, 119);
            this.textBoxPush.Name = "textBoxPush";
            this.textBoxPush.Size = new System.Drawing.Size(100, 25);
            this.textBoxPush.TabIndex = 11;
            // 
            // labelPop
            // 
            this.labelPop.AutoSize = true;
            this.labelPop.Location = new System.Drawing.Point(176, 171);
            this.labelPop.Name = "labelPop";
            this.labelPop.Size = new System.Drawing.Size(0, 15);
            this.labelPop.TabIndex = 12;
            // 
            // labelPeek
            // 
            this.labelPeek.AutoSize = true;
            this.labelPeek.Location = new System.Drawing.Point(165, 221);
            this.labelPeek.Name = "labelPeek";
            this.labelPeek.Size = new System.Drawing.Size(0, 15);
            this.labelPeek.TabIndex = 13;
            // 
            // labelStartUpChoose
            // 
            this.labelStartUpChoose.AutoSize = true;
            this.labelStartUpChoose.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStartUpChoose.Location = new System.Drawing.Point(110, 74);
            this.labelStartUpChoose.Name = "labelStartUpChoose";
            this.labelStartUpChoose.Size = new System.Drawing.Size(553, 30);
            this.labelStartUpChoose.TabIndex = 14;
            this.labelStartUpChoose.Text = "Choose How Many Entried in the Stack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStartUpChoose);
            this.Controls.Add(this.labelPeek);
            this.Controls.Add(this.labelPop);
            this.Controls.Add(this.textBoxPush);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStackBegin);
            this.Controls.Add(this.textBoxStack);
            this.Controls.Add(this.buttonCLEAR);
            this.Controls.Add(this.buttonPEEK);
            this.Controls.Add(this.buttonPOP);
            this.Controls.Add(this.buttonPUSH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPUSH;
        private System.Windows.Forms.Button buttonPOP;
        private System.Windows.Forms.Button buttonPEEK;
        private System.Windows.Forms.Button buttonCLEAR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxStack;
        private System.Windows.Forms.Button buttonStackBegin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxPush;
        private System.Windows.Forms.Label labelPop;
        private System.Windows.Forms.Label labelPeek;
        private System.Windows.Forms.Label labelStartUpChoose;
    }
}

