using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckHunt
{
    public partial class HowToPlayScreen : UserControl
    {
        bool spaceDown;
        public HowToPlayScreen()
        {
            InitializeComponent();
        }

        private void HowToPlayScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Space):
                    spaceDown = true;
                    break;
            }
        }

        private void HowToPlayScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Space):
                    spaceDown = false;
                    break;
            }
        }

        private void howToPlayLoop_Tick(object sender, EventArgs e)
        {
            if (spaceDown)
            {
                howToPlayLoop.Enabled = false;
                Form form = this.FindForm();
                mainMenuScreen mm = new mainMenuScreen();

                form.Controls.Add(mm);
                form.Controls.Remove(this);
            }
            Refresh();
        }

        private void goalExplainLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
