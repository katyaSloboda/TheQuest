using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Quest_1._0
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        int level = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(76, 55, 420, 160));
            game.NewLevel(random);
            levelNumber.Text = level.ToString();
            UpdateCharacters();
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateCharacters()
        {
            // Update the player's position and stats
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShow = 0;

            // Update each enemy's location and hit points
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        bat.Visible = true;
                        showBat = true;
                        enemiesShow++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        ghost.Visible = true;
                        showGhost = true;
                        enemiesShow++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        ghoul.Visible = true;
                        showGhoul = true;
                        enemiesShow++;
                    }
                }
            }

            if (!showBat)
            {
                bat.Visible = false;
                batHitPoints.Text = "";
            }
            if (!showGhost)
            {
                ghost.Visible = false;
                ghostHitPoints.Text = "";
            }
            if (!showGhoul)
            {
                ghoul.Visible = false;
                ghoulHitPoints.Text = "";
            }

            // Update the weapon PictureBoxes
            sword.Visible = false;
            bow.Visible = false;
            mace.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; break;
                case "Bow":
                    weaponControl = bow; break;
                case "Mace":
                    weaponControl = mace; break;
                case "Blue Potion":
                    weaponControl = bluePotion; break;
                case "Red Potion":
                    weaponControl = redPotion; break;
                default: break;
            }
            weaponControl.Visible = true;

            // Set the visible property on each inventory icon PictureBox
            inventorySword.Visible = false;
            inventoryBow.Visible = false;
            inventoryMace.Visible = false;
            inventoryBluePotion.Visible = false;
            inventoryRedPotion.Visible = false;
            
            if (game.CheckPlayerInventory("Sword"))
                inventorySword.Visible = true;
            if (game.CheckPlayerInventory("Bow"))
                inventoryBow.Visible = true;
            if (game.CheckPlayerInventory("Mace"))
                inventoryMace.Visible = true;
            if (game.CheckPlayerInventory("Blue Potion"))
                inventoryBluePotion.Visible = true;
            if (game.CheckPlayerInventory("Red Potion"))
                inventoryRedPotion.Visible = true;
            
            // The rest of the method
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if (enemiesShow < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                level++;
                levelNumber.Text = level.ToString();
                UpdateCharacters();
            }
        }

        private void inventorySword_Click(object sender, EventArgs e)
        {
            attackButtonVisible(true);
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                inventoryBorderStyle(inventorySword);
            }

        }

        private void inventoryBow_Click(object sender, EventArgs e)
        {
            attackButtonVisible(true);
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                inventoryBorderStyle(inventoryBow);
            }
        }

        private void inventoryMace_Click(object sender, EventArgs e)
        {
            attackButtonVisible(true);
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                inventoryBorderStyle(inventoryMace);
            }
        }

        private void inventoryBluePotion_Click(object sender, EventArgs e)
        {
            attackButtonVisible(false);
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                inventoryBorderStyle(inventoryBluePotion);
            }
        }

        private void inventoryRedPotion_Click(object sender, EventArgs e)
        {
            attackButtonVisible(false);
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                inventoryBorderStyle(inventoryRedPotion);
            }
        }

        private void attackButtonVisible(bool visible)
        {
            if (visible)
            {
                attackDown.Visible = true;
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackUp.Width = 23;
                attackUp.Text = "↑";
            }
            else
            {
                attackDown.Visible = false;
                attackLeft.Visible = false;
                attackRight.Visible = false;
                attackUp.Width = 40;
                attackUp.Text = "Drink";
            }
        }

        private void inventoryBorderStyle(PictureBox picture)
        {
            List<PictureBox> inventory = new List<PictureBox>();
            inventory.Add(inventorySword);
            inventory.Add(inventoryBow);
            inventory.Add(inventoryMace);
            inventory.Add(inventoryRedPotion);
            inventory.Add(inventoryBluePotion);

            foreach (PictureBox invenPicture in inventory)
                if (invenPicture == picture)
                    invenPicture.BorderStyle = BorderStyle.FixedSingle;
                else
                    invenPicture.BorderStyle = BorderStyle.None;
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }
    }
}
