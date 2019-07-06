namespace CIS266Project
{
    partial class frmEditProjectInfo
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
            System.Windows.Forms.Label projectNameLabel;
            System.Windows.Forms.Label desciptionLabel;
            System.Windows.Forms.Label projectStartLabel;
            System.Windows.Forms.Label projectStatusLabel1;
            System.Windows.Forms.Label projectManagerLabel;
            System.Windows.Forms.Label projectIDLabel;
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbProjectStatus = new System.Windows.Forms.ComboBox();
            this.cbProjectManager = new System.Windows.Forms.ComboBox();
            this.tbProjectID = new System.Windows.Forms.TextBox();
            this.mtbEndDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            desciptionLabel = new System.Windows.Forms.Label();
            projectStartLabel = new System.Windows.Forms.Label();
            projectStatusLabel1 = new System.Windows.Forms.Label();
            projectManagerLabel = new System.Windows.Forms.Label();
            projectIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(342, 12);
            this.btnAdd.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(342, 41);
            this.btnEdit.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(342, 70);
            this.btnDelete.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(342, 99);
            this.btnSave.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 128);
            this.btnCancel.TabIndex = 22;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 208);
            this.btnFirst.TabIndex = 14;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(93, 208);
            this.btnPrev.TabIndex = 15;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(174, 208);
            this.btnNext.TabIndex = 16;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(255, 208);
            this.btnLast.TabIndex = 17;
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(9, 39);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(74, 13);
            projectNameLabel.TabIndex = 2;
            projectNameLabel.Text = "Project Name:";
            // 
            // desciptionLabel
            // 
            desciptionLabel.AutoSize = true;
            desciptionLabel.Location = new System.Drawing.Point(9, 119);
            desciptionLabel.Name = "desciptionLabel";
            desciptionLabel.Size = new System.Drawing.Size(60, 13);
            desciptionLabel.TabIndex = 8;
            desciptionLabel.Text = "Desciption:";
            // 
            // projectStartLabel
            // 
            projectStartLabel.AutoSize = true;
            projectStartLabel.Location = new System.Drawing.Point(9, 148);
            projectStartLabel.Name = "projectStartLabel";
            projectStartLabel.Size = new System.Drawing.Size(68, 13);
            projectStartLabel.TabIndex = 10;
            projectStartLabel.Text = "Project Start:";
            // 
            // projectStatusLabel1
            // 
            projectStatusLabel1.AutoSize = true;
            projectStatusLabel1.Location = new System.Drawing.Point(9, 92);
            projectStatusLabel1.Name = "projectStatusLabel1";
            projectStatusLabel1.Size = new System.Drawing.Size(76, 13);
            projectStatusLabel1.TabIndex = 6;
            projectStatusLabel1.Text = "Project Status:";
            // 
            // projectManagerLabel
            // 
            projectManagerLabel.AutoSize = true;
            projectManagerLabel.Location = new System.Drawing.Point(9, 65);
            projectManagerLabel.Name = "projectManagerLabel";
            projectManagerLabel.Size = new System.Drawing.Size(88, 13);
            projectManagerLabel.TabIndex = 4;
            projectManagerLabel.Text = "Project Manager:";
            // 
            // projectIDLabel
            // 
            projectIDLabel.AutoSize = true;
            projectIDLabel.Location = new System.Drawing.Point(12, 13);
            projectIDLabel.Name = "projectIDLabel";
            projectIDLabel.Size = new System.Drawing.Size(57, 13);
            projectIDLabel.TabIndex = 0;
            projectIDLabel.Text = "Project ID:";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(106, 36);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(200, 20);
            this.tbProjectName.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(106, 116);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(200, 20);
            this.tbDescription.TabIndex = 9;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(106, 142);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 11;
            // 
            // cbProjectStatus
            // 
            this.cbProjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectStatus.FormattingEnabled = true;
            this.cbProjectStatus.Location = new System.Drawing.Point(106, 89);
            this.cbProjectStatus.Name = "cbProjectStatus";
            this.cbProjectStatus.Size = new System.Drawing.Size(200, 21);
            this.cbProjectStatus.TabIndex = 7;
            // 
            // cbProjectManager
            // 
            this.cbProjectManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjectManager.FormattingEnabled = true;
            this.cbProjectManager.Location = new System.Drawing.Point(106, 62);
            this.cbProjectManager.Name = "cbProjectManager";
            this.cbProjectManager.Size = new System.Drawing.Size(200, 21);
            this.cbProjectManager.TabIndex = 5;
            // 
            // tbProjectID
            // 
            this.tbProjectID.Enabled = false;
            this.tbProjectID.Location = new System.Drawing.Point(106, 10);
            this.tbProjectID.Name = "tbProjectID";
            this.tbProjectID.Size = new System.Drawing.Size(200, 20);
            this.tbProjectID.TabIndex = 1;
            // 
            // mtbEndDate
            // 
            this.mtbEndDate.Location = new System.Drawing.Point(106, 168);
            this.mtbEndDate.Name = "mtbEndDate";
            this.mtbEndDate.Size = new System.Drawing.Size(200, 20);
            this.mtbEndDate.TabIndex = 13;
            this.mtbEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Project End:";
            // 
            // frmEditProjectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(431, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbEndDate);
            this.Controls.Add(projectIDLabel);
            this.Controls.Add(this.tbProjectID);
            this.Controls.Add(projectManagerLabel);
            this.Controls.Add(this.cbProjectManager);
            this.Controls.Add(projectStatusLabel1);
            this.Controls.Add(this.cbProjectStatus);
            this.Controls.Add(projectNameLabel);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(desciptionLabel);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(projectStartLabel);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "frmEditProjectInfo";
            this.Text = "Edit Project";
            this.Load += new System.EventHandler(this.frmEditProjectInfo_Load);
            this.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.Controls.SetChildIndex(projectStartLabel, 0);
            this.Controls.SetChildIndex(this.tbDescription, 0);
            this.Controls.SetChildIndex(desciptionLabel, 0);
            this.Controls.SetChildIndex(this.tbProjectName, 0);
            this.Controls.SetChildIndex(projectNameLabel, 0);
            this.Controls.SetChildIndex(this.cbProjectStatus, 0);
            this.Controls.SetChildIndex(projectStatusLabel1, 0);
            this.Controls.SetChildIndex(this.cbProjectManager, 0);
            this.Controls.SetChildIndex(projectManagerLabel, 0);
            this.Controls.SetChildIndex(this.btnFirst, 0);
            this.Controls.SetChildIndex(this.btnPrev, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnLast, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tbProjectID, 0);
            this.Controls.SetChildIndex(projectIDLabel, 0);
            this.Controls.SetChildIndex(this.mtbEndDate, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbProjectStatus;
        private System.Windows.Forms.ComboBox cbProjectManager;
        private System.Windows.Forms.TextBox tbProjectID;
        private System.Windows.Forms.MaskedTextBox mtbEndDate;
        private System.Windows.Forms.Label label1;
    }
}
