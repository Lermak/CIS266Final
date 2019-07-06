namespace CIS266Project
{
    partial class frmTasks
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
            System.Windows.Forms.Label projectIDLabel;
            System.Windows.Forms.Label projectNameLabel;
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.tbProjectID = new System.Windows.Forms.TextBox();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            projectIDLabel = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 256);
            this.btnFirst.TabIndex = 5;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(93, 256);
            this.btnPrev.TabIndex = 6;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(174, 256);
            this.btnNext.TabIndex = 7;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(255, 256);
            this.btnLast.TabIndex = 8;
            // 
            // projectIDLabel
            // 
            projectIDLabel.AutoSize = true;
            projectIDLabel.Location = new System.Drawing.Point(13, 9);
            projectIDLabel.Name = "projectIDLabel";
            projectIDLabel.Size = new System.Drawing.Size(57, 13);
            projectIDLabel.TabIndex = 0;
            projectIDLabel.Text = "Project ID:";
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(13, 35);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(74, 13);
            projectNameLabel.TabIndex = 2;
            projectNameLabel.Text = "Project Name:";
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(12, 58);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.Size = new System.Drawing.Size(545, 192);
            this.dgvTasks.TabIndex = 4;
            // 
            // tbProjectID
            // 
            this.tbProjectID.Location = new System.Drawing.Point(93, 6);
            this.tbProjectID.Name = "tbProjectID";
            this.tbProjectID.ReadOnly = true;
            this.tbProjectID.Size = new System.Drawing.Size(464, 20);
            this.tbProjectID.TabIndex = 1;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(93, 32);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.ReadOnly = true;
            this.tbProjectName.Size = new System.Drawing.Size(464, 20);
            this.tbProjectName.TabIndex = 3;
            // 
            // frmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(577, 288);
            this.Controls.Add(projectNameLabel);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(projectIDLabel);
            this.Controls.Add(this.tbProjectID);
            this.Controls.Add(this.dgvTasks);
            this.Name = "frmTasks";
            this.Text = "Task Status By Project";
            this.Load += new System.EventHandler(this.frmTasks_Load);
            this.Controls.SetChildIndex(this.btnFirst, 0);
            this.Controls.SetChildIndex(this.btnPrev, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnLast, 0);
            this.Controls.SetChildIndex(this.dgvTasks, 0);
            this.Controls.SetChildIndex(this.tbProjectID, 0);
            this.Controls.SetChildIndex(projectIDLabel, 0);
            this.Controls.SetChildIndex(this.tbProjectName, 0);
            this.Controls.SetChildIndex(projectNameLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.TextBox tbProjectID;
        private System.Windows.Forms.TextBox tbProjectName;
    }
}
