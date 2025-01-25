namespace WindowsProgramDesign
{
    partial class ReceptionistMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnviewprofile = new System.Windows.Forms.Button();
            this.btnTrainers = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrainingSession = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 149);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnviewprofile);
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 495);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(-1, 201);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(184, 64);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnviewprofile
            // 
            this.btnviewprofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewprofile.Location = new System.Drawing.Point(-1, 73);
            this.btnviewprofile.Name = "btnviewprofile";
            this.btnviewprofile.Size = new System.Drawing.Size(184, 58);
            this.btnviewprofile.TabIndex = 0;
            this.btnviewprofile.Text = "View Profile";
            this.btnviewprofile.UseVisualStyleBackColor = true;
            this.btnviewprofile.Click += new System.EventHandler(this.btnReceptionistProfile_Click);
            // 
            // btnTrainers
            // 
            this.btnTrainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainers.Location = new System.Drawing.Point(302, 223);
            this.btnTrainers.Name = "btnTrainers";
            this.btnTrainers.Size = new System.Drawing.Size(183, 58);
            this.btnTrainers.TabIndex = 2;
            this.btnTrainers.Text = "Trainers";
            this.btnTrainers.UseVisualStyleBackColor = true;
            this.btnTrainers.Click += new System.EventHandler(this.btnTrainers_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.Location = new System.Drawing.Point(633, 223);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(183, 58);
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(302, 390);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(183, 64);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.Location = new System.Drawing.Point(633, 390);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(183, 64);
            this.btnAppointment.TabIndex = 5;
            this.btnAppointment.Text = "Training Appointments";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnTraningAppointment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(295, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "RECEPTIONIST DASHBOARD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(182, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 37);
            this.panel3.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(617, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(205, 42);
            this.panel6.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hello, RECEPTIONIST";
            // 
            // btnTrainingSession
            // 
            this.btnTrainingSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingSession.Location = new System.Drawing.Point(483, 519);
            this.btnTrainingSession.Name = "btnTrainingSession";
            this.btnTrainingSession.Size = new System.Drawing.Size(173, 64);
            this.btnTrainingSession.TabIndex = 12;
            this.btnTrainingSession.Text = "Training Sessions";
            this.btnTrainingSession.UseVisualStyleBackColor = true;
            this.btnTrainingSession.Click += new System.EventHandler(this.btnTrainingSession_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsProgramDesign.Properties.Resources.Screenshot_15_12_2024_21287_www_bing_com;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ReceptionistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1004, 644);
            this.Controls.Add(this.btnTrainingSession);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnTrainers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceptionistMain";
            this.Text = "ReceptionistMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnviewprofile;
        private System.Windows.Forms.Button btnTrainers;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTrainingSession;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}