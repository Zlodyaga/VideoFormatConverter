namespace VideoFormatScript
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtVideoDir = new TextBox();
            txtSoundDir = new TextBox();
            txtSubtitlesDir = new TextBox();
            txtOutputDir = new TextBox();
            btnSelectVideoDir = new Button();
            btnSelectSoundDir = new Button();
            btnSelectSubtitlesDir = new Button();
            btnSelectOutputDir = new Button();
            btnMerge = new Button();
            checkBoxShowMessage = new CheckBox();
            labelNumSeries = new Label();
            textBoxFormatVideo = new TextBox();
            textBoxFormatSound = new TextBox();
            textBoxFormatSubs = new TextBox();
            checkBoxDeleteVideos = new CheckBox();
            textBoxMaskVideo = new TextBox();
            textBoxMaskSound = new TextBox();
            textBoxMaskSubs = new TextBox();
            panel1 = new Panel();
            textBoxSymbolMaskVideo = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            textBoxSymbolMaskSound = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            textBoxSymbolMaskSubs = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtVideoDir
            // 
            txtVideoDir.Font = new Font("Segoe UI", 15.75F);
            txtVideoDir.Location = new Point(22, 25);
            txtVideoDir.Name = "txtVideoDir";
            txtVideoDir.Size = new Size(694, 35);
            txtVideoDir.TabIndex = 0;
            txtVideoDir.Text = "VideoDir";
            txtVideoDir.TextChanged += txtVideoDir_TextChanged;
            // 
            // txtSoundDir
            // 
            txtSoundDir.Font = new Font("Segoe UI", 15.75F);
            txtSoundDir.Location = new Point(22, 139);
            txtSoundDir.Name = "txtSoundDir";
            txtSoundDir.Size = new Size(694, 35);
            txtSoundDir.TabIndex = 1;
            txtSoundDir.Text = "SoundDir";
            txtSoundDir.TextChanged += txtSoundDir_TextChanged;
            // 
            // txtSubtitlesDir
            // 
            txtSubtitlesDir.Font = new Font("Segoe UI", 15.75F);
            txtSubtitlesDir.Location = new Point(22, 257);
            txtSubtitlesDir.Name = "txtSubtitlesDir";
            txtSubtitlesDir.Size = new Size(694, 35);
            txtSubtitlesDir.TabIndex = 2;
            txtSubtitlesDir.Text = "SubsDir";
            txtSubtitlesDir.TextChanged += txtSubtitlesDir_TextChanged;
            // 
            // txtOutputDir
            // 
            txtOutputDir.Font = new Font("Segoe UI", 15.75F);
            txtOutputDir.Location = new Point(22, 390);
            txtOutputDir.Name = "txtOutputDir";
            txtOutputDir.Size = new Size(694, 35);
            txtOutputDir.TabIndex = 3;
            txtOutputDir.Text = "OutputDir";
            txtOutputDir.TextChanged += txtOutputDir_TextChanged;
            // 
            // btnSelectVideoDir
            // 
            btnSelectVideoDir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectVideoDir.Location = new Point(743, 26);
            btnSelectVideoDir.Name = "btnSelectVideoDir";
            btnSelectVideoDir.Size = new Size(215, 35);
            btnSelectVideoDir.TabIndex = 4;
            btnSelectVideoDir.Text = "Select video";
            btnSelectVideoDir.UseVisualStyleBackColor = true;
            btnSelectVideoDir.Click += btnSelectVideoDir_Click;
            // 
            // btnSelectSoundDir
            // 
            btnSelectSoundDir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectSoundDir.Location = new Point(743, 140);
            btnSelectSoundDir.Name = "btnSelectSoundDir";
            btnSelectSoundDir.Size = new Size(215, 35);
            btnSelectSoundDir.TabIndex = 5;
            btnSelectSoundDir.Text = "Select sound";
            btnSelectSoundDir.UseVisualStyleBackColor = true;
            btnSelectSoundDir.Click += btnSelectSoundDir_Click;
            // 
            // btnSelectSubtitlesDir
            // 
            btnSelectSubtitlesDir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectSubtitlesDir.Location = new Point(743, 257);
            btnSelectSubtitlesDir.Name = "btnSelectSubtitlesDir";
            btnSelectSubtitlesDir.Size = new Size(215, 35);
            btnSelectSubtitlesDir.TabIndex = 6;
            btnSelectSubtitlesDir.Text = "Select sub";
            btnSelectSubtitlesDir.UseVisualStyleBackColor = true;
            btnSelectSubtitlesDir.Click += btnSelectSubtitlesDir_Click;
            // 
            // btnSelectOutputDir
            // 
            btnSelectOutputDir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectOutputDir.Location = new Point(743, 391);
            btnSelectOutputDir.Name = "btnSelectOutputDir";
            btnSelectOutputDir.Size = new Size(215, 35);
            btnSelectOutputDir.TabIndex = 7;
            btnSelectOutputDir.Text = "Select output";
            btnSelectOutputDir.UseVisualStyleBackColor = true;
            btnSelectOutputDir.Click += btnSelectOutputDir_Click;
            // 
            // btnMerge
            // 
            btnMerge.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnMerge.Location = new Point(505, 582);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(155, 40);
            btnMerge.TabIndex = 8;
            btnMerge.Text = "Merge";
            btnMerge.UseVisualStyleBackColor = true;
            btnMerge.Click += btnMerge_Click;
            // 
            // checkBoxShowMessage
            // 
            checkBoxShowMessage.AutoSize = true;
            checkBoxShowMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxShowMessage.Location = new Point(22, 508);
            checkBoxShowMessage.Name = "checkBoxShowMessage";
            checkBoxShowMessage.Size = new Size(326, 25);
            checkBoxShowMessage.TabIndex = 9;
            checkBoxShowMessage.Text = "Show me success message (stops untill ok)";
            checkBoxShowMessage.UseVisualStyleBackColor = true;
            // 
            // labelNumSeries
            // 
            labelNumSeries.AutoSize = true;
            labelNumSeries.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelNumSeries.Location = new Point(22, 592);
            labelNumSeries.Name = "labelNumSeries";
            labelNumSeries.Size = new Size(207, 30);
            labelNumSeries.TabIndex = 10;
            labelNumSeries.Text = "Here will be progress";
            // 
            // textBoxFormatVideo
            // 
            textBoxFormatVideo.Font = new Font("Segoe UI", 15.75F);
            textBoxFormatVideo.Location = new Point(982, 26);
            textBoxFormatVideo.Name = "textBoxFormatVideo";
            textBoxFormatVideo.Size = new Size(129, 35);
            textBoxFormatVideo.TabIndex = 11;
            textBoxFormatVideo.Text = ".mkv";
            // 
            // textBoxFormatSound
            // 
            textBoxFormatSound.Font = new Font("Segoe UI", 15.75F);
            textBoxFormatSound.Location = new Point(982, 140);
            textBoxFormatSound.Name = "textBoxFormatSound";
            textBoxFormatSound.Size = new Size(129, 35);
            textBoxFormatSound.TabIndex = 12;
            textBoxFormatSound.Text = ".mka";
            // 
            // textBoxFormatSubs
            // 
            textBoxFormatSubs.Font = new Font("Segoe UI", 15.75F);
            textBoxFormatSubs.Location = new Point(982, 257);
            textBoxFormatSubs.Name = "textBoxFormatSubs";
            textBoxFormatSubs.Size = new Size(129, 35);
            textBoxFormatSubs.TabIndex = 13;
            textBoxFormatSubs.Text = ".ass";
            // 
            // checkBoxDeleteVideos
            // 
            checkBoxDeleteVideos.AutoSize = true;
            checkBoxDeleteVideos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxDeleteVideos.Location = new Point(22, 539);
            checkBoxDeleteVideos.Name = "checkBoxDeleteVideos";
            checkBoxDeleteVideos.Size = new Size(225, 25);
            checkBoxDeleteVideos.TabIndex = 14;
            checkBoxDeleteVideos.Text = "Delete videos from VideoDir";
            checkBoxDeleteVideos.UseVisualStyleBackColor = true;
            // 
            // textBoxMaskVideo
            // 
            textBoxMaskVideo.Font = new Font("Segoe UI", 15.75F);
            textBoxMaskVideo.Location = new Point(22, 80);
            textBoxMaskVideo.Name = "textBoxMaskVideo";
            textBoxMaskVideo.Size = new Size(503, 35);
            textBoxMaskVideo.TabIndex = 15;
            textBoxMaskVideo.Text = "MaskVideo";
            textBoxMaskVideo.TextChanged += textBoxMaskVideo_TextChanged;
            // 
            // textBoxMaskSound
            // 
            textBoxMaskSound.Font = new Font("Segoe UI", 15.75F);
            textBoxMaskSound.Location = new Point(22, 193);
            textBoxMaskSound.Name = "textBoxMaskSound";
            textBoxMaskSound.Size = new Size(503, 35);
            textBoxMaskSound.TabIndex = 16;
            textBoxMaskSound.Text = "MaskSound";
            textBoxMaskSound.TextChanged += textBoxMaskSound_TextChanged;
            // 
            // textBoxMaskSubs
            // 
            textBoxMaskSubs.Font = new Font("Segoe UI", 15.75F);
            textBoxMaskSubs.Location = new Point(22, 313);
            textBoxMaskSubs.Name = "textBoxMaskSubs";
            textBoxMaskSubs.Size = new Size(503, 35);
            textBoxMaskSubs.TabIndex = 17;
            textBoxMaskSubs.Text = "MaskSubs";
            textBoxMaskSubs.TextChanged += textBoxMaskSubs_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBoxSymbolMaskVideo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 103);
            panel1.TabIndex = 18;
            // 
            // textBoxSymbolMaskVideo
            // 
            textBoxSymbolMaskVideo.Font = new Font("Segoe UI", 15.75F);
            textBoxSymbolMaskVideo.Location = new Point(968, 61);
            textBoxSymbolMaskVideo.Name = "textBoxSymbolMaskVideo";
            textBoxSymbolMaskVideo.Size = new Size(129, 35);
            textBoxSymbolMaskVideo.TabIndex = 12;
            textBoxSymbolMaskVideo.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(517, 62);
            label1.Name = "label1";
            label1.Size = new Size(331, 30);
            label1.TabIndex = 0;
            label1.Text = "example: text.smth231.Ep*.smth15";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBoxSymbolMaskSound);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(1105, 111);
            panel2.TabIndex = 19;
            // 
            // textBoxSymbolMaskSound
            // 
            textBoxSymbolMaskSound.Font = new Font("Segoe UI", 15.75F);
            textBoxSymbolMaskSound.Location = new Point(968, 66);
            textBoxSymbolMaskSound.Name = "textBoxSymbolMaskSound";
            textBoxSymbolMaskSound.Size = new Size(129, 35);
            textBoxSymbolMaskSound.TabIndex = 12;
            textBoxSymbolMaskSound.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(517, 66);
            label2.Name = "label2";
            label2.Size = new Size(331, 30);
            label2.TabIndex = 1;
            label2.Text = "example: text.smth231.Ep*.smth15";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBoxSymbolMaskSubs);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(1105, 110);
            panel3.TabIndex = 19;
            // 
            // textBoxSymbolMaskSubs
            // 
            textBoxSymbolMaskSubs.Font = new Font("Segoe UI", 15.75F);
            textBoxSymbolMaskSubs.Location = new Point(968, 64);
            textBoxSymbolMaskSubs.Name = "textBoxSymbolMaskSubs";
            textBoxSymbolMaskSubs.Size = new Size(129, 35);
            textBoxSymbolMaskSubs.TabIndex = 13;
            textBoxSymbolMaskSubs.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(517, 69);
            label3.Name = "label3";
            label3.Size = new Size(331, 30);
            label3.TabIndex = 2;
            label3.Text = "example: text.smth231.Ep*.smth15";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1123, 664);
            Controls.Add(textBoxMaskSubs);
            Controls.Add(textBoxMaskSound);
            Controls.Add(textBoxMaskVideo);
            Controls.Add(checkBoxDeleteVideos);
            Controls.Add(textBoxFormatSubs);
            Controls.Add(textBoxFormatSound);
            Controls.Add(textBoxFormatVideo);
            Controls.Add(labelNumSeries);
            Controls.Add(checkBoxShowMessage);
            Controls.Add(btnMerge);
            Controls.Add(btnSelectOutputDir);
            Controls.Add(btnSelectSubtitlesDir);
            Controls.Add(btnSelectSoundDir);
            Controls.Add(btnSelectVideoDir);
            Controls.Add(txtOutputDir);
            Controls.Add(txtSubtitlesDir);
            Controls.Add(txtSoundDir);
            Controls.Add(txtVideoDir);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Video Converter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVideoDir;
        private TextBox txtSoundDir;
        private TextBox txtSubtitlesDir;
        private TextBox txtOutputDir;
        private Button btnSelectVideoDir;
        private Button btnSelectSoundDir;
        private Button btnSelectSubtitlesDir;
        private Button btnSelectOutputDir;
        private Button btnMerge;
        private CheckBox checkBoxShowMessage;
        private Label labelNumSeries;
        private TextBox textBoxFormatVideo;
        private TextBox textBoxFormatSound;
        private TextBox textBoxFormatSubs;
        private CheckBox checkBoxDeleteVideos;
        private TextBox textBoxMaskVideo;
        private TextBox textBoxMaskSound;
        private TextBox textBoxMaskSubs;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxSymbolMaskVideo;
        private TextBox textBoxSymbolMaskSound;
        private TextBox textBoxSymbolMaskSubs;
    }
}
