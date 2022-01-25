using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DuckHunt
{
    public partial class gameOverScreen : UserControl
    {
        public static List<Duck> menuDucks = new List<Duck>();
        public static int maxDucks = 0;
        Random random = new Random();
        Duck duck;
        int frameTimer = 0;
        int frameLeftRightNum = 0;// says what frame of the left or right flight animation it son
        Image[] leftImages = new Image[11];
        Image[] rightImages = new Image[11];

        bool aDown, dDown, spaceDown;
        int positionSwitchTimer = 10;
        int position = 0;

        System.Windows.Media.MediaPlayer selectSound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer switchSound = new System.Windows.Media.MediaPlayer();

        private void gameOverScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.A):
                    aDown = true;
                    break;
                case (Keys.D):
                    dDown = true;
                    break;
                case (Keys.Space):
                    spaceDown = true;
                    break;
            }
        }

        private void gameOverScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.A):
                    aDown = false;
                    break;
                case (Keys.D):
                    dDown = false;
                    break;
                case (Keys.Space):
                    spaceDown = false;
                    break;
            }
        }

        public gameOverScreen()
        {
            selectSound.Open(new Uri(Application.StartupPath + "/Resources/select sound.mp3"));
            switchSound.Open(new Uri(Application.StartupPath + "/Resources/switch sound.mp3"));

            InitializeComponent();
            scoreLabel.Text = $"SCORE: {gameScreen.points}";

            if(Convert.ToInt32(mainMenuScreen.highscore[0]) < gameScreen.points)
            {
                scoreLabel.Text = $"NEW HIGHSCORE: {gameScreen.points}";

                mainMenuScreen.highscore[0] = Convert.ToString(gameScreen.points); // add new highscore to highscore list
                File.WriteAllLines("HighscoreTextFile.txt", mainMenuScreen.highscore); // add new highscore to text file
            }
            //fly left images added to array
            leftImages[0] = Properties.Resources.duck_left_ani0;
            leftImages[1] = Properties.Resources.duck_left_ani1;
            leftImages[2] = Properties.Resources.duck_left_ani2;
            leftImages[3] = Properties.Resources.duck_left_ani3;
            leftImages[4] = Properties.Resources.duck_left_ani4;
            leftImages[5] = Properties.Resources.duck_left_ani5;
            leftImages[6] = Properties.Resources.duck_left_ani6;
            leftImages[7] = Properties.Resources.duck_left_ani7;
            leftImages[8] = Properties.Resources.duck_left_ani8;
            leftImages[9] = Properties.Resources.duck_left_ani9;
            leftImages[10] = Properties.Resources.duck_left_ani10;
            //add right images to array
            rightImages[0] = Properties.Resources.duck_right_0;
            rightImages[1] = Properties.Resources.duck_right_1;
            rightImages[2] = Properties.Resources.duck_right_2;
            rightImages[3] = Properties.Resources.duck_right_3;
            rightImages[4] = Properties.Resources.duck_right_4;
            rightImages[5] = Properties.Resources.duck_right_5;
            rightImages[6] = Properties.Resources.duck_right_6;
            rightImages[7] = Properties.Resources.duck_right_7;
            rightImages[8] = Properties.Resources.duck_right_8;
            rightImages[9] = Properties.Resources.duck_right_9;
            rightImages[10] = Properties.Resources.duck_right_10;
        }

        private void gameOverScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Duck d in menuDucks)
            {
                if (d.duckState == "left") // draw images if duck is moving left
                {
                    e.Graphics.DrawImage(leftImages[frameLeftRightNum], d.x, d.y); // draw duck images moving left
                }

                if (d.duckState == "right") // draw images if duck is moving right
                {
                    e.Graphics.DrawImage(rightImages[frameLeftRightNum], d.x, d.y);// draw duck images flying right
                }
            }
        }

        public void NewDucks()
        {
            int duckSize = 70; // how big the duck is
            int duckXSpeed = 5; // the xSpeed of the duck
            int duckYSpeed = 0; // the ySpeed of the duck
            int deadFallingTimer = 20; // sets time for duck to stop before falling
            int addPoints = 0;
            for (int i = 1; i <= 6; i++) // creates a duck 10 times
            {
                if (maxDucks == 6)
                {
                    break;
                }
                string duckState = null; // creates a duckState string and sets to nothing
                int duckX;
                int duckY = random.Next(49, 200);
                int duckXDir = random.Next(0, 2); //chooses if the duck will go left or right
                if (duckXDir == 0)
                {
                    duckState = "right";
                    duckX = -100;
                }
                else
                {
                    duckState = "left";
                    duckX = this.Width;
                }

                maxDucks++;
                duck = new Duck(duckSize, duckY, duckX, duckXSpeed, duckYSpeed, new SolidBrush(Color.Red), duckState, deadFallingTimer, addPoints);
                menuDucks.Add(duck);// adds a duck to the list
            }
        }

        private void gameOverLoop_Tick(object sender, EventArgs e)
        {
            if (aDown && position > 0 && positionSwitchTimer <= 0)
            {
                position--;
                positionSwitchTimer = 10;

                switchSound.Stop();
                switchSound.Play();
            }
            if (dDown && position < 2 && positionSwitchTimer <= 0)
            {
                position++;
                positionSwitchTimer = 10;

                switchSound.Stop();
                switchSound.Play();
            }

            if (position == 0)
            {
                replayLabel.ForeColor = Color.Orange;
                mainMenuLabel.ForeColor = Color.Black;
                quitLabel.ForeColor = Color.Black;
            }
            if (position == 1)
            {
                replayLabel.ForeColor = Color.Black;
                mainMenuLabel.ForeColor = Color.Orange;
                quitLabel.ForeColor = Color.Black;
            }
            if (position == 2)
            {
                replayLabel.ForeColor = Color.Black;
                mainMenuLabel.ForeColor = Color.Black;
                quitLabel.ForeColor = Color.Orange;
            }

            if (spaceDown && position == 0)
            {
                gameOverLoop.Enabled = false;
                Form form = this.FindForm();
                gameScreen gs = new gameScreen();

                form.Controls.Add(gs);
                form.Controls.Remove(this);
            }
            if (spaceDown && position == 1)
            {
                gameOverLoop.Enabled = false;
                Form form = this.FindForm();
                mainMenuScreen mm = new mainMenuScreen();

                form.Controls.Add(mm);
                form.Controls.Remove(this);
            }
            if (spaceDown && position == 2)
            {
                Application.Exit();
            }

            foreach (Duck d in menuDucks)
            {
                d.Move(d.duckState);
            }

            //check to see if its time to change image in left or right animation
            if (frameTimer % 2 == 0)
            {
                if (frameLeftRightNum < 10)//change image if it is not more than 10
                {
                    frameLeftRightNum++;
                }
                if (frameLeftRightNum == 10)//set image back to the first one
                {
                    frameLeftRightNum = 0;
                }
            }

            foreach (Duck d in menuDucks)
            {
                d.gameOverWallCollision(d);
                break;
            }

            if (menuDucks.Count <= maxDucks)
            {
                NewDucks();
            }

            frameTimer++;
            positionSwitchTimer--;
            Refresh();
        }
    }
}
