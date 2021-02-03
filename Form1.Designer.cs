namespace CsharpFinalProject
{
    partial class AdditionForm
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
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.problemTB2 = new System.Windows.Forms.TextBox();
            this.problemTB1 = new System.Windows.Forms.TextBox();
            this.problemResultTB = new System.Windows.Forms.TextBox();
            this.signLbl = new System.Windows.Forms.Label();
            this.equalsLbl = new System.Windows.Forms.Label();
            this.topLbl = new System.Windows.Forms.Label();
            this.probNoLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.msgLbl = new System.Windows.Forms.Label();
            this.getGradeBtn = new System.Windows.Forms.Button();
            this.enterNameBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(121, 48);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(160, 20);
            this.firstNameTB.TabIndex = 0;
            this.firstNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstNameTB_KeyDown);
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(383, 48);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(160, 20);
            this.lastNameTB.TabIndex = 1;
            this.lastNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastNameTB_KeyDown);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(42, 51);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.firstNameLbl.TabIndex = 2;
            this.firstNameLbl.Text = "First Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(303, 51);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.lastNameLbl.TabIndex = 3;
            this.lastNameLbl.Text = "Last Name";
            // 
            // problemTB2
            // 
            this.problemTB2.Location = new System.Drawing.Point(281, 88);
            this.problemTB2.Name = "problemTB2";
            this.problemTB2.ReadOnly = true;
            this.problemTB2.Size = new System.Drawing.Size(100, 20);
            this.problemTB2.TabIndex = 5;
            this.problemTB2.Visible = false;
            // 
            // problemTB1
            // 
            this.problemTB1.Location = new System.Drawing.Point(156, 88);
            this.problemTB1.Name = "problemTB1";
            this.problemTB1.ReadOnly = true;
            this.problemTB1.Size = new System.Drawing.Size(100, 20);
            this.problemTB1.TabIndex = 4;
            this.problemTB1.Visible = false;
            // 
            // problemResultTB
            // 
            this.problemResultTB.AcceptsReturn = true;
            this.problemResultTB.Location = new System.Drawing.Point(406, 88);
            this.problemResultTB.Name = "problemResultTB";
            this.problemResultTB.Size = new System.Drawing.Size(100, 20);
            this.problemResultTB.TabIndex = 6;
            this.problemResultTB.Visible = false;
            this.problemResultTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.problemResultTB_KeyDown);
            // 
            // signLbl
            // 
            this.signLbl.AutoSize = true;
            this.signLbl.Location = new System.Drawing.Point(262, 91);
            this.signLbl.Name = "signLbl";
            this.signLbl.Size = new System.Drawing.Size(13, 13);
            this.signLbl.TabIndex = 7;
            this.signLbl.Text = "+";
            this.signLbl.Visible = false;
            // 
            // equalsLbl
            // 
            this.equalsLbl.AutoSize = true;
            this.equalsLbl.Location = new System.Drawing.Point(387, 91);
            this.equalsLbl.Name = "equalsLbl";
            this.equalsLbl.Size = new System.Drawing.Size(13, 13);
            this.equalsLbl.TabIndex = 8;
            this.equalsLbl.Text = "=";
            this.equalsLbl.Visible = false;
            // 
            // topLbl
            // 
            this.topLbl.AutoSize = true;
            this.topLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLbl.ForeColor = System.Drawing.Color.Blue;
            this.topLbl.Location = new System.Drawing.Point(42, 17);
            this.topLbl.Name = "topLbl";
            this.topLbl.Size = new System.Drawing.Size(208, 13);
            this.topLbl.TabIndex = 9;
            this.topLbl.Text = "Welcome!  Please enter your name:";
            // 
            // probNoLbl
            // 
            this.probNoLbl.AutoSize = true;
            this.probNoLbl.Location = new System.Drawing.Point(42, 93);
            this.probNoLbl.Name = "probNoLbl";
            this.probNoLbl.Size = new System.Drawing.Size(74, 13);
            this.probNoLbl.TabIndex = 10;
            this.probNoLbl.Text = "Problem No. 1";
            this.probNoLbl.Visible = false;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(21, 163);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLbl.Size = new System.Drawing.Size(86, 13);
            this.statusLbl.TabIndex = 11;
            this.statusLbl.Text = "Status Label 0/0";
            this.statusLbl.Visible = false;
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLbl.ForeColor = System.Drawing.Color.Blue;
            this.msgLbl.Location = new System.Drawing.Point(71, 129);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.msgLbl.Size = new System.Drawing.Size(92, 13);
            this.msgLbl.TabIndex = 12;
            this.msgLbl.Text = "Message Label";
            this.msgLbl.Visible = false;
            // 
            // getGradeBtn
            // 
            this.getGradeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getGradeBtn.Location = new System.Drawing.Point(383, 152);
            this.getGradeBtn.Name = "getGradeBtn";
            this.getGradeBtn.Size = new System.Drawing.Size(160, 23);
            this.getGradeBtn.TabIndex = 13;
            this.getGradeBtn.Text = "Finish and Calculate Grade";
            this.getGradeBtn.UseVisualStyleBackColor = true;
            this.getGradeBtn.Visible = false;
            this.getGradeBtn.Click += new System.EventHandler(this.GetGradeBtn_Click);
            // 
            // enterNameBtn
            // 
            this.enterNameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterNameBtn.Location = new System.Drawing.Point(383, 12);
            this.enterNameBtn.Name = "enterNameBtn";
            this.enterNameBtn.Size = new System.Drawing.Size(160, 23);
            this.enterNameBtn.TabIndex = 14;
            this.enterNameBtn.Text = "Enter Name and Begin";
            this.enterNameBtn.UseVisualStyleBackColor = true;
            this.enterNameBtn.Click += new System.EventHandler(this.EnterNameBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptBtn.Location = new System.Drawing.Point(513, 88);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(30, 23);
            this.acceptBtn.TabIndex = 15;
            this.acceptBtn.Text = "->";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Visible = false;
            this.acceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.restartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.restartBtn.FlatAppearance.BorderSize = 5;
            this.restartBtn.Location = new System.Drawing.Point(255, 12);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 23);
            this.restartBtn.TabIndex = 16;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // AdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 201);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.enterNameBtn);
            this.Controls.Add(this.getGradeBtn);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.probNoLbl);
            this.Controls.Add(this.topLbl);
            this.Controls.Add(this.equalsLbl);
            this.Controls.Add(this.signLbl);
            this.Controls.Add(this.problemResultTB);
            this.Controls.Add(this.problemTB2);
            this.Controls.Add(this.problemTB1);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.MaximumSize = new System.Drawing.Size(600, 240);
            this.MinimumSize = new System.Drawing.Size(600, 240);
            this.Name = "AdditionForm";
            this.Text = "Addition Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox problemTB2;
        private System.Windows.Forms.TextBox problemTB1;
        private System.Windows.Forms.TextBox problemResultTB;
        private System.Windows.Forms.Label signLbl;
        private System.Windows.Forms.Label equalsLbl;
        private System.Windows.Forms.Label topLbl;
        private System.Windows.Forms.Label probNoLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.Button getGradeBtn;
        private System.Windows.Forms.Button enterNameBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button restartBtn;
    }
}

