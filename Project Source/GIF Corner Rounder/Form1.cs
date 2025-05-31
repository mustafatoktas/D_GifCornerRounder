using ImageMagick;
using System.Diagnostics;

namespace GIF_Corner_Rounder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string kopyaYolu = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(1, 1);
        }

        private void tbCornerRadius_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbCornerRadius.Text))
            {

                if (1 <= Convert.ToInt32(tbCornerRadius.Text) &&
                    Convert.ToInt32(tbCornerRadius.Text) <= 238 &&
                    !String.IsNullOrEmpty(tbFilePath.Text))
                {
                    btnCreateGif.Enabled = true;
                }
                else btnCreateGif.Enabled = false;
            }
            else btnCreateGif.Enabled = false;

            if (!String.IsNullOrEmpty(tbFilePath.Text))
            {
                btnOpenFolder.Enabled = true;
            }
            else btnOpenFolder.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (Cursor == Cursors.AppStarting)
            {
                return;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                dosyaSec(selectedFileName);
            }
        }

        private void dosyaSec(string selectedFileName)
        {
            // seçilen dosyanýn bir gif dosyasý olup olmadýðýný kontrol et
            if (Path.GetExtension(selectedFileName).Equals(".gif", StringComparison.OrdinalIgnoreCase))
            {
                // textBox kontrolüne dosya yolunu yaz
                tbFilePath.Text = selectedFileName;

                // pictureBox kontrolüne gif dosyasýný göster
                pictureBox.Image = new Bitmap(selectedFileName);
                kopyaYolu = selectedFileName;

                adjustFormSizeToFitImage(pictureBox.Image.Size);

                pencereOrtala();
            }
            else
            {
                MessageBox.Show("Please select a GIF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pencereOrtala()
        {
            Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length > 0)
                {
                    dosyaSec(files[0]);
                }
            }
        }

        private void adjustFormSizeToFitImage(Size imageSize)
        {
            int currentWidth = Width;
            int currentHeight = Height;

            int gifWidth = imageSize.Width;
            int gifHeight = imageSize.Height;

            // eðer gifin boyutu pencere boyutundan büyükse pencere boyutunu ayarla
            if (gifWidth > currentWidth || gifHeight > currentHeight)
            {
                // yeni pencere boyutunu ayarlaya ve biraz boþluk ekle
                Size = new Size(gifWidth + 50, gifHeight + 170);
            }
        }

        private async void btnCreateGif_Click(object sender, EventArgs e)
        {
            btnCreateGif.Enabled = false;
            Cursor = Cursors.AppStarting;

            int radius = Convert.ToInt32(tbCornerRadius.Text);
            string inputPath = tbFilePath.Text;
            string outputPath = $"{Path.GetDirectoryName(inputPath)}\\{Path.GetFileNameWithoutExtension(inputPath)}_cr{radius}.gif";
            await Task.Run(() => RoundCorners(inputPath, outputPath, radius));

            btnCreateGif.Enabled = true;
            Cursor = Cursors.Default;

            MessageBox.Show($"Rounded corners GIF created:\n{outputPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBox.Image = Image.FromFile(outputPath);
            kopyaYolu = outputPath;
        }

        private void RoundCorners(string inputPath, string outputPath, int radius)
        {
            using (MagickImageCollection collection = new MagickImageCollection(inputPath))
            {
                foreach (MagickImage image in collection)
                {
                    // yuvarlatýlmýþ köþe maskesi oluþtur
                    MagickImage mask = new MagickImage(MagickColors.Transparent, image.Width, image.Height);
                    mask.Settings.FillColor = MagickColors.White;
                    mask.Draw(new DrawableRoundRectangle(0, 0, image.Width, image.Height, radius, radius));

                    // maskeyi görüntüye uygula
                    image.Composite(mask, CompositeOperator.DstIn);
                }
                collection.Write(outputPath);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // dosya uzantýsý gif ise iþlemi (efekti) kopyala olarak ayarla
                if (Path.GetExtension(files[0]).Equals(".gif", StringComparison.OrdinalIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                    //deðilse efekti hiçbir þey olarak ayarla
                    e.Effect = DragDropEffects.None;

            }
            else
                // eðer uzantý uygun deðilse iþlemi hiçbir þey olarak ayarla
                e.Effect = DragDropEffects.None;
        }

        private void tbCornerRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await VersionChecker.CheckForUpdates();
        }

        private async void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (Cursor != Cursors.AppStarting)
            {
                await Task.Run(() => openFolderInExplorer(tbFilePath.Text));
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox.Image);
        }

        private void copyAsPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(kopyaYolu);
        }

        private void gPL30LicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkeGit("https://www.gnu.org/licenses/gpl-3.0.html");
        }

        private void gitHubRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkeGit("https://github.com/mustafatoktas/D_GifCornerRounder");
        }

        private void openFolderInExplorer(string filePath)
        {
            string folderPath = Path.GetDirectoryName(filePath);

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}");
            }
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Theme support will be added in later versions.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkedInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkeGit("https://www.linkedin.com/in/mustafatoktas");
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkeGit("https://github.com/mustafatoktas/");
        }

        private void linkeGit(string link)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}");
            }
        }
    }
}