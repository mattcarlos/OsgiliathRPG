using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsgiliathRPG {
    public partial class CharacterSelect:Form {
        private string[] selectedCharacter = { "Warrior", "Wizard", "Archer" };
        private int index;

        //stores the name of the character
        public string[] SelectedCharacter {
            get {
                return selectedCharacter;
            }
            set {
                selectedCharacter = value;
            }
        }
        //index that corresponds to the character in SelectedCharacter
        public int Index {
            get {
                return index;
            }
            set {
                index = value;
            }
        }

        public CharacterSelect() {
            InitializeComponent();
            this.Index = 0;
            //loads the default image (warrior)
            pbCharacter.Image = new Bitmap(this.selectedCharacter[this.Index] + ".png");
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            //decrements index
            if (this.Index >= 1) {
                this.Index -= 1;
            }
            //prevents Index from going below 0
            else {
                this.Index = 2;
            }
            //displays the text and image
            lbClass.Text = this.SelectedCharacter[this.Index];
            pbCharacter.Image = new Bitmap(this.selectedCharacter[this.Index] + ".png");
        }

        private void btnRight_Click(object sender, EventArgs e) {
            //increments index
            if (this.Index <= 1) {
                this.Index += 1;
            }
            //prevents index from going above 2
            else {
                this.Index = 0;
            }
            //displays the text and image
            lbClass.Text = this.SelectedCharacter[this.Index];
            pbCharacter.Image = new Bitmap(this.selectedCharacter[this.Index] + ".png");
        }

        private void lbClass_Click(object sender, EventArgs e) {

        }

        private void btnSelectCharacter_Click(object sender, EventArgs e) {
            //sets the selected character to the main form and closes
            OsgiliathRPG.Form1.CurrentPlayer = this.SelectedCharacter[this.Index];
            this.Close();
        }
    }
}
