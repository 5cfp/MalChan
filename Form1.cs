using System.Media;
using System.Reflection;

namespace MalChan
{
    public partial class Form1 : Form
    {
        private SoundPlayer onii;
        private SoundPlayer etoo;

        public Form1()
        {
            InitializeComponent();

            var asm = Assembly.GetExecutingAssembly();

            onii = new SoundPlayer(asm.GetManifestResourceStream("MalChan.snd.onii.wav"));
            etoo = new SoundPlayer(asm.GetManifestResourceStream("MalChan.snd.etoo.wav"));
            etoo.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onii.Play();
        }
    }
}