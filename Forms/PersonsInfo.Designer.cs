
namespace WindowsForm.Forms
{
    partial class PersonsInfo
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
            this.gbxSidebar = new System.Windows.Forms.GroupBox();
            this.gbxSave = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgwPersons = new System.Windows.Forms.DataGridView();
            this.gbxSidebar.SuspendLayout();
            this.gbxSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSidebar
            // 
            this.gbxSidebar.Controls.Add(this.gbxSave);
            this.gbxSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxSidebar.Location = new System.Drawing.Point(0, 0);
            this.gbxSidebar.Name = "gbxSidebar";
            this.gbxSidebar.Size = new System.Drawing.Size(222, 533);
            this.gbxSidebar.TabIndex = 0;
            this.gbxSidebar.TabStop = false;
            // 
            // gbxSave
            // 
            this.gbxSave.Controls.Add(this.btnSave);
            this.gbxSave.Controls.Add(this.tbxSurname);
            this.gbxSave.Controls.Add(this.lblSurname);
            this.gbxSave.Controls.Add(this.tbxAge);
            this.gbxSave.Controls.Add(this.lblAge);
            this.gbxSave.Controls.Add(this.tbxName);
            this.gbxSave.Controls.Add(this.lblName);
            this.gbxSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxSave.Location = new System.Drawing.Point(3, 16);
            this.gbxSave.Name = "gbxSave";
            this.gbxSave.Size = new System.Drawing.Size(216, 239);
            this.gbxSave.TabIndex = 0;
            this.gbxSave.TabStop = false;
            this.gbxSave.Text = "Save";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(100, 78);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 9;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(9, 81);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(100, 119);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 20);
            this.tbxAge.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 122);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(100, 37);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // dgwPersons
            // 
            this.dgwPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPersons.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwPersons.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgwPersons.Location = new System.Drawing.Point(222, 0);
            this.dgwPersons.Name = "dgwPersons";
            this.dgwPersons.Size = new System.Drawing.Size(1001, 533);
            this.dgwPersons.TabIndex = 3;
            this.dgwPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersons_CellClick);
            // 
            // PersonsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 533);
            this.Controls.Add(this.dgwPersons);
            this.Controls.Add(this.gbxSidebar);
            this.Name = "PersonsInfo";
            this.Text = "PersonsInfo";
            this.Load += new System.EventHandler(this.PersonsInfo_Load);
            this.gbxSidebar.ResumeLayout(false);
            this.gbxSave.ResumeLayout(false);
            this.gbxSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSidebar;
        private System.Windows.Forms.DataGridView dgwPersons;
        private System.Windows.Forms.GroupBox gbxSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
    }
}