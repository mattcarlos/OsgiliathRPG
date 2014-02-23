namespace OsgiliathRPG {
    partial class CharacterSelect {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelect));
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lbClass = new System.Windows.Forms.Label();
            this.btnSelectCharacter = new System.Windows.Forms.Button();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(20, 360);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(80, 60);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(520, 360);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(80, 60);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(278, 300);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(82, 25);
            this.lbClass.TabIndex = 2;
            this.lbClass.Text = "Warrior";
            this.lbClass.Click += new System.EventHandler(this.lbClass_Click);
            // 
            // btnSelectCharacter
            // 
            this.btnSelectCharacter.Location = new System.Drawing.Point(283, 360);
            this.btnSelectCharacter.Name = "btnSelectCharacter";
            this.btnSelectCharacter.Size = new System.Drawing.Size(77, 60);
            this.btnSelectCharacter.TabIndex = 3;
            this.btnSelectCharacter.Text = "Select";
            this.btnSelectCharacter.UseVisualStyleBackColor = true;
            this.btnSelectCharacter.Click += new System.EventHandler(this.btnSelectCharacter_Click);
            // 
            // pbCharacter
            // 
            this.pbCharacter.Image = ((System.Drawing.Image)(resources.GetObject("pbCharacter.Image")));
            this.pbCharacter.Location = new System.Drawing.Point(12, 12);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(600, 285);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCharacter.TabIndex = 5;
            this.pbCharacter.TabStop = false;
            // 
            // CharacterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.btnSelectCharacter);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Name = "CharacterSelect";
            this.Text = "Character Select";
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Button btnSelectCharacter;
        private System.Windows.Forms.PictureBox pbCharacter;
    }
}