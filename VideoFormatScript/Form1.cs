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
        private string audioDir;
        private string subtitlesDir;
        private string outputDir;

        // Кнопка для выбора директории с видео
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

        // Кнопка для выбора директории с аудио
        private void btnSelectAudioDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    audioDir = dialog.SelectedPath;
                    txtAudioDir.Text = audioDir;
                }
            }
        }

        // Кнопка для выбора директории с субтитрами
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

        // Кнопка для выбора выходной директории
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

        // Кнопка для запуска процесса объединения файлов
        private async void btnMerge_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(videoDir) || string.IsNullOrEmpty(audioDir) || string.IsNullOrEmpty(subtitlesDir) || string.IsNullOrEmpty(outputDir))
            {
                MessageBox.Show("Выберите все директории перед началом процесса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(videoDir == outputDir)
            {
                MessageBox.Show("Директория, откуда берутся файлы и куда выгружаются не могут быть одинаковыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string videoFormat = textBoxFormatVideo.Text;
            string audioFormat = textBoxFormatAudio.Text;
            string subFormat = textBoxFormatSubs.Text;

            if (string.IsNullOrEmpty(videoFormat) || string.IsNullOrEmpty(audioFormat) || string.IsNullOrEmpty(subFormat))
            {
                MessageBox.Show("Укажите все типы файлов перед началом процесса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stopOrStartUI();

            // Получаем все файлы в папке с видео
            string[] videoFiles = Directory.GetFiles(videoDir, $"*{videoFormat}");

            foreach (string video in videoFiles)
            {
                // Извлекаем номер серии
                string fileName = Path.GetFileNameWithoutExtension(video);
                string seriesNumber = ExtractSeriesNumber(fileName);
                labelNumSeries.Text = $"Converting {seriesNumber}";

                if (seriesNumber != null)
                {
                    // Ищем соответствующие аудио и субтитры с таким же номером серии
                    string audio = FindFileWithSeriesNumber(audioDir, seriesNumber, $"*{audioFormat}");
                    string subtitles = FindFileWithSeriesNumber(subtitlesDir, seriesNumber, $"*{subFormat}");

                    if (audio != null && subtitles != null)
                    {
                        string outputFilePath = Path.Combine(outputDir, fileName + $"{videoFormat}");

                        // Запускаем процесс в отдельном потоке
                        await Task.Run(() => RunFFmpeg(video, audio, subtitles, outputFilePath));

                        // Если обработка завершилась успешно, удаляем файл
                        if (File.Exists(outputFilePath) && checkBoxDeleteVideos.Checked)
                        {
                            File.Delete(video);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Файлы аудио или субтитров для серии {seriesNumber} не найдены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            labelNumSeries.Text = "Process ended";
            MessageBox.Show("Процесс завершён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            stopOrStartUI();
        }

        // Извлечение двух- или трёхзначного номера серии
        private string ExtractSeriesNumber(string fileName)
        {
            foreach (char c in fileName)
            {
                if (char.IsDigit(c))
                {
                    string number = "";
                    int index = fileName.IndexOf(c);

                    while (index < fileName.Length && char.IsDigit(fileName[index]) && number.Length < 3)
                    {
                        number += fileName[index];
                        index++;
                    }

                    if (number.Length == 2 || number.Length == 3)
                        return number;
                }
            }
            return null;
        }

        // Поиск файла с таким же номером серии
        private string FindFileWithSeriesNumber(string directory, string seriesNumber, string extension)
        {
            string[] files = Directory.GetFiles(directory, extension);
            foreach (string file in files)
            {
                if (file.Contains(seriesNumber))
                {
                    return file;
                }
            }
            return null;
        }

        private void stopOrStartUI()
        {
            btnMerge.Enabled = !btnMerge.Enabled;
            txtAudioDir.Enabled = !txtAudioDir.Enabled;
            txtOutputDir.Enabled = !txtOutputDir.Enabled;
            txtSubtitlesDir.Enabled = !txtSubtitlesDir.Enabled;
            txtVideoDir.Enabled = !txtVideoDir.Enabled;
            btnSelectVideoDir.Enabled = !btnSelectVideoDir.Enabled;
            btnSelectAudioDir.Enabled = !btnSelectAudioDir.Enabled;
            btnSelectOutputDir.Enabled = !btnSelectOutputDir.Enabled;
            btnSelectSubtitlesDir.Enabled = !btnSelectSubtitlesDir.Enabled;
            textBoxFormatAudio.Enabled = !textBoxFormatAudio.Enabled;
            textBoxFormatSubs.Enabled = !textBoxFormatSubs.Enabled;
            textBoxFormatVideo.Enabled = !textBoxFormatVideo.Enabled;

        }

        private void RunFFmpeg(string video, string audio, string subtitles, string output)
        {
            Process ffmpeg = new Process();
            ffmpeg.StartInfo.FileName = @"ffmpeg\bin\ffmpeg.exe";
            ffmpeg.StartInfo.Arguments = $"-i \"{video}\" -i \"{audio}\" -i \"{subtitles}\" -map 0:v -map 1:a -map 2:s -c:v copy -c:a copy -c:s copy \"{output}\"";
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
                        MessageBox.Show($"Файл успешно обработан: {output}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Ошибка при обработке файла. Код завершения: {ffmpeg.ExitCode}\nСообщение об ошибке: {ffmpeg.StandardError.ReadToEnd()}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtVideoDir_TextChanged(object sender, EventArgs e)
        {
            videoDir = txtVideoDir.Text;
        }

        private void txtAudioDir_TextChanged(object sender, EventArgs e)
        {
            audioDir = txtAudioDir.Text;
        }

        private void txtSubtitlesDir_TextChanged(object sender, EventArgs e)
        {
            subtitlesDir = txtSubtitlesDir.Text;
        }

        private void txtOutputDir_TextChanged(object sender, EventArgs e)
        {
            outputDir = txtOutputDir.Text;
        }
    }
}
