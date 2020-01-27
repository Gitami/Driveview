namespace driveview
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.allheadline_label_size = new System.Windows.Forms.Label();
            this.allheadline_label_label = new System.Windows.Forms.Label();
            this.allheadline_label_type = new System.Windows.Forms.Label();
            this.allheadline_label_name = new System.Windows.Forms.Label();
            this.alldrives_label_size = new System.Windows.Forms.Label();
            this.alldrives_label_label = new System.Windows.Forms.Label();
            this.alldrives_label_type = new System.Windows.Forms.Label();
            this.alldrives_label_name = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.drivedetails_helptext1 = new System.Windows.Forms.Label();
            this.drivesdetails_icon = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_drivedata_out = new System.Windows.Forms.Label();
            this.label_drivedata = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.about_label_link2 = new System.Windows.Forms.Label();
            this.about_label_link1 = new System.Windows.Forms.Label();
            this.about_label_1 = new System.Windows.Forms.Label();
            this.alldrivestotalspace_label = new System.Windows.Forms.Label();
            this.alldrivestotalspacefree_label = new System.Windows.Forms.Label();
            this.alldrivestotalspaceused_label = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivesdetails_icon)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(0, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(389, 325);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 84;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.alldrivestotalspaceused_label);
            this.tabPage1.Controls.Add(this.alldrivestotalspacefree_label);
            this.tabPage1.Controls.Add(this.alldrivestotalspace_label);
            this.tabPage1.Controls.Add(this.allheadline_label_size);
            this.tabPage1.Controls.Add(this.allheadline_label_label);
            this.tabPage1.Controls.Add(this.allheadline_label_type);
            this.tabPage1.Controls.Add(this.allheadline_label_name);
            this.tabPage1.Controls.Add(this.alldrives_label_size);
            this.tabPage1.Controls.Add(this.alldrives_label_label);
            this.tabPage1.Controls.Add(this.alldrives_label_type);
            this.tabPage1.Controls.Add(this.alldrives_label_name);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(381, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All drives";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // allheadline_label_size
            // 
            this.allheadline_label_size.AutoSize = true;
            this.allheadline_label_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allheadline_label_size.Location = new System.Drawing.Point(266, 16);
            this.allheadline_label_size.Name = "allheadline_label_size";
            this.allheadline_label_size.Size = new System.Drawing.Size(0, 13);
            this.allheadline_label_size.TabIndex = 7;
            // 
            // allheadline_label_label
            // 
            this.allheadline_label_label.AutoSize = true;
            this.allheadline_label_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allheadline_label_label.Location = new System.Drawing.Point(122, 16);
            this.allheadline_label_label.Name = "allheadline_label_label";
            this.allheadline_label_label.Size = new System.Drawing.Size(0, 13);
            this.allheadline_label_label.TabIndex = 6;
            // 
            // allheadline_label_type
            // 
            this.allheadline_label_type.AutoSize = true;
            this.allheadline_label_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allheadline_label_type.Location = new System.Drawing.Point(63, 16);
            this.allheadline_label_type.Name = "allheadline_label_type";
            this.allheadline_label_type.Size = new System.Drawing.Size(0, 13);
            this.allheadline_label_type.TabIndex = 5;
            // 
            // allheadline_label_name
            // 
            this.allheadline_label_name.AutoSize = true;
            this.allheadline_label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allheadline_label_name.Location = new System.Drawing.Point(35, 16);
            this.allheadline_label_name.Name = "allheadline_label_name";
            this.allheadline_label_name.Size = new System.Drawing.Size(0, 13);
            this.allheadline_label_name.TabIndex = 4;
            // 
            // alldrives_label_size
            // 
            this.alldrives_label_size.AutoSize = true;
            this.alldrives_label_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alldrives_label_size.Location = new System.Drawing.Point(265, 36);
            this.alldrives_label_size.Name = "alldrives_label_size";
            this.alldrives_label_size.Size = new System.Drawing.Size(0, 13);
            this.alldrives_label_size.TabIndex = 3;
            this.alldrives_label_size.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // alldrives_label_label
            // 
            this.alldrives_label_label.AutoSize = true;
            this.alldrives_label_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alldrives_label_label.Location = new System.Drawing.Point(121, 36);
            this.alldrives_label_label.Name = "alldrives_label_label";
            this.alldrives_label_label.Size = new System.Drawing.Size(0, 13);
            this.alldrives_label_label.TabIndex = 2;
            // 
            // alldrives_label_type
            // 
            this.alldrives_label_type.AutoSize = true;
            this.alldrives_label_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alldrives_label_type.Location = new System.Drawing.Point(64, 36);
            this.alldrives_label_type.Name = "alldrives_label_type";
            this.alldrives_label_type.Size = new System.Drawing.Size(0, 13);
            this.alldrives_label_type.TabIndex = 1;
            // 
            // alldrives_label_name
            // 
            this.alldrives_label_name.AutoSize = true;
            this.alldrives_label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alldrives_label_name.Location = new System.Drawing.Point(37, 36);
            this.alldrives_label_name.Name = "alldrives_label_name";
            this.alldrives_label_name.Size = new System.Drawing.Size(0, 13);
            this.alldrives_label_name.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.drivedetails_helptext1);
            this.tabPage2.Controls.Add(this.drivesdetails_icon);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label_drivedata_out);
            this.tabPage2.Controls.Add(this.label_drivedata);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(381, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Drive details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // drivedetails_helptext1
            // 
            this.drivedetails_helptext1.AutoSize = true;
            this.drivedetails_helptext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.drivedetails_helptext1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.drivedetails_helptext1.Location = new System.Drawing.Point(131, 24);
            this.drivedetails_helptext1.Name = "drivedetails_helptext1";
            this.drivedetails_helptext1.Size = new System.Drawing.Size(126, 13);
            this.drivedetails_helptext1.TabIndex = 83;
            this.drivedetails_helptext1.Text = "List of all drives detected:";
            // 
            // drivesdetails_icon
            // 
            this.drivesdetails_icon.Location = new System.Drawing.Point(71, 21);
            this.drivesdetails_icon.Name = "drivesdetails_icon";
            this.drivesdetails_icon.Size = new System.Drawing.Size(45, 45);
            this.drivesdetails_icon.TabIndex = 82;
            this.drivesdetails_icon.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 79;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_drivedata_out
            // 
            this.label_drivedata_out.AutoSize = true;
            this.label_drivedata_out.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_drivedata_out.Location = new System.Drawing.Point(129, 71);
            this.label_drivedata_out.Name = "label_drivedata_out";
            this.label_drivedata_out.Size = new System.Drawing.Size(0, 13);
            this.label_drivedata_out.TabIndex = 81;
            this.label_drivedata_out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_drivedata
            // 
            this.label_drivedata.AutoSize = true;
            this.label_drivedata.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_drivedata.Location = new System.Drawing.Point(54, 71);
            this.label_drivedata.Name = "label_drivedata";
            this.label_drivedata.Size = new System.Drawing.Size(0, 13);
            this.label_drivedata.TabIndex = 80;
            this.label_drivedata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.about_label_link2);
            this.tabPage3.Controls.Add(this.about_label_link1);
            this.tabPage3.Controls.Add(this.about_label_1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(381, 299);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // about_label_link2
            // 
            this.about_label_link2.AutoSize = true;
            this.about_label_link2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about_label_link2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.about_label_link2.Location = new System.Drawing.Point(44, 193);
            this.about_label_link2.Name = "about_label_link2";
            this.about_label_link2.Size = new System.Drawing.Size(0, 13);
            this.about_label_link2.TabIndex = 2;
            this.about_label_link2.Click += new System.EventHandler(this.about_label_link2_Click);
            // 
            // about_label_link1
            // 
            this.about_label_link1.AutoSize = true;
            this.about_label_link1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about_label_link1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.about_label_link1.Location = new System.Drawing.Point(44, 140);
            this.about_label_link1.Name = "about_label_link1";
            this.about_label_link1.Size = new System.Drawing.Size(0, 13);
            this.about_label_link1.TabIndex = 1;
            this.about_label_link1.Click += new System.EventHandler(this.about_label_link1_Click);
            // 
            // about_label_1
            // 
            this.about_label_1.AutoSize = true;
            this.about_label_1.Location = new System.Drawing.Point(44, 22);
            this.about_label_1.Name = "about_label_1";
            this.about_label_1.Size = new System.Drawing.Size(0, 13);
            this.about_label_1.TabIndex = 0;
            // 
            // alldrivestotalspace_label
            // 
            this.alldrivestotalspace_label.AutoSize = true;
            this.alldrivestotalspace_label.Location = new System.Drawing.Point(37, 232);
            this.alldrivestotalspace_label.Name = "alldrivestotalspace_label";
            this.alldrivestotalspace_label.Size = new System.Drawing.Size(0, 13);
            this.alldrivestotalspace_label.TabIndex = 8;
            // 
            // alldrivestotalspacefree_label
            // 
            this.alldrivestotalspacefree_label.AutoSize = true;
            this.alldrivestotalspacefree_label.Location = new System.Drawing.Point(37, 250);
            this.alldrivestotalspacefree_label.Name = "alldrivestotalspacefree_label";
            this.alldrivestotalspacefree_label.Size = new System.Drawing.Size(0, 13);
            this.alldrivestotalspacefree_label.TabIndex = 9;
            // 
            // alldrivestotalspaceused_label
            // 
            this.alldrivestotalspaceused_label.AutoSize = true;
            this.alldrivestotalspaceused_label.Location = new System.Drawing.Point(37, 268);
            this.alldrivestotalspaceused_label.Name = "alldrivestotalspaceused_label";
            this.alldrivestotalspaceused_label.Size = new System.Drawing.Size(0, 13);
            this.alldrivestotalspaceused_label.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 327);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DriveView by amite.dk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivesdetails_icon)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox drivesdetails_icon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label drivedetails_helptext1;
        private System.Windows.Forms.Label label_drivedata_out;
        private System.Windows.Forms.Label label_drivedata;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label about_label_1;
        private System.Windows.Forms.Label about_label_link2;
        private System.Windows.Forms.Label about_label_link1;
        private System.Windows.Forms.Label alldrives_label_name;
        private System.Windows.Forms.Label alldrives_label_type;
        private System.Windows.Forms.Label alldrives_label_label;
        private System.Windows.Forms.Label alldrives_label_size;
        private System.Windows.Forms.Label allheadline_label_size;
        private System.Windows.Forms.Label allheadline_label_label;
        private System.Windows.Forms.Label allheadline_label_type;
        private System.Windows.Forms.Label allheadline_label_name;
        private System.Windows.Forms.Label alldrivestotalspaceused_label;
        private System.Windows.Forms.Label alldrivestotalspacefree_label;
        private System.Windows.Forms.Label alldrivestotalspace_label;
    }
}

