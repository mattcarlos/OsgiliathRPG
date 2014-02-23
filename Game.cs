using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGlibrary;

namespace OsgiliathRPG {
    public partial class Game:Form {
        private string[] selectedCharacter = { "Warrior", "Wizard", "Archer" };
        private string navigationReturn, currentEnemy, levelUp;
        private int index, turnNumber, numberOfTurnsAllowedThisClick;
        private bool isFightButtonShown;
        TakeATurn takeATurn = new TakeATurn();
        Navigation navigate = new Navigation();
        Enemy enemy;

        public string[] SelectedCharacter {
            get {
                return selectedCharacter;
            }
            set {
                selectedCharacter = value;
            }
        }
        public string NavigationReturn {
            get {
                return navigationReturn;
            }
            set {
                navigationReturn = value;
            }
        }
        public string CurrentEnemy {
            get {
                return currentEnemy;
            }
            set {
                currentEnemy = value;
            }
        }
        public string LevelUp {
            get {
                return levelUp;
            }
            set {
                levelUp = value;
            }
        }
        public int Index {
            get {
                return index;
            }
            set {
                index = value;
            }
        }
        public int TurnNumber {
            get {
                return turnNumber;
            }
            set {
                turnNumber = value;
            }
        }
        public int NumberOfTurnsAllowedThisClick {
            get {
                return numberOfTurnsAllowedThisClick;
            }
            set {
                numberOfTurnsAllowedThisClick = value;
            }
        }
        public bool IsFightButtonShown {
            get {
                return isFightButtonShown;
            }
            set {
                isFightButtonShown = value;
            }
        }

        //Default constructor
        public Game() {
            InitializeComponent();
        }

        //Main constructor
        public Game(string character) {
            InitializeComponent();
            this.TurnNumber = 0;
            this.IsFightButtonShown = false;
            if (character == "Warrior") {
                this.Index = 0;
            }
            if (character == "Wizard") {
                this.Index = 1;
            }
            if (character == "Archer") {
                this.Index = 2;
            }
            //sets player stats in takeATurn
            takeATurn.SetPlayerStats(this.SelectedCharacter[this.Index]);
            //Shows the character image and stats
            pbCharacterSmall.Image = new Bitmap(this.SelectedCharacter[this.Index] + "Small.png");
            lbPlayerStats.Text = "Stats:\nLevel: " + takeATurn.PlayerLevel
            + "\nCurrent Health: " + takeATurn.PHp
            + "\nArmor: " + takeATurn.PArmour
            + "\nSpeed: " + takeATurn.PSpeed
            + "\nDamage: " + takeATurn.PDmg;
        }

        //performs all attacking
        public void Fight() {
            //damage done for the turn
            int damageDone;

            //allow only one turn
            this.NumberOfTurnsAllowedThisClick = 1;

            if (turnNumber == 0) {
                //set player and enemy stats
                takeATurn.SetPlayerStats(this.SelectedCharacter[this.Index]);
                takeATurn.SetEnemyStats(this.CurrentEnemy);
            }

            //if the previous attacker already won and this isn't the first game
            if ((takeATurn.EHp <= 0) && (this.TurnNumber != 0)) {
                takeATurn.IsFightOver = true;
            }
            else {
                //if the previous damage reciever still has health, or this is the first turn
                if ((takeATurn.EHp > 0) || (this.TurnNumber == 0)) {
                    //if we are on an even vs odd turn, player turn
                    if ((this.TurnNumber % 2) == 0) {
                        this.TurnNumber++;
                        //performs the turn
                        damageDone = takeATurn.Turn(this.SelectedCharacter[this.Index], this.CurrentEnemy);

                        //prevent another turn without Fight() being called again
                        this.NumberOfTurnsAllowedThisClick = 0;

                        //if the turn did not kill opponent
                        if (takeATurn.EHp >= 0) {
                            //display damage done
                            //should implement character stats as well
                            MessageBox.Show("You did " + damageDone + " damage to " + CurrentEnemy + ".\n"
                                + CurrentEnemy + " has " + takeATurn.EHp + " remaining health");
                        }

                        //if enemy killed
                        if (takeATurn.EHp <= 0) {
                            this.LevelUp = takeATurn.OnKill(this.SelectedCharacter[this.Index]);
                            takeATurn.IsFightOver = true;
                            takeATurn.SetPlayerHPToMax();
                            MessageBox.Show("You killed " + this.CurrentEnemy + " by doing " + damageDone + " damage.\n" + this.LevelUp);
                        }
                    }
                    //odd turn, enemy turn
                    if (((this.TurnNumber % 2) == 1) && (this.NumberOfTurnsAllowedThisClick > 0)) {
                        this.TurnNumber++;
                        //performs the turn
                        damageDone = takeATurn.Turn(this.CurrentEnemy, this.SelectedCharacter[this.Index]);
                        //if the turn did not kill the player
                        if (takeATurn.PHp >= 0) {
                            //display damage done
                            //should implement character stats as well
                            MessageBox.Show(CurrentEnemy + " did " + damageDone + " damage to you.\n"
                                + "You have " + takeATurn.PHp + " remaining health");
                        }
                        //if player killed
                        if (takeATurn.PHp <= 0) {
                            //game is over, close to main window
                            MessageBox.Show(CurrentEnemy + " killed you by doing " + damageDone + " damage.");
                            MessageBox.Show("Game Over.");
                            takeATurn.IsFightOver = true;
                            this.Close();
                            enemy.Close();
                        }
                    }
                }
            }
            //reset to default, just in case
            this.NumberOfTurnsAllowedThisClick = 0;
        }

        public void UpdatePlayerStats() {
            lbPlayerStats.Text = "Stats:\nLevel: " + takeATurn.PlayerLevel
                + "\nCurrent Health: " + takeATurn.PHp
                + "\nArmor: " + takeATurn.PArmour
                + "\nSpeed: " + takeATurn.PSpeed
                + "\nDamage: " + takeATurn.PDmg;
        }

        private void btnNorth_Click(object sender, EventArgs e) {
            //reset button text if necessary
            if (this.IsFightButtonShown == true) {
                btnNorth.Text = "Go North";
                btnWest.Text = "Go West";
                btnEast.Text = "Go East";
            }

            //NavigateNorth() returns a string
            this.NavigationReturn = navigate.NavigateNorth();

            //if you've encountered an enemy
            if ((this.NavigationReturn == "You've encountered an enemy!") 
                || (this.NavigationReturn == "An enemy has ambushed you!")) {
                //takeATurn.EnemySelector returns a string
                this.CurrentEnemy = takeATurn.EnemySelector();

                //shows the enemy picture in a new window
                enemy = new Enemy(this.CurrentEnemy);
                enemy.Show();
                enemy.Visible = true;
                enemy.SetDesktopLocation(700, 0);
                MessageBox.Show(this.NavigationReturn + "\n\nYou are fighting a " + this.CurrentEnemy + ".");

                //make sure that player/enemy stats are set correctly
                takeATurn.SetPlayerStats(this.SelectedCharacter[this.Index]);
                takeATurn.SetEnemyStats(this.CurrentEnemy);

                //Start the fight
                do {
                    Fight();
                }
                while (takeATurn.IsFightOver == false);
                enemy.Close();
                UpdatePlayerStats();
            }

            //change button text if enemy attack on next move
            else if (this.NavigationReturn == "You hear skittering to the north.") {
                btnNorth.Text = "Fight!";
                this.IsFightButtonShown = true;
                MessageBox.Show(this.NavigationReturn);
            }
            else {
                MessageBox.Show(this.NavigationReturn);
            }
        }

        private void btnWest_Click(object sender, EventArgs e) {
            //reset button text if necessary
            if (this.IsFightButtonShown == true) {
                btnNorth.Text = "Go North";
                btnWest.Text = "Go West";
                btnEast.Text = "Go East";
            }

            //NavigateWest() returns a string
            this.NavigationReturn = navigate.NavigateWest();

            //if you've encountered an enemy
            if ((this.NavigationReturn == "You've encountered an enemy!") 
                || (this.NavigationReturn == "An enemy has ambushed you!")) {
                
                //takeATurn.EnemySelector returns a string
                this.CurrentEnemy = takeATurn.EnemySelector();

                //shows the enemy picture in a new window
                enemy = new Enemy(this.CurrentEnemy);
                enemy.Show();
                enemy.Visible = true;
                enemy.SetDesktopLocation(700, 0);
                MessageBox.Show(this.NavigationReturn + "\n\nYou are fighting a " + this.CurrentEnemy + ".");

                //make sure that player/enemy stats are set correctly
                takeATurn.SetPlayerStats(this.SelectedCharacter[this.Index]);
                takeATurn.SetEnemyStats(this.CurrentEnemy);

                //Start the fight
                do {
                    Fight();
                }
                while (takeATurn.IsFightOver == false);
                enemy.Close();
                UpdatePlayerStats();
            }

            //change button text if enemy attack on next move
            else if (this.NavigationReturn == "You hear rustling to the west.") {
                btnWest.Text = "Fight!";
                this.IsFightButtonShown = true;
                MessageBox.Show(this.NavigationReturn);
            }
            else {
                MessageBox.Show(this.NavigationReturn);
            }
        }

        private void btnEast_Click(object sender, EventArgs e) {
            //reset button text if necessary
            if (this.IsFightButtonShown == true) {
                btnNorth.Text = "Go North";
                btnWest.Text = "Go West";
                btnEast.Text = "Go East";
            }

            //NavigateEast() returns a string
            this.NavigationReturn = navigate.NavigateEast();

            //if you've encountered an enemy
            if ((this.NavigationReturn == "You've encountered an enemy!") 
                || (this.NavigationReturn == "An enemy has ambushed you!")) {

                //takeATurn.EnemySelector returns a string
                this.CurrentEnemy = takeATurn.EnemySelector();

                //shows the enemy picture in a new window
                enemy = new Enemy(this.CurrentEnemy);
                enemy.Show();
                enemy.Visible = true;
                enemy.SetDesktopLocation(700, 0);
                MessageBox.Show(this.NavigationReturn + "\n\nYou are fighting a " + this.CurrentEnemy + ".");

                //make sure that player/enemy stats are set correctly
                takeATurn.SetPlayerStats(this.SelectedCharacter[this.Index]);
                takeATurn.SetEnemyStats(this.CurrentEnemy);

                //Start the fight
                do {
                    Fight();
                }
                while (takeATurn.IsFightOver == false);
                enemy.Close();
                UpdatePlayerStats();
            }
            
            //change button text if enemy attack on next move
            else if (this.NavigationReturn == "You hear something coming from the east") {
                btnEast.Text = "Fight!";
                this.IsFightButtonShown = true;
                MessageBox.Show(this.NavigationReturn);
            }
            else {
                MessageBox.Show(this.NavigationReturn);
            }
        }
        
        private void pbCharacterSmall_Click(object sender, EventArgs e) {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("OsgiliathRPG 1.0\n\nCreated by and Copyright Matt Carlos 2013");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
