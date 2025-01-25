namespace WindowsProgramDesign
{
    partial class ReceptionistList
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.employment = new System.Windows.Forms.Label();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtReceptionistID = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnbacktomain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxEmploymentStatus = new System.Windows.Forms.ComboBox();
            this.btnClearReceptionistFields = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receptionist ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone No.";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(72, 232);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 16);
            this.email.TabIndex = 5;
            this.email.Text = "Email";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(72, 271);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(58, 16);
            this.address.TabIndex = 6;
            this.address.Text = "Address";
            // 
            // employment
            // 
            this.employment.AutoSize = true;
            this.employment.Location = new System.Drawing.Point(48, 404);
            this.employment.Name = "employment";
            this.employment.Size = new System.Drawing.Size(82, 16);
            this.employment.TabIndex = 7;
            this.employment.Text = "Employment";
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Location = new System.Drawing.Point(147, 268);
            this.txtHomeAddress.Multiline = true;
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(341, 117);
            this.txtHomeAddress.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 226);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(147, 186);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(189, 22);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // txtReceptionistID
            // 
            this.txtReceptionistID.Location = new System.Drawing.Point(147, 141);
            this.txtReceptionistID.Name = "txtReceptionistID";
            this.txtReceptionistID.Size = new System.Drawing.Size(189, 22);
            this.txtReceptionistID.TabIndex = 14;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(392, 534);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 54);
            this.btndelete.TabIndex = 44;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(458, 46);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(81, 35);
            this.btnsearch.TabIndex = 43;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(218, 534);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(118, 54);
            this.btnupdate.TabIndex = 42;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnbacktomain
            // 
            this.btnbacktomain.Location = new System.Drawing.Point(1236, 575);
            this.btnbacktomain.Name = "btnbacktomain";
            this.btnbacktomain.Size = new System.Drawing.Size(109, 42);
            this.btnbacktomain.TabIndex = 41;
            this.btnbacktomain.Text = "Back to Main";
            this.btnbacktomain.UseVisualStyleBackColor = true;
            this.btnbacktomain.Click += new System.EventHandler(this.btnbacktomain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 22);
            this.txtName.TabIndex = 46;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(147, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 22);
            this.txtSearch.TabIndex = 48;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(38, 534);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(119, 54);
            this.btnadd.TabIndex = 49;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(565, 101);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(780, 468);
            this.dataGridView.TabIndex = 50;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewforuser_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Search Details";
            // 
            // cboxEmploymentStatus
            // 
            this.cboxEmploymentStatus.FormattingEnabled = true;
            this.cboxEmploymentStatus.Items.AddRange(new object[] {
            "Part-time ",
            "Full-time"});
            this.cboxEmploymentStatus.Location = new System.Drawing.Point(147, 404);
            this.cboxEmploymentStatus.Name = "cboxEmploymentStatus";
            this.cboxEmploymentStatus.Size = new System.Drawing.Size(189, 24);
            this.cboxEmploymentStatus.TabIndex = 53;
            // 
            // btnClearReceptionistFields
            // 
            this.btnClearReceptionistFields.Location = new System.Drawing.Point(565, 46);
            this.btnClearReceptionistFields.Name = "btnClearReceptionistFields";
            this.btnClearReceptionistFields.Size = new System.Drawing.Size(94, 35);
            this.btnClearReceptionistFields.TabIndex = 54;
            this.btnClearReceptionistFields.Text = "Clear Fields";
            this.btnClearReceptionistFields.UseVisualStyleBackColor = true;
            this.btnClearReceptionistFields.Click += new System.EventHandler(this.btnClearReceptionistFields_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(565, 574);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(107, 43);
            this.btnView.TabIndex = 55;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ReceptionistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1357, 715);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClearReceptionistFields);
            this.Controls.Add(this.cboxEmploymentStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnbacktomain);
            this.Controls.Add(this.txtReceptionistID);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.employment);
            this.Controls.Add(this.address);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceptionistList";
            this.Text = "ReceptionistList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label employment;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtReceptionistID;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnbacktomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxEmploymentStatus;
        private System.Windows.Forms.Button btnClearReceptionistFields;
        private System.Windows.Forms.Button btnView;
    }
}