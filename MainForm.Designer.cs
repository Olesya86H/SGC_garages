
namespace SGC_garages
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.реестрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПоискГаражаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.владельцыГаражейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плательщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общийСписокФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиСистемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыГаражейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыСтатейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статьиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.единицыИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётСамостройToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётНеСамостройToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётЖелезныеГаражиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчт2хЭтажныеГаражиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётЭлектричествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётАрендаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётШлагбаумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяДействийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьПисьмоВТехподдержкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPaymentBtn = new System.Windows.Forms.Button();
            this.NewGarageBtn = new System.Windows.Forms.Button();
            this.ReeBtn = new System.Windows.Forms.Button();
            this.FindGarageBtn = new System.Windows.Forms.Button();
            this.реестрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПлатёжToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйГаражToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.отчётностьToolStripMenuItem,
            this.сервисыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.личныйКабинетToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // реестрToolStripMenuItem
            // 
            this.реестрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПлатёжToolStripMenuItem,
            this.новыйГаражToolStripMenuItem,
            this.реестрыToolStripMenuItem,
            this.ПоискГаражаToolStripMenuItem});
            this.реестрToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.marked_list_points;
            this.реестрToolStripMenuItem.Name = "реестрToolStripMenuItem";
            this.реестрToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.реестрToolStripMenuItem.Text = "Главное";
            // 
            // ПоискГаражаToolStripMenuItem
            // 
            this.ПоискГаражаToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.find;
            this.ПоискГаражаToolStripMenuItem.Name = "ПоискГаражаToolStripMenuItem";
            this.ПоискГаражаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ПоискГаражаToolStripMenuItem.Text = "Поиск гаража";
            this.ПоискГаражаToolStripMenuItem.Click += new System.EventHandler(this.ПоискГаражаToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.владельцыГаражейToolStripMenuItem,
            this.плательщикиToolStripMenuItem,
            this.общийСписокФИОToolStripMenuItem,
            this.пользователиСистемыToolStripMenuItem,
            this.типыГаражейToolStripMenuItem,
            this.типыСтатейToolStripMenuItem,
            this.статьиToolStripMenuItem,
            this.единицыИзмеренияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.book;
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // владельцыГаражейToolStripMenuItem
            // 
            this.владельцыГаражейToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.user;
            this.владельцыГаражейToolStripMenuItem.Name = "владельцыГаражейToolStripMenuItem";
            this.владельцыГаражейToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.владельцыГаражейToolStripMenuItem.Text = "Владельцы гаражей";
            this.владельцыГаражейToolStripMenuItem.Click += new System.EventHandler(this.владельцыГаражейToolStripMenuItem_Click);
            // 
            // плательщикиToolStripMenuItem
            // 
            this.плательщикиToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.user;
            this.плательщикиToolStripMenuItem.Name = "плательщикиToolStripMenuItem";
            this.плательщикиToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.плательщикиToolStripMenuItem.Text = "Плательщики";
            this.плательщикиToolStripMenuItem.Click += new System.EventHandler(this.плательщикиToolStripMenuItem_Click);
            // 
            // общийСписокФИОToolStripMenuItem
            // 
            this.общийСписокФИОToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.user;
            this.общийСписокФИОToolStripMenuItem.Name = "общийСписокФИОToolStripMenuItem";
            this.общийСписокФИОToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.общийСписокФИОToolStripMenuItem.Text = "Общий список ФИО";
            this.общийСписокФИОToolStripMenuItem.Click += new System.EventHandler(this.общийСписокФИОToolStripMenuItem_Click);
            // 
            // пользователиСистемыToolStripMenuItem
            // 
            this.пользователиСистемыToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.user;
            this.пользователиСистемыToolStripMenuItem.Name = "пользователиСистемыToolStripMenuItem";
            this.пользователиСистемыToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.пользователиСистемыToolStripMenuItem.Text = "Пользователи системы";
            this.пользователиСистемыToolStripMenuItem.Click += new System.EventHandler(this.пользователиСистемыToolStripMenuItem_Click);
            // 
            // типыГаражейToolStripMenuItem
            // 
            this.типыГаражейToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.garage_16;
            this.типыГаражейToolStripMenuItem.Name = "типыГаражейToolStripMenuItem";
            this.типыГаражейToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.типыГаражейToolStripMenuItem.Text = "Типы гаражей";
            this.типыГаражейToolStripMenuItem.Click += new System.EventHandler(this.типыГаражейToolStripMenuItem_Click);
            // 
            // типыСтатейToolStripMenuItem
            // 
            this.типыСтатейToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.pack_money;
            this.типыСтатейToolStripMenuItem.Name = "типыСтатейToolStripMenuItem";
            this.типыСтатейToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.типыСтатейToolStripMenuItem.Text = "Типы статей";
            this.типыСтатейToolStripMenuItem.Click += new System.EventHandler(this.типыСтатейToolStripMenuItem_Click);
            // 
            // статьиToolStripMenuItem
            // 
            this.статьиToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.calculator;
            this.статьиToolStripMenuItem.Name = "статьиToolStripMenuItem";
            this.статьиToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.статьиToolStripMenuItem.Text = "Статьи";
            this.статьиToolStripMenuItem.Click += new System.EventHandler(this.статьиToolStripMenuItem_Click);
            // 
            // единицыИзмеренияToolStripMenuItem
            // 
            this.единицыИзмеренияToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.clock;
            this.единицыИзмеренияToolStripMenuItem.Name = "единицыИзмеренияToolStripMenuItem";
            this.единицыИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.единицыИзмеренияToolStripMenuItem.Text = "Единицы измерения";
            this.единицыИзмеренияToolStripMenuItem.Click += new System.EventHandler(this.единицыИзмеренияToolStripMenuItem_Click);
            // 
            // отчётностьToolStripMenuItem
            // 
            this.отчётностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётСамостройToolStripMenuItem,
            this.отчётНеСамостройToolStripMenuItem,
            this.отчётЖелезныеГаражиToolStripMenuItem,
            this.отчт2хЭтажныеГаражиToolStripMenuItem,
            this.отчётЭлектричествоToolStripMenuItem,
            this.отчётАрендаToolStripMenuItem,
            this.отчётШлагбаумToolStripMenuItem});
            this.отчётностьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.reportexcel;
            this.отчётностьToolStripMenuItem.Name = "отчётностьToolStripMenuItem";
            this.отчётностьToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.отчётностьToolStripMenuItem.Text = "Отчётность";
            // 
            // отчётСамостройToolStripMenuItem
            // 
            this.отчётСамостройToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.reportexcel;
            this.отчётСамостройToolStripMenuItem.Name = "отчётСамостройToolStripMenuItem";
            this.отчётСамостройToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.отчётСамостройToolStripMenuItem.Text = "Отчёт \"Самострой\"";
            this.отчётСамостройToolStripMenuItem.Click += new System.EventHandler(this.отчётСамостройToolStripMenuItem_Click);
            // 
            // отчётНеСамостройToolStripMenuItem
            // 
            this.отчётНеСамостройToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.reportexcel;
            this.отчётНеСамостройToolStripMenuItem.Name = "отчётНеСамостройToolStripMenuItem";
            this.отчётНеСамостройToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.отчётНеСамостройToolStripMenuItem.Text = "Отчёт \"Не самострой\"";
            this.отчётНеСамостройToolStripMenuItem.Click += new System.EventHandler(this.отчётНеСамостройToolStripMenuItem_Click);
            // 
            // отчётЖелезныеГаражиToolStripMenuItem
            // 
            this.отчётЖелезныеГаражиToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.reportexcel;
            this.отчётЖелезныеГаражиToolStripMenuItem.Name = "отчётЖелезныеГаражиToolStripMenuItem";
            this.отчётЖелезныеГаражиToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.отчётЖелезныеГаражиToolStripMenuItem.Text = "Отчёт \"Железные гаражи\"";
            this.отчётЖелезныеГаражиToolStripMenuItem.Click += new System.EventHandler(this.отчётЖелезныеГаражиToolStripMenuItem_Click);
            // 
            // отчт2хЭтажныеГаражиToolStripMenuItem
            // 
            this.отчт2хЭтажныеГаражиToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.reportexcel;
            this.отчт2хЭтажныеГаражиToolStripMenuItem.Name = "отчт2хЭтажныеГаражиToolStripMenuItem";
            this.отчт2хЭтажныеГаражиToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.отчт2хЭтажныеГаражиToolStripMenuItem.Text = "Отчёт \"2-х этажные гаражи\"";
            this.отчт2хЭтажныеГаражиToolStripMenuItem.Click += new System.EventHandler(this.отчт2хЭтажныеГаражиToolStripMenuItem_Click);
            // 
            // отчётЭлектричествоToolStripMenuItem
            // 
            this.отчётЭлектричествоToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.reportexcel;
            this.отчётЭлектричествоToolStripMenuItem.Name = "отчётЭлектричествоToolStripMenuItem";
            this.отчётЭлектричествоToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.отчётЭлектричествоToolStripMenuItem.Text = "Отчёт \"Электричество\"";
            this.отчётЭлектричествоToolStripMenuItem.Click += new System.EventHandler(this.отчётЭлектричествоToolStripMenuItem_Click);
            // 
            // отчётАрендаToolStripMenuItem
            // 
            this.отчётАрендаToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.reportexcel;
            this.отчётАрендаToolStripMenuItem.Name = "отчётАрендаToolStripMenuItem";
            this.отчётАрендаToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.отчётАрендаToolStripMenuItem.Text = "Отчёт \"Аренда\"";
            this.отчётАрендаToolStripMenuItem.Click += new System.EventHandler(this.отчётАрендаToolStripMenuItem_Click);
            // 
            // отчётШлагбаумToolStripMenuItem
            // 
            this.отчётШлагбаумToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.reportexcel;
            this.отчётШлагбаумToolStripMenuItem.Name = "отчётШлагбаумToolStripMenuItem";
            this.отчётШлагбаумToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.отчётШлагбаумToolStripMenuItem.Text = "Отчёт \"Благоустройство\"";
            this.отчётШлагбаумToolStripMenuItem.Click += new System.EventHandler(this.отчётШлагбаумToolStripMenuItem_Click);
            // 
            // сервисыToolStripMenuItem
            // 
            this.сервисыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяДействийToolStripMenuItem,
            this.отправитьПисьмоВТехподдержкуToolStripMenuItem});
            this.сервисыToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.options;
            this.сервисыToolStripMenuItem.Name = "сервисыToolStripMenuItem";
            this.сервисыToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.сервисыToolStripMenuItem.Text = "Сервисы";
            // 
            // историяДействийToolStripMenuItem
            // 
            this.историяДействийToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.history;
            this.историяДействийToolStripMenuItem.Name = "историяДействийToolStripMenuItem";
            this.историяДействийToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.историяДействийToolStripMenuItem.Text = "История действий";
            this.историяДействийToolStripMenuItem.Click += new System.EventHandler(this.историяДействийToolStripMenuItem_Click);
            // 
            // отправитьПисьмоВТехподдержкуToolStripMenuItem
            // 
            this.отправитьПисьмоВТехподдержкуToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.envelope_out1;
            this.отправитьПисьмоВТехподдержкуToolStripMenuItem.Name = "отправитьПисьмоВТехподдержкуToolStripMenuItem";
            this.отправитьПисьмоВТехподдержкуToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.отправитьПисьмоВТехподдержкуToolStripMenuItem.Text = "Отправить письмо в тех.поддержку";
            this.отправитьПисьмоВТехподдержкуToolStripMenuItem.Click += new System.EventHandler(this.отправитьПисьмоВТехподдержкуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.user;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.оПрограммеToolStripMenuItem.Text = "Личный кабинет";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.property;
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.личныйКабинетToolStripMenuItem.Text = "О программе";
            this.личныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.личныйКабинетToolStripMenuItem_Click_1);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.delete;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // NewPaymentBtn
            // 
            this.NewPaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NewPaymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPaymentBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.NewPaymentBtn.Image = global::SGC_garages.Properties.Resources.money_dollar;
            this.NewPaymentBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewPaymentBtn.Location = new System.Drawing.Point(21, 41);
            this.NewPaymentBtn.Name = "NewPaymentBtn";
            this.NewPaymentBtn.Size = new System.Drawing.Size(327, 130);
            this.NewPaymentBtn.TabIndex = 1;
            this.NewPaymentBtn.Text = "Новый платёж";
            this.NewPaymentBtn.UseVisualStyleBackColor = false;
            this.NewPaymentBtn.Click += new System.EventHandler(this.новыйПлатёжToolStripMenuItem_Click);
            // 
            // NewGarageBtn
            // 
            this.NewGarageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGarageBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.NewGarageBtn.Image = global::SGC_garages.Properties.Resources.garage_48;
            this.NewGarageBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NewGarageBtn.Location = new System.Drawing.Point(354, 41);
            this.NewGarageBtn.Name = "NewGarageBtn";
            this.NewGarageBtn.Size = new System.Drawing.Size(335, 130);
            this.NewGarageBtn.TabIndex = 2;
            this.NewGarageBtn.Text = "Новый гараж";
            this.NewGarageBtn.UseVisualStyleBackColor = true;
            this.NewGarageBtn.Click += new System.EventHandler(this.новыйГаражToolStripMenuItem_Click);
            // 
            // ReeBtn
            // 
            this.ReeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReeBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.ReeBtn.Image = global::SGC_garages.Properties.Resources.spreadsheet_48;
            this.ReeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReeBtn.Location = new System.Drawing.Point(21, 177);
            this.ReeBtn.Name = "ReeBtn";
            this.ReeBtn.Size = new System.Drawing.Size(327, 130);
            this.ReeBtn.TabIndex = 3;
            this.ReeBtn.Text = "Все реестры";
            this.ReeBtn.UseVisualStyleBackColor = true;
            this.ReeBtn.Click += new System.EventHandler(this.реестрыToolStripMenuItem_Click);
            // 
            // FindGarageBtn
            // 
            this.FindGarageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindGarageBtn.ForeColor = System.Drawing.Color.DarkGreen;
            this.FindGarageBtn.Image = global::SGC_garages.Properties.Resources.find_48;
            this.FindGarageBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FindGarageBtn.Location = new System.Drawing.Point(354, 177);
            this.FindGarageBtn.Name = "FindGarageBtn";
            this.FindGarageBtn.Size = new System.Drawing.Size(335, 130);
            this.FindGarageBtn.TabIndex = 4;
            this.FindGarageBtn.Text = "Поиск гаража";
            this.FindGarageBtn.UseVisualStyleBackColor = true;
            this.FindGarageBtn.Click += new System.EventHandler(this.ПоискГаражаToolStripMenuItem_Click);
            // 
            // реестрыToolStripMenuItem
            // 
            this.реестрыToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.spreadsheet_48;
            this.реестрыToolStripMenuItem.Name = "реестрыToolStripMenuItem";
            this.реестрыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.реестрыToolStripMenuItem.Text = "Реестры";
            this.реестрыToolStripMenuItem.Click += new System.EventHandler(this.реестрыToolStripMenuItem_Click);
            // 
            // новыйПлатёжToolStripMenuItem
            // 
            this.новыйПлатёжToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.money_dollar;
            this.новыйПлатёжToolStripMenuItem.Name = "новыйПлатёжToolStripMenuItem";
            this.новыйПлатёжToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйПлатёжToolStripMenuItem.Text = "Новый платёж";
            this.новыйПлатёжToolStripMenuItem.Click += new System.EventHandler(this.новыйПлатёжToolStripMenuItem_Click);
            // 
            // новыйГаражToolStripMenuItem
            // 
            this.новыйГаражToolStripMenuItem.Image = global::SGC_garages.Properties.Resources.garage_48;
            this.новыйГаражToolStripMenuItem.Name = "новыйГаражToolStripMenuItem";
            this.новыйГаражToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйГаражToolStripMenuItem.Text = "Новый гараж";
            this.новыйГаражToolStripMenuItem.Click += new System.EventHandler(this.новыйГаражToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 329);
            this.Controls.Add(this.FindGarageBtn);
            this.Controls.Add(this.ReeBtn);
            this.Controls.Add(this.NewGarageBtn);
            this.Controls.Add(this.NewPaymentBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПС \"Учёт гаражей\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem реестрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem владельцыГаражейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плательщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общийСписокФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиСистемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыГаражейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыСтатейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статьиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem единицыИзмеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяДействийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьПисьмоВТехподдержкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётСамостройToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётНеСамостройToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётЖелезныеГаражиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчт2хЭтажныеГаражиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётЭлектричествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётАрендаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётШлагбаумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПоискГаражаToolStripMenuItem;
        private System.Windows.Forms.Button NewPaymentBtn;
        private System.Windows.Forms.Button NewGarageBtn;
        private System.Windows.Forms.Button ReeBtn;
        private System.Windows.Forms.Button FindGarageBtn;
        private System.Windows.Forms.ToolStripMenuItem новыйПлатёжToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйГаражToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрыToolStripMenuItem;
    }
}

