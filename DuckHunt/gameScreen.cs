using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Xml;
using System.IO;

namespace DuckHunt
{
    public partial class gameScreen : UserControl
    {

        ClayPigeon clay;
        //reticle variables
        reticle shotThing;
        bool wDown = false;
        bool aDown = false;
        bool sDown = false;
        bool dDown = false;
        bool spaceDown = false;
        bool escDown = false;
        int shotTimer = 20;

        //game variables
        Random random = new Random();
        public static int points;
        int round;
        int hitDucks;
        int frameTimer;
        int requiredDucks = 5;

        //duck variables
        Duck duck;
        public static List<Duck> duckStationary = new List<Duck>();// stores ducks that arent moving yet
        public static List<Duck> duckMoving = new List<Duck>();// says what ducks are currently moving
        int duckDirTimer = 30;// timer for ducks to see if they change direction

        //UI and animations
        public static List<string> ducksDeadAlive = new List<string>();
        int frameLeftRightNum = 0;// says what frame of the left or right flight animation it son
        int frameFallNum = 0;// says what frame of the fall animation is on
        Font duckScoreFont = new Font("Arial", 16, FontStyle.Bold);
        SolidBrush solidBrush = new SolidBrush(Color.Black);
        Image[] fallImages = new Image[3];
        Image[] leftImages = new Image[11];
        Image[] rightImages = new Image[11];
        Image[] clayImages = new Image[8];

        //Sounds
        System.Windows.Media.MediaPlayer loadShellSound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer cockSound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer outOfAmmo = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer selectSound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer switchSound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer duckNoise1 = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer duckNoise2 = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer shotgunShotSound = new System.Windows.Media.MediaPlayer();

        //pause screen
        int positionSwitchTimer = 10;
        int position = 0;

        public gameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //set pause labels to now show
            resumeLabel.Text = "";
            mainMenuLabel.Text = "";
            quitLabel.Text = "";
            //fall images added to array
            fallImages[0] = Properties.Resources.duck_fall_0_resized;
            fallImages[1] = Properties.Resources.duck_fall_1_resized;
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
            //add clay images to array
            clayImages[0] = Properties.Resources.Clay_Destroy_1;
            clayImages[1] = Properties.Resources.Clay_Destroy_2;
            clayImages[2] = Properties.Resources.Clay_Destroy_3;
            clayImages[3] = Properties.Resources.Clay_Destroy_4;
            clayImages[4] = Properties.Resources.Clay_Destroy_5;
            clayImages[5] = Properties.Resources.Clay_Destroy_6;
            clayImages[6] = Properties.Resources.Clay_Destroy_7;
            clayImages[7] = Properties.Resources.Clay_Destroy_8;
            //open sounds
            cockSound.Open(new Uri(Application.StartupPath + "/Resources/reload 1.mp3"));
            loadShellSound.Open(new Uri(Application.StartupPath + "/Resources/loading shell 1.mp3"));
            outOfAmmo.Open(new Uri(Application.StartupPath + "/Respources/out of ammo.mp3"));
            selectSound.Open(new Uri(Application.StartupPath + "/Resources/select sound.mp3"));
            switchSound.Open(new Uri(Application.StartupPath + "/Resources/switch sound.mp3"));
            shotgunShotSound.Open(new Uri(Application.StartupPath + "/Resources/ShotGunShotSound.mp3"));
            duckNoise1.Open(new Uri(Application.StartupPath + "/Resources/duckNoise1.mp3"));
            duckNoise2.Open(new Uri(Application.StartupPath + "/Resources/duckNoise2.mp3"));
            //set reticle variables
            int rectickleSize = 64;// sets reticle size
            int recticleSpeed = 10;// sets reticle speed
            int recticleXY = 100;// set x and y spawn location
            int recticleAmmo = 0;// sets starting ammo amount
            shotThing = new reticle(rectickleSize, recticleSpeed, recticleXY, recticleXY, new SolidBrush(Color.Gold), recticleAmmo);// create reticle
            //clear duck lists and reset variables
            duckStationary.Clear();
            duckMoving.Clear();
            points = 0;
            round = 0;
            NewRound();
        }


        public void NewRound()
        {
            round++; // increase round number
            roundTitleLabel.Text = $"ROUND: {round}";
            Refresh();
            if (round % 5 == 0 && requiredDucks < 10)
            {
                requiredDucks++;
            }
            hitDucks = 0; // resets the amount of ducks you hit in the last round
            int duckSize = 70; // how big the duck is
            int duckXSpeed = 5; // the xSpeed of the duck
            int duckYSpeed = 10; // the ySpeed of the duck
            int duckY = 720; // the y spawn level of the duck
            int deadFallingTimer = 20; // sets time for duck to stop before falling
            int addPoints = 0;
            for (int i = 1; i <= 10; i++) // creates a duck 10 times
            {
                string duckState = null; // creates a duckState string and sets to nothing
                int duckX = random.Next(100, 600); // chooses a random x point to spawn the duck
                int duckXDir = random.Next(0, 2); //chooses if the duck will go left or right
                if (duckXDir == 0)
                {
                    duckState = "right";
                }
                else
                {
                    duckState = "left";
                }

                duck = new Duck(duckSize, duckY, duckX, duckXSpeed, duckYSpeed, new SolidBrush(Color.Red), duckState, deadFallingTimer, addPoints);
                duckStationary.Add(duck);// adds a duck to the list
            }
            ducksDeadAlive.Clear();// clears the tracker list of last round
            roundTitleLabel.Text = "";
            Wave();
        }

        public void Wave()
        {
            //randomly add 1 to 3 ducks to a move
            int ammountODuckInator = random.Next(0, 3);
            try// tries amount the random selected
            {
                for (int i = 0; i < ammountODuckInator; i++)
                {
                    duckMoving.Add(duckStationary[i]);
                    duckStationary.RemoveAt(i);
                }
            }
            catch// catches if it cant and restarts the process
            {
                Wave();
            }

            //check to see if clay will be in round
            int spawnClayChance = random.Next(0, 5);
            if (spawnClayChance == 1)
            {
                int size = 32;
                int x = 0;
                int y = 400;
                int xSpeed = 20;
                int ySpeed = 20;
                string clayState = "moving";
                clay = new ClayPigeon(size, x, y, xSpeed, ySpeed, clayState);
            }

            //reload to 3 rounds
            for (int i = 0; i <= 3; i++)
            {
                if (shotThing.ammo == 3)// break out of for loop is ammo is equal to 3
                {
                    cockSound.Stop();
                    cockSound.Play();
                    break;
                }

                loadShellSound.Stop();// stops and plays loading shell sound
                loadShellSound.Play();
                shotThing.ammo++;// increase ammo
                Refresh();
                Thread.Sleep(500);
            }
        }

        public void GameOver()
        {
            Form form = this.FindForm();
            gameOverScreen gos = new gameOverScreen();

            form.Controls.Add(gos);
            form.Controls.Remove(this);
        }

        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = !true;
                    break;
                case Keys.A:
                    aDown = !true;
                    break;
                case Keys.S:
                    sDown = !true;
                    break;
                case Keys.D:
                    dDown = !true;
                    break;
                case Keys.Space:
                    spaceDown = !true;
                    break;
                case Keys.Escape:
                    escDown = !true;
                    break;
            }
        }

        private void gameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    escDown = true;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            clay.Move();
            //move reticle
            if (wDown && shotThing.y >= 5)
            {
                shotThing.move("Up");
            }
            if (aDown && shotThing.x >= 5)
            {
                shotThing.move("Left");
            }
            if (sDown && shotThing.y <= this.Height - shotThing.size)
            {
                shotThing.move("Down");
            }
            if (dDown && shotThing.x <= this.Width - shotThing.size * 2)
            {
                shotThing.move("Right");
            }
            if (escDown)
            {
                resumeLabel.Text = "RESUME";
                mainMenuLabel.Text = "MAIN MENU";
                quitLabel.Text = "QUIT";

                pauseTimer.Enabled = true;
                gameTimer.Enabled = false;
            }

            //fire and check if player shot and hit a duck
            if (spaceDown == true && shotTimer <= 0 && shotThing.ammo > 0)
            {
                foreach (Duck d in duckMoving)
                {
                    shotThing.fire(d, clay);// check if duck got hit
                    d.Directions(); // change direction of all alive ducks

                    if (shotThing.didHitDuck)
                    {
                        d.Points(d); // check how much points player gets
                        points += d.addPoints; // add points to current score
                        ducksDeadAlive.Add("dead"); // add a dead duck to the deadAlive list
                        d.duckState = "dead"; // set duck state to dead
                        hitDucks++; // increase  duckHit variable for that round
                        shotThing.didHitDuck = false;
                        break;
                    }
                    if (shotThing.didHitClay)
                    {
                        points += clay.addPoints;
                        clay.clayState = "hit";
                        shotThing.didHitClay = false;
                    }
                }
                shotgunShotSound.Stop();
                shotgunShotSound.Play();
                shotTimer = 25; // reset shot timer
                shotThing.ammo--; // remove one shot from player
                cockSound.Stop();
                cockSound.Play();
            }

            //play this sound if out of ammo and tries to fire
            if (spaceDown == true && shotThing.ammo <= 0)
            {
                outOfAmmo.Stop();
                outOfAmmo.Play();
            }

            //check to see if new round
            if (duckStationary.Count == 0 && duckMoving.Count == 0 && hitDucks >= requiredDucks)
            {
                NewRound();
            }
            else if (duckStationary.Count == 0 && duckMoving.Count == 0 && hitDucks < requiredDucks)
            {
                GameOver();
                gameTimer.Enabled = false;
            }

            //check to see if new wave
            if (duckMoving.Count == 0)
            {
                Wave();
            }

            //move ducks
            foreach (Duck d in duckMoving)
            {
                int duckNoiseRan = random.Next(0, 4);

                if (duckNoiseRan <= 2)
                {
                    duckNoise1.Stop();
                    duckNoise1.Play();
                }
                else
                {
                    duckNoise2.Stop();
                    duckNoise2.Play();
                }

                d.Move(d.duckState);
            }

            //remove ducks if they hit top of screen
            foreach (Duck d in duckMoving)
            {
                d.TopWallCollision(d);
                break;
            }

            foreach (Duck d in duckMoving)
            {
                d.BottomCollision(d);
                break;
            }

            //change direction of duck hits side wall
            foreach (Duck d in duckMoving)
            {
                d.WallCollision(d);
            }

            //check if its time for duck to change x direction
            if (duckDirTimer <= 0)
            {
                foreach (Duck d in duckMoving)
                {
                    int duckDirChange = random.Next(0, 4);// choose a random number to decide if duck changes their direction

                    if (duckDirChange >= 2)
                    {
                        d.Directions();// change the direction of the duck
                    }
                }
                duckDirTimer = 30;// reset direction timer
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

            //check to see if its time to change image in fall animation
            if (frameTimer % 4 == 0)
            {
                if (frameFallNum < 2)//change image if it is not more than 2
                {
                    frameFallNum++;
                }
                if (frameFallNum == 2)//set image back to the first one
                {
                    frameFallNum = 0;
                }
            }

            //check to see if duck is in state dead and if it is reduce that by 1
            foreach (Duck d in duckMoving)
            {
                if (d.duckFallTimer <= 0)//checks duck state and fallTimer
                {
                    d.duckFallTimer = 20;//resets fallTimer
                }

                if (d.duckState == "dead")//check duck state
                {
                    d.duckFallTimer--;//reduces the timer
                }
            }

            if (clay.frameTimer % 2 == 0)
            {
                if (clay.currentFrame > 6)
                {
                    clay.clayState = "";
                    clay.currentFrame = 0;
                }
                else
                {
                    clay.currentFrame++;
                }
            }


            clay.frameTimer++;
            duckDirTimer--;
            shotTimer--;
            frameTimer++;
            Refresh();
        }

        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw UI background
            e.Graphics.DrawImage(Properties.Resources.woodBannerResize3, 0, 590);

            //draw ducks
            foreach (Duck d in duckMoving)
            {
                if (d.duckState == "left") // draw images if duck is moving left
                {
                    e.Graphics.DrawImage(leftImages[frameLeftRightNum], d.x, d.y); // draw duck images moving left
                }

                if (d.duckState == "right") // draw images if duck is moving right
                {
                    e.Graphics.DrawImage(rightImages[frameLeftRightNum], d.x, d.y);// draw duck images flying right
                }

                if (d.duckState == "dead") // show image if duck was just hit
                {
                    d.Points(d);//check what number to display
                    e.Graphics.DrawImage(Properties.Resources.duck_dead, d.x, d.y);//draw duck image when hit

                    if (d.x >= this.Width - d.size * 2)
                    {
                        e.Graphics.DrawString($"{d.addPoints}", duckScoreFont, solidBrush, d.x, d.y + d.size);// draw points received from that duck if duck is not on border of screen
                    }
                    else if (d.x < this.Width)
                    {
                        e.Graphics.DrawString($"{d.addPoints}", duckScoreFont, solidBrush, d.x + d.size, d.y + d.size);// draw points received from that duck if duck is right on border of screen
                    }

                    if (d.duckFallTimer <= 0)//check if falltimer is or less then 0
                    {
                        d.duckState = "deadFalling"; //change duck state to falling
                    }

                }

                if (d.duckState == "deadFalling") // play images while duck is falling after being hit
                {
                    e.Graphics.DrawImage(fallImages[frameFallNum], d.x, d.y); // draw duck images falling
                }
            }

            if (clay.clayState == "moving")
            {
                e.Graphics.DrawImage(Properties.Resources.clay_resized, clay.x, clay.y);
            }
            else if (clay.clayState == "hit")
            {
                e.Graphics.DrawImage(clayImages[clay.currentFrame], clay.x, clay.y);
            }


            //draw player
            if (shotThing.ammo > 0) // draw image if player has ammo
            {
                e.Graphics.DrawImage(Properties.Resources.crosshair, shotThing.x, shotThing.y);
            }
            else // draw image if player is out of ammo
            {
                e.Graphics.DrawImage(Properties.Resources.crosshairEmpty, shotThing.x, shotThing.y);
            }

            //draws the ducks you have hit and missed
            int currentDuckUIX = 200; // x position of each duck UI
            int duckUISpace = 25; // space between each duck UI

            foreach (string da in ducksDeadAlive)
            {
                if (da == "dead") // draw image for dead duck in deadAlive list
                {
                    e.Graphics.DrawImage(Properties.Resources.Dead_Duck, currentDuckUIX, 600);
                }
                else // draw image for alive ducks in deadAlive list
                {
                    e.Graphics.DrawImage(Properties.Resources.Alive_Duck, currentDuckUIX, 600);
                }
                currentDuckUIX += duckUISpace; // create x value for next duck UI
            }

            //draws shot gun shells
            int currentShotUIX = 25; // x poisition for shot UI
            int shotUISpace = 50; // space between each shot UI
            for (int i = 1; i <= shotThing.ammo; i++)
            {
                e.Graphics.DrawImage(Properties.Resources.Shot_Gun_Shell, currentShotUIX, 610);// draws shotguns shells to screen
                currentShotUIX += shotUISpace; // create x position for next shot UI
            }

            if (hitDucks == 10)
            {
                e.Graphics.DrawString("PERFECT +10000", duckScoreFont, solidBrush, this.Width / 2, this.Height / 2); // draw +10000 to screen if player doesnt miss a single duck
            }

            //Refresh labels
            scoreTestLabel.Text = $"SCORE: {points}";
            roundTestLabel.Text = $"ROUND: {round}";
        }

        private void pauseTimer_Tick(object sender, EventArgs e)
        {
            if (wDown && position > 0 && positionSwitchTimer <= 0)
            {
                position--;
                positionSwitchTimer = 10;

                switchSound.Stop();
                switchSound.Play();
            }
            if (sDown && position < 2 && positionSwitchTimer <= 0)
            {
                position++;
                positionSwitchTimer = 10;

                switchSound.Stop();
                switchSound.Play();
            }

            if (position == 0)
            {
                resumeLabel.ForeColor = Color.Orange;
                mainMenuLabel.ForeColor = Color.White;
                quitLabel.ForeColor = Color.White;
            }
            if (position == 1)
            {
                resumeLabel.ForeColor = Color.White;
                mainMenuLabel.ForeColor = Color.Orange;
                quitLabel.ForeColor = Color.White;
            }
            if (position == 2)
            {
                resumeLabel.ForeColor = Color.White;
                mainMenuLabel.ForeColor = Color.White;
                quitLabel.ForeColor = Color.Orange;
            }

            if (spaceDown && position == 0)
            {
                resumeLabel.Text = "";
                mainMenuLabel.Text = "";
                quitLabel.Text = "";

                gameTimer.Enabled = true;
                pauseTimer.Enabled = false;
            }
            if (spaceDown && position == 1)
            {
                pauseTimer.Enabled = false;
                Form form = this.FindForm();
                mainMenuScreen mm = new mainMenuScreen();

                form.Controls.Add(mm);
                form.Controls.Remove(this);
            }
            if (spaceDown && position == 2)
            {

                Application.Exit();
            }

            positionSwitchTimer--;
            Refresh();
        }
    }
}