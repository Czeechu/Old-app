namespace egzamin_2023_01
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxStand = new System.Windows.Forms.ComboBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelStand = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxCharacters = new System.Windows.Forms.CheckBox();
            this.checkBoxNum = new System.Windows.Forms.CheckBox();
            this.checkBoxLetters = new System.Windows.Forms.CheckBox();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.comboBoxStand);
            this.groupBoxInfo.Controls.Add(this.textBoxSurname);
            this.groupBoxInfo.Controls.Add(this.textBoxName);
            this.groupBoxInfo.Controls.Add(this.labelStand);
            this.groupBoxInfo.Controls.Add(this.labelSurname);
            this.groupBoxInfo.Controls.Add(this.labelName);
            this.groupBoxInfo.Location = new System.Drawing.Point(45, 50);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(255, 203);
            this.groupBoxInfo.TabIndex = 0;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Dane pracownika";
            // 
            // comboBoxStand
            // 
            this.comboBoxStand.FormattingEnabled = true;
            this.comboBoxStand.Items.AddRange(new object[] {
            "Kierownik",
            "Starszy programista",
            "Młodszy programista",
            "Tester"});
            this.comboBoxStand.Location = new System.Drawing.Point(119, 104);
            this.comboBoxStand.Name = "comboBoxStand";
            this.comboBoxStand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStand.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(118, 73);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(122, 20);
            this.textBoxSurname.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(122, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // labelStand
            // 
            this.labelStand.AutoSize = true;
            this.labelStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStand.Location = new System.Drawing.Point(25, 104);
            this.labelStand.Name = "labelStand";
            this.labelStand.Size = new System.Drawing.Size(76, 16);
            this.labelStand.TabIndex = 2;
            this.labelStand.Text = "Stanowisko";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSurname.Location = new System.Drawing.Point(25, 73);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(65, 16);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(25, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(32, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Imię";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxCharacters);
            this.groupBox1.Controls.Add(this.checkBoxNum);
            this.groupBox1.Controls.Add(this.checkBoxLetters);
            this.groupBox1.Controls.Add(this.textBoxChar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(429, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generowanie hasła";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(82, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generuj hasło";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxCharacters
            // 
            this.checkBoxCharacters.AutoSize = true;
            this.checkBoxCharacters.Location = new System.Drawing.Point(28, 126);
            this.checkBoxCharacters.Name = "checkBoxCharacters";
            this.checkBoxCharacters.Size = new System.Drawing.Size(101, 17);
            this.checkBoxCharacters.TabIndex = 6;
            this.checkBoxCharacters.Text = "Znaki specjalne";
            this.checkBoxCharacters.UseVisualStyleBackColor = true;
            // 
            // checkBoxNum
            // 
            this.checkBoxNum.AutoSize = true;
            this.checkBoxNum.Location = new System.Drawing.Point(28, 103);
            this.checkBoxNum.Name = "checkBoxNum";
            this.checkBoxNum.Size = new System.Drawing.Size(49, 17);
            this.checkBoxNum.TabIndex = 5;
            this.checkBoxNum.Text = "Cyfry";
            this.checkBoxNum.UseVisualStyleBackColor = true;
            // 
            // checkBoxLetters
            // 
            this.checkBoxLetters.AutoSize = true;
            this.checkBoxLetters.Location = new System.Drawing.Point(28, 76);
            this.checkBoxLetters.Name = "checkBoxLetters";
            this.checkBoxLetters.Size = new System.Drawing.Size(115, 17);
            this.checkBoxLetters.TabIndex = 4;
            this.checkBoxLetters.Text = "Małe i wielkie litery";
            this.checkBoxLetters.UseVisualStyleBackColor = true;
            // 
            // textBoxChar
            // 
            this.textBoxChar.Location = new System.Drawing.Point(118, 36);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(122, 20);
            this.textBoxChar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ile znaków?";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(277, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Zatwierdź";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "Form1";
            this.Text = "Dodaj pracownika";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxStand;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelStand;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxChar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxCharacters;
        private System.Windows.Forms.CheckBox checkBoxNum;
        private System.Windows.Forms.CheckBox checkBoxLetters;
        private System.Windows.Forms.Button button2;
    }
}

