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
    public partial class Enemy:Form {
        private string enemyName;

        public string EnemyName {
            get {
                return enemyName;
            }
            set {
                enemyName = value;
            }
        }

        public Enemy() {
            InitializeComponent();
        }

        public Enemy(string enemy) {
            InitializeComponent();
            switch (enemy) {
                case "Scorpion":
                    pbEnemy.Image = new Bitmap("scorpion.png");
                    break;
                case "Armoured Scorpion":
                    pbEnemy.Image = new Bitmap("armouredscorpion.png");
                    break;
                case "Spider":
                    pbEnemy.Image = new Bitmap("spider.png");
                    break;
                case "Poison Spider":
                    pbEnemy.Image = new Bitmap("poisonspider.png");
                    break;
                case "Boar":
                    pbEnemy.Image = new Bitmap("boar.png");
                    break;
                case "Armoured Boar":
                    pbEnemy.Image = new Bitmap("armouredboar.png");
                    break;
                case "Hulking Boar":
                    pbEnemy.Image = new Bitmap("hulkingboar.png");
                    break;
                case "Bat":
                    pbEnemy.Image = new Bitmap("bat.png");
                    break;
                case "Hawk":
                    pbEnemy.Image = new Bitmap("hawk.png");
                    break;
                case "Giant Hawk":
                    pbEnemy.Image = new Bitmap("gianthawk.png");
                    break;
                default:
                    break;
            }
        }

        private void pbEnemy_Click(object sender, EventArgs e) {

        }
    }
}
