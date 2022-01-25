using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckHunt
{
    class reticle
    {
        public int size, speed, x, y, ammo;
        public SolidBrush brushColour;
        public bool didHitDuck = false;
        public bool didHitClay = false;
        public reticle(int _size, int _speed, int _y, int _x, SolidBrush _brushColour, int _ammo)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            brushColour = _brushColour;
            ammo = _ammo;
        }

        public void move(string direction)
        {
            //move recticle
            if (direction == "Up")
            {
                y -= speed;
            }
            if (direction == "Left")
            {
                x -= speed;
            }
            if (direction == "Down")
            {
                y += speed;
            }
            if (direction == "Right")
            {
                x += speed;
            }
        }

        public void fire(Duck d, ClayPigeon clay)
        {
            //create hit boxes for duck, clay and reticle
            Rectangle duckRec = new Rectangle(d.x, d.y, d.size, d.size);
            Rectangle recticleRec = new Rectangle(x, y, size, size);
            Rectangle clayRec = new Rectangle(clay.x, clay.y, clay.size, clay.size);

            if (recticleRec.IntersectsWith(duckRec))
            {
                didHitDuck = true;
            }

            if (recticleRec.IntersectsWith(clayRec))
            {
                didHitClay = true;
            }
        }
    }
}