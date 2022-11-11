namespace Lecture_13_Lists_Continued
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(266, 25);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(262, 202);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(603, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(574, 72);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(186, 26);
            this.txtStudentName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search By Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search By Grade";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(574, 261);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(186, 26);
            this.txtGrade.TabIndex = 5;
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(603, 312);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(124, 32);
            this.btnGrade.TabIndex = 4;
            this.btnGrade.Text = "Search";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "Form1";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnGrade;
    }
}

