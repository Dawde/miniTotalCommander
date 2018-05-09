namespace cwiczenie2
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
            this.buttonUsunL = new System.Windows.Forms.Button();
            this.buttonKopiujP = new System.Windows.Forms.Button();
            this.buttonKopiujL = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUsunP = new System.Windows.Forms.Button();
            this.miniTotalCommander2 = new cwiczenie2.miniTotalCommander();
            this.miniTotalCommander1 = new cwiczenie2.miniTotalCommander();
            this.SuspendLayout();
            // 
            // buttonUsunL
            // 
            this.buttonUsunL.Location = new System.Drawing.Point(160, 289);
            this.buttonUsunL.Name = "buttonUsunL";
            this.buttonUsunL.Size = new System.Drawing.Size(75, 23);
            this.buttonUsunL.TabIndex = 2;
            this.buttonUsunL.Text = "Usuń";
            this.buttonUsunL.UseVisualStyleBackColor = true;
            this.buttonUsunL.Click += new System.EventHandler(this.buttonUsunL_Click);
            // 
            // buttonKopiujP
            // 
            this.buttonKopiujP.Location = new System.Drawing.Point(434, 289);
            this.buttonKopiujP.Name = "buttonKopiujP";
            this.buttonKopiujP.Size = new System.Drawing.Size(75, 23);
            this.buttonKopiujP.TabIndex = 3;
            this.buttonKopiujP.Text = "◀  Kopiuj";
            this.buttonKopiujP.UseVisualStyleBackColor = true;
            this.buttonKopiujP.Click += new System.EventHandler(this.buttonKopiujP_Click);
            // 
            // buttonKopiujL
            // 
            this.buttonKopiujL.Location = new System.Drawing.Point(12, 289);
            this.buttonKopiujL.Name = "buttonKopiujL";
            this.buttonKopiujL.Size = new System.Drawing.Size(75, 23);
            this.buttonKopiujL.TabIndex = 4;
            this.buttonKopiujL.Text = "Kopiuj  ▶";
            this.buttonKopiujL.UseVisualStyleBackColor = true;
            this.buttonKopiujL.Click += new System.EventHandler(this.buttonKopiujL_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(241, 122);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(39, 23);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = ">>";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(241, 151);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(39, 23);
            this.buttonLeft.TabIndex = 6;
            this.buttonLeft.Text = "<<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonUsunP
            // 
            this.buttonUsunP.Location = new System.Drawing.Point(286, 289);
            this.buttonUsunP.Name = "buttonUsunP";
            this.buttonUsunP.Size = new System.Drawing.Size(75, 23);
            this.buttonUsunP.TabIndex = 7;
            this.buttonUsunP.Text = "Usuń";
            this.buttonUsunP.UseVisualStyleBackColor = true;
            this.buttonUsunP.Click += new System.EventHandler(this.buttonUsunP_Click);
            // 
            // miniTotalCommander2
            // 
            this.miniTotalCommander2.currentPath = "C:\\";
            this.miniTotalCommander2.lastPath = "C:\\";
            this.miniTotalCommander2.Location = new System.Drawing.Point(286, 12);
            this.miniTotalCommander2.Name = "miniTotalCommander2";
            this.miniTotalCommander2.Size = new System.Drawing.Size(223, 287);
            this.miniTotalCommander2.TabIndex = 1;
            this.miniTotalCommander2.Load += new System.EventHandler(this.miniTotalCommander2_Load);
            // 
            // miniTotalCommander1
            // 
            this.miniTotalCommander1.currentPath = "C:\\";
            this.miniTotalCommander1.lastPath = "C:\\";
            this.miniTotalCommander1.Location = new System.Drawing.Point(12, 12);
            this.miniTotalCommander1.Name = "miniTotalCommander1";
            this.miniTotalCommander1.Size = new System.Drawing.Size(223, 287);
            this.miniTotalCommander1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 324);
            this.Controls.Add(this.buttonUsunP);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonKopiujL);
            this.Controls.Add(this.buttonKopiujP);
            this.Controls.Add(this.buttonUsunL);
            this.Controls.Add(this.miniTotalCommander2);
            this.Controls.Add(this.miniTotalCommander1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private miniTotalCommander miniTotalCommander1;
        private miniTotalCommander miniTotalCommander2;
        private System.Windows.Forms.Button buttonUsunL;
        private System.Windows.Forms.Button buttonKopiujP;
        private System.Windows.Forms.Button buttonKopiujL;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUsunP;
    }
}

