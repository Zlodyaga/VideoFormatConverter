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
            txtAudioDir = new TextBox();
            txtSubtitlesDir = new TextBox();
            txtOutputDir = new TextBox();
            btnSelectVideoDir = new Button();
            btnSelectAudioDir = new Button();
            btnSelectSubtitlesDir = new Button();
            btnSelectOutputDir = new Button();
            btnMerge = new Button();
            checkBoxShowMessage = new CheckBox();
            labelNumSeries = new Label();
            textBoxFormatVideo = new TextBox();
            textBoxFormatAudio = new TextBox();
            textBoxFormatSubs = new TextBox();
            checkBoxDeleteVideos = new CheckBox();
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
            // 
            // txtAudioDir
            // 
            txtAudioDir.Font = new Font("Segoe UI", 15.75F);
            txtAudioDir.Location = new Point(22, 90);
            txtAudioDir.Name = "txtAudioDir";
            txtAudioDir.Size = new Size(694, 35);
            txtAudioDir.TabIndex = 1;
            txtAudioDir.Text = "SoundDir";
            // 
            // txtSubtitlesDir
            // 
            txtSubtitlesDir.Font = new Font("Segoe UI", 15.75F);
            txtSubtitlesDir.Location = new Point(22, 159);
            txtSubtitlesDir.Name = "txtSubtitlesDir";
            txtSubtitlesDir.Size = new Size(694, 35);
            txtSubtitlesDir.TabIndex = 2;
            txtSubtitlesDir.Text = "SubsDir";
            // 
            // txtOutputDir
            // 
            txtOutputDir.Font = new Font("Segoe UI", 15.75F);
            txtOutputDir.Location = new Point(22, 229);
            txtOutputDir.Name = "txtOutputDir";
            txtOutputDir.Size = new Size(694, 35);
            txtOutputDir.TabIndex = 3;
            txtOutputDir.Text = "OutputDir";
            // 
            // btnSelectVideoDir
            // 
            btnSelectVideoDir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectVideoDir.Location = new Point(743, 26);
            btnSelectVideoDir.Name = "btnSelectVideoDir";
            btnSelectVideoDir.Size = new Size(215, 35);
            btnSelectVideoDir.TabIndex = 4;
            btnSelectVideoDir.Text = "SelectVideo";
            btnSelectVideoDir.UseVisualStyleBackColor = true;
            btnSelectVideoDir.Click += btnSelectVideoDir_Click;
            // 
            // btnSelectAudioDir
            // 
            btnSelectAudioDir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectAudioDir.Location = new Point(743, 91);
            btnSelectAudioDir.Name = "btnSelectAudioDir";
            btnSelectAudioDir.Size = new Size(215, 35);
            btnSelectAudioDir.TabIndex = 5;
            btnSelectAudioDir.Text = "SelectAudio";
            btnSelectAudioDir.UseVisualStyleBackColor = true;
            btnSelectAudioDir.Click += btnSelectAudioDir_Click;
            // 
            // btnSelectSubtitlesDir
            // 
            btnSelectSubtitlesDir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectSubtitlesDir.Location = new Point(743, 159);
            btnSelectSubtitlesDir.Name = "btnSelectSubtitlesDir";
            btnSelectSubtitlesDir.Size = new Size(215, 35);
            btnSelectSubtitlesDir.TabIndex = 6;
            btnSelectSubtitlesDir.Text = "SelectSub";
            btnSelectSubtitlesDir.UseVisualStyleBackColor = true;
            btnSelectSubtitlesDir.Click += btnSelectSubtitlesDir_Click;
            // 
            // btnSelectOutputDir
            // 
            btnSelectOutputDir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSelectOutputDir.Location = new Point(743, 230);
            btnSelectOutputDir.Name = "btnSelectOutputDir";
            btnSelectOutputDir.Size = new Size(215, 35);
            btnSelectOutputDir.TabIndex = 7;
            btnSelectOutputDir.Text = "SelectOutput";
            btnSelectOutputDir.UseVisualStyleBackColor = true;
            btnSelectOutputDir.Click += btnSelectOutputDir_Click;
            // 
            // btnMerge
            // 
            btnMerge.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnMerge.Location = new Point(505, 363);
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
            checkBoxShowMessage.Location = new Point(22, 289);
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
            labelNumSeries.Location = new Point(22, 373);
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
            // textBoxFormatAudio
            // 
            textBoxFormatAudio.Font = new Font("Segoe UI", 15.75F);
            textBoxFormatAudio.Location = new Point(982, 91);
            textBoxFormatAudio.Name = "textBoxFormatAudio";
            textBoxFormatAudio.Size = new Size(129, 35);
            textBoxFormatAudio.TabIndex = 12;
            textBoxFormatAudio.Text = ".mka";
            // 
            // textBoxFormatSubs
            // 
            textBoxFormatSubs.Font = new Font("Segoe UI", 15.75F);
            textBoxFormatSubs.Location = new Point(982, 159);
            textBoxFormatSubs.Name = "textBoxFormatSubs";
            textBoxFormatSubs.Size = new Size(129, 35);
            textBoxFormatSubs.TabIndex = 13;
            textBoxFormatSubs.Text = ".ass";
            // 
            // checkBoxDeleteVideos
            // 
            checkBoxDeleteVideos.AutoSize = true;
            checkBoxDeleteVideos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxDeleteVideos.Location = new Point(22, 320);
            checkBoxDeleteVideos.Name = "checkBoxDeleteVideos";
            checkBoxDeleteVideos.Size = new Size(225, 25);
            checkBoxDeleteVideos.TabIndex = 14;
            checkBoxDeleteVideos.Text = "Delete videos from VideoDir";
            checkBoxDeleteVideos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1123, 443);
            Controls.Add(checkBoxDeleteVideos);
            Controls.Add(textBoxFormatSubs);
            Controls.Add(textBoxFormatAudio);
            Controls.Add(textBoxFormatVideo);
            Controls.Add(labelNumSeries);
            Controls.Add(checkBoxShowMessage);
            Controls.Add(btnMerge);
            Controls.Add(btnSelectOutputDir);
            Controls.Add(btnSelectSubtitlesDir);
            Controls.Add(btnSelectAudioDir);
            Controls.Add(btnSelectVideoDir);
            Controls.Add(txtOutputDir);
            Controls.Add(txtSubtitlesDir);
            Controls.Add(txtAudioDir);
            Controls.Add(txtVideoDir);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Video Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVideoDir;
        private TextBox txtAudioDir;
        private TextBox txtSubtitlesDir;
        private TextBox txtOutputDir;
        private Button btnSelectVideoDir;
        private Button btnSelectAudioDir;
        private Button btnSelectSubtitlesDir;
        private Button btnSelectOutputDir;
        private Button btnMerge;
        private CheckBox checkBoxShowMessage;
        private Label labelNumSeries;
        private TextBox textBoxFormatVideo;
        private TextBox textBoxFormatAudio;
        private TextBox textBoxFormatSubs;
        private CheckBox checkBoxDeleteVideos;
    }
}
