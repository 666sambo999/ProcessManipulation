namespace ProcessManipulation
{
    partial class MainForm
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
            this.listBoxAssembly = new System.Windows.Forms.ListBox();
            this.listBoxStartAss = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelProc = new System.Windows.Forms.Label();
            this.labelProc2 = new System.Windows.Forms.Label();
            this.buttonBrauw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAssembly
            // 
            this.listBoxAssembly.FormattingEnabled = true;
            this.listBoxAssembly.Location = new System.Drawing.Point(40, 48);
            this.listBoxAssembly.Name = "listBoxAssembly";
            this.listBoxAssembly.Size = new System.Drawing.Size(174, 212);
            this.listBoxAssembly.TabIndex = 0;
            // 
            // listBoxStartAss
            // 
            this.listBoxStartAss.FormattingEnabled = true;
            this.listBoxStartAss.Location = new System.Drawing.Point(367, 51);
            this.listBoxStartAss.Name = "listBoxStartAss";
            this.listBoxStartAss.Size = new System.Drawing.Size(169, 212);
            this.listBoxStartAss.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(253, 48);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(253, 91);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(253, 135);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(253, 179);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // labelProc
            // 
            this.labelProc.AutoSize = true;
            this.labelProc.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProc.Location = new System.Drawing.Point(37, 22);
            this.labelProc.Name = "labelProc";
            this.labelProc.Size = new System.Drawing.Size(141, 17);
            this.labelProc.TabIndex = 6;
            this.labelProc.Text = "доступные процессы";
            // 
            // labelProc2
            // 
            this.labelProc2.AutoSize = true;
            this.labelProc2.Font = new System.Drawing.Font("Mistral", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProc2.Location = new System.Drawing.Point(364, 22);
            this.labelProc2.Name = "labelProc2";
            this.labelProc2.Size = new System.Drawing.Size(95, 15);
            this.labelProc2.TabIndex = 7;
            this.labelProc2.Text = "запущенные процессы";
            // 
            // buttonBrauw
            // 
            this.buttonBrauw.Location = new System.Drawing.Point(253, 219);
            this.buttonBrauw.Name = "buttonBrauw";
            this.buttonBrauw.Size = new System.Drawing.Size(75, 23);
            this.buttonBrauw.TabIndex = 8;
            this.buttonBrauw.Text = "review";
            this.buttonBrauw.UseVisualStyleBackColor = true;
            this.buttonBrauw.Click += new System.EventHandler(this.buttonBrauw_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 319);
            this.Controls.Add(this.buttonBrauw);
            this.Controls.Add(this.labelProc2);
            this.Controls.Add(this.labelProc);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listBoxStartAss);
            this.Controls.Add(this.listBoxAssembly);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAssembly;
        private System.Windows.Forms.ListBox listBoxStartAss;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelProc;
        private System.Windows.Forms.Label labelProc2;
        private System.Windows.Forms.Button buttonBrauw;
    }
}

