namespace livestreamer_shell
{
    partial class homeScreen
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
            this.components = new System.ComponentModel.Container();
            this.streamText = new System.Windows.Forms.TextBox();
            this.serviceName = new System.Windows.Forms.ComboBox();
            this.streamTip = new System.Windows.Forms.ToolTip(this.components);
            this.lableStreamType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.streamLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.sourceButton = new System.Windows.Forms.RadioButton();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.highButton = new System.Windows.Forms.RadioButton();
            this.mediumButton = new System.Windows.Forms.RadioButton();
            this.lowButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // streamText
            // 
            this.streamText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streamText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.streamText.Location = new System.Drawing.Point(200, 48);
            this.streamText.Name = "streamText";
            this.streamText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.streamText.Size = new System.Drawing.Size(173, 20);
            this.streamText.TabIndex = 1;
            this.streamTip.SetToolTip(this.streamText, "Input only stream name here.\r\nExample: twitch.tv/sample_name = sample_name");
            // 
            // serviceName
            // 
            this.serviceName.AllowDrop = true;
            this.serviceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceName.FormattingEnabled = true;
            this.serviceName.Items.AddRange(new object[] {
            "Twitch.tv",
            "YouTube Live"});
            this.serviceName.Location = new System.Drawing.Point(8, 48);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(172, 21);
            this.serviceName.TabIndex = 0;
            this.streamTip.SetToolTip(this.serviceName, "Select Where you would like to pull stream from.\r\n");
            // 
            // lableStreamType
            // 
            this.lableStreamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableStreamType.Location = new System.Drawing.Point(8, 8);
            this.lableStreamType.Name = "lableStreamType";
            this.lableStreamType.Size = new System.Drawing.Size(139, 28);
            this.lableStreamType.TabIndex = 2;
            this.lableStreamType.Text = "Streaming Service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(185, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // streamLabel
            // 
            this.streamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamLabel.Location = new System.Drawing.Point(232, 8);
            this.streamLabel.Name = "streamLabel";
            this.streamLabel.Size = new System.Drawing.Size(126, 27);
            this.streamLabel.TabIndex = 4;
            this.streamLabel.Text = "Name of Stream";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(8, 112);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(110, 40);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "OK, Go!";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(132, 112);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(110, 40);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(73, 169);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(103, 40);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // sourceButton
            // 
            this.sourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceButton.AutoSize = true;
            this.sourceButton.Checked = true;
            this.sourceButton.Location = new System.Drawing.Point(264, 104);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(59, 17);
            this.sourceButton.TabIndex = 8;
            this.sourceButton.TabStop = true;
            this.sourceButton.Text = "Source";
            this.sourceButton.UseVisualStyleBackColor = true;
            // 
            // qualityLabel
            // 
            this.qualityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(276, 78);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(75, 13);
            this.qualityLabel.TabIndex = 9;
            this.qualityLabel.Text = "Stream Quality";
            // 
            // highButton
            // 
            this.highButton.AutoSize = true;
            this.highButton.Location = new System.Drawing.Point(264, 136);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(47, 17);
            this.highButton.TabIndex = 10;
            this.highButton.Text = "High";
            this.highButton.UseVisualStyleBackColor = true;
            // 
            // mediumButton
            // 
            this.mediumButton.AutoSize = true;
            this.mediumButton.Location = new System.Drawing.Point(264, 168);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(62, 17);
            this.mediumButton.TabIndex = 11;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            // 
            // lowButton
            // 
            this.lowButton.AutoSize = true;
            this.lowButton.Location = new System.Drawing.Point(264, 200);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(45, 17);
            this.lowButton.TabIndex = 12;
            this.lowButton.Text = "Low";
            this.lowButton.UseVisualStyleBackColor = true;
            // 
            // homeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 232);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.sourceButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.streamLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lableStreamType);
            this.Controls.Add(this.streamText);
            this.Controls.Add(this.serviceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 271);
            this.Name = "homeScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Livestreamer GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serviceName;
        private System.Windows.Forms.ToolTip streamTip;
        private System.Windows.Forms.Label lableStreamType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label streamLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox streamText;
        private System.Windows.Forms.RadioButton sourceButton;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.RadioButton highButton;
        private System.Windows.Forms.RadioButton mediumButton;
        private System.Windows.Forms.RadioButton lowButton;
    }
}

