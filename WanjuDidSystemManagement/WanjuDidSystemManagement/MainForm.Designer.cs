
namespace WanjuDidSystemManagement
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.vidio_Btn = new System.Windows.Forms.Button();
            this.photo_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.vidio_Btn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.photo_Btn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.15942F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(111, 138);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // vidio_Btn
            // 
            this.vidio_Btn.BackColor = System.Drawing.SystemColors.Control;
            this.vidio_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vidio_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vidio_Btn.Location = new System.Drawing.Point(0, 94);
            this.vidio_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.vidio_Btn.Name = "vidio_Btn";
            this.vidio_Btn.Size = new System.Drawing.Size(111, 44);
            this.vidio_Btn.TabIndex = 2;
            this.vidio_Btn.Text = "기타 관리";
            this.vidio_Btn.UseVisualStyleBackColor = false;
            this.vidio_Btn.Click += new System.EventHandler(this.vidio_Btn_Click);
            // 
            // photo_Btn
            // 
            this.photo_Btn.BackColor = System.Drawing.SystemColors.Control;
            this.photo_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.photo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.photo_Btn.Location = new System.Drawing.Point(0, 47);
            this.photo_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.photo_Btn.Name = "photo_Btn";
            this.photo_Btn.Size = new System.Drawing.Size(111, 47);
            this.photo_Btn.TabIndex = 1;
            this.photo_Btn.Text = "포토갤러리 관리";
            this.photo_Btn.UseVisualStyleBackColor = false;
            this.photo_Btn.Click += new System.EventHandler(this.photo_Btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "좌석배치도 관리";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 678);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 28);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 706);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button vidio_Btn;
        private System.Windows.Forms.Button photo_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

