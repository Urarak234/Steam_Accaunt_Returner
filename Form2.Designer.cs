namespace Steam_Accunt_Restorrer_Note
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            appPanel = new Panel();
            MinimizeBtn2 = new Bunifu.Framework.UI.BunifuThinButton2();
            MaximizeBtn2 = new Bunifu.Framework.UI.BunifuThinButton2();
            CloseBtn2 = new Bunifu.Framework.UI.BunifuThinButton2();
            instructionsBtn2 = new Bunifu.Framework.UI.BunifuFlatButton();
            infoBtn2 = new Bunifu.Framework.UI.BunifuFlatButton();
            sidebarPanel = new ReaLTaiizor.Controls.MetroPanel();
            lostPanel1 = new ReaLTaiizor.Controls.LostPanel();
            additionMatBtn = new ReaLTaiizor.Controls.ForeverButton();
            resultBtn2 = new ReaLTaiizor.Controls.ForeverButton();
            cb2_2 = new ReaLTaiizor.Controls.HopeCheckBox();
            cb3_2 = new ReaLTaiizor.Controls.HopeCheckBox();
            cb1_2 = new ReaLTaiizor.Controls.HopeCheckBox();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            mainText2 = new RichTextBox();
            appPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            lostPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // appPanel
            // 
            appPanel.BackColor = Color.Gray;
            appPanel.Controls.Add(MinimizeBtn2);
            appPanel.Controls.Add(MaximizeBtn2);
            appPanel.Controls.Add(CloseBtn2);
            appPanel.Dock = DockStyle.Top;
            appPanel.Location = new Point(0, 0);
            appPanel.Margin = new Padding(3, 4, 3, 4);
            appPanel.Name = "appPanel";
            appPanel.Size = new Size(1443, 33);
            appPanel.TabIndex = 10;
            appPanel.MouseDown += appPanel_MouseDown;
            // 
            // MinimizeBtn2
            // 
            MinimizeBtn2.ActiveBorderThickness = 2;
            MinimizeBtn2.ActiveCornerRadius = 15;
            MinimizeBtn2.ActiveFillColor = Color.SeaGreen;
            MinimizeBtn2.ActiveForecolor = Color.White;
            MinimizeBtn2.ActiveLineColor = Color.SeaGreen;
            MinimizeBtn2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeBtn2.BackColor = Color.Gray;
            MinimizeBtn2.BackgroundImage = (Image)resources.GetObject("MinimizeBtn2.BackgroundImage");
            MinimizeBtn2.ButtonText = "-";
            MinimizeBtn2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MinimizeBtn2.ForeColor = Color.SeaGreen;
            MinimizeBtn2.IdleBorderThickness = 2;
            MinimizeBtn2.IdleCornerRadius = 15;
            MinimizeBtn2.IdleFillColor = Color.White;
            MinimizeBtn2.IdleForecolor = Color.SeaGreen;
            MinimizeBtn2.IdleLineColor = Color.SeaGreen;
            MinimizeBtn2.Location = new Point(1361, -2);
            MinimizeBtn2.Margin = new Padding(5);
            MinimizeBtn2.Name = "MinimizeBtn2";
            MinimizeBtn2.Padding = new Padding(3, 0, 0, 2);
            MinimizeBtn2.Size = new Size(25, 35);
            MinimizeBtn2.TabIndex = 2;
            MinimizeBtn2.TextAlign = ContentAlignment.MiddleCenter;
            MinimizeBtn2.Click += MinimizeBtn2_Click;
            // 
            // MaximizeBtn2
            // 
            MaximizeBtn2.ActiveBorderThickness = 2;
            MaximizeBtn2.ActiveCornerRadius = 15;
            MaximizeBtn2.ActiveFillColor = Color.SeaGreen;
            MaximizeBtn2.ActiveForecolor = Color.White;
            MaximizeBtn2.ActiveLineColor = Color.SeaGreen;
            MaximizeBtn2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximizeBtn2.BackColor = Color.Gray;
            MaximizeBtn2.BackgroundImage = (Image)resources.GetObject("MaximizeBtn2.BackgroundImage");
            MaximizeBtn2.ButtonText = "o";
            MaximizeBtn2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBtn2.ForeColor = Color.SeaGreen;
            MaximizeBtn2.IdleBorderThickness = 2;
            MaximizeBtn2.IdleCornerRadius = 15;
            MaximizeBtn2.IdleFillColor = Color.White;
            MaximizeBtn2.IdleForecolor = Color.SeaGreen;
            MaximizeBtn2.IdleLineColor = Color.SeaGreen;
            MaximizeBtn2.Location = new Point(1387, -2);
            MaximizeBtn2.Margin = new Padding(5);
            MaximizeBtn2.Name = "MaximizeBtn2";
            MaximizeBtn2.Padding = new Padding(3, 0, 0, 2);
            MaximizeBtn2.Size = new Size(25, 35);
            MaximizeBtn2.TabIndex = 3;
            MaximizeBtn2.TextAlign = ContentAlignment.MiddleCenter;
            MaximizeBtn2.Click += MaximizeBtn2_Click;
            // 
            // CloseBtn2
            // 
            CloseBtn2.ActiveBorderThickness = 2;
            CloseBtn2.ActiveCornerRadius = 15;
            CloseBtn2.ActiveFillColor = Color.SeaGreen;
            CloseBtn2.ActiveForecolor = Color.White;
            CloseBtn2.ActiveLineColor = Color.SeaGreen;
            CloseBtn2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn2.BackColor = Color.Gray;
            CloseBtn2.BackgroundImage = (Image)resources.GetObject("CloseBtn2.BackgroundImage");
            CloseBtn2.ButtonText = "x";
            CloseBtn2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloseBtn2.ForeColor = Color.SeaGreen;
            CloseBtn2.IdleBorderThickness = 2;
            CloseBtn2.IdleCornerRadius = 15;
            CloseBtn2.IdleFillColor = Color.White;
            CloseBtn2.IdleForecolor = Color.SeaGreen;
            CloseBtn2.IdleLineColor = Color.SeaGreen;
            CloseBtn2.Location = new Point(1413, -2);
            CloseBtn2.Margin = new Padding(5);
            CloseBtn2.Name = "CloseBtn2";
            CloseBtn2.Padding = new Padding(3, 0, 0, 2);
            CloseBtn2.Size = new Size(25, 35);
            CloseBtn2.TabIndex = 4;
            CloseBtn2.TextAlign = ContentAlignment.MiddleCenter;
            CloseBtn2.Click += CloseBtn2_Click_1;
            // 
            // instructionsBtn2
            // 
            instructionsBtn2.Active = false;
            instructionsBtn2.Activecolor = Color.FromArgb(64, 64, 64);
            instructionsBtn2.BackColor = Color.FromArgb(64, 64, 64);
            instructionsBtn2.BackgroundImageLayout = ImageLayout.Stretch;
            instructionsBtn2.BorderRadius = 0;
            instructionsBtn2.ButtonText = "   Guide";
            instructionsBtn2.DisabledColor = Color.Black;
            instructionsBtn2.Iconcolor = Color.Transparent;
            instructionsBtn2.Iconimage = (Image)resources.GetObject("instructionsBtn2.Iconimage");
            instructionsBtn2.Iconimage_right = null;
            instructionsBtn2.Iconimage_right_Selected = null;
            instructionsBtn2.Iconimage_Selected = null;
            instructionsBtn2.IconMarginLeft = 0;
            instructionsBtn2.IconMarginRight = 0;
            instructionsBtn2.IconRightVisible = true;
            instructionsBtn2.IconRightZoom = 0D;
            instructionsBtn2.IconVisible = true;
            instructionsBtn2.IconZoom = 65D;
            instructionsBtn2.IsTab = false;
            instructionsBtn2.Location = new Point(0, 170);
            instructionsBtn2.Margin = new Padding(4, 5, 4, 5);
            instructionsBtn2.Name = "instructionsBtn2";
            instructionsBtn2.Normalcolor = Color.FromArgb(64, 64, 64);
            instructionsBtn2.OnHovercolor = Color.Black;
            instructionsBtn2.OnHoverTextColor = Color.White;
            instructionsBtn2.selected = false;
            instructionsBtn2.Size = new Size(262, 68);
            instructionsBtn2.TabIndex = 3;
            instructionsBtn2.Text = "   Guide";
            instructionsBtn2.TextAlign = ContentAlignment.MiddleLeft;
            instructionsBtn2.Textcolor = Color.White;
            instructionsBtn2.TextFont = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // infoBtn2
            // 
            infoBtn2.Active = false;
            infoBtn2.Activecolor = Color.FromArgb(64, 64, 64);
            infoBtn2.BackColor = Color.FromArgb(64, 64, 64);
            infoBtn2.BackgroundImageLayout = ImageLayout.Stretch;
            infoBtn2.BorderRadius = 0;
            infoBtn2.ButtonText = "  Information";
            infoBtn2.DisabledColor = Color.Black;
            infoBtn2.Iconcolor = Color.Transparent;
            infoBtn2.Iconimage = (Image)resources.GetObject("infoBtn2.Iconimage");
            infoBtn2.Iconimage_right = null;
            infoBtn2.Iconimage_right_Selected = null;
            infoBtn2.Iconimage_Selected = null;
            infoBtn2.IconMarginLeft = 0;
            infoBtn2.IconMarginRight = 0;
            infoBtn2.IconRightVisible = true;
            infoBtn2.IconRightZoom = 0D;
            infoBtn2.IconVisible = true;
            infoBtn2.IconZoom = 80D;
            infoBtn2.IsTab = false;
            infoBtn2.Location = new Point(0, 92);
            infoBtn2.Margin = new Padding(4, 5, 4, 5);
            infoBtn2.Name = "infoBtn2";
            infoBtn2.Normalcolor = Color.FromArgb(64, 64, 64);
            infoBtn2.OnHovercolor = Color.Black;
            infoBtn2.OnHoverTextColor = Color.White;
            infoBtn2.selected = false;
            infoBtn2.Size = new Size(262, 68);
            infoBtn2.TabIndex = 3;
            infoBtn2.Text = "  Information";
            infoBtn2.TextAlign = ContentAlignment.MiddleLeft;
            infoBtn2.Textcolor = Color.White;
            infoBtn2.TextFont = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            infoBtn2.Click += infoBtn2_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackgroundColor = Color.FromArgb(30, 30, 30);
            sidebarPanel.BorderColor = Color.FromArgb(110, 110, 110);
            sidebarPanel.BorderThickness = 0;
            sidebarPanel.Controls.Add(instructionsBtn2);
            sidebarPanel.Controls.Add(infoBtn2);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.IsDerivedStyle = true;
            sidebarPanel.Location = new Point(0, 33);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(262, 540);
            sidebarPanel.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            sidebarPanel.StyleManager = null;
            sidebarPanel.TabIndex = 2;
            sidebarPanel.ThemeAuthor = "Taiizor";
            sidebarPanel.ThemeName = "MetroDark";
            // 
            // lostPanel1
            // 
            lostPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lostPanel1.BackColor = Color.FromArgb(38, 38, 40);
            lostPanel1.Controls.Add(additionMatBtn);
            lostPanel1.Controls.Add(resultBtn2);
            lostPanel1.Controls.Add(cb2_2);
            lostPanel1.Controls.Add(cb3_2);
            lostPanel1.Controls.Add(cb1_2);
            lostPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lostPanel1.ForeColor = Color.White;
            lostPanel1.Location = new Point(261, 33);
            lostPanel1.Name = "lostPanel1";
            lostPanel1.Padding = new Padding(5);
            lostPanel1.ShowText = true;
            lostPanel1.Size = new Size(1182, 302);
            lostPanel1.TabIndex = 12;
            // 
            // additionMatBtn
            // 
            additionMatBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            additionMatBtn.BackColor = Color.Transparent;
            additionMatBtn.BaseColor = Color.FromArgb(35, 168, 109);
            additionMatBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            additionMatBtn.Location = new Point(647, 232);
            additionMatBtn.Name = "additionMatBtn";
            additionMatBtn.Rounded = false;
            additionMatBtn.Size = new Size(310, 50);
            additionMatBtn.TabIndex = 11;
            additionMatBtn.Text = "Copy Img Guide";
            additionMatBtn.TextColor = Color.FromArgb(243, 243, 243);
            additionMatBtn.Click += additionMatBtn_Click;
            // 
            // resultBtn2
            // 
            resultBtn2.BackColor = Color.Transparent;
            resultBtn2.BaseColor = Color.FromArgb(35, 168, 109);
            resultBtn2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultBtn2.Location = new Point(267, 232);
            resultBtn2.Name = "resultBtn2";
            resultBtn2.Rounded = false;
            resultBtn2.Size = new Size(311, 50);
            resultBtn2.TabIndex = 11;
            resultBtn2.Text = "Copy Result";
            resultBtn2.TextColor = Color.FromArgb(243, 243, 243);
            resultBtn2.Click += resultBtn2_Click;
            // 
            // cb2_2
            // 
            cb2_2.AutoSize = true;
            cb2_2.BackColor = Color.FromArgb(38, 38, 40);
            cb2_2.CheckedColor = Color.SeaGreen;
            cb2_2.DisabledColor = Color.FromArgb(196, 198, 202);
            cb2_2.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb2_2.Enable = true;
            cb2_2.EnabledCheckedColor = Color.SeaGreen;
            cb2_2.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb2_2.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb2_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb2_2.ForeColor = Color.Silver;
            cb2_2.Location = new Point(16, 92);
            cb2_2.Name = "cb2_2";
            cb2_2.Size = new Size(562, 20);
            cb2_2.TabIndex = 10;
            cb2_2.Text = "2). Есть привязанный первоначальный номер телефона  \r\n";
            cb2_2.UseVisualStyleBackColor = false;
            cb2_2.CheckedChanged += cb2_2_CheckedChanged;
            // 
            // cb3_2
            // 
            cb3_2.AutoSize = true;
            cb3_2.BackColor = Color.FromArgb(38, 38, 40);
            cb3_2.CheckedColor = Color.SeaGreen;
            cb3_2.DisabledColor = Color.FromArgb(196, 198, 202);
            cb3_2.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb3_2.Enable = true;
            cb3_2.EnabledCheckedColor = Color.SeaGreen;
            cb3_2.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb3_2.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb3_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb3_2.ForeColor = Color.Silver;
            cb3_2.Location = new Point(16, 140);
            cb3_2.Name = "cb3_2";
            cb3_2.Size = new Size(234, 20);
            cb3_2.TabIndex = 10;
            cb3_2.Text = "3). Есть ключ от игры ";
            cb3_2.UseVisualStyleBackColor = false;
            cb3_2.CheckedChanged += cb3_2_CheckedChanged;
            // 
            // cb1_2
            // 
            cb1_2.AutoSize = true;
            cb1_2.BackColor = Color.FromArgb(38, 38, 40);
            cb1_2.CheckedColor = Color.SeaGreen;
            cb1_2.DisabledColor = Color.FromArgb(196, 198, 202);
            cb1_2.DisabledStringColor = Color.FromArgb(186, 187, 189);
            cb1_2.Enable = true;
            cb1_2.EnabledCheckedColor = Color.SeaGreen;
            cb1_2.EnabledStringColor = Color.FromArgb(153, 153, 153);
            cb1_2.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            cb1_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb1_2.ForeColor = Color.Silver;
            cb1_2.Location = new Point(16, 46);
            cb1_2.Name = "cb1_2";
            cb1_2.Size = new Size(240, 20);
            cb1_2.TabIndex = 10;
            cb1_2.Text = "1). Есть доступ к почте";
            cb1_2.UseVisualStyleBackColor = false;
            cb1_2.CheckedChanged += cb1_2_CheckedChanged;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView1.BackColor = Color.FromArgb(38, 38, 40);
            listView1.BorderStyle = BorderStyle.None;
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(1148, 339);
            listView1.Name = "listView1";
            listView1.Size = new Size(295, 234);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "img1.png");
            imageList1.Images.SetKeyName(1, "img2.png");
            imageList1.Images.SetKeyName(2, "img3.png");
            // 
            // mainText2
            // 
            mainText2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainText2.BackColor = Color.FromArgb(30, 30, 30);
            mainText2.BorderStyle = BorderStyle.None;
            mainText2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            mainText2.ForeColor = Color.Silver;
            mainText2.Location = new Point(268, 341);
            mainText2.Name = "mainText2";
            mainText2.Size = new Size(874, 220);
            mainText2.TabIndex = 13;
            mainText2.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1443, 573);
            Controls.Add(listView1);
            Controls.Add(mainText2);
            Controls.Add(lostPanel1);
            Controls.Add(sidebarPanel);
            Controls.Add(appPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            appPanel.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            lostPanel1.ResumeLayout(false);
            lostPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel appPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 MinimizeBtn2;
        private Bunifu.Framework.UI.BunifuThinButton2 MaximizeBtn2;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseBtn2;
        private Bunifu.Framework.UI.BunifuFlatButton instructionsBtn2;
        private Bunifu.Framework.UI.BunifuFlatButton infoBtn2;
        private ReaLTaiizor.Controls.MetroPanel sidebarPanel;
        private ReaLTaiizor.Controls.LostPanel lostPanel1;
        private ReaLTaiizor.Controls.ForeverButton resultBtn2;
        private ReaLTaiizor.Controls.HopeCheckBox cb2_2;
        private ReaLTaiizor.Controls.HopeCheckBox cb5;
        private ReaLTaiizor.Controls.HopeCheckBox cb3;
        private ReaLTaiizor.Controls.HopeCheckBox cb23;
        private ReaLTaiizor.Controls.HopeCheckBox cb22;
        private ReaLTaiizor.Controls.HopeCheckBox cb21;
        private ReaLTaiizor.Controls.HopeCheckBox cb1_2;
        private ReaLTaiizor.Controls.ForeverButton additionMatBtn;
        private ReaLTaiizor.Controls.HopeCheckBox cb3_2;
        private RichTextBox mainText2;
        private ImageList imageList1;
        private ListView listView1;
    }
}