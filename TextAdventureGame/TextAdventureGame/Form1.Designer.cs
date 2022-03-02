namespace TextAdventureGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGame = new System.Windows.Forms.Label();
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.lblLocationItems = new System.Windows.Forms.Label();
            this.btnExamine = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.btnExamineInventory = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.lblHand = new System.Windows.Forms.Label();
            this.btnUse = new System.Windows.Forms.Button();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            this.lblGame.BackColor = System.Drawing.Color.Black;
            this.lblGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGame.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.White;
            this.lblGame.Location = new System.Drawing.Point(13, 13);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(360, 340);
            this.lblGame.TabIndex = 0;
            // 
            // lstLocation
            // 
            this.lstLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.Location = new System.Drawing.Point(13, 392);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(360, 132);
            this.lstLocation.TabIndex = 1;
            // 
            // lblLocationItems
            // 
            this.lblLocationItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocationItems.Location = new System.Drawing.Point(13, 366);
            this.lblLocationItems.Name = "lblLocationItems";
            this.lblLocationItems.Size = new System.Drawing.Size(360, 23);
            this.lblLocationItems.TabIndex = 2;
            this.lblLocationItems.Text = "Items in";
            this.lblLocationItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExamine
            // 
            this.btnExamine.Location = new System.Drawing.Point(13, 530);
            this.btnExamine.Name = "btnExamine";
            this.btnExamine.Size = new System.Drawing.Size(163, 30);
            this.btnExamine.TabIndex = 3;
            this.btnExamine.Text = "Examine";
            this.btnExamine.UseVisualStyleBackColor = true;
            this.btnExamine.Click += new System.EventHandler(this.BtnExamine_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(207, 530);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(166, 30);
            this.btnTake.TabIndex = 4;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.BtnTake_Click);
            // 
            // lstInventory
            // 
            this.lstInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(412, 392);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(360, 132);
            this.lstInventory.TabIndex = 5;
            // 
            // lblInventory
            // 
            this.lblInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInventory.Location = new System.Drawing.Point(412, 366);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(360, 23);
            this.lblInventory.TabIndex = 6;
            this.lblInventory.Text = "Inventory";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExamineInventory
            // 
            this.btnExamineInventory.Location = new System.Drawing.Point(606, 530);
            this.btnExamineInventory.Name = "btnExamineInventory";
            this.btnExamineInventory.Size = new System.Drawing.Size(166, 30);
            this.btnExamineInventory.TabIndex = 8;
            this.btnExamineInventory.Text = "Examine";
            this.btnExamineInventory.UseVisualStyleBackColor = true;
            this.btnExamineInventory.Click += new System.EventHandler(this.BtnExamineInventory_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(412, 530);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(163, 30);
            this.btnHold.TabIndex = 7;
            this.btnHold.Text = "Hold Selected Item";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.BtnHold_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNorth.Location = new System.Drawing.Point(541, 17);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 75);
            this.btnNorth.TabIndex = 9;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.BtnNorth_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSouth.Location = new System.Drawing.Point(541, 162);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 75);
            this.btnSouth.TabIndex = 10;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.BtnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWest.Location = new System.Drawing.Point(468, 90);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 75);
            this.btnWest.TabIndex = 11;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.BtnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEast.Location = new System.Drawing.Point(614, 90);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 75);
            this.btnEast.TabIndex = 12;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.BtnEast_Click);
            // 
            // lblHand
            // 
            this.lblHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHand.Location = new System.Drawing.Point(412, 291);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(360, 23);
            this.lblHand.TabIndex = 13;
            this.lblHand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUse
            // 
            this.btnUse.Location = new System.Drawing.Point(412, 317);
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(360, 30);
            this.btnUse.TabIndex = 14;
            this.btnUse.Text = "Use";
            this.btnUse.UseVisualStyleBackColor = true;
            this.btnUse.Click += new System.EventHandler(this.BtnUse_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.Location = new System.Drawing.Point(412, 258);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(163, 30);
            this.btnDrop.TabIndex = 15;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.BtnDrop_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(609, 258);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(163, 30);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return to Inventory";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.btnUse);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnExamineInventory);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnExamine);
            this.Controls.Add(this.lblLocationItems);
            this.Controls.Add(this.lstLocation);
            this.Controls.Add(this.lblGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.Label lblLocationItems;
        private System.Windows.Forms.Button btnExamine;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Button btnExamineInventory;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Button btnUse;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnReturn;
    }
}

