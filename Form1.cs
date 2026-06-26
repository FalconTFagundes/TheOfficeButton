using NAudio.Wave;
using System.Reflection;

namespace TheOfficeButton
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private Mp3FileReader audioFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream("TheOfficeButton.theoffice.mp3");

            if (stream == null)
            {
                MessageBox.Show("Áudio não encontrado!");
                return;
            }

            audioFile = new Mp3FileReader(stream);

            outputDevice = new WaveOutEvent
            {
                DeviceNumber = 1
            };

            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
