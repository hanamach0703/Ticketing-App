namespace Airline_App
{
    partial class Flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight));
            this.nama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonregis = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.takeOfDate = new System.Windows.Forms.Label();
            this.textBoxFlightCode = new System.Windows.Forms.TextBox();
            this.flighCode = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.source2 = new System.Windows.Forms.Label();
            this.source1 = new System.Windows.Forms.Label();
            this.numOfSeats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.BackColor = System.Drawing.Color.Transparent;
            this.nama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nama.Font = new System.Drawing.Font("MV Boli", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nama.Location = new System.Drawing.Point(274, 24);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(344, 58);
            this.nama.TabIndex = 2;
            this.nama.Text = "HaNCh Airlines";
            this.nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(234, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Record Penerbangan Baru";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonregis
            // 
            this.buttonregis.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonregis.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonregis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonregis.Location = new System.Drawing.Point(424, 589);
            this.buttonregis.Name = "buttonregis";
            this.buttonregis.Size = new System.Drawing.Size(162, 60);
            this.buttonregis.TabIndex = 19;
            this.buttonregis.Text = "Registrasi";
            this.buttonregis.UseVisualStyleBackColor = false;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonlogin.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonlogin.Location = new System.Drawing.Point(234, 589);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(159, 60);
            this.buttonlogin.TabIndex = 18;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 26);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // takeOfDate
            // 
            this.takeOfDate.AutoSize = true;
            this.takeOfDate.BackColor = System.Drawing.Color.Transparent;
            this.takeOfDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeOfDate.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeOfDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.takeOfDate.Location = new System.Drawing.Point(12, 256);
            this.takeOfDate.Name = "takeOfDate";
            this.takeOfDate.Size = new System.Drawing.Size(202, 29);
            this.takeOfDate.TabIndex = 37;
            this.takeOfDate.Text = "Tgl Keberangkatan";
            this.takeOfDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFlightCode
            // 
            this.textBoxFlightCode.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFlightCode.Location = new System.Drawing.Point(215, 178);
            this.textBoxFlightCode.Name = "textBoxFlightCode";
            this.textBoxFlightCode.Size = new System.Drawing.Size(227, 43);
            this.textBoxFlightCode.TabIndex = 36;
            // 
            // flighCode
            // 
            this.flighCode.AutoSize = true;
            this.flighCode.BackColor = System.Drawing.Color.Transparent;
            this.flighCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flighCode.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flighCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.flighCode.Location = new System.Drawing.Point(12, 185);
            this.flighCode.Name = "flighCode";
            this.flighCode.Size = new System.Drawing.Size(199, 29);
            this.flighCode.TabIndex = 35;
            this.flighCode.Text = "Kode Penerbangan";
            this.flighCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(215, 388);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(229, 39);
            this.comboBox2.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 39);
            this.comboBox1.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(215, 463);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 43);
            this.textBox1.TabIndex = 41;
            // 
            // source2
            // 
            this.source2.AutoSize = true;
            this.source2.BackColor = System.Drawing.Color.Transparent;
            this.source2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.source2.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.source2.Location = new System.Drawing.Point(12, 393);
            this.source2.Name = "source2";
            this.source2.Size = new System.Drawing.Size(80, 29);
            this.source2.TabIndex = 40;
            this.source2.Text = "Tujuan";
            this.source2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // source1
            // 
            this.source1.AutoSize = true;
            this.source1.BackColor = System.Drawing.Color.Transparent;
            this.source1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.source1.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.source1.Location = new System.Drawing.Point(12, 317);
            this.source1.Name = "source1";
            this.source1.Size = new System.Drawing.Size(54, 29);
            this.source1.TabIndex = 39;
            this.source1.Text = "Asal";
            this.source1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOfSeats
            // 
            this.numOfSeats.AutoSize = true;
            this.numOfSeats.BackColor = System.Drawing.Color.Transparent;
            this.numOfSeats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numOfSeats.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfSeats.ForeColor = System.Drawing.Color.MidnightBlue;
            this.numOfSeats.Location = new System.Drawing.Point(12, 455);
            this.numOfSeats.Name = "numOfSeats";
            this.numOfSeats.Size = new System.Drawing.Size(183, 58);
            this.numOfSeats.TabIndex = 44;
            this.numOfSeats.Text = "Nomor Tempat \r\nDuduk";
            this.numOfSeats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 696);
            this.Controls.Add(this.numOfSeats);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.source2);
            this.Controls.Add(this.source1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.takeOfDate);
            this.Controls.Add(this.textBoxFlightCode);
            this.Controls.Add(this.flighCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonregis);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Flight";
            this.Text = "Flight";
            this.Load += new System.EventHandler(this.Flight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonregis;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label takeOfDate;
        private System.Windows.Forms.TextBox textBoxFlightCode;
        private System.Windows.Forms.Label flighCode;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label source2;
        private System.Windows.Forms.Label source1;
        private System.Windows.Forms.Label numOfSeats;
    }
}