using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using LanMessengerLib;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Threading;
using System.Net;

namespace Lan_Messenger
{
	/// <summary>
	/// Summary description for FormSignIn.
	/// </summary>
	public class FormSignIn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCreateAccount_1;
		internal System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.Button btnCancel;
		private System.ComponentModel.IContainer components;
        private System.Windows.Forms.CheckBox chkInvisible;
        private Panel panel2;
        private TextBox txt_DisName_R;
        private TextBox txtconfirm_R;
        private TextBox txt_Pass_R;
        private TextBox txt_user_R;
        private Button btn_Register;
        private Label label5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label6;
        private Label lb_change_pass;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private System.Windows.Forms.Button btnChangePassword_1;

		public FormSignIn()
		{
			//
			// Required for Windows Form Designer support
			//            
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount_1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkInvisible = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangePassword_1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_DisName_R = new System.Windows.Forms.TextBox();
            this.txtconfirm_R = new System.Windows.Forms.TextBox();
            this.txt_Pass_R = new System.Windows.Forms.TextBox();
            this.txt_user_R = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_change_pass = new System.Windows.Forms.Label();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateAccount_1);
            this.PanelTransition.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(346, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn chưa có tài khoản?";
            // 
            // btnCreateAccount_1
            // 
            this.PanelTransition.SetDecoration(this.btnCreateAccount_1, BunifuAnimatorNS.DecorationType.None);
            this.btnCreateAccount_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCreateAccount_1.Location = new System.Drawing.Point(67, 16);
            this.btnCreateAccount_1.Name = "btnCreateAccount_1";
            this.btnCreateAccount_1.Size = new System.Drawing.Size(120, 24);
            this.btnCreateAccount_1.TabIndex = 0;
            this.btnCreateAccount_1.Text = "Tạo tài khoản mới";
            this.btnCreateAccount_1.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnChangePassword_1);
            this.groupBox2.Controls.Add(this.label1);
            this.PanelTransition.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(346, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bạn đã có tài khoản rồi?";
            // 
            // chkInvisible
            // 
            this.PanelTransition.SetDecoration(this.chkInvisible, BunifuAnimatorNS.DecorationType.None);
            this.chkInvisible.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkInvisible.Location = new System.Drawing.Point(51, 245);
            this.chkInvisible.Name = "chkInvisible";
            this.chkInvisible.Size = new System.Drawing.Size(112, 16);
            this.chkInvisible.TabIndex = 3;
            this.chkInvisible.Text = "Đăng nhập ẩn";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PanelTransition.SetDecoration(this.txtPassword, BunifuAnimatorNS.DecorationType.None);
            this.txtPassword.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(45, 212);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "123446";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PanelTransition.SetDecoration(this.txtUsername, BunifuAnimatorNS.DecorationType.None);
            this.txtUsername.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsername.Location = new System.Drawing.Point(45, 164);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(211, 21);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            // 
            // label2
            // 
            this.PanelTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên tài khoản :";
            // 
            // btnSignIn
            // 
            this.PanelTransition.SetDecoration(this.btnSignIn, BunifuAnimatorNS.DecorationType.None);
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.btnSignIn.Location = new System.Drawing.Point(50, 271);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(206, 39);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Đăng Nhập";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnCancel
            // 
            this.PanelTransition.SetDecoration(this.btnCancel, BunifuAnimatorNS.DecorationType.None);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(90, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            // 
            // btnChangePassword_1
            // 
            this.PanelTransition.SetDecoration(this.btnChangePassword_1, BunifuAnimatorNS.DecorationType.None);
            this.btnChangePassword_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangePassword_1.Location = new System.Drawing.Point(164, 119);
            this.btnChangePassword_1.Name = "btnChangePassword_1";
            this.btnChangePassword_1.Size = new System.Drawing.Size(112, 24);
            this.btnChangePassword_1.TabIndex = 3;
            this.btnChangePassword_1.Text = "Thay đổi mật khẩu";
            this.btnChangePassword_1.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.txt_DisName_R);
            this.panel2.Controls.Add(this.txtconfirm_R);
            this.panel2.Controls.Add(this.txt_Pass_R);
            this.panel2.Controls.Add(this.txt_user_R);
            this.panel2.Controls.Add(this.btn_Register);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bunifuSeparator7);
            this.panel2.Controls.Add(this.bunifuSeparator8);
            this.panel2.Controls.Add(this.bunifuSeparator5);
            this.panel2.Controls.Add(this.bunifuSeparator6);
            this.PanelTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 448);
            this.panel2.TabIndex = 11;
            // 
            // txt_DisName_R
            // 
            this.txt_DisName_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.txt_DisName_R.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PanelTransition.SetDecoration(this.txt_DisName_R, BunifuAnimatorNS.DecorationType.None);
            this.txt_DisName_R.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DisName_R.ForeColor = System.Drawing.Color.White;
            this.txt_DisName_R.Location = new System.Drawing.Point(44, 274);
            this.txt_DisName_R.Multiline = true;
            this.txt_DisName_R.Name = "txt_DisName_R";
            this.txt_DisName_R.Size = new System.Drawing.Size(211, 20);
            this.txt_DisName_R.TabIndex = 23;
            this.txt_DisName_R.Text = "DisplayName";
            // 
            // txtconfirm_R
            // 
            this.txtconfirm_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.txtconfirm_R.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PanelTransition.SetDecoration(this.txtconfirm_R, BunifuAnimatorNS.DecorationType.None);
            this.txtconfirm_R.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirm_R.ForeColor = System.Drawing.Color.White;
            this.txtconfirm_R.Location = new System.Drawing.Point(44, 225);
            this.txtconfirm_R.Multiline = true;
            this.txtconfirm_R.Name = "txtconfirm_R";
            this.txtconfirm_R.Size = new System.Drawing.Size(211, 20);
            this.txtconfirm_R.TabIndex = 22;
            this.txtconfirm_R.Text = "Re - Password";
            // 
            // txt_Pass_R
            // 
            this.txt_Pass_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.txt_Pass_R.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PanelTransition.SetDecoration(this.txt_Pass_R, BunifuAnimatorNS.DecorationType.None);
            this.txt_Pass_R.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass_R.ForeColor = System.Drawing.Color.White;
            this.txt_Pass_R.Location = new System.Drawing.Point(44, 177);
            this.txt_Pass_R.Multiline = true;
            this.txt_Pass_R.Name = "txt_Pass_R";
            this.txt_Pass_R.Size = new System.Drawing.Size(211, 20);
            this.txt_Pass_R.TabIndex = 21;
            this.txt_Pass_R.Text = "Password";
            // 
            // txt_user_R
            // 
            this.txt_user_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.txt_user_R.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PanelTransition.SetDecoration(this.txt_user_R, BunifuAnimatorNS.DecorationType.None);
            this.txt_user_R.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_R.ForeColor = System.Drawing.Color.White;
            this.txt_user_R.Location = new System.Drawing.Point(44, 128);
            this.txt_user_R.Multiline = true;
            this.txt_user_R.Name = "txt_user_R";
            this.txt_user_R.Size = new System.Drawing.Size(211, 20);
            this.txt_user_R.TabIndex = 20;
            this.txt_user_R.Text = "Username";
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.btn_Register, BunifuAnimatorNS.DecorationType.None);
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(46, 328);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(206, 42);
            this.btn_Register.TabIndex = 10;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Login";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.bunifuSeparator7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator7.LineThickness = 2;
            this.bunifuSeparator7.Location = new System.Drawing.Point(44, 300);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(210, 3);
            this.bunifuSeparator7.TabIndex = 19;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.bunifuSeparator8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator8.LineThickness = 2;
            this.bunifuSeparator8.Location = new System.Drawing.Point(44, 251);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(210, 3);
            this.bunifuSeparator8.TabIndex = 17;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = false;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.bunifuSeparator5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator5.LineThickness = 2;
            this.bunifuSeparator5.Location = new System.Drawing.Point(44, 203);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(210, 3);
            this.bunifuSeparator5.TabIndex = 15;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.bunifuSeparator6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator6.LineThickness = 2;
            this.bunifuSeparator6.Location = new System.Drawing.Point(45, 154);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(210, 3);
            this.bunifuSeparator6.TabIndex = 13;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Controls.Add(this.chkInvisible);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lb_change_pass);
            this.panel1.Controls.Add(this.bunifuSeparator4);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.PanelTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 448);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.PanelTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelTransition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(48, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Register";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(99, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Forgot the password?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_change_pass
            // 
            this.lb_change_pass.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelTransition.SetDecoration(this.lb_change_pass, BunifuAnimatorNS.DecorationType.None);
            this.lb_change_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lb_change_pass.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_change_pass.Location = new System.Drawing.Point(99, 388);
            this.lb_change_pass.Name = "lb_change_pass";
            this.lb_change_pass.Size = new System.Drawing.Size(123, 23);
            this.lb_change_pass.TabIndex = 13;
            this.lb_change_pass.Text = "Change the password...";
            this.lb_change_pass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_change_pass.Click += new System.EventHandler(this.lb_change_pass_Click);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.bunifuSeparator4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(45, 235);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(210, 3);
            this.bunifuSeparator4.TabIndex = 12;
            this.bunifuSeparator4.Transparency = 100;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(45, 191);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(210, 3);
            this.bunifuSeparator3.TabIndex = 11;
            this.bunifuSeparator3.Transparency = 100;
            this.bunifuSeparator3.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.PanelTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(153, 2);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(105, 10);
            this.bunifuSeparator2.TabIndex = 9;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.PanelTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(48, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(105, 10);
            this.bunifuSeparator1.TabIndex = 8;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.PanelTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation4;
            // 
            // FormSignIn
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(302, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSignIn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormSignIn_Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnCreateAccount_Click(object sender, System.EventArgs e)
		{
			FormCreateAccount frmCreateAccount = new FormCreateAccount();
			if(frmCreateAccount.ShowDialog()==DialogResult.OK)
			{
				txtUsername.Text=frmCreateAccount.txtUsername.Text;
				txtPassword.Text=frmCreateAccount.txtPassword.Text;
			}
		}
		private void btnSignIn_Click(object sender, System.EventArgs e)
		{            
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    if (Global.server.SignIn(txtUsername.Text, txtPassword.Text, !chkInvisible.Checked))
                    {
                        // Ghi địa chỉ IP của user đăng nhập
                        IPHostEntry temp = Dns.GetHostByName(Dns.GetHostName().ToString());
                        string IP = temp.AddressList[0].ToString();
                        Global.server.SetIP(txtUsername.Text, IP);
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng kiểm tra lại!","Lỗi đăng nhập...");
                        this.DialogResult = DialogResult.None;
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối tới Server. Vui lòng kiểm tra kết nối và thử lại!", "Lỗi kết nối...");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                MessageBox.Show("Lỗi! Vui lòng nhập tên tài khoản và mật khẩu!", "Lỗi đăng nhập...");
                this.DialogResult = DialogResult.None;
            }
		}

		private void FormSignIn_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(this.DialogResult==DialogResult.None)
			{
				e.Cancel=true;
			}
		}

		private void btnChangePassword_Click(object sender, System.EventArgs e)
		{
			FormChangePassword frmChangePassword = new FormChangePassword();
			frmChangePassword.txtUsername.Text=txtUsername.Text;
			frmChangePassword.txtCurPassword.Text=txtPassword.Text;
			if(frmChangePassword.ShowDialog()==DialogResult.OK)
			{
				txtUsername.Text=frmChangePassword.txtUsername.Text;
				txtPassword.Text=frmChangePassword.txtNewPassword.Text;
			}
		}

        private void label5_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 300)
            {
                panel2.Visible = false;
                panel2.Width = 0;
                PanelTransition.ShowSync(panel2);

            }
            else
            {

                panel2.Visible = false;
                panel2.Width = 300;
                PanelTransition.ShowSync(panel2);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 0)
            {
                panel2.Visible = false;
                panel2.Width = 300;
                PanelTransition.ShowSync(panel2);

            }
            else
            {

                panel1.Visible = false;
                panel1.Width = 0;
                PanelTransition.ShowSync(panel2);
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Pass_R.Text == txtconfirm_R.Text)
            {
                try
                {
                    IPHostEntry temp = Dns.GetHostByName(Dns.GetHostName().ToString());
                    string IP = temp.AddressList[0].ToString(); // IP máy phản hồi
                    if (Global.server.SignUp(txt_user_R.Text, txt_Pass_R.Text, txt_DisName_R.Text, IP))
                    {
                        MessageBox.Show("Account created successfully.", "Create Account...");
                        txtUsername.Text = txt_user_R.Text;
                        txtPassword.Text = txt_Pass_R.Text;
                    }
                    else
                    {
                        MessageBox.Show("This account has already been used.", "Error...");
                        this.DialogResult = DialogResult.None;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    // MessageBox.Show("Lỗi kết nối tới Server. Hãy kiểm tra kết nối và thử lại!.", "Lỗi kết nối...");
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "Error...");
                this.DialogResult = DialogResult.None;
            }
        }

        private void lb_change_pass_Click(object sender, EventArgs e)
        {
            FormChangePassword frmChangePassword = new FormChangePassword();
            frmChangePassword.txtUsername.Text = txtUsername.Text;
            frmChangePassword.txtCurPassword.Text = txtPassword.Text;
            if (frmChangePassword.ShowDialog() == DialogResult.OK)
            {
                txtUsername.Text = frmChangePassword.txtUsername.Text;
                txtPassword.Text = frmChangePassword.txtNewPassword.Text;
            }
        }
    }
}
