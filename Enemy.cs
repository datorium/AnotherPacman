﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherPacman
{
    class Enemy : PictureBox
    {
        public int Step { get; set; } = 2;
        public int HorizontalVelocity { get; set; } = 0;
        public int VerticalVelocity { get; set; } = 0;

        public Enemy()
        {
            InitializeEnemy();
        }

        private void InitializeEnemy()
        {
            this.BackColor = Color.Red;
            this.Size = new Size(20, 20);
            this.Tag = "ghost";
        }
        /// <summary>
        /// Sets movement direction of the enemy
        /// </summary>
        /// <param name="directionCode">1-East, 2-South, 3-West, 4-North</param>
        public void SetDirection(int directionCode)
        {
            switch (directionCode)
            {
                case 1:
                    HorizontalVelocity = Step;
                    VerticalVelocity = 0;
                    break;
                case 2:
                    HorizontalVelocity = 0;
                    VerticalVelocity = Step;
                    break;
                case 3:
                    HorizontalVelocity = -Step;
                    VerticalVelocity = 0;
                    break;
                case 4:
                    HorizontalVelocity = 0;
                    VerticalVelocity = -Step;
                    break;
            }
        }
    }


}
