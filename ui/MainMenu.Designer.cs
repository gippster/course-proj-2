namespace gui_cp2
{
    partial class MainMenu
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
            this._personsList = new System.Windows.Forms.ListBox();
            this._btnShowNPCForm = new System.Windows.Forms.Button();
            this._personView = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._lbID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._lbLname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._lbFname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._lbEmail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._lbAddr = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._lbTlph = new System.Windows.Forms.Label();
            this._btnChange = new System.Windows.Forms.Button();
            this._btnDelPerson = new System.Windows.Forms.Button();
            this._btnSearch = new System.Windows.Forms.Button();
            this._personView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _personsList
            // 
            this._personsList.FormattingEnabled = true;
            this._personsList.Location = new System.Drawing.Point(12, 59);
            this._personsList.Name = "_personsList";
            this._personsList.Size = new System.Drawing.Size(170, 381);
            this._personsList.TabIndex = 0;
            this._personsList.SelectedIndexChanged += new System.EventHandler(this._personsList_SelectedIndexChanged);
            // 
            // _btnShowNPCForm
            // 
            this._btnShowNPCForm.Location = new System.Drawing.Point(12, 30);
            this._btnShowNPCForm.Name = "_btnShowNPCForm";
            this._btnShowNPCForm.Size = new System.Drawing.Size(23, 23);
            this._btnShowNPCForm.TabIndex = 1;
            this._btnShowNPCForm.Text = "+";
            this._btnShowNPCForm.UseVisualStyleBackColor = true;
            this._btnShowNPCForm.Click += new System.EventHandler(this._btnShowNPCForm_Click);
            // 
            // _personView
            // 
            this._personView.Controls.Add(this.tableLayoutPanel1);
            this._personView.Location = new System.Drawing.Point(204, 12);
            this._personView.Name = "_personView";
            this._personView.Size = new System.Drawing.Size(504, 426);
            this._personView.TabIndex = 2;
            this._personView.TabStop = false;
            this._personView.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._lbID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._lbLname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._lbFname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._lbEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._lbAddr, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this._lbTlph, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // _lbID
            // 
            this._lbID.AutoSize = true;
            this._lbID.Location = new System.Drawing.Point(249, 0);
            this._lbID.Name = "_lbID";
            this._lbID.Size = new System.Drawing.Size(35, 13);
            this._lbID.TabIndex = 1;
            this._lbID.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // _lbLname
            // 
            this._lbLname.AutoSize = true;
            this._lbLname.Location = new System.Drawing.Point(249, 30);
            this._lbLname.Name = "_lbLname";
            this._lbLname.Size = new System.Drawing.Size(35, 13);
            this._lbLname.TabIndex = 3;
            this._lbLname.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя";
            // 
            // _lbFname
            // 
            this._lbFname.AutoSize = true;
            this._lbFname.Location = new System.Drawing.Point(249, 60);
            this._lbFname.Name = "_lbFname";
            this._lbFname.Size = new System.Drawing.Size(35, 13);
            this._lbFname.TabIndex = 5;
            this._lbFname.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // _lbEmail
            // 
            this._lbEmail.AutoSize = true;
            this._lbEmail.Location = new System.Drawing.Point(249, 90);
            this._lbEmail.Name = "_lbEmail";
            this._lbEmail.Size = new System.Drawing.Size(35, 13);
            this._lbEmail.TabIndex = 7;
            this._lbEmail.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 120);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.label9.Size = new System.Drawing.Size(44, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Адреса";
            // 
            // _lbAddr
            // 
            this._lbAddr.AutoSize = true;
            this._lbAddr.Location = new System.Drawing.Point(249, 120);
            this._lbAddr.Name = "_lbAddr";
            this._lbAddr.Size = new System.Drawing.Size(41, 13);
            this._lbAddr.TabIndex = 9;
            this._lbAddr.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Телефоны";
            // 
            // _lbTlph
            // 
            this._lbTlph.AutoSize = true;
            this._lbTlph.Location = new System.Drawing.Point(249, 148);
            this._lbTlph.Name = "_lbTlph";
            this._lbTlph.Size = new System.Drawing.Size(41, 13);
            this._lbTlph.TabIndex = 11;
            this._lbTlph.Text = "label12";
            // 
            // _btnChange
            // 
            this._btnChange.Location = new System.Drawing.Point(41, 31);
            this._btnChange.Name = "_btnChange";
            this._btnChange.Size = new System.Drawing.Size(111, 22);
            this._btnChange.TabIndex = 12;
            this._btnChange.Text = "Изменить";
            this._btnChange.UseVisualStyleBackColor = true;
            this._btnChange.Click += new System.EventHandler(this._btnChange_Click);
            // 
            // _btnDelPerson
            // 
            this._btnDelPerson.Location = new System.Drawing.Point(158, 30);
            this._btnDelPerson.Name = "_btnDelPerson";
            this._btnDelPerson.Size = new System.Drawing.Size(23, 23);
            this._btnDelPerson.TabIndex = 13;
            this._btnDelPerson.Text = "-";
            this._btnDelPerson.UseVisualStyleBackColor = true;
            this._btnDelPerson.Click += new System.EventHandler(this._btnDelPerson_Click);
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(12, 2);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(169, 23);
            this._btnSearch.TabIndex = 14;
            this._btnSearch.Text = "Поиск";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this._btnSearch);
            this.Controls.Add(this._btnDelPerson);
            this.Controls.Add(this._personView);
            this.Controls.Add(this._btnShowNPCForm);
            this.Controls.Add(this._personsList);
            this.Controls.Add(this._btnChange);
            this.Name = "MainMenu";
            this.Text = "Телефонный справочник";
            this._personView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _personsList;
        private System.Windows.Forms.Button _btnShowNPCForm;
        private System.Windows.Forms.GroupBox _personView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _lbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _lbLname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _lbFname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label _lbEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label _lbAddr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label _lbTlph;
        private System.Windows.Forms.Button _btnChange;
        private System.Windows.Forms.Button _btnDelPerson;
        private System.Windows.Forms.Button _btnSearch;
    }
}

