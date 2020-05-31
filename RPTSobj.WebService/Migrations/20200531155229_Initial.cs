using Microsoft.EntityFrameworkCore.Migrations;

namespace RPTSobj.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RPTSobjs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    MetroStation = table.Column<string>(nullable: true),
                    MetroLine = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPTSobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 1L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Успенский собор", "assumption-cathedral.kreml.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 377L, "Андроньевская площадь, дом 10", "Калининская линия", "Площадь Ильича", "Храм Спаса Нерукотворного Образа в Спасо-Андрониковом монастыре", "www.rublev-museum.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 376L, "Динамовская улица, дом 28", "Люблинско-Дмитровская линия", "Крестьянская застава", "Храм Сорока Севастийских мучеников в Спасской слободе", "40much.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 375L, "Николоямская улица, дом 10", "Кольцевая линия", "Таганская", "Храм преподобного Симеона Столпника за Яузой", "simeonstolpnik.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 374L, "Николоямская улица, дом 59", "Калининская линия", "Площадь Ильича", "Храм преподобного Сергия Радонежского (Живоначальной Троицы) в Рогожской слободе", "sergeyrad.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 373L, "улица Солянка, дом 5/2", "Таганско-Краснопресненская линия", "Китай-город", "Храм Рождества Пресвятой Богородицы на Кулишках (на Стрелке), Патриаршее подворье", "xram-alani.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 372L, "Лыщиков переулок, дом 10", "Кольцевая линия", "Таганская", "Храм Покрова Пресвятой Богородицы на Лыщиковой горе", "покровахрам.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 371L, "Тессинский переулок, дом 3", "Люблинско-Дмитровская линия", "Чкаловская", "Храм Петра свт., митр. Крутицкого (домовый) при гимназии Спасского Братства, приписной к храму свт. Николая в Кузнецкой слободе", "www.nikvkuz.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 370L, "Верхняя Радищевская улица, дом 20", "Кольцевая линия", "Таганская", "Храм Святителя Николая на Болвановке", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 369L, "1-й Котельнический переулок, дом 8, строение 1", "Кольцевая линия", "Таганская", "Храм Святителя Николая в Котельниках (Подворье Православной Церкви Чешских земель и Словакии)", "www.pccs.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 368L, "Гончарная улица, дом 4/6", "Кольцевая линия", "Таганская", "Храм великомученика Никиты на Швивой горке за Яузой в Москве (Подворье Русского на Афоне Свято-Пантелеимонова монастыря )", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 367L, "Марксистская улица, дом 34", "Люблинско-Дмитровская линия", "Крестьянская застава", "Храм Архангела Михаила при детском семейном образовательном телеканале «Радость моя»", "vtolmachah.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 366L, "Андроньевская площадь, дом 10", "Калининская линия", "Площадь Ильича", "Храм Архангела Михаила в Спасо-Андрониковом монастыре", "www.rublev-museum.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 365L, "Таганская улица, дом 20А", "Калининская линия", "Марксистская", "Храм Святителя Николая Мирликийского (Казанской иконы Божией Матери) в Студенцах (единоверческий)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 364L, "улица Талалихина, дом 24", "Таганско-Краснопресненская линия", "Пролетарская", "Храм Иерусалимской иконы Божией Матери за Покровской заставой, Представительство Крестовоздвиженского Иерусалимского ставропигиального женского монастыря, Патриаршее подворье", "www.ierhram-kupel.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 378L, "Серебрянический переулок, дом 1А", "Таганско-Краснопресненская линия", "Китай-город", "Храм Троицы Живоначальной в Серебряниках с отдельно стоящей колокольней и храмом Иоанна Предтечи Усекновения главы", "zvon80.ucoz.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 363L, "Петропавловский переулок, дом 4-6", "Таганско-Краснопресненская линия", "Китай-город", "Храм иконы Божией Матери «Знамение» (свв. апп. Петра и Павла) у Яузских ворот (Подворье Сербской Православной Церкви)", "www.serbskoe-podvorie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 361L, "Славянская площадь, дом 2", "Таганско-Краснопресненская линия", "Китай-город", "Храм всех святых на Кулишках (Подворье Александрийской Православной Церкви)", "www.podvorie-alexandria.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 360L, "Гончарная улица, дом 4/6", "Кольцевая линия", "Таганская", "Храм всех афонских святых (Подворье Русского на Афоне Свято-Пантелеимонова монастыря)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 359L, "Крутицкая улица, дом 13", "Люблинско-Дмитровская линия", "Крестьянская застава", "Храм Воскресения Словущего на Крутицком подворье", "www.krutitsy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 358L, "улица Александра Солженицына, дом 15", "Кольцевая линия", "Таганская", "Храм Вознесения Господня (святителя Мартина Исповедника) в Алексеевской Новой слободе", "www.st-martin.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 357L, "Международная улица, дом 10, строение 2", "Люблинско-Дмитровская линия", "Римская", "Храм преподобного Василия Исповедника (Петра и Павла свв. апп.) у Рогожской заставы, Патриаршее подворье", "василийисповедник.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 356L, "улица Воронцово Поле, дом 16", "Люблинско-Дмитровская линия", "Чкаловская", "Храм Благовещения Пресвятой Богородицы (Илии пророка Божия) на Воронцовом поле", "iliya-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 355L, "улица Станиславского, дом 29, строение 3", "Калининская линия", "Площадь Ильича", "Храм святителя Алексия Митрополита Московского, в Рогожской слободе", "alexiy-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 354L, "деревня Уварово, улица Ирбис, дом 57А", "Сокольническая линия", "Румянцево", "Храм Святителя Феодора Едесского в Уварове", "uvarovo-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 353L, "деревня Большое Свинорье, дом 65", "Калужско-Рижская линия", "Тёплый стан", "Храм Спаса Нерукотворного Образа, деревня Большое Свинорье", "hramspasa.np-mos.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 352L, "деревня Руднево, Славянская улица, дом 9", "Сокольническая линия", "Румянцево", "Церковь Рождества Пресвятой Богородицы, деревня Руднево", "www.odigitria-blago.ru/churches/8/" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 351L, "деревня Большое Покровское, Лесная улица, дом 11/1", "Сокольническая линия", "Румянцево", "Храм Покрова Пресвятой Богородицы, деревня Большое Покровское", "www.odigitria-blago.ru/churches/10/" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 350L, "рабочий посёлок Киевский, Бекасовская улица, дом 19", "Сокольническая линия", "Румянцево", "Храм иконы Божией Матери «Неупиваемая Чаша» в поселке Киевский", "kievskiyhram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 349L, "деревня Пучково, Богородская улица, дом 7", "Сокольническая линия", "Юго-Западная", "Храм Казанской иконы Божией Матери в Пучково", "hram-puchkovo.me-ga.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 348L, "деревня Белоусово, дом 1", "Сокольническая линия", "Юго-Западная", "Храм Михаила Архангела, деревня Белоусово", "hram-belousovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 362L, "Большой Калитниковский проезд, дом 11", "Таганско-Краснопресненская линия", "Волгоградский проспект", "Храм иконы Божией Матери «Всех Скорбящих Радость» на Калитниках", "hramkalitniki.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 379L, "Гончарная улица, дом 29", "Кольцевая линия", "Таганская", "Храм Успения Пресвятой Богородицы в Гончарах (Подворье Болгарской Православной Церкви)", "bolgarskoe-podvorie.com" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 380L, "Крутицкая улица, дом 11", "Люблинско-Дмитровская линия", "Крестьянская застава", "Собор Успения Пресвятой Богородицы на Крутицах", "www.krutitsy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 381L, "улица Трофимова, дом 14", "Замоскворецкая линия", "Автозаводская", "Храм святого благоверного князя Александра Невского в Кожухово", "www.starosimonovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 412L, "Севастопольский проспект, дом 21", "Серпуховско-Тимирязевская линия", "Нагорная", "Храм иконы Божией Матери «Целительница» при медцентре Центробанка России в Узком, приписной к храму Казанской иконы Божией Матери в Узком", "uzkoe.narod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 411L, "улица Островитянова, дом 16, корпус 5", "Калужско-Рижская линия", "Коньково", "Храм преподобного Серафима Саровского при доме-интернате ветеранов труда № 31 (домовый), приписной к храму Архангела Михаила в Тропареве", "troparevo-hram.org" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 410L, "Черневская улица, дом 1", "Калужско-Рижская линия", "Ясенево", "Храм Рождества Христова в Черневе", "butovohram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 409L, "Голубинская улица, дом 32, корпус 2", "Калужско-Рижская линия", "Новоясеневская", "Храм Петра свв. блгг. кн. и кн. Февронии, Муромских чудотврцев при КЦСО «Ясенево» (домовый), приписной к храму свв. апп. Петра и Павла в Ясеневе", "optina.org.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 408L, "Новоясеневский проспект, дом 42", "Калужско-Рижская линия", "Новоясеневская", "Храм Святых Апостолов в Ясеневе, Подворье Свято-Введенской Оптиной пустыни", "optina.org.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 407L, "Старокачаловская улица, дом 8, корпус 1", "Серпуховско-Тимирязевская линия", "Бульвар Дмитрия Донского", "Храм вмц. Параскевы Пятницы в Качалове, Северное Бутово", "paraskeva.butovo-msk.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 406L, "Литовский бульвар, дом 1А", "Калужско-Рижская линия", "Ясенево", "Храм в честь великомученика и целителя Пантелеимона при ЦКБ РАМН (домовый), приписной к храму прпп. Зосимы и Савватия Соловецких в Гольянове", "www.hramzis.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 405L, "Остафьевская улица, домовладение 44", "Серпуховско-Тимирязевская линия", "Бульвар Дмитрия Донского", "Храм в честь великомученика и целителя Пантелеимона в Потапове (Южное Бутово)", "hram-vlad-butovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 404L, "улица Островитянова, дом 8, строение 1", "Калужско-Рижская линия", "Коньково", "Храм Святителя Льва Великого", "svt-lev-velikiy.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 403L, "улица Поляны, дом 4", "Серпуховско-Тимирязевская линия", "Бульвар Дмитрия Донского", "Храм святых бессребреников Космы и Дамиана при ГУЗ «Хоспис №3» УЗ ЮЗАО (домовый),приписной к храму великомученицы Параскевы Пятницы в Качалове", "paraskeva.butovo-msk.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 402L, "Профсоюзная улица, дом 123Б", "Калужско-Рижская линия", "Ясенево", "Храм Казанской иконы Божией Матери в Узком", "uzkoe.narod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 401L, "проезд Одоевского, дом 13", "Калужско-Рижская линия", "Ясенево", "Храм Иоанна Богослова при православной классической гимназии «Ясенево»", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 400L, "улица Николая Сироткина, дом 28А, строение 1", "Серпуховско-Тимирязевская линия", "Бульвар Дмитрия Донского", "Храм «Знамение» иконы Божией Матери в Захарьине", "hram1648.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 399L, "Профсоюзная улица, дом 140, корпус 6", "Калужско-Рижская линия", "Коньково", "Храм святого благоверного князя Дмитрия Донского при пансионате «Коньково» для ветеранов войны (домовый), приписной к храму вмч. Анастасии Узорешительницы в Теплом Стане", "butovo.orthodoxy.ru/hram.php?page=29" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 398L, "улица Островитянова, дом 10", "Калужско-Рижская линия", "Коньково", "Храм Воскресения Христова при Пансионате для ветеранов труда № 6 (домовый)", "optina.org.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 397L, "Самокатная улица, дом 3/8, строение 16", "Калининская линия", "Площадь Ильича", "Храм Троицы Живоначальной у Салтыкова моста", "saltykovmost.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 396L, "Рязанский проспект, дом 3", "Калининская линия", "Авиамоторная", "Храм Троицы Живоначальной в Карачарове", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 382L, "Самокатная улица, дом 3/8", "Калининская линия", "Площадь Ильича", "Храм Введения во храм Пресвятой Богородицы на Новоблагословенной, у Салтыкова моста", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 383L, "Окская улица, дом 17, строение 2", "Таганско-Краснопресненская линия", "Рязанский проспект", "Храм Введения во храм Пресвятой Богородицы на Рязанке приписной к храму преподобного Сергия Радонежского на Рязанке", "www.hram-ryazanka.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 384L, "Солдатская улица, дом 4", "Арбатско-Покровская линия", "Бауманская", "Храм Воскресения Словущего при Городской клинической больнице № 29 (домовый)", "hramlefortovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 385L, "улица Гурьянова, дом 18А", "Люблинско-Дмитровская линия", "Печатники", "Храм иконы Божией Матери «Всех скорбящих Радость» в Печатниках, приписной к Николо-Перервинскому монастырю", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 386L, "1-й Краснокурсантский проезд, дом 1/4", "Калининская линия", "Площадь Ильича", "Храм святого благоверного князя Димитрия Донского при в/ч 01904 Отдельного Комендантского полка (домовый), приписной к храму свт. Григория Неокесарийского в Дербицах", "www.ieronim-polyanka.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 387L, "Шоссейная улица, дом 82", "Люблинско-Дмитровская линия", "Печатники", "Храм Иверской иконы Божией Матери в Николо-Перервинском монастыре", "перервинский-монастырь.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 347L, "посёлок Первомайское, Парковая улица, дом 12", "Сокольническая линия", "Румянцево", "Церковь Сошествия Святого Духа, поселок Первомайское", "www.odigitria-blago.ru/churches/6/" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 388L, "шоссе Энтузиастов, дом 7", "Калининская линия", "Авиамоторная", "Храм Святителя Николая Мирликийского бывшего Всехсвятского монастыря (не освобожден)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 390L, "улица Рогожский посёлок, дом 1А/29", "Люблинско-Дмитровская линия", "Римская", "Храм Святителя Николая Мирликийского на Рогожском кладбище", "nikolanarogozhke.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 391L, "улица Шкулёва, дом 4", "Люблинско-Дмитровская линия", "Волжская", "Храм иконы Божией Матери «Отрада и Утешение» при 68-й Городской больнице (домовый)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 392L, "Солдатская улица, дом 4", "Арбатско-Покровская линия", "Бауманская", "Храм Петра и Павла в Лефортово с крестильным храмом Архангела Михаила", "hramlefortovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 393L, "Госпитальная площадь, дом 3", "Арбатско-Покровская линия", "Бауманская", "Храм Петра и Павла при Главном военном госпитале им. Н. Н. Бурденко (домовый)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 394L, "Окская улица, дом 17", "Таганско-Краснопресненская линия", "Рязанский проспект", "Храм преподобного Сергия Радонежского на Рязанке", "www.hram-ryazanka.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 395L, "Шоссейная улица, дом 82", "Люблинско-Дмитровская линия", "Печатники", "Надвратная церковь Толгской иконы Божией Матери", "перервинский-монастырь.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 389L, "Шоссейная улица, дом 82", "Люблинско-Дмитровская линия", "Печатники", "Храм Святителя Николая Мирликийского в Николо-Перервинском монастыре", "перервинский-монастырь.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 413L, "Косинская улица, дом 8", "Таганско-Краснопресненская линия", "Выхино", "Храм Алексия свт., митрополита Московского при Психоневрологическом интернате № 26 (домовый)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 346L, "деревня Крекшино, Клубничная улица, дом 329", "Филёвская линия", "Кунцевская", "Храм Воздвижения Креста Господня в Крекшино", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 344L, "дачный посёлок Кокошкино, улица Труда, дом 6", "Сокольническая линия", "Юго-Западная", "Храм Веры, Надежды, Любови и матери их Софии в Кокошкине", "hram-kokoshkino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 308L, "проспект Вернадского, дом 90", "Сокольническая линия", "Юго-Западная", "Храм Архангела Михаила в Тропарево", "troparevo-hram.org" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 307L, "Родниковая улица, дом 12, корпус 1", "Сокольническая линия", "Юго-Западная", "Храм Казанской иконы Божией Матери в Орлово", "hramorlovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 306L, "Озёрная улица, дом 47", "Сокольническая линия", "Юго-Западная", "Храм пророка Иоанна Предтечи и Крестителя Господня на Востряковском кладбище, приписной к храму Архангела Михаила в Тропарево", "m-blago.ru/temples-and-chapels/98-temple-of-the-prophet-of-the-forerunner-and-krestitelja-gospodnja" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 305L, "улица Академика Анохина, дом 28, корпус 1", "Сокольническая линия", "Юго-Западная", "Храм Иоакима и Анны при доме сирот № 11 (домовый), приписной к храму Архангела Михаила в Тропарево", "troparevo-hram.org" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 304L, "7-я улица Лазенки, дом 42", "Сокольническая линия", "Юго-Западная", "Храм великого князя Игоря Черниговского и Киевского в Переделкино", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 303L, "улица Косыгина, дом 61", "Сокольническая линия", "Воробьёвы горы", "Храм Всех Святых на территории Государственного особняка № 14 управления материально-технического обеспечения службы хозяйственного обеспечения Федеральной службы охраны Российской Федерации, приписной к Донскому ставропигиальному мужскому монастырю", "www.donskoi.org" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 302L, "посёлок ОПХ Толстопальцево, улица Осипенко, дом 2", "Сокольническая линия", "Юго-Западная", "Храм Воскресения Христова в Толстопальцеве", "www.christos-anesty.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 301L, "Лукинская улица, дом 11, корпус 1", "Сокольническая линия", "Юго-Западная", "Храм Благовещения Пресвятой Богородицы в Федосьино, что в Солнцево", "www.fedosino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 300L, "Черниговский переулок, дом 3", "Калужско-Рижская линия", "Третьяковская", "Храм Черниговских князя Михаила и боярина Феодора", "www.podborom.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 299L, "улица Большая Полянка, дом 37", "Серпуховско-Тимирязевская линия", "Полянка", "Храм Успения Пресвятой Богородицы в Казачьей слободе", "hramusp.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 298L, "улица Шаболовка, дом 21, строение 1", "Калужско-Рижская линия", "Шаболовская", "Храм Троицы Живоначальной на Шаболовке", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 297L, "Пятницкая улица, дом 51/14, строение 4", "Калужско-Рижская линия", "Третьяковская", "Храм Троицы Живоначальной в Вишняках или Больших Лужниках при Православном Свято-Тихоновском Богословском университете, приписной к храму Святителя Николая в Кузнецкой слободе", "www.nikvkuz.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 296L, "2-й Новокузнецкий переулок, дом 10, строение 1", "Кольцевая линия", "Павелецкая", "Храм Спаса Преображения на Болвановке", "bolvanovka.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 295L, "Софийская набережная, дом 32", "Замоскворецкая линия", "Новокузнецкая", "Храм Софии Премудрости Божией в Средних Садовниках Садовниках с отдельно стоящей колокольней и храмом иконы Божией Матери «Взыскание Погибших»", "www.hram-sofia.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 309L, "проспект Вернадского, дом 100", "Сокольническая линия", "Юго-Западная", "Храм Михаила Архангела при Военной академии Генерального штаба Вооруженных Сил Российской Федерации (домовый)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 294L, "1-й Хвостов переулок, дом 3, строение 1", "Серпуховско-Тимирязевская линия", "Полянка", "Храм иконы Божией Матери «Скоропослушница» (домовый), приписной к Афонскому подворью", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 292L, "Большая Серпуховская улица, дом 24", "Серпуховско-Тимирязевская линия", "Серпуховская", "Храм Святой равноапостольной Ольги на Серпуховской улице при храме Вознесения Господня за Серпуховскими воротами", "www.voznesenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 291L, "Большая Серпуховская улица, дом 24, строение 2", "Серпуховско-Тимирязевская линия", "Серпуховская", "Храм новомучеников и исповедников Российских на Серпуховской улице, приписной к храму Вознесения Господня за Серпуховскими воротами", "www.voznesenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 290L, "Малый Толмачёвский переулок, дом 9", "Калужско-Рижская линия", "Третьяковская", "Храм Святителя Николая Мирликийского в Толмачах", "vtolmachah.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 289L, "3-й Голутвинский переулок, дом 14", "Серпуховско-Тимирязевская линия", "Полянка", "Храм Святителя Николая Мирликийского в Голутвине", "st-nicholas.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 288L, "Берсеневская набережная, дом 18-22", "Сокольническая линия", "Кропоткинская", "Храм Святителя Николая Мирликийского (Живоначальной Троицы) в Верхних Садовниках на Берсеневке", "bersenevka.info" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 287L, "Вишняковский переулок, дом 15", "Кольцевая линия", "Павелецкая", "Храм Святителя Николая Мирликийского в Кузнецкой Слободе", "www.nikvkuz.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 286L, "2-й Раушский переулок, дом 1-3/26, строение 8", "Замоскворецкая линия", "Новокузнецкая", "Храм Святителя Николая Мирликийского (Спаса Преображения) в Заяицком", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 285L, "Средний Овчинниковский переулок, дом 7", "Замоскворецкая линия", "Новокузнецкая", "Храм Архангела Михаила (Покрова Пресвятой Богородицы) в Овчинниках", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 284L, "4-й Добрынинский переулок дом 1/9, строение 52", "Серпуховско-Тимирязевская линия", "Серпуховская", "Храм иконы Божией Матери «Милующая» при Морозовской Детской клинической больнице", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 283L, "улица Пятницкая, дом 26, строение 1", "Калужско-Рижская линия", "Третьяковская", "Храм священномученика Климента папы Римского в Замоскворечье", "www.klement.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 282L, "улица Житная, дом 18", "Кольцевая линия", "Октябрьская", "Храм Казанской иконы Божией Матери на Калужской площади", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 281L, "улица Академика Павлова, дом 15", "Арбатско-Покровская линия", "Молодёжная", "Храм Казанской иконы Божией Матери при Детском доме для детей-инвалидов № 15 (домовый)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 280L, "Черниговский переулок, дом 3", "Калужско-Рижская линия", "Третьяковская", "Храм Иоанна Предтечи Усекновения Главы под Бором с отдельно стоящей колокольней, Черниговское подворье", "www.podborom.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 279L, "улица Большая Якиманка, дом 46", "Кольцевая линия", "Октябрьская", "Храм Иоанна Воина на Якиманке", "www.hram-ioanna-voina.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 293L, "Ленинский проспект, дом 117", "Сокольническая линия", "Юго-Западная", "Храм Покрова Пресвятой Богородицы при Российской детской клинической больнице города Москвы (домовый)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 310L, "Рябиновая улица, 24А", "Арбатско-Покровская линия", "Кунцевская", "Храм Святителя Николая Мирликийского в Троекурове", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 311L, "Нежинская улица, дом 2", "Арбатско-Покровская линия", "Славянский бульвар", "Храм Святителя Николая Мирликийского при Интернате ветеранов труда № 29 (домовый), приписной к храму Архангела Михаила в Тропарево", "troparevo-hram.org" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 312L, "Мичуринский проспект, дом 8/29", "Сокольническая линия", "Университет", "Храм Святой Равноапостольной Великой княгини Ольги при Паломническом центре Московского Патриархата, гостиница «Университетская» (домовый)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 343L, "посёлок дома отдыха \"Плесково\", дом 1", "Калужско-Рижская линия", "Тёплый стан", "Храм преподобного Сергия Радонежского при Православной школе-пансионе «Плесково» (домовый)", "www.pleskovo.ru/index.php?name=temple" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 342L, "деревня Ворсино, дом 3", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Феодоровской иконы Божией Матери, село Ворсино", "vorsyno.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 341L, "посёлок Щапово, дом 52А", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Успения Пресвятой Богородицы в Александрове", "shapovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 340L, "село Остафьево, Троицкая улица, дом 4", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Живоначальной Троицы в Остафьево", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 339L, "село Ознобишино, дом 30А", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Живоначальной Троицы в Ознобишино", "oznobishino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 338L, "деревня Васюнино, дом 88", "Калужско-Рижская линия", "Тёплый стан", "Храм Живоначальной Троицы в Васюнине", "nikol-blag.ru/blagochinie/khramy/60-troitskij-khram-s-vasyunino.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 337L, "село Вороново, дом 110", "Калужско-Рижская линия", "Тёплый стан", "Храм Всемилостивого Спаса в селе Вороново", "voronovo-hram.narod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 336L, "деревня Тарасово, дом 5", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Преподобного Сергия Радонежского в Тарасове", "nikol-blag.ru/blagochinie/khramy/57-sergievskij-khram-der-tarasovo.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 335L, "деревня Варварино, дом 1Б", "Калужско-Рижская линия", "Тёплый стан", "Храм Рождества Христова в Варварине", "nikol-blag.ru/blagochinie/khramy/59-khristorozhdestvenskij-khram-s-varvarino.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 334L, "деревня Рождественно, дом 32", "Арбатско-Покровская линия", "Молодёжная", "Храм Рождества Христова в Рождественне", "nikol-blag.ru/blagochinie/khramy/61-khristorozhdestvenskij-khram-der-rozhdestvenno.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 333L, "село Покровское, дом 25", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Покрова Пресвятой Богородицы в селе Покровском", "pokrovpp.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 332L, "деревня Ерино, Северная улица, дом 11А", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Покрова Пресвятой Богородицы в деревне Ерино", "erinohram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 331L, "посёлок Шишкин Лес, дом 43", "Калужско-Рижская линия", "Тёплый стан", "Храм Новомучеников Подольских в Шишкином Лесу", "nikol-blag.ru/blagochinie/khramy/73-khram-novomuchenikov-podolskikh-s-shishkin-les.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 330L, "улица Алёшкинская Долина, дом 64, строение 2", "Калужско-Рижская линия", "Тёплый стан", "Храм Святителя Николая Мирликийского в Никольском", "nikol-blag.ru/blagochinie/khramy/67-nikolskij-khram-s-nikolskoe.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 329L, "село Кленово, Центральная улица, дом 8", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Святителя Николая Мирликийского в селе Клёново", "hramvklenovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 328L, "село Былово, дом Б/Н, строение 1А", "Калужско-Рижская линия", "Тёплый стан", "Храм Михаила Архангела в Былово", "hram-bylovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 327L, "деревня Товарищево, дом 21А", "Серпуховско-Тимирязевская линия", "Бульвар Дмитрия Донского", "Храм Казанской иконы Божией Матери, деревня Товарищево", "tovarischevo.ucoz.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 313L, "Мичуринский проспект, дом 74", "Сокольническая линия", "Юго-Западная", "Храм Пантелеимона великомученика и целителя при Детской психоневрологической больницеце № 18", "www.hram-sdr.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 314L, "Мичуринский проспект, дом 6", "Сокольническая линия", "Воробьёвы горы", "Храм Пантелеимона великомученика и целителя при Объединенной больнице с поликлиникой Медицинского Центра Управления Делами Президента Российской Федерации, приписной к Свято-Троицкой Сергиевой Лавре", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 315L, "посёлок ОПХ Толстопальцево, улица Осипенко, дом 2", "Сокольническая линия", "Юго-Западная", "Храм Покрова Пресвятой Богородицы в Толстопальцеве", "www.christos-anesty.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 316L, "проспект Вернадского, дом 90", "Сокольническая линия", "Юго-Западная", "Храм Происхождения Честных Древ Животворящего Креста Господня в Тропарево (крестильный) при храме Архангела Михаила в Тропарево", "troparevo-hram.org" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 317L, "Староволынская улица, дом 10", "Арбатско-Покровская линия", "Славянский бульвар", "Храм Спаса Нерукотворного Образа в Волынском при Медицинском Центре Управления Делами Президента Российской Федерации, приписной к Свято-Троицкой Сергиеворй Лавре", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 318L, "7-я улица Лазенки, дом 42", "Сокольническая линия", "Юго-Западная", "Храм Спаса Преображения в Переделкино", "spas-pr.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 345L, "дачный посёлок Кокошкино, улица Труда, дом 6", "Сокольническая линия", "Юго-Западная", "Храм Михаила Архангела в Кокошкине", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 319L, "Мосфильмовская улица, дом 18А", "Арбатско-Покровская линия", "Парк Победы", "Храм Живоначальной Троицы в Троицком-Голенищеве", "kadilo.info" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 321L, "село Сальково, дом 7А", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Благовещения Пресвятой Богородицы, село Сальково", "www.salkovo.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 322L, "село Богоявление", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Богоявления Господня в Богоявлении", "nikol-blag.ru/blagochinie/khramy/56-bogoyavlenskij-khram-s-bogoyavlenie.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 323L, "деревня Сатино-Русское", "Серпуховско-Тимирязевская линия", "Аннино", "Храм Вознесения Господня в Сатино-Русском", "www.voznesenie.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 324L, "деревня Чернецкое", "Серпуховско-Тимирязевская линия", "Аннино", "Часовня Иверской иконы Божией Матери в Чернецком, приписная к храму Святителя Николая Мирликийского в селе Клёново", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 325L, "город Щербинка, Железнодорожная улица, дом 15", "Серпуховско-Тимирязевская линия", "Бульвар Дмитрия Донского", "Храм Святой Елизаветы в городе Щербинка", "stelizabeth.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 326L, "село Красное, Парковая улица, домовладение 10, строение 1", "Калужско-Рижская линия", "Тёплый стан", "Храм Иоанна Богослова в селе Красном", "www.ibogoslov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 320L, "улица Косыгина, дом 30", "Сокольническая линия", "Воробьёвы горы", "Храм Троицы Живоначальной на Воробьевых горах", "www.hram-troicy.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 278L, "улица Большая Полянка, дом 20, строение 2", "Серпуховско-Тимирязевская линия", "Полянка", "Церковь Иверской иконы Божией Матери при бывшей Иверской общине сестер милосердия (ныне детская больница № 20)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 414L, "улица Сталеваров, дом 6, строение 1", "Калининская линия", "Новогиреево", "Храм Василия Великого свт. в Ивановском (крестильный), при храме Рождества Иоанна Предтечи в Ивановском", "i-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 416L, "Суздальская улица, владение 8Б", "Калининская линия", "Новогиреево", "Храм всех святых в земле Российской просиявших в Новокосино", "www.hramnovokosino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 515L, "Гагаринский переулок, дом 20, строение 2", "Арбатско-Покровская линия", "Смоленская", "Храм Власия сщмч. (Спаса Преображения) в Старой Конюшенной слободе", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 514L, "улица Лужники, дом 24, строение 17", "Сокольническая линия", "Воробьёвы горы", "Часовня Владимира св. равноап. вел. кн. в Лужниках", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 513L, "Поварская улица, дом 5, строение 1", "Филёвская линия", "Арбатская", "Храм Введения во храм Пресвятой Богородицы (прп. Симеона Столпника) на Поварской", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 512L, "Арбатская площадь, дом 4", "Филёвская линия", "Арбатская", "Храм Бориса и Глеба блгг. кнн. на Арбатской площади, Патриаршее подворье, приписной к храму Большое Вознесение (Вознесения Господня) у Никитских ворот", "bolshoevoznesenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 511L, "Большая Никитская улица, дом 36, строение 1", "Филёвская линия", "Арбатская", "Храм «Большое Вознесение» у Никитских ворот", "bolshoevoznesenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 510L, "Колымажный переулок, дом 8/4, строение 1", "Сокольническая линия", "Кропоткинская", "Храм Cвященномученика Антипы на Колымажном дворе", "www.hramantipa.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 509L, "улица Сергея Макеева, дом 5, строение 1", "Таганско-Краснопресненская линия", "Улица 1905 года", "Храм Андрея Первозванного ап. на Ваганьковском кладбище, приписной к храму Воскресения Словущего на Ваганьковском кладбище", "храмваганьково.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 508L, "Большая Садовая улица, дом 14, строение 6", "Замоскворецкая линия", "Маяковская", "Храм Александра Невского блв. кн. при бывшем Комиссаровском училище (домовый), Патриаршее подворье, приписной к храму Вознесения Господня («Большое Вознесение») в Сторожах, у Никитских ворот", "bolshoevoznesenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 507L, "Таллинская улица, дом 12, корпус 4", "Арбатско-Покровская линия", "Строгино", "Храм Феодора Ушакова св. прав. воина при ГОУ Кадетской школе № 1700 «Московский объединенный морской корпус героев Севастополя» (домовый), приписной к храму новомучеников и исповедников Российских в Строгино", "uspenie.strogino.ru/frame/hrami/hram_svyatogo_pravednogo_voyna_feodora_ushakova/hram_svyatogo_pravednogo_voyna_feodora_ushakova.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 506L, "Одинцовская улица, дом 24", "Таганско-Краснопресненская линия", "Щукинская", "Храм Успения Пресвятой Богородицы в Троице-Лыково, подворье Покровского ставропигиального женского монастыря", "tl.strogino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 505L, "Карамышевская набережная, дом 15", "Таганско-Краснопресненская линия", "Октябрьское поле", "Храм Троицы Живоначальной в Хорошове", "www.troitsa-horoshevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 504L, "Одинцовская улица, дом 24", "Таганско-Краснопресненская линия", "Щукинская", "Храм Троицы Живоначальной в Троице-Лыково, приписной к храму Успения Пресвятой Богородицы в Троице-Лыково (подворье Покровского ставропигиального женского монастыря г. Москвы)", "tl.strogino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 503L, "Волоколамское шоссе, дом 128", "Арбатско-Покровская линия", "Волоколамская", "Храм Спаса Преображения в Тушино", "spas-tushino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 502L, "улица Маршала Рыбалко, дом 8, корпус 2", "Таганско-Краснопресненская линия", "Октябрьское поле", "Храм иконы Божией Матери «Скоропослушница» на Ходынском поле", "skor-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 516L, "1-й переулок Тружеников, дом 8, строение 1", "Филёвская линия", "Киевская", "Храм Воздвижения Креста Господня в Чистом (Пометном) Вражке", "www.hramkresta.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 501L, "Щукинская улица, дом 1", "Таганско-Краснопресненская линия", "Щукинская", "Храм Серафима Саровского прп. при Институте трансплантологии и искусственных органов ММА им. И.М. Сеченова (домовый), Патриаршее подворье", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 499L, "Волоколамское шоссе, дом 84", "Таганско-Краснопресненская линия", "Щукинская", "Храм Пантелеимона вмч. и целит. при Центральной клинической больнице №1 ОАО РЖД", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 498L, "1-й Пехотный переулок, дом 9/27", "Таганско-Краснопресненская линия", "Щукинская", "Храм Пантелеимона вмч. цел. при Центральном военном клиническом госпитале ФСБ РФ, приписной к храму Софии Премудрости Божией Патриаршего подворья у Пушечного двора, что на Лубянке", "uspenie.strogino.ru/frame/hrami/hram_vmch_i_cel_panteleimona_pri_cetralnom_voennom_gospitale_fsb_rf/hram_vmch_i_cel_panteleimona_pri_cetralnom_voennom_gospitale_fsb_rf.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 497L, "Строгинский бульвар, дом 14", "Арбатско-Покровская линия", "Строгино", "Храм новомучеников и исповедников Российских в Строгине", "nvmr.strogino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 496L, "улица Твардовского, дом 2", "Арбатско-Покровская линия", "Строгино", "Храм Димитрия Донского св. блг. кн. на базе ОМОН в Строгине, приписной к храму Успения Пресвятой Богородицы в Троице-Лыково, подворье Покровского ставропигиального женского монастыря г. Москвы", "tl.strogino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 495L, "Живописная улица, дом 28", "Таганско-Краснопресненская линия", "Щукинская", "Храм Георгия Победоносца вмч. на территории УМ Центра МЧС, приписной к храму Успения Пресвятой Богородицы в Троице-Лыково, подворье Покровского ставропигиального женского монастыря г. Москвы", "uspenie.strogino.ru/frame/hrami/hram_chasovnya_georgiya_pobedonosca/hram_chasovnya_georgiya_pobedonosca.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 494L, "Малахитовая улица, дом 16", "Калужско-Рижская линия", "ВДНХ", "Храм иконы Божией Матери «Целительница» при МЧС-33 «Моспочтамт» (домовый), приписной к подворью Спасо-Преображенского Валаамского ставропигиального мужского монастыря", "www.valaam-msk.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 493L, "улица Вильгельма Пика, дом 4, корпус 3", "Калужско-Рижская линия", "Ботанический сад", "Храм Феодоровской иконы Божией Матери при РГСУ, приписной к храму Ризоположения Пресвятой Богородицы в Леоново", "teo-rgsu.ru/hram/hram.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 492L, "1-й Рижский переулок, дом 2, строение 7", "Калужско-Рижская линия", "Алексеевская", "Храм Троицы Живоначальной при бывшем приюте Бахрушиных", "www.sv-troitsa.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 491L, "Дроболитейный переулок, дом 5, строение 1", "Калужско-Рижская линия", "Рижская", "Храм Троицы Живоначальной на Пятницком кладбище", "troitse-paraskevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 490L, "1-я Останкинская улица, дом 7, строение 2", "Калужско-Рижская линия", "ВДНХ", "Храм Троицы Живоначальной в Останкино, Патриаршее подворье", "www.trinitychurch.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 489L, "проспект Мира, дом 130", "Калужско-Рижская линия", "ВДНХ", "Храм Тихвинской иконы Божией Матери в Алексеевском", "tihvinskiy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 488L, "Дроболитейный переулок, дом 5, строение 2", "Калужско-Рижская линия", "Рижская", "Храм Симеона сщмч., еп. Персидского на Пятницком кладбище", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 487L, "улица Бутырская, дом 56", "Серпуховско-Тимирязевская линия", "Дмитровская", "Храм Рождества Пресвятой Богородицы в Бутырской слободе", "butyr-sloboda.ortox.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 486L, "улица Докукина, дом 19", "Калужско-Рижская линия", "Ботанический сад", "Храм Ризоположения (Положения Ризы Пресвятой Богородицы во Влахерне) в Леоново", "www.hram-leonovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 500L, "Волоколамское шоссе, дом 52, строение 1", "Замоскворецкая линия", "Сокол", "Храм Покрова Пресвятой Богородицы в Покровском-Стрешневе, Патриаршее подворье", "стрешнево.рпу.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 517L, "Большая Никитская улица, дом 18", "Филёвская линия", "Арбатская", "Храм Вознесения Господня («Малое Вознесение») на Большой Никитской", "www.mvoznesenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 518L, "улица Сергея Макеева, дом 5, строение 1", "Таганско-Краснопресненская линия", "Улица 1905 года", "Храм Воскресения Словущего на Ваганьковском кладбище", "храмваганьково.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 519L, "Брюсов переулок, дом 15/2", "Таганско-Краснопресненская линия", "Пушкинская", "Храм Воскресения Словущего на Успенском Вражке", "vslov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 550L, "Шмитовский проезд, дом 29, строение 10", "Филёвская линия", "Выставочная", "Храм Филарета Милостивого прав. при детской городской клинической больнице им. Г.Н. Сперанского, приписной к храму Рождества Иоанна Предтечи на Пресне", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 549L, "Большой Власьевский переулок, дом 2/2", "Арбатско-Покровская линия", "Смоленская", "Храм Успения Пресвятой Богородицы на Могильцах", "yspenie-arbat-mogil.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 548L, "Кропоткинский переулок, дом 23", "Сокольническая линия", "Парк культуры", "Храм иконы Божией Матери «Умиления» при Государственном научном центре социальной и судебной психиатрии им. В. П. Сербского (домовый), приписной к храму свт. Николая Мирликийского в Хамовниках", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 547L, "улица Доватора, дом 10", "Сокольническая линия", "Спортивная", "Храм Троицы Живоначальной при Хосписе №1", "www.hospice.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 546L, "Большая Никитская улица, дом 1", "Сокольническая линия", "Библиотека имени Ленина", "Храм святой мученицы Татианы при Московском государственном университете имени М.В. Ломоносова (домовый), Патриаршее подворье", "www.st-tatiana.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 545L, "Садовая-Кудринская улица, дом 15, строение 9", "Таганско-Краснопресненская линия", "Баррикадная", "Храм Софии и Татианы свв.мцц. при Детской клинической больнице им. Н.Ф.Филатова (бывшей Софийской)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 544L, "Спасопесковский переулок, дом 4А", "Арбатско-Покровская линия", "Смоленская", "Храм Спаса Преображения на Песках", "spas-na-peskah.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 543L, "Большая Никитская улица, дом 29", "Филёвская линия", "Арбатская", "Храм прп. Феодора Студита (Смоленской иконы Божией Матери) у Никитских ворот", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 542L, "Зубовская улица, дом 3", "Сокольническая линия", "Парк культуры", "Храм Сергия Радонежского прп. - при Счетной Палате Российской Федерации (домовый), приписной к храму сщмч. Антипы на Колымажном дворе", "www.hramantipa.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 541L, "Краснопресненская набережная, дом 14", "Филёвская линия", "Выставочная", "Храм Серафима Саровского прп. при Выставочном центре ЗАО «Экспоцентр», приписной к домовому храму мц. Татианы при МГУ им. М.В. Ломоносова", "www.st-serafim.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 540L, "улица Достоевского, дом 4, корпус1", "Люблинско-Дмитровская линия", "Достоевская", "Храм Петра и Павла свв. апп. при НИИ фтизиопульмонологии Первого МГМУ им. И.М.Сеченова (домовый), приписан к храму Михаила Арх. при Клиниках, на Девичьем поле", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 539L, "Абрикосовский переулок, дом 2/6, строение В", "Сокольническая линия", "Спортивная", "Храм Пантелеимона великомученика и целителя при Научном центре хирургии им. Б.В.Петровского РАМН (домовый), приписан к храму Воздвижения Креста Господня в Чистом (Пометном) вражке", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 538L, "1-й Смоленский переулок, дом 20, строение 1", "Филёвская линия", "Смоленская", "Храм Святителя Николая Мирликийского на Щепах", "nikolashepi.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 537L, "улица Льва Толстого, дом 2", "Сокольническая линия", "Парк культуры", "Храм Святителя Николая Мирликийского в Хамовниках", "nikolakhamovniki.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 536L, "Староваганьковский переулок, дом 14", "Серпуховско-Тимирязевская линия", "Боровицкая", "Храм Святителя Николая Мирликийского в Старом Ваганькове (при бывшем Румянцевском музее - ныне Российской государственной библиотеке)", "www.s-nikola.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 535L, "улица Знаменка, дом 1", "Серпуховско-Тимирязевская линия", "Боровицкая", "Часовня Николая св. на Знаменке приписана к храму свт. Николая в Старом Ваганькове", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 534L, "улица Пречистенка, дом 22", "Сокольническая линия", "Кропоткинская", "Храм иконы Божией Матери «Неопалимая Купина» на Пречистенке, при Управлении противопожарной службы ГУВД г. Москвы приписной к храму Воскресения Словущего на Арбате", "podvorie.orthodoxy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 520L, "Филипповский переулок, дом 20", "Филёвская линия", "Арбатская", "Храм Воскресения Словущего (ап. Филиппа) на Арбате, Подворье Иерусалимской Православной Церкви", "podvorie.orthodoxy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 521L, "Филипповский переулок, дом 3", "Сокольническая линия", "Кропоткинская", "Храм Воскресения Словущего (свтт. Афанасия и Кирилла) на Сивцевом вражке", "afanasiakirilla.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 522L, "Большая Грузинская улица, дом 13", "Кольцевая линия", "Краснопресненская", "Храм Георгия Победоносца вмч. в Грузинах, Патриаршее подворье", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 523L, "Большой Девятинский переулок, дом 15", "Филёвская линия", "Смоленская", "Храм Святых Девяти Мучеников Кизических", "www.kizik.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 524L, "Пречистенская набережная, дом 37", "Сокольническая линия", "Кропоткинская", "Храм Державной иконы Божией Матери на Пречистенской набережной, приписной к кафедральному соборному Храму Христа Спасителя", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 525L, "Большая Пироговская улица, дом 6", "Сокольническая линия", "Спортивная", "Храм Димитрия Прилуцкого прп. при Клиниках, на Девичьем поле", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 485L, "улица Академика Королёва, дом 12", "Калужско-Рижская линия", "ВДНХ", "Храм Порфирия Ефесского св. мч. при Телецентре в Останкино (домовый), приписной к храму Живоначальной Троицы в Останкино", "www.trinitychurch.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 526L, "Нововаганьковский переулок, дом 9, строение 1", "Кольцевая линия", "Краснопресненская", "Храм святителя Николая Мирликийского на Трех Горах", "храмтригоры.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 528L, "2-й Обыденский переулок, дом 6", "Сокольническая линия", "Кропоткинская", "Храм Илии пророка Божия в Обыденском переулке", "www.hram-ostozhenka.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 529L, "переулок Хользунова, дом 18", "Сокольническая линия", "Фрунзенская", "Часовня Илии пророка при штабе Дальней авиации ВВС РФ (домовый), приписан к Синодальному отделу Московского Патриархата по взаимодействию с Вооруженными силами и правоохранительными органами", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 530L, "Богословский переулок, дом 4", "Замоскворецкая линия", "Тверская", "Храм святого апостола и евангелиста Иоанна Богослова на Бронной", "bogoslovnabronnoy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 531L, "Малый Предтеченский переулок, дом 2", "Кольцевая линия", "Краснопресненская", "Храм Рождества Иоанна Предтечи на Пресне", "www.ioannp.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 532L, "улица Остоженка, дом 38", "Сокольническая линия", "Парк культуры", "Храм Марии Магдалины св. равноап при Московском Государственном Лингвистическом Университете (домовый)", "centralnoe-blagochinie.ru/temples/detail.php?ID=338" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 533L, "улица Еланского, дом 2А", "Сокольническая линия", "Фрунзенская", "Храм Михаила Арх. при Клиниках, на Девичьем поле", "www.hramnadevichiem.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 527L, "Романов переулок, дом 2, строение 8", "Сокольническая линия", "Библиотека имени Ленина", "Храм «Знамение» иконы Божией Матери на Шереметевом дворе, Патриаршее подворье", "www.hram-znameniya.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 415L, "улица Юности, дом 2, строение 5", "Таганско-Краснопресненская линия", "Рязанский проспект", "Храм Происхождения Честных Древ Животворящего Креста Господня (Всемилостивого Спаса) в Кускове", "kuskovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 484L, "улица Достоевского, дом 4, строение 3", "Серпуховско-Тимирязевская линия", "Менделеевская", "Храм Петра и Павла апп. при бывшей Мариинской больнице (НИИ фтизиопульманологии ММА имени И.М. Сеченова), приписной к храму Арх. Михаила на Девичьем поле", "www.hramnadevichiem.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 482L, "Шереметьевская улица, дом 33", "Люблинско-Дмитровская линия", "Марьина роща", "Храм иконы Божией Матери «Нечаянная Радость» в Марьиной Роще", "www.n-radost.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 446L, "Заповедная улица, дом 52А", "Калужско-Рижская линия", "Свиблово", "Храм Покрова Пресвятой Богородицы в Медведкове", "pokrovchram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 445L, "Каргопольская улица, дом 9", "Серпуховско-Тимирязевская линия", "Отрадное", "Храм Святителя Николая Мирликийского в Отрадном, приписной к храму Неопалимой Купины иконы Божией Матери в Отрадном", "www.rpb-v.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 444L, "улица Хачатуряна, дом 6, корпус 2", "Серпуховско-Тимирязевская линия", "Владыкино", "Храм Святителя Николая Мирликийского в Отрадном, приписной к Синодальному миссионерскому отделу МП", "www.portal-missia.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 443L, "Ярославское шоссе, дом 61, корпус 1", "Калужско-Рижская линия", "ВДНХ", "Храм Иоакима и Анны свв. правв. в Бабушкине, крестильный при храме свв. мчч. Адриана и Наталии в Бабушкине", "adrian-i-natalia.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 442L, "улица Хачатуряна, дом 20/2", "Серпуховско-Тимирязевская линия", "Отрадное", "Храм Илии пророка Божия в Отрадном, приписной к храму Покрова Пресвятой Богородицы в Медведкове", "pokrovchram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 441L, "улица Лескова, дом 11Б", "Серпуховско-Тимирязевская линия", "Алтуфьево", "Храм иконы Божией Матери «Живоносный Источник» в Бибиреве", "hram-ziv.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 440L, "Алтуфьевское шоссе, дом 13", "Серпуховско-Тимирязевская линия", "Владыкино", "Храм Елисаветы прмц., великой княгини при ЦВНП ГУВД г. Москвы (домовый), приписной к Свято-Данилову мужскому монастырю", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 439L, "Дмитровское шоссе, дом 124А", "Серпуховско-Тимирязевская линия", "Алтуфьево", "Храм-часовня Гавриила Архангела на Старомарковском кладбище", "www.turikovo.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 438L, "Алтуфьевское шоссе, дом 147", "Серпуховско-Тимирязевская линия", "Алтуфьево", "Храм Воздвижения Креста Господня в Алтуфьеве", "www.hramaltuf.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 437L, "Дмитровское шоссе, дом 170", "Серпуховско-Тимирязевская линия", "Алтуфьево", "Храм Владимирской иконы Божией Матери в Виноградово", "www.hram-vinogradovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 436L, "Берингов проезд, дом 1", "Калужско-Рижская линия", "Свиблово", "Храм Владимира сщмч., митрополита Киевского Галицкого в Свиблове, приписной к храму прп. Серафима Саровского в Раеве", "www.raevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 435L, "Алтуфьевское шоссе, дом 147", "Серпуховско-Тимирязевская линия", "Алтуфьево", "Храм Веры, Надежды, Любови и матери их Софии свв. мцц. (крестильный) в Алтуфьеве, при храме Воздвижения Креста Господня в Алтуфьеве", "www.hramaltuf.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 434L, "проезд Шокальского, дом 48", "Калужско-Рижская линия", "Медведково", "Храм Введения во храм Пресвятой Богородицы в Раеве, крестильный при храме преподобного Серафима Саровского в Раеве", "www.raevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 433L, "Енисейская улица, дом 14", "Калужско-Рижская линия", "Бабушкинская", "Храм Благовещения Пресвятой Богородицы в Раеве, приписной к храму преподобного Серафима Саровского в Раеве", "www.raevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 447L, "Алтуфьевское шоссе, дом 4, строение 1", "Серпуховско-Тимирязевская линия", "Владыкино", "Храм Рождества Пресвятой Богородицы во Владыкине", "www.rpb-v.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 432L, "проезд Шокальского, дом 48", "Калужско-Рижская линия", "Медведково", "Храм Алексия свт., митрополита Московского в Раеве. Крестильный храм при храме преподобного Серафима Саровского в Раеве", "www.raevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 430L, "Большая Косинская улица, дом 29", "Таганско-Краснопресненская линия", "Выхино", "Храм Успения Пресвятой Богородицы в Косино", "www.kosino-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 429L, "улица Юности, дом 17", "Таганско-Краснопресненская линия", "Рязанский проспект", "Храм Успения Пресвятой Богородицы в Вешняках", "www.hram-veshnjaki.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 428L, "Большая Косинская улица, дом 29", "Таганско-Краснопресненская линия", "Выхино", "Храм Тихона свт., Патриарха Всероссийского в Косино (крестильный), при храме Успения Пресвятой Богородицы в Косино", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 427L, "Свободный проспект, дом 4А, строение 1", "Калининская линия", "Новогиреево", "Храм Спаса Нерукотворного Образа в Перово (Гиреево)", "spas-perovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 426L, "3-я Парковая улица, дом 34, строение 1", "Арбатско-Покровская линия", "Первомайская", "Храм Серафима Саровского прп. в Измайлове при Лицее духовной культуры (домовый), приписной к храму прп. Сергия Радонежского Патриаршего подворья в Крапивниках", "pravoslavie-licey.narod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 425L, "Измайловский проезд, дом 28", "Сокольническая линия", "Черкизовская", "Храм Рождества Христова в Измайлове", "hramrh-izmaylovo.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 424L, "городок имени Баумана, дом 1, строение 1", "Арбатско-Покровская линия", "Партизанская", "Храм Покрова Пресвятой Богородицы в Измайлове", "www.hrampokrova.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 423L, "Вешняковская улица, дом 23", "Таганско-Краснопресненская линия", "Выхино", "Храм Пантелеимона великомученика и целителя при Городской клинической больнице № 15, приписной к храму Успения Пресвятой Богородицы в Косино", "www.kosino-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 422L, "Измайловское шоссе, дом 73Ж, строение 2", "Арбатско-Покровская линия", "Партизанская", "Храм Святителя Николая Мирликийского в Измайлове (на территории ООО «Вернисаж»)", "www.svtnikola.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 421L, "Нижняя Первомайская улица, дом 70, строение 15", "Арбатско-Покровская линия", "Первомайская", "Храм Святителя Николая Мирликийского при НМХЦ имени Н.И. Пирогова, приписной к храму Рождества Христова в Измайлове", "hramrh-izmaylovo.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 420L, "Большая Косинская улица, дом 29", "Таганско-Краснопресненская линия", "Выхино", "Храм Святителя Николая Мирликийского в Косино", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 419L, "шоссе Энтузиастов, дом 88", "Калининская линия", "Перово", "Храм Матроны Московской блж. при Доме ветеранов сцены им. А. Яблочкиной (домовый) Патриаршее подворье", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 418L, "9-я Парковая улица, дом 4А", "Арбатско-Покровская линия", "Первомайская", "Храм Казанской (Песчанской) иконы Божией Матери в Измайлове", "www.peschanskiy-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 417L, "улица Лазо, дом 7, строение 1", "Калининская линия", "Перово", "Храм иконы Божией Матери «Знамение» в Перово, приписной к храму Иоанна Предтечи в Ивановском", "i-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 431L, "Ярославское шоссе, дом 61, корпус 1", "Калужско-Рижская линия", "ВДНХ", "Храм Адриана и Наталии в Бабушкине", "adrian-i-natalia.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 448L, "Костромская, дом 7", "Серпуховско-Тимирязевская линия", "Бибирево", "Храм Преподобного Сергия Радонежского в Бибиреве", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 449L, "Лазоревый проезд, дом 15", "Калужско-Рижская линия", "Ботанический сад", "Храм Троицы Живоначальной в Свиблово", "s-blag.ru/patriarshie-podvorya/sviblovo/" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 450L, "Алтуфьевское шоссе, дом 13, корпус 4, строение 4", "Серпуховско-Тимирязевская линия", "Владыкино", "Храм «Умягчение злых сердец» иконы Божией Матери при социальном приюте для детей и подростков «Алтуфьево» (домовый), приписной к храму Воздвижения Креста Господня в Алтуфьеве", "www.hramaltuf.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 481L, "Будайская улица, дом 2", "Калужско-Рижская линия", "ВДНХ", "Храм иконы Божией Матери «Всецарица» при ЦКБ № 2 имени Семашко, приписной к подворью Спасо-Преображенского Валаамского ставропигиального мужского монастыря", "www.valaam-msk.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 480L, "улица Сущёвский Вал, дом 21", "Серпуховско-Тимирязевская линия", "Савёловская", "Храм Веры, Надежды, Любови и Софии свв. мцц. на Миусском кладбище", "st-vera.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 479L, "проспект Мира, дом 119, строение 500", "Калужско-Рижская линия", "ВДНХ", "Храм Василия Великого свт. при Всероссийском Выставочном Центре, приписной к храму Тихвинской иконы Божией Матери в Алексеевском", "tihvinskiy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 478L, "улица Гиляровского, дом 35", "Калужско-Рижская линия", "Проспект Мира", "Храм свт. Филиппа, митрополита Московского, в Мещанской слободе, Сибирское Подворье", "st-philipp-church.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 477L, "улица Сретенка, дом 3/27", "Люблинско-Дмитровская линия", "Сретенский бульвар", "Храм Успения Пресвятой Богородицы в Печатниках", "www.usp-pech.orthodoxy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 476L, "Большая Сухаревская площадь, дом 3", "Калужско-Рижская линия", "Сухаревская", "Храм Троицы Живоначальной при Шереметевом странноприимном доме (ныне НИИ скорой помощи им. Н.В.Склифосовского)", "sheremetev-st-trinity.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 475L, "2-й Троицкий переулок, дом 8/10", "Серпуховско-Тимирязевская линия", "Цветной бульвар", "Храм Троицы Живоначальной - в Троицкой слободе, Подворье Троице-Сергиевой Лавры", "blagoslovenie.su" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 474L, "улица Сретенка, дом 27, строение 3", "Калужско-Рижская линия", "Сухаревская", "Храм Троицы Живоначальной в Листах", "www.hram-troicy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 473L, "Трифоновская улица, дом 38", "Калужско-Рижская линия", "Рижская", "Храм мученика Трифона, что в Напрудном, приписной к храму иконы Божией Матери «Знамение» в Переяславской слободе", "www.triphon.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 472L, "Скрябинский переулок, дом 12/14", "Калужско-Рижская линия", "Проспект Мира", "Храм Трех святителей при Классической гимназии Греко-Латинского кабинета Ю.А. Шичалина (домовый)", "www.mgl.ru/church-of-three-saints.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 471L, "Пушечная улица, дом 15", "Таганско-Краснопресненская линия", "Кузнецкий мост", "Храм Софии Премудрости Божией у Пушечного двора, что на Лубянке, Патриаршее подворье", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 470L, "проспект Мира, дом 22", "Калужско-Рижская линия", "Проспект Мира", "Церковь Собора дивеевских сятых, Патриаршее подворье. Представительство Свято-Троицкого Серафимо-Дивеевского м-ря Нижегородско-Арзамасской епархии в г. Москве", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 469L, "2-й Троицкий переулок, дом 6А, строение 9", "Серпуховско-Тимирязевская линия", "Цветной бульвар", "Храм преподобного Сергия Радонежского в бывшем Троицком подворье (бывшии Митрополичьи покои), приписной к храму Троицы Живоначальной в Троицкой слободе, Подворью Свято-Троицкой Сергиевой лавры", "sretsorok.orthodoxy.ru/htm/hrams/_28.htm" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 468L, "улица Большая Лубянка, дом 20", "Таганско-Краснопресненская линия", "Кузнецкий мост", "Храм Покрова Пресвятой Богородицы при ФСБ России (домовый), приписной к храму Софии Премудрости Божией Патриаршего подворья у Пушечного двора, что на Лубянке", "sretsorok.orthodoxy.ru/htm/hrams/_1_.htm" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 467L, "улица Рождественка, дом 15/8", "Таганско-Краснопресненская линия", "Кузнецкий мост", "Храм Святителя Николая Мирликийского (Благовещения Пресвятой Богородицы) в Звонарях. Подворье Пюхтицкого (Куремяэского) Успенского женского монастыря", "nikolazvonary.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 466L, "проспект Мира, дом 13", "Калужско-Рижская линия", "Проспект Мира", "Храм Иверской иконы Божией Матери при Восточно-Европейской нефтяной компании (домовый), приписной к Донскому ставропигиальному мужскому монастырю", "www.donskoi.org" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 465L, "2-й Крестовский переулок, дом 17", "Калужско-Рижская линия", "Рижская", "Храм иконы Божией Матери «Знамение» в Переяславской слободе", "www.znamene.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 451L, "Дмитровское шоссе, дом 120, корпус 1, строение 1", "Серпуховско-Тимирязевская линия", "Алтуфьево", "Храм Успения Пресвятой Богородицы в Архангельском-Тюрикове", "turikovo.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 452L, "Широкая улица, дом 14", "Калужско-Рижская линия", "Медведково", "Храм иконы Божией Матери «Утоли моя печали» в Медведкове, приписной к храму Покрова Пресвятой Богородицы в Медведкове", "pokrovchram.ru/hram-chasovnya_v_chest_ikony_bozhey" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 453L, "Алтуфьевское шоссе, дом 4, строение 1", "Серпуховско-Тимирязевская линия", "Владыкино", "Храм Филарета свт., Митрополита Московского и Коломенского, крестильный при храме Рождества Пресвятой Богородицы во Владыкине", "www.rpb-v.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 454L, "Родионовская улица, дом 14", "Таганско-Краснопресненская линия", "Планерная", "Храм святого благоверного Великого князя Александра Невского в Куркине", "alexnevskhram.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 455L, "Новогорская улица, дом 37", "Таганско-Краснопресненская линия", "Планерная", "Храм Владимирской иконы Божией Матери в Куркине", "hram-kurkino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 456L, "улица Саломеи Нерис, дом 4, строение 2", "Таганско-Краснопресненская линия", "Планерная", "Храм Покрова Пресвятой Богородицы в Братцеве", "www.hram-bratsevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 483L, "улица Образцова, дом 15", "Люблинско-Дмитровская линия", "Марьина роща", "Храм Николая свт. при МГУ путей сообщения (домовый)", "novospasskiymon.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 457L, "Митинская улица, дом 11", "Арбатско-Покровская линия", "Волоколамская", "Храм Почаевской иконы Божией Матери в Митино", "konstantin-i-elena.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 459L, "улица Сретенка, дом 19", "Калужско-Рижская линия", "Сухаревская", "Храм Сретения Господня при театре «Школа драматического искусства», приписной к Высокопетровскому монастырю", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 460L, "улица Бутырский вал, дом 26", "Кольцевая линия", "Белорусская", "Храм Александра свт., патр. Константинопольского при приюте Василия Кесарийского приходского попечительства (не передан)", "sretsorok.orthodoxy.ru/htm/hrams/_15.htm" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 461L, "2-й Крестовский переулок, дом 17, строение 1", "Калужско-Рижская линия", "Рижская", "Храм Александра Хотовицкого сщмч. в Переяславской слободе (крестильный), при храме иконы Божией Матери «Знамение» в Переяславской слободе", "www.znamene.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 462L, "Большая Сухаревская площадь, дом 3", "Калужско-Рижская линия", "Сухаревская", "Храм Воскресения Христова при Шереметевом странноприимном доме (ныне НИИ скорой помощи им. Н.В.Склифосовского)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 463L, "улица Щепкина, дом 61/2, строение 25", "Калужско-Рижская линия", "Проспект Мира", "Храм иконы Божией Матери «Всех скорбящих Радость» (свт. Павла Исповедника) при Старой Екатерининской больнице (ныне больница Моники), Патриаршее подворье", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 464L, "улица Советской Армии, дом 12, строение 1", "Люблинско-Дмитровская линия", "Марьина роща", "Храм сошествия Святаго Духа на Лазаревском кладбище", "na-lazarevskom.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 458L, "1-я Муравская улица, дом 39", "Арбатско-Покровская линия", "Митино", "Храм Рождества Христова в Рождественно, что в Митино", "hrammitino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 277L, "Ленинский проспект, дом 8, корпус 12", "Кольцевая линия", "Октябрьская", "Храм иконы Божией Матери «Знамение» в Хирургическом корпусе 1-й Городской Больницы (крестильный)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 276L, "Ленинский проспект, дом 8", "Кольцевая линия", "Октябрьская", "Храм преподобномученицы великой княгини Елисаветы при 23-м корпусе 1-й Городской больницы (домовый)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 275L, "улица Большая Ордынка, дом 60/2", "Кольцевая линия", "Добрынинская", "Храм святой Екатерины Великомученицы, что на Всполье", "www.st-catherine.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 100L, "2-й Боткинский проезд, дом 3", "Таганско-Краснопресненская линия", "Беговая", "Храм иконы Божией Матери «Всецарица» при клинике Московского научно-исследовательского онкологического института имени П.А. Герцена, приписной к Новоспасскому ставропигиальному мужскому монастырю", "novospasskiymon.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 99L, "Ленинградский проспект, дом 73А", "Замоскворецкая линия", "Сокол", "Храм всех Святых во Всехсвятском на Соколе", "hramsokol.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 98L, "улица 8 Марта, дом 1", "Замоскворецкая линия", "Динамо", "Храм Вонифатия св. мч. при Московской областной Клинической психиатрической больнице", "vseblago.ru/blagochinie/hramy/hram-muchenika-vonifatia" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 97L, "Тимирязевская улица, дом 33, строение 19", "Серпуховско-Тимирязевская линия", "Тимирязевская", "Храм Владимира Амбарцумова сщмч. при жилищно-строительном кооперативе «Соломенная Сторожка», приписной к храму святителя Митрофана Воронежского на Хуторской", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 96L, "улица Поликарпова, дом 16", "Таганско-Краснопресненская линия", "Беговая", "Храм иконы Божией Матери «Отрада и Утешение» на Ходынском поле города Москвы", "otrada-i-uteshenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 95L, "Ленинградский проспект, дом 73А, строение 3", "Замоскворецкая линия", "Сокол", "Храм Богоявления Господня (крестильный) во Всехсвятском, что на Соколе при храме всех святых во Всехсвятском на Соколе", "hramsokol.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 94L, "Красноармейская улица, дом 2А", "Замоскворецкая линия", "Динамо", "Храм Благовещения Пресвятой Богородицы в Петровском парке", "blagpb.orthodoxy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 93L, "улица Зои и Александра Космодемьянских, дом 8", "Замоскворецкая линия", "Войковская", "Храм Александра Невского св. блгв. кн. при Академии Управления (министерство внутренних дел России)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 92L, "Марьинский бульвар, дом 2", "Люблинско-Дмитровская линия", "Марьино", "Церковь иконы Божией Матери «Целительница» при социальном жилом доме «Марьино», приписной к храму «Утоли моя печали» иконы Божией Матери в Марьино", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 91L, "Марьинский бульвар, дом 2", "Люблинско-Дмитровская линия", "Марьино", "Храм «Утоли моя печали» в Марьино", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 90L, "Иловайская улица, дом 2", "Люблинско-Дмитровская линия", "Марьино", "Церковь иконы Божией Матери «Умягчение злых сердец» при Центре социальной адаптации «Люблино»", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 89L, "Ставропольская улица, владение 25", "Люблинско-Дмитровская линия", "Люблино", "Храм Святителя Тихона Патриарха Всероссийского в Люблино", "www.hram-lublino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 88L, "Краснодарская улица, владение 50", "Люблинско-Дмитровская линия", "Люблино", "Храм святой мученицы Татианы Римской в Люблино", "hram-tatiany.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 87L, "1-я Вольская улица, дом 1, строение 2", "Таганско-Краснопресненская линия", "Выхино", "Храм-воскресная школа Георгия Победоносца, приписной к храму иконы Божией Матери «Воспитание» в Некрасовке", "www.vospitanie-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 101L, "улица Большая Академическая, владение 33", "Замоскворецкая линия", "Войковская", "Храм святого великомученика Георгия Победоносца в Коптево", "www.hramkoptevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 86L, "1-й Капотнинский проезд, дом 1", "Таганско-Краснопресненская линия", "Кузьминки", "Храм Рождества Пресвятой Богородицы в Капотне", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 84L, "Ставропольская улица, дом 25", "Люблинско-Дмитровская линия", "Люблино", "Храм новомучеников и исповедников Российских в Люблино (крестильный)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 83L, "Ставропольская улица, дом 27", "Люблинско-Дмитровская линия", "Люблино", "Храм Матроны блж. прав. при Центре наркологии Росздрава в Люблино, приписной к Крутицкому подворью города Москвы", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 82L, "улица Академика Скрябина, дом 17, корпус 2", "Таганско-Краснопресненская линия", "Рязанский проспект", "Храм Ксении Петербургской блж. на Кузьминском кладбище", "vlahernskoe.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 81L, "улица Саранская, дом 1", "Таганско-Краснопресненская линия", "Жулебино", "Храм св. прав. Иоанна Кронштадтского в Жулебино", "www.pravoslavie-zhulebino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 80L, "улица Маршала Чуйкова, дом 26, строение 1", "Люблинско-Дмитровская линия", "Волжская", "Храм Елисаветы прмц. при школе-интернате № 55,приписной к храму свт. Николая Мирликийского в Кузнецкой слободе", "www.nikvkuz.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 79L, "Волгоградский проспект, дом 168", "Таганско-Краснопресненская линия", "Выхино", "Храм святого великомученика Георгия Победоносца при Госпитале ветеранов войн №2", "www.v-blago.ru/2011-09-12-10-45-33.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 78L, "улица 2-я Вольская, дом 19, корпус 1", "Таганско-Краснопресненская линия", "Выхино", "Часовня иконы Божией Матери «Всех скорбящих Радость» при Городской больнице № 10", "www.vospitanie-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 77L, "улица Кузьминская дом 7, строение 1", "Таганско-Краснопресненская линия", "Кузьминки", "Храм Влахернской иконы Божией Матери в Кузьминках", "vlahernskoe.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 76L, "улица Маршала Чуйкова, дом 30", "Люблинско-Дмитровская линия", "Волжская", "Храм святого равноапостольного князя Владимира при Московском казачьем кадетском корпусе имени М. А. Шолохова", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 75L, "улица Ставропольская, дом 37, корпус 1", "Люблинско-Дмитровская линия", "Люблино", "Храм Алексия царевича страстотерпца при доме-интернате для умственно-отсталых детей № 11 (домовый),приписной к храму св. блг. царевича Димитрия при 1-й Градской больнице", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 74L, "улица Головачёва, дом 2", "Люблинско-Дмитровская линия", "Люблино", "Храм Александра Невского блгв. кн. на территории Московского высшего военного командного училища (военного института)", "www.v-blago.ru/2011-09-12-10-28-38.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 73L, "улица Радио, дом 10А", "Арбатско-Покровская линия", "Бауманская", "Храм Троицы Живоначальной при Государственном областном педагогическом университете", "www.bogoyavlenskoe.ru/about/hrami/troitsi_pri_mopu" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 72L, "улица Покровка, дом 13", "Сокольническая линия", "Чистые пруды", "Храм Живоначальной Троицы на Грязех", "www.triradosti.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 71L, "Хохловский переулок, дом 12", "Калужско-Рижская линия", "Китай-город", "Храм Святой Живоначальной Троицы в Хохловском переулке", "www.trinity-church.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 85L, "Люблинская улица, дом 37/1", "Люблинско-Дмитровская линия", "Печатники", "Храм Преображения Господня при научно-практическом центре наркологии, приписной к храму св. прав. Иоанна Кронштадтского в Жулебино", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 102L, "улица Вучетича, дом 30, строение 2", "Серпуховско-Тимирязевская линия", "Тимирязевская", "Храм-часовня святого благоверного князя Дмитрия Донского при Первом Московском Кадетском корпусе, приписной к храму святителя Николая у Соломенной сторожки", "www.agios-nicolos.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 103L, "2-я Хуторская улица, дом 40", "Серпуховско-Тимирязевская линия", "Дмитровская", "Храм Елисаветы прмц. на Хуторской (крестильный) при храме святителя Митрофана Воронежского на Хуторской", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 104L, "Тимирязевская улица, дом 49", "Серпуховско-Тимирязевская линия", "Дмитровская", "Храм священномученика Иоанна Артоболевского при Российском государственном аграрном университете имени К.А. Тимирязева", "vseblago.ru/blagochinie/hramy/chasovnya-ioanna-timiryazevka" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 135L, "Рублёвское шоссе, дом 151, корпус 1, строение 2", "Арбатско-Покровская линия", "Крылатское", "Храм преподобномученицы великой княгини Елисаветы на Рублевском кладбище приписной к храму иконы Божией Матери «Неувядаемый Цвет»", "neuvyadaemy-tsvet.orthodoxy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 134L, "3-я Черепковская улица, дом 15А", "Арбатско-Покровская линия", "Крылатское", "Храм преподобномученицы великой княгини Елисаветы в Российском кардиологическом научно-производственном комплексе Министерства здравоохранения России, в Крылатском", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 133L, "Давыдковская улица, дом 7", "Арбатско-Покровская линия", "Славянский бульвар", "Храм великомученика Георгия Победоносца при Центральном Региональном Центре по делам гражданской обороны и чрезвычайных ситуаций Министерства по чрезвычайным ситуациям Российской Федерации, приписной к храму Архангела Михаила в Тропареве", "troparevo-hram.org" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 132L, "площадь Победы, дом 3Б", "Арбатско-Покровская линия", "Парк Победы", "Храм великомученика Георгия Победоносца на Поклонной горе", "altaryvic.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 131L, "Рублёвское шоссе, дом 68/2", "Арбатско-Покровская линия", "Крылатское", "Храм Владимира равноапостольного князя при воинской части № 83466 (автобаза грузовых и специальных машин министерства обороны Российской Федерации) (крестильный)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 130L, "Измайловское шоссе, дом 2", "Арбатско-Покровская линия", "Семёновская", "Храм Воскресения Христова на бывшем Семеновском кладбище", "www.nasemenovs.com" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 129L, "Рубцово-Дворцовая улица, дом 1/3, строение 21", "Сокольническая линия", "Сокольники", "Храм Живоначальной Троицы при детской городской Сокольнической больнице святого равноапостольного князя Владимира", "www.hram-ks.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 128L, "Майский просек, владение 5, строение 1", "Сокольническая линия", "Сокольники", "Храм святителя Тихона Задонского, в Сокольническом парке, приписной к Алексеевскому ставропигиальному женскому монастырю", "www.hram-svt-tihona.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 127L, "Монтажная улица, дом 8", "Арбатско-Покровская линия", "Щёлковская", "Церковь Сретения Господня на территории общества с ограниченной ответственностью «ФПК САТОРИ», приписной к храму пророка Божия Илии в Черкизове", "www.hramilii.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 126L, "улица Короленко, дом 3, корпус 6", "Сокольническая линия", "Сокольники", "Церковь Смоленской иконы Божией Матери при бывшем Коронационном убежище", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 125L, "Окружной проезд, дом 4", "Сокольническая линия", "Черкизовская", "Храм Сергия Радонежского при Московской средней специальной школе милиции Министерства внутренних дел Российской Федерации", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 124L, "Сокольническая площадь, дом 6", "Сокольническая линия", "Сокольники", "Храм Рождества Христова в Сокольниках (крестильный)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 123L, "Краснобогатырская улица, дом 17", "Сокольническая линия", "Преображенская площадь", "Храм Преображения Господня в Богородском", "бого.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 122L, "8-я улица Соколиной Горы, дом 15", "Калининская линия", "Шоссе Энтузиастов", "Храм Пантелеимона вмч. и целителя при Инфекционной клинической больнице № 2, приписной Храм воскресения Христова на бывшем Семеновском кладбище", "www.nasemenovs.com" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 121L, "улица Стромынка, дом 10", "Сокольническая линия", "Сокольники", "Храм Николая Мирликийского свт. при Центре борьбы с туберкулезом", "www.hram-ks.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 120L, "улица Преображенский вал, дом 25", "Сокольническая линия", "Преображенская площадь", "Храм Николая Мирликийского свт. на Преображенском кладбище", "www.pavel-prusskiy.ru/nikol_hram.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 119L, "Набережная Шитова, дом 72", "Сокольническая линия", "Бульвар Рокоссовского", "Храм Святителя Луки Войно-Ясенецкого в городской клинической больнице №5", "www.hramilii.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 105L, "2-й Боткинский проезд, дом 5, корпус 27", "Таганско-Краснопресненская линия", "Беговая", "Храм святых бессребреников Космы и Дамиана Асийских при Солдатенковской, ныне Боткинской больнице, приписной к храму «Отрада и Утешение» (Ватопедской) иконы Божией Матери на Ходынском поле", "otrada-i-uteshenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 106L, "2-я Хуторская улица, дом 40", "Серпуховско-Тимирязевская линия", "Дмитровская", "Храм Митрофана свт., еп. Воронежского на Хуторской", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 107L, "Большая Академическая улица, владение 33", "Замоскворецкая линия", "Войковская", "Храм Младенцев 14000 мчч. от Ирода в Вифлееме избиенных (крестильный) при храме вмч. Георгия Победоносца в Коптево", "www.hramkoptevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 108L, "Ивановская улица, дом 3", "Серпуховско-Тимирязевская линия", "Тимирязевская", "Храм Святителя Николая Мирликийского у Соломенной Сторожки", "www.agios-nicolos.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 109L, "улица Самеда Вургуна, дом 3", "Замоскворецкая линия", "Сокол", "Храм Серафима Саровского прп. - при Свято-Димитриевском детском доме № 27, приюте для девочек", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 110L, "Ленинградский проспект, дом 16, строение 2", "Замоскворецкая линия", "Белорусская", "Храм Живоначальной Троицы при бывшей Черкасской Богадельне", "holy-trinity.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 70L, "Малый Трёхсвятительский переулок, дом 4/6", "Калужско-Рижская линия", "Китай-город", "Храм Трех Святителей на Кулишках", "www.trisvyat.orthodoxy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 111L, "улица Матросская Тишина, дом 9", "Сокольническая линия", "Сокольники", "Храм Благовещения Пресвятой Богородицы в Сокольниках", "vdvhram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 113L, "Сокольническая площадь, дом 6", "Сокольническая линия", "Сокольники", "Храм Воскресения Христова в Сокольниках", "www.xbxc.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 114L, "Главная улица, дом 1А", "Арбатско-Покровская линия", "Щёлковская", "Храм Димитрия Солунского вмч. в поселке Восточный (Щитниково)", "www.dimsol.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 115L, "улица Ибрагимова, дом 6", "Арбатско-Покровская линия", "Семёновская", "Храм Святого Великомученика Димитрия Солунского на Благуше", "hram-dimitria.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 116L, "Байкальская улица, дом 37А", "Арбатско-Покровская линия", "Щёлковская", "Храм преподобных Зосимы и Савватия Соловецких чудотворцев в Гольяново", "www.hramzis.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 117L, "улица Матросская Тишина, дом 10", "Сокольническая линия", "Сокольники", "Храм Илии пророка Божия при штабе Воздушно-десантных войск в Сокольниках", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 118L, "Колодезный переулок, дом 2А", "Сокольническая линия", "Преображенская площадь", "Храм Рождества Иоанна Предтечи в Сокольниках", "podvorie-sokolniki.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 112L, "Большая Черкизовская улица, дом 17", "Сокольническая линия", "Черкизовская", "Храм Воздвижения Креста Господня (пророка Божия Илии) в Черкизове", "www.hramilii.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 136L, "Большая Филёвская улица, дом 65", "Филёвская линия", "Пионерская", "Храм в честь иконы Божией Матери «Знамение» в Кунцеве", "hramznamenie.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 69L, "Комсомольская площадь, дом 5", "Сокольническая линия", "Комсомольская", "Сергия Радонежского преподобного при Ярославском вокзале часовня", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 67L, "улица Бакунинская, дом 83", "Арбатско-Покровская линия", "Электрозаводская", "Храм Покрова в Рубцове", "www.oldrpc.ru/hram" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 31L, "проезд Одоевского, дом 13", "Калужско-Рижская линия", "Ясенево", "Храм святого апостола и евангелиста Иоанна Богослова при Православной классической гимназии «Радонеж»", "www.gymnasia-radonezh.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 30L, "улица Гарибальди, дом 36А", "Калужско-Рижская линия", "Новые Черёмушки", "Храм св. прав. Иоанна Кронштадтского в строящемся комплексе храма Всех Святых в земле Русской просиявших, в Черёмушках", "ioannkronshtadt.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 29L, "Профсоюзная улица, дом 86", "Калужско-Рижская линия", "Калужская", "Храм Иверской иконы Божией Матери при ФГУ «Российский научный центр рентгенорадиологии Росмедтехнологий» (домовый)(приписной к храму Преображения Господня, в Старом Беляеве (строящийся)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 28L, "Научный проезд, напротив владения 4", "Калужско-Рижская линия", "Калужская", "Храм в честь Священномученика Илариона, архиепископа Верейского, в Черемушках", "www.ilarion.moseparh.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 27L, "Большая Черёмушкинская улица, дом 25", "Калужско-Рижская линия", "Академическая", "Церковь «Знамение» иконы Божией Матери при ФГБУ «ГНЦ РФ Институт теоретической и экспериментальной физики»,приписна к храму преподобной Евфросинии Московской, в Котловке", "www.evfrosinia.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 26L, "Симферопольский бульвар, дом 28", "Серпуховско-Тимирязевская линия", "Чертановская", "Храм Ермогена Священномученика, Патриарха Московского и всея Руси, чудотворца, в Зюзине с временным храмом Священномученика Луки, архиепископа Симферопольского", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 25L, "Нахимовский проспект, владение 6", "Серпуховско-Тимирязевская линия", "Нахимовский проспект", "Храм преподобной Евфросинии Великой княгини Московской", "www.evfrosinia.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 24L, "улица Кржижановского дом 24/35, корпус 1", "Калужско-Рижская линия", "Профсоюзная", "Храм Всех Преподобных отцев Киево-Печерских в Старых Черемушках", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 23L, "улица Саморы Машела, д. 1", "Сокольническая линия", "Юго-Западная", "Храм Веры, Надежды, Любови и Софии свв. мцц. - при Федеральном научно-клиническом центре детской гематологии, онкологии и иммунологии Росздрава, приписан к Свято-Данилову мужскому монастырю", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 22L, "улица Крупской, дом 12А", "Сокольническая линия", "Университет", "Церковь Веры, Надежды, Любови и Софии свв. мцц. - при Свято-Софийском православном детском доме", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 21L, "улица Каховка, владение 13, корпус 9", "Каховская линия", "Каховская", "Храм в честь священномученика Вениамина, митрополита Петроградского и Гдовского, в Зюзине", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 20L, "улица Введенского, дом 1А", "Калужско-Рижская линия", "Калужская", "Церковь Введения во Храм Пресвятой Богородицы при Московском финансово-юридическом университете", "www.evfrosinia.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 19L, "улица Островитянова, владение 45", "Калужско-Рижская линия", "Коньково", "Храм Священномученика Василия, протоиерея Московского, в Конькове", "hramvasilia.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 18L, "улица Каховка, дом 8", "Каховская линия", "Каховская", "Валентины Кесарийской (Палестинской) церковь при психоневрологическом интернате №18 комитета социальной защиты населения Правительства Москвы", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 32L, "улица Академика Челомея, владение 3Б", "Калужско-Рижская линия", "Калужская", "Храм преподобного Иосифа Волоцкого в Старом Беляеве", "svetfavora.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 17L, "Перекопская улица, дом 7", "Каховская линия", "Каховская", "Храм свв. благоверных князей российских и страстотерпцев Бориса и Глеба в Зюзине", "hramborisaigleba.orthodoxy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 15L, "7-я улица Лазенки, дом 42", "Сокольническая линия", "Юго-Западная", "Михаила Архистратига крестовый храм в резиденции Святейшего Патриарха, в Переделкино", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 14L, "Погодинская улица, дом 20", "Сокольническая линия", "Спортивная", "Храм Иосифа Волоцкого прп. - при Издательстве Московской Патриархии", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 13L, "улица Даниловский Вал, дом 22", "Серпуховско-Тимирязевская линия", "Тульская", "Храм Всех Святых в Земле Российской Просиявших - в Синодальной резиденции Святейшего Патриарха, в Даниловом монастыре", "www.msdm.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 12L, "Чистый переулок, дом 5", "Сокольническая линия", "Кропоткинская", "Храм Владимирской иконы Божией Матери - Крестовый храм в резиденции Святейшего Патриарха при Московской Патриархии", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 11L, "2-я Линия Хорошёвского Серебряного Бора, дом 52", "Таганско-Краснопресненская линия", "Щукинская", "Храм в честь Благовещения Пресвятой Богородицы в резиденции отдела внешних церковных сношений", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 10L, "улица Волхонка, дом 15", "Сокольническая линия", "Кропоткинская", "Кафедральный соборный Храм Христа Спасителя", "www.xxc.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 9L, "Спартаковская улица, дом 15", "Арбатско-Покровская линия", "Бауманская", "Богоявленский кафедральный собор", "www.elohovosobor.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 8L, "Красная площадь, дом 2", "Арбатско-Покровская линия", "Площадь Революции", "Храм Покрова Пресвятой Богородицы - на Рву (собор Василия Блаженного)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 7L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Церковь Ризположения", "holy-robe-deposition-church.kreml.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 6L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Верхоспасский собор (Спаса Нерукотворного Образа)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 5L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Храм Иоанна Лествичника с колокольней Ивана Великого", "ivan-the-great-bell-tower.kreml.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 4L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Патриаршие палаты с церковью Двенадцати апостолов", "www.kreml.ru/visit-to-kremlin/what-to-see/patriarshie-palaty-s-tserkovyu-dvenadtsati-apostolov" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 3L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Благовещенский собор", "annunciation-cathedral.kreml.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 2L, "Кремль", "Сокольническая линия", "Библиотека имени Ленина", "Архангельский собор", "archangel-cathedral.kreml.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 16L, "7-я улица Лазенки, дом 42", "Сокольническая линия", "Юго-Западная", "Церковь иконы Божией Матери «Скоропослушница»", "sobory.ru/article/?object=16904" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 33L, "улица Академика Волгина, дом 12-14", "Калужско-Рижская линия", "Беляево", "Храм-часовня Михаила Архистратига при Московском университеле МВД России", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 34L, "улица Каховка, владение 1В, строение 2", "Каховская линия", "Каховская", "Храм иконы Божией Матери «Отрада и Утешение» на Каховке", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 35L, "Профсоюзная улица, дом 116", "Калужско-Рижская линия", "Коньково", "Храм Живоначальной Троицы в Конькове", "trinity.kmail.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 66L, "Посланников переулок, дом 9, строение 1", "Арбатско-Покровская линия", "Бауманская", "Храм Святителей Московских Петра, Алексия, Ионы и Филиппа в Посланниковом переулке при бывшем Епархиальном училище", "svt-msk.orthodox.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 65L, "улица Новая Басманная, дом 11", "Сокольническая линия", "Красные ворота", "Храм Святых Апостолов Петра и Павла в Новой Басманной слободе", "petraipavla-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 64L, "Комсомольская площадь, дом 3", "Сокольническая линия", "Комсомольская", "Часовня во имя Николая Чудотворца, архиепископа Мир Ликийских", "www.rop.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 63L, "Подкопаевский переулок, дом 15/9", "Калужско-Рижская линия", "Китай-город", "Храм Святителя Николая Чудотворца в Подкопаях", "www.hram-podkopai.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 62L, "улица Маросейка, дом 5", "Калужско-Рижская линия", "Китай-город", "Храм святителя Николая Чудотворца в Кленниках", "www.klenniki.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 61L, "Уланский переулок, дом 11, строение 1", "Калужско-Рижская линия", "Тургеневская", "Храм Святителя Николая Мирликийского в Дербеневе", "www.derbenevo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 60L, "Бакунинская улица, дом100", "Арбатско-Покровская линия", "Электрозаводская", "Храм Святителя Николая в Покровском", "www.nikolopokrov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 59L, "улица Земляной вал, дом 29", "Кольцевая линия", "Курская", "Часовня Матроны Московской на Курском вокзале", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 58L, "улица Маросейка, дом 14/2, строение 3", "Калужско-Рижская линия", "Китай-город", "Храм святых бессребреников Космы и Дамиана на Маросейке", "www.hram-kosmadamian.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 57L, "улица Казакова, дом 15", "Кольцевая линия", "Курская", "Церковь Константина и Елены при Государственном университете по землеустройству", "www.elohovosobor.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 56L, "Комсомольская площадь, дом 2", "Сокольническая линия", "Комсомольская", "Казанской иконы Божией Матери часовня при Казанском вокзале", "www.bogoyavlenskoe.ru/about/hrami/ikoni_bojiei_materi" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 55L, "улица Фридриха Энгельса, дом 38", "Арбатско-Покровская линия", "Бауманская", "Храм великомученицы Ирины в Покровском", "hramirini.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 54L, "улица Покровка, дом 50/2, строение 17", "Арбатско-Покровская линия", "Курская", "Иоанна Предтечи усекновения в Казенной слободе (колокольня)", "www.bogoyavlenskoe.ru/about/hrami/ioanna_predtechi" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 53L, "Яковоапостольский переулок, дом 6, строение 1", "Арбатско-Покровская линия", "Курская", "Храм святого апостола Иакова Заведеева в Казенной слободе", "www.iakovzavedeev.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 52L, "Лубянский проезд, дом 9, строение 2", "Сокольническая линия", "Лубянка", "Храм вмч. Георгия Победоносца в Старых Лучниках", "hramvluchnikah.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 51L, "Архангельский переулок, дом 15А", "Сокольническая линия", "Чистые пруды", "Храм Гавриила Архангела и вмч. Феодора Стратилата в Антиохийском подворье", "www.bogoyavlenskoe.ru/about/hrami/antiohiiskoe_podvorie" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 50L, "улица Покровка, дом 26/1", "Арбатско-Покровская линия", "Курская", "Храм Воскресения Словущего в Барашах", "www.voskresbarashi.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 36L, "Перекопская улица, дом 34, корпус 2", "Калужско-Рижская линия", "Новые Черёмушки", "Храм святых праведных Симеона Богоприимца и Анны пророчицы в Черемушках", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 37L, "улица Академика Пилюгина, дом 1", "Калужско-Рижская линия", "Новые Черёмушки", "Храм Живоначальной Троицы в Воронцове", "troizavoronzovo.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 38L, "улица Шверника, дом 17, корпус 1, строение 1", "Калужско-Рижская линия", "Академическая", "Храм Живоначальной Троицы в Старых Черемушках", "www.hramvcheremushkah.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 39L, "Профсоюзная улица, дом 67", "Калужско-Рижская линия", "Калужская", "Храм в честь иконы Божией Матери «Умягчение злых сердец» в Конькове", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 40L, "Бакунинская улица, дом 81/55", "Арбатско-Покровская линия", "Электрозаводская", "Храм Александра Невского блгв. кн. при большой Покровской богадельне", "www.bogoyavlenskoe.ru/about/hrami/aleksandra_nevskogo" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 41L, "2-й Красносельский переулок, дом 3, строение 1", "Сокольническая линия", "Красносельская", "Храм преподобного Алексия человека Божия в Красном селе", "www.st-alexis.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 68L, "улица Нижняя Красносельская, дом 12, строение 1", "Серпуховско-Тимирязевская линия", "Полянка", "Храм Покрова Пресвятой Богородицы в Красном Селе", "pokrovahram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 42L, "2-й Красносельский переулок, дом 5, строение 2", "Сокольническая линия", "Красносельская", "Церковь Алексия царевича, приписана к Алексеевскому ставропигиальному женскому монастырю", "www.hram-ks.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 44L, "Спартаковская улица, дом 15", "Арбатско-Покровская линия", "Бауманская", "Храм Василия Блаженного (крестильный) при Богоявленском кафедральном соборе", "www.elohovosobor.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 45L, "Барашёвский переулок, дом 8/2, строение 4", "Арбатско-Покровская линия", "Курская", "Храм Введения Пресвятой Богородицы в Барашах", "www.vvedenievbarashah.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 46L, "Старосадский переулок, дом 11", "Калужско-Рижская линия", "Китай-город", "Храм святого равноапостольного князя Владимира в Старых Садех", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 47L, "Старая Басманная улица, дом 16/1Б, строение 1", "Кольцевая линия", "Курская", "Церковь Владимирской иконы Божией Матери (св. вмч. Никиты) в Старой Басманной слободе", "www.elohovosobor.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 48L, "Верхняя Красносельская улица, дом 17", "Сокольническая линия", "Красносельская", "Храм Воздвижения Креста Господня в Красном Селе", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 49L, "улица Радио, дом 2, строение 1", "Кольцевая линия", "Курская", "Храм Вознесения Господня Гороховом поле", "hram1788.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 43L, "Скорняжный переулок, дом 4", "Кольцевая линия", "Комсомольская", "Артемия Веркольского св. прав. при Социально реабилитационном центре «Красносельский»", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 137L, "Ярцевская улица, дом 1А", "Арбатско-Покровская линия", "Молодёжная", "Храм святого праведного Иоанна Русского в Кунцеве", "www.ioannrus.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 138L, "площадь Киевского Вокзала, дом 2", "Филёвская линия", "Киевская", "Храм-часовня Киево-Печерской иконы Божией Матери при Киевском вокзале", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 139L, "Рублёвское шоссе, дом 135", "Арбатско-Покровская линия", "Крылатское", "Церковь Луки, архиепископа Симферопольского и Крымского при Научном Центре сердечно-сосудистой хирургии имени А.Н. Бакулева", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 239L, "деревня Изварино, дом 4", "Сокольническая линия", "Саларьево", "Храм Илии пророка Божия в Изварине", "nt-vikariatstvo.ru/index.php/hramy/ilinskaa-cerkov" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 238L, "город Троицк, Октябрьский проспект, дом 3", "Калужско-Рижская линия", "Тёплый стан", "Храм преподобномученицы великой княгини Елисаветы в Троицкой больнице Российской академии наук, приписной к Храму Троицы Живоначальной в Троицке", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 237L, "посёлок Воскресенское, дом 28А", "Бутовская линия Лёгкого метро", "Бунинская аллея", "Храм Воскресения Христова в Воскресенском", "voskresenskoe-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 236L, "посёлок Ватутинки, дом 36", "Калужско-Рижская линия", "Тёплый стан", "Церковь-часовня Владимирской иконы Божией Матери в Ватутинках, приписной к храму Покрова Пресвятой Богородицы на Десне", "desnapokrov.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 235L, "деревня Ямонтово, Солнечная улица, дом 1", "Бутовская линия Лёгкого метро", "Бунинская аллея", "Часовня Введения Пресвятой Богородицы во Храм на Ивановском кладбище, приписная к храму Троицы Живоначальной при доме отдыха «Воскресенское»", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 234L, "город Московский, 3-й микрорайон, дом 19", "Сокольническая линия", "Саларьево", "Храм Святого благоверного князя Андрея Боголюбского в Московском", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 233L, "Калужское шоссе, дом 4, строение 1", "Калужско-Рижская линия", "Тёплый стан", "Храм преподобной Ангелины Сербской (строящийся)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 232L, "улица Лётчика Грицевца, дом 3, строение 1", "Сокольническая линия", "Саларьево", "Храм Святого Благоверного князя Александра Невского в Пыхтино", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 231L, "Никольская улица, дом 8/1, строение 3", "Арбатско-Покровская линия", "Площадь Революции", "Храм Успения Пресвятой Богородицы на Чижевском подворье", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 230L, "Газетный переулок, дом 15", "Сокольническая линия", "Охотный ряд", "Храм Успения Пресвятой Богородицы на Успенском Вражке", "uspenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 229L, "Успенский переулок, дом 4", "Серпуховско-Тимирязевская линия", "Чеховская", "Храм Успения Пресвятой Богородицы в Путинках", "putinki.uspenie.com" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 228L, "Никитников переулок, дом 3", "Калужско-Рижская линия", "Китай-город", "Храм Святой Троицы в Никитниках", "www.nikitniki.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 227L, "Тихвинская улица, дом 13", "Серпуховско-Тимирязевская линия", "Менделеевская", "Храм Тихвинской иконы Божией Матери в Сущеве", "tihvinbm.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 226L, "Крапивенский переулок, дом 4, строение 2", "Люблинско-Дмитровская линия", "Трубная", "Храм преподобного Сергия Радонежского в Крапивниках", "krapivniki.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 240L, "деревня Десна, Центральная улица, дом 1", "Калужско-Рижская линия", "Тёплый стан", "Храм святителя Иннокентия митрополита Московского в «Ракитках» Патриаршее подворье", "hram-rakitki.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 225L, "2-я Тверская Ямская улица, дом 52", "Замоскворецкая линия", "Белорусская", "Храм преподобных Сергия и Германа Валаамских чудотворцев, Подворье Спасо-Преображенского Валаамского ставропигиального мужского монастыря", "valaam.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 223L, "улица Малая Дмитровка, дом 4", "Серпуховско-Тимирязевская линия", "Чеховская", "Храм Рождества Пресвятой Богородицы в Путинках, Патриаршее подворье", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 222L, "Нововоротниковский переулок, дом 3", "Кольцевая линия", "Новослободская", "Храм преподобного Пимена Великого (Троицы Живоначальной) в Новых Воротниках, что в Сущеве", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 221L, "4-я Тверская-Ямская улица, дом 16", "Замоскворецкая линия", "Маяковская", "Храм святителя Николая Мирликийского при научно-исследовательском институте нейрохирургии имени Н. Н. Бурденко (домовый) приписной к храму прпп. Сергия и Германа Валаамских чудотворцев", "valaam.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 220L, "Никитский переулок, дом 3", "Сокольническая линия", "Охотный ряд", "Храм святителя Николая Мирликийского при Главном управлении Министерства Внутренних дел Московской области (домовый) приписной к Синодальному отделу Московского Патриархата по взаимодействию с Вооруженными Силами России", "www.pobeda.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 219L, "Никольский переулок, дом 9А, строение 1", "Калужско-Рижская линия", "Китай-город", "Храм святителя Николая Мирликийского «Красный Звон»", "www.iverblag.ru/?page_id=210" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 218L, "Долгоруковская улица, дом 23А", "Кольцевая линия", "Новослободская", "Храм святителя Николая в Новой Слободе", "svt-nikolay.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 217L, "улица Варварка, дом 4, строение 1", "Калужско-Рижская линия", "Китай-город", "Храм преподобного Максима Блаженного на Варварке", "zaryadie.ru/node/139" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 216L, "Старопанский переулок, дом 4, строение 2", "Арбатско-Покровская линия", "Площадь Революции", "Храм Космы и Дамиана в Старых Панех", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 215L, "Никольская улица, дом 3", "Арбатско-Покровская линия", "Площадь Революции", "Собор Казанской иконы Божией Матери на Красной площади", "www.kazanski-sobor.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 214L, "улица Варварка, дом 15, строение 2", "Калужско-Рижская линия", "Китай-город", "Храм Рождества Иоанна Предтечи (Климента, папы Римского) на Варварке", "zaryadie.ru/node/141" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 213L, "Новая площадь, дом 12", "Сокольническая линия", "Лубянка", "Храм святого апостола Иоанна Богослова под Вязом", "рпу.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 212L, "улица Ильинка, дом 3/8, строение.2", "Арбатско-Покровская линия", "Площадь Революции", "Храм Святого пророка Божия Илии что в Китай-городе", "www.hramilias.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 211L, "улица Варварка, дом 8", "Калужско-Рижская линия", "Китай-город", "Собор иконы Божией Матери «Знамение» бывшего Знаменского монастыря", "zaryadie.ru/node/142" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 210L, "1-й Колобовский переулок, дом 1", "Серпуховско-Тимирязевская линия", "Цветной бульвар", "Храм Знамения иконы Божией Матери за Петровскими воротами при Главном управлении министерства внутренних дел России по городу Москве", "www.hramznameniya.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 224L, "Лихов переулок, дом 6, строение 1", "Серпуховско-Тимирязевская линия", "Цветной бульвар", "Храм Святых Отцов Поместного Собора 1917-1918 годов при бывшем Епархиальном доме (домовый) приписной к храму святителя Николая в Кузнецкой слободе", "www.nikvkuz.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 241L, "деревня Сосенки, дом 15А", "Калужско-Рижская линия", "Тёплый стан", "Храм Казанской иконы Божией Матери в Сосенках", "www.sosenkidom.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 242L, "деревня Летово, Летовская улица, дом 1", "Калужско-Рижская линия", "Тёплый стан", "Храм Михаила Архангела в Летово", "www.letovochurch.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 243L, "деревня Станиславль, дом 1", "Калужско-Рижская линия", "Тёплый стан", "Храм Архангела Михаила в Станиславле", "stanislavl1696.cerkov.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 274L, "Малый Толмачёвский переулок, дом 9", "Калужско-Рижская линия", "Третьяковская", "Храм святителя Николая в Толмачах", "vtolmachah.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 273L, "Ленинский проспект, дом 8, корпус 12", "Кольцевая линия", "Октябрьская", "Храм Димитрия благоверного Царевича при бывшей Голицинской ныне 1-ой Городской больнице", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 272L, "улица Большая Полянка, дом 29А", "Серпуховско-Тимирязевская линия", "Полянка", "Храм Святителя Григория Неокесарийского в Дербицах", "www.ieronim-polyanka.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 271L, "улица Большая Ордынка, дом 39", "Серпуховско-Тимирязевская линия", "Полянка", "Храм Иверской иконы Божией Матери на Всполье", "vratarnica.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 270L, "Садовническая улица, дом 6", "Замоскворецкая линия", "Новокузнецкая", "Храм великомученика Георгия Победоносца в Ендове, Подворье Спасо-Преображенского Соловецкого ставропигиального мужского монастыря", "solovki-monastyr.ru/spp/moskovskoe-podvorye" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 269L, "Большая Серпуховская улица, дом 31", "Серпуховско-Тимирязевская линия", "Серпуховская", "Храм иконы Божией Матери «Всех скорбящих Радость» при благотворительных учреждениях и общежитиях братьев Ляпиных (не передан)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 268L, "улица Большая Ордынка, дом 20", "Калужско-Рижская линия", "Третьяковская", "Храм иконы Божией Матери «Всех скорбящих Радость» на Большой Ордынке", "ordynka.com" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 267L, "Дубининская улица, дом 9/3, строение 1", "Кольцевая линия", "Павелецкая", "Храм святых мученников Флора и Лавра на Зацепе", "hram-flora-lavra.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 266L, "2-й Кадашёвский переулок, дом 7/4, строение 14", "Калужско-Рижская линия", "Третьяковская", "Храм Воскресения Христова в Кадашах", "www.kadashi.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 265L, "Большая Серпуховская улица, дом 24", "Серпуховско-Тимирязевская линия", "Серпуховская", "Храм Вознесения Господня за Серпуховскими воротами", "www.voznesenie.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 264L, "Вишняковский переулок, дом 15", "Кольцевая линия", "Павелецкая", "Крестильный храм в честь равноапостольного князя Владимира приписной к Храму святителя Николая Мирликийского в Кузнецах", "www.nikvkuz.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 263L, "улица Зацепа, дом 41", "Серпуховско-Тимирязевская линия", "Серпуховская", "Храм иконы Божией Матери «Взыскание погибших» на Зацепе", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 262L, "улица Большая Ордынка, дом 27А/8", "Калужско-Рижская линия", "Третьяковская", "Храм Благовещения Пресвятой Богородицы (святителя Николая Мирликийского) в Пыжах", "www.vpyzhax.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 261L, "улица Большая Якиманка, дом 32, строение 2", "Серпуховско-Тимирязевская линия", "Полянка", "Храм Благовещения Пресвятой Богородицы (преподобного Марона Пустынника Сирийского) в Старых Панех", "www.st-maron.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 260L, "деревня Бачурино, дом 1", "Бутовская линия Лёгкого метро", "Бульвар адмирала Ушакова", "Храм «Умягчение Злых Сердец» иконы Божией Матери в Бачурине", "www.bachurino-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 259L, "посёлок Филимонки, дом 1", "Калужско-Рижская линия", "Тёплый стан", "Церковь Троицы Живоначальной и церковь Успения Пресвятой Богородицы в Филимонках", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 258L, "посёлок Воскресенское, дом 28А", "Бутовская линия Лёгкого метро", "Бунинская аллея", "Храм Троицы Живоначальной при доме отдыха «Воскресенское»", "www.voskresenskoe-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 244L, "город Московский, 1-й микрорайон, дом 1", "Сокольническая линия", "Саларьево", "Храм иконы Божией Матери «Неувядаемый цвет» в Московском", "ntsvet.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 245L, "деревня Кувекино, Кувекинская улица, дом 1", "Калужско-Рижская линия", "Тёплый стан", "Храм святителя Николая Мирликийского в Кувекино", "kuvekinohram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 246L, "Калужское шоссе, 24-й километр", "Калужско-Рижская линия", "Тёплый стан", "Храм Святых Новомучеников и Исповедников Российских в Коммунарке", "hram-poligon-kommunarka.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 247L, "Чароитовая улица, владение 8", "Калужско-Рижская линия", "Тёплый стан", "Храм Покрова Божией Матери на Десне", "desnapokrov.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 248L, "посёлок Валуево, дом 10", "Сокольническая линия", "Юго-Западная", "Церковь Покрова Пресвятой Богородицы в Валуеве, домовый храм Клинического санатория Главмосстроя «Валуево»", "pokrov-valuevo.sochost.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 249L, "деревня Яковлево, Центральная улица, дом 3", "Калужско-Рижская линия", "Тёплый стан", "Храм Покрова Пресвятой Богородицы и часовня святителя Николая в Яковлеве", "храм-яковлево.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 209L, "Москворецкая набережная, дом 3", "Калужско-Рижская линия", "Китай-город", "Храм Зачатия праведной Анны «что в Углу» в Зарядье", "zaryadie.ru/node/143" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 250L, "посёлок Коммунарка, Лазурная улица, дом 22А", "Калужско-Рижская линия", "Тёплый стан", "Храм Преображения Господня в Коммунарке (строящийся)", "храм-коммунарка.рф" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 252L, "посёлок Минвнешторга, Берёзовая аллея, дом 1", "Сокольническая линия", "Тропарёво", "Храм преподобного Сергия Радонежского при детском доме «Молодая Гвардия» во Внукове приписной к храму Архангела Михаила в селе Летово", "www.letovochurch.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 253L, "город Троицк, Богородская улица, дом 12", "Калужско-Рижская линия", "Тёплый стан", "Храм Тихвинской иконы Божией Матери в Троицке", "www.tihvin-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 254L, "город Московский, 1-й микрорайон, дом 50", "Сокольническая линия", "Саларьево", "Храм в честь святителя Тихона в городе Московском", "sv-tihon.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 255L, "посёлок Воскресенское, дом 59", "Бутовская линия Лёгкого метро", "Бунинская аллея", "Храм Трех Святителей при оздоровительном комплексе «Архангельское» Управления Делами Президента Российской Федерации, Патриаршее подворье", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 256L, "посёлок Завода Мосрентген, дом 1", "Калужско-Рижская линия", "Тёплый стан", "Храм Святой Животворящей Троицы в поселке Мосрентген", "www.hram-mosrentgen.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 257L, "город Троицк, улица Солнечная, дом 1", "Калужско-Рижская линия", "Тёплый стан", "Храм Живоначальной Троицы в Троицке", "www.troitskhram.com" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 251L, "деревня Говорово, Полевая улица, дом 1А", "Сокольническая линия", "Тропарёво", "Храм Рождества Пресвятой Богородицы и святого благоверного князя Александра Невского в Говорове", "govorovo-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 208L, "улица Варварка, дом 12", "Калужско-Рижская линия", "Китай-город", "Храм великомученика Георгия Победоносца (Покрова пресвятой Богородицы) на Псковской горке в Зарядье", "zaryadie.ru/node/144" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 207L, "Новослободская улица, дом 58, строение 5", "Серпуховско-Тимирязевская линия", "Савёловская", "Храм Всемилостивого Спаса в бывших монастырских кельях бывшего Скорбященского монастыря (домовый)", "www.vsemspas.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 206L, "Новослободская улица, дом 58, строение 5", "Серпуховско-Тимирязевская линия", "Савёловская", "Храм Всемилостивого Спаса бывшего Скорбященского монастыря (не передан Русской православной церкви)", "www.vsemspas.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 170L, "Каширское шоссе, дом 34", "Каховская линия", "Каширская", "Храм иконы Божией Матери «Целительница» при Научном центре психического здоровья, приписной к храму Положения Ризы Господней (Ризоположения) на Донской улице", "hram.riza.su" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 169L, "улица Колобашкина, дом 1", "Замоскворецкая линия", "Кантемировская", "Храм апостола Фомы на Кантемировской", "www.daniilhram.info" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 168L, "улица Москворечье, дом 20", "Замоскворецкая линия", "Кантемировская", "Храм Феодоровской иконы Божией Матери при Детской клинической больнице № 38 (домовый), приписной к храму иконы Божией Матери «Живоносный Источник» в Царицыне", "www.spring-life.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 167L, "Каширское шоссе, дом 61А", "Замоскворецкая линия", "Домодедовская", "Храм Живоначальной Троицы в Орехово-Борисово", "1000let.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 166L, "2-й Кожевнический переулок, дом 4/6, строение 7", "Замоскворецкая линия", "Павелецкая", "Храм Троицы Живоначальной в Кожевниках", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 165L, "Ключевая улица, дом 5", "Люблинско-Дмитровская линия", "Борисово", "Храм Троицы Живоначальной в Братееве", "hram-brateevo.narod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 164L, "Борисовский проезд, дом 15, корпус 4", "Люблинско-Дмитровская линия", "Борисово", "Храм Троицы Живоначальной в Борисово", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 163L, "Каширское шосее, владение 63, корпус 2", "Замоскворецкая линия", "Домодедовская", "Храм иконы Божей Матери «Троеручица» в Орехово-Борисово", "troeruchitsa.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 162L, "Восточная улица, дом 4, корпус 1", "Замоскворецкая линия", "Автозаводская", "Храм Тихвинской иконы Божией Матери Симонова монастыря", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 161L, "Каширское шоссе, дом 31", "Каховская линия", "Каширская", "Храм Смоленской иконы Божией Матери при Национальном исследовательском ядерном университете «МИФИ»", "www.hram-mephi.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 160L, "Восточная улица, дом 6", "Замоскворецкая линия", "Автозаводская", "Храм Рождества Пресвятой Богородицы в Старом Симонове", "www.starosimonovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 159L, "Ясеневая улица, дом 38, корпус 1", "Люблинско-Дмитровская линия", "Зябликово", "Храм Покрова Пресвятой Богородицы в Орехово-Борисово", "pokrov-orehovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 158L, "Ореховый бульвар, дом 28", "Замоскворецкая линия", "Красногвардейская", "Храм Пантелеимона великомученика и целителя в Клинической больнице № 83(домовый), приписной к храму святого Николая на Берсеневке", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 157L, "Каширское шоссе, дом 24", "Каховская линия", "Каширская", "Храм Пантелеимона при Онкологическом научном центре Российской академии медицинских наук (домовый), приписной к храму Казанской иконы Божией Матери в Коломенском", "kolomenskoe.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 156L, "Проспект Андропова, дом 39, строение 9", "Замоскворецкая линия", "Коломенская", "Храм Казанской иконы Божией Матери в Коломенском", "kolomenskoe.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 155L, "Проспект Андропова, дом 39, строение 7", "Замоскворецкая линия", "Коломенская", "Церковь Усекновения главы Иоанна Предтечи в Дьякове", "mgomz.ru/pamyatniki/a-monk-walks-his-path" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 154L, "Каширское шоссе, дом 59, корпус 4", "Замоскворецкая линия", "Царицыно", "Храм святителя Николая Мирликийского в Сабурове (Иверской иконы Божией Матери)", "hramsaburovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 140L, "Рублёвское шоссе, дом 68/2", "Арбатско-Покровская линия", "Крылатское", "Храм Михаила Архангела в Екатериновке при воинской части № 83466 (автобаза грузовых и специальных машин министерства обороны Российской Федерации)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 141L, "площадь Победы, дом 3Б", "Арбатско-Покровская линия", "Парк Победы", "Храм-часовня Архангела Михаила близ Кутузовской избы, что в Филях", "www.altaryvic.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 142L, "Новозаводская улица, дом 6", "Филёвская линия", "Фили", "Храм Покрова Пресвятой Богородицы в Филях", "m-blago.ru/temples-and-chapels/78-presvjatoj-bogoroditsy-in-filjah" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 143L, "улица Крылатские Холмы, дом 12", "Арбатско-Покровская линия", "Крылатское", "Храм Рождества Пресвятой Богородицы в Крылатском", "www.hramnaholmah.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 144L, "улица Багрицкого, дом 10, корпус 3", "Арбатско-Покровская линия", "Кунцевская", "Храм Серафима Саровского в Кунцеве", "www.stserafim.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 145L, "Филёвский бульвар, владение 18", "Филёвская линия", "Багратионовская", "Храм преподобного Серафима Саровского на Филевской Пойме", "www.hramnapoime.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 171L, "Ленинский проспект, дом 27", "Калужско-Рижская линия", "Ленинский проспект", "Храм свт. Алексия, митрополита Московского при Центральной клинической больнице Московского Патриархата", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 146L, "улица Маршала Тимошенко, дом 15", "Арбатско-Покровская линия", "Крылатское", "Храм преподобного Сергия Радонежского при федеральном государственном учреждении «Центральная клиническая больница с поликлиникой»", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 148L, "улица Москворечье, дом 7", "Каховская линия", "Каширская", "Церковь страстотерпца Алексия царевича при городской клинической психиатрической больнице №15", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 149L, "Дольская улица, дом 2", "Замоскворецкая линия", "Царицыно", "Храм Богоявления Господня в Царицыне (крестильный) при храме иконы Божией Матери «Живоносный Источник» в Царицыне", "www.spring-life.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 150L, "Проспект Андропова, дом 39, строение 1", "Замоскворецкая линия", "Коломенская", "Храм Вознесения Господня в Коломенском", "mgomz.ru/kolomenskoe" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 151L, "Средний Староданиловский переулок, дом 3", "Серпуховско-Тимирязевская линия", "Тульская", "Храм Воскресения Словущего в Даниловской слободе", "hram-vs.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 152L, "Проспект Андропова, дом 39, строение 4", "Замоскворецкая линия", "Коломенская", "Храм великомученика Георгия Победоносца, с колокольней в Коломенском", "mgomz.ru/kolomenskoe" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 153L, "Дольская улица, дом 2", "Замоскворецкая линия", "Царицыно", "Храм иконы Божией Матери «Живоносный Источник»", "www.spring-life.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 147L, "Рябиновая улица, дом 18, строение 1", "Арбатско-Покровская линия", "Кунцевская", "Храм Спаса Нерукотворного Образа на Сетуни", "spas-setun.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 551L, "Пречистенская набережная, дом 11", "Сокольническая линия", "Парк культуры", "Храм Флора и Лавра свв. мчч. при бывшем Ермаковском училище, Патриаршее подворье ныне Московском экономико-энергетическом колледже, приписной к храму прор. Божия Илии в Обыденском переулке", "www.hram-ostozhenka.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 172L, "Загородное шоссе, дом 2", "Калужско-Рижская линия", "Ленинский проспект", "Храм в честь иконы Божией Матери «Всех скорбящих Радость» при психиатрической больнице имени Н.А. Алексеева", "hram-pkb1.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 174L, "Чертановская улица, владение 2, корпус 2", "Серпуховско-Тимирязевская линия", "Чертановская", "Храм Державной иконы Божией Матери в Чертанове", "derzhavnaya.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 205L, "Лихов переулок, дом 6, строение 1", "Серпуховско-Тимирязевская линия", "Цветной бульвар", "Храм Равноапостольного князя Владимира при бывшем Епархиальном доме (домовый) приписной к храму Николая Мирликийского в Кузнецкой слободе", "www.nikvkuz.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 204L, "улица Варварка, дом 2, строение 1", "Калужско-Рижская линия", "Китай-город", "Церковь святой великомученицы Варвары", "zaryadie.ru/hram-varvary-na-varvarke" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 203L, "Богоявленский переулок, дом 2, строение 4", "Арбатско-Покровская линия", "Площадь Революции", "Храм Богоявления Господня Бывшего Богоявленского монастыря", "www.bgkg.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 202L, "Столешников переулок, дом 2", "Таганско-Краснопресненская линия", "Пушкинская", "Храм святых бессребренников Космы и Дамиана в Шубине", "www.damian.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 201L, "Ижорская улица, дом 1", "Замоскворецкая линия", "Речной вокзал", "Храм Преподобного Сергия Радонежского в Бусинове", "www.businovohram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 200L, "Талдомская улица, дом 2", "Замоскворецкая линия", "Речной вокзал", "Храм преподобного Серафима Саровского при научно-исследовательском институте Педиатрии и Детской Хирургии (домовый)", "www.hram-bg.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 199L, "Ленинградское шоссе, дом 354/1, строение 1", "Замоскворецкая линия", "Речной вокзал", "Храм Рождества Христова в Черкизове (Новоподрезково)", "cherkrh.prihod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 198L, "улица Ивана Сусанина, дом 3", "Замоскворецкая линия", "Речной вокзал", "Часовня святого великомученика и целителя Пантелеимона при федеральном государственном учреждении Федеральное бюро медико-социальной экспертизы (домовый)", "www.hram-bg.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 197L, "Правобережная улица, дом 6", "Таганско-Краснопресненская линия", "Планерная", "Храм святых бессребреников Космы и Дамиана в Космодемьянском", "www.kosmaidamian.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 196L, "Кронштадтский бульвар, дом 29", "Замоскворецкая линия", "Водный стадион", "Колокольня бывшего Казанского Головинского монастыря приписная к храму иконы Божией Матери «Знамение» в Аксиньине", "www.aksinino-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 195L, "Дмитровское шоссе, владение 66", "Серпуховско-Тимирязевская линия", "Петровско-Разумовская", "Храм святителя Иннокентия, митрополита Московского в Бескудникове", "www.svt-innokentiy.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 194L, "Фестивальная улица, дом 77A", "Замоскворецкая линия", "Речной вокзал", "Храм иконы Божией Матери «Знамение» в Ховрино", "znamenie-hovrino.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 193L, "Фестивальная улица, дом 6", "Замоскворецкая линия", "Речной вокзал", "Храм иконы Божией Матери «Знамение» в Аксиньино", "www.aksinino-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 192L, "Правобережная улица, дом 4", "Замоскворецкая линия", "Речной вокзал", "Храм «Живоносный Источник» иконы Божией Матери в пансионате № 1 для ветеранов труда (домовый) приписной к храму святых бессребреников Космы и Дамиана в Космодемьянском", "www.kosmaidamian.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 191L, "Дегунинская улица, дом 18А", "Серпуховско-Тимирязевская линия", "Петровско-Разумовская", "Храм святых мучеников и страстотерпцев Бориса и Глеба в Дегунине", "www.hram-bg.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 190L, "Панфиловский проспект, дом 1", "Замоскворецкая линия", "Речной вокзал", "Храм преподобного Сергия Радонежского в Зеленограде приписной к храму Архистратига Божия Михаила в Зеленограде", "www.zelen-hram.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 189L, "Никольский проезд, дом 1", "Замоскворецкая линия", "Речной вокзал", "Храм свт. Николая, архиепископа Мир Ликийских в Зеленограде", "www.zelen-hram.ru/hram/raspisanie-bogosluzhenii.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 175L, "4-й Рощинский проезд, дом 30", "Серпуховско-Тимирязевская линия", "Тульская", "Храм Сошествия Святого Духа на Даниловском кладбище", "hram-sv-duha.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 176L, "Чертановская улица, дом 56А", "Серпуховско-Тимирязевская линия", "Улица академика Янгеля", "Церковь Жен Мироносиц при Доме ребенка № 17 приписной к Свято-Данилову мужскому монастырю", "www.msdm.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 177L, "МКАД, 33-й километр, владение 7А", "Серпуховско-Тимирязевская линия", "Аннино", "Храм - часовня Матроны Московской на Варшавском шоссе приписной к Покровскому ставропигиальному женскому монастырю", "www.pokrov-monastir.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 178L, "Булатниковский проезд, владение 8А", "Замоскворецкая линия", "Царицыно", "Храм святителя Николая Мирликийского в Бирюлеве", "www.st-nikolas.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 179L, "2-я Покровская улица, дом 24", "Серпуховско-Тимирязевская линия", "Пражская", "Покрова Пресвятой Богородицы на Городне", "www.pokrovgorod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 180L, "Донская улица, дом 20/6, cтроение 1", "Калужско-Рижская линия", "Шаболовская", "Храм Ризоположения на Донской", "hram.riza.su" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 173L, "Загородное шоссе, дом 2", "Калужско-Рижская линия", "Ленинский проспект", "Храм во имя преподобного Иоанна Рыльского при психиатрической больнице им. Н.А. Алексеева", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 181L, "улица Подольских курсантов, дом 22", "Серпуховско-Тимирязевская линия", "Улица академика Янгеля", "Храм-часовня преподобного Серафима Саровского на Покровском кладбище, приписной к храму Покрова Пресвятой Богородицы в Покровском, на Городне", "www.pokrovgorod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 183L, "Ленинский проспект, дом 27", "Калужско-Рижская линия", "Ленинский проспект", "Храм Тихвинской иконы Божией Матери при Центральной клинической больнице Московского Патриархата", "pravbolnitsa.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 184L, "Днепропетровская улица, дом 14", "Серпуховско-Тимирязевская линия", "Пражская", "Храм мученика Трифона при психоневрологическом интернате № 30 (домовый) приписной к храму Живоначальной Троицы в Чертанове", "troitza-chertanovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 185L, "Днепропетровская улица, дом 16", "Серпуховско-Тимирязевская линия", "Пражская", "Храм Живоначальной Троицы в Чертанове", "troitza-chertanovo.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 186L, "Деловая улица, дом 21А", "Замоскворецкая линия", "Кантемировская", "Храм Успения Пресвятой Богородицы на Котляковском кладбище приписной к храму иконы Божией Матери «Живоносный Источник» в Царицыне", "cemetery-church.narod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 187L, "улица Садовники, дом 15", "Замоскворецкая линия", "Коломенская", "Храм преподобного Серафима Саровского при психоневрологическом интернате № 16 (домовый)", null });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 188L, "Филаретовская улица, дом 3", "Замоскворецкая линия", "Речной вокзал", "Храм свт. Филарета Московского в Зеленограде приписной к храму иконы Божией матери «Скоропослушница» в Зеленограде", "www.zelen-hram.ru/hram/raspisanie-bogosluzhenii.html" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 182L, "2-я Покровская улица, дом 24", "Серпуховско-Тимирязевская линия", "Пражская", "Храм святителя Спиридона Тримифунтского на Городне (крестильный) при храме Покрова Пресвятой Богородицы в Покровском, на Городне", "www.pokrovgorod.ru" });

            migrationBuilder.InsertData(
                table: "RPTSobjs",
                columns: new[] { "Id", "Address", "MetroLine", "MetroStation", "Name", "WebSite" },
                values: new object[] { 552L, "Преображенская площадь, дом 9А", "Сокольническая линия", "Преображенская площадь", "Храм Преображения Господня на Преображенской площади", "www.hram-preobrajeniya.ru" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RPTSobjs");
        }
    }
}
