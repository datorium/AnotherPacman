using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnotherPacman
{
    class Score : PictureBox
    {
        public string scoreType { get; private set; } = null;
        public Score(int score)
        {
            this.scoreType = "score_" + score.ToString();
            InitializeScore();
        }

        private void InitializeScore()
        {
            this.BackColor = Color.Transparent;
            this.Size = new Size(30, 15);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject(this.scoreType);
        }
    }
}
