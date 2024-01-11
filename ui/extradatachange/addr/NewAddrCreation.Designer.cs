namespace gui_cp2.ui.extradatachange.addr
{
    partial class NewAddrCreation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._tbPostcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._tbCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._tbStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._nudHouse = new System.Windows.Forms.NumericUpDown();
            this._nudAppartment = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudAppartment)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._tbPostcode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._tbCountry, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._tbCity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._tbStreet, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this._nudHouse, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this._nudAppartment, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Почтовый индекс";
            // 
            // _tbPostcode
            // 
            this._tbPostcode.Location = new System.Drawing.Point(193, 3);
            this._tbPostcode.Name = "_tbPostcode";
            this._tbPostcode.Size = new System.Drawing.Size(100, 20);
            this._tbPostcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Страна";
            // 
            // _tbCountry
            // 
            this._tbCountry.Location = new System.Drawing.Point(193, 33);
            this._tbCountry.Name = "_tbCountry";
            this._tbCountry.Size = new System.Drawing.Size(100, 20);
            this._tbCountry.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Город";
            // 
            // _tbCity
            // 
            this._tbCity.Location = new System.Drawing.Point(193, 63);
            this._tbCity.Name = "_tbCity";
            this._tbCity.Size = new System.Drawing.Size(100, 20);
            this._tbCity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Улица";
            // 
            // _tbStreet
            // 
            this._tbStreet.Location = new System.Drawing.Point(193, 93);
            this._tbStreet.Name = "_tbStreet";
            this._tbStreet.Size = new System.Drawing.Size(100, 20);
            this._tbStreet.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер дома";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Номер квартиры";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(12, 202);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(358, 23);
            this._btnSave.TabIndex = 1;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _nudHouse
            // 
            this._nudHouse.Location = new System.Drawing.Point(193, 123);
            this._nudHouse.Name = "_nudHouse";
            this._nudHouse.Size = new System.Drawing.Size(120, 20);
            this._nudHouse.TabIndex = 12;
            // 
            // _nudAppartment
            // 
            this._nudAppartment.Location = new System.Drawing.Point(193, 153);
            this._nudAppartment.Name = "_nudAppartment";
            this._nudAppartment.Size = new System.Drawing.Size(120, 20);
            this._nudAppartment.TabIndex = 13;
            // 
            // NewAddrCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 240);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewAddrCreation";
            this.Text = "NewAddrCreation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudAppartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbPostcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.NumericUpDown _nudHouse;
        private System.Windows.Forms.NumericUpDown _nudAppartment;
    }
}