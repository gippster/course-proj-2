namespace gui_cp2.ui
{
    partial class SearchForm
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
            this._cbConditions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._tbCondition = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this._lbPersons = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _cbConditions
            // 
            this._cbConditions.FormattingEnabled = true;
            this._cbConditions.Items.AddRange(new object[] {
            "ID",
            "Имя",
            "Фамилия",
            "Номер"});
            this._cbConditions.Location = new System.Drawing.Point(15, 25);
            this._cbConditions.Name = "_cbConditions";
            this._cbConditions.Size = new System.Drawing.Size(86, 21);
            this._cbConditions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Условие";
            // 
            // _tbCondition
            // 
            this._tbCondition.Location = new System.Drawing.Point(107, 25);
            this._tbCondition.Name = "_tbCondition";
            this._tbCondition.Size = new System.Drawing.Size(256, 20);
            this._tbCondition.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Искать!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lbPersons
            // 
            this._lbPersons.FormattingEnabled = true;
            this._lbPersons.Location = new System.Drawing.Point(15, 52);
            this._lbPersons.Name = "_lbPersons";
            this._lbPersons.Size = new System.Drawing.Size(435, 134);
            this._lbPersons.TabIndex = 4;
            this._lbPersons.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._lbPersons_MouseDoubleClick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 195);
            this.Controls.Add(this._lbPersons);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._tbCondition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbConditions);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cbConditions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbCondition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox _lbPersons;
    }
}