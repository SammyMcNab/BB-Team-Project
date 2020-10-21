﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{

    public class PowerUp
    {
        public int x, y, xSpeed, ySpeed, size;
        public Color colour;
        public static Random randGen = new Random();

        public PowerUp(int _x, int _y, int _xSpeed, int _ySpeed, int _powerUpSize) 
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _powerUpSize;
        }

        public void Move()
        {
            x = x + xSpeed;
            y = y + ySpeed;
        }

        public void YCollision()
        {
            ySpeed *= -1;
            
        }
        public void XCollision()
        {
            xSpeed *= -1;
        }

        public void PaddleCollision(Paddle p, PowerUp up)
        {
            Rectangle powerUpRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (powerUpRec.IntersectsWith(paddleRec))
            {
                int value = randGen.Next(1, 3);

                if (value == 1)
                {
                    Form1.powerUp = 1;
                    ySpeed *= -1;
                    xSpeed *= -1;

                }
                else if (value == 2)
                {
                    Form1.powerUp = 2;
                    ySpeed *= -1;
                    xSpeed *= -1;
                }
                else
                {
                    Form1.powerUp = 3;
                    ySpeed *= -1;
                    xSpeed *= -1;
                }
            }
        }

        public void SheildCollistion()
        {
            ySpeed *= -1;
            xSpeed *= -1;
        }

    }
}
