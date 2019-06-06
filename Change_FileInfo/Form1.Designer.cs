namespace Change_FileInfo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTFileDirectory = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnBrwose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnChange = new System.Windows.Forms.Button();
            this.DTPCreateTime = new System.Windows.Forms.DateTimePicker();
            this.DTPModifyTime = new System.Windows.Forms.DateTimePicker();
            this.DTPLastAccess = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.83871F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.16129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TXTFileDirectory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnBrwose, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnChange, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.DTPCreateTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DTPModifyTime, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DTPLastAccess, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Directory :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXTFileDirectory
            // 
            this.TXTFileDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TXTFileDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTFileDirectory.Location = new System.Drawing.Point(165, 57);
            this.TXTFileDirectory.Name = "TXTFileDirectory";
            this.TXTFileDirectory.Size = new System.Drawing.Size(297, 26);
            this.TXTFileDirectory.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(609, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(47, 34);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnBrwose
            // 
            this.BtnBrwose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnBrwose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrwose.Location = new System.Drawing.Point(468, 53);
            this.BtnBrwose.Name = "BtnBrwose";
            this.BtnBrwose.Size = new System.Drawing.Size(40, 34);
            this.BtnBrwose.TabIndex = 3;
            this.BtnBrwose.Text = "...";
            this.BtnBrwose.UseVisualStyleBackColor = true;
            this.BtnBrwose.Click += new System.EventHandler(this.BtnBrwose_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 87);
            this.label2.TabIndex = 4;
            this.label2.Text = "Create Time :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 87);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modify Time :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 91);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Access Time :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnChange
            // 
            this.BtnChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChange.Location = new System.Drawing.Point(507, 365);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(109, 45);
            this.BtnChange.TabIndex = 10;
            this.BtnChange.Text = "Change";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // DTPCreateTime
            // 
            this.DTPCreateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DTPCreateTime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.DTPCreateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPCreateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPCreateTime.Location = new System.Drawing.Point(165, 218);
            this.DTPCreateTime.Name = "DTPCreateTime";
            this.DTPCreateTime.Size = new System.Drawing.Size(297, 26);
            this.DTPCreateTime.TabIndex = 11;
            // 
            // DTPModifyTime
            // 
            this.DTPModifyTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DTPModifyTime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.DTPModifyTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPModifyTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPModifyTime.Location = new System.Drawing.Point(165, 305);
            this.DTPModifyTime.Name = "DTPModifyTime";
            this.DTPModifyTime.Size = new System.Drawing.Size(297, 26);
            this.DTPModifyTime.TabIndex = 12;
            // 
            // DTPLastAccess
            // 
            this.DTPLastAccess.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DTPLastAccess.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.DTPLastAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPLastAccess.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPLastAccess.Location = new System.Drawing.Point(165, 394);
            this.DTPLastAccess.Name = "DTPLastAccess";
            this.DTPLastAccess.Size = new System.Drawing.Size(297, 26);
            this.DTPLastAccess.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(165, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 87);
            this.label5.TabIndex = 14;
            this.label5.Text = "Powered By VEGA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Info Changer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTFileDirectory;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnBrwose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.DateTimePicker DTPCreateTime;
        private System.Windows.Forms.DateTimePicker DTPModifyTime;
        private System.Windows.Forms.DateTimePicker DTPLastAccess;
        private System.Windows.Forms.Label label5;
    }
}

