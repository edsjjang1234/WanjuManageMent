
namespace WanjuDidSystemManagement
{
    partial class VidioManageForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vidioGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.vidioListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.vidioPathTat = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dialogBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.vidioSaveBtn = new System.Windows.Forms.Button();
            this.vidioDeleteBTn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ipFTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipMTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipLTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ipLLTxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ipSaveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.vidioGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 50);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.vidioGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 657);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // vidioGroupBox
            // 
            this.vidioGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.vidioGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vidioGroupBox.ForeColor = System.Drawing.Color.Black;
            this.vidioGroupBox.Location = new System.Drawing.Point(3, 3);
            this.vidioGroupBox.Name = "vidioGroupBox";
            this.vidioGroupBox.Size = new System.Drawing.Size(427, 213);
            this.vidioGroupBox.TabIndex = 0;
            this.vidioGroupBox.TabStop = false;
            this.vidioGroupBox.Text = "동영상 관리";
            this.vidioGroupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.vidioGroupBox_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.vidioListView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 193);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // vidioListView
            // 
            this.vidioListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vidioListView.HideSelection = false;
            this.vidioListView.Location = new System.Drawing.Point(3, 3);
            this.vidioListView.Name = "vidioListView";
            this.vidioListView.Size = new System.Drawing.Size(204, 187);
            this.vidioListView.TabIndex = 0;
            this.vidioListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.vidioPathTat, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(213, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.65217F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.526882F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.5914F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.96774F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.27957F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.73913F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(205, 187);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // vidioPathTat
            // 
            this.vidioPathTat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vidioPathTat.Location = new System.Drawing.Point(3, 32);
            this.vidioPathTat.Name = "vidioPathTat";
            this.vidioPathTat.Size = new System.Drawing.Size(199, 21);
            this.vidioPathTat.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.14141F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel4.Controls.Add(this.dialogBtn, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(199, 23);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // dialogBtn
            // 
            this.dialogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dialogBtn.Location = new System.Drawing.Point(128, 3);
            this.dialogBtn.Name = "dialogBtn";
            this.dialogBtn.Size = new System.Drawing.Size(68, 17);
            this.dialogBtn.TabIndex = 0;
            this.dialogBtn.Text = "불러오기";
            this.dialogBtn.UseVisualStyleBackColor = true;
            this.dialogBtn.Click += new System.EventHandler(this.dialogBtn_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel5.Controls.Add(this.vidioSaveBtn, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.vidioDeleteBTn, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 148);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(199, 36);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // vidioSaveBtn
            // 
            this.vidioSaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vidioSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vidioSaveBtn.Location = new System.Drawing.Point(3, 3);
            this.vidioSaveBtn.Name = "vidioSaveBtn";
            this.vidioSaveBtn.Size = new System.Drawing.Size(84, 30);
            this.vidioSaveBtn.TabIndex = 0;
            this.vidioSaveBtn.Text = "저장";
            this.vidioSaveBtn.UseVisualStyleBackColor = true;
            this.vidioSaveBtn.Click += new System.EventHandler(this.vidioSaveBtn_Click);
            // 
            // vidioDeleteBTn
            // 
            this.vidioDeleteBTn.BackColor = System.Drawing.Color.Red;
            this.vidioDeleteBTn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vidioDeleteBTn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vidioDeleteBTn.Location = new System.Drawing.Point(111, 3);
            this.vidioDeleteBTn.Name = "vidioDeleteBTn";
            this.vidioDeleteBTn.Size = new System.Drawing.Size(85, 30);
            this.vidioDeleteBTn.TabIndex = 1;
            this.vidioDeleteBTn.Text = "삭제";
            this.vidioDeleteBTn.UseVisualStyleBackColor = false;
            this.vidioDeleteBTn.Click += new System.EventHandler(this.vidioDeleteBTn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(436, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DIDSystem IP";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.67876F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.16062F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(421, 193);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 7;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.20482F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.578313F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.68675F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.301205F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.96386F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.614458F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.40964F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.ipFTxt, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.ipMTxt, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.ipLTxt, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.label4, 5, 1);
            this.tableLayoutPanel7.Controls.Add(this.ipLLTxt, 6, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(415, 58);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ipFTxt
            // 
            this.ipFTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipFTxt.Location = new System.Drawing.Point(3, 32);
            this.ipFTxt.Name = "ipFTxt";
            this.ipFTxt.Size = new System.Drawing.Size(82, 21);
            this.ipFTxt.TabIndex = 0;
            this.ipFTxt.TextChanged += new System.EventHandler(this.ipFTxt_TextChanged);
            this.ipFTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipFTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(91, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ipMTxt
            // 
            this.ipMTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipMTxt.Location = new System.Drawing.Point(110, 32);
            this.ipMTxt.Name = "ipMTxt";
            this.ipMTxt.Size = new System.Drawing.Size(84, 21);
            this.ipMTxt.TabIndex = 1;
            this.ipMTxt.TextChanged += new System.EventHandler(this.ipMTxt_TextChanged);
            this.ipMTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipMTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(200, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ipLTxt
            // 
            this.ipLTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipLTxt.Location = new System.Drawing.Point(222, 32);
            this.ipLTxt.Name = "ipLTxt";
            this.ipLTxt.Size = new System.Drawing.Size(81, 21);
            this.ipLTxt.TabIndex = 2;
            this.ipLTxt.TextChanged += new System.EventHandler(this.ipLTxt_TextChanged);
            this.ipLTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipLTxt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(309, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ipLLTxt
            // 
            this.ipLLTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipLLTxt.Location = new System.Drawing.Point(324, 32);
            this.ipLLTxt.Name = "ipLLTxt";
            this.ipLLTxt.Size = new System.Drawing.Size(88, 21);
            this.ipLLTxt.TabIndex = 7;
            this.ipLLTxt.TextChanged += new System.EventHandler(this.ipLLTxt_TextChanged);
            this.ipLLTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipLLTxt_KeyPress);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.98795F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.56627F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.44578F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77108F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.98795F));
            this.tableLayoutPanel8.Controls.Add(this.ipSaveBtn, 2, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.67797F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.32203F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(415, 59);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // ipSaveBtn
            // 
            this.ipSaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ipSaveBtn.Location = new System.Drawing.Point(163, 27);
            this.ipSaveBtn.Name = "ipSaveBtn";
            this.ipSaveBtn.Size = new System.Drawing.Size(83, 29);
            this.ipSaveBtn.TabIndex = 2;
            this.ipSaveBtn.Text = "저장";
            this.ipSaveBtn.UseVisualStyleBackColor = true;
            this.ipSaveBtn.Click += new System.EventHandler(this.ipSaveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 657);
            this.panel2.TabIndex = 1;
            // 
            // VidioManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VidioManageForm";
            this.ShowIcon = false;
            this.Text = "VidioManageForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.vidioGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox vidioGroupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView vidioListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox vidioPathTat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button dialogBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button vidioSaveBtn;
        private System.Windows.Forms.Button vidioDeleteBTn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TextBox ipFTxt;
        private System.Windows.Forms.TextBox ipLTxt;
        private System.Windows.Forms.TextBox ipMTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button ipSaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ipLLTxt;
    }
}