namespace gui_cp2
{
    partial class ExtraAddrChange
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
            this._btnSave = new System.Windows.Forms.Button();
            this._lbAddresses = new System.Windows.Forms.ListBox();
            this._btnShowAddForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(43, 251);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(273, 23);
            this._btnSave.TabIndex = 1;
            this._btnSave.Text = "Сохранить";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _lbAddresses
            // 
            this._lbAddresses.FormattingEnabled = true;
            this._lbAddresses.Location = new System.Drawing.Point(13, 12);
            this._lbAddresses.Name = "_lbAddresses";
            this._lbAddresses.Size = new System.Drawing.Size(303, 225);
            this._lbAddresses.TabIndex = 2;
            // 
            // _btnShowAddForm
            // 
            this._btnShowAddForm.Location = new System.Drawing.Point(12, 251);
            this._btnShowAddForm.Name = "_btnShowAddForm";
            this._btnShowAddForm.Size = new System.Drawing.Size(23, 23);
            this._btnShowAddForm.TabIndex = 3;
            this._btnShowAddForm.Text = "+";
            this._btnShowAddForm.UseVisualStyleBackColor = true;
            this._btnShowAddForm.Click += new System.EventHandler(this._btnShowAddForm_Click);
            // 
            // ExtraAddrChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 277);
            this.Controls.Add(this._btnShowAddForm);
            this.Controls.Add(this._lbAddresses);
            this.Controls.Add(this._btnSave);
            this.Name = "ExtraAddrChange";
            this.Text = "ExtraAddrChange";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.ListBox _lbAddresses;
        private System.Windows.Forms.Button _btnShowAddForm;
    }
}