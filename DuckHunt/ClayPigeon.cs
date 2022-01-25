using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckHunt
{
    class ClayPigeon
    {
        public int size, x, y, xSpeed, ySpeed;
        public int addPoints = 5000;
        int gravity = 13;
        public  int frameTimer = 0;
        public int currentFrame = 0;
        public string clayState = "none";
        public ClayPigeon(int _size, int _x, int _y, int _xSpeed, int _ySpeed, string _clayState)
        {
            size = _size;
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            clayState = _clayState;
        }

        public void Move()
        {
            x += xSpeed;
            y -= ySpeed - gravity;
        }
    }
}
