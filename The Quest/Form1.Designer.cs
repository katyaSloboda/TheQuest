namespace The_Quest_1._0
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.inventorySword = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.inventoryRedPotion = new System.Windows.Forms.PictureBox();
            this.inventoryBluePotion = new System.Windows.Forms.PictureBox();
            this.inventoryMace = new System.Windows.Forms.PictureBox();
            this.inventoryBow = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.levelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.levelNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.levelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(81, 64);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 30);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.44737F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.55263F));
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(351, 245);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 54);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(66, 39);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(35, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghoul";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(66, 26);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(35, 13);
            this.ghostHitPoints.TabIndex = 5;
            this.ghostHitPoints.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghost";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(66, 13);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(35, 13);
            this.batHitPoints.TabIndex = 3;
            this.batHitPoints.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bat";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(66, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 13);
            this.playerHitPoints.TabIndex = 1;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveRight);
            this.groupBox1.Controls.Add(this.moveLeft);
            this.groupBox1.Controls.Add(this.moveDown);
            this.groupBox1.Controls.Add(this.moveUp);
            this.groupBox1.Location = new System.Drawing.Point(344, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(61, 21);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(23, 23);
            this.moveRight.TabIndex = 3;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(17, 21);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(23, 23);
            this.moveLeft.TabIndex = 2;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(39, 34);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(23, 23);
            this.moveDown.TabIndex = 1;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(39, 11);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(23, 23);
            this.moveUp.TabIndex = 0;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackRight);
            this.groupBox2.Controls.Add(this.attackLeft);
            this.groupBox2.Controls.Add(this.attackDown);
            this.groupBox2.Controls.Add(this.attackUp);
            this.groupBox2.Location = new System.Drawing.Point(444, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 62);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(59, 22);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(23, 23);
            this.attackRight.TabIndex = 7;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(15, 22);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(23, 23);
            this.attackLeft.TabIndex = 6;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // attackDown
            // 
            this.attackDown.Location = new System.Drawing.Point(37, 35);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(23, 23);
            this.attackDown.TabIndex = 5;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackUp
            // 
            this.attackUp.Location = new System.Drawing.Point(37, 12);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(23, 23);
            this.attackUp.TabIndex = 4;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // inventorySword
            // 
            this.inventorySword.BackColor = System.Drawing.Color.Transparent;
            this.inventorySword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inventorySword.Image = ((System.Drawing.Image)(resources.GetObject("inventorySword.Image")));
            this.inventorySword.Location = new System.Drawing.Point(70, 319);
            this.inventorySword.Name = "inventorySword";
            this.inventorySword.Size = new System.Drawing.Size(50, 50);
            this.inventorySword.TabIndex = 4;
            this.inventorySword.TabStop = false;
            this.inventorySword.Visible = false;
            this.inventorySword.Click += new System.EventHandler(this.inventorySword_Click);
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
            this.mace.Location = new System.Drawing.Point(413, 64);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(30, 30);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mace.TabIndex = 5;
            this.mace.TabStop = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(372, 64);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(30, 30);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow.TabIndex = 6;
            this.bow.TabStop = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(331, 64);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(30, 30);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 7;
            this.sword.TabStop = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.redPotion.Image = ((System.Drawing.Image)(resources.GetObject("redPotion.Image")));
            this.redPotion.Location = new System.Drawing.Point(290, 64);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(30, 30);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotion.TabIndex = 8;
            this.redPotion.TabStop = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bluePotion.Image = ((System.Drawing.Image)(resources.GetObject("bluePotion.Image")));
            this.bluePotion.Location = new System.Drawing.Point(249, 64);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(30, 30);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotion.TabIndex = 9;
            this.bluePotion.TabStop = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ghoul.Image = ((System.Drawing.Image)(resources.GetObject("ghoul.Image")));
            this.ghoul.Location = new System.Drawing.Point(208, 64);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(30, 30);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoul.TabIndex = 10;
            this.ghoul.TabStop = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ghost.Image = ((System.Drawing.Image)(resources.GetObject("ghost.Image")));
            this.ghost.Location = new System.Drawing.Point(167, 64);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(30, 30);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost.TabIndex = 11;
            this.ghost.TabStop = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bat.Image = ((System.Drawing.Image)(resources.GetObject("bat.Image")));
            this.bat.Location = new System.Drawing.Point(126, 64);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(30, 30);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat.TabIndex = 12;
            this.bat.TabStop = false;
            // 
            // inventoryRedPotion
            // 
            this.inventoryRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryRedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inventoryRedPotion.Image = ((System.Drawing.Image)(resources.GetObject("inventoryRedPotion.Image")));
            this.inventoryRedPotion.Location = new System.Drawing.Point(290, 319);
            this.inventoryRedPotion.Name = "inventoryRedPotion";
            this.inventoryRedPotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryRedPotion.TabIndex = 13;
            this.inventoryRedPotion.TabStop = false;
            this.inventoryRedPotion.Visible = false;
            this.inventoryRedPotion.Click += new System.EventHandler(this.inventoryRedPotion_Click);
            // 
            // inventoryBluePotion
            // 
            this.inventoryBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inventoryBluePotion.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBluePotion.Image")));
            this.inventoryBluePotion.Location = new System.Drawing.Point(236, 319);
            this.inventoryBluePotion.Name = "inventoryBluePotion";
            this.inventoryBluePotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryBluePotion.TabIndex = 14;
            this.inventoryBluePotion.TabStop = false;
            this.inventoryBluePotion.Visible = false;
            this.inventoryBluePotion.Click += new System.EventHandler(this.inventoryBluePotion_Click);
            // 
            // inventoryMace
            // 
            this.inventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.inventoryMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inventoryMace.Image = ((System.Drawing.Image)(resources.GetObject("inventoryMace.Image")));
            this.inventoryMace.Location = new System.Drawing.Point(180, 319);
            this.inventoryMace.Name = "inventoryMace";
            this.inventoryMace.Size = new System.Drawing.Size(50, 50);
            this.inventoryMace.TabIndex = 15;
            this.inventoryMace.TabStop = false;
            this.inventoryMace.Visible = false;
            this.inventoryMace.Click += new System.EventHandler(this.inventoryMace_Click);
            // 
            // inventoryBow
            // 
            this.inventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inventoryBow.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBow.Image")));
            this.inventoryBow.Location = new System.Drawing.Point(124, 319);
            this.inventoryBow.Name = "inventoryBow";
            this.inventoryBow.Size = new System.Drawing.Size(50, 50);
            this.inventoryBow.TabIndex = 16;
            this.inventoryBow.TabStop = false;
            this.inventoryBow.Visible = false;
            this.inventoryBow.Click += new System.EventHandler(this.inventoryBow_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(236, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // levelPanel
            // 
            this.levelPanel.BackColor = System.Drawing.Color.Transparent;
            this.levelPanel.ColumnCount = 2;
            this.levelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.levelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.levelPanel.Controls.Add(this.levelNumber, 1, 0);
            this.levelPanel.Controls.Add(this.levelLabel, 0, 0);
            this.levelPanel.Location = new System.Drawing.Point(200, 256);
            this.levelPanel.Name = "levelPanel";
            this.levelPanel.RowCount = 1;
            this.levelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.levelPanel.Size = new System.Drawing.Size(141, 34);
            this.levelPanel.TabIndex = 19;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelLabel.Location = new System.Drawing.Point(3, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(76, 26);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "Level:";
            // 
            // levelNumber
            // 
            this.levelNumber.AutoSize = true;
            this.levelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelNumber.Location = new System.Drawing.Point(86, 0);
            this.levelNumber.Name = "levelNumber";
            this.levelNumber.Size = new System.Drawing.Size(25, 26);
            this.levelNumber.TabIndex = 1;
            this.levelNumber.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 399);
            this.Controls.Add(this.levelPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.player);
            this.Controls.Add(this.inventoryBow);
            this.Controls.Add(this.inventoryMace);
            this.Controls.Add(this.inventoryBluePotion);
            this.Controls.Add(this.inventoryRedPotion);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.inventorySword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.mace);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.bluePotion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.levelPanel.ResumeLayout(false);
            this.levelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox inventorySword;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox inventoryRedPotion;
        private System.Windows.Forms.PictureBox inventoryBluePotion;
        private System.Windows.Forms.PictureBox inventoryMace;
        private System.Windows.Forms.PictureBox inventoryBow;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel levelPanel;
        private System.Windows.Forms.Label levelNumber;
        private System.Windows.Forms.Label levelLabel;
    }
}

