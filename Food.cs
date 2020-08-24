using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnotherPacman
{    
    class Food : PictureBox
    {
        public int Type { get; set; } = 1;

        public Food()
        {

        }

        private void InitializeFood()
        {
            this.BackColor = Color.Transparent;
            this.Size = new Size(20, 20);
            this.Name = "Food";
        }


        
    }
}
