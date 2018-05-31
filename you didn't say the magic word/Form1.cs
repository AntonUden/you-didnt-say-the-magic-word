using System;
using System.Windows.Forms;
using System.Media;


namespace you_didn_t_say_the_magic_word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.sound);
            sp.PlayLooping();
        }
    }
}
