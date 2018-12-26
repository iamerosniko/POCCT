namespace FrontEnd
{
    partial class Main
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
            this.GridCalls = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GridCallCategories = new System.Windows.Forms.DataGridView();
            this.GridCallerAssocs = new System.Windows.Forms.DataGridView();
            this.GridCallStatuses = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCallCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCallerAssocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCallStatuses)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCalls
            // 
            this.GridCalls.AllowUserToAddRows = false;
            this.GridCalls.AllowUserToDeleteRows = false;
            this.GridCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCalls.Location = new System.Drawing.Point(12, 38);
            this.GridCalls.Name = "GridCalls";
            this.GridCalls.ReadOnly = true;
            this.GridCalls.Size = new System.Drawing.Size(475, 242);
            this.GridCalls.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Call data";
            // 
            // GridCallCategories
            // 
            this.GridCallCategories.AllowUserToAddRows = false;
            this.GridCallCategories.AllowUserToDeleteRows = false;
            this.GridCallCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCallCategories.Location = new System.Drawing.Point(498, 38);
            this.GridCallCategories.Name = "GridCallCategories";
            this.GridCallCategories.ReadOnly = true;
            this.GridCallCategories.Size = new System.Drawing.Size(482, 242);
            this.GridCallCategories.TabIndex = 2;
            // 
            // GridCallerAssocs
            // 
            this.GridCallerAssocs.AllowUserToAddRows = false;
            this.GridCallerAssocs.AllowUserToDeleteRows = false;
            this.GridCallerAssocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCallerAssocs.Location = new System.Drawing.Point(12, 317);
            this.GridCallerAssocs.Name = "GridCallerAssocs";
            this.GridCallerAssocs.ReadOnly = true;
            this.GridCallerAssocs.Size = new System.Drawing.Size(475, 242);
            this.GridCallerAssocs.TabIndex = 3;
            // 
            // GridCallStatuses
            // 
            this.GridCallStatuses.AllowUserToAddRows = false;
            this.GridCallStatuses.AllowUserToDeleteRows = false;
            this.GridCallStatuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCallStatuses.Location = new System.Drawing.Point(498, 317);
            this.GridCallStatuses.Name = "GridCallStatuses";
            this.GridCallStatuses.ReadOnly = true;
            this.GridCallStatuses.Size = new System.Drawing.Size(482, 242);
            this.GridCallStatuses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caller Assocs Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Call statuses Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Call Categories Data";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 573);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridCallStatuses);
            this.Controls.Add(this.GridCallerAssocs);
            this.Controls.Add(this.GridCallCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridCalls);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCallCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCallerAssocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCallStatuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridCallCategories;
        private System.Windows.Forms.DataGridView GridCallerAssocs;
        private System.Windows.Forms.DataGridView GridCallStatuses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

