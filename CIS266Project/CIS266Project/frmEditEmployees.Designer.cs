namespace CIS266Project
{
    partial class frmEditEmployees
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
        protected void InitializeComponent()
        {
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label label1;
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(259, 12);
            this.btnAdd.TabIndex = 12;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(259, 41);
            this.btnEdit.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 70);
            this.btnDelete.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 99);
            this.btnSave.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 128);
            this.btnCancel.TabIndex = 16;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 169);
            this.btnFirst.TabIndex = 8;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(93, 169);
            this.btnPrev.TabIndex = 9;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(174, 169);
            this.btnNext.TabIndex = 10;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(255, 169);
            this.btnLast.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(41, 48);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(41, 74);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(41, 100);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(41, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 13);
            label1.TabIndex = 0;
            label1.Text = "EmployeeID:";
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(117, 45);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(100, 20);
            this.tbFirst.TabIndex = 3;
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(117, 71);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 5;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(117, 97);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 20);
            this.tbTitle.TabIndex = 7;
            // 
            // tbEmpID
            // 
            this.tbEmpID.Enabled = false;
            this.tbEmpID.Location = new System.Drawing.Point(117, 19);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.ReadOnly = true;
            this.tbEmpID.Size = new System.Drawing.Size(100, 20);
            this.tbEmpID.TabIndex = 1;
            // 
            // frmEditEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(346, 205);
            this.Controls.Add(label1);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.tbTitle);
            this.Name = "frmEditEmployees";
            this.Text = "Edit Employees";
            this.Load += new System.EventHandler(this.frmEditEmployees_Load);
            this.Controls.SetChildIndex(this.tbTitle, 0);
            this.Controls.SetChildIndex(titleLabel, 0);
            this.Controls.SetChildIndex(this.tbLast, 0);
            this.Controls.SetChildIndex(lastNameLabel, 0);
            this.Controls.SetChildIndex(this.tbFirst, 0);
            this.Controls.SetChildIndex(firstNameLabel, 0);
            this.Controls.SetChildIndex(this.btnFirst, 0);
            this.Controls.SetChildIndex(this.btnPrev, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnLast, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tbEmpID, 0);
            this.Controls.SetChildIndex(label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbEmpID;
    }
}
