namespace NoteTaker2
{
    partial class qTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qTask));
            this.taskTitleLbl = new System.Windows.Forms.Label();
            this.taskDetailsLbl = new System.Windows.Forms.Label();
            this.taskTitle = new System.Windows.Forms.TextBox();
            this.taskDetails = new System.Windows.Forms.TextBox();
            this.buttSave = new System.Windows.Forms.Button();
            this.buttDetails = new System.Windows.Forms.Button();
            this.buttComplete = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listLbl = new System.Windows.Forms.Label();
            this.estTimeBox = new System.Windows.Forms.ComboBox();
            this.timeLbl = new System.Windows.Forms.Label();
            this.buttNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // taskTitleLbl
            // 
            this.taskTitleLbl.AutoSize = true;
            this.taskTitleLbl.Location = new System.Drawing.Point(9, 383);
            this.taskTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskTitleLbl.Name = "taskTitleLbl";
            this.taskTitleLbl.Size = new System.Drawing.Size(39, 17);
            this.taskTitleLbl.TabIndex = 0;
            this.taskTitleLbl.Text = "Task";
            // 
            // taskDetailsLbl
            // 
            this.taskDetailsLbl.AutoSize = true;
            this.taskDetailsLbl.Location = new System.Drawing.Point(9, 431);
            this.taskDetailsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskDetailsLbl.Name = "taskDetailsLbl";
            this.taskDetailsLbl.Size = new System.Drawing.Size(51, 17);
            this.taskDetailsLbl.TabIndex = 1;
            this.taskDetailsLbl.Text = "Details";
            // 
            // taskTitle
            // 
            this.taskTitle.Location = new System.Drawing.Point(12, 404);
            this.taskTitle.Margin = new System.Windows.Forms.Padding(4);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(213, 23);
            this.taskTitle.TabIndex = 1;
            // 
            // taskDetails
            // 
            this.taskDetails.Location = new System.Drawing.Point(12, 452);
            this.taskDetails.Margin = new System.Windows.Forms.Padding(4);
            this.taskDetails.Multiline = true;
            this.taskDetails.Name = "taskDetails";
            this.taskDetails.Size = new System.Drawing.Size(268, 125);
            this.taskDetails.TabIndex = 3;
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(13, 585);
            this.buttSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(127, 53);
            this.buttSave.TabIndex = 4;
            this.buttSave.Text = "Save";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.ButtSave_Click);
            // 
            // buttDetails
            // 
            this.buttDetails.Location = new System.Drawing.Point(13, 258);
            this.buttDetails.Margin = new System.Windows.Forms.Padding(4);
            this.buttDetails.Name = "buttDetails";
            this.buttDetails.Size = new System.Drawing.Size(127, 53);
            this.buttDetails.TabIndex = 7;
            this.buttDetails.Text = "Details";
            this.buttDetails.UseVisualStyleBackColor = true;
            this.buttDetails.Click += new System.EventHandler(this.ButtRead_Click);
            // 
            // buttComplete
            // 
            this.buttComplete.Location = new System.Drawing.Point(148, 258);
            this.buttComplete.Margin = new System.Windows.Forms.Padding(4);
            this.buttComplete.Name = "buttComplete";
            this.buttComplete.Size = new System.Drawing.Size(132, 53);
            this.buttComplete.TabIndex = 8;
            this.buttComplete.Text = "Complete";
            this.buttComplete.UseVisualStyleBackColor = true;
            this.buttComplete.Click += new System.EventHandler(this.ButtDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Location = new System.Drawing.Point(13, 34);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(264, 212);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 319);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 63);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // listLbl
            // 
            this.listLbl.AutoSize = true;
            this.listLbl.Location = new System.Drawing.Point(16, 13);
            this.listLbl.Name = "listLbl";
            this.listLbl.Size = new System.Drawing.Size(30, 17);
            this.listLbl.TabIndex = 10;
            this.listLbl.Text = "List";
            // 
            // estTimeBox
            // 
            this.estTimeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "45",
            "60",
            "120"});
            this.estTimeBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.estTimeBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.estTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estTimeBox.FormattingEnabled = true;
            this.estTimeBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "45",
            "60",
            "90",
            "120",
            "other"});
            this.estTimeBox.Location = new System.Drawing.Point(232, 404);
            this.estTimeBox.Name = "estTimeBox";
            this.estTimeBox.Size = new System.Drawing.Size(50, 24);
            this.estTimeBox.TabIndex = 2;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(229, 383);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(39, 17);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "Time";
            // 
            // buttNew
            // 
            this.buttNew.Location = new System.Drawing.Point(155, 585);
            this.buttNew.Margin = new System.Windows.Forms.Padding(4);
            this.buttNew.Name = "buttNew";
            this.buttNew.Size = new System.Drawing.Size(127, 53);
            this.buttNew.TabIndex = 5;
            this.buttNew.Text = "New";
            this.buttNew.UseVisualStyleBackColor = true;
            this.buttNew.Click += new System.EventHandler(this.ButtNew_Click_1);
            // 
            // qTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(294, 646);
            this.ControlBox = false;
            this.Controls.Add(this.buttNew);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.estTimeBox);
            this.Controls.Add(this.listLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttComplete);
            this.Controls.Add(this.buttDetails);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.taskDetails);
            this.Controls.Add(this.taskTitle);
            this.Controls.Add(this.taskDetailsLbl);
            this.Controls.Add(this.taskTitleLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "qTask";
            this.Text = "qTask";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskTitleLbl;
        private System.Windows.Forms.Label taskDetailsLbl;
        private System.Windows.Forms.TextBox taskTitle;
        private System.Windows.Forms.TextBox taskDetails;
        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.Button buttDetails;
        private System.Windows.Forms.Button buttComplete;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label listLbl;
        private System.Windows.Forms.ComboBox estTimeBox;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button buttNew;
    }
}

