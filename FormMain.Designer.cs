namespace PassGenerator
{
   partial class FormMain
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
         components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
         imEllipseControl1 = new IMControls.CustomControls.IMEllipseControl();
         pictureBox1 = new PictureBox();
         label1 = new Label();
         txt_Senha = new IMControls.CustomControls.IMTextBox();
         check_Numbers = new IMControls.CustomControls.IMSwitchButton();
         label2 = new Label();
         check_Lower = new IMControls.CustomControls.IMSwitchButton();
         label3 = new Label();
         check_Upper = new IMControls.CustomControls.IMSwitchButton();
         label4 = new Label();
         check_Symbol = new IMControls.CustomControls.IMSwitchButton();
         label5 = new Label();
         label6 = new Label();
         trackBar1 = new TrackBar();
         lbl_Tamanho = new Label();
         btn_Gerar = new IMControls.CustomControls.IMButton();
         imGradientPanel1 = new IMControls.CustomControls.IMGradientPanel();
         label8 = new Label();
         label9 = new Label();
         btn_Close = new Button();
         btn_Copy = new IMControls.CustomControls.IMButton();
         toolTip1 = new ToolTip(components);
         ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
         ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
         SuspendLayout();
         // 
         // imEllipseControl1
         // 
         imEllipseControl1.CornerRadius = 45;
         imEllipseControl1.TargetControl = this;
         // 
         // pictureBox1
         // 
         pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
         pictureBox1.Location = new Point(139, 46);
         pictureBox1.Name = "pictureBox1";
         pictureBox1.Size = new Size(141, 95);
         pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
         pictureBox1.TabIndex = 0;
         pictureBox1.TabStop = false;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
         label1.ForeColor = Color.Gainsboro;
         label1.Location = new Point(111, 147);
         label1.Name = "label1";
         label1.Size = new Size(202, 23);
         label1.TabIndex = 1;
         label1.Text = "PASS GENERATOR 1.0";
         // 
         // txt_Senha
         // 
         txt_Senha.BackColor = Color.FromArgb(245, 173, 10);
         txt_Senha.BorderColor = Color.MediumSlateBlue;
         txt_Senha.BorderFocusColor = Color.HotPink;
         txt_Senha.BorderRadius = 10;
         txt_Senha.BorderSize = 2;
         txt_Senha.CharacterCasing = CharacterCasing.Normal;
         txt_Senha.Font = new Font("Consolas", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
         txt_Senha.ForeColor = Color.FromArgb(35, 35, 35);
         txt_Senha.Location = new Point(37, 187);
         txt_Senha.Margin = new Padding(4);
         txt_Senha.MaxLength = 16;
         txt_Senha.Multiline = true;
         txt_Senha.Name = "txt_Senha";
         txt_Senha.Padding = new Padding(7);
         txt_Senha.PasswordChar = false;
         txt_Senha.PlaceholderColor = Color.DarkGray;
         txt_Senha.PlaceholderText = "";
         txt_Senha.ReadOnly = true;
         txt_Senha.Size = new Size(360, 50);
         txt_Senha.TabIndex = 2;
         txt_Senha.TextAlign = HorizontalAlignment.Center;
         txt_Senha.Texts = "12345aaKKKK0O";
         txt_Senha.UnderlinedStyle = false;
         // 
         // check_Numbers
         // 
         check_Numbers.Checked = true;
         check_Numbers.CheckState = CheckState.Checked;
         check_Numbers.Location = new Point(151, 260);
         check_Numbers.MinimumSize = new Size(30, 20);
         check_Numbers.Name = "check_Numbers";
         check_Numbers.OffBackColor = Color.FromArgb(140, 130, 150);
         check_Numbers.OffToggleColor = Color.White;
         check_Numbers.OnBackColor = Color.FromArgb(43, 185, 89);
         check_Numbers.OnToggleColor = Color.White;
         check_Numbers.Size = new Size(50, 20);
         check_Numbers.TabIndex = 3;
         check_Numbers.Tag = "0123456789";
         check_Numbers.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
         label2.ForeColor = Color.Gainsboro;
         label2.Location = new Point(203, 261);
         label2.Name = "label2";
         label2.Size = new Size(73, 18);
         label2.TabIndex = 4;
         label2.Text = "Números";
         // 
         // check_Lower
         // 
         check_Lower.Checked = true;
         check_Lower.CheckState = CheckState.Checked;
         check_Lower.Location = new Point(151, 292);
         check_Lower.MinimumSize = new Size(30, 20);
         check_Lower.Name = "check_Lower";
         check_Lower.OffBackColor = Color.FromArgb(140, 130, 150);
         check_Lower.OffToggleColor = Color.White;
         check_Lower.OnBackColor = Color.FromArgb(43, 185, 89);
         check_Lower.OnToggleColor = Color.White;
         check_Lower.Size = new Size(50, 20);
         check_Lower.TabIndex = 3;
         check_Lower.Tag = "abcdefghijklmnopqrstuvwxyz";
         check_Lower.UseVisualStyleBackColor = true;
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
         label3.ForeColor = Color.Gainsboro;
         label3.Location = new Point(203, 293);
         label3.Name = "label3";
         label3.Size = new Size(83, 18);
         label3.TabIndex = 4;
         label3.Text = "Minúsculo";
         // 
         // check_Upper
         // 
         check_Upper.Checked = true;
         check_Upper.CheckState = CheckState.Checked;
         check_Upper.Location = new Point(151, 324);
         check_Upper.MinimumSize = new Size(30, 20);
         check_Upper.Name = "check_Upper";
         check_Upper.OffBackColor = Color.FromArgb(140, 130, 150);
         check_Upper.OffToggleColor = Color.White;
         check_Upper.OnBackColor = Color.FromArgb(43, 185, 89);
         check_Upper.OnToggleColor = Color.White;
         check_Upper.Size = new Size(50, 20);
         check_Upper.TabIndex = 3;
         check_Upper.Tag = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
         check_Upper.UseVisualStyleBackColor = true;
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
         label4.ForeColor = Color.Gainsboro;
         label4.Location = new Point(203, 325);
         label4.Name = "label4";
         label4.Size = new Size(84, 18);
         label4.TabIndex = 4;
         label4.Text = "Maiúsculo";
         // 
         // check_Symbol
         // 
         check_Symbol.Checked = true;
         check_Symbol.CheckState = CheckState.Checked;
         check_Symbol.Location = new Point(151, 356);
         check_Symbol.MinimumSize = new Size(30, 20);
         check_Symbol.Name = "check_Symbol";
         check_Symbol.OffBackColor = Color.FromArgb(140, 130, 150);
         check_Symbol.OffToggleColor = Color.White;
         check_Symbol.OnBackColor = Color.FromArgb(43, 185, 89);
         check_Symbol.OnToggleColor = Color.White;
         check_Symbol.Size = new Size(50, 20);
         check_Symbol.TabIndex = 3;
         check_Symbol.Tag = "!@#$%&*-+=?<>.{}:";
         check_Symbol.UseVisualStyleBackColor = true;
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
         label5.ForeColor = Color.Gainsboro;
         label5.Location = new Point(203, 357);
         label5.Name = "label5";
         label5.Size = new Size(74, 18);
         label5.TabIndex = 4;
         label5.Text = "Símbolos";
         // 
         // label6
         // 
         label6.AutoSize = true;
         label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
         label6.ForeColor = Color.Gainsboro;
         label6.Location = new Point(37, 389);
         label6.Name = "label6";
         label6.Size = new Size(84, 19);
         label6.TabIndex = 5;
         label6.Text = "Tamanho";
         // 
         // trackBar1
         // 
         trackBar1.Location = new Point(37, 411);
         trackBar1.Maximum = 16;
         trackBar1.Minimum = 1;
         trackBar1.Name = "trackBar1";
         trackBar1.Size = new Size(350, 45);
         trackBar1.TabIndex = 6;
         trackBar1.TickStyle = TickStyle.None;
         trackBar1.Value = 1;
         trackBar1.Scroll += trackBar1_Scroll;
         // 
         // lbl_Tamanho
         // 
         lbl_Tamanho.AutoSize = true;
         lbl_Tamanho.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
         lbl_Tamanho.ForeColor = Color.Gainsboro;
         lbl_Tamanho.Location = new Point(383, 408);
         lbl_Tamanho.Name = "lbl_Tamanho";
         lbl_Tamanho.Size = new Size(21, 23);
         lbl_Tamanho.TabIndex = 7;
         lbl_Tamanho.Text = "0";
         lbl_Tamanho.TextAlign = ContentAlignment.MiddleLeft;
         // 
         // btn_Gerar
         // 
         btn_Gerar.BackColor = Color.FromArgb(212, 68, 80);
         btn_Gerar.BackgroundColor = Color.FromArgb(212, 68, 80);
         btn_Gerar.BorderColor = Color.Gainsboro;
         btn_Gerar.BorderRadius = 10;
         btn_Gerar.BorderSize = 1;
         btn_Gerar.FlatAppearance.BorderSize = 0;
         btn_Gerar.FlatStyle = FlatStyle.Flat;
         btn_Gerar.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
         btn_Gerar.ForeColor = Color.WhiteSmoke;
         btn_Gerar.Location = new Point(37, 460);
         btn_Gerar.Name = "btn_Gerar";
         btn_Gerar.Size = new Size(360, 50);
         btn_Gerar.TabIndex = 8;
         btn_Gerar.Text = "&GERAR";
         btn_Gerar.TextColor = Color.WhiteSmoke;
         btn_Gerar.UseVisualStyleBackColor = false;
         btn_Gerar.Click += btn_Gerar_Click;
         // 
         // imGradientPanel1
         // 
         imGradientPanel1.BackColor = Color.White;
         imGradientPanel1.BorderRadius = 0;
         imGradientPanel1.ForeColor = Color.Black;
         imGradientPanel1.GradientAngle = 90F;
         imGradientPanel1.GradientBottomColor = Color.FromArgb(0, 0, 192);
         imGradientPanel1.GradientTopColor = Color.FromArgb(44, 67, 212);
         imGradientPanel1.Location = new Point(43, 547);
         imGradientPanel1.Name = "imGradientPanel1";
         imGradientPanel1.Size = new Size(351, 3);
         imGradientPanel1.TabIndex = 9;
         // 
         // label8
         // 
         label8.AutoSize = true;
         label8.Font = new Font("Century Gothic", 8F);
         label8.ForeColor = SystemColors.ControlDark;
         label8.Location = new Point(43, 551);
         label8.Name = "label8";
         label8.Size = new Size(51, 16);
         label8.TabIndex = 10;
         label8.Text = "©Itamar";
         // 
         // label9
         // 
         label9.AutoSize = true;
         label9.Font = new Font("Century Gothic", 8F);
         label9.ForeColor = SystemColors.ControlDark;
         label9.Location = new Point(361, 551);
         label9.Name = "label9";
         label9.Size = new Size(31, 16);
         label9.TabIndex = 10;
         label9.Text = "2024";
         label9.TextAlign = ContentAlignment.MiddleRight;
         // 
         // btn_Close
         // 
         btn_Close.FlatAppearance.BorderSize = 0;
         btn_Close.FlatStyle = FlatStyle.Flat;
         btn_Close.Font = new Font("Segoe UI", 12F);
         btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
         btn_Close.Location = new Point(395, 14);
         btn_Close.Name = "btn_Close";
         btn_Close.Size = new Size(30, 25);
         btn_Close.TabIndex = 11;
         btn_Close.UseVisualStyleBackColor = true;
         btn_Close.Click += btn_Close_Click;
         // 
         // btn_Copy
         // 
         btn_Copy.BackColor = Color.FromArgb(245, 173, 10);
         btn_Copy.BackgroundColor = Color.FromArgb(245, 173, 10);
         btn_Copy.BorderColor = Color.FromArgb(51, 67, 190);
         btn_Copy.BorderRadius = 0;
         btn_Copy.BorderSize = 0;
         btn_Copy.FlatAppearance.BorderSize = 0;
         btn_Copy.FlatStyle = FlatStyle.Flat;
         btn_Copy.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
         btn_Copy.ForeColor = Color.WhiteSmoke;
         btn_Copy.Image = (Image)resources.GetObject("btn_Copy.Image");
         btn_Copy.Location = new Point(351, 191);
         btn_Copy.Name = "btn_Copy";
         btn_Copy.Size = new Size(40, 42);
         btn_Copy.TabIndex = 12;
         btn_Copy.TextColor = Color.WhiteSmoke;
         btn_Copy.TextImageRelation = TextImageRelation.ImageBeforeText;
         toolTip1.SetToolTip(btn_Copy, "Copiar");
         btn_Copy.UseVisualStyleBackColor = false;
         btn_Copy.Click += btn_Copy_Click;
         // 
         // toolTip1
         // 
         toolTip1.IsBalloon = true;
         // 
         // FormMain
         // 
         AutoScaleMode = AutoScaleMode.None;
         BackColor = Color.FromArgb(50, 60, 150);
         ClientSize = new Size(440, 580);
         Controls.Add(btn_Copy);
         Controls.Add(btn_Close);
         Controls.Add(label9);
         Controls.Add(label8);
         Controls.Add(imGradientPanel1);
         Controls.Add(btn_Gerar);
         Controls.Add(lbl_Tamanho);
         Controls.Add(trackBar1);
         Controls.Add(label6);
         Controls.Add(label5);
         Controls.Add(check_Symbol);
         Controls.Add(label4);
         Controls.Add(check_Upper);
         Controls.Add(label3);
         Controls.Add(check_Lower);
         Controls.Add(label2);
         Controls.Add(check_Numbers);
         Controls.Add(txt_Senha);
         Controls.Add(label1);
         Controls.Add(pictureBox1);
         FormBorderStyle = FormBorderStyle.None;
         Name = "FormMain";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "FormMain";
         Load += FormMain_Load;
         Shown += FormMain_Shown;
         ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
         ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private IMControls.CustomControls.IMEllipseControl imEllipseControl1;
      private PictureBox pictureBox1;
      private Label label1;
      private IMControls.CustomControls.IMTextBox txt_Senha;
      private IMControls.CustomControls.IMSwitchButton check_Numbers;
      private Label label2;
      private TrackBar trackBar1;
      private Label label6;
      private Label label5;
      private IMControls.CustomControls.IMSwitchButton check_Symbol;
      private Label label4;
      private IMControls.CustomControls.IMSwitchButton check_Upper;
      private Label label3;
      private IMControls.CustomControls.IMSwitchButton check_Lower;
      private IMControls.CustomControls.IMButton btn_Gerar;
      private Label lbl_Tamanho;
      private Label label8;
      private IMControls.CustomControls.IMGradientPanel imGradientPanel1;
      private Label label9;
      private Button btn_Close;
      private IMControls.CustomControls.IMButton btn_Copy;
      private ToolTip toolTip1;
   }
}