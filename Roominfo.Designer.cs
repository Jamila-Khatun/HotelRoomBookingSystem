namespace HotelManagement
{
    partial class Roominfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roominfo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.stDatelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomphonetbl = new System.Windows.Forms.TextBox();
            this.roomidtbl = new System.Windows.Forms.TextBox();
            this.yesradio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noradio = new System.Windows.Forms.RadioButton();
            this.roomrefresh = new System.Windows.Forms.PictureBox();
            this.roomgridview = new System.Windows.Forms.DataGridView();
            this.roomsearchtbl = new System.Windows.Forms.TextBox();
            this.roomsearch = new System.Windows.Forms.Button();
            this.DeleteroomBtn = new System.Windows.Forms.Button();
            this.EditroomBtn = new System.Windows.Forms.Button();
            this.AddroomBtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomgridview)).BeginInit();
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
            this.panel3.TabIndex = 5;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(269, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rooms Informations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(51, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Free";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // roomphonetbl
            // 
            this.roomphonetbl.BackColor = System.Drawing.SystemColors.Control;
            this.roomphonetbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomphonetbl.ForeColor = System.Drawing.Color.Navy;
            this.roomphonetbl.Location = new System.Drawing.Point(55, 276);
            this.roomphonetbl.Name = "roomphonetbl";
            this.roomphonetbl.Size = new System.Drawing.Size(171, 22);
            this.roomphonetbl.TabIndex = 11;
            // 
            // roomidtbl
            // 
            this.roomidtbl.BackColor = System.Drawing.SystemColors.Control;
            this.roomidtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomidtbl.ForeColor = System.Drawing.Color.Navy;
            this.roomidtbl.Location = new System.Drawing.Point(55, 210);
            this.roomidtbl.Name = "roomidtbl";
            this.roomidtbl.Size = new System.Drawing.Size(171, 22);
            this.roomidtbl.TabIndex = 10;
            this.roomidtbl.TextChanged += new System.EventHandler(this.roomidtbl_TextChanged);
            // 
            // yesradio
            // 
            this.yesradio.AutoSize = true;
            this.yesradio.BackColor = System.Drawing.SystemColors.Control;
            this.yesradio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yesradio.Location = new System.Drawing.Point(102, 345);
            this.yesradio.Name = "yesradio";
            this.yesradio.Size = new System.Drawing.Size(25, 17);
            this.yesradio.TabIndex = 12;
            this.yesradio.TabStop = true;
            this.yesradio.Text = "\r\n";
            this.yesradio.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(117, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Yes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(183, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "No";
            // 
            // noradio
            // 
            this.noradio.AutoSize = true;
            this.noradio.BackColor = System.Drawing.SystemColors.Control;
            this.noradio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noradio.Location = new System.Drawing.Point(168, 345);
            this.noradio.Name = "noradio";
            this.noradio.Size = new System.Drawing.Size(25, 17);
            this.noradio.TabIndex = 14;
            this.noradio.TabStop = true;
            this.noradio.Text = "\r\n";
            this.noradio.UseVisualStyleBackColor = false;
            // 
            // roomrefresh
            // 
            this.roomrefresh.Image = ((System.Drawing.Image)(resources.GetObject("roomrefresh.Image")));
            this.roomrefresh.Location = new System.Drawing.Point(650, 111);
            this.roomrefresh.Name = "roomrefresh";
            this.roomrefresh.Size = new System.Drawing.Size(29, 26);
            this.roomrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roomrefresh.TabIndex = 24;
            this.roomrefresh.TabStop = false;
            this.roomrefresh.Click += new System.EventHandler(this.roomrefresh_Click);
            // 
            // roomgridview
            // 
            this.roomgridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roomgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomgridview.Location = new System.Drawing.Point(305, 143);
            this.roomgridview.Name = "roomgridview";
            this.roomgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomgridview.Size = new System.Drawing.Size(483, 439);
            this.roomgridview.TabIndex = 23;
            this.roomgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomgridview_CellContentClick);
            // 
            // roomsearchtbl
            // 
            this.roomsearchtbl.BackColor = System.Drawing.SystemColors.Control;
            this.roomsearchtbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsearchtbl.ForeColor = System.Drawing.Color.Navy;
            this.roomsearchtbl.Location = new System.Drawing.Point(439, 115);
            this.roomsearchtbl.Name = "roomsearchtbl";
            this.roomsearchtbl.Size = new System.Drawing.Size(145, 22);
            this.roomsearchtbl.TabIndex = 22;
            // 
            // roomsearch
            // 
            this.roomsearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roomsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsearch.ForeColor = System.Drawing.Color.Navy;
            this.roomsearch.Location = new System.Drawing.Point(579, 111);
            this.roomsearch.Name = "roomsearch";
            this.roomsearch.Size = new System.Drawing.Size(75, 30);
            this.roomsearch.TabIndex = 21;
            this.roomsearch.Text = "Search";
            this.roomsearch.UseVisualStyleBackColor = false;
            this.roomsearch.Click += new System.EventHandler(this.roomsearch_Click);
            // 
            // DeleteroomBtn
            // 
            this.DeleteroomBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteroomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteroomBtn.ForeColor = System.Drawing.Color.Navy;
            this.DeleteroomBtn.Location = new System.Drawing.Point(224, 410);
            this.DeleteroomBtn.Name = "DeleteroomBtn";
            this.DeleteroomBtn.Size = new System.Drawing.Size(75, 30);
            this.DeleteroomBtn.TabIndex = 27;
            this.DeleteroomBtn.Text = "DELETE";
            this.DeleteroomBtn.UseVisualStyleBackColor = false;
            this.DeleteroomBtn.Click += new System.EventHandler(this.DeleteroomBtn_Click);
            // 
            // EditroomBtn
            // 
            this.EditroomBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditroomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditroomBtn.ForeColor = System.Drawing.Color.Navy;
            this.EditroomBtn.Location = new System.Drawing.Point(128, 410);
            this.EditroomBtn.Name = "EditroomBtn";
            this.EditroomBtn.Size = new System.Drawing.Size(75, 30);
            this.EditroomBtn.TabIndex = 26;
            this.EditroomBtn.Text = "EDIT";
            this.EditroomBtn.UseVisualStyleBackColor = false;
            this.EditroomBtn.Click += new System.EventHandler(this.EditroomBtn_Click);
            // 
            // AddroomBtn
            // 
            this.AddroomBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddroomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddroomBtn.ForeColor = System.Drawing.Color.Navy;
            this.AddroomBtn.Location = new System.Drawing.Point(34, 410);
            this.AddroomBtn.Name = "AddroomBtn";
            this.AddroomBtn.Size = new System.Drawing.Size(75, 30);
            this.AddroomBtn.TabIndex = 25;
            this.AddroomBtn.Text = "ADD";
            this.AddroomBtn.UseVisualStyleBackColor = false;
            this.AddroomBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.back.Location = new System.Drawing.Point(128, 476);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 30);
            this.back.TabIndex = 42;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(52, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Room Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(52, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Room Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(358, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Room Number:";
            // 
            // Roominfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back);
            this.Controls.Add(this.DeleteroomBtn);
            this.Controls.Add(this.EditroomBtn);
            this.Controls.Add(this.AddroomBtn);
            this.Controls.Add(this.roomrefresh);
            this.Controls.Add(this.roomgridview);
            this.Controls.Add(this.roomsearchtbl);
            this.Controls.Add(this.roomsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noradio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yesradio);
            this.Controls.Add(this.roomphonetbl);
            this.Controls.Add(this.roomidtbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Roominfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roominfo";
            this.Load += new System.EventHandler(this.Roominfo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label stDatelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomphonetbl;
        private System.Windows.Forms.TextBox roomidtbl;
        private System.Windows.Forms.RadioButton yesradio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton noradio;
        private System.Windows.Forms.PictureBox roomrefresh;
        private System.Windows.Forms.DataGridView roomgridview;
        private System.Windows.Forms.TextBox roomsearchtbl;
        private System.Windows.Forms.Button roomsearch;
        private System.Windows.Forms.Button DeleteroomBtn;
        private System.Windows.Forms.Button EditroomBtn;
        private System.Windows.Forms.Button AddroomBtn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}