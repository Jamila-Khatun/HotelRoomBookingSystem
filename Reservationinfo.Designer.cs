namespace HotelManagement
{
    partial class Reservationinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservationinfo));
            this.panel3 = new System.Windows.Forms.Panel();
            this.reDatelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationid = new System.Windows.Forms.TextBox();
            this.reservationgridview = new System.Windows.Forms.DataGridView();
            this.rerefresh = new System.Windows.Forms.PictureBox();
            this.reservationsearch = new System.Windows.Forms.TextBox();
            this.research = new System.Windows.Forms.Button();
            this.datein = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateout = new System.Windows.Forms.DateTimePicker();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.reclient = new System.Windows.Forms.ComboBox();
            this.reroom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rerefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.reDatelbl);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 100);
            this.panel3.TabIndex = 6;
            // 
            // reDatelbl
            // 
            this.reDatelbl.AutoSize = true;
            this.reDatelbl.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reDatelbl.ForeColor = System.Drawing.Color.Navy;
            this.reDatelbl.Location = new System.Drawing.Point(636, 63);
            this.reDatelbl.Name = "reDatelbl";
            this.reDatelbl.Size = new System.Drawing.Size(60, 28);
            this.reDatelbl.TabIndex = 1;
            this.reDatelbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(229, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Information";
            // 
            // reservationid
            // 
            this.reservationid.BackColor = System.Drawing.SystemColors.Control;
            this.reservationid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationid.ForeColor = System.Drawing.Color.Navy;
            this.reservationid.Location = new System.Drawing.Point(71, 158);
            this.reservationid.Name = "reservationid";
            this.reservationid.Size = new System.Drawing.Size(171, 22);
            this.reservationid.TabIndex = 12;
            // 
            // reservationgridview
            // 
            this.reservationgridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.reservationgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationgridview.Location = new System.Drawing.Point(302, 158);
            this.reservationgridview.Name = "reservationgridview";
            this.reservationgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationgridview.Size = new System.Drawing.Size(459, 439);
            this.reservationgridview.TabIndex = 25;
            this.reservationgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationgridview_CellContentClick);
            // 
            // rerefresh
            // 
            this.rerefresh.Image = ((System.Drawing.Image)(resources.GetObject("rerefresh.Image")));
            this.rerefresh.Location = new System.Drawing.Point(661, 126);
            this.rerefresh.Name = "rerefresh";
            this.rerefresh.Size = new System.Drawing.Size(29, 26);
            this.rerefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rerefresh.TabIndex = 28;
            this.rerefresh.TabStop = false;
            this.rerefresh.Click += new System.EventHandler(this.rerefresh_Click);
            // 
            // reservationsearch
            // 
            this.reservationsearch.BackColor = System.Drawing.SystemColors.Control;
            this.reservationsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsearch.ForeColor = System.Drawing.Color.Navy;
            this.reservationsearch.Location = new System.Drawing.Point(450, 130);
            this.reservationsearch.Name = "reservationsearch";
            this.reservationsearch.Size = new System.Drawing.Size(145, 22);
            this.reservationsearch.TabIndex = 27;
            // 
            // research
            // 
            this.research.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.research.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.research.ForeColor = System.Drawing.Color.Navy;
            this.research.Location = new System.Drawing.Point(590, 126);
            this.research.Name = "research";
            this.research.Size = new System.Drawing.Size(75, 30);
            this.research.TabIndex = 26;
            this.research.Text = "Search";
            this.research.UseVisualStyleBackColor = false;
            this.research.Click += new System.EventHandler(this.research_Click);
            // 
            // datein
            // 
            this.datein.CalendarForeColor = System.Drawing.Color.Navy;
            this.datein.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.datein.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.datein.Location = new System.Drawing.Point(99, 352);
            this.datein.Name = "datein";
            this.datein.Size = new System.Drawing.Size(197, 20);
            this.datein.TabIndex = 30;
            this.datein.ValueChanged += new System.EventHandler(this.datein_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(37, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "DateIn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(37, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "DateOut";
            // 
            // dateout
            // 
            this.dateout.CalendarForeColor = System.Drawing.Color.Navy;
            this.dateout.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateout.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.dateout.Location = new System.Drawing.Point(99, 394);
            this.dateout.Name = "dateout";
            this.dateout.Size = new System.Drawing.Size(197, 20);
            this.dateout.TabIndex = 32;
            this.dateout.ValueChanged += new System.EventHandler(this.dateout_ValueChanged);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Navy;
            this.DeleteBtn.Location = new System.Drawing.Point(212, 476);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 30);
            this.DeleteBtn.TabIndex = 36;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.Navy;
            this.EditBtn.Location = new System.Drawing.Point(116, 476);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 30);
            this.EditBtn.TabIndex = 35;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Navy;
            this.AddBtn.Location = new System.Drawing.Point(22, 476);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 30);
            this.AddBtn.TabIndex = 34;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // reclient
            // 
            this.reclient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reclient.ForeColor = System.Drawing.Color.Navy;
            this.reclient.FormattingEnabled = true;
            this.reclient.Location = new System.Drawing.Point(99, 222);
            this.reclient.Name = "reclient";
            this.reclient.Size = new System.Drawing.Size(171, 25);
            this.reclient.TabIndex = 37;
            this.reclient.Text = "Client Name";
            this.reclient.SelectedIndexChanged += new System.EventHandler(this.reclient_SelectedIndexChanged);
            // 
            // reroom
            // 
            this.reroom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reroom.ForeColor = System.Drawing.Color.Navy;
            this.reroom.FormattingEnabled = true;
            this.reroom.Location = new System.Drawing.Point(99, 291);
            this.reroom.Name = "reroom";
            this.reroom.Size = new System.Drawing.Size(171, 25);
            this.reroom.TabIndex = 38;
            this.reroom.Text = "room number";
            this.reroom.SelectedIndexChanged += new System.EventHandler(this.reroom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(37, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(37, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Client";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.back.Location = new System.Drawing.Point(116, 536);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 30);
            this.back.TabIndex = 41;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(113, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Reservation ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(366, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Reservation Id:";
            // 
            // Reservationinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 628);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reroom);
            this.Controls.Add(this.reclient);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datein);
            this.Controls.Add(this.rerefresh);
            this.Controls.Add(this.reservationsearch);
            this.Controls.Add(this.research);
            this.Controls.Add(this.reservationgridview);
            this.Controls.Add(this.reservationid);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservationinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservationinfo";
            this.Load += new System.EventHandler(this.Reservationinfo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rerefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label reDatelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reservationid;
        private System.Windows.Forms.DataGridView reservationgridview;
        private System.Windows.Forms.PictureBox rerefresh;
        private System.Windows.Forms.TextBox reservationsearch;
        private System.Windows.Forms.Button research;
        private System.Windows.Forms.DateTimePicker datein;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateout;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox reclient;
        private System.Windows.Forms.ComboBox reroom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}