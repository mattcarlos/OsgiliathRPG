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
    public partial class Form1:Form {
        TakeATurn takeATurn = new TakeATurn();
        static string currentPlayer, currentEnemy;

        public static string CurrentPlayer {
            get {
                return currentPlayer;
            }
            set {
                currentPlayer = value;
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

        public Form1() {
            InitializeComponent();
            currentPlayer = "";
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (currentPlayer == "") {
                MessageBox.Show("Please select a character first.");
            }
            else {
                Game game = new Game(currentPlayer);
                game.Show();
                game.Visible = true;
            }
        }

        //Shows CharacterSelect form
        private void btnSelectChar_Click(object sender, EventArgs e) {
            CharacterSelect charSelect = new CharacterSelect();
            charSelect.Show();
            charSelect.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("OsgiliathRPG 1.0\n\nCreated by and Copyright Matt Carlos 2013");
        }
    }
}
