namespace ProgrammingLanguageEnvironmentforASE
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.OutputWindow = new System.Windows.Forms.PictureBox();
            this.ProgramCommandWindow = new System.Windows.Forms.RichTextBox();
            this.commandline = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(472, 874);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(168, 70);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // OutputWindow
            // 
            this.OutputWindow.Location = new System.Drawing.Point(472, 13);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(692, 855);
            this.OutputWindow.TabIndex = 1;
            this.OutputWindow.TabStop = false;
            this.OutputWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // ProgramCommandWindow
            // 
            this.ProgramCommandWindow.Location = new System.Drawing.Point(12, 12);
            this.ProgramCommandWindow.Name = "ProgramCommandWindow";
            this.ProgramCommandWindow.Size = new System.Drawing.Size(453, 856);
            this.ProgramCommandWindow.TabIndex = 2;
            this.ProgramCommandWindow.Text = "";
            this.ProgramCommandWindow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProgramCommandWindow_KeyDown);
            // 
            // commandline
            // 
            this.commandline.Location = new System.Drawing.Point(13, 894);
            this.commandline.Name = "commandline";
            this.commandline.Size = new System.Drawing.Size(453, 29);
            this.commandline.TabIndex = 3;
            this.commandline.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandline_KeyDown);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(646, 874);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(168, 70);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(820, 874);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(168, 70);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset Pen";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(994, 874);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(168, 35);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(994, 909);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(168, 35);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 956);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.commandline);
            this.Controls.Add(this.ProgramCommandWindow);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.buttonRun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OutputWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Initializing GUI elements
        /// </summary>

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.PictureBox OutputWindow;
        private System.Windows.Forms.RichTextBox ProgramCommandWindow;
        private System.Windows.Forms.TextBox commandline;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}

