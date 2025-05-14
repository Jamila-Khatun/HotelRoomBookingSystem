namespace HotelManagement
{
    partial class Staffinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staffinfo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.stDatelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.staffnametbl = new System.Windows.Forms.TextBox();
            this.stphonenumbertbl = new System.Windows.Forms.TextBox();
            this.staffidtbl = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.gendertbl = new System.Windows.Forms.ComboBox();
            this.staffrefresh = new System.Windows.Forms.PictureBox();
            this.Staffgridview = new System.Windows.Forms.DataGridView();
            this.staffsearchtbl = new System.Windows.Forms.TextBox();
            this.staffsearch = new System.Windows.Forms.Button();
            this.staffpasstb = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staffgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.stDatelbl);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 100);
            this.panel3.TabIndex = 4;
            // 
            // stDatelbl
            // 
            this.stDatelbl.AutoSize = true;
            this.stDatelbl.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stDatelbl.ForeColor = System.Drawing.Color.Navy;
            this.stDatelbl.Location = new System.Drawing.Point(636, 63);
            this.stDatelbl.Name = "stDatelbl";
            this.stDatelbl.Size = new System.Drawing.Size(60, 28);
            this.stDatelbl.TabIndex = 1;
            this.stDatelbl.Text = "Date";
            this.stDatelbl.Click += new System.EventHandler(this.stDatelbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(269, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Information";
            // 
            // staffnametbl
            // 
            this.staffnametbl.BackColor = System.Drawing.SystemColors.Control;
            this.staffnametbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnametbl.ForeColor = System.Drawing.Color.Navy;
            this.staffnametbl.Location = new System.Drawing.Point(62, 235);
            this.staffnametbl.Name = "staffnametbl";
            this.staffnametbl.Size = new System.Drawing.Size(171, 22);
            this.staffnametbl.TabIndex = 9;
            // 
            // stphonenumbertbl
            // 
            this.stphonenumbertbl.BackColor = System.Drawing.SystemColors.Control;
            this.stphonenumbertbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stphonenumbertbl.ForeColor = System.Drawing.Color.Navy;
            this.stphonenumbertbl.Location = new System.Drawing.Point(62, 302);
            this.stphonenumbertbl.Name = "stphonenumbertbl";
            this.stphonenumbertbl.Size = new System.Drawing.Size(171, 22);
            this.stphonenumbertbl.TabIndex = 8;
            this.stphonenumbertbl.TextChanged += new System.EventHandler(this.stphonenumbertbl_TextChanged);
            // 
            // staffidtbl
            // 
            this.staffidtbl.BackColor = System.Drawing.SystemColors.Control;
            this.staffidtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffidtbl.ForeColor = System.Drawing.Color.Navy;
            this.staffidtbl.Location = new System.Drawing.Point(62, 169);
            this.staffidtbl.Name = "staffidtbl";
            this.staffidtbl.Size = new System.Drawing.Size(171, 22);
            this.staffidtbl.TabIndex = 7;
            this.staffidtbl.TextChanged += new System.EventHandler(this.staffidtbl_TextChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Navy;
            this.DeleteBtn.Location = new System.Drawing.Point(205, 511);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 30);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.Navy;
            this.EditBtn.Location = new System.Drawing.Point(109, 511);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 30);
            this.EditBtn.TabIndex = 14;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Navy;
            this.AddBtn.Location = new System.Drawing.Point(15, 511);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 30);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // gendertbl
            // 
            this.gendertbl.BackColor = System.Drawing.SystemColors.Control;
            this.gendertbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendertbl.ForeColor = System.Drawing.Color.Navy;
            this.gendertbl.FormattingEnabled = true;
            this.gendertbl.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gendertbl.Location = new System.Drawing.Point(62, 424);
            this.gendertbl.Name = "gendertbl";
            this.gendertbl.Size = new System.Drawing.Size(171, 24);
            this.gendertbl.TabIndex = 16;
            this.gendertbl.Text = "Gender";
            this.gendertbl.SelectedIndexChanged += new System.EventHandler(this.gendertbl_SelectedIndexChanged);
            // 
            // staffrefresh
            // 
            this.staffrefresh.Image = ((System.Drawing.Image)(resources.GetObject("staffrefresh.Image")));
            this.staffrefresh.Location = new System.Drawing.Point(654, 137);
            this.staffrefresh.Name = "staffrefresh";
            this.staffrefresh.Size = new System.Drawing.Size(29, 26);
            this.staffrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staffrefresh.TabIndex = 20;
            this.staffrefresh.TabStop = false;
            this.staffrefresh.Click += new System.EventHandler(this.staffrefresh_Click);
            // 
            // Staffgridview
            // 
            this.Staffgridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Staffgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Staffgridview.Location = new System.Drawing.Point(286, 169);
            this.Staffgridview.Name = "Staffgridview";
            this.Staffgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Staffgridview.Size = new System.Drawing.Size(502, 439);
            this.Staffgridview.TabIndex = 19;
            this.Staffgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Staffgridview_CellContentClick);
            // 
            // staffsearchtbl
            // 
            this.staffsearchtbl.BackColor = System.Drawing.SystemColors.Control;
            this.staffsearchtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsearchtbl.ForeColor = System.Drawing.Color.Navy;
            this.staffsearchtbl.Location = new System.Drawing.Point(443, 141);
            this.staffsearchtbl.Name = "staffsearchtbl";
            this.staffsearchtbl.Size = new System.Drawing.Size(145, 22);
            this.staffsearchtbl.TabIndex = 18;
            this.staffsearchtbl.TextChanged += new System.EventHandler(this.clientsearchtbl_TextChanged);
            // 
            // staffsearch
            // 
            this.staffsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.staffsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsearch.ForeColor = System.Drawing.Color.Navy;
            this.staffsearch.Location = new System.Drawing.Point(583, 137);
            this.staffsearch.Name = "staffsearch";
            this.staffsearch.Size = new System.Drawing.Size(75, 30);
            this.staffsearch.TabIndex = 17;
            this.staffsearch.Text = "Search";
            this.staffsearch.UseVisualStyleBackColor = false;
            this.staffsearch.Click += new System.EventHandler(this.staffsearch_Click);
            // 
            // staffpasstb
            // 
            this.staffpasstb.BackColor = System.Drawing.SystemColors.Control;
            this.staffpasstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffpasstb.ForeColor = System.Drawing.Color.Navy;
            this.staffpasstb.Location = new System.Drawing.Point(62, 367);
            this.staffpasstb.Name = "staffpasstb";
            this.staffpasstb.Size = new System.Drawing.Size(171, 22);
            this.staffpasstb.TabIndex = 21;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.back.Location = new System.Drawing.Point(109, 568);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 30);
            this.back.TabIndex = 42;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(59, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(59, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(59, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Staff Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(59, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Staff Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(362, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Staff Search:\r\n";
            // 
            // Staffinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.staffpasstb);
            this.Controls.Add(this.staffrefresh);
            this.Controls.Add(this.Staffgridview);
            this.Controls.Add(this.staffsearchtbl);
            this.Controls.Add(this.staffsearch);
            this.Controls.Add(this.gendertbl);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.staffnametbl);
            this.Controls.Add(this.stphonenumbertbl);
            this.Controls.Add(this.staffidtbl);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staffinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staffinfo";
            this.Load += new System.EventHandler(this.Staffinfo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Staffgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label stDatelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staffnametbl;
        private System.Windows.Forms.TextBox stphonenumbertbl;
        private System.Windows.Forms.TextBox staffidtbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox gendertbl;
        private System.Windows.Forms.PictureBox staffrefresh;
        private System.Windows.Forms.DataGridView Staffgridview;
        private System.Windows.Forms.TextBox staffsearchtbl;
        private System.Windows.Forms.Button staffsearch;
        private System.Windows.Forms.TextBox staffpasstb;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        // private Bunifu.Utils.DgvStyler dgvStyler1;
    }
}