namespace Steam_Accunt_Restorrer_Note
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            appPanel = new Panel();
            MinimazeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            MaximazeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            CloseBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            sidebarPanel = new ReaLTaiizor.Controls.MetroPanel();
            instructionsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            infoBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox2 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox3 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox4 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox5 = new ReaLTaiizor.Controls.MaterialCheckBox();
            materialCheckBox6 = new ReaLTaiizor.Controls.MaterialCheckBox();
            cb1 = new ReaLTaiizor.Controls.HopeCheckBox();
            lostPanel1 = new ReaLTaiizor.Controls.LostPanel();
            resultBtn = new ReaLTaiizor.Controls.ForeverButton();
            cb6 = new ReaLTaiizor.Controls.HopeCheckBox();
            cb5 = new ReaLTaiizor.Controls.HopeCheckBox();
            cb4 = new ReaLTaiizor.Controls.HopeCheckBox();
            cb3 = new ReaLTaiizor.Controls.HopeCheckBox();
            cb23 = new ReaLTaiizor.Controls.HopeCheckBox();
            cb22 = new ReaLTaiizor.Controls.HopeCheckBox();
            cb21 = new ReaLTaiizor.Controls.HopeCheckBox();
            mainText = new RichTextBox();
            appPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            lostPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // appPanel
            // 
            appPanel.BackColor = Color.Gray;
            appPanel.Controls.Add(MinimazeBtn);
            appPanel.Controls.Add(MaximazeBtn);
            appPanel.Controls.Add(CloseBtn);
            appPanel.Dock = DockStyle.Top;
            appPanel.Location = new Point(0, 0);
            appPanel.Margin = new Padding(3, 4, 3, 4);
            appPanel.Name = "appPanel";
            appPanel.Size = new Size(1461, 33);
            appPanel.TabIndex = 0;
            appPanel.Paint += appPanel_Paint;
            appPanel.MouseDown += appPanel_MouseDown;
            // 
            // MinimazeBtn
            // 
            MinimazeBtn.ActiveBorderThickness = 2;
            MinimazeBtn.ActiveCornerRadius = 15;
            MinimazeBtn.ActiveFillColor = Color.SeaGreen;
            MinimazeBtn.ActiveForecolor = Color.White;
            MinimazeBtn.ActiveLineColor = Color.SeaGreen;
            MinimazeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimazeBtn.BackColor = Color.Gray;
            MinimazeBtn.BackgroundImage = (Image)resources.GetObject("MinimazeBtn.BackgroundImage");
            MinimazeBtn.ButtonText = "-";
            MinimazeBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinimazeBtn.ForeColor = Color.SeaGreen;
            MinimazeBtn.IdleBorderThickness = 2;
            MinimazeBtn.IdleCornerRadius = 15;
            MinimazeBtn.IdleFillColor = Color.White;
            MinimazeBtn.IdleForecolor = Color.SeaGreen;
            MinimazeBtn.IdleLineColor = Color.SeaGreen;
            MinimazeBtn.Location = new Point(1379, -2);
            MinimazeBtn.Margin = new Padding(5);
            MinimazeBtn.Name = "MinimazeBtn";
            MinimazeBtn.Padding = new Padding(3, 0, 0, 2);
            MinimazeBtn.Size = new Size(25, 35);
            MinimazeBtn.TabIndex = 1;
            MinimazeBtn.TextAlign = ContentAlignment.MiddleCenter;
            MinimazeBtn.Click += MinimazeBtn_Click;
            // 
            // MaximazeBtn
            // 
            MaximazeBtn.ActiveBorderThickness = 2;
            MaximazeBtn.ActiveCornerRadius = 15;
            MaximazeBtn.ActiveFillColor = Color.SeaGreen;
            MaximazeBtn.ActiveForecolor = Color.White;
            MaximazeBtn.ActiveLineColor = Color.SeaGreen;
            MaximazeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximazeBtn.BackColor = Color.Gray;
            MaximazeBtn.BackgroundImage = (Image)resources.GetObject("MaximazeBtn.BackgroundImage");
            MaximazeBtn.ButtonText = "o";
            MaximazeBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaximazeBtn.ForeColor = Color.SeaGreen;
            MaximazeBtn.IdleBorderThickness = 2;
            MaximazeBtn.IdleCornerRadius = 15;
            MaximazeBtn.IdleFillColor = Color.White;
            MaximazeBtn.IdleForecolor = Color.SeaGreen;
            MaximazeBtn.IdleLineColor = Color.SeaGreen;
            MaximazeBtn.Location = new Point(1405, -2);
            MaximazeBtn.Margin = new Padding(5);
            MaximazeBtn.Name = "MaximazeBtn";
            MaximazeBtn.Padding = new Padding(3, 0, 0, 2);
            MaximazeBtn.Size = new Size(25, 35);
            MaximazeBtn.TabIndex = 1;
            MaximazeBtn.TextAlign = ContentAlignment.MiddleCenter;
            MaximazeBtn.Click += MaximazeBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.ActiveBorderThickness = 2;
            CloseBtn.ActiveCornerRadius = 15;
            CloseBtn.ActiveFillColor = Color.SeaGreen;
            CloseBtn.ActiveForecolor = Color.White;
            CloseBtn.ActiveLineColor = Color.SeaGreen;
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.BackColor = Color.Gray;
            CloseBtn.BackgroundImage = (Image)resources.GetObject("CloseBtn.BackgroundImage");
            CloseBtn.ButtonText = "x";
            CloseBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloseBtn.ForeColor = Color.SeaGreen;
            CloseBtn.IdleBorderThickness = 2;
            CloseBtn.IdleCornerRadius = 15;
            CloseBtn.IdleFillColor = Color.White;
            CloseBtn.IdleForecolor = Color.SeaGreen;
            CloseBtn.IdleLineColor = Color.SeaGreen;
            CloseBtn.Location = new Point(1431, -2);
            CloseBtn.Margin = new Padding(5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Padding = new Padding(3, 0, 0, 2);
            CloseBtn.Size = new Size(25, 35);
            CloseBtn.TabIndex = 1;
            CloseBtn.TextAlign = ContentAlignment.MiddleCenter;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebarPanel.BackgroundColor = Color.FromArgb(30, 30, 30);
            sidebarPanel.BorderColor = Color.FromArgb(110, 110, 110);
            sidebarPanel.BorderThickness = 0;
            sidebarPanel.Controls.Add(instructionsBtn);
            sidebarPanel.Controls.Add(infoBtn);
            sidebarPanel.IsDerivedStyle = true;
            sidebarPanel.Location = new Point(0, 32);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(262, 502);
            sidebarPanel.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            sidebarPanel.StyleManager = null;
            sidebarPanel.TabIndex = 1;
            sidebarPanel.ThemeAuthor = "Taiizor";
            sidebarPanel.ThemeName = "MetroDark";
            // 
            // instructionsBtn
            // 
            instructionsBtn.Active = false;
            instructionsBtn.Activecolor = Color.FromArgb(64, 64, 64);
            instructionsBtn.BackColor = Color.FromArgb(64, 64, 64);
            instructionsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            instructionsBtn.BorderRadius = 0;
            instructionsBtn.ButtonText = "   Guide";
            instructionsBtn.DisabledColor = Color.Black;
            instructionsBtn.Iconcolor = Color.Transparent;
            instructionsBtn.Iconimage = (Image)resources.GetObject("instructionsBtn.Iconimage");
            instructionsBtn.Iconimage_right = null;
            instructionsBtn.Iconimage_right_Selected = null;
            instructionsBtn.Iconimage_Selected = null;
            instructionsBtn.IconMarginLeft = 0;
            instructionsBtn.IconMarginRight = 0;
            instructionsBtn.IconRightVisible = true;
            instructionsBtn.IconRightZoom = 0D;
            instructionsBtn.IconVisible = true;
            instructionsBtn.IconZoom = 65D;
            instructionsBtn.IsTab = false;
            instructionsBtn.Location = new Point(0, 170);
            instructionsBtn.Margin = new Padding(4, 5, 4, 5);
            instructionsBtn.Name = "instructionsBtn";
            instructionsBtn.Normalcolor = Color.FromArgb(64, 64, 64);
            instructionsBtn.OnHovercolor = Color.Black;
            instructionsBtn.OnHoverTextColor = Color.White;
            instructionsBtn.selected = false;
            instructionsBtn.Size = new Size(262, 68);
            instructionsBtn.TabIndex = 3;
            instructionsBtn.Text = "   Guide";
            instructionsBtn.TextAlign = ContentAlignment.MiddleLeft;
            instructionsBtn.Textcolor = Color.White;
            instructionsBtn.TextFont = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            instructionsBtn.Click += instructionsBtn_Click;
            // 
            // infoBtn
            // 
            infoBtn.Active = false;
            infoBtn.Activecolor = Color.FromArgb(64, 64, 64);
            infoBtn.BackColor = Color.FromArgb(64, 64, 64);
            infoBtn.BackgroundImageLayout = ImageLayout.Stretch;
            infoBtn.BorderRadius = 0;
            infoBtn.ButtonText = "  Information";
            infoBtn.DisabledColor = Color.Black;
            infoBtn.Iconcolor = Color.Transparent;
            infoBtn.Iconimage = (Image)resources.GetObject("infoBtn.Iconimage");
            infoBtn.Iconimage_right = null;
            infoBtn.Iconimage_right_Selected = null;
            infoBtn.Iconimage_Selected = null;
            infoBtn.IconMarginLeft = 0;
            infoBtn.IconMarginRight = 0;
            infoBtn.IconRightVisible = true;
            infoBtn.IconRightZoom = 0D;
            infoBtn.IconVisible = true;
            infoBtn.IconZoom = 80D;
            infoBtn.IsTab = false;
            infoBtn.Location = new Point(0, 92);
            infoBtn.Margin = new Padding(4, 5, 4, 5);
            infoBtn.Name = "infoBtn";
            infoBtn.Normalcolor = Color.FromArgb(64, 64, 64);
            infoBtn.OnHovercolor = Color.Black;
            infoBtn.OnHoverTextColor = Color.White;
            infoBtn.selected = false;
            infoBtn.Size = new Size(262, 68);
            infoBtn.TabIndex = 3;
            infoBtn.Text = "  Information";
            infoBtn.TextAlign = ContentAlignment.MiddleLeft;
            infoBtn.Textcolor = Color.White;
            infoBtn.TextFont = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // materialCheckBox1
            // 
            materialCheckBox1.AutoSize = true;
            materialCheckBox1.Depth = 0;
            materialCheckBox1.Location = new Point(0, 0);
            materialCheckBox1.Margin = new Padding(0);
            materialCheckBox1.MouseLocation = new Point(-1, -1);
            materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox1.Name = "materialCheckBox1";
            materialCheckBox1.ReadOnly = false;
            materialCheckBox1.Ripple = true;
            materialCheckBox1.Size = new Size(10, 10);
            materialCheckBox1.TabIndex = 0;
            materialCheckBox1.Text = "materialCheckBox1";
            materialCheckBox1.UseAccentColor = false;
            materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox2
            // 
            materialCheckBox2.AutoSize = true;
            materialCheckBox2.Depth = 0;
            materialCheckBox2.Location = new Point(0, 0);
            materialCheckBox2.Margin = new Padding(0);
            materialCheckBox2.MouseLocation = new Point(-1, -1);
            materialCheckBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox2.Name = "materialCheckBox2";
            materialCheckBox2.ReadOnly = false;
            materialCheckBox2.Ripple = true;
            materialCheckBox2.Size = new Size(10, 10);
            materialCheckBox2.TabIndex = 0;
            materialCheckBox2.Text = "materialCheckBox2";
            materialCheckBox2.UseAccentColor = false;
            materialCheckBox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox3
            // 
            materialCheckBox3.AutoSize = true;
            materialCheckBox3.Depth = 0;
            materialCheckBox3.Location = new Point(0, 0);
            materialCheckBox3.Margin = new Padding(0);
            materialCheckBox3.MouseLocation = new Point(-1, -1);
            materialCheckBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox3.Name = "materialCheckBox3";
            materialCheckBox3.ReadOnly = false;
            materialCheckBox3.Ripple = true;
            materialCheckBox3.Size = new Size(10, 10);
            materialCheckBox3.TabIndex = 0;
            materialCheckBox3.Text = "materialCheckBox3";
            materialCheckBox3.UseAccentColor = false;
            materialCheckBox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox4
            // 
            materialCheckBox4.AutoSize = true;
            materialCheckBox4.Depth = 0;
            materialCheckBox4.Location = new Point(0, 0);
            materialCheckBox4.Margin = new Padding(0);
            materialCheckBox4.MouseLocation = new Point(-1, -1);
            materialCheckBox4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox4.Name = "materialCheckBox4";
            materialCheckBox4.ReadOnly = false;
            materialCheckBox4.Ripple = true;
            materialCheckBox4.Size = new Size(10, 10);
            materialCheckBox4.TabIndex = 0;
            materialCheckBox4.Text = "materialCheckBox4";
            materialCheckBox4.UseAccentColor = false;
            materialCheckBox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox5
            // 
            materialCheckBox5.AutoSize = true;
            materialCheckBox5.Depth = 0;
            materialCheckBox5.Location = new Point(0, 0);
            materialCheckBox5.Margin = new Padding(0);
            materialCheckBox5.MouseLocation = new Point(-1, -1);
            materialCheckBox5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox5.Name = "materialCheckBox5";
            materialCheckBox5.ReadOnly = false;
            materialCheckBox5.Ripple = true;
            materialCheckBox5.Size = new Size(10, 10);
            materialCheckBox5.TabIndex = 0;
            materialCheckBox5.Text = "materialCheckBox5";
            materialCheckBox5.UseAccentColor = false;
            materialCheckBox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox6
            // 
            materialCheckBox6.AutoSize = true;
            materialCheckBox6.Depth = 0;
            materialCheckBox6.Location = new Point(0, 0);
            materialCheckBox6.Margin = new Padding(0);
            materialCheckBox6.MouseLocation = new Point(-1, -1);
            materialCheckBox6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox6.Name = "materialCheckBox6";
            materialCheckBox6.ReadOnly = false;
            materialCheckBox6.Ripple = true;
            materialCheckBox6.Size = new Size(10, 10);
            materialCheckBox6.TabIndex = 0;
            materialCheckBox6.Text = "materialCheckBox6";
            materialCheckBox6.UseAccentColor = false;
            materialCheckBox6.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            cb1.AutoSize = true;
            cb1.BackColor = Color.FromArgb(38, 38, 40);
            cb1.CheckedColor = Color.SeaGreen;
            cb1.DisabledColor = Color.FromArgb(196, 198, 202);
            cb1.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb1.Enable = true;
            cb1.EnabledCheckedColor = Color.SeaGreen;
            cb1.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb1.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb1.ForeColor = Color.Silver;
            cb1.Location = new Point(16, 46);
            cb1.Name = "cb1";
            cb1.Size = new Size(240, 20);
            cb1.TabIndex = 10;
            cb1.Text = "1). Есть доступ к почте";
            cb1.UseVisualStyleBackColor = false;
            cb1.CheckedChanged += cb1_CheckedChanged;
            // 
            // lostPanel1
            // 
            lostPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lostPanel1.BackColor = Color.FromArgb(38, 38, 40);
            lostPanel1.Controls.Add(resultBtn);
            lostPanel1.Controls.Add(cb6);
            lostPanel1.Controls.Add(cb5);
            lostPanel1.Controls.Add(cb4);
            lostPanel1.Controls.Add(cb3);
            lostPanel1.Controls.Add(cb23);
            lostPanel1.Controls.Add(cb22);
            lostPanel1.Controls.Add(cb21);
            lostPanel1.Controls.Add(cb1);
            lostPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostPanel1.ForeColor = Color.White;
            lostPanel1.Location = new Point(261, 33);
            lostPanel1.Name = "lostPanel1";
            lostPanel1.Padding = new Padding(5);
            lostPanel1.ShowText = true;
            lostPanel1.Size = new Size(1200, 302);
            lostPanel1.TabIndex = 11;
            // 
            // resultBtn
            // 
            resultBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resultBtn.BackColor = Color.Transparent;
            resultBtn.BaseColor = Color.FromArgb(35, 168, 109);
            resultBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultBtn.Location = new Point(494, 232);
            resultBtn.Name = "resultBtn";
            resultBtn.Rounded = false;
            resultBtn.Size = new Size(150, 50);
            resultBtn.TabIndex = 11;
            resultBtn.Text = "Copy Result";
            resultBtn.TextColor = Color.FromArgb(243, 243, 243);
            resultBtn.Click += resultBtn_Click;
            // 
            // cb6
            // 
            cb6.Anchor = AnchorStyles.Top;
            cb6.AutoSize = true;
            cb6.BackColor = Color.FromArgb(38, 38, 40);
            cb6.CheckedColor = Color.SeaGreen;
            cb6.DisabledColor = Color.FromArgb(196, 198, 202);
            cb6.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb6.Enable = true;
            cb6.EnabledCheckedColor = Color.SeaGreen;
            cb6.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb6.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb6.ForeColor = Color.Silver;
            cb6.Location = new Point(630, 156);
            cb6.Name = "cb6";
            cb6.Size = new Size(562, 20);
            cb6.TabIndex = 10;
            cb6.Text = "6). Есть привязанный первоначальный номер телефона  \r\n";
            cb6.UseVisualStyleBackColor = false;
            cb6.CheckedChanged += cb6_CheckedChanged;
            // 
            // cb5
            // 
            cb5.Anchor = AnchorStyles.Top;
            cb5.AutoSize = true;
            cb5.BackColor = Color.FromArgb(38, 38, 40);
            cb5.CheckedColor = Color.SeaGreen;
            cb5.DisabledColor = Color.FromArgb(196, 198, 202);
            cb5.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb5.Enable = true;
            cb5.EnabledCheckedColor = Color.SeaGreen;
            cb5.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb5.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb5.ForeColor = Color.Silver;
            cb5.Location = new Point(630, 120);
            cb5.Name = "cb5";
            cb5.Size = new Size(400, 20);
            cb5.TabIndex = 10;
            cb5.Text = "5). Был отправлен запрос в поддержку \r\n";
            cb5.UseVisualStyleBackColor = false;
            cb5.CheckedChanged += cb5_CheckedChanged;
            // 
            // cb4
            // 
            cb4.Anchor = AnchorStyles.Top;
            cb4.AutoSize = true;
            cb4.BackColor = Color.FromArgb(38, 38, 40);
            cb4.CheckedColor = Color.SeaGreen;
            cb4.DisabledColor = Color.FromArgb(196, 198, 202);
            cb4.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb4.Enable = true;
            cb4.EnabledCheckedColor = Color.SeaGreen;
            cb4.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb4.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb4.ForeColor = Color.Silver;
            cb4.Location = new Point(630, 83);
            cb4.Name = "cb4";
            cb4.Size = new Size(269, 20);
            cb4.TabIndex = 10;
            cb4.Text = "4). Получал ключи от игр";
            cb4.UseVisualStyleBackColor = false;
            cb4.CheckedChanged += cb4_CheckedChanged;
            // 
            // cb3
            // 
            cb3.Anchor = AnchorStyles.Top;
            cb3.AutoSize = true;
            cb3.BackColor = Color.FromArgb(38, 38, 40);
            cb3.CheckedColor = Color.SeaGreen;
            cb3.DisabledColor = Color.FromArgb(196, 198, 202);
            cb3.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb3.Enable = true;
            cb3.EnabledCheckedColor = Color.SeaGreen;
            cb3.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb3.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb3.ForeColor = Color.Silver;
            cb3.Location = new Point(630, 46);
            cb3.Name = "cb3";
            cb3.Size = new Size(450, 20);
            cb3.TabIndex = 10;
            cb3.Text = "3). Были совершены подарочные операции  \r\n";
            cb3.UseVisualStyleBackColor = false;
            cb3.CheckedChanged += cb3_CheckedChanged;
            // 
            // cb23
            // 
            cb23.AutoSize = true;
            cb23.BackColor = Color.FromArgb(38, 38, 40);
            cb23.CheckedColor = Color.SeaGreen;
            cb23.DisabledColor = Color.FromArgb(196, 198, 202);
            cb23.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb23.Enable = true;
            cb23.EnabledCheckedColor = Color.SeaGreen;
            cb23.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb23.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb23.ForeColor = Color.Silver;
            cb23.Location = new Point(16, 159);
            cb23.Name = "cb23";
            cb23.Size = new Size(526, 20);
            cb23.TabIndex = 10;
            cb23.Text = "2.3). Совершал пополнения на аккаунте через САЙТ  \r\n";
            cb23.UseVisualStyleBackColor = false;
            cb23.CheckedChanged += cb23_CheckedChanged;
            // 
            // cb22
            // 
            cb22.AutoSize = true;
            cb22.BackColor = Color.FromArgb(38, 38, 40);
            cb22.CheckedColor = Color.SeaGreen;
            cb22.DisabledColor = Color.FromArgb(196, 198, 202);
            cb22.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb22.Enable = true;
            cb22.EnabledCheckedColor = Color.SeaGreen;
            cb22.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb22.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb22.ForeColor = Color.Silver;
            cb22.Location = new Point(16, 119);
            cb22.Name = "cb22";
            cb22.Size = new Size(585, 20);
            cb22.TabIndex = 10;
            cb22.Text = "2.2). Совершал пополнения на аккаунте через ТЕРМИНАЛ   \r\n ";
            cb22.UseVisualStyleBackColor = false;
            cb22.CheckedChanged += cb22_CheckedChanged;
            // 
            // cb21
            // 
            cb21.AutoSize = true;
            cb21.BackColor = Color.FromArgb(38, 38, 40);
            cb21.CheckedColor = Color.SeaGreen;
            cb21.DisabledColor = Color.FromArgb(196, 198, 202);
            cb21.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb21.Enable = true;
            cb21.EnabledCheckedColor = Color.SeaGreen;
            cb21.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb21.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb21.ForeColor = Color.Silver;
            cb21.Location = new Point(16, 83);
            cb21.Name = "cb21";
            cb21.Size = new Size(490, 20);
            cb21.TabIndex = 10;
            cb21.Text = "2.1). Совершал пополнения на аккаунте КАРТОЙ \r\n\r\n";
            cb21.UseVisualStyleBackColor = false;
            cb21.CheckedChanged += cb21_CheckedChanged;
            // 
            // mainText
            // 
            mainText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainText.BackColor = Color.FromArgb(30, 30, 30);
            mainText.BorderStyle = BorderStyle.None;
            mainText.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            mainText.ForeColor = Color.Silver;
            mainText.Location = new Point(268, 341);
            mainText.Name = "mainText";
            mainText.Size = new Size(1181, 180);
            mainText.TabIndex = 12;
            mainText.Text = "";
            mainText.TextChanged += mainText_TextChanged;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1461, 533);
            Controls.Add(mainText);
            Controls.Add(lostPanel1);
            Controls.Add(sidebarPanel);
            Controls.Add(appPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainForm";
            Text = "Form1";
            TransparencyKey = Color.Fuchsia;
            appPanel.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            lostPanel1.ResumeLayout(false);
            lostPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel appPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 MinimazeBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 MaximazeBtn;
        private ReaLTaiizor.Controls.MetroPanel sidebarPanel;
        private Bunifu.Framework.UI.BunifuFlatButton infoBtn;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox2;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox3;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox4;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox5;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox6;
        private ReaLTaiizor.Controls.HopeCheckBox cb1;
        private ReaLTaiizor.Controls.LostPanel lostPanel1;
        private ReaLTaiizor.Controls.HopeCheckBox cb6;
        private ReaLTaiizor.Controls.HopeCheckBox cb5;
        private ReaLTaiizor.Controls.HopeCheckBox cb4;
        private ReaLTaiizor.Controls.HopeCheckBox cb21;
        private ReaLTaiizor.Controls.HopeCheckBox cb3;
        private RichTextBox mainText;
        private ReaLTaiizor.Controls.ForeverButton resultBtn;
        private ReaLTaiizor.Controls.HopeCheckBox cb23;
        private ReaLTaiizor.Controls.HopeCheckBox cb22;
        private Bunifu.Framework.UI.BunifuFlatButton instructionsBtn;
    }
}