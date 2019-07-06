namespace CIS266Project
{
    partial class frmProjectWork
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
            System.Windows.Forms.Label projectStatusLabel;
            System.Windows.Forms.Label desciptionLabel;
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.tbProjectDescription = new System.Windows.Forms.TextBox();
            this.tbProjectStatus = new System.Windows.Forms.TextBox();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            projectStatusLabel = new System.Windows.Forms.Label();
            desciptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 339);
            this.btnFirst.TabIndex = 7;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(93, 339);
            this.btnPrev.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(174, 339);
            this.btnNext.TabIndex = 9;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(255, 339);
            this.btnLast.TabIndex = 10;
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(10, 15);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(74, 13);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "Project Name:";
            // 
            // projectStatusLabel
            // 
            projectStatusLabel.AutoSize = true;
            projectStatusLabel.Location = new System.Drawing.Point(10, 41);
            projectStatusLabel.Name = "projectStatusLabel";
            projectStatusLabel.Size = new System.Drawing.Size(76, 13);
            projectStatusLabel.TabIndex = 2;
            projectStatusLabel.Text = "Project Status:";
            // 
            // desciptionLabel
            // 
            desciptionLabel.AutoSize = true;
            desciptionLabel.Location = new System.Drawing.Point(10, 68);
            desciptionLabel.Name = "desciptionLabel";
            desciptionLabel.Size = new System.Drawing.Size(60, 13);
            desciptionLabel.TabIndex = 4;
            desciptionLabel.Text = "Desciption:";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(93, 12);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.ReadOnly = true;
            this.tbProjectName.Size = new System.Drawing.Size(513, 20);
            this.tbProjectName.TabIndex = 1;
            // 
            // tbProjectDescription
            // 
            this.tbProjectDescription.Location = new System.Drawing.Point(93, 65);
            this.tbProjectDescription.Name = "tbProjectDescription";
            this.tbProjectDescription.ReadOnly = true;
            this.tbProjectDescription.Size = new System.Drawing.Size(513, 20);
            this.tbProjectDescription.TabIndex = 5;
            // 
            // tbProjectStatus
            // 
            this.tbProjectStatus.Location = new System.Drawing.Point(92, 38);
            this.tbProjectStatus.Name = "tbProjectStatus";
            this.tbProjectStatus.ReadOnly = true;
            this.tbProjectStatus.Size = new System.Drawing.Size(513, 20);
            this.tbProjectStatus.TabIndex = 3;
            // 
            // dgvWork
            // 
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Location = new System.Drawing.Point(13, 91);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.ReadOnly = true;
            this.dgvWork.Size = new System.Drawing.Size(592, 242);
            this.dgvWork.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Hours Worked:";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(471, 344);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(35, 13);
            this.lblTotalHours.TabIndex = 12;
            this.lblTotalHours.Text = "label2";
            // 
            // frmProjectWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(617, 371);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWork);
            this.Controls.Add(this.tbProjectStatus);
            this.Controls.Add(desciptionLabel);
            this.Controls.Add(this.tbProjectDescription);
            this.Controls.Add(projectStatusLabel);
            this.Controls.Add(projectNameLabel);
            this.Controls.Add(this.tbProjectName);
            this.Name = "frmProjectWork";
            this.Text = "Work By Project";
            this.Load += new System.EventHandler(this.frmProjectWork_Load);
            this.Controls.SetChildIndex(this.btnFirst, 0);
            this.Controls.SetChildIndex(this.btnPrev, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnLast, 0);
            this.Controls.SetChildIndex(this.tbProjectName, 0);
            this.Controls.SetChildIndex(projectNameLabel, 0);
            this.Controls.SetChildIndex(projectStatusLabel, 0);
            this.Controls.SetChildIndex(this.tbProjectDescription, 0);
            this.Controls.SetChildIndex(desciptionLabel, 0);
            this.Controls.SetChildIndex(this.tbProjectStatus, 0);
            this.Controls.SetChildIndex(this.dgvWork, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTotalHours, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox tbProjectDescription;
        private System.Windows.Forms.TextBox tbProjectStatus;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalHours;
    }
}
