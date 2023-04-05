namespace BankManage
{
    partial class FMain
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gvSTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.txtPNum = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).BeginInit();
            this.pnlUpdate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 502);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 60);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 502);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(129, 60);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlFind
            // 
            this.pnlFind.AutoSize = true;
            this.pnlFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFind.Controls.Add(this.btnCancel);
            this.pnlFind.Controls.Add(this.gvSTK);
            this.pnlFind.Controls.Add(this.label1);
            this.pnlFind.Controls.Add(this.btnFilter);
            this.pnlFind.Controls.Add(this.txtFilter);
            this.pnlFind.Location = new System.Drawing.Point(11, 15);
            this.pnlFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(461, 258);
            this.pnlFind.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 81);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 24);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gvSTK
            // 
            this.gvSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSTK.Location = new System.Drawing.Point(18, 138);
            this.gvSTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvSTK.Name = "gvSTK";
            this.gvSTK.RowHeadersWidth = 51;
            this.gvSTK.RowTemplate.Height = 24;
            this.gvSTK.Size = new System.Drawing.Size(440, 116);
            this.gvSTK.TabIndex = 2;
            this.gvSTK.Visible = false;
            this.gvSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSTK_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập CMND/CCCD:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(83, 101);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(102, 30);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Tìm kiếm";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(18, 54);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilter.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(439, 26);
            this.txtFilter.TabIndex = 10;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.AutoSize = true;
            this.pnlUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlUpdate.Controls.Add(this.txtSTK);
            this.pnlUpdate.Controls.Add(this.label2);
            this.pnlUpdate.Controls.Add(this.dtpDoB);
            this.pnlUpdate.Controls.Add(this.txtPNum);
            this.pnlUpdate.Controls.Add(this.txtID);
            this.pnlUpdate.Controls.Add(this.label4);
            this.pnlUpdate.Controls.Add(this.label8);
            this.pnlUpdate.Controls.Add(this.btnCreate);
            this.pnlUpdate.Controls.Add(this.txtAddr);
            this.pnlUpdate.Controls.Add(this.txtName);
            this.pnlUpdate.Controls.Add(this.label6);
            this.pnlUpdate.Controls.Add(this.label5);
            this.pnlUpdate.Controls.Add(this.label3);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.txtMoney);
            this.pnlUpdate.Controls.Add(this.btnDelete);
            this.pnlUpdate.Controls.Add(this.label7);
            this.pnlUpdate.Location = new System.Drawing.Point(17, 275);
            this.pnlUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(455, 566);
            this.pnlUpdate.TabIndex = 7;
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(227, 2);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.ReadOnly = true;
            this.txtSTK.Size = new System.Drawing.Size(224, 26);
            this.txtSTK.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "STK:";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(227, 205);
            this.dtpDoB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(224, 26);
            this.dtpDoB.TabIndex = 58;
            // 
            // txtPNum
            // 
            this.txtPNum.Location = new System.Drawing.Point(227, 344);
            this.txtPNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPNum.Name = "txtPNum";
            this.txtPNum.Size = new System.Drawing.Size(224, 26);
            this.txtPNum.TabIndex = 57;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(227, 278);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(224, 26);
            this.txtID.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 55;
            this.label4.Text = "Số ĐT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 22);
            this.label8.TabIndex = 54;
            this.label8.Text = "CMND/CCCD:";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(227, 135);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(224, 26);
            this.txtAddr.TabIndex = 53;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 26);
            this.txtName.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Ngày, tháng, năm sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Họ và tên:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(169, 502);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 60);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(227, 402);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(224, 26);
            this.txtMoney.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "Số tiền khả dụng:";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.pnlOption);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(490, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 662);
            this.panel3.TabIndex = 7;
            // 
            // pnlOption
            // 
            this.pnlOption.Location = new System.Drawing.Point(24, 44);
            this.pnlOption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(600, 780);
            this.pnlOption.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContractToolStripMenuItem,
            this.BorrowToolStripMenuItem,
            this.CreditToolStripMenuItem,
            this.SavingToolStripMenuItem,
            this.TransHistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(642, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WithdrawToolStripMenuItem,
            this.SendToolStripMenuItem,
            this.TransToolStripMenuItem});
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.ContractToolStripMenuItem.Text = "Giao dịch";
            // 
            // WithdrawToolStripMenuItem
            // 
            this.WithdrawToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WithdrawToolStripMenuItem.Name = "WithdrawToolStripMenuItem";
            this.WithdrawToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.WithdrawToolStripMenuItem.Text = "Rút tiền";
            this.WithdrawToolStripMenuItem.Click += new System.EventHandler(this.WithdrawToolStripMenuItem_Click);
            // 
            // SendToolStripMenuItem
            // 
            this.SendToolStripMenuItem.Name = "SendToolStripMenuItem";
            this.SendToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.SendToolStripMenuItem.Text = "Gửi tiền";
            this.SendToolStripMenuItem.Click += new System.EventHandler(this.SendToolStripMenuItem_Click);
            // 
            // TransToolStripMenuItem
            // 
            this.TransToolStripMenuItem.Name = "TransToolStripMenuItem";
            this.TransToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.TransToolStripMenuItem.Text = "Chuyển khoản";
            this.TransToolStripMenuItem.Click += new System.EventHandler(this.TransToolStripMenuItem_Click);
            // 
            // BorrowToolStripMenuItem
            // 
            this.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem";
            this.BorrowToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.BorrowToolStripMenuItem.Text = "Vay";
            this.BorrowToolStripMenuItem.Click += new System.EventHandler(this.BorrowToolStripMenuItem_Click);
            // 
            // CreditToolStripMenuItem
            // 
            this.CreditToolStripMenuItem.Name = "CreditToolStripMenuItem";
            this.CreditToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.CreditToolStripMenuItem.Text = "Tín dụng ";
            this.CreditToolStripMenuItem.Click += new System.EventHandler(this.CreditToolStripMenuItem_Click);
            // 
            // SavingToolStripMenuItem
            // 
            this.SavingToolStripMenuItem.Name = "SavingToolStripMenuItem";
            this.SavingToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.SavingToolStripMenuItem.Text = "Tài khoản tiết kiệm";
            this.SavingToolStripMenuItem.Click += new System.EventHandler(this.SavingToolStripMenuItem_Click);
            // 
            // TransHistoryToolStripMenuItem
            // 
            this.TransHistoryToolStripMenuItem.Name = "TransHistoryToolStripMenuItem";
            this.TransHistoryToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.TransHistoryToolStripMenuItem.Text = "Xem lịch sử giao dịch";
            this.TransHistoryToolStripMenuItem.Click += new System.EventHandler(this.TransHistoryToolStripMenuItem_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 855);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.pnlFind);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.pnlFind.ResumeLayout(false);
            this.pnlFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).EndInit();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WithdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransHistoryToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.TextBox txtPNum;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvSTK;
        private System.Windows.Forms.ToolStripMenuItem CreditToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
    }
}