
namespace WanjuDidSystemManagement
{
    partial class UserProfile
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
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClearBtn = new System.Windows.Forms.Button();
            this.FileDialog_Btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TelTxtBox = new System.Windows.Forms.TextBox();
            this.WorkTxtBox = new System.Windows.Forms.TextBox();
            this.TeamTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.NameCardCheckBox = new System.Windows.Forms.CheckBox();
            this.ColseBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.20718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.61188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.18094F));
            this.tableLayoutPanel1.Controls.Add(this.UserPictureBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPictureBox.Location = new System.Drawing.Point(95, 3);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(118, 149);
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picClearBtn);
            this.panel1.Controls.Add(this.FileDialog_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 34);
            this.panel1.TabIndex = 2;
            // 
            // picClearBtn
            // 
            this.picClearBtn.Location = new System.Drawing.Point(157, 5);
            this.picClearBtn.Name = "picClearBtn";
            this.picClearBtn.Size = new System.Drawing.Size(73, 23);
            this.picClearBtn.TabIndex = 1;
            this.picClearBtn.Text = "이미지삭제";
            this.picClearBtn.UseVisualStyleBackColor = true;
            this.picClearBtn.Click += new System.EventHandler(this.PicTureClearBtn_Click);
            // 
            // FileDialog_Btn
            // 
            this.FileDialog_Btn.Location = new System.Drawing.Point(76, 5);
            this.FileDialog_Btn.Name = "FileDialog_Btn";
            this.FileDialog_Btn.Size = new System.Drawing.Size(73, 23);
            this.FileDialog_Btn.TabIndex = 0;
            this.FileDialog_Btn.Text = "이미지첨부";
            this.FileDialog_Btn.UseVisualStyleBackColor = true;
            this.FileDialog_Btn.Click += new System.EventHandler(this.FileDialog_Btn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.29316F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.70684F));
            this.tableLayoutPanel2.Controls.Add(this.TelTxtBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.WorkTxtBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TeamTxtBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.NameTxtBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NameCardCheckBox, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 189);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 123);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // TelTxtBox
            // 
            this.TelTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TelTxtBox.Location = new System.Drawing.Point(95, 75);
            this.TelTxtBox.Name = "TelTxtBox";
            this.TelTxtBox.Size = new System.Drawing.Size(209, 21);
            this.TelTxtBox.TabIndex = 8;
            // 
            // WorkTxtBox
            // 
            this.WorkTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkTxtBox.Location = new System.Drawing.Point(95, 51);
            this.WorkTxtBox.Name = "WorkTxtBox";
            this.WorkTxtBox.Size = new System.Drawing.Size(209, 21);
            this.WorkTxtBox.TabIndex = 7;
            // 
            // TeamTxtBox
            // 
            this.TeamTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamTxtBox.Location = new System.Drawing.Point(95, 27);
            this.TeamTxtBox.Name = "TeamTxtBox";
            this.TeamTxtBox.Size = new System.Drawing.Size(209, 21);
            this.TeamTxtBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(49, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(65, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "팀";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(49, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "업무";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(17, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "전화번호";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(17, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "네임카드";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTxtBox.Location = new System.Drawing.Point(95, 3);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(209, 21);
            this.NameTxtBox.TabIndex = 5;
            // 
            // NameCardCheckBox
            // 
            this.NameCardCheckBox.AutoSize = true;
            this.NameCardCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameCardCheckBox.Location = new System.Drawing.Point(95, 99);
            this.NameCardCheckBox.Name = "NameCardCheckBox";
            this.NameCardCheckBox.Size = new System.Drawing.Size(209, 21);
            this.NameCardCheckBox.TabIndex = 9;
            this.NameCardCheckBox.Text = "활성/비활성";
            this.NameCardCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColseBtn
            // 
            this.ColseBtn.Location = new System.Drawing.Point(157, 401);
            this.ColseBtn.Name = "ColseBtn";
            this.ColseBtn.Size = new System.Drawing.Size(73, 23);
            this.ColseBtn.TabIndex = 3;
            this.ColseBtn.Text = "닫기";
            this.ColseBtn.UseVisualStyleBackColor = true;
            this.ColseBtn.Click += new System.EventHandler(this.ColseBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(76, 401);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(73, 23);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "저장";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ColseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FileDialog_Btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TelTxtBox;
        private System.Windows.Forms.TextBox WorkTxtBox;
        private System.Windows.Forms.TextBox TeamTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.CheckBox NameCardCheckBox;
        private System.Windows.Forms.Button picClearBtn;
        private System.Windows.Forms.Button ColseBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}