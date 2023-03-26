﻿namespace PBL3_Demo4
{
    partial class FormQuanLy
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_user = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_info = new System.Windows.Forms.Panel();
            this.lbl_form = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_QuanLyDoanhThu = new FontAwesome.Sharp.IconButton();
            this.btn_QuanLyKhoHang = new FontAwesome.Sharp.IconButton();
            this.btn_QuanLySP = new FontAwesome.Sharp.IconButton();
            this.btn_QuanLyNV = new FontAwesome.Sharp.IconButton();
            this.btn_DangXuat = new FontAwesome.Sharp.IconButton();
            this.btn_ThietLapTK = new FontAwesome.Sharp.IconButton();
            this.btn_user = new FontAwesome.Sharp.IconButton();
            this.panel_menu.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.panel_menu.Controls.Add(this.btn_QuanLyDoanhThu);
            this.panel_menu.Controls.Add(this.btn_QuanLyKhoHang);
            this.panel_menu.Controls.Add(this.btn_QuanLySP);
            this.panel_menu.Controls.Add(this.btn_QuanLyNV);
            this.panel_menu.Controls.Add(this.panel_user);
            this.panel_menu.Controls.Add(this.btn_user);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(300, 853);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.Transparent;
            this.panel_user.Controls.Add(this.btn_DangXuat);
            this.panel_user.Controls.Add(this.btn_ThietLapTK);
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user.Location = new System.Drawing.Point(0, 270);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(300, 140);
            this.panel_user.TabIndex = 2;
            this.panel_user.Visible = false;
            // 
            // panel_logo
            // 
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(300, 200);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.lbl_form);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(300, 0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(1182, 50);
            this.panel_info.TabIndex = 1;
            // 
            // lbl_form
            // 
            this.lbl_form.AutoSize = true;
            this.lbl_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form.Location = new System.Drawing.Point(3, 9);
            this.lbl_form.Name = "lbl_form";
            this.lbl_form.Size = new System.Drawing.Size(102, 39);
            this.lbl_form.TabIndex = 0;
            this.lbl_form.Text = "Menu";
            // 
            // panel_main
            // 
            this.panel_main.BackgroundImage = global::PBL3_Demo4.Properties.Resources.icy2_5ebz_2211141;
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(300, 50);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1182, 803);
            this.panel_main.TabIndex = 2;
            // 
            // btn_QuanLyDoanhThu
            // 
            this.btn_QuanLyDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.btn_QuanLyDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_QuanLyDoanhThu.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_QuanLyDoanhThu.IconColor = System.Drawing.Color.Black;
            this.btn_QuanLyDoanhThu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLyDoanhThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyDoanhThu.Location = new System.Drawing.Point(0, 620);
            this.btn_QuanLyDoanhThu.Name = "btn_QuanLyDoanhThu";
            this.btn_QuanLyDoanhThu.Size = new System.Drawing.Size(300, 70);
            this.btn_QuanLyDoanhThu.TabIndex = 6;
            this.btn_QuanLyDoanhThu.Text = "   Quản lý doanh thu";
            this.btn_QuanLyDoanhThu.UseVisualStyleBackColor = false;
            // 
            // btn_QuanLyKhoHang
            // 
            this.btn_QuanLyKhoHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.btn_QuanLyKhoHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyKhoHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_QuanLyKhoHang.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_QuanLyKhoHang.IconColor = System.Drawing.Color.Black;
            this.btn_QuanLyKhoHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLyKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyKhoHang.Location = new System.Drawing.Point(0, 550);
            this.btn_QuanLyKhoHang.Name = "btn_QuanLyKhoHang";
            this.btn_QuanLyKhoHang.Size = new System.Drawing.Size(300, 70);
            this.btn_QuanLyKhoHang.TabIndex = 5;
            this.btn_QuanLyKhoHang.Text = "   Quản lý kho hàng";
            this.btn_QuanLyKhoHang.UseVisualStyleBackColor = false;
            // 
            // btn_QuanLySP
            // 
            this.btn_QuanLySP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.btn_QuanLySP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLySP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLySP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLySP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_QuanLySP.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.btn_QuanLySP.IconColor = System.Drawing.Color.Black;
            this.btn_QuanLySP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLySP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLySP.Location = new System.Drawing.Point(0, 480);
            this.btn_QuanLySP.Name = "btn_QuanLySP";
            this.btn_QuanLySP.Size = new System.Drawing.Size(300, 70);
            this.btn_QuanLySP.TabIndex = 4;
            this.btn_QuanLySP.Text = "   Quản lý sản phẩm";
            this.btn_QuanLySP.UseVisualStyleBackColor = false;
            // 
            // btn_QuanLyNV
            // 
            this.btn_QuanLyNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.btn_QuanLyNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLyNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_QuanLyNV.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_QuanLyNV.IconColor = System.Drawing.Color.Black;
            this.btn_QuanLyNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLyNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLyNV.Location = new System.Drawing.Point(0, 410);
            this.btn_QuanLyNV.Name = "btn_QuanLyNV";
            this.btn_QuanLyNV.Size = new System.Drawing.Size(300, 70);
            this.btn_QuanLyNV.TabIndex = 3;
            this.btn_QuanLyNV.Text = "   Quản lý nhân viên";
            this.btn_QuanLyNV.UseVisualStyleBackColor = false;
            this.btn_QuanLyNV.Click += new System.EventHandler(this.btn_QuanLyNV_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_DangXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_DangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_DangXuat.IconColor = System.Drawing.Color.Black;
            this.btn_DangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 70);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(300, 70);
            this.btn_DangXuat.TabIndex = 3;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_ThietLapTK
            // 
            this.btn_ThietLapTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_ThietLapTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThietLapTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThietLapTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThietLapTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ThietLapTK.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btn_ThietLapTK.IconColor = System.Drawing.Color.Black;
            this.btn_ThietLapTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ThietLapTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThietLapTK.Location = new System.Drawing.Point(0, 0);
            this.btn_ThietLapTK.Name = "btn_ThietLapTK";
            this.btn_ThietLapTK.Size = new System.Drawing.Size(300, 70);
            this.btn_ThietLapTK.TabIndex = 2;
            this.btn_ThietLapTK.Text = "   Thiết lập tài khoản";
            this.btn_ThietLapTK.UseVisualStyleBackColor = false;
            this.btn_ThietLapTK.Click += new System.EventHandler(this.btn_ThietLapTK_Click);
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(114)))));
            this.btn_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_user.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_user.IconColor = System.Drawing.Color.Black;
            this.btn_user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user.Location = new System.Drawing.Point(0, 200);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(300, 70);
            this.btn_user.TabIndex = 1;
            this.btn_user.Text = "User";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // FormQuanLy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_menu);
            this.Name = "FormQuanLy";
            this.Text = "Form Quản Lý";
            this.panel_menu.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private FontAwesome.Sharp.IconButton btn_user;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_user;
        private FontAwesome.Sharp.IconButton btn_DangXuat;
        private FontAwesome.Sharp.IconButton btn_ThietLapTK;
        private FontAwesome.Sharp.IconButton btn_QuanLyNV;
        private FontAwesome.Sharp.IconButton btn_QuanLySP;
        private FontAwesome.Sharp.IconButton btn_QuanLyDoanhThu;
        private FontAwesome.Sharp.IconButton btn_QuanLyKhoHang;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label lbl_form;
        private System.Windows.Forms.Panel panel_main;
    }
}