using System.Diagnostics;
using System.Threading.Tasks;

namespace VideoFormatScript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string videoDir;
        private string soundDir;
        private string subtitlesDir;
        private string videoMask;
        private string soundMask;
        private string subtitlesMask;
        private string outputDir;

        // ������ ��� ������ ���������� � �����
        private void btnSelectVideoDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    videoDir = dialog.SelectedPath;
                    txtVideoDir.Text = videoDir;
                }
            }
        }

        // ������ ��� ������ ���������� � �����
        private void btnSelectSoundDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    soundDir = dialog.SelectedPath;
                    txtSoundDir.Text = soundDir;
                }
            }
        }

        // ������ ��� ������ ���������� � ����������
        private void btnSelectSubtitlesDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    subtitlesDir = dialog.SelectedPath;
                    txtSubtitlesDir.Text = subtitlesDir;
                }
            }
        }

        // ������ ��� ������ �������� ����������
        private void btnSelectOutputDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    outputDir = dialog.SelectedPath;
                    txtOutputDir.Text = outputDir;
                }
            }
        }

        // �������� ����� ��� ������� �������� ����������� ������
        private async void btnMerge_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            stopOrStartUI();

            try
            {
                // �������� ��� ����� � �����
                string[] videoFiles = Directory.GetFiles(videoDir, $"*{textBoxFormatVideo.Text}");

                // ������������ ������ ���� �����
                foreach (string videoFile in videoFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(videoFile);
                    string seriesNumber = ExtractSeriesNumber(fileName, videoMask);

                    if (!string.IsNullOrEmpty(seriesNumber))
                    {
                        labelNumSeries.Text = $"Converting {seriesNumber}";
                        await ProcessFile(seriesNumber, fileName, videoFile);
                    }
                }

                MessageBox.Show("������� ��������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("������� �������� � �������: " + ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                labelNumSeries.Text = "Process ended";
                stopOrStartUI();
            }
        }

        // ������� ��� �������� ������� ������ (����������, �����, ��������)
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(videoDir) || string.IsNullOrEmpty(soundDir) || string.IsNullOrEmpty(subtitlesDir) || string.IsNullOrEmpty(outputDir))
            {
                MessageBox.Show("�������� ��� ���������� ����� ������� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxSymbolMaskSubs.Text) || string.IsNullOrEmpty(textBoxSymbolMaskSound.Text) || string.IsNullOrEmpty(textBoxSymbolMaskVideo.Text))
            {
                MessageBox.Show("������ ��� ����� �� ����� ���� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (videoDir == outputDir)
            {
                MessageBox.Show("����������, ������ ������� ����� � ���� �����������, �� ����� ���� �����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxFormatVideo.Text) || string.IsNullOrEmpty(textBoxFormatSound.Text) || string.IsNullOrEmpty(textBoxFormatSubs.Text))
            {
                MessageBox.Show("������� ��� ���� ������ ����� ������� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // ������� ��� ��������� ������ �����
        private async Task ProcessFile(string seriesNumber, string fileName, string videoFile)
        {
            string video = FindFileWithSeriesNumber(videoDir, seriesNumber, $"*{textBoxFormatVideo.Text}", videoMask, textBoxSymbolMaskVideo.Text[0]);
            string sound = FindFileWithSeriesNumber(soundDir, seriesNumber, $"*{textBoxFormatSound.Text}", soundMask, textBoxSymbolMaskSound.Text[0]);
            string subtitles = FindFileWithSeriesNumber(subtitlesDir, seriesNumber, $"*{textBoxFormatSubs.Text}", subtitlesMask, textBoxSymbolMaskSubs.Text[0]);

            if (sound != null && subtitles != null)
            {
                string outputFilePath = Path.Combine(outputDir, fileName + $"{textBoxFormatVideo.Text}");

                if (File.Exists(outputFilePath)) {
                    MessageBox.Show($"���� � ����������� {outputFilePath} ��� ����������. ", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // ��������� ������� � ��������� ������
                await Task.Run(() => RunFFmpeg(video, sound, subtitles, outputFilePath));

                // ���� ��������� ����������� �������, ������� �������� �����
                if (File.Exists(outputFilePath) && checkBoxDeleteVideos.Checked)
                {
                    File.Delete(videoFile);
                }
            }
            else
            {
                MessageBox.Show($"����� ����� ��� ��������� ��� ����� {seriesNumber} �� �������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ���������� ������ ����� � ������ �����
        private string ExtractSeriesNumber(string fileName, string mask = null)
        {
            if (!string.IsNullOrEmpty(mask))
            {
                // ���� ������� �����, �������� ����� �����, ��� ���������� ����� �����
                string placeholder = "*";  // ����������� ������� ������ �����
                int placeholderIndex = mask.IndexOf(placeholder);

                if (placeholderIndex != -1)
                {
                    // ���������� ����� ����� ����� ����������
                    string prefix = mask.Substring(0, placeholderIndex);
                    int startIndex = fileName.IndexOf(prefix);

                    if (startIndex != -1)
                    {
                        // ������ ������ ����� � ����� ����� ���������� ��������
                        startIndex += prefix.Length;

                        string number = "";
                        // ��������� ����� �� ��� ���, ���� ��� ����
                        while (startIndex < fileName.Length && char.IsDigit(fileName[startIndex]))
                        {
                            number += fileName[startIndex];
                            startIndex++;
                        }

                        if (!string.IsNullOrEmpty(number))
                        {
                            return number; // ���������� ����������� ����� �����
                        }
                    }
                }
            }

            // ���� ����� �� �������, ���������� ����������� ��������� (����� ������ ����)
            foreach (char c in fileName)
            {
                if (char.IsDigit(c))
                {
                    string number = "";
                    int index = fileName.IndexOf(c);

                    while (index < fileName.Length && char.IsDigit(fileName[index]))
                    {
                        number += fileName[index];
                        index++;
                    }

                    if (number.Length >= 1)
                        return number;
                }
            }
            return null;
        }



        // ����� ����� � ����� �� ������� �����
        private string FindFileWithSeriesNumber(string directory, string seriesNumber, string extension, string maskName, char maskSymbol)
        {
            string[] files;

            // ���� ����� �������, �������� maskSymbol �� seriesNumber
            if (!string.IsNullOrEmpty(maskName))
            {
                string modifiedMask = maskName.Replace(maskSymbol.ToString(), seriesNumber);
                // ���� ����� � ����������� ������
                files = Directory.GetFiles(directory, modifiedMask + extension);
            }
            else
            {
                // ���� ����� ���, ���� ����� �� ���������� � seriesNumber
                files = Directory.GetFiles(directory, "*" + seriesNumber + "*" + extension);
            }

            // ���� ������� �����, ���������� ������
            if (files.Length > 0)
            {
                return files[0];
            }

            // ���� ������ �� �������, ���������� null
            return null;
        }



        private void RunFFmpeg(string video, string sound, string subtitles, string output)
        {
            Process ffmpeg = new Process();
            ffmpeg.StartInfo.FileName = @"ffmpeg\bin\ffmpeg.exe";
            ffmpeg.StartInfo.Arguments = $"-i \"{video}\" -i \"{sound}\" -i \"{subtitles}\" -map 0:v -map 1:a -map 2:s -c:v copy -c:a copy -c:s copy \"{output}\"";
            ffmpeg.StartInfo.RedirectStandardOutput = true;
            ffmpeg.StartInfo.RedirectStandardError = true;
            ffmpeg.StartInfo.UseShellExecute = false;
            ffmpeg.StartInfo.CreateNoWindow = true;

            try
            {
                ffmpeg.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        Console.WriteLine($"Output: {e.Data}");
                    }
                };

                ffmpeg.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        Console.WriteLine($"Error: {e.Data}");
                    }
                };

                ffmpeg.Start();
                ffmpeg.BeginOutputReadLine();
                ffmpeg.BeginErrorReadLine();

                ffmpeg.WaitForExit();

                if (ffmpeg.ExitCode == 0)
                {
                    if (checkBoxShowMessage.Checked)
                    {
                        MessageBox.Show($"���� ������� ���������: {output}", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"������ ��� ��������� �����. ��� ����������: {ffmpeg.ExitCode}\n��������� �� ������: {ffmpeg.StandardError.ReadToEnd()}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!ffmpeg.HasExited)
                {
                    ffmpeg.Kill();
                }
                ffmpeg.Close();
                ffmpeg.Dispose();
            }
        }

        //UI functions

        private void stopOrStartUI()
        {
            btnMerge.Enabled = !btnMerge.Enabled;

            txtSoundDir.Enabled = !txtSoundDir.Enabled;
            txtOutputDir.Enabled = !txtOutputDir.Enabled;
            txtSubtitlesDir.Enabled = !txtSubtitlesDir.Enabled;
            txtVideoDir.Enabled = !txtVideoDir.Enabled;

            btnSelectVideoDir.Enabled = !btnSelectVideoDir.Enabled;
            btnSelectSoundDir.Enabled = !btnSelectSoundDir.Enabled;
            btnSelectOutputDir.Enabled = !btnSelectOutputDir.Enabled;
            btnSelectSubtitlesDir.Enabled = !btnSelectSubtitlesDir.Enabled;

            textBoxFormatSound.Enabled = !textBoxFormatSound.Enabled;
            textBoxFormatSubs.Enabled = !textBoxFormatSubs.Enabled;
            textBoxFormatVideo.Enabled = !textBoxFormatVideo.Enabled;

            textBoxMaskSubs.Enabled = !textBoxMaskSubs.Enabled;
            textBoxMaskSound.Enabled = !textBoxMaskSound.Enabled;
            textBoxMaskVideo.Enabled = !textBoxMaskVideo.Enabled;

            textBoxSymbolMaskVideo.Enabled = !textBoxSymbolMaskVideo.Enabled;
            textBoxSymbolMaskSound.Enabled = !textBoxSymbolMaskSound.Enabled;
            textBoxSymbolMaskSubs.Enabled = !textBoxSymbolMaskSubs.Enabled;
        }

        private void txtVideoDir_TextChanged(object sender, EventArgs e)
        {
            videoDir = txtVideoDir.Text;
        }

        private void txtSoundDir_TextChanged(object sender, EventArgs e)
        {
            soundDir = txtSoundDir.Text;
        }

        private void txtSubtitlesDir_TextChanged(object sender, EventArgs e)
        {
            subtitlesDir = txtSubtitlesDir.Text;
        }

        private void txtOutputDir_TextChanged(object sender, EventArgs e)
        {
            outputDir = txtOutputDir.Text;
        }

        private void textBoxMaskVideo_TextChanged(object sender, EventArgs e)
        {
            videoMask = textBoxMaskVideo.Text;
        }

        private void textBoxMaskSound_TextChanged(object sender, EventArgs e)
        {
            soundMask = textBoxMaskSound.Text;
        }

        private void textBoxMaskSubs_TextChanged(object sender, EventArgs e)
        {
            subtitlesMask = textBoxMaskSubs.Text;
        }
    }
}
