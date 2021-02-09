
namespace Example.WinformNET5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVDeveloper = new System.Windows.Forms.DataGridView();
            this.BtnGetAllDeveloper = new System.Windows.Forms.Button();
            this.DGVProject = new System.Windows.Forms.DataGridView();
            this.BtnGetAllProject = new System.Windows.Forms.Button();
            this.BtnWithoutDI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDeveloper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDeveloper
            // 
            this.DGVDeveloper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDeveloper.Location = new System.Drawing.Point(12, 12);
            this.DGVDeveloper.Name = "DGVDeveloper";
            this.DGVDeveloper.RowTemplate.Height = 25;
            this.DGVDeveloper.Size = new System.Drawing.Size(411, 248);
            this.DGVDeveloper.TabIndex = 0;
            // 
            // BtnGetAllDeveloper
            // 
            this.BtnGetAllDeveloper.Location = new System.Drawing.Point(150, 265);
            this.BtnGetAllDeveloper.Name = "BtnGetAllDeveloper";
            this.BtnGetAllDeveloper.Size = new System.Drawing.Size(116, 23);
            this.BtnGetAllDeveloper.TabIndex = 1;
            this.BtnGetAllDeveloper.Text = "Get All Developer";
            this.BtnGetAllDeveloper.UseVisualStyleBackColor = true;
            this.BtnGetAllDeveloper.Click += new System.EventHandler(this.BtnGetAllDeveloper_Click);
            // 
            // DGVProject
            // 
            this.DGVProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProject.Location = new System.Drawing.Point(444, 12);
            this.DGVProject.Name = "DGVProject";
            this.DGVProject.RowTemplate.Height = 25;
            this.DGVProject.Size = new System.Drawing.Size(411, 248);
            this.DGVProject.TabIndex = 2;
            // 
            // BtnGetAllProject
            // 
            this.BtnGetAllProject.Location = new System.Drawing.Point(600, 264);
            this.BtnGetAllProject.Name = "BtnGetAllProject";
            this.BtnGetAllProject.Size = new System.Drawing.Size(107, 23);
            this.BtnGetAllProject.TabIndex = 3;
            this.BtnGetAllProject.Text = "Get All Project";
            this.BtnGetAllProject.UseVisualStyleBackColor = true;
            this.BtnGetAllProject.Click += new System.EventHandler(this.BtnGetAllProject_Click);
            // 
            // BtnWithoutDI
            // 
            this.BtnWithoutDI.Location = new System.Drawing.Point(369, 299);
            this.BtnWithoutDI.Name = "BtnWithoutDI";
            this.BtnWithoutDI.Size = new System.Drawing.Size(139, 23);
            this.BtnWithoutDI.TabIndex = 4;
            this.BtnWithoutDI.Text = "Form Without DI";
            this.BtnWithoutDI.UseVisualStyleBackColor = true;
            this.BtnWithoutDI.Click += new System.EventHandler(this.BtnWithoutDI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 334);
            this.Controls.Add(this.BtnWithoutDI);
            this.Controls.Add(this.BtnGetAllProject);
            this.Controls.Add(this.DGVProject);
            this.Controls.Add(this.BtnGetAllDeveloper);
            this.Controls.Add(this.DGVDeveloper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDeveloper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDeveloper;
        private System.Windows.Forms.Button BtnGetAllDeveloper;
        private System.Windows.Forms.DataGridView DGVProject;
        private System.Windows.Forms.Button BtnGetAllProject;
        private System.Windows.Forms.Button BtnWithoutDI;
    }
}

