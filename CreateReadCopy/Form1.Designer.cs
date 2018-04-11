namespace CreateReadCopy
{
    partial class CRCform
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
            this.writeButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.entertextLabel = new System.Windows.Forms.Label();
            this.readfilenameLabel = new System.Windows.Forms.Label();
            this.inputfileLabel = new System.Windows.Forms.Label();
            this.outputfileLabel = new System.Windows.Forms.Label();
            this.entertexttextBox = new System.Windows.Forms.TextBox();
            this.readFilenametextBox = new System.Windows.Forms.TextBox();
            this.outputFilenametextBox = new System.Windows.Forms.TextBox();
            this.inputFilenametextBox = new System.Windows.Forms.TextBox();
            this.enterfilenametextBox = new System.Windows.Forms.TextBox();
            this.outputlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(36, 301);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 0;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(288, 301);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(523, 301);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 2;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(667, 301);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(55, 36);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(46, 13);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "filename";
            // 
            // entertextLabel
            // 
            this.entertextLabel.AutoSize = true;
            this.entertextLabel.Location = new System.Drawing.Point(55, 80);
            this.entertextLabel.Name = "entertextLabel";
            this.entertextLabel.Size = new System.Drawing.Size(56, 13);
            this.entertextLabel.TabIndex = 5;
            this.entertextLabel.Text = "Enter Text";
            // 
            // readfilenameLabel
            // 
            this.readfilenameLabel.AutoSize = true;
            this.readfilenameLabel.Location = new System.Drawing.Point(302, 36);
            this.readfilenameLabel.Name = "readfilenameLabel";
            this.readfilenameLabel.Size = new System.Drawing.Size(75, 13);
            this.readfilenameLabel.TabIndex = 6;
            this.readfilenameLabel.Text = "read FileName";
            // 
            // inputfileLabel
            // 
            this.inputfileLabel.AutoSize = true;
            this.inputfileLabel.Location = new System.Drawing.Point(520, 36);
            this.inputfileLabel.Name = "inputfileLabel";
            this.inputfileLabel.Size = new System.Drawing.Size(76, 13);
            this.inputfileLabel.TabIndex = 7;
            this.inputfileLabel.Text = "Input Filename";
            // 
            // outputfileLabel
            // 
            this.outputfileLabel.AutoSize = true;
            this.outputfileLabel.Location = new System.Drawing.Point(520, 121);
            this.outputfileLabel.Name = "outputfileLabel";
            this.outputfileLabel.Size = new System.Drawing.Size(84, 13);
            this.outputfileLabel.TabIndex = 8;
            this.outputfileLabel.Text = "Output filename ";
            // 
            // entertexttextBox
            // 
            this.entertexttextBox.Location = new System.Drawing.Point(36, 121);
            this.entertexttextBox.Multiline = true;
            this.entertexttextBox.Name = "entertexttextBox";
            this.entertexttextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.entertexttextBox.Size = new System.Drawing.Size(182, 162);
            this.entertexttextBox.TabIndex = 9;
            this.entertexttextBox.WordWrap = false;
            // 
            // readFilenametextBox
            // 
            this.readFilenametextBox.Location = new System.Drawing.Point(288, 73);
            this.readFilenametextBox.Name = "readFilenametextBox";
            this.readFilenametextBox.Size = new System.Drawing.Size(100, 20);
            this.readFilenametextBox.TabIndex = 10;
            // 
            // outputFilenametextBox
            // 
            this.outputFilenametextBox.Location = new System.Drawing.Point(523, 151);
            this.outputFilenametextBox.Name = "outputFilenametextBox";
            this.outputFilenametextBox.Size = new System.Drawing.Size(100, 20);
            this.outputFilenametextBox.TabIndex = 11;
            // 
            // inputFilenametextBox
            // 
            this.inputFilenametextBox.Location = new System.Drawing.Point(523, 57);
            this.inputFilenametextBox.Name = "inputFilenametextBox";
            this.inputFilenametextBox.Size = new System.Drawing.Size(100, 20);
            this.inputFilenametextBox.TabIndex = 12;
            // 
            // enterfilenametextBox
            // 
            this.enterfilenametextBox.Location = new System.Drawing.Point(36, 57);
            this.enterfilenametextBox.Name = "enterfilenametextBox";
            this.enterfilenametextBox.Size = new System.Drawing.Size(100, 20);
            this.enterfilenametextBox.TabIndex = 13;
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Location = new System.Drawing.Point(285, 121);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(35, 13);
            this.outputlabel.TabIndex = 14;
            this.outputlabel.Text = "label1";
            // 
            // CRCform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.enterfilenametextBox);
            this.Controls.Add(this.inputFilenametextBox);
            this.Controls.Add(this.outputFilenametextBox);
            this.Controls.Add(this.readFilenametextBox);
            this.Controls.Add(this.entertexttextBox);
            this.Controls.Add(this.outputfileLabel);
            this.Controls.Add(this.inputfileLabel);
            this.Controls.Add(this.readfilenameLabel);
            this.Controls.Add(this.entertextLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.writeButton);
            this.Name = "CRCform";
            this.Text = "Create Read Copy";
            this.Load += new System.EventHandler(this.CRCform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label entertextLabel;
        private System.Windows.Forms.Label readfilenameLabel;
        private System.Windows.Forms.Label inputfileLabel;
        private System.Windows.Forms.Label outputfileLabel;
        private System.Windows.Forms.TextBox entertexttextBox;
        private System.Windows.Forms.TextBox readFilenametextBox;
        private System.Windows.Forms.TextBox outputFilenametextBox;
        private System.Windows.Forms.TextBox inputFilenametextBox;
        private System.Windows.Forms.TextBox enterfilenametextBox;
        private System.Windows.Forms.Label outputlabel;
    }
}

