using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckHunt
{
    public class Duck
    {
        public int size, xSpeed, ySpeed, x, y, duckFallTimer;
        public string duckState;
        public SolidBrush brushColour;
        public int bigPoint = 1500; public int normalPoint = 1000; public int smallPoint = 500;
        public int addPoints;

        public Duck(int _size, int _y, int _x, int _xSpeed, int _ySpeed, SolidBrush _brushColour, string _duckState, int _duckFallTimer, int _addPoints)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            brushColour = _brushColour;
            duckState = _duckState;
            duckFallTimer = _duckFallTimer;
            addPoints = _addPoints;
        }

        public void Move(string direction)
        {
            //move ducks
            if(duckState == "left")
            {
                y -= ySpeed;
                x -= xSpeed;
            }
            if(duckState == "right")
            {
                y -= ySpeed;
                x += xSpeed;
            }
            if(duckState == "deadFalling")
            {
                y += ySpeed;
            }
        }

        public void Directions()
        {
            //change direction
            if(duckState == "left")
            {
                duckState = "right";
            }
            else if(duckState == "right")
            {
                duckState = "left";
            }
        }

        public void TopWallCollision(Duck d)
        {
            //remove duck if it is above the forms y height
            if(d.y < - 200)
            {
                gameScreen.duckMoving.Remove(d);
                gameScreen.ducksDeadAlive.Add("alive");
            }
        }

        public void WallCollision(Duck d)
        {
            //check collision with right wall and change direction 
            if (d.x >= 720 - d.size)
            {
                Directions();
            }
            //check collision with left wall and change direction 
            if (d.x <= 0 - d.size / 2)
            {
                Directions();
            }
        }

        public void mainMenuWallCollision(Duck d)
        {
            if(d.x >= 720 || d.x <= -100)
            {
                mainMenuScreen.menuDucks.Remove(d);
                mainMenuScreen.maxDucks--;
            }
        }

        public void gameOverWallCollision(Duck d)
        {
            if (d.x >= 720 || d.x <= -100)
            {
                gameOverScreen.menuDucks.Remove(d);
                gameOverScreen.maxDucks--;
            }
        }

        public void BottomCollision(Duck d)
        {
            if (d.y > 720)
            {
                gameScreen.duckMoving.Remove(d);
            }
        }

        public void Points(Duck d)
        {
            //calculate amount of points to reward player based on duck y position
            if(d.y >= 400)
            {
                addPoints = bigPoint;
            }
            else if (d.y <= 399 && d.y >= 100)
            {
                addPoints = normalPoint;
            }
            else if (d.y <= 100)
            {
                addPoints = smallPoint;
            }
        }
    }
}