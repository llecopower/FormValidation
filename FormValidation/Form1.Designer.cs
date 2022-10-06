namespace FormValidation
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
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.listBoxNumber = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(82, 46);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(84, 16);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Type your ID";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(85, 80);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(174, 22);
            this.textBoxNumber.TabIndex = 1;
            // 
            // listBoxNumber
            // 
            this.listBoxNumber.FormattingEnabled = true;
            this.listBoxNumber.ItemHeight = 16;
            this.listBoxNumber.Location = new System.Drawing.Point(85, 135);
            this.listBoxNumber.Name = "listBoxNumber";
            this.listBoxNumber.Size = new System.Drawing.Size(290, 132);
            this.listBoxNumber.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(275, 51);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 51);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 335);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Text = "ID Identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ListBox listBoxNumber;
        private System.Windows.Forms.Button buttonAdd;
    }
}

