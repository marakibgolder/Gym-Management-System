namespace WindowsProgramDesign
{
    partial class TrainingSession
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSessionName = new System.Windows.Forms.TextBox();
            this.txtTrainerID = new System.Windows.Forms.TextBox();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.txtTrainingSessionID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnClearTrainingSessionFields = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Search Details";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(176, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(297, 22);
            this.txtSearch.TabIndex = 71;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(502, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 33);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(176, 267);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker.TabIndex = 69;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 49);
            this.button3.TabIndex = 68;
            this.button3.Text = "Back to Main Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(92, 528);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 49);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(287, 446);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 54);
            this.btnUpdate.TabIndex = 66;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 54);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(502, 103);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(869, 506);
            this.dataGridView.TabIndex = 64;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(176, 308);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(246, 22);
            this.txtPrice.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Date and Time";
            // 
            // txtSessionName
            // 
            this.txtSessionName.Location = new System.Drawing.Point(176, 147);
            this.txtSessionName.Name = "txtSessionName";
            this.txtSessionName.Size = new System.Drawing.Size(246, 22);
            this.txtSessionName.TabIndex = 60;
            // 
            // txtTrainerID
            // 
            this.txtTrainerID.Location = new System.Drawing.Point(176, 187);
            this.txtTrainerID.Name = "txtTrainerID";
            this.txtTrainerID.Size = new System.Drawing.Size(246, 22);
            this.txtTrainerID.TabIndex = 59;
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Location = new System.Drawing.Point(176, 226);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(246, 22);
            this.txtTrainerName.TabIndex = 58;
            // 
            // txtTrainingSessionID
            // 
            this.txtTrainingSessionID.Location = new System.Drawing.Point(176, 103);
            this.txtTrainingSessionID.Name = "txtTrainingSessionID";
            this.txtTrainingSessionID.Size = new System.Drawing.Size(246, 22);
            this.txtTrainingSessionID.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Trainer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Trainer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Session Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Session ID";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(100, 356);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(62, 16);
            this.Category.TabIndex = 73;
            this.Category.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(176, 353);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(246, 22);
            this.txtCategory.TabIndex = 74;
            // 
            // btnClearTrainingSessionFields
            // 
            this.btnClearTrainingSessionFields.Location = new System.Drawing.Point(597, 45);
            this.btnClearTrainingSessionFields.Name = "btnClearTrainingSessionFields";
            this.btnClearTrainingSessionFields.Size = new System.Drawing.Size(92, 33);
            this.btnClearTrainingSessionFields.TabIndex = 75;
            this.btnClearTrainingSessionFields.Text = "Clear Fields";
            this.btnClearTrainingSessionFields.UseVisualStyleBackColor = true;
            this.btnClearTrainingSessionFields.Click += new System.EventHandler(this.btnClearTrainingSessionFields_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 76;
            this.button1.Text = "View All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // TrainingSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1381, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearTrainingSessionFields);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSessionName);
            this.Controls.Add(this.txtTrainerID);
            this.Controls.Add(this.txtTrainerName);
            this.Controls.Add(this.txtTrainingSessionID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrainingSession";
            this.Text = "Training Session Booking ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSessionName;
        private System.Windows.Forms.TextBox txtTrainerID;
        private System.Windows.Forms.TextBox txtTrainerName;
        private System.Windows.Forms.TextBox txtTrainingSessionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnClearTrainingSessionFields;
        private System.Windows.Forms.Button button1;
    }
}