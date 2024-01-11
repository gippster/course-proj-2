namespace gui_cp2.ui.extradatachange.tlph
{
    partial class NewTlphCreation
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
            this._cbTelType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbTelNum = new System.Windows.Forms.TextBox();
            this._cbIsStationary = new System.Windows.Forms.CheckBox();
            this._btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._cbTelType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._tbTelNum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._cbIsStationary, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип телефона";
            // 
            // _cbTelType
            // 
            this._cbTelType.FormattingEnabled = true;
            this._cbTelType.Items.AddRange(new object[] {
            "Home",
            "Main",
            "Work",
            "Mobile"});
            this._cbTelType.Location = new System.Drawing.Point(193, 3);
            this._cbTelType.Name = "_cbTelType";
            this._cbTelType.Size = new System.Drawing.Size(121, 21);
            this._cbTelType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон является стационарным";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер телефона";
            // 
            // _tbTelNum
            // 
            this._tbTelNum.Location = new System.Drawing.Point(193, 63);
            this._tbTelNum.Name = "_tbTelNum";
            this._tbTelNum.Size = new System.Drawing.Size(121, 20);
            this._tbTelNum.TabIndex = 5;
            // 
            // _cbIsStationary
            // 
            this._cbIsStationary.AutoSize = true;
            this._cbIsStationary.Location = new System.Drawing.Point(193, 33);
            this._cbIsStationary.Name = "_cbIsStationary";
            this._cbIsStationary.Size = new System.Drawing.Size(15, 14);
            this._cbIsStationary.TabIndex = 6;
            this._cbIsStationary.UseVisualStyleBackColor = true;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(12, 202);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(358, 23);
            this._btnSave.TabIndex = 0;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // NewTlphCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 240);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewTlphCreation";
            this.Text = "NewTlphCreation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbTelType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbTelNum;
        private System.Windows.Forms.CheckBox _cbIsStationary;
    }
}