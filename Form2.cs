using Steam_Accunt_Restorrer_Note.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Accunt_Restorrer_Note
{
    public partial class Form2 : Form
    {
        //private bool[] checkboxStates;

        public Form2()
        {
            InitializeComponent();
            mainText2.Text = "Укажите, какие материалы предоставил клиент, выбрав соответствующие галочки!\n" +
                "\nПРИМЕЧАНИЕ: В начале нажимаете на кнопку [ COPY RESULT ], затем кнопку [ COPY IMG GUIDE ] для полного представления инструкции действий." +
                "\n[ COPY RESULT ] --> Копируете для предоставления текстовую инструкцию." +
                "\n[ COPY IMG GUIDE ] --> Копируете для предоставления визуальную инструкцию.";
            cb1_2.Checked = DataStorage.Cb_email;
            cb2_2.Checked = DataStorage.Cb_phone;
            cb3_2.Checked = DataStorage.Cb_gameKey;
        }

        private void checkedInstructionsGuide()
        {
            if (cb1_2.Checked && !cb2_2.Checked && !cb3_2.Checked)
            {
                //if (cb2_2.Checked)
                //{
                //    if (cb3_2.Checked)
                //    {
                //        mainText2.Text = "Отлично! Благодарим за полученную информацию и оплату.\r" +
                //            "\n‼ ВАЖНО: Обязательно завершите все предыдущие обращения.‼\r" +
                //            "\nДалее перейдите по ссылке: https://help.steampowered.com/ru/wizard/HelpWithLoginInfo?accountsearch=1&issueid=408&reset=1\r" +
                //            "\nВы должны выполнить следующие шаги:\r\n\r" +
                //            "\n1). Вводите имя аккаунта/адрес почты/номер телефона (1 из перечисленного)\r" +
                //            "\n2). Выбираете пункт: \"У меня больше нет доступа к этому адресу эл. почты\"\r" +
                //            "\n3) Вам открывается форма для заполнения. Внесите в соответствующие поля необходимую информацию:\r" +
                //            "\n• Ваш текущий адрес эл. почты (наш ответ придет на него) - вводите почту, к которой имеете доступ.\r\n\r" +
                //            "\n----===== Расскажите нам о своем аккаунте Steam... =====--—\r" +
                //            "\n• Какой адрес эл. почты использовался на этом аккаунте первым? - оставьте поле пустым.\r" +
                //            "\n• Укажите номер телефона, привязанный к аккаунту - оставьте поле пустым.\r\n\r" +
                //            "\n----===== Регистрировали ли вы на аккаунте ключи активации? =====--—\r" +
                //            "\n• Если у вас есть какой-либо ключ - введите его сюда.\r\n\r\n\r" +
                //            "\nСейчас я создам макет для последней формы обращения. Пожалуйста, подождите ещё немного";
                //    }

                //    mainText2.Text = "Отлично! Благодарим за полученную информацию и оплату.\r" +
                //            "\n‼ ВАЖНО: Обязательно завершите все предыдущие обращения.‼\r" +
                //            "\nДалее перейдите по ссылке: https://help.steampowered.com/ru/wizard/HelpWithLoginInfo?accountsearch=1&issueid=408&reset=1\r" +
                //            "\nВы должны выполнить следующие шаги:\r\n\r" +
                //            "\n1). Вводите имя аккаунта/адрес почты/номер телефона (1 из перечисленного)\r" +
                //            "\n2). Выбираете пункт: \"У меня больше нет доступа к этому адресу эл. почты\"\r" +
                //            "\n3) Вам открывается форма для заполнения. Внесите в соответствующие поля необходимую информацию:\r" +
                //            "\n• Ваш текущий адрес эл. почты (наш ответ придет на него) - вводите почту, к которой имеете доступ.\r\n\r" +
                //            "\n----===== Расскажите нам о своем аккаунте Steam... =====--—\r" +
                //            "\n• Какой адрес эл. почты использовался на этом аккаунте первым? - оставьте поле пустым.\r" +
                //            "\n• Укажите номер телефона, привязанный к аккаунту - указываете номер телефона, который был привязан к аккаунту (обязательно с кодом страны).\r\n\r" +
                //            "\n----===== Регистрировали ли вы на аккаунте ключи активации? =====--—\r" +
                //            "\n• Оставьте поле пустым.\r\n\r\n\r" +
                //            "\nСейчас я создам макет для последней формы обращения. Пожалуйста, подождите ещё немного";
                //}

                mainText2.Text = "Отлично! Благодарим за полученную информацию и оплату.\r" +
                            "\n‼ ВАЖНО: Обязательно завершите все предыдущие обращения.‼\r" +
                            "\nДалее перейдите по ссылке: https://help.steampowered.com/ru/wizard/HelpWithLoginInfo?accountsearch=1&issueid=408&reset=1\r" +
                            "\nВы должны выполнить следующие шаги:\r\n\r" +
                            "\n1). Вводите имя аккаунта/адрес почты/номер телефона (1 из перечисленного)\r" +
                            "\n2). Выбираете пункт: \"У меня больше нет доступа к этому адресу эл. почты\"\r" +
                            "\n3) Вам открывается форма для заполнения. Внесите в соответствующие поля необходимую информацию:\r" +
                            "\n• Ваш текущий адрес эл. почты (наш ответ придет на него) - вводите почту, к которой имеете доступ. Желательно первоначальную почту аккаунта.\r\n\r" +
                            "\n----===== Расскажите нам о своем аккаунте Steam... =====--—\r" +
                            "\n• Какой адрес эл. почты использовался на этом аккаунте первым? - вводите почту, на которую был зарегистрирован аккаунт.\r" +
                            "\n• Укажите номер телефона, привязанный к аккаунту - оставьте поле пустым.\r\n\r" +
                            "\n----===== Регистрировали ли вы на аккаунте ключи активации? =====--—\r" +
                            "\n• Оставьте поле пустым.\r\n\r\n\r" +
                            "\nСейчас я создам макет для последней формы обращения. Пожалуйста, подождите ещё немного";
            }
            else if (cb2_2.Checked && !cb1_2.Checked && !cb3_2.Checked)
            {
                mainText2.Text = "Отлично! Благодарим за полученную информацию и оплату.\r" +
                            "\n‼ ВАЖНО: Обязательно завершите все предыдущие обращения.‼\r" +
                            "\nДалее перейдите по ссылке: https://help.steampowered.com/ru/wizard/HelpWithLoginInfo?accountsearch=1&issueid=408&reset=1\r" +
                            "\nВы должны выполнить следующие шаги:\r\n\r" +
                            "\n1). Вводите имя аккаунта/адрес почты/номер телефона (1 из перечисленного)\r" +
                            "\n2). Выбираете пункт: \"У меня больше нет доступа к этому адресу эл. почты\"\r" +
                            "\n3) Вам открывается форма для заполнения. Внесите в соответствующие поля необходимую информацию:\r" +
                            "\n• Ваш текущий адрес эл. почты (наш ответ придет на него) - вводите почту, к которой имеете доступ.\r\n\r" +
                            "\n----===== Расскажите нам о своем аккаунте Steam... =====--—\r" +
                            "\n• Какой адрес эл. почты использовался на этом аккаунте первым? - оставьте поле пустым.\r" +
                            "\n• Укажите номер телефона, привязанный к аккаунту - указываете номер телефона, который был привязан к аккаунту (обязательно с кодом страны).\r\n\r" +
                            "\n----===== Регистрировали ли вы на аккаунте ключи активации? =====--—\r" +
                            "\n• Оставьте поле пустым.\r\n\r\n\r" +
                            "\nСейчас я создам макет для последней формы обращения. Пожалуйста, подождите ещё немного";
            }
            else if (cb3_2.Checked && !cb2_2.Checked && !cb1_2.Checked)
            {
                mainText2.Text = "Отлично! Благодарим за полученную информацию и оплату.\r" +
                            "\n‼ ВАЖНО: Обязательно завершите все предыдущие обращения.‼\r" +
                            "\nДалее перейдите по ссылке: https://help.steampowered.com/ru/wizard/HelpWithLoginInfo?accountsearch=1&issueid=408&reset=1\r" +
                            "\nВы должны выполнить следующие шаги:\r\n\r" +
                            "\n1). Вводите имя аккаунта/адрес почты/номер телефона (1 из перечисленного)\r" +
                            "\n2). Выбираете пункт: \"У меня больше нет доступа к этому адресу эл. почты\"\r" +
                            "\n3) Вам открывается форма для заполнения. Внесите в соответствующие поля необходимую информацию:\r" +
                            "\n• Ваш текущий адрес эл. почты (наш ответ придет на него) - вводите почту, к которой имеете доступ.\r\n\r" +
                            "\n----===== Расскажите нам о своем аккаунте Steam... =====--—\r" +
                            "\n• Какой адрес эл. почты использовался на этом аккаунте первым? - оставьте поле пустым.\r" +
                            "\n• Укажите номер телефона, привязанный к аккаунту - оставьте поле пустым.\r\n\r" +
                            "\n----===== Регистрировали ли вы на аккаунте ключи активации? =====--—\r" +
                            "\n• Если у вас есть какой-либо ключ - введите его сюда.\r\n\r\n\r" +
                            "\nСейчас я создам макет для последней формы обращения. Пожалуйста, подождите ещё немного";
            }
            else if (cb1_2.Checked && cb2_2.Checked && !cb3_2.Checked)
            {
                mainText2.Text = "Отлично! Благодарим за полученную информацию и оплату.\r" +
                            "\n‼ ВАЖНО: Обязательно завершите все предыдущие обращения.‼\r" +
                            "\nДалее перейдите по ссылке: https://help.steampowered.com/ru/wizard/HelpWithLoginInfo?accountsearch=1&issueid=408&reset=1\r" +
                            "\nВы должны выполнить следующие шаги:\r\n\r" +
                            "\n1). Вводите имя аккаунта/адрес почты/номер телефона (1 из перечисленного)\r" +
                            "\n2). Выбираете пункт: \"У меня больше нет доступа к этому адресу эл. почты\"\r" +
                            "\n3) Вам открывается форма для заполнения. Внесите в соответствующие поля необходимую информацию:\r" +
                            "\n• Ваш текущий адрес эл. почты (наш ответ придет на него) - вводите почту, к которой имеете доступ. Желательно первоначальную почту аккаунта.\r\n\r" +
                            "\n----===== Расскажите нам о своем аккаунте Steam... =====--—\r" +
                            "\n• Какой адрес эл. почты использовался на этом аккаунте первым? - вводите почту, на которую был зарегистрирован аккаунт.\r" +
                            "\n• Укажите номер телефона, привязанный к аккаунту - указываете номер телефона, который был привязан к аккаунту (обязательно с кодом страны).\r\n\r" +
                            "\n----===== Регистрировали ли вы на аккаунте ключи активации? =====--—\r" +
                            "\n• Оставьте поле пустым.\r\n\r\n\r" +
                            "\nСейчас я создам макет для последней формы обращения. Пожалуйста, подождите ещё немного";
            }
            else if (cb1_2.Checked && cb3_2.Checked && !cb2_2.Checked)
            {
                mainText2.Text = "Отлично! Благодарим за полученную информацию и оплату.\r" +
                            "\n‼ ВАЖНО: Обязательно завершите все предыдущие обращения.‼\r" +
                            "\nДалее перейдите по ссылке: https://help.steampowered.com/ru/wizard/HelpWithLoginInfo?accountsearch=1&issueid=408&reset=1\r" +
                            "\nВы должны выполнить следующие шаги:\r\n\r" +
                            "\n1). Вводите имя аккаунта/адрес почты/номер телефона (1 из перечисленного)\r" +
                            "\n2). Выбираете пункт: \"У меня больше нет доступа к этому адресу эл. почты\"\r" +
                            "\n3) Вам открывается форма для заполнения. Внесите в соответствующие поля необходимую информацию:\r" +
                            "\n• Ваш текущий адрес эл. почты (наш ответ придет на него) - вводите почту, к которой имеете доступ. Желательно первоначальную почту аккаунта.\r\n\r" +
                            "\n----===== Расскажите нам о своем аккаунте Steam... =====--—\r" +
                            "\n• Какой адрес эл. почты использовался на этом аккаунте первым? - вводите почту, на которую был зарегистрирован аккаунт.\r" +
                            "\n• Укажите номер телефона, привязанный к аккаунту - оставьте поле пустым.\r\n\r" +
                            "\n----===== Регистрировали ли вы на аккаунте ключи активации? =====--—\r" +
                            "\n• Если у вас есть какой-либо ключ - введите его сюда.\r\n\r\n\r" +
                            "\nСейчас я создам макет для последней формы обращения. Пожалуйста, подождите ещё немного";
            }
            else if (cb2_2.Checked && cb3_2.Checked && !cb1_2.Checked)
            {
                mainText2.Text = "Отлично! Благодарим за полученную информацию и оплату.\r" +
                            "\n‼ ВАЖНО: Обязательно завершите все предыдущие обращения.‼\r" +
                            "\nДалее перейдите по ссылке: https://help.steampowered.com/ru/wizard/HelpWithLoginInfo?accountsearch=1&issueid=408&reset=1\r" +
                            "\nВы должны выполнить следующие шаги:\r\n\r" +
                            "\n1). Вводите имя аккаунта/адрес почты/номер телефона (1 из перечисленного)\r" +
                            "\n2). Выбираете пункт: \"У меня больше нет доступа к этому адресу эл. почты\"\r" +
                            "\n3) Вам открывается форма для заполнения. Внесите в соответствующие поля необходимую информацию:\r" +
                            "\n• Ваш текущий адрес эл. почты (наш ответ придет на него) - вводите почту, к которой имеете доступ.\r\n\r" +
                            "\n----===== Расскажите нам о своем аккаунте Steam... =====--—\r" +
                            "\n• Какой адрес эл. почты использовался на этом аккаунте первым? - оставьте поле пустым.\r" +
                            "\n• Укажите номер телефона, привязанный к аккаунту - указываете номер телефона, который был привязан к аккаунту (обязательно с кодом страны).\r\n\r" +
                            "\n----===== Регистрировали ли вы на аккаунте ключи активации? =====--—\r" +
                            "\n• Если у вас есть какой-либо ключ - введите его сюда.\r\n\r\n\r" +
                            "\nСейчас я создам макет для последней формы обращения. Пожалуйста, подождите ещё немного";
            }
            else if (cb1_2.Checked && cb2_2.Checked && cb3_2.Checked)
            {
                mainText2.Text = "Отлично! Благодарим за полученную информацию и оплату.\r" +
                            "\n‼ ВАЖНО: Обязательно завершите все предыдущие обращения.‼\r" +
                            "\nДалее перейдите по ссылке: https://help.steampowered.com/ru/wizard/HelpWithLoginInfo?accountsearch=1&issueid=408&reset=1\r" +
                            "\nВы должны выполнить следующие шаги:\r\n\r" +
                            "\n1). Вводите имя аккаунта/адрес почты/номер телефона (1 из перечисленного)\r" +
                            "\n2). Выбираете пункт: \"У меня больше нет доступа к этому адресу эл. почты\"\r" +
                            "\n3) Вам открывается форма для заполнения. Внесите в соответствующие поля необходимую информацию:\r" +
                            "\n• Ваш текущий адрес эл. почты (наш ответ придет на него) - вводите почту, к которой имеете доступ. Желательно первоначальную почту аккаунта.\r\n\r" +
                            "\n----===== Расскажите нам о своем аккаунте Steam... =====--—\r" +
                            "\n• Какой адрес эл. почты использовался на этом аккаунте первым? - вводите почту, на которую был зарегистрирован аккаунт.\r" +
                            "\n• Укажите номер телефона, привязанный к аккаунту - указываете номер телефона, который был привязан к аккаунту (обязательно с кодом страны).\r\n\r" +
                            "\n----===== Регистрировали ли вы на аккаунте ключи активации? =====--—\r" +
                            "\n• Если у вас есть какой-либо ключ - введите его сюда.\r\n\r\n\r" +
                            "\nСейчас я создам макет для последней формы обращения. Пожалуйста, подождите ещё немного";
            }


            else
            {
                mainText2.Text = "Укажите, какие материалы предоставил клиент, выбрав соответствующие галочки!\n" +
                "\nПРИМЕЧАНИЕ: В начале нажимаете на кнопку [ COPY RESULT ], затем кнопку [ COPY IMG GUIDE ] для полного представления инструкции действий." +
                "\n[ COPY RESULT ] --> Копируете для предоставления текстовую инструкцию." +
                "\n[ COPY IMG GUIDE ] --> Копируете для предоставления визуальную инструкцию.";
            }


        }

        //// Метод для сохранения состояния всех чекбоксов
        //public void SaveState()
        //{
        //    checkboxStates = new bool[]
        //    {
        //        cb1_2.Checked,
        //        cb2_2.Checked,
        //        cb3_2.Checked
        //    };
        //}

        //public void RestoreState() 
        //{
        //    if (checkboxStates != null)
        //    {
        //        cb1_2.Checked = checkboxStates[0];
        //        cb2_2.Checked = checkboxStates[1];
        //        cb3_2.Checked = checkboxStates[2];
        //        // Восстановите больше чекбоксов, если необходимо
        //    }
        //}
        //mainForm openForm = new mainForm();
        public void openForm1()
        {

            mainForm openForm = new mainForm();
            //Form openForm1 = new Form();
            openForm.StartPosition = FormStartPosition.Manual;
            openForm.Location = Location;
            openForm.Size = Size;
            openForm.Show();
            this.Hide();
        }

        private void cb1_2_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Type: " + cb1_2.CheckState + "\nCheck: " + cb1_2.Checked + "\nDataStoage CheckBox1: " + DataStorage.Cb_email);
            //DataStorage.CheckBox1.Checked = tumbler;
            DataStorage.Cb_email = cb1_2.Checked;
            //cb1_2.Checked = false;
            //MessageBox.Show("DataStorage.CheckBox1 Status: " + cb1_2.Checked);
            //MessageBox.Show("DataStorage checkbox1 Status: " + DataStorage.CheckBox1.Checked);
            checkedInstructionsGuide();

        }

        private void cb2_2_CheckedChanged(object sender, EventArgs e)
        {
            DataStorage.Cb_phone = cb2_2.Checked;
            checkedInstructionsGuide();
        }

        private void cb3_2_CheckedChanged(object sender, EventArgs e)
        {
            DataStorage.Cb_gameKey = cb3_2.Checked;
            checkedInstructionsGuide();
        }

        private void MaximizeBtn2_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void MinimizeBtn2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resultBtn2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mainText2.Text);
        }

        private void additionMatBtn_Click(object sender, EventArgs e)
        {

            //imageList1 = new ImageList();

            //string imagePaths = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            //MessageBox.Show("imagePath" + imagePaths);
            //if (Directory.Exists(imagePaths))
            //{
            //    // Получаем список всех файлов в папке Resources
            //    string[] imageFiles = Directory.GetFiles(imagePaths, "*.png"); // Или укажите другой формат: *.jpg, *.jpeg

            //    foreach (string filePath in imageFiles)
            //    {

            //        // Загружаем изображения из файлов
            //        imageList1.Images.Add(Image.FromFile(filePath));
            //        //MessageBox.Show("imagePath Array: " + imagePaths + "\nfilePath: " + filePath);
            //    }

            //    imageList1.ImageSize = new Size(256, 190);
            //    listView1.View = View.LargeIcon;
            //    this.listView1.TileSize = new Size(5, 14);
            //    listView1.LargeImageList = imageList1;
            //    listView1.Items.Add("", 0);
            //    listView1.Items.Add("", 1);
            //    listView1.Items.Add("", 2);

            //    Clipboard.SetImage();
            //}
            //else
            //{
            //    MessageBox.Show($"Папка Resources не найдена: {imagePaths}", "Ошибка");
            //}

            ////MessageBox.Show("Content: " + imageList1.Images[0].Size + "\nTile Size: " + listView1.TileSize + "\nImage Size: " + imageList1.ImageSize);

            List<Image> images = new List<Image>();
            imageList1 = new ImageList();

            string imagePaths = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            //MessageBox.Show("imagePath: " + imagePaths);

            if (Directory.Exists(imagePaths))
            {
                // Получаем список всех файлов в папке Resources
                string[] imageFiles = Directory.GetFiles(imagePaths, "*.png");

                foreach (string filePath in imageFiles)
                {
                    // Загружаем изображения из файлов и сохраняем в список
                    images.Add(Image.FromFile(filePath));
                    imageList1.Images.Add(Image.FromFile(filePath));
                }

                imageList1.ImageSize = new Size(256, 190);
                this.listView1.TileSize = new Size(5, 14);
                listView1.View = View.LargeIcon;

                listView1.LargeImageList = imageList1;


                for (int i = 0; i < images.Count; i++)
                {
                    // Добавляем элементы в ListView с использованием индекса
                    listView1.Items.Add("", i);
                    //MessageBox.Show("lisView Image: " + images[i].ToString());
                }

                // Объединяем изображения в одно
                if (images.Count > 0)
                {
                    int spacing = 5; // Пробел между изображениями
                    int totalWidth = (images.Count - 1) * spacing; // Начальная ширина (учитывая отступы)
                    int maxHeight = 0;

                    foreach (Image img in images)
                    {
                        totalWidth += img.Width; // Общая ширина всех изображений
                        maxHeight = Math.Max(maxHeight, img.Height); // Максимальная высота
                    }

                    Bitmap finalBitmap = new Bitmap(totalWidth, maxHeight);
                    using (Graphics g = Graphics.FromImage(finalBitmap))
                    {
                        // Устанавливаем прозрачный фон
                        g.Clear(Color.Transparent);

                        // Параметры для высокого качества
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                        g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                        int currentX = 0;
                        foreach (Image img in images)
                        {
                            g.DrawImage(img, currentX, 0, img.Width, img.Height);
                            currentX += img.Width + spacing; // Добавляем ширину изображения и отступ
                        }
                    }

                    // Копируем объединённое изображение с прозрачным фоном в буфер обмена
                    Clipboard.SetImage(finalBitmap);
                    //MessageBox.Show("Все изображения объединены, с прозрачным фоном, и скопированы в буфер обмена!", "Успех");
                }
                else
                {
                    MessageBox.Show("Нет изображений для копирования.", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show($"Папка Resources не найдена: {imagePaths}", "Ошибка");
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void appPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void infoBtn2_Click(object sender, EventArgs e)
        {
            openForm1();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //listView1.View = View.Details;

            //listView1.Columns.Add("columImages");
            //listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            //mainText2.Text = "";
        }
    }
}
