using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SofiaTransport.Models;


namespace SofiaTransport.ViewModels
{
    class BusesViewModel
    {
        private static ObservableCollection<BusModel> buses;

        public static IEnumerable<BusModel> Buses
        {
            get
            {
                if (buses == null)
                {
                    Buses = GetGeneratedBuses();
                }
                return buses;
            }
            set
            {
                if (buses != value)
                {
                    if (buses == null)
                    {
                        buses = new ObservableCollection<BusModel>();
                    }
                    buses.Clear();
                    foreach (var item in value)
                    {
                        buses.Add(item);
                    }
                }
            }
        }

        public static IEnumerable<BusModel> GetBuses()
        {
            return Buses;
        }
        public BusesViewModel()
        {
        }

        private static IEnumerable<BusModel> GetGeneratedBuses()
        {
            BusModel[] buses =
            {
                new BusModel()
{
Number = "1",
lid = "1000066",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Гео Милев - Село Кокаляне",
rid="1001824",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Гео Милев",
Kod="52",
s="1002619"
},new StopModel()
{
Name="СК ЦСКА ",
Kod="1151",
s="1002037"
},new StopModel()
{
Name="Спортна зала Арена Армеец ",
Kod="2616",
s="1002021"
},new StopModel()
{
Name="Площад на авиацията ",
Kod="1259",
s="1002009"
},new StopModel()
{
Name="УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name="Държавна печатница ",
Kod="554",
s="1001965"
},new StopModel()
{
Name="Комплекс на БАН ",
Kod="84",
s="1001953"
},new StopModel()
{
Name="Метростанция Цариградско шосе ",
Kod="1017",
s="1001939"
},new StopModel()
{
Name="Корабчето ",
Kod="970",
s="1002252"
},new StopModel()
{
Name=" Горублянско ханче ",
Kod="498",
s="1015623"
},new StopModel()
{
Name=" Ул. Цветна градина ",
Kod="2257",
s="1001833"
},new StopModel()
{
Name=" Кв. Горубляне ",
Kod="831",
s="1001803"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1174",
s="1001769"
},new StopModel()
{
Name=" СБА ",
Kod="1504",
s="1001733"
},new StopModel()
{
Name=" Детско градче ",
Kod="536",
s="1001719"
},new StopModel()
{
Name=" Разклонът за с. Герман ",
Kod="1427",
s="1001687"
},new StopModel()
{
Name=" Банята Панчарево ",
Kod="102",
s="1001669"
},new StopModel()
{
Name=" Гребна база ",
Kod="506",
s="1001635"
},new StopModel()
{
Name=" Кв. Панчарево ",
Kod="1243",
s="1001611"
},new StopModel()
{
Name=" Плажа Панчарево ",
Kod="1334",
s="1001563"
},new StopModel()
{
Name=" Кокалянско ханче ",
Kod="2560",
s="1003791"
},new StopModel()
{
Name=" Ул. Латинка ",
Kod="2020",
s="1003764"
},new StopModel()
{
Name=" Ул. Цар Иван Шишман ",
Kod="1666",
s="1003776"
},new StopModel()
{
Name=" Ул.Цар Иван Асен ІІ ",
Kod="1364",
s="1003780"
},new StopModel()
{
Name=" Село Кокаляне ",
Kod="1540",
s="1003790"
},}
},new DirectionModel()
{
Name ="Село Кокаляне - Автостанция Гео Милев",
rid="1001823",
Stops=new StopModel[]
{new StopModel()
{
Name="Село Кокаляне",
Kod="1539",
s="1003798"
},new StopModel()
{
Name="Ул. Цар Иван Асен ІІ ",
Kod="1365",
s="1003779"
},new StopModel()
{
Name="Ул. Цар Иван Шишман ",
Kod="1665",
s="1003775"
},new StopModel()
{
Name="Ул. Латинка ",
Kod="2019",
s="1003763"
},new StopModel()
{
Name="Кокалянско ханче ",
Kod="962",
s="1001543"
},new StopModel()
{
Name="Плажа Панчарево ",
Kod="1335",
s="1001564"
},new StopModel()
{
Name="Кв. Панчарево ",
Kod="1244",
s="1001612"
},new StopModel()
{
Name="Гребна база ",
Kod="505",
s="1001640"
},new StopModel()
{
Name="Банята Панчарево ",
Kod="101",
s="1001666"
},new StopModel()
{
Name=" Разклонът за с. Герман ",
Kod="1428",
s="1001688"
},new StopModel()
{
Name=" Детско градче ",
Kod="535",
s="1001720"
},new StopModel()
{
Name=" СБА ",
Kod="1503",
s="1001734"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1182",
s="1001774"
},new StopModel()
{
Name=" Кв. Горубляне ",
Kod="830",
s="1001804"
},new StopModel()
{
Name=" Ул. Цветна градина ",
Kod="2255",
s="1020113"
},new StopModel()
{
Name=" Горублянско ханче ",
Kod="497",
s="1015626"
},new StopModel()
{
Name=" Корабчето ",
Kod="971",
s="1002257"
},new StopModel()
{
Name=" Интер Експо Център ",
Kod="1072",
s="1023849"
},new StopModel()
{
Name=" Метростанция Цариградско шосе ",
Kod="1016",
s="1023827"
},new StopModel()
{
Name=" Комплекс на БАН ",
Kod="86",
s="1023838"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="555",
s="1001968"
},new StopModel()
{
Name=" Хермес парк ",
Kod="2593",
s="1001978"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1196",
s="1001988"
},new StopModel()
{
Name=" Площад на авиацията ",
Kod="1260",
s="1002016"
},new StopModel()
{
Name=" Спортна зала Арена Армеец ",
Kod="2615",
s="1002024"
},new StopModel()
{
Name=" СК ЦСКА ",
Kod="1155",
s="1002042"
},new StopModel()
{
Name=" Автостанция Гео Милев ",
Kod="53",
s="1002618"
},}
},}},

new BusModel()
{
Number = "3",
lid = "1000068",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Гео Милев - СЕЛО ДОЛНИ ПАСАРЕЛ",
rid="1001827",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Гео Милев",
Kod="52",
s="1002619"
},new StopModel()
{
Name="СК ЦСКА ",
Kod="1151",
s="1002037"
},new StopModel()
{
Name="Спортна зала Арена Армеец ",
Kod="2616",
s="1002021"
},new StopModel()
{
Name="Площад на авиацията ",
Kod="1259",
s="1002009"
},new StopModel()
{
Name="УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name="Държавна печатница ",
Kod="554",
s="1001965"
},new StopModel()
{
Name="Комплекс на БАН ",
Kod="84",
s="1001953"
},new StopModel()
{
Name="Метростанция Цариградско шосе ",
Kod="1017",
s="1001939"
},new StopModel()
{
Name="Корабчето ",
Kod="970",
s="1002252"
},new StopModel()
{
Name=" Горублянско ханче ",
Kod="498",
s="1015623"
},new StopModel()
{
Name=" Ул. Цветна градина ",
Kod="2257",
s="1001833"
},new StopModel()
{
Name=" Кв. Горубляне ",
Kod="831",
s="1001803"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1174",
s="1001769"
},new StopModel()
{
Name=" СБА ",
Kod="1504",
s="1001733"
},new StopModel()
{
Name=" Детско градче ",
Kod="536",
s="1001719"
},new StopModel()
{
Name=" Разклонът за с. Герман ",
Kod="1427",
s="1001687"
},new StopModel()
{
Name=" Банята Панчарево ",
Kod="102",
s="1001669"
},new StopModel()
{
Name=" Гребна база ",
Kod="506",
s="1001635"
},new StopModel()
{
Name=" Кв. Панчарево ",
Kod="1243",
s="1001611"
},new StopModel()
{
Name=" Плажа Панчарево ",
Kod="1334",
s="1001563"
},new StopModel()
{
Name=" КОКАЛЯНСКО ХАНЧЕ ",
Kod="963",
s="1009394"
},new StopModel()
{
Name=" в.з. Китката ",
Kod="1625",
s="1009436"
},new StopModel()
{
Name=" ДЯВОЛСКИ МОСТ ",
Kod="557",
s="1009500"
},new StopModel()
{
Name=" Манастир св. Никола ",
Kod="2266",
s="1009530"
},new StopModel()
{
Name=" ЗАСЛОН СИНАНИЦА ",
Kod="732",
s="1009614"
},new StopModel()
{
Name=" РЕСТОРАНТ ЗЛАТНАТА РИБКА ",
Kod="1474",
s="1009636"
},new StopModel()
{
Name=" БАРАЖА яз. Пасарел ",
Kod="104",
s="1009702"
},new StopModel()
{
Name=" яз. Пасарел ",
Kod="1229",
s="1009734"
},new StopModel()
{
Name=" ВЕЦ ПАСАРЕЛ ",
Kod="420",
s="1009770"
},new StopModel()
{
Name=" МОСТА ДОЛНИ ПАСАРЕЛ ",
Kod="1088",
s="1009806"
},new StopModel()
{
Name=" СЕЛО ДОЛНИ ПАСАРЕЛ ",
Kod="1528",
s="1009813"
},}
},new DirectionModel()
{
Name ="СЕЛО ДОЛНИ ПАСАРЕЛ - Автостанция Гео Милев",
rid="1001826",
Stops=new StopModel[]
{new StopModel()
{
Name="СЕЛО ДОЛНИ ПАСАРЕЛ",
Kod="1529",
s="1009823"
},new StopModel()
{
Name="МОСТА ДОЛНИ ПАСАРЕЛ ",
Kod="1089",
s="1009803"
},new StopModel()
{
Name="ВЕЦ ПАСАРЕЛ ",
Kod="421",
s="1009767"
},new StopModel()
{
Name="яз. Пасарел ",
Kod="1230",
s="1009731"
},new StopModel()
{
Name="БАРАЖА яз. Пасарел ",
Kod="103",
s="1009699"
},new StopModel()
{
Name="РЕСТОРАНТ ЗЛАТНАТА РИБКА ",
Kod="1473",
s="1009635"
},new StopModel()
{
Name="ЗАСЛОН СИНАНИЦА ",
Kod="731",
s="1009613"
},new StopModel()
{
Name="Манастир св. Никола ",
Kod="2267",
s="1009531"
},new StopModel()
{
Name="ДЯВОЛСКИ МОСТ ",
Kod="556",
s="1009497"
},new StopModel()
{
Name=" в.з. Китката ",
Kod="1624",
s="1009439"
},new StopModel()
{
Name=" Кокалянско ханче ",
Kod="2592",
s="1027509"
},new StopModel()
{
Name=" Плажа Панчарево ",
Kod="1335",
s="1001564"
},new StopModel()
{
Name=" Кв. Панчарево ",
Kod="1244",
s="1001612"
},new StopModel()
{
Name=" Гребна база ",
Kod="505",
s="1001640"
},new StopModel()
{
Name=" Банята Панчарево ",
Kod="101",
s="1001666"
},new StopModel()
{
Name=" Разклонът за с. Герман ",
Kod="1428",
s="1001688"
},new StopModel()
{
Name=" Детско градче ",
Kod="535",
s="1001720"
},new StopModel()
{
Name=" СБА ",
Kod="1503",
s="1001734"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1182",
s="1001774"
},new StopModel()
{
Name=" Кв. Горубляне ",
Kod="830",
s="1001804"
},new StopModel()
{
Name=" Ул. Цветна градина ",
Kod="2255",
s="1020113"
},new StopModel()
{
Name=" Горублянско ханче ",
Kod="497",
s="1015626"
},new StopModel()
{
Name=" Корабчето ",
Kod="971",
s="1002257"
},new StopModel()
{
Name=" Интер Експо Център ",
Kod="1072",
s="1023849"
},new StopModel()
{
Name=" Метростанция Цариградско шосе ",
Kod="1016",
s="1023827"
},new StopModel()
{
Name=" Комплекс на БАН ",
Kod="86",
s="1023838"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="555",
s="1001968"
},new StopModel()
{
Name=" Хермес парк ",
Kod="2593",
s="1001978"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1196",
s="1001988"
},new StopModel()
{
Name=" Площад на авиацията ",
Kod="1260",
s="1002016"
},new StopModel()
{
Name=" Спортна зала Арена Армеец ",
Kod="2615",
s="1002024"
},new StopModel()
{
Name=" СК ЦСКА ",
Kod="1155",
s="1002042"
},new StopModel()
{
Name=" Автостанция Гео Милев ",
Kod="53",
s="1002618"
},}
},}},

new BusModel()
{
Number = "4",
lid = "1000069",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Кокалянско ханче - Ж.к.Младост 1",
rid="1001814",
Stops=new StopModel[]
{new StopModel()
{
Name="Кокалянско ханче",
Kod="962",
s="1001543"
},new StopModel()
{
Name="Плажа Панчарево ",
Kod="1335",
s="1001564"
},new StopModel()
{
Name="Кв. Панчарево ",
Kod="1244",
s="1001612"
},new StopModel()
{
Name="Гребна база ",
Kod="505",
s="1001640"
},new StopModel()
{
Name="Банята Панчарево ",
Kod="101",
s="1001666"
},new StopModel()
{
Name="Разклонът за с. Герман ",
Kod="1428",
s="1001688"
},new StopModel()
{
Name="Детско градче ",
Kod="535",
s="1001720"
},new StopModel()
{
Name="СБА ",
Kod="1503",
s="1001734"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1182",
s="1001774"
},new StopModel()
{
Name=" Кв. Горубляне ",
Kod="830",
s="1001804"
},new StopModel()
{
Name=" Ул. Цветна градина ",
Kod="2256",
s="1001838"
},new StopModel()
{
Name=" САМОКОВСКО ШОСЕ ",
Kod="1498",
s="1019009"
},new StopModel()
{
Name=" БЛ. 1 ж.к. Горубляне ",
Kod="122",
s="1018997"
},new StopModel()
{
Name=" БЛ. 43 ж.к. Горубляне ",
Kod="215",
s="1018987"
},new StopModel()
{
Name=" БЛ. 39 ж.к. Горубляне ",
Kod="203",
s="1018977"
},new StopModel()
{
Name=" Ул. Инж. Георги Белов ",
Kod="2591",
s="1018963"
},new StopModel()
{
Name=" КУЛИНАРЕН К-Т ПЕЙФИЛ ",
Kod="989",
s="1009173"
},new StopModel()
{
Name=" СОФИЙСКА ВОДА ",
Kod="1602",
s="1009167"
},new StopModel()
{
Name=" Ж.К.МЛАДОСТ-3 ",
Kod="668",
s="1018914"
},new StopModel()
{
Name=" Община Младост ",
Kod="946",
s="1009101"
},new StopModel()
{
Name=" бл.327 ж.к. Младост-3 ",
Kod="194",
s="1009091"
},new StopModel()
{
Name=" Ул. Д-р Ат. Москов ",
Kod="1917",
s="1009077"
},new StopModel()
{
Name=" Бл. 222 ж.к. Младост 2 ",
Kod="168",
s="1009067"
},new StopModel()
{
Name=" Бл. 56 ж.к. Младост 1 ",
Kod="234",
s="1017085"
},new StopModel()
{
Name=" Бл. 66 ж.к. Младост 1 ",
Kod="246",
s="1018826"
},new StopModel()
{
Name=" Пазара Младост 1 ",
Kod="969",
s="1018836"
},new StopModel()
{
Name=" Ул.Йерусалим ",
Kod="2471",
s="1018842"
},new StopModel()
{
Name=" Онкологичен диспансер ",
Kod="23",
s="1018852"
},new StopModel()
{
Name=" Посолствата ",
Kod="1400",
s="1018860"
},new StopModel()
{
Name=" Ж.к.Младост 1 ",
Kod="662",
s="1018870"
},}
},new DirectionModel()
{
Name ="Ж.к.Младост-1 - Кокалянско ханче",
rid="1001815",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Младост-1",
Kod="661",
s="1018869"
},new StopModel()
{
Name="Посолствата ",
Kod="1401",
s="1018859"
},new StopModel()
{
Name="Онкологичен диспансер ",
Kod="22",
s="1027323"
},new StopModel()
{
Name="Пазара Младост 1 ",
Kod="968",
s="1018835"
},new StopModel()
{
Name="Бл. 66 ж.к. Младост 1 ",
Kod="245",
s="1018825"
},new StopModel()
{
Name="Бл. 56 ж.к. Младост 1 ",
Kod="233",
s="1017086"
},new StopModel()
{
Name="Бл. 223 ж.к. Младост 2 ",
Kod="169",
s="1009062"
},new StopModel()
{
Name="Бл. 222 ж.к. Младост 2 ",
Kod="167",
s="1009068"
},new StopModel()
{
Name="Ул.д-р Атанас Москов ",
Kod="1918",
s="1009082"
},new StopModel()
{
Name=" бл.327 ж.к. Младост-3 ",
Kod="193",
s="1009094"
},new StopModel()
{
Name=" Община Младост ",
Kod="945",
s="1018899"
},new StopModel()
{
Name=" ж.к. Младост-3 ",
Kod="667",
s="1018915"
},new StopModel()
{
Name=" СОФИЙСКА ВОДА ",
Kod="1603",
s="1009164"
},new StopModel()
{
Name=" Кулинарен к-т Пейфил ",
Kod="988",
s="1018954"
},new StopModel()
{
Name=" Ул. Инж. Георги Белов ",
Kod="2590",
s="1018966"
},new StopModel()
{
Name=" БЛ. 39 ж.к. Горубляне ",
Kod="204",
s="1018978"
},new StopModel()
{
Name=" БЛ. 43 ж.к. Горубляне ",
Kod="216",
s="1018986"
},new StopModel()
{
Name=" БЛ. 1 ж.к. Горубляне ",
Kod="125",
s="1019000"
},new StopModel()
{
Name=" САМОКОВСКО ШОСЕ ",
Kod="1497",
s="1019012"
},new StopModel()
{
Name=" Ул. Цветна градина ",
Kod="2257",
s="1001833"
},new StopModel()
{
Name=" Кв. Горубляне ",
Kod="831",
s="1001803"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1174",
s="1001769"
},new StopModel()
{
Name=" СБА ",
Kod="1504",
s="1001733"
},new StopModel()
{
Name=" Детско градче ",
Kod="536",
s="1001719"
},new StopModel()
{
Name=" Разклонът за с. Герман ",
Kod="1427",
s="1001687"
},new StopModel()
{
Name=" Банята Панчарево ",
Kod="102",
s="1001669"
},new StopModel()
{
Name=" Гребна база ",
Kod="506",
s="1001635"
},new StopModel()
{
Name=" Кв. Панчарево ",
Kod="1243",
s="1001611"
},new StopModel()
{
Name=" Плажа Панчарево ",
Kod="1334",
s="1001563"
},new StopModel()
{
Name=" Кокалянско ханче ",
Kod="962",
s="1001543"
},}
},}},

new BusModel()
{
Number = "5",
lid = "1000070",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Гео Милев - СЕЛО ДОЛНИ ЛОЗЕН",
rid="1000063",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Гео Милев",
Kod="52",
s="1002619"
},new StopModel()
{
Name="СК ЦСКА ",
Kod="1151",
s="1002037"
},new StopModel()
{
Name="Спортна зала Арена Армеец ",
Kod="2616",
s="1002021"
},new StopModel()
{
Name="Площад на авиацията ",
Kod="1259",
s="1002009"
},new StopModel()
{
Name="УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name="Държавна печатница ",
Kod="554",
s="1001965"
},new StopModel()
{
Name="Комплекс на БАН ",
Kod="84",
s="1001953"
},new StopModel()
{
Name="Метростанция Цариградско шосе ",
Kod="1017",
s="1001939"
},new StopModel()
{
Name="Корабчето ",
Kod="970",
s="1002252"
},new StopModel()
{
Name=" Горублянско ханче ",
Kod="500",
s="1002278"
},new StopModel()
{
Name=" Моста за резиденция Враня ",
Kod="1090",
s="1002304"
},new StopModel()
{
Name=" Разклона за с.Герман ",
Kod="1426",
s="1002318"
},new StopModel()
{
Name=" РЕЗИДЕНЦИЯ ВРАНЯ ",
Kod="1466",
s="1002348"
},new StopModel()
{
Name=" ОКОЛОВРЪСТЕН ПЪТ ",
Kod="1183",
s="1002368"
},new StopModel()
{
Name=" АВТОРЕМОНТНА БАЗА ",
Kod="49",
s="1002418"
},new StopModel()
{
Name=" Опитна станция ",
Kod="1202",
s="1002438"
},new StopModel()
{
Name=" Фирма СИСТЕН ",
Kod="1653",
s="1002470"
},new StopModel()
{
Name=" УЛ.СИНЧЕЦ ",
Kod="2173",
s="1002508"
},new StopModel()
{
Name=" Ул.Ралица ",
Kod="2359",
s="1002524"
},new StopModel()
{
Name=" СЕЛО ГОРНИ ЛОЗЕН ",
Kod="1523",
s="1002550"
},new StopModel()
{
Name=" Кметство Лозен ",
Kod="952",
s="1002560"
},new StopModel()
{
Name=" СЕЛО ДОЛНИ ЛОЗЕН ",
Kod="1526",
s="1002588"
},}
},new DirectionModel()
{
Name ="село Долни Лозен - Автостанция Гео Милев",
rid="1001629",
Stops=new StopModel[]
{new StopModel()
{
Name="село Долни Лозен",
Kod="1527",
s="1002589"
},new StopModel()
{
Name="Кметство Лозен ",
Kod="961",
s="1002559"
},new StopModel()
{
Name="СЕЛО ГОРНИ ЛОЗЕН ",
Kod="1524",
s="1002549"
},new StopModel()
{
Name="Ул.Ралица ",
Kod="2358",
s="1002527"
},new StopModel()
{
Name="УЛ.СИНЧЕЦ ",
Kod="2172",
s="1002507"
},new StopModel()
{
Name="Фирма СИСТЕН ",
Kod="1652",
s="1002469"
},new StopModel()
{
Name="Опитна станция ",
Kod="1207",
s="1002435"
},new StopModel()
{
Name="АВТОРЕМОНТНА БАЗА ",
Kod="48",
s="1002417"
},new StopModel()
{
Name="ОКОЛОВРЪСТЕН ПЪТ ",
Kod="1184",
s="1002365"
},new StopModel()
{
Name=" РЕЗИДЕНЦИЯ ВРАНЯ ",
Kod="1467",
s="1002345"
},new StopModel()
{
Name=" Разклона за с.Герман ",
Kod="1429",
s="1002317"
},new StopModel()
{
Name=" Моста за резиденция Враня ",
Kod="1091",
s="1002301"
},new StopModel()
{
Name=" ГОРУБЛЯНСКО ХАНЧЕ ",
Kod="499",
s="1002275"
},new StopModel()
{
Name=" Корабчето ",
Kod="971",
s="1002257"
},new StopModel()
{
Name=" Интер Експо Център ",
Kod="1072",
s="1023849"
},new StopModel()
{
Name=" Метростанция Цариградско шосе ",
Kod="1016",
s="1023827"
},new StopModel()
{
Name=" Комплекс на БАН ",
Kod="86",
s="1023838"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="555",
s="1001968"
},new StopModel()
{
Name=" Хермес парк ",
Kod="2593",
s="1001978"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1196",
s="1001988"
},new StopModel()
{
Name=" Площад на авиацията ",
Kod="1260",
s="1002016"
},new StopModel()
{
Name=" Спортна зала Арена Армеец ",
Kod="2615",
s="1002024"
},new StopModel()
{
Name=" СК ЦСКА ",
Kod="1155",
s="1002042"
},new StopModel()
{
Name=" Автостанция Гео Милев ",
Kod="53",
s="1002618"
},}
},}},

new BusModel()
{
Number = "6",
lid = "1000071",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="СЕЛО ГЕРМАН - Автостанция Гео Милев",
rid="1001631",
Stops=new StopModel[]
{new StopModel()
{
Name="СЕЛО ГЕРМАН",
Kod="1517",
s="1011818"
},new StopModel()
{
Name="86-ТИ ПОЩЕНСКИ КЛОН ",
Kod="486",
s="1011799"
},new StopModel()
{
Name="СТАДИОНА ГЕРМАН ",
Kod="1037",
s="1011791"
},new StopModel()
{
Name="В.З.Герман ",
Kod="430",
s="1011773"
},new StopModel()
{
Name="Корията ",
Kod="972",
s="1011749"
},new StopModel()
{
Name="Разклона за с.Герман ",
Kod="1429",
s="1002317"
},new StopModel()
{
Name="Моста за резиденция Враня ",
Kod="1091",
s="1002301"
},new StopModel()
{
Name="ГОРУБЛЯНСКО ХАНЧЕ ",
Kod="499",
s="1002275"
},new StopModel()
{
Name="Корабчето ",
Kod="971",
s="1002257"
},new StopModel()
{
Name=" Интер Експо Център ",
Kod="1072",
s="1023849"
},new StopModel()
{
Name=" Метростанция Цариградско шосе ",
Kod="1016",
s="1023827"
},new StopModel()
{
Name=" Комплекс на БАН ",
Kod="86",
s="1023838"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="555",
s="1001968"
},new StopModel()
{
Name=" Хермес парк ",
Kod="2593",
s="1001978"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1196",
s="1001988"
},new StopModel()
{
Name=" Площад на авиацията ",
Kod="1260",
s="1002016"
},new StopModel()
{
Name=" Спортна зала Арена Армеец ",
Kod="2615",
s="1002024"
},new StopModel()
{
Name=" СК ЦСКА ",
Kod="1155",
s="1002042"
},new StopModel()
{
Name=" Автостанция Гео Милев ",
Kod="53",
s="1002618"
},}
},new DirectionModel()
{
Name ="Автостанция Гео Милев - СЕЛО ГЕРМАН",
rid="1000124",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Гео Милев",
Kod="52",
s="1002619"
},new StopModel()
{
Name="СК ЦСКА ",
Kod="1151",
s="1002037"
},new StopModel()
{
Name="Спортна зала Арена Армеец ",
Kod="2616",
s="1002021"
},new StopModel()
{
Name="Площад на авиацията ",
Kod="1259",
s="1002009"
},new StopModel()
{
Name="УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name="Държавна печатница ",
Kod="554",
s="1001965"
},new StopModel()
{
Name="Комплекс на БАН ",
Kod="84",
s="1001953"
},new StopModel()
{
Name="Метростанция Цариградско шосе ",
Kod="1017",
s="1001939"
},new StopModel()
{
Name="Корабчето ",
Kod="970",
s="1002252"
},new StopModel()
{
Name=" Горублянско ханче ",
Kod="500",
s="1002278"
},new StopModel()
{
Name=" Моста за резиденция Враня ",
Kod="1090",
s="1002304"
},new StopModel()
{
Name=" Разклона за с.Герман ",
Kod="1426",
s="1002318"
},new StopModel()
{
Name=" Корията ",
Kod="973",
s="1011750"
},new StopModel()
{
Name=" В.З.Герман ",
Kod="425",
s="1011772"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="2626",
s="1011778"
},new StopModel()
{
Name=" СТАДИОНА ГЕРМАН ",
Kod="1039",
s="1011794"
},new StopModel()
{
Name=" 86-ТИ ПОЩЕНСКИ КЛОН ",
Kod="487",
s="1011800"
},new StopModel()
{
Name=" СЕЛО ГЕРМАН ",
Kod="1517",
s="1011818"
},}
},}},

new BusModel()
{
Number = "7",
lid = "1000072",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Гара Искър - ЧИТАЛИЩЕ СВЕТЛИНА",
rid="1001204",
Stops=new StopModel[]
{new StopModel()
{
Name="Гара Искър",
Kod="826",
s="1015628"
},new StopModel()
{
Name="Кв. ГараИскър ",
Kod="34",
s="1014274"
},new StopModel()
{
Name="София мед АД ",
Kod="975",
s="1014260"
},new StopModel()
{
Name="Депо Искър ",
Kod="520",
s="1014256"
},new StopModel()
{
Name="ТЕЦ Изток ",
Kod="1750",
s="1014238"
},new StopModel()
{
Name="РАЗКЛОНА ЗА АП ДРУЖБА ",
Kod="1450",
s="1014234"
},new StopModel()
{
Name="БЛ. 501 ж.к. Дружба-2 ",
Kod="226",
s="1004184"
},new StopModel()
{
Name="Горублянско ханче ",
Kod="500",
s="1002278"
},new StopModel()
{
Name="Моста за резиденция Враня ",
Kod="1090",
s="1002304"
},new StopModel()
{
Name=" Разклона за с.Герман ",
Kod="1426",
s="1002318"
},new StopModel()
{
Name=" РЕЗИДЕНЦИЯ ВРАНЯ ",
Kod="1466",
s="1002348"
},new StopModel()
{
Name=" ОКОЛОВРЪСТЕН ПЪТ ",
Kod="1183",
s="1002368"
},new StopModel()
{
Name=" РЕСТОРАНТ ЧЕРНАТА КОТКА ",
Kod="2303",
s="1014114"
},new StopModel()
{
Name=" СТРАННОПРИЕМНИЦАТА ",
Kod="1660",
s="1014174"
},new StopModel()
{
Name=" НАЧАЛО  с. Д.ЛОЗЕН ",
Kod="1121",
s="1014183"
},new StopModel()
{
Name=" село Долни Лозен ",
Kod="1527",
s="1002589"
},new StopModel()
{
Name=" Кметство Лозен ",
Kod="961",
s="1002559"
},new StopModel()
{
Name=" СЕЛО ГОРНИ ЛОЗЕН ",
Kod="1524",
s="1002549"
},new StopModel()
{
Name=" ЧИТАЛИЩЕ СВЕТЛИНА ",
Kod="2414",
s="1025585"
},}
},new DirectionModel()
{
Name ="ЧИТАЛИЩЕ СВЕТЛИНА - Гара Искър",
rid="1000361",
Stops=new StopModel[]
{new StopModel()
{
Name="ЧИТАЛИЩЕ СВЕТЛИНА",
Kod="2414",
s="1025585"
},new StopModel()
{
Name="СЕЛО ГОРНИ ЛОЗЕН ",
Kod="1523",
s="1002550"
},new StopModel()
{
Name="Кметство Лозен ",
Kod="952",
s="1002560"
},new StopModel()
{
Name="СЕЛО ДОЛНИ ЛОЗЕН ",
Kod="2412",
s="1025577"
},new StopModel()
{
Name="НАЧАЛО  с. Д. ЛОЗЕН ",
Kod="2413",
s="1025563"
},new StopModel()
{
Name="СТРАННОПРИЕМНИЦАТА ",
Kod="1150",
s="1025545"
},new StopModel()
{
Name="РЕСТОРАНТ ЧЕРНАТА КОТКА ",
Kod="1261",
s="1025425"
},new StopModel()
{
Name="ОКОЛОВРЪСТЕН ПЪТ ",
Kod="1184",
s="1002365"
},new StopModel()
{
Name="РЕЗИДЕНЦИЯ ВРАНЯ ",
Kod="1467",
s="1002345"
},new StopModel()
{
Name=" Разклона за с.Герман ",
Kod="1429",
s="1002317"
},new StopModel()
{
Name=" Моста за резиденция Враня ",
Kod="1091",
s="1002301"
},new StopModel()
{
Name=" Горубл. ханче ",
Kod="499",
s="1014195"
},new StopModel()
{
Name=" БЛ. 501 ж.к. Дружба-2 ",
Kod="225",
s="1004181"
},new StopModel()
{
Name=" РАЗКЛОНА ЗА АП ДРУЖБА ",
Kod="1449",
s="1014237"
},new StopModel()
{
Name=" ТЕЦ Изток ",
Kod="1749",
s="1014241"
},new StopModel()
{
Name=" Депо Искър ",
Kod="515",
s="1014255"
},new StopModel()
{
Name=" София мед АД ",
Kod="974",
s="1014263"
},new StopModel()
{
Name=" Кв. Гара Искър ",
Kod="33",
s="1014275"
},new StopModel()
{
Name=" Гара Искър ",
Kod="826",
s="1015628"
},}
},}},

new BusModel()
{
Number = "8",
lid = "1000074",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="СЕЛО КРИВИНА - СЕЛО ГЕРМАН",
rid="1000808",
Stops=new StopModel[]
{new StopModel()
{
Name="СЕЛО КРИВИНА",
Kod="1541",
s="1004996"
},new StopModel()
{
Name="ЦЕНТЪРА НА С. КРИВИНА ",
Kod="1232",
s="1005002"
},new StopModel()
{
Name="УЛ. ЛЮЛЯК ",
Kod="2361",
s="1005014"
},new StopModel()
{
Name="УЛ.ГРАДИНА ",
Kod="1078",
s="1005022"
},new StopModel()
{
Name="ПАРКА С. КРИВИНА ",
Kod="714",
s="1005034"
},new StopModel()
{
Name="ПРОМИШЛЕНА ЗОНА КРИВИНА ",
Kod="545",
s="1005040"
},new StopModel()
{
Name="РИТЕКС АД ",
Kod="544",
s="1005058"
},new StopModel()
{
Name="СЕЛО КАЗИЧЕНЕ ",
Kod="1537",
s="1004874"
},new StopModel()
{
Name="КМЕТСТВО КАЗИЧЕНЕ ",
Kod="940",
s="1004880"
},new StopModel()
{
Name=" Ул.Цар Борис ІІІ ",
Kod="2244",
s="1019988"
},new StopModel()
{
Name=" Гара Казичене ",
Kod="455",
s="1019978"
},new StopModel()
{
Name=" КВ.ВИДНИТЕ ",
Kod="820",
s="1004904"
},new StopModel()
{
Name=" КМЕТСТВО КАЗИЧЕНЕ ",
Kod="941",
s="1004879"
},new StopModel()
{
Name=" СЕЛО КАЗИЧЕНЕ ",
Kod="1538",
s="1004873"
},new StopModel()
{
Name=" СТАДИОНА КАЗИЧЕНЕ ",
Kod="1623",
s="1005062"
},new StopModel()
{
Name=" БЕТОНОВ ВЪЗЕЛ КАЗИЧЕНЕ ",
Kod="112",
s="1005078"
},new StopModel()
{
Name=" Промишлена зона Казичене ",
Kod="1702",
s="1005088"
},new StopModel()
{
Name=" МЕСТНОСТ КАЛАЙДЖИЙКАТА ",
Kod="735",
s="1005096"
},new StopModel()
{
Name=" Промишлена зона Бусманци ",
Kod="1640",
s="1005106"
},new StopModel()
{
Name=" КВ. БУСМАНЦИ ",
Kod="816",
s="1005124"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="525",
s="1005134"
},new StopModel()
{
Name=" ТРЪНСКА МАХАЛА ",
Kod="1785",
s="1005148"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР кв. Абдовица ",
Kod="1101",
s="1005156"
},new StopModel()
{
Name=" Гара Искър ",
Kod="825",
s="1014279"
},new StopModel()
{
Name=" Кв. ГараИскър ",
Kod="34",
s="1014274"
},new StopModel()
{
Name=" София мед АД ",
Kod="975",
s="1014260"
},new StopModel()
{
Name=" Депо Искър ",
Kod="520",
s="1014256"
},new StopModel()
{
Name=" ТЕЦ Изток ",
Kod="1750",
s="1014238"
},new StopModel()
{
Name=" РАЗКЛОНА ЗА АП ДРУЖБА ",
Kod="1450",
s="1014234"
},new StopModel()
{
Name=" БЛ. 501 ж.к. Дружба-2 ",
Kod="226",
s="1004184"
},new StopModel()
{
Name=" Горублянско ханче ",
Kod="498",
s="1015623"
},new StopModel()
{
Name=" Ул. Цветна градина ",
Kod="2257",
s="1001833"
},new StopModel()
{
Name=" Кв. Горубляне ",
Kod="831",
s="1001803"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1174",
s="1001769"
},new StopModel()
{
Name=" СТАДИОНА ГЕРМАН ",
Kod="1039",
s="1011794"
},new StopModel()
{
Name=" 86-ТИ ПОЩЕНСКИ КЛОН ",
Kod="487",
s="1011800"
},new StopModel()
{
Name=" СЕЛО ГЕРМАН ",
Kod="1517",
s="1011818"
},}
},new DirectionModel()
{
Name ="СЕЛО ГЕРМАН - СЕЛО КРИВИНА",
rid="1000989",
Stops=new StopModel[]
{new StopModel()
{
Name="СЕЛО ГЕРМАН",
Kod="1517",
s="1011818"
},new StopModel()
{
Name="86-ТИ ПОЩЕНСКИ КЛОН ",
Kod="486",
s="1011799"
},new StopModel()
{
Name="СТАДИОНА ГЕРМАН ",
Kod="1037",
s="1011791"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1182",
s="1001774"
},new StopModel()
{
Name="Кв. Горубляне ",
Kod="830",
s="1001804"
},new StopModel()
{
Name="Ул. Цветна градина ",
Kod="2255",
s="1020113"
},new StopModel()
{
Name="Горублянско ханче ",
Kod="497",
s="1015626"
},new StopModel()
{
Name="БЛ. 501 ж.к. Дружба-2 ",
Kod="225",
s="1004181"
},new StopModel()
{
Name="РАЗКЛОНА ЗА АП ДРУЖБА ",
Kod="1449",
s="1014237"
},new StopModel()
{
Name=" ТЕЦ Изток ",
Kod="1749",
s="1014241"
},new StopModel()
{
Name=" Депо Искър ",
Kod="515",
s="1014255"
},new StopModel()
{
Name=" София мед АД ",
Kod="974",
s="1014263"
},new StopModel()
{
Name=" Кв. Гара Искър ",
Kod="33",
s="1014275"
},new StopModel()
{
Name=" Гара Искър ",
Kod="826",
s="1015628"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР кв. Абдовица ",
Kod="1096",
s="1005155"
},new StopModel()
{
Name=" ТРЪНСКА МАХАЛА ",
Kod="1784",
s="1005147"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="527",
s="1005131"
},new StopModel()
{
Name=" КВ. БУСМАНЦИ ",
Kod="814",
s="1005123"
},new StopModel()
{
Name=" Промишлена зона Бусманци ",
Kod="1641",
s="1005105"
},new StopModel()
{
Name=" МЕСТНОСТ КАЛАЙДЖИЙКАТА ",
Kod="740",
s="1005093"
},new StopModel()
{
Name=" Промишлена зона Казичене ",
Kod="1701",
s="1005089"
},new StopModel()
{
Name=" БЕТОНОВ ВЪЗЕЛ КАЗИЧЕНЕ ",
Kod="111",
s="1005077"
},new StopModel()
{
Name=" СТАДИОНА КАЗИЧЕНЕ ",
Kod="1622",
s="1005061"
},new StopModel()
{
Name=" СЕЛО КАЗИЧЕНЕ ",
Kod="1537",
s="1004874"
},new StopModel()
{
Name=" КМЕТСТВО КАЗИЧЕНЕ ",
Kod="940",
s="1004880"
},new StopModel()
{
Name=" Кв.Видните ",
Kod="819",
s="1004898"
},new StopModel()
{
Name=" Гара Казичене ",
Kod="456",
s="1019979"
},new StopModel()
{
Name=" УЛ. ЦАР БОРИС ІІІ ",
Kod="2243",
s="1019989"
},new StopModel()
{
Name=" КМЕТСТВО КАЗИЧЕНЕ ",
Kod="941",
s="1004879"
},new StopModel()
{
Name=" СЕЛО КАЗИЧЕНЕ ",
Kod="1538",
s="1004873"
},new StopModel()
{
Name=" РИТЕКС АД ",
Kod="543",
s="1005055"
},new StopModel()
{
Name=" ПРОМИШЛЕНА ЗОНА КРИВИНА ",
Kod="548",
s="1005039"
},new StopModel()
{
Name=" ПАРКА С.КРИВИНА ",
Kod="713",
s="1005033"
},new StopModel()
{
Name=" УЛ. ГРАДИНА ",
Kod="1077",
s="1005023"
},new StopModel()
{
Name=" УЛ. ЛЮЛЯК ",
Kod="2360",
s="1005013"
},new StopModel()
{
Name=" ЦЕНТЪРА С. КРИВИНА ",
Kod="1240",
s="1004999"
},new StopModel()
{
Name=" СЕЛО КРИВИНА ",
Kod="1542",
s="1004993"
},}
},}},

new BusModel()
{
Number = "9",
lid = "1000002",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="АВТОБАЗА ИСКЪР - Ул. Ген. Гурко",
rid="1000838",
Stops=new StopModel[]
{new StopModel()
{
Name="АВТОБАЗА ИСКЪР",
Kod="47",
s="1000957"
},new StopModel()
{
Name="БКС СРЕДЕЦ ",
Kod="121",
s="1000950"
},new StopModel()
{
Name="Слатина  БУЛГАРПЛОД ",
Kod="1587",
s="1000936"
},new StopModel()
{
Name="ВТУ Т.Каблешков ",
Kod="2013",
s="1000904"
},new StopModel()
{
Name="Ж.К.СЛАТИНА ",
Kod="689",
s="1000886"
},new StopModel()
{
Name="УЛ.КОСТА ЛУЛЧЕВ ",
Kod="2007",
s="1000876"
},new StopModel()
{
Name="УЛ.НИКОЛАЙ КОПЕРНИК ",
Kod="2061",
s="1000866"
},new StopModel()
{
Name="11-ти пощенски клон ",
Kod="1405",
s="1000858"
},new StopModel()
{
Name="31-во СУЧЕМ ",
Kod="92",
s="1000782"
},new StopModel()
{
Name=" Ул.Калиманци ",
Kod="1972",
s="1000790"
},new StopModel()
{
Name=" УЛ.ОБОРИЩЕ ",
Kod="2074",
s="1000689"
},new StopModel()
{
Name=" УЛ.ЧЕРКОВНА ",
Kod="2259",
s="1000417"
},new StopModel()
{
Name=" 129-то ОУ ",
Kod="2271",
s="1000694"
},new StopModel()
{
Name=" ВОЕННА АКАДЕМИЯ ",
Kod="442",
s="1000393"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1289",
s="1000695"
},new StopModel()
{
Name=" Ул. Ген. Гурко ",
Kod="1903",
s="1000741"
},}
},new DirectionModel()
{
Name ="Ул. Ген. Гурко - АВТОБАЗА ИСКЪР",
rid="1000837",
Stops=new StopModel[]
{new StopModel()
{
Name="Ул. Ген. Гурко",
Kod="1903",
s="1000741"
},new StopModel()
{
Name="СУ Св. Климент Охридски ",
Kod="1697",
s="1000747"
},new StopModel()
{
Name="Военна академия ",
Kod="441",
s="1000750"
},new StopModel()
{
Name="129 -то ОУ ",
Kod="2270",
s="1000408"
},new StopModel()
{
Name="УЛ.ЧЕРКОВНА ",
Kod="2258",
s="1000420"
},new StopModel()
{
Name="Ул.Оборище ",
Kod="2071",
s="1000773"
},new StopModel()
{
Name="Ул.Калиманци ",
Kod="1975",
s="1000791"
},new StopModel()
{
Name="31-во СУЧЕМ ",
Kod="93",
s="1000851"
},new StopModel()
{
Name="11-ти пощенски клон ",
Kod="1404",
s="1000861"
},new StopModel()
{
Name=" УЛ.НИКОЛАЙ КОПЕРНИК ",
Kod="2058",
s="1000869"
},new StopModel()
{
Name=" УЛ.КОСТА ЛУЛЧЕВ ",
Kod="2006",
s="1000877"
},new StopModel()
{
Name=" Ж.к.Слатина ",
Kod="690",
s="1000891"
},new StopModel()
{
Name=" ВТУ Т.Каблешков ",
Kod="2014",
s="1000905"
},new StopModel()
{
Name=" Слатина БУЛГАРПЛОД ",
Kod="1586",
s="1000935"
},new StopModel()
{
Name=" БКС СРЕДЕЦ ",
Kod="120",
s="1000953"
},new StopModel()
{
Name=" АВТОБАЗА ИСКЪР ",
Kod="47",
s="1000957"
},}
},}},

new BusModel()
{
Number = "10",
lid = "1000075",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="КВ. БУСМАНЦИ - КВ. ДИМИТЪР МИЛЕНКОВ",
rid="1000680",
Stops=new StopModel[]
{new StopModel()
{
Name="КВ. БУСМАНЦИ",
Kod="815",
s="1021085"
},new StopModel()
{
Name="ДЕТСКИ ДОМ ",
Kod="525",
s="1005134"
},new StopModel()
{
Name="ТРЪНСКА МАХАЛА ",
Kod="1785",
s="1005148"
},new StopModel()
{
Name="МОСТА НА р. ИСКЪР кв. Абдовица ",
Kod="1101",
s="1005156"
},new StopModel()
{
Name="Център кв. Абдовица ",
Kod="2338",
s="1021090"
},new StopModel()
{
Name="кв. Абдовица ",
Kod="802",
s="1021091"
},new StopModel()
{
Name="Център кв. Абдовица ",
Kod="2339",
s="1021092"
},new StopModel()
{
Name="Ул.5010 ",
Kod="2478",
s="1027291"
},new StopModel()
{
Name="Ул.Поручик Христо Топракчиев ",
Kod="723",
s="1021184"
},new StopModel()
{
Name=" Ул.5007 ",
Kod="721",
s="1021192"
},new StopModel()
{
Name=" Ул.Подп.Йордан Тодоров ",
Kod="1745",
s="1021200"
},new StopModel()
{
Name=" ТЮФ ",
Kod="1577",
s="1021212"
},new StopModel()
{
Name=" Технотест ",
Kod="90",
s="1016478"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1451",
s="1012063"
},new StopModel()
{
Name=" Ж.к.Дружба 1 ",
Kod="604",
s="1012071"
},new StopModel()
{
Name=" Бул.Кръстьо Пастухов ",
Kod="1632",
s="1017056"
},new StopModel()
{
Name=" 28-ми ДКЦ ",
Kod="28",
s="1017046"
},new StopModel()
{
Name=" 28-ми пощенски клон ",
Kod="1406",
s="1012169"
},new StopModel()
{
Name=" Гара Искър ",
Kod="826",
s="1015628"
},new StopModel()
{
Name=" Начало кв. Миленков ",
Kod="1348",
s="1021264"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="488",
s="1021280"
},new StopModel()
{
Name=" КВ. ДИМИТЪР МИЛЕНКОВ ",
Kod="833",
s="1021241"
},}
},new DirectionModel()
{
Name ="КВ. ДИМИТЪР МИЛЕНКОВ - КВ. БУСМАНЦИ",
rid="1000681",
Stops=new StopModel[]
{new StopModel()
{
Name="КВ. ДИМИТЪР МИЛЕНКОВ",
Kod="833",
s="1021241"
},new StopModel()
{
Name="Промишлена зона ",
Kod="489",
s="1021279"
},new StopModel()
{
Name="Начало кв. Д.Миленков ",
Kod="1349",
s="1021263"
},new StopModel()
{
Name="Гара Искър ",
Kod="825",
s="1014279"
},new StopModel()
{
Name="28-ми пощенски клон ",
Kod="1411",
s="1017037"
},new StopModel()
{
Name="28-ми ДКЦ ",
Kod="25",
s="1017051"
},new StopModel()
{
Name="Бул. Кръстьо Пастухов ",
Kod="1629",
s="1012078"
},new StopModel()
{
Name="Ж.к.Дружба 1 ",
Kod="608",
s="1012068"
},new StopModel()
{
Name="Разклона за летището ",
Kod="1452",
s="1016465"
},new StopModel()
{
Name=" Технотест ",
Kod="89",
s="1021218"
},new StopModel()
{
Name=" ТЮФ ",
Kod="1578",
s="1021211"
},new StopModel()
{
Name=" Ул.Пподпор.Йордан Тодоров ",
Kod="1744",
s="1021197"
},new StopModel()
{
Name=" Ул.5007 ",
Kod="722",
s="1021191"
},new StopModel()
{
Name=" Ул.Поручик Христо Топракчиев ",
Kod="724",
s="1021183"
},new StopModel()
{
Name=" Ул.5010 ",
Kod="2479",
s="1027282"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР кв. Абдовица ",
Kod="1096",
s="1021093"
},new StopModel()
{
Name=" Център кв. Абдовица ",
Kod="2338",
s="1021090"
},new StopModel()
{
Name=" кв. Абдовица ",
Kod="802",
s="1021091"
},new StopModel()
{
Name=" Център кв. Абдовица ",
Kod="2339",
s="1021092"
},new StopModel()
{
Name=" ТРЪНСКА МАХАЛА ",
Kod="1784",
s="1005147"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="527",
s="1005131"
},new StopModel()
{
Name=" КВ. БУСМАНЦИ ",
Kod="815",
s="1021085"
},}
},}},

new BusModel()
{
Number = "11",
lid = "1000004",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к. Овча купел 2 - Автостанция Гео Милев",
rid="1000094",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Овча купел 2",
Kod="684",
s="1020574"
},new StopModel()
{
Name="Пазара Овча купел ",
Kod="1706",
s="1003211"
},new StopModel()
{
Name="Бл. 25 ж.к. Овча купел 2 ",
Kod="174",
s="1003183"
},new StopModel()
{
Name="Бл. 32 ж.к. Овча купел 2 ",
Kod="191",
s="1003175"
},new StopModel()
{
Name="Ул. Промишлена ",
Kod="2140",
s="1003167"
},new StopModel()
{
Name="Търговски ц-р Овча купел ",
Kod="211",
s="1003155"
},new StopModel()
{
Name="Бл. 519 ж.к. Овча купел 1 ",
Kod="229",
s="1003141"
},new StopModel()
{
Name="ОЦ Овча купел ",
Kod="1219",
s="1003129"
},new StopModel()
{
Name="Ул. Лиляче ",
Kod="2030",
s="1003109"
},new StopModel()
{
Name=" Бул. Овча купел ",
Kod="352",
s="1003095"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="566",
s="1003071"
},new StopModel()
{
Name=" Ж.к.Красна поляна ",
Kod="631",
s="1003057"
},new StopModel()
{
Name=" Ул.Добротич ",
Kod="1931",
s="1003045"
},new StopModel()
{
Name=" Бул.Вардар ",
Kod="293",
s="1000510"
},new StopModel()
{
Name=" Бул.Възкресение ",
Kod="307",
s="1000228"
},new StopModel()
{
Name=" Парк Св.Св.Петър и Павел ",
Kod="1250",
s="1002931"
},new StopModel()
{
Name=" Метростанция К. Величков ",
Kod="1052",
s="1002911"
},new StopModel()
{
Name=" Ул. Цар Симеон ",
Kod="2247",
s="1002899"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2087",
s="1002851"
},new StopModel()
{
Name=" Бул.Христо Ботев ",
Kod="385",
s="1002839"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1278",
s="1002825"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1316",
s="1002791"
},new StopModel()
{
Name=" Ул.Бяло море ",
Kod="1859",
s="1002775"
},new StopModel()
{
Name=" Театър София ",
Kod="1728",
s="1001056"
},new StopModel()
{
Name=" Гара Подуяне ",
Kod="466",
s="1000448"
},new StopModel()
{
Name=" УЛ.ВЕЛЧО АТАНАСОВ ",
Kod="1867",
s="1001166"
},new StopModel()
{
Name=" УЛ.БОЯН МАГЕСНИК ",
Kod="1846",
s="1001172"
},new StopModel()
{
Name=" 109 ОУ ",
Kod="118",
s="1001178"
},new StopModel()
{
Name=" 148 СОУ ",
Kod="150",
s="1001180"
},new StopModel()
{
Name=" Ж.к.Слатина ",
Kod="687",
s="1002627"
},new StopModel()
{
Name=" Автостанция Гео Милев ",
Kod="52",
s="1002619"
},}
},new DirectionModel()
{
Name ="Автостанция Гео Милев - Ж.к. Овча купел 2",
rid="1000093",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Гео Милев",
Kod="53",
s="1002618"
},new StopModel()
{
Name="ж.к. Слатина ",
Kod="688",
s="1001183"
},new StopModel()
{
Name="148 СОУ ",
Kod="149",
s="1001179"
},new StopModel()
{
Name="109 ОУ ",
Kod="119",
s="1001175"
},new StopModel()
{
Name="УЛ.БОЯН МАГЕСНИК ",
Kod="1847",
s="1001171"
},new StopModel()
{
Name="УЛ.ВЕЛЧО АТАНАСОВ ",
Kod="1866",
s="1000461"
},new StopModel()
{
Name="Гара Подуене ",
Kod="471",
s="1001275"
},new StopModel()
{
Name="Театър София ",
Kod="1725",
s="1002632"
},new StopModel()
{
Name="Ул.Бяло море ",
Kod="1857",
s="1002778"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1314",
s="1002794"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1311",
s="1002810"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1275",
s="1002828"
},new StopModel()
{
Name=" Бул. Христо Ботев ",
Kod="382",
s="1002844"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2082",
s="1002858"
},new StopModel()
{
Name=" Ул. Цар Симеон ",
Kod="2252",
s="1002902"
},new StopModel()
{
Name=" Метростанция К. Величков ",
Kod="1053",
s="1002914"
},new StopModel()
{
Name=" Парк Св. Св. Петър и Павел ",
Kod="1249",
s="1002934"
},new StopModel()
{
Name=" Бул.Възкресение ",
Kod="304",
s="1000227"
},new StopModel()
{
Name=" Бул.Вардар ",
Kod="292",
s="1000505"
},new StopModel()
{
Name=" Ул.Добротич ",
Kod="1934",
s="1003050"
},new StopModel()
{
Name=" Ж.к.Красна поляна ",
Kod="635",
s="1003060"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="565",
s="1003074"
},new StopModel()
{
Name=" Бул. Овча купел ",
Kod="351",
s="1003096"
},new StopModel()
{
Name=" Ул. Лиляче ",
Kod="2029",
s="1003114"
},new StopModel()
{
Name=" ОЦ Овча купел ",
Kod="1218",
s="1003134"
},new StopModel()
{
Name=" Бл. 519 ж.к. Овча купел 1 ",
Kod="230",
s="1003142"
},new StopModel()
{
Name=" Търговски ц-р Овча купел ",
Kod="212",
s="1003158"
},new StopModel()
{
Name=" Ул. Промишлена ",
Kod="2141",
s="1003170"
},new StopModel()
{
Name=" Бл. 32 ж.к. Овча купел 2 ",
Kod="192",
s="1003178"
},new StopModel()
{
Name=" Бл. 25 ж.к. Овча купел 2 ",
Kod="175",
s="1003186"
},new StopModel()
{
Name=" Пазара Овча купел ",
Kod="1708",
s="1003212"
},new StopModel()
{
Name=" Ж.к. Овча купел 2 ",
Kod="682",
s="1020575"
},}
},}},

new BusModel()
{
Number = "12",
lid = "1000038",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Село Долни Богров - Автостанция Изток",
rid="1001055",
Stops=new StopModel[]
{new StopModel()
{
Name="Село Долни Богров",
Kod="1525",
s="1021291"
},new StopModel()
{
Name="Кметство Долни Богров ",
Kod="954",
s="1021290"
},new StopModel()
{
Name="Моста с. Долни Богров ",
Kod="1479",
s="1021306"
},new StopModel()
{
Name="Разклона за Д. Богров ",
Kod="2512",
s="1027625"
},new StopModel()
{
Name="Езерото ",
Kod="1659",
s="1017836"
},new StopModel()
{
Name="Кантона ",
Kod="787",
s="1004642"
},new StopModel()
{
Name="Махала Батареята ",
Kod="1648",
s="1004616"
},new StopModel()
{
Name="МОСТА НА р. ИСКЪР кв. Враждебна ",
Kod="2439",
s="1004594"
},new StopModel()
{
Name="Площада кв. Враждебна ",
Kod="1338",
s="1004572"
},new StopModel()
{
Name=" кв. Враждебна ",
Kod="824",
s="1004548"
},new StopModel()
{
Name=" Моста кв.Враждебна ",
Kod="1093",
s="1004532"
},new StopModel()
{
Name=" Ул.3 ",
Kod="1795",
s="1004512"
},new StopModel()
{
Name=" ул.61 ",
Kod="1811",
s="1004490"
},new StopModel()
{
Name=" Сервиз Изток ",
Kod="1579",
s="1004454"
},new StopModel()
{
Name=" Бл. 11 ж.к. Левски В ",
Kod="131",
s="1004410"
},new StopModel()
{
Name=" Ул. Ст. Доспевски ",
Kod="2181",
s="1022595"
},new StopModel()
{
Name=" Автостанция Изток ",
Kod="2428",
s="1004378"
},}
},new DirectionModel()
{
Name ="Автостанция Изток - Село Долни Богров",
rid="1001054",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Изток",
Kod="2427",
s="1004381"
},new StopModel()
{
Name="Ул. Ст. Доспевски ",
Kod="2180",
s="1004403"
},new StopModel()
{
Name="Бл. 11 ж.к. Левски В ",
Kod="130",
s="1004413"
},new StopModel()
{
Name="Сервиз Изток ",
Kod="1582",
s="1004469"
},new StopModel()
{
Name="Ул.61 ",
Kod="1812",
s="1004491"
},new StopModel()
{
Name="Ул.3 ",
Kod="1794",
s="1004515"
},new StopModel()
{
Name="Моста кв. Враждебна ",
Kod="1092",
s="1004533"
},new StopModel()
{
Name="Кв. Враждебна ",
Kod="823",
s="1004549"
},new StopModel()
{
Name="Площада кв. Враждебна ",
Kod="1341",
s="1004583"
},new StopModel()
{
Name=" моста на р.Искър кв.Враждебна ",
Kod="2440",
s="1004597"
},new StopModel()
{
Name=" Махала Батареята ",
Kod="1649",
s="1004615"
},new StopModel()
{
Name=" КАНТОНА ",
Kod="788",
s="1004643"
},new StopModel()
{
Name=" Езерото ",
Kod="1658",
s="1017833"
},new StopModel()
{
Name=" Разклон за Д.Богров ",
Kod="1212",
s="1017805"
},new StopModel()
{
Name=" Моста с.Долни Богров ",
Kod="1478",
s="1021287"
},new StopModel()
{
Name=" Кметство Долни Богров ",
Kod="953",
s="1021289"
},new StopModel()
{
Name=" Село Долни Богров ",
Kod="1525",
s="1021291"
},}
},}},

new BusModel()
{
Number = "14",
lid = "1000076",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Изток - Гара Искър",
rid="1001102",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Изток",
Kod="2427",
s="1004381"
},new StopModel()
{
Name="Ул. Ст. Доспевски ",
Kod="2180",
s="1004403"
},new StopModel()
{
Name="Бл. 11 ж.к. Левски В ",
Kod="130",
s="1004413"
},new StopModel()
{
Name="Сервиз Изток ",
Kod="1582",
s="1004469"
},new StopModel()
{
Name="Ул.61 ",
Kod="1812",
s="1004491"
},new StopModel()
{
Name="Ул.3 ",
Kod="1794",
s="1004515"
},new StopModel()
{
Name="Моста кв. Враждебна ",
Kod="1092",
s="1004533"
},new StopModel()
{
Name="Кв. Враждебна ",
Kod="823",
s="1004549"
},new StopModel()
{
Name="Площада кв. Враждебна ",
Kod="1341",
s="1004583"
},new StopModel()
{
Name=" моста на р.Искър кв.Враждебна ",
Kod="2440",
s="1004597"
},new StopModel()
{
Name=" Махала Батареята ",
Kod="1649",
s="1004615"
},new StopModel()
{
Name=" Кантона ",
Kod="793",
s="1004908"
},new StopModel()
{
Name=" Работилницата ",
Kod="1437",
s="1004942"
},new StopModel()
{
Name=" По желание - Нова махала ",
Kod="2523",
s="1004950"
},new StopModel()
{
Name=" Нова Враждебна ",
Kod="1145",
s="1004960"
},new StopModel()
{
Name=" По желание ",
Kod="2510",
s="1004970"
},new StopModel()
{
Name=" ул. Зад село ",
Kod="1142",
s="1004986"
},new StopModel()
{
Name=" СЕЛО КРИВИНА ",
Kod="1541",
s="1004996"
},new StopModel()
{
Name=" ЦЕНТЪРА НА С. КРИВИНА ",
Kod="1232",
s="1005002"
},new StopModel()
{
Name=" УЛ. ЛЮЛЯК ",
Kod="2361",
s="1005014"
},new StopModel()
{
Name=" УЛ.ГРАДИНА ",
Kod="1078",
s="1005022"
},new StopModel()
{
Name=" ПАРКА С. КРИВИНА ",
Kod="714",
s="1005034"
},new StopModel()
{
Name=" ПРОМИШЛЕНА ЗОНА КРИВИНА ",
Kod="545",
s="1005040"
},new StopModel()
{
Name=" РИТЕКС АД ",
Kod="544",
s="1005058"
},new StopModel()
{
Name=" СЕЛО КАЗИЧЕНЕ ",
Kod="1537",
s="1004874"
},new StopModel()
{
Name=" КМЕТСТВО КАЗИЧЕНЕ ",
Kod="940",
s="1004880"
},new StopModel()
{
Name=" Кв.Видните ",
Kod="819",
s="1004898"
},new StopModel()
{
Name=" КВ.ВИДНИТЕ ",
Kod="820",
s="1004904"
},new StopModel()
{
Name=" КМЕТСТВО КАЗИЧЕНЕ ",
Kod="941",
s="1004879"
},new StopModel()
{
Name=" СЕЛО КАЗИЧЕНЕ ",
Kod="1538",
s="1004873"
},new StopModel()
{
Name=" СТАДИОНА КАЗИЧЕНЕ ",
Kod="1623",
s="1005062"
},new StopModel()
{
Name=" БЕТОНОВ ВЪЗЕЛ КАЗИЧЕНЕ ",
Kod="112",
s="1005078"
},new StopModel()
{
Name=" Промишлена зона Казичене ",
Kod="1702",
s="1005088"
},new StopModel()
{
Name=" МЕСТНОСТ КАЛАЙДЖИЙКАТА ",
Kod="735",
s="1005096"
},new StopModel()
{
Name=" Промишлена зона Бусманци ",
Kod="1640",
s="1005106"
},new StopModel()
{
Name=" КВ. БУСМАНЦИ ",
Kod="816",
s="1005124"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="525",
s="1005134"
},new StopModel()
{
Name=" ТРЪНСКА МАХАЛА ",
Kod="1785",
s="1005148"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР кв. Абдовица ",
Kod="1101",
s="1005156"
},new StopModel()
{
Name=" Гара Искър ",
Kod="825",
s="1014279"
},}
},new DirectionModel()
{
Name ="Гара Искър - Автостанция Изток",
rid="1001103",
Stops=new StopModel[]
{new StopModel()
{
Name="Гара Искър",
Kod="825",
s="1014279"
},new StopModel()
{
Name="МОСТА НА р. ИСКЪР кв. Абдовица ",
Kod="1096",
s="1005155"
},new StopModel()
{
Name="ТРЪНСКА МАХАЛА ",
Kod="1784",
s="1005147"
},new StopModel()
{
Name="ДЕТСКИ ДОМ ",
Kod="527",
s="1005131"
},new StopModel()
{
Name="КВ. БУСМАНЦИ ",
Kod="814",
s="1005123"
},new StopModel()
{
Name="Промишлена зона Бусманци ",
Kod="1641",
s="1005105"
},new StopModel()
{
Name="МЕСТНОСТ КАЛАЙДЖИЙКАТА ",
Kod="740",
s="1005093"
},new StopModel()
{
Name="Промишлена зона Казичене ",
Kod="1701",
s="1005089"
},new StopModel()
{
Name="БЕТОНОВ ВЪЗЕЛ КАЗИЧЕНЕ ",
Kod="111",
s="1005077"
},new StopModel()
{
Name=" СТАДИОНА КАЗИЧЕНЕ ",
Kod="1622",
s="1005061"
},new StopModel()
{
Name=" СЕЛО КАЗИЧЕНЕ ",
Kod="1537",
s="1004874"
},new StopModel()
{
Name=" КМЕТСТВО КАЗИЧЕНЕ ",
Kod="940",
s="1004880"
},new StopModel()
{
Name=" Кв.Видните ",
Kod="819",
s="1004898"
},new StopModel()
{
Name=" КВ.ВИДНИТЕ ",
Kod="820",
s="1004904"
},new StopModel()
{
Name=" КМЕТСТВО КАЗИЧЕНЕ ",
Kod="941",
s="1004879"
},new StopModel()
{
Name=" СЕЛО КАЗИЧЕНЕ ",
Kod="1538",
s="1004873"
},new StopModel()
{
Name=" РИТЕКС АД ",
Kod="543",
s="1005055"
},new StopModel()
{
Name=" ПРОМИШЛЕНА ЗОНА КРИВИНА ",
Kod="548",
s="1005039"
},new StopModel()
{
Name=" ПАРКА С.КРИВИНА ",
Kod="713",
s="1005033"
},new StopModel()
{
Name=" УЛ. ГРАДИНА ",
Kod="1077",
s="1005023"
},new StopModel()
{
Name=" УЛ. ЛЮЛЯК ",
Kod="2360",
s="1005013"
},new StopModel()
{
Name=" ЦЕНТЪРА С. КРИВИНА ",
Kod="1240",
s="1004999"
},new StopModel()
{
Name=" СЕЛО КРИВИНА ",
Kod="1542",
s="1004993"
},new StopModel()
{
Name=" ул. Зад село ",
Kod="1143",
s="1004983"
},new StopModel()
{
Name=" По желание ",
Kod="2511",
s="1004969"
},new StopModel()
{
Name=" Нова Враждебна ",
Kod="1144",
s="1004959"
},new StopModel()
{
Name=" По желание - Нова махала ",
Kod="2522",
s="1004949"
},new StopModel()
{
Name=" Работилницата ",
Kod="1436",
s="1004939"
},new StopModel()
{
Name=" Кантона ",
Kod="2441",
s="1004905"
},new StopModel()
{
Name=" КАНТОНА ",
Kod="788",
s="1004643"
},new StopModel()
{
Name=" Кантона ",
Kod="787",
s="1004642"
},new StopModel()
{
Name=" Махала Батареята ",
Kod="1648",
s="1004616"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР кв. Враждебна ",
Kod="2439",
s="1004594"
},new StopModel()
{
Name=" Площада кв. Враждебна ",
Kod="1338",
s="1004572"
},new StopModel()
{
Name=" кв. Враждебна ",
Kod="824",
s="1004548"
},new StopModel()
{
Name=" Моста кв.Враждебна ",
Kod="1093",
s="1004532"
},new StopModel()
{
Name=" Ул.3 ",
Kod="1795",
s="1004512"
},new StopModel()
{
Name=" ул.61 ",
Kod="1811",
s="1004490"
},new StopModel()
{
Name=" Сервиз Изток ",
Kod="1579",
s="1004454"
},new StopModel()
{
Name=" Бл. 11 ж.к. Левски В ",
Kod="131",
s="1004410"
},new StopModel()
{
Name=" Ул. Ст. Доспевски ",
Kod="2181",
s="1022595"
},new StopModel()
{
Name=" Автостанция Изток ",
Kod="2428",
s="1004378"
},}
},}},

new BusModel()
{
Number = "18",
lid = "1000041",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Станция Орландовци - Мелницата Чепинци",
rid="1000174",
Stops=new StopModel[]
{new StopModel()
{
Name="Станция Орландовци",
Kod="63",
s="1005678"
},new StopModel()
{
Name="Кв. Малашевци ",
Kod="862",
s="1005911"
},new StopModel()
{
Name="Моста на Владайска река ",
Kod="1095",
s="1005893"
},new StopModel()
{
Name="Гробищен парк Малашевци ",
Kod="1147",
s="1005869"
},new StopModel()
{
Name="Ул. Чепинско шосе ",
Kod="920",
s="1005855"
},new StopModel()
{
Name="Птицефермата ",
Kod="1420",
s="1005847"
},new StopModel()
{
Name="Промишлена зона ",
Kod="1654",
s="1005831"
},new StopModel()
{
Name="Петте могили ",
Kod="1262",
s="1005813"
},new StopModel()
{
Name="Моста на р. Искър ",
Kod="1100",
s="1005797"
},new StopModel()
{
Name=" Опитна станция ",
Kod="1206",
s="1005779"
},new StopModel()
{
Name=" ЗЕЛЕНЧУКОВА ГРАДИНА ",
Kod="739",
s="1005771"
},new StopModel()
{
Name=" Кариерни материали АД ",
Kod="1359",
s="1005741"
},new StopModel()
{
Name=" СЕЛО ЧЕПИНЦИ ",
Kod="1563",
s="1005727"
},new StopModel()
{
Name=" Пл. Витоша ",
Kod="2363",
s="1005715"
},new StopModel()
{
Name=" Ул. Надежда ",
Kod="1222",
s="1005705"
},new StopModel()
{
Name=" Мелницата Чепинци ",
Kod="1038",
s="1005921"
},}
},new DirectionModel()
{
Name ="Мелницата Чепинци - Станция Орландовци",
rid="1000176",
Stops=new StopModel[]
{new StopModel()
{
Name="Мелницата Чепинци",
Kod="1038",
s="1005921"
},new StopModel()
{
Name="Ул. Надежда ",
Kod="1223",
s="1005706"
},new StopModel()
{
Name="Пл. Витоша ",
Kod="2362",
s="1005716"
},new StopModel()
{
Name="Кариерни материали АД ",
Kod="1358",
s="1005744"
},new StopModel()
{
Name="ЗЕЛЕНЧУКОВА ГРАДИНА ",
Kod="738",
s="1005772"
},new StopModel()
{
Name="Опитна станция ",
Kod="1205",
s="1005780"
},new StopModel()
{
Name="Моста на р. Искър ",
Kod="1099",
s="1020068"
},new StopModel()
{
Name="Петте могили ",
Kod="1263",
s="1005816"
},new StopModel()
{
Name="Промишлена зона ",
Kod="1655",
s="1005832"
},new StopModel()
{
Name=" Птицефермата ",
Kod="1421",
s="1005848"
},new StopModel()
{
Name=" Ул. Чепинско шосе ",
Kod="921",
s="1005860"
},new StopModel()
{
Name=" Гробищен парк Малашевци ",
Kod="1146",
s="1005870"
},new StopModel()
{
Name=" Моста на  Владайска река ",
Kod="1094",
s="1005892"
},new StopModel()
{
Name=" Кв. Малашевци ",
Kod="863",
s="1005912"
},new StopModel()
{
Name=" Станция Орландовци ",
Kod="63",
s="1025856"
},}
},}},

new BusModel()
{
Number = "20",
lid = "1000040",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Село Локорско - Станция Орландовци",
rid="1000275",
Stops=new StopModel[]
{new StopModel()
{
Name="Село Локорско",
Kod="1546",
s="1006249"
},new StopModel()
{
Name="Ул. Веско Веселинов ",
Kod="1667",
s="1006235"
},new StopModel()
{
Name="Начало с. Локорско ",
Kod="979",
s="1006229"
},new StopModel()
{
Name="Горско стопанство ",
Kod="496",
s="1006195"
},new StopModel()
{
Name="Гара Чепинци ",
Kod="696",
s="1006165"
},new StopModel()
{
Name="160-ОУ, с.Чепинци ",
Kod="2287",
s="1006155"
},new StopModel()
{
Name="Село Чепинци ",
Kod="1565",
s="1010136"
},new StopModel()
{
Name="Ул. Орфей ",
Kod="2094",
s="1006129"
},new StopModel()
{
Name="Гробищен парк Негован ",
Kod="508",
s="1006101"
},new StopModel()
{
Name=" с.Негован ",
Kod="1554",
s="1006095"
},new StopModel()
{
Name=" Ел. кантон ",
Kod="560",
s="1006073"
},new StopModel()
{
Name=" Зеленчукова градина ",
Kod="736",
s="1006057"
},new StopModel()
{
Name=" Опитна станция ",
Kod="1203",
s="1006043"
},new StopModel()
{
Name=" Моста на р. Искър ",
Kod="1099",
s="1020068"
},new StopModel()
{
Name=" Петте могили ",
Kod="1263",
s="1005816"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1655",
s="1005832"
},new StopModel()
{
Name=" Птицефермата ",
Kod="1421",
s="1005848"
},new StopModel()
{
Name=" Ул. Чепинско шосе ",
Kod="921",
s="1005860"
},new StopModel()
{
Name=" Гробищен парк Малашевци ",
Kod="1146",
s="1005870"
},new StopModel()
{
Name=" Моста на  Владайска река ",
Kod="1094",
s="1005892"
},new StopModel()
{
Name=" Кв. Малашевци ",
Kod="863",
s="1005912"
},new StopModel()
{
Name=" Станция Орландовци ",
Kod="63",
s="1025856"
},}
},new DirectionModel()
{
Name ="Станция Орландовци - Село Локорско",
rid="1000029",
Stops=new StopModel[]
{new StopModel()
{
Name="Станция Орландовци",
Kod="63",
s="1005678"
},new StopModel()
{
Name="Кв. Малашевци ",
Kod="862",
s="1005911"
},new StopModel()
{
Name="Моста на Владайска река ",
Kod="1095",
s="1005893"
},new StopModel()
{
Name="Гробищен парк Малашевци ",
Kod="1147",
s="1005869"
},new StopModel()
{
Name="Ул. Чепинско шосе ",
Kod="920",
s="1005855"
},new StopModel()
{
Name="Птицефермата ",
Kod="1420",
s="1005847"
},new StopModel()
{
Name="Промишлена зона ",
Kod="1654",
s="1005831"
},new StopModel()
{
Name="Петте могили ",
Kod="1262",
s="1005813"
},new StopModel()
{
Name="Моста на р. Искър ",
Kod="1100",
s="1005797"
},new StopModel()
{
Name=" Опитна станция ",
Kod="1204",
s="1006044"
},new StopModel()
{
Name=" Зеленчукова градина ",
Kod="737",
s="1006058"
},new StopModel()
{
Name=" Ел. кантон ",
Kod="561",
s="1006074"
},new StopModel()
{
Name=" Село Негован ",
Kod="1555",
s="1006090"
},new StopModel()
{
Name=" Гробищен парк Негован ",
Kod="507",
s="1006102"
},new StopModel()
{
Name=" Ул. Орфей ",
Kod="2095",
s="1006130"
},new StopModel()
{
Name=" Село Чепинци ",
Kod="1562",
s="1020078"
},new StopModel()
{
Name=" Ул. Училищна ",
Kod="2286",
s="1006152"
},new StopModel()
{
Name=" 160-то ОУ,с.Чепинци ",
Kod="2288",
s="1006156"
},new StopModel()
{
Name=" Гара Чепинци ",
Kod="695",
s="1006166"
},new StopModel()
{
Name=" Горско стопанство ",
Kod="495",
s="1006196"
},new StopModel()
{
Name=" Начало с. Локорско ",
Kod="978",
s="1006230"
},new StopModel()
{
Name=" Ул. Веско Веселинов ",
Kod="1668",
s="1006236"
},new StopModel()
{
Name=" Село Локорско ",
Kod="1546",
s="1006249"
},}
},}},

new BusModel()
{
Number = "22",
lid = "1000043",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Село Войняговци - Автостанция Орландовци",
rid="1000022",
Stops=new StopModel[]
{new StopModel()
{
Name="Село Войняговци",
Kod="1516",
s="1007267"
},new StopModel()
{
Name="Център с. Войнеговци ",
Kod="2341",
s="1007257"
},new StopModel()
{
Name="Начало с.Войнеговци ",
Kod="1647",
s="1007247"
},new StopModel()
{
Name="По желание ",
Kod="1366",
s="1007227"
},new StopModel()
{
Name="ул. Тракийска могила ",
Kod="1766",
s="1006886"
},new StopModel()
{
Name="село Световрачане ",
Kod="1559",
s="1006900"
},new StopModel()
{
Name="177-мо ОУ с. Световрачане ",
Kod="2281",
s="1025039"
},new StopModel()
{
Name="Ул.Синчец ",
Kod="482",
s="1006912"
},new StopModel()
{
Name="Село Кубратово ",
Kod="1544",
s="1006970"
},new StopModel()
{
Name=" Ул.Кирил Христов ",
Kod="1990",
s="1006984"
},new StopModel()
{
Name=" Пречиствателна станция ",
Kod="1415",
s="1007032"
},new StopModel()
{
Name=" Обрадовски път ",
Kod="2387",
s="1007044"
},new StopModel()
{
Name=" Кв. Бенковски ",
Kod="805",
s="1007056"
},new StopModel()
{
Name=" 60-то ОУ кв. Бенковски ",
Kod="40",
s="1007068"
},new StopModel()
{
Name=" Пл. Биримирци ",
Kod="1267",
s="1007084"
},new StopModel()
{
Name=" Ж.п. прелез ",
Kod="710",
s="1007100"
},new StopModel()
{
Name=" Сервиз Полмо ",
Kod="1585",
s="1007112"
},new StopModel()
{
Name=" Ул. Одеса ",
Kod="2356",
s="1007122"
},new StopModel()
{
Name=" Ул. Пощенска ",
Kod="46",
s="1007134"
},new StopModel()
{
Name=" Кв. Орландовци ",
Kod="884",
s="1007148"
},new StopModel()
{
Name=" Автостанция Орландовци ",
Kod="62",
s="1025880"
},}
},new DirectionModel()
{
Name ="Автостанция Орландовци - Ул.Стара планина",
rid="1000277",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Орландовци",
Kod="62",
s="1025880"
},new StopModel()
{
Name="кв. Орландовци ",
Kod="887",
s="1007149"
},new StopModel()
{
Name="Ул. Пощенска ",
Kod="45",
s="1007133"
},new StopModel()
{
Name="Ул. Одеса ",
Kod="2355",
s="1007119"
},new StopModel()
{
Name="Сервиз Полмо ",
Kod="1584",
s="1007109"
},new StopModel()
{
Name="Ж.п. прелез ",
Kod="697",
s="1007095"
},new StopModel()
{
Name="Площад Биримирци ",
Kod="1268",
s="1007081"
},new StopModel()
{
Name="60-то ОУ кв. Бенковски ",
Kod="39",
s="1007065"
},new StopModel()
{
Name="Кв. Бенковски ",
Kod="806",
s="1007053"
},new StopModel()
{
Name=" УЛ. ОБРАДОВСКИ ПЪТ ",
Kod="2386",
s="1007043"
},new StopModel()
{
Name=" ПРЕЧИСТВАТЕЛНА СТАНЦИЯ ",
Kod="1412",
s="1007027"
},new StopModel()
{
Name=" УЛ. КИРИЛ ХРИСТОВ ",
Kod="1989",
s="1006981"
},new StopModel()
{
Name=" С.Кубратово ",
Kod="1543",
s="1006971"
},new StopModel()
{
Name=" ул. Синчец ",
Kod="481",
s="1006913"
},new StopModel()
{
Name=" 177 ОУ, с.Световрачане ",
Kod="2282",
s="1006903"
},new StopModel()
{
Name=" Село Световрачане ",
Kod="1557",
s="1006897"
},new StopModel()
{
Name=" ул. Тракийска могила ",
Kod="1765",
s="1006885"
},new StopModel()
{
Name=" По желание ",
Kod="1367",
s="1007228"
},new StopModel()
{
Name=" Начало с. Войнеговци ",
Kod="1646",
s="1007250"
},new StopModel()
{
Name=" Център с. Войнеговци ",
Kod="2340",
s="1007260"
},new StopModel()
{
Name=" Село Войняговци ",
Kod="1516",
s="1007267"
},new StopModel()
{
Name=" Център с. Войнеговци ",
Kod="2341",
s="1007257"
},new StopModel()
{
Name=" Начало с.Войнеговци ",
Kod="1647",
s="1007247"
},new StopModel()
{
Name=" По желание ",
Kod="1366",
s="1007227"
},new StopModel()
{
Name=" Начало с.Подгумер ",
Kod="1679",
s="1006823"
},new StopModel()
{
Name=" ул. Младост ",
Kod="2416",
s="1006817"
},new StopModel()
{
Name=" Център с. Подгумер ",
Kod="2344",
s="1007167"
},new StopModel()
{
Name=" Ул.Стара планина ",
Kod="2183",
s="1007304"
},}
},}},

new BusModel()
{
Number = "23",
lid = "1000045",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Орландовци - ГАРА КУРИЛО",
rid="1001601",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Орландовци",
Kod="62",
s="1025880"
},new StopModel()
{
Name="кв. Орландовци ",
Kod="887",
s="1007149"
},new StopModel()
{
Name="Ул. Пощенска ",
Kod="45",
s="1007133"
},new StopModel()
{
Name="Ул. Одеса ",
Kod="2355",
s="1007119"
},new StopModel()
{
Name="Сервиз Полмо ",
Kod="1584",
s="1007109"
},new StopModel()
{
Name="Ж.п. прелез ",
Kod="697",
s="1007095"
},new StopModel()
{
Name="Площад Биримирци ",
Kod="1268",
s="1007081"
},new StopModel()
{
Name="60-то ОУ кв. Бенковски ",
Kod="39",
s="1007065"
},new StopModel()
{
Name="Кв. Бенковски ",
Kod="806",
s="1007053"
},new StopModel()
{
Name=" УЛ. ОБРАДОВСКИ ПЪТ ",
Kod="2386",
s="1007043"
},new StopModel()
{
Name=" ПРЕЧИСТВАТЕЛНА СТАНЦИЯ ",
Kod="1412",
s="1007027"
},new StopModel()
{
Name=" УЛ. КИРИЛ ХРИСТОВ ",
Kod="1989",
s="1006981"
},new StopModel()
{
Name=" С.Кубратово ",
Kod="1543",
s="1006971"
},new StopModel()
{
Name=" ул. Синчец ",
Kod="481",
s="1006913"
},new StopModel()
{
Name=" 177 ОУ, с.Световрачане ",
Kod="2282",
s="1006903"
},new StopModel()
{
Name=" Село Световрачане ",
Kod="1557",
s="1006897"
},new StopModel()
{
Name=" ул. Тракийска могила ",
Kod="1765",
s="1006885"
},new StopModel()
{
Name=" БАНЯТА кв. Гниляне ",
Kod="99",
s="1008056"
},new StopModel()
{
Name=" НАЧАЛО КВ. ГНИЛЯНЕ ",
Kod="1124",
s="1008066"
},new StopModel()
{
Name=" Кв. Гниляне ",
Kod="827",
s="1008078"
},new StopModel()
{
Name=" Старата чешма ",
Kod="1626",
s="1008086"
},new StopModel()
{
Name=" Ул. Ливадите ",
Kod="2027",
s="1008100"
},new StopModel()
{
Name=" Кв. Изгрев ",
Kod="841",
s="1008108"
},new StopModel()
{
Name=" Каучуков завод ЗЕБРА ",
Kod="798",
s="1008122"
},new StopModel()
{
Name=" ГАРА КУРИЛО ",
Kod="2460",
s="1008152"
},}
},new DirectionModel()
{
Name ="ГАРА КУРИЛО - Автостанция Орландовци",
rid="1001600",
Stops=new StopModel[]
{new StopModel()
{
Name="ГАРА КУРИЛО",
Kod="2460",
s="1008152"
},new StopModel()
{
Name="Поща кв.Курило ",
Kod="1408",
s="1007629"
},new StopModel()
{
Name="Каучуков завод ЗЕБРА ",
Kod="799",
s="1008119"
},new StopModel()
{
Name="Кв. Изгрев ",
Kod="846",
s="1008107"
},new StopModel()
{
Name="Ул. Ливадите ",
Kod="2028",
s="1008099"
},new StopModel()
{
Name="Старата чешма ",
Kod="1627",
s="1008087"
},new StopModel()
{
Name="Кв. Гниляне ",
Kod="828",
s="1008079"
},new StopModel()
{
Name="НАЧАЛО КВ. ГНИЛЯНЕ ",
Kod="1125",
s="1008065"
},new StopModel()
{
Name="БАНЯТА кв. Гниляне ",
Kod="100",
s="1008055"
},new StopModel()
{
Name=" ул. Тракийска могила ",
Kod="1766",
s="1006886"
},new StopModel()
{
Name=" село Световрачане ",
Kod="1559",
s="1006900"
},new StopModel()
{
Name=" 177-мо ОУ с. Световрачане ",
Kod="2281",
s="1025039"
},new StopModel()
{
Name=" Ул.Синчец ",
Kod="482",
s="1006912"
},new StopModel()
{
Name=" Село Кубратово ",
Kod="1544",
s="1006970"
},new StopModel()
{
Name=" Ул.Кирил Христов ",
Kod="1990",
s="1006984"
},new StopModel()
{
Name=" Пречиствателна станция ",
Kod="1415",
s="1007032"
},new StopModel()
{
Name=" Обрадовски път ",
Kod="2387",
s="1007044"
},new StopModel()
{
Name=" Кв. Бенковски ",
Kod="805",
s="1007056"
},new StopModel()
{
Name=" 60-то ОУ кв. Бенковски ",
Kod="40",
s="1007068"
},new StopModel()
{
Name=" Пл. Биримирци ",
Kod="1267",
s="1007084"
},new StopModel()
{
Name=" Ж.п. прелез ",
Kod="710",
s="1007100"
},new StopModel()
{
Name=" Сервиз Полмо ",
Kod="1585",
s="1007112"
},new StopModel()
{
Name=" Ул. Одеса ",
Kod="2356",
s="1007122"
},new StopModel()
{
Name=" Ул. Пощенска ",
Kod="46",
s="1007134"
},new StopModel()
{
Name=" Кв. Орландовци ",
Kod="884",
s="1007148"
},new StopModel()
{
Name=" Автостанция Орландовци ",
Kod="62",
s="1025880"
},}
},}},

new BusModel()
{
Number = "24",
lid = "1000046",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Орландовци - Кв. Бенковски",
rid="1000027",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Орландовци",
Kod="62",
s="1025880"
},new StopModel()
{
Name="кв. Орландовци ",
Kod="887",
s="1007149"
},new StopModel()
{
Name="Ул. Пощенска ",
Kod="45",
s="1007133"
},new StopModel()
{
Name="Ул. Одеса ",
Kod="2355",
s="1007119"
},new StopModel()
{
Name="Сервиз Полмо ",
Kod="1584",
s="1007109"
},new StopModel()
{
Name="Ж.п. прелез ",
Kod="697",
s="1007095"
},new StopModel()
{
Name="Площад Биримирци ",
Kod="1268",
s="1007081"
},new StopModel()
{
Name="60-то ОУ кв. Бенковски ",
Kod="39",
s="1007065"
},new StopModel()
{
Name="Кв. Бенковски ",
Kod="806",
s="1007053"
},}
},new DirectionModel()
{
Name ="Кв. Бенковски - Автостанция Орландовци",
rid="1000028",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Бенковски",
Kod="805",
s="1007056"
},new StopModel()
{
Name="60-то ОУ кв. Бенковски ",
Kod="40",
s="1007068"
},new StopModel()
{
Name="Пл. Биримирци ",
Kod="1267",
s="1007084"
},new StopModel()
{
Name="Ж.п. прелез ",
Kod="710",
s="1007100"
},new StopModel()
{
Name="Сервиз Полмо ",
Kod="1585",
s="1007112"
},new StopModel()
{
Name="Ул. Одеса ",
Kod="2356",
s="1007122"
},new StopModel()
{
Name="Ул. Пощенска ",
Kod="46",
s="1007134"
},new StopModel()
{
Name="Кв. Орландовци ",
Kod="884",
s="1007148"
},new StopModel()
{
Name="Автостанция Орландовци ",
Kod="62",
s="1025880"
},}
},}},

new BusModel()
{
Number = "25",
lid = "1000047",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Илиянци - С. Мировяне",
rid="1001534",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Илиянци",
Kod="58",
s="1007868"
},new StopModel()
{
Name="Начало кв. Требич ",
Kod="1684",
s="1007815"
},new StopModel()
{
Name="Кв. Требич ",
Kod="906",
s="1007803"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1185",
s="1007791"
},new StopModel()
{
Name="Ул.Спортист ",
Kod="1672",
s="1010506"
},new StopModel()
{
Name="С. Мировяне ",
Kod="2617",
s="1010527"
},}
},new DirectionModel()
{
Name ="С. Мировяне - Автостанция Илиянци",
rid="1001444",
Stops=new StopModel[]
{new StopModel()
{
Name="С. Мировяне",
Kod="1549",
s="1010531"
},new StopModel()
{
Name="Ул.Спортист ",
Kod="1671",
s="1010505"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1186",
s="1007794"
},new StopModel()
{
Name="Кв. Требич ",
Kod="905",
s="1007804"
},new StopModel()
{
Name="Начало кв. Требич ",
Kod="1683",
s="1007816"
},new StopModel()
{
Name="Автостанция Илиянци ",
Kod="2608",
s="1007867"
},}
},}},

new BusModel()
{
Number = "26",
lid = "1000048",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Кв. Обеля - Кв. Гниляне",
rid="1001765",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Обеля",
Kod="874",
s="1015706"
},new StopModel()
{
Name="Ул.9 ",
Kod="1815",
s="1006509"
},new StopModel()
{
Name="Ул.2 ",
Kod="1793",
s="1006501"
},new StopModel()
{
Name="Метростанция Обеля ",
Kod="6241",
s="1026043"
},new StopModel()
{
Name="Ж.к. Обеля 2 ",
Kod="678",
s="1008968"
},new StopModel()
{
Name="Бетонов възел ",
Kod="113",
s="1008946"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1187",
s="1008930"
},new StopModel()
{
Name="Мировско шосе ",
Kod="2629",
s="1010522"
},new StopModel()
{
Name="Ул.Спортист ",
Kod="1672",
s="1010506"
},new StopModel()
{
Name=" С. Мировяне ",
Kod="2617",
s="1010527"
},new StopModel()
{
Name=" Ул.Еделвайс ",
Kod="2618",
s="1028394"
},new StopModel()
{
Name=" Ул.Вишновка ",
Kod="2631",
s="1028396"
},new StopModel()
{
Name=" Ул.Крушата ",
Kod="2620",
s="1028446"
},new StopModel()
{
Name=" УЛ. РАВНЕЦ ",
Kod="2150",
s="1007743"
},new StopModel()
{
Name=" КВ. СЛАВОВЦИ ",
Kod="903",
s="1007729"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="529",
s="1007715"
},new StopModel()
{
Name=" КВ. КУМАРИЦА ",
Kod="859",
s="1007705"
},new StopModel()
{
Name=" Община Нови Искър ",
Kod="956",
s="1007693"
},new StopModel()
{
Name=" БАЛКАНКЕРАМИК  АД ",
Kod="924",
s="1007679"
},new StopModel()
{
Name=" УЛ. БЪДЕЩЕ ",
Kod="1850",
s="1007665"
},new StopModel()
{
Name=" УЛ. БАБА ТОНКА ",
Kod="1831",
s="1007653"
},new StopModel()
{
Name=" ГАРА КУРИЛО ",
Kod="457",
s="1007641"
},new StopModel()
{
Name=" Поща кв.Курило ",
Kod="1408",
s="1007629"
},new StopModel()
{
Name=" Каучуков завод ЗЕБРА ",
Kod="799",
s="1008119"
},new StopModel()
{
Name=" Кв. Изгрев ",
Kod="846",
s="1008107"
},new StopModel()
{
Name=" Ул. Ливадите ",
Kod="2028",
s="1008099"
},new StopModel()
{
Name=" Старата чешма ",
Kod="1627",
s="1008087"
},new StopModel()
{
Name=" Кв. Гниляне ",
Kod="828",
s="1008079"
},}
},new DirectionModel()
{
Name ="Кв. Гниляне - Кв. Обеля",
rid="1001764",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Гниляне",
Kod="827",
s="1008078"
},new StopModel()
{
Name="Старата чешма ",
Kod="1626",
s="1008086"
},new StopModel()
{
Name="Ул. Ливадите ",
Kod="2027",
s="1008100"
},new StopModel()
{
Name="Кв. Изгрев ",
Kod="841",
s="1008108"
},new StopModel()
{
Name="Каучуков завод ЗЕБРА ",
Kod="798",
s="1008122"
},new StopModel()
{
Name="Поща кв.Курило ",
Kod="1407",
s="1007628"
},new StopModel()
{
Name="ГАРА КУРИЛО ",
Kod="459",
s="1007640"
},new StopModel()
{
Name="УЛ. БАБА ТОНКА ",
Kod="1832",
s="1007654"
},new StopModel()
{
Name="УЛ. БЪДЕЩЕ ",
Kod="1851",
s="1007668"
},new StopModel()
{
Name=" Балканкерамик АД ",
Kod="925",
s="1007682"
},new StopModel()
{
Name=" Община Нови Искър ",
Kod="955",
s="1007696"
},new StopModel()
{
Name=" КВ. КУМАРИЦА ",
Kod="856",
s="1007702"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="528",
s="1007716"
},new StopModel()
{
Name=" КВ. СЛАВОВЦИ ",
Kod="904",
s="1007732"
},new StopModel()
{
Name=" УЛ. РАВНЕЦ ",
Kod="2151",
s="1007746"
},new StopModel()
{
Name=" Ул.Крушата ",
Kod="2621",
s="1028420"
},new StopModel()
{
Name=" Ул.Вишновка ",
Kod="2632",
s="1028437"
},new StopModel()
{
Name=" Ул.Еделвайс ",
Kod="2619",
s="1028440"
},new StopModel()
{
Name=" С. Мировяне ",
Kod="1549",
s="1010531"
},new StopModel()
{
Name=" Ул.Спортист ",
Kod="1671",
s="1010505"
},new StopModel()
{
Name=" Мировско шосе ",
Kod="2630",
s="1010523"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1188",
s="1008931"
},new StopModel()
{
Name=" Бетонов възел ",
Kod="114",
s="1008947"
},new StopModel()
{
Name=" Ж.к.Обеля 2 ",
Kod="681",
s="1008971"
},new StopModel()
{
Name=" Метростанция Обеля ",
Kod="6240",
s="1028322"
},new StopModel()
{
Name=" Ул.2 ",
Kod="1792",
s="1006502"
},new StopModel()
{
Name=" Ул.9 ",
Kod="1817",
s="1006506"
},new StopModel()
{
Name=" Кв. Обеля ",
Kod="871",
s="1015707"
},}
},}},

new BusModel()
{
Number = "27",
lid = "1000104",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Гара София север - СЕЛО КЪТИНА",
rid="1001684",
Stops=new StopModel[]
{new StopModel()
{
Name="Гара София север",
Kod="2673",
s="1028628"
},new StopModel()
{
Name="Модна къща Агресия ",
Kod="2671",
s="1028634"
},new StopModel()
{
Name="Бул. Рожен ",
Kod="2674",
s="1016110"
},new StopModel()
{
Name="ЗАГ Динамик ",
Kod="725",
s="1016102"
},new StopModel()
{
Name="Софарма АД ",
Kod="746",
s="1016096"
},new StopModel()
{
Name="Стоков базар Илиянци ",
Kod="2456",
s="1026549"
},new StopModel()
{
Name="Хюндай България ",
Kod="1634",
s="1016993"
},new StopModel()
{
Name="Центъра кв. Илиянци ",
Kod="938",
s="1017011"
},new StopModel()
{
Name="Ул.Джерман ",
Kod="2667",
s="1007857"
},new StopModel()
{
Name=" Начало кв. Требич ",
Kod="1684",
s="1007815"
},new StopModel()
{
Name=" Кв. Требич ",
Kod="906",
s="1007803"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1185",
s="1007791"
},new StopModel()
{
Name=" УЛ. РАВНЕЦ ",
Kod="2150",
s="1007743"
},new StopModel()
{
Name=" КВ. СЛАВОВЦИ ",
Kod="903",
s="1007729"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="529",
s="1007715"
},new StopModel()
{
Name=" КВ. КУМАРИЦА ",
Kod="859",
s="1007705"
},new StopModel()
{
Name=" Община Нови Искър ",
Kod="956",
s="1007693"
},new StopModel()
{
Name=" БАЛКАНКЕРАМИК  АД ",
Kod="924",
s="1007679"
},new StopModel()
{
Name=" УЛ. БЪДЕЩЕ ",
Kod="1850",
s="1007665"
},new StopModel()
{
Name=" УЛ. БАБА ТОНКА ",
Kod="1831",
s="1007653"
},new StopModel()
{
Name=" ГАРА КУРИЛО ",
Kod="457",
s="1007641"
},new StopModel()
{
Name=" Поща кв.Курило ",
Kod="1408",
s="1007629"
},new StopModel()
{
Name=" УЛ. ТЕМЕНУГА ",
Kod="2203",
s="1007609"
},new StopModel()
{
Name=" Ул. Мальовица ",
Kod="2538",
s="1007601"
},new StopModel()
{
Name=" СЕПАРАЦИЯТА ",
Kod="1576",
s="1007579"
},new StopModel()
{
Name=" МИНАТА ",
Kod="1069",
s="1007559"
},new StopModel()
{
Name=" НАЧАЛО с. КЪТИНА ",
Kod="1129",
s="1007523"
},new StopModel()
{
Name=" Старата фурна ",
Kod="2296",
s="1007519"
},new StopModel()
{
Name=" СЕЛО КЪТИНА ",
Kod="1545",
s="1007874"
},}
},new DirectionModel()
{
Name ="СЕЛО КЪТИНА - Гара София север",
rid="1001685",
Stops=new StopModel[]
{new StopModel()
{
Name="СЕЛО КЪТИНА",
Kod="1545",
s="1007874"
},new StopModel()
{
Name="Старата фурна ",
Kod="2297",
s="1007520"
},new StopModel()
{
Name="НАЧАЛО с. КЪТИНА ",
Kod="1128",
s="1007526"
},new StopModel()
{
Name="МИНАТА ",
Kod="1066",
s="1007562"
},new StopModel()
{
Name="СЕПАРАЦИЯТА ",
Kod="1575",
s="1007580"
},new StopModel()
{
Name="Ул. Мальовица ",
Kod="2539",
s="1007602"
},new StopModel()
{
Name="УЛ. ТЕМЕНУГА ",
Kod="2200",
s="1007610"
},new StopModel()
{
Name="Поща кв.Курило ",
Kod="1407",
s="1007628"
},new StopModel()
{
Name="ГАРА КУРИЛО ",
Kod="459",
s="1007640"
},new StopModel()
{
Name=" УЛ. БАБА ТОНКА ",
Kod="1832",
s="1007654"
},new StopModel()
{
Name=" УЛ. БЪДЕЩЕ ",
Kod="1851",
s="1007668"
},new StopModel()
{
Name=" Балканкерамик АД ",
Kod="925",
s="1007682"
},new StopModel()
{
Name=" Община Нови Искър ",
Kod="955",
s="1007696"
},new StopModel()
{
Name=" КВ. КУМАРИЦА ",
Kod="856",
s="1007702"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="528",
s="1007716"
},new StopModel()
{
Name=" КВ. СЛАВОВЦИ ",
Kod="904",
s="1007732"
},new StopModel()
{
Name=" УЛ. РАВНЕЦ ",
Kod="2151",
s="1007746"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1186",
s="1007794"
},new StopModel()
{
Name=" Кв. Требич ",
Kod="905",
s="1007804"
},new StopModel()
{
Name=" Начало кв. Требич ",
Kod="1683",
s="1007816"
},new StopModel()
{
Name=" Ул.Джерман ",
Kod="2666",
s="1017018"
},new StopModel()
{
Name=" Центъра кв. Илиянци ",
Kod="939",
s="1017008"
},new StopModel()
{
Name=" Хюндай България ",
Kod="1633",
s="1016992"
},new StopModel()
{
Name=" Стоков базар Илиянци ",
Kod="2457",
s="1027116"
},new StopModel()
{
Name=" Софарма АД ",
Kod="743",
s="1016097"
},new StopModel()
{
Name=" ЗАГ Динамик АД ",
Kod="726",
s="1016103"
},new StopModel()
{
Name=" Бул. Рожен ",
Kod="2664",
s="1016111"
},new StopModel()
{
Name=" Модна къща Агресия ",
Kod="2670",
s="1028618"
},new StopModel()
{
Name=" Гара София север ",
Kod="2672",
s="1028623"
},}
},}},

new BusModel()
{
Number = "28",
lid = "1000049",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Село Локорско - Центъра село Мрамор",
rid="1000621",
Stops=new StopModel[]
{new StopModel()
{
Name="Село Локорско",
Kod="1546",
s="1006249"
},new StopModel()
{
Name="Ул. Веско Веселинов ",
Kod="1667",
s="1006235"
},new StopModel()
{
Name="Начало с. Локорско ",
Kod="979",
s="1006229"
},new StopModel()
{
Name="Горско стопанство ",
Kod="496",
s="1006195"
},new StopModel()
{
Name="Гара Чепинци ",
Kod="696",
s="1006165"
},new StopModel()
{
Name="160-ОУ, с.Чепинци ",
Kod="2287",
s="1006155"
},new StopModel()
{
Name="Село Чепинци ",
Kod="1565",
s="1010136"
},new StopModel()
{
Name="Ул. Орфей ",
Kod="2094",
s="1006129"
},new StopModel()
{
Name="Гробищен парк Негован ",
Kod="508",
s="1006101"
},new StopModel()
{
Name=" с.Негован ",
Kod="1554",
s="1006095"
},new StopModel()
{
Name=" Ул.Врачанска ",
Kod="984",
s="1007918"
},new StopModel()
{
Name=" Ул. Лесновска река ",
Kod="2544",
s="1007946"
},new StopModel()
{
Name=" Кметство Световрачане ",
Kod="948",
s="1006901"
},new StopModel()
{
Name=" Село Световрачане ",
Kod="1557",
s="1006897"
},new StopModel()
{
Name=" ул. Тракийска могила ",
Kod="1765",
s="1006885"
},new StopModel()
{
Name=" По желание ",
Kod="1367",
s="1007228"
},new StopModel()
{
Name=" Начало с. Войнеговци ",
Kod="1646",
s="1007250"
},new StopModel()
{
Name=" Център с. Войнеговци ",
Kod="2340",
s="1007260"
},new StopModel()
{
Name=" Село Войняговци ",
Kod="1516",
s="1007267"
},new StopModel()
{
Name=" Център с. Войнеговци ",
Kod="2341",
s="1007257"
},new StopModel()
{
Name=" Начало с.Войнеговци ",
Kod="1647",
s="1007247"
},new StopModel()
{
Name=" По желание ",
Kod="1366",
s="1007227"
},new StopModel()
{
Name=" Начало с.Подгумер ",
Kod="1679",
s="1006823"
},new StopModel()
{
Name=" ул. Младост ",
Kod="2416",
s="1006817"
},new StopModel()
{
Name=" Център с. Подгумер ",
Kod="2344",
s="1007167"
},new StopModel()
{
Name=" Ул.Стара планина ",
Kod="2183",
s="1007304"
},new StopModel()
{
Name=" Ул.Стара планина ",
Kod="2188",
s="1007303"
},new StopModel()
{
Name=" Център с. Подгумер ",
Kod="2345",
s="1007157"
},new StopModel()
{
Name=" ул.Младост ",
Kod="2415",
s="1006818"
},new StopModel()
{
Name=" Начало с. Подгумер ",
Kod="1680",
s="1006824"
},new StopModel()
{
Name=" БАНЯТА кв. Гниляне ",
Kod="99",
s="1008056"
},new StopModel()
{
Name=" НАЧАЛО КВ. ГНИЛЯНЕ ",
Kod="1124",
s="1008066"
},new StopModel()
{
Name=" Кв. Гниляне ",
Kod="827",
s="1008078"
},new StopModel()
{
Name=" Старата чешма ",
Kod="1626",
s="1008086"
},new StopModel()
{
Name=" Ул. Ливадите ",
Kod="2027",
s="1008100"
},new StopModel()
{
Name=" Кв. Изгрев ",
Kod="841",
s="1008108"
},new StopModel()
{
Name=" Каучуков завод ЗЕБРА ",
Kod="798",
s="1008122"
},new StopModel()
{
Name=" ГАРА КУРИЛО ",
Kod="459",
s="1007640"
},new StopModel()
{
Name=" УЛ. БАБА ТОНКА ",
Kod="1832",
s="1007654"
},new StopModel()
{
Name=" УЛ. БЪДЕЩЕ ",
Kod="1851",
s="1007668"
},new StopModel()
{
Name=" Балканкерамик АД ",
Kod="925",
s="1007682"
},new StopModel()
{
Name=" Община Нови Искър ",
Kod="955",
s="1007696"
},new StopModel()
{
Name=" КВ. КУМАРИЦА ",
Kod="857",
s="1008282"
},new StopModel()
{
Name=" ОРАНЖЕРИЯТА ",
Kod="1209",
s="1008294"
},new StopModel()
{
Name=" ПОЛЕТО ",
Kod="1393",
s="1008306"
},new StopModel()
{
Name=" ЛЕТИЩЕ Доброславци ",
Kod="1003",
s="1008344"
},new StopModel()
{
Name=" Паметника с. Доброславци ",
Kod="1239",
s="1008382"
},new StopModel()
{
Name=" Площад Мегдана ",
Kod="1286",
s="1008386"
},new StopModel()
{
Name=" СЕЛО ЖИТЕН ",
Kod="1535",
s="1008442"
},new StopModel()
{
Name=" ул. Минзухар ",
Kod="1122",
s="1008450"
},new StopModel()
{
Name=" Начало с. Житен ",
Kod="2350",
s="1008458"
},new StopModel()
{
Name=" БИОМЕТ ЕООД ",
Kod="117",
s="1008482"
},new StopModel()
{
Name=" Края на с. Мрамор ",
Kod="438",
s="1008518"
},new StopModel()
{
Name=" Село Мрамор ",
Kod="1550",
s="1008526"
},new StopModel()
{
Name=" Центъра село Мрамор ",
Kod="2348",
s="1008531"
},}
},new DirectionModel()
{
Name ="Центъра село Мрамор - Село Локорско",
rid="1000622",
Stops=new StopModel[]
{new StopModel()
{
Name="Центъра село Мрамор",
Kod="2348",
s="1008531"
},new StopModel()
{
Name="Село Мрамор ",
Kod="1551",
s="1008523"
},new StopModel()
{
Name="Края на с. Мрамор ",
Kod="439",
s="1008517"
},new StopModel()
{
Name="БИОМЕТ ЕООД ",
Kod="116",
s="1008481"
},new StopModel()
{
Name="Начало с. Житен ",
Kod="2349",
s="1008457"
},new StopModel()
{
Name="ул. Минзухар ",
Kod="1123",
s="1008449"
},new StopModel()
{
Name="СЕЛО ЖИТЕН ",
Kod="1533",
s="1008439"
},new StopModel()
{
Name="Площад Мегдана ",
Kod="1285",
s="1008385"
},new StopModel()
{
Name="Паметника ",
Kod="1237",
s="1008381"
},new StopModel()
{
Name=" ЛЕТИЩЕ Доброславци ",
Kod="1004",
s="1008343"
},new StopModel()
{
Name=" ПОЛЕТО ",
Kod="1392",
s="1008305"
},new StopModel()
{
Name=" ОРАНЖЕРИЯТА ",
Kod="1208",
s="1008293"
},new StopModel()
{
Name=" КВ. КУМАРИЦА ",
Kod="858",
s="1008536"
},new StopModel()
{
Name=" Община Нови Искър ",
Kod="956",
s="1007693"
},new StopModel()
{
Name=" БАЛКАНКЕРАМИК  АД ",
Kod="924",
s="1007679"
},new StopModel()
{
Name=" УЛ. БЪДЕЩЕ ",
Kod="1850",
s="1007665"
},new StopModel()
{
Name=" УЛ. БАБА ТОНКА ",
Kod="1831",
s="1007653"
},new StopModel()
{
Name=" ГАРА КУРИЛО ",
Kod="457",
s="1007641"
},new StopModel()
{
Name=" Каучуков завод ЗЕБРА ",
Kod="799",
s="1008119"
},new StopModel()
{
Name=" Кв. Изгрев ",
Kod="846",
s="1008107"
},new StopModel()
{
Name=" Ул. Ливадите ",
Kod="2028",
s="1008099"
},new StopModel()
{
Name=" Старата чешма ",
Kod="1627",
s="1008087"
},new StopModel()
{
Name=" Кв. Гниляне ",
Kod="828",
s="1008079"
},new StopModel()
{
Name=" НАЧАЛО КВ. ГНИЛЯНЕ ",
Kod="1125",
s="1008065"
},new StopModel()
{
Name=" БАНЯТА кв. Гниляне ",
Kod="100",
s="1008055"
},new StopModel()
{
Name=" Начало с.Подгумер ",
Kod="1679",
s="1006823"
},new StopModel()
{
Name=" ул. Младост ",
Kod="2416",
s="1006817"
},new StopModel()
{
Name=" Център с. Подгумер ",
Kod="2344",
s="1007167"
},new StopModel()
{
Name=" Ул.Стара планина ",
Kod="2183",
s="1007304"
},new StopModel()
{
Name=" Ул.Стара планина ",
Kod="2188",
s="1007303"
},new StopModel()
{
Name=" Център с. Подгумер ",
Kod="2345",
s="1007157"
},new StopModel()
{
Name=" ул.Младост ",
Kod="2415",
s="1006818"
},new StopModel()
{
Name=" Начало с. Подгумер ",
Kod="1680",
s="1006824"
},new StopModel()
{
Name=" По желание ",
Kod="1367",
s="1007228"
},new StopModel()
{
Name=" Начало с. Войнеговци ",
Kod="1646",
s="1007250"
},new StopModel()
{
Name=" Център с. Войнеговци ",
Kod="2340",
s="1007260"
},new StopModel()
{
Name=" Село Войняговци ",
Kod="1516",
s="1007267"
},new StopModel()
{
Name=" Център с. Войнеговци ",
Kod="2341",
s="1007257"
},new StopModel()
{
Name=" Начало с.Войнеговци ",
Kod="1647",
s="1007247"
},new StopModel()
{
Name=" По желание ",
Kod="1366",
s="1007227"
},new StopModel()
{
Name=" ул. Тракийска могила ",
Kod="1766",
s="1006886"
},new StopModel()
{
Name=" село Световрачане ",
Kod="1559",
s="1006900"
},new StopModel()
{
Name=" КМЕТСТВО СВЕТОВРАЧАНЕ ",
Kod="949",
s="1006902"
},new StopModel()
{
Name=" Ул. Лесновска река ",
Kod="2545",
s="1007917"
},new StopModel()
{
Name=" ул. Врачанска ",
Kod="983",
s="1007915"
},new StopModel()
{
Name=" Село Негован ",
Kod="1555",
s="1006090"
},new StopModel()
{
Name=" Гробищен парк Негован ",
Kod="507",
s="1006102"
},new StopModel()
{
Name=" Ул. Орфей ",
Kod="2095",
s="1006130"
},new StopModel()
{
Name=" Село Чепинци ",
Kod="1562",
s="1020078"
},new StopModel()
{
Name=" Ул. Училищна ",
Kod="2286",
s="1006152"
},new StopModel()
{
Name=" 160-то ОУ,с.Чепинци ",
Kod="2288",
s="1006156"
},new StopModel()
{
Name=" Гара Чепинци ",
Kod="695",
s="1006166"
},new StopModel()
{
Name=" Горско стопанство ",
Kod="495",
s="1006196"
},new StopModel()
{
Name=" Начало с. Локорско ",
Kod="978",
s="1006230"
},new StopModel()
{
Name=" Ул. Веско Веселинов ",
Kod="1668",
s="1006236"
},new StopModel()
{
Name=" Село Локорско ",
Kod="1546",
s="1006249"
},}
},}},

new BusModel()
{
Number = "29",
lid = "1000050",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Илиянци - СЕЛО БАЛША",
rid="1001536",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Илиянци",
Kod="58",
s="1007868"
},new StopModel()
{
Name="Начало кв. Требич ",
Kod="1684",
s="1007815"
},new StopModel()
{
Name="Кв. Требич ",
Kod="906",
s="1007803"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1185",
s="1007791"
},new StopModel()
{
Name="Ул.Спортист ",
Kod="1672",
s="1010506"
},new StopModel()
{
Name="С. Мировяне ",
Kod="2617",
s="1010527"
},new StopModel()
{
Name="Ул.Еделвайс ",
Kod="2618",
s="1028394"
},new StopModel()
{
Name="Ул.Вишновка ",
Kod="2631",
s="1028396"
},new StopModel()
{
Name="Ул.Крушата ",
Kod="2620",
s="1028446"
},new StopModel()
{
Name=" УЛ. РАВНЕЦ ",
Kod="2150",
s="1007743"
},new StopModel()
{
Name=" КВ. СЛАВОВЦИ ",
Kod="903",
s="1007729"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="529",
s="1007715"
},new StopModel()
{
Name=" КВ. КУМАРИЦА ",
Kod="857",
s="1008282"
},new StopModel()
{
Name=" ОРАНЖЕРИЯТА ",
Kod="1209",
s="1008294"
},new StopModel()
{
Name=" ПОЛЕТО ",
Kod="1393",
s="1008306"
},new StopModel()
{
Name=" ЛЕТИЩЕ Доброславци ",
Kod="1003",
s="1008344"
},new StopModel()
{
Name=" Паметника с. Доброславци ",
Kod="1239",
s="1008382"
},new StopModel()
{
Name=" Края с. ДОБРОВСЛАВЦИ ",
Kod="1656",
s="1008618"
},new StopModel()
{
Name=" Манастир Св.Теодор Стратилат ",
Kod="2613",
s="1008656"
},new StopModel()
{
Name=" КМЕТСТВО БАЛША ",
Kod="933",
s="1008680"
},new StopModel()
{
Name=" ПО ЖЕЛАНИЕ ",
Kod="1370",
s="1008690"
},new StopModel()
{
Name=" УЛ. СТАРА ПЛАНИНА ",
Kod="2186",
s="1008700"
},new StopModel()
{
Name=" СЕЛО БАЛША ",
Kod="1511",
s="1008595"
},}
},new DirectionModel()
{
Name ="СЕЛО БАЛША - Автостанция Илиянци",
rid="1001535",
Stops=new StopModel[]
{new StopModel()
{
Name="СЕЛО БАЛША",
Kod="1511",
s="1008595"
},new StopModel()
{
Name="УЛ. СТАРА ПЛАНИНА ",
Kod="2187",
s="1008697"
},new StopModel()
{
Name="ПО ЖЕЛАНИЕ ",
Kod="1371",
s="1008691"
},new StopModel()
{
Name="КМЕТСТВО БАЛША ",
Kod="932",
s="1008679"
},new StopModel()
{
Name="Манастир Св.Теодор Стратилат ",
Kod="2614",
s="1008655"
},new StopModel()
{
Name="Края с. ДОБРОВСЛАВЦИ ",
Kod="1657",
s="1008617"
},new StopModel()
{
Name="Паметника ",
Kod="1237",
s="1008381"
},new StopModel()
{
Name="ЛЕТИЩЕ Доброславци ",
Kod="1004",
s="1008343"
},new StopModel()
{
Name="ПОЛЕТО ",
Kod="1392",
s="1008305"
},new StopModel()
{
Name=" ОРАНЖЕРИЯТА ",
Kod="1208",
s="1008293"
},new StopModel()
{
Name=" КВ. КУМАРИЦА ",
Kod="858",
s="1008536"
},new StopModel()
{
Name=" ДЕТСКИ ДОМ ",
Kod="528",
s="1007716"
},new StopModel()
{
Name=" КВ. СЛАВОВЦИ ",
Kod="904",
s="1007732"
},new StopModel()
{
Name=" УЛ. РАВНЕЦ ",
Kod="2151",
s="1007746"
},new StopModel()
{
Name=" Ул.Крушата ",
Kod="2621",
s="1028420"
},new StopModel()
{
Name=" Ул.Вишновка ",
Kod="2632",
s="1028437"
},new StopModel()
{
Name=" Ул.Еделвайс ",
Kod="2619",
s="1028440"
},new StopModel()
{
Name=" С. Мировяне ",
Kod="1549",
s="1010531"
},new StopModel()
{
Name=" Ул.Спортист ",
Kod="1671",
s="1010505"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1186",
s="1007794"
},new StopModel()
{
Name=" Кв. Требич ",
Kod="905",
s="1007804"
},new StopModel()
{
Name=" Начало кв. Требич ",
Kod="1683",
s="1007816"
},new StopModel()
{
Name=" Автостанция Илиянци ",
Kod="2608",
s="1007867"
},}
},}},

new BusModel()
{
Number = "30",
lid = "1000109",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Кв. Обеля - СЕЛО БАЛША",
rid="1001390",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Обеля",
Kod="874",
s="1015706"
},new StopModel()
{
Name="Ул.9 ",
Kod="1815",
s="1006509"
},new StopModel()
{
Name="Ул.2 ",
Kod="1793",
s="1006501"
},new StopModel()
{
Name="Метростанция Обеля ",
Kod="6241",
s="1026043"
},new StopModel()
{
Name="Ж.к. Обеля 2 ",
Kod="678",
s="1008968"
},new StopModel()
{
Name="Бетонов възел ",
Kod="113",
s="1008946"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1187",
s="1008930"
},new StopModel()
{
Name="ТИР паркинг - Мрамор ",
Kod="2690",
s="1008908"
},new StopModel()
{
Name="Начало с. Мрамор ",
Kod="1676",
s="1008894"
},new StopModel()
{
Name=" Село Мрамор ",
Kod="1551",
s="1008523"
},new StopModel()
{
Name=" Края на с. Мрамор ",
Kod="439",
s="1008517"
},new StopModel()
{
Name=" Летище Доброславци ",
Kod="1005",
s="1008759"
},new StopModel()
{
Name=" Начало с. Доброславци ",
Kod="1621",
s="1008749"
},new StopModel()
{
Name=" Площад Мегдана ",
Kod="1285",
s="1008385"
},new StopModel()
{
Name=" Паметника ",
Kod="1237",
s="1020110"
},new StopModel()
{
Name=" Края с. ДОБРОВСЛАВЦИ ",
Kod="1656",
s="1008618"
},new StopModel()
{
Name=" Манастир Св.Теодор Стратилат ",
Kod="2613",
s="1008656"
},new StopModel()
{
Name=" КМЕТСТВО БАЛША ",
Kod="933",
s="1008680"
},new StopModel()
{
Name=" ПО ЖЕЛАНИЕ ",
Kod="1370",
s="1008690"
},new StopModel()
{
Name=" УЛ. СТАРА ПЛАНИНА ",
Kod="2186",
s="1008700"
},new StopModel()
{
Name=" СЕЛО БАЛША ",
Kod="1511",
s="1008595"
},}
},new DirectionModel()
{
Name ="СЕЛО БАЛША - Кв. Обеля",
rid="1001389",
Stops=new StopModel[]
{new StopModel()
{
Name="СЕЛО БАЛША",
Kod="1511",
s="1008595"
},new StopModel()
{
Name="УЛ. СТАРА ПЛАНИНА ",
Kod="2187",
s="1008697"
},new StopModel()
{
Name="ПО ЖЕЛАНИЕ ",
Kod="1371",
s="1008691"
},new StopModel()
{
Name="КМЕТСТВО БАЛША ",
Kod="932",
s="1008679"
},new StopModel()
{
Name="Манастир Св.Теодор Стратилат ",
Kod="2614",
s="1008655"
},new StopModel()
{
Name="Края с. ДОБРОВСЛАВЦИ ",
Kod="1657",
s="1008617"
},new StopModel()
{
Name="ПАМЕТНИКА с.Доброславци ",
Kod="1238",
s="1020107"
},new StopModel()
{
Name="Площад Мегдана ",
Kod="1286",
s="1008386"
},new StopModel()
{
Name="Начало с. Доброславци ",
Kod="1616",
s="1008748"
},new StopModel()
{
Name=" Летище Доброславци ",
Kod="1002",
s="1008760"
},new StopModel()
{
Name=" Края на с. Мрамор ",
Kod="438",
s="1008518"
},new StopModel()
{
Name=" Село Мрамор ",
Kod="1550",
s="1008526"
},new StopModel()
{
Name=" Начало с. Мрамор ",
Kod="1675",
s="1008895"
},new StopModel()
{
Name=" ТИР паркинг - Мрамор ",
Kod="2691",
s="1008909"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1188",
s="1008931"
},new StopModel()
{
Name=" Бетонов възел ",
Kod="114",
s="1008947"
},new StopModel()
{
Name=" Ж.к.Обеля 2 ",
Kod="681",
s="1008971"
},new StopModel()
{
Name=" Метростанция Обеля ",
Kod="6240",
s="1028322"
},new StopModel()
{
Name=" Ул.2 ",
Kod="1792",
s="1006502"
},new StopModel()
{
Name=" Ул.9 ",
Kod="1817",
s="1006506"
},new StopModel()
{
Name=" Кв. Обеля ",
Kod="871",
s="1015707"
},}
},}},

new BusModel()
{
Number = "31",
lid = "1000013",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Село Голяновци - Кв. Обеля",
rid="1001393",
Stops=new StopModel[]
{new StopModel()
{
Name="Село Голяновци",
Kod="1519",
s="1009000"
},new StopModel()
{
Name="Начало с.Голяновци ",
Kod="1651",
s="1009010"
},new StopModel()
{
Name="Края на с.Житен ",
Kod="986",
s="1009024"
},new StopModel()
{
Name="СЕЛО ЖИТЕН ",
Kod="1536",
s="1008440"
},new StopModel()
{
Name="ул. Минзухар ",
Kod="1122",
s="1008450"
},new StopModel()
{
Name="Начало с. Житен ",
Kod="2350",
s="1008458"
},new StopModel()
{
Name="БИОМЕТ ЕООД ",
Kod="117",
s="1008482"
},new StopModel()
{
Name="Края на с. Мрамор ",
Kod="438",
s="1008518"
},new StopModel()
{
Name="Село Мрамор ",
Kod="1550",
s="1008526"
},new StopModel()
{
Name=" Начало с. Мрамор ",
Kod="1675",
s="1008895"
},new StopModel()
{
Name=" ТИР паркинг - Мрамор ",
Kod="2691",
s="1008909"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1188",
s="1008931"
},new StopModel()
{
Name=" Бетонов възел ",
Kod="114",
s="1008947"
},new StopModel()
{
Name=" Ж.к.Обеля 2 ",
Kod="681",
s="1008971"
},new StopModel()
{
Name=" Метростанция Обеля ",
Kod="6240",
s="1028322"
},new StopModel()
{
Name=" Ул.2 ",
Kod="1792",
s="1006502"
},new StopModel()
{
Name=" Ул.9 ",
Kod="1817",
s="1006506"
},new StopModel()
{
Name=" Кв. Обеля ",
Kod="871",
s="1015707"
},}
},new DirectionModel()
{
Name ="Кв. Обеля - Село Голяновци",
rid="1001392",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Обеля",
Kod="874",
s="1015706"
},new StopModel()
{
Name="Ул.9 ",
Kod="1815",
s="1006509"
},new StopModel()
{
Name="Ул.2 ",
Kod="1793",
s="1006501"
},new StopModel()
{
Name="Метростанция Обеля ",
Kod="6241",
s="1026043"
},new StopModel()
{
Name="Ж.к. Обеля 2 ",
Kod="678",
s="1008968"
},new StopModel()
{
Name="Бетонов възел ",
Kod="113",
s="1008946"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1187",
s="1008930"
},new StopModel()
{
Name="ТИР паркинг - Мрамор ",
Kod="2690",
s="1008908"
},new StopModel()
{
Name="Начало с. Мрамор ",
Kod="1676",
s="1008894"
},new StopModel()
{
Name=" Село Мрамор ",
Kod="1551",
s="1008523"
},new StopModel()
{
Name=" Края на с. Мрамор ",
Kod="439",
s="1008517"
},new StopModel()
{
Name=" БИОМЕТ ЕООД ",
Kod="116",
s="1008481"
},new StopModel()
{
Name=" Начало с. Житен ",
Kod="2349",
s="1008457"
},new StopModel()
{
Name=" ул. Минзухар ",
Kod="1123",
s="1008449"
},new StopModel()
{
Name=" СЕЛО ЖИТЕН ",
Kod="1533",
s="1008439"
},new StopModel()
{
Name=" Края на селото ",
Kod="985",
s="1009021"
},new StopModel()
{
Name=" Начало с.Голяновци ",
Kod="1650",
s="1009007"
},new StopModel()
{
Name=" Село Голяновци ",
Kod="1518",
s="1008999"
},}
},}},

new BusModel()
{
Number = "42",
lid = "1000101",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Банкя - Ж.к.Люлин 8",
rid="1001407",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Банкя",
Kod="50",
s="1022111"
},new StopModel()
{
Name="Центъра Банкя ",
Kod="503",
s="1021906"
},new StopModel()
{
Name="Ул.Бор ",
Kod="2245",
s="1023444"
},new StopModel()
{
Name="Стадиона Банкя ",
Kod="1620",
s="1023446"
},new StopModel()
{
Name="Ул.Космонавт ",
Kod="2047",
s="1019909"
},new StopModel()
{
Name="Кв.Изгрев ",
Kod="842",
s="1019895"
},new StopModel()
{
Name="Махала Иваняне ",
Kod="1026",
s="1019881"
},new StopModel()
{
Name="Кенди ООД ",
Kod="2218",
s="1019871"
},new StopModel()
{
Name="Хлебозавода ",
Kod="2316",
s="1019863"
},new StopModel()
{
Name=" Ул.Суходолски път ",
Kod="2198",
s="1019791"
},new StopModel()
{
Name=" Ул.Български войн ",
Kod="1852",
s="1015909"
},new StopModel()
{
Name=" Ул.Детелина ",
Kod="1482",
s="1015905"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1169",
s="1015895"
},new StopModel()
{
Name=" Ул.Филиповско шосе ",
Kod="908",
s="1015887"
},new StopModel()
{
Name=" Ул.Поручик Задгорски ",
Kod="2132",
s="1018737"
},new StopModel()
{
Name=" Ул.Кап.В.Данаджиев ",
Kod="1981",
s="1018719"
},new StopModel()
{
Name=" Магазин Витоша ",
Kod="1703",
s="1019605"
},new StopModel()
{
Name=" Община Люлин ",
Kod="1715",
s="1019601"
},new StopModel()
{
Name=" Търговски ц-р Люлин ",
Kod="1789",
s="1019645"
},new StopModel()
{
Name=" Метростанция Люлин ",
Kod="1054",
s="1019659"
},new StopModel()
{
Name=" Ул.Ген.Никола Генев ",
Kod="1896",
s="1019677"
},new StopModel()
{
Name=" Ул.Ген.Ас.Николов ",
Kod="1891",
s="1019687"
},new StopModel()
{
Name=" Ж.к.Люлин 8 ",
Kod="2397",
s="1019694"
},}
},new DirectionModel()
{
Name ="Ул.Търново - Автостанция Банкя",
rid="1001345",
Stops=new StopModel[]
{new StopModel()
{
Name="Ул.Търново",
Kod="2220",
s="1019695"
},new StopModel()
{
Name="Ул.Ген.Ас.Николов ",
Kod="1889",
s="1019680"
},new StopModel()
{
Name="Ул.Ген.Никола Генев ",
Kod="1897",
s="1019676"
},new StopModel()
{
Name="Метростанция Люлин ",
Kod="1057",
s="1019658"
},new StopModel()
{
Name="Търговски център Люлин ",
Kod="1788",
s="1019644"
},new StopModel()
{
Name="Община Люлин ",
Kod="1716",
s="1020908"
},new StopModel()
{
Name="Ул.308 ",
Kod="1798",
s="1020916"
},new StopModel()
{
Name="Ж.к.Люлин 3 ",
Kod="653",
s="1020928"
},new StopModel()
{
Name="Бл.402 ж.к.Люлин 4 ",
Kod="207",
s="1015880"
},new StopModel()
{
Name=" Ул.Филиповско шосе ",
Kod="907",
s="1015888"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1191",
s="1015898"
},new StopModel()
{
Name=" Ул.Детелина ",
Kod="1477",
s="1015906"
},new StopModel()
{
Name=" Ул. Български войн ",
Kod="1853",
s="1015912"
},new StopModel()
{
Name=" Ул.Суходолски път ",
Kod="2199",
s="1019794"
},new StopModel()
{
Name=" Хлебозавода ",
Kod="2317",
s="1019864"
},new StopModel()
{
Name=" Кенди ООД ",
Kod="2219",
s="1019872"
},new StopModel()
{
Name=" Махала Иваняне ",
Kod="1025",
s="1019884"
},new StopModel()
{
Name=" Кв.Изгрев ",
Kod="843",
s="1019896"
},new StopModel()
{
Name=" Ул.Космонавт ",
Kod="2048",
s="1019910"
},new StopModel()
{
Name=" Стадиона Банкя ",
Kod="1619",
s="1023447"
},new StopModel()
{
Name=" Ул.Бор ",
Kod="2246",
s="1023445"
},new StopModel()
{
Name=" Центъра Банкя ",
Kod="502",
s="1021907"
},new StopModel()
{
Name=" Автостанция Банкя ",
Kod="51",
s="1022109"
},}
},}},

new BusModel()
{
Number = "44",
lid = "1000031",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Кв. Иваняне - Автостанция Банкя",
rid="1001304",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Иваняне",
Kod="840",
s="1016019"
},new StopModel()
{
Name="кв.Изгрев ",
Kod="844",
s="1023547"
},new StopModel()
{
Name="Гара Иваняне ",
Kod="453",
s="1019939"
},new StopModel()
{
Name="Гробищен парк Банкя ",
Kod="106",
s="1019925"
},new StopModel()
{
Name="Ремонтна база ",
Kod="1468",
s="1023584"
},new StopModel()
{
Name="Ул. Ученическа ",
Kod="2225",
s="1023594"
},new StopModel()
{
Name="Ул. Стара планина ",
Kod="1942",
s="1022113"
},new StopModel()
{
Name="Центъра Банкя ",
Kod="502",
s="1021907"
},new StopModel()
{
Name="Автостанция Банкя ",
Kod="51",
s="1022109"
},}
},new DirectionModel()
{
Name ="Автостанция Банкя - Кв. Иваняне",
rid="1001308",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Банкя",
Kod="50",
s="1022111"
},new StopModel()
{
Name="Стадиона Банкя ",
Kod="1618",
s="1021910"
},new StopModel()
{
Name="Гробищен парк Банкя ",
Kod="107",
s="1019928"
},new StopModel()
{
Name="Гара Иваняне ",
Kod="454",
s="1019942"
},new StopModel()
{
Name="Кв.Изгрев ",
Kod="845",
s="1023548"
},new StopModel()
{
Name="Кв. Иваняне ",
Kod="840",
s="1016019"
},}
},}},

new BusModel()
{
Number = "45",
lid = "1000199",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Метростанция Вардар - Кв.Овча купел",
rid="1001639",
Stops=new StopModel[]
{new StopModel()
{
Name="Метростанция Вардар",
Kod="2572",
s="1028102"
},new StopModel()
{
Name="Бул.Ал.Стамболийски ",
Kod="282",
s="1014997"
},new StopModel()
{
Name="Бул.Вардар ",
Kod="292",
s="1000505"
},new StopModel()
{
Name="Ул.Добротич ",
Kod="1934",
s="1003050"
},new StopModel()
{
Name="Ж.к.Красна поляна ",
Kod="635",
s="1003060"
},new StopModel()
{
Name="Балканкар АД ",
Kod="565",
s="1003074"
},new StopModel()
{
Name="Ул.Народно хоро ",
Kod="2054",
s="1014402"
},new StopModel()
{
Name="НЦ по Рехабилитация ",
Kod="95",
s="1014394"
},new StopModel()
{
Name="Ул.Любляна ",
Kod="2606",
s="1028197"
},new StopModel()
{
Name=" Ул.Народен герой ",
Kod="2607",
s="1028202"
},new StopModel()
{
Name=" Ул.Боряна ",
Kod="1845",
s="1014382"
},new StopModel()
{
Name=" НБУ ",
Kod="69",
s="1014374"
},new StopModel()
{
Name=" ПГСС ",
Kod="1566",
s="1014368"
},new StopModel()
{
Name=" Кв.Овча купел ",
Kod="361",
s="1028586"
},}
},new DirectionModel()
{
Name ="Кв.Овча купел - Метростанция Вардар",
rid="1001638",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв.Овча купел",
Kod="361",
s="1028586"
},new StopModel()
{
Name="Кв.Бузема ",
Kod="812",
s="1014363"
},new StopModel()
{
Name="ПГСС ",
Kod="1567",
s="1014371"
},new StopModel()
{
Name="НБУ ",
Kod="67",
s="1014377"
},new StopModel()
{
Name="Ул.Боряна ",
Kod="1844",
s="1014428"
},new StopModel()
{
Name="Ул.Народен герой ",
Kod="2053",
s="1014422"
},new StopModel()
{
Name="Ул.Любляна ",
Kod="2037",
s="1014417"
},new StopModel()
{
Name="НЦ по Рехабилитация ",
Kod="98",
s="1014397"
},new StopModel()
{
Name="Ул.Народно хоро ",
Kod="2057",
s="1014405"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="566",
s="1003071"
},new StopModel()
{
Name=" Ж.к.Красна поляна ",
Kod="631",
s="1003057"
},new StopModel()
{
Name=" Ул.Добротич ",
Kod="1931",
s="1003045"
},new StopModel()
{
Name=" Бул.Вардар ",
Kod="296",
s="1015006"
},new StopModel()
{
Name=" Бл.38, ж.к.Западен парк ",
Kod="2571",
s="1028100"
},new StopModel()
{
Name=" Метростанция Вардар ",
Kod="2572",
s="1028102"
},}
},}},

new BusModel()
{
Number = "47",
lid = "1000193",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Метростанция Сливница - Кв.Градоман",
rid="1001697",
Stops=new StopModel[]
{new StopModel()
{
Name="Метростанция Сливница",
Kod="1063",
s="1010770"
},new StopModel()
{
Name="Нестле София ",
Kod="1141",
s="1010590"
},new StopModel()
{
Name="ПП Успех ",
Kod="1752",
s="1010580"
},new StopModel()
{
Name="Кв. Република ",
Kod="896",
s="1022002"
},new StopModel()
{
Name="Институт Пушкаров ",
Kod="772",
s="1021992"
},new StopModel()
{
Name="Промишлена зона ",
Kod="1686",
s="1021984"
},new StopModel()
{
Name="Екобулсорт ",
Kod="2521",
s="1021980"
},new StopModel()
{
Name="Разклона за с. Гурмазово ",
Kod="1431",
s="1021972"
},new StopModel()
{
Name="Хиподрума Банкя ",
Kod="2308",
s="1021874"
},new StopModel()
{
Name=" Кантона ",
Kod="789",
s="1021956"
},new StopModel()
{
Name=" Махала Иваняне ",
Kod="1027",
s="1021948"
},new StopModel()
{
Name=" Къмпинга ",
Kod="997",
s="1021944"
},new StopModel()
{
Name=" Гара Иваняне ",
Kod="453",
s="1019939"
},new StopModel()
{
Name=" Гробищен парк Банкя ",
Kod="106",
s="1019925"
},new StopModel()
{
Name=" Стадиона Банкя ",
Kod="1617",
s="1021911"
},new StopModel()
{
Name=" Ул.Хисаря ",
Kod="1403",
s="1021908"
},new StopModel()
{
Name=" Автостанция Банкя ",
Kod="2675",
s="1021912"
},new StopModel()
{
Name=" Центъра Банкя ",
Kod="503",
s="1021906"
},new StopModel()
{
Name=" Община Банкя ",
Kod="957",
s="1023460"
},new StopModel()
{
Name=" Ул.Тинтява ",
Kod="1595",
s="1023607"
},new StopModel()
{
Name=" В.З.Банкя ",
Kod="431",
s="1023644"
},new StopModel()
{
Name=" Ул.Венера ",
Kod="1390",
s="1023654"
},new StopModel()
{
Name=" Начало кв.Градоман ",
Kod="1120",
s="1023663"
},new StopModel()
{
Name=" Кв.Градоман ",
Kod="832",
s="1023665"
},}
},new DirectionModel()
{
Name ="Кв.Градоман - Метростанция Сливница",
rid="1001696",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв.Градоман",
Kod="832",
s="1023665"
},new StopModel()
{
Name="Начало кв.Градоман ",
Kod="1119",
s="1023664"
},new StopModel()
{
Name="Ул.Венера ",
Kod="1389",
s="1023655"
},new StopModel()
{
Name="В.З.Банкя ",
Kod="432",
s="1023645"
},new StopModel()
{
Name="Ул.Тинтява ",
Kod="1596",
s="1023608"
},new StopModel()
{
Name="Община Банкя ",
Kod="958",
s="1023459"
},new StopModel()
{
Name="Центъра Банкя ",
Kod="502",
s="1021907"
},new StopModel()
{
Name="Автостанция Банкя ",
Kod="50",
s="1022111"
},new StopModel()
{
Name="Стадиона Банкя ",
Kod="1618",
s="1021910"
},new StopModel()
{
Name=" Гробищен парк Банкя ",
Kod="107",
s="1019928"
},new StopModel()
{
Name=" Гара Иваняне ",
Kod="454",
s="1019942"
},new StopModel()
{
Name=" Къмпинга ",
Kod="996",
s="1021945"
},new StopModel()
{
Name=" Махала Иваняне ",
Kod="1024",
s="1021949"
},new StopModel()
{
Name=" Кантона ",
Kod="790",
s="1021957"
},new StopModel()
{
Name=" Хиподрума Банкя ",
Kod="2307",
s="1021928"
},new StopModel()
{
Name=" Разклона за с. Гурмазово ",
Kod="1430",
s="1021973"
},new StopModel()
{
Name=" Екобулсорт ",
Kod="2520",
s="1021981"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1685",
s="1021985"
},new StopModel()
{
Name=" Институт Пушкаров ",
Kod="771",
s="1021993"
},new StopModel()
{
Name=" Кв. Република ",
Kod="895",
s="1010864"
},new StopModel()
{
Name=" ПП Успех ",
Kod="1751",
s="1010583"
},new StopModel()
{
Name=" НЕСТЛЕ София ",
Kod="1140",
s="1010595"
},new StopModel()
{
Name=" Метростанция Сливница ",
Kod="1061",
s="1021873"
},}
},}},

new BusModel()
{
Number = "48",
lid = "1000194",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Метростанция Сливница - Края на с. Михайлово",
rid="1001699",
Stops=new StopModel[]
{new StopModel()
{
Name="Метростанция Сливница",
Kod="1063",
s="1010770"
},new StopModel()
{
Name="Нестле София ",
Kod="1141",
s="1010590"
},new StopModel()
{
Name="ПП Успех ",
Kod="1752",
s="1010580"
},new StopModel()
{
Name="Кв. Република ",
Kod="896",
s="1022002"
},new StopModel()
{
Name="Институт Пушкаров ",
Kod="772",
s="1021992"
},new StopModel()
{
Name="Промишлена зона ",
Kod="1686",
s="1021984"
},new StopModel()
{
Name="Екобулсорт ",
Kod="2521",
s="1021980"
},new StopModel()
{
Name="Разклона за с. Гурмазово ",
Kod="1431",
s="1021972"
},new StopModel()
{
Name="Хиподрума Банкя ",
Kod="2308",
s="1021874"
},new StopModel()
{
Name=" Кантона ",
Kod="789",
s="1021956"
},new StopModel()
{
Name=" Махала Иваняне ",
Kod="1027",
s="1021948"
},new StopModel()
{
Name=" Къмпинга ",
Kod="997",
s="1021944"
},new StopModel()
{
Name=" Гара Иваняне ",
Kod="453",
s="1019939"
},new StopModel()
{
Name=" Гробищен парк Банкя ",
Kod="106",
s="1019925"
},new StopModel()
{
Name=" Стадиона Банкя ",
Kod="1617",
s="1021911"
},new StopModel()
{
Name=" Ул.Хисаря ",
Kod="1403",
s="1021908"
},new StopModel()
{
Name=" Автостанция Банкя ",
Kod="2675",
s="1021912"
},new StopModel()
{
Name=" Центъра Банкя ",
Kod="503",
s="1021906"
},new StopModel()
{
Name=" Ул. Странджа ",
Kod="965",
s="1022054"
},new StopModel()
{
Name=" Ул. Родина ",
Kod="1433",
s="1022045"
},new StopModel()
{
Name=" Начало кв. Михайлово ",
Kod="1425",
s="1022039"
},new StopModel()
{
Name=" Стопанство Михайлово ",
Kod="1674",
s="1022033"
},new StopModel()
{
Name=" Ул. АлекоКонстантинов ",
Kod="446",
s="1022027"
},new StopModel()
{
Name=" Ул. Даме Груев ",
Kod="1921",
s="1022019"
},new StopModel()
{
Name=" Ул. Топлика ",
Kod="870",
s="1022015"
},new StopModel()
{
Name=" Ул. Китката ",
Kod="1992",
s="1022007"
},new StopModel()
{
Name=" Края на с. Михайлово ",
Kod="982",
s="1022006"
},}
},new DirectionModel()
{
Name ="Края на с. Михайлово - Метростанция Сливница",
rid="1001694",
Stops=new StopModel[]
{new StopModel()
{
Name="Края на с. Михайлово",
Kod="982",
s="1022006"
},new StopModel()
{
Name="Ул. Китката ",
Kod="1991",
s="1022008"
},new StopModel()
{
Name="Ул. Топлика ",
Kod="869",
s="1022016"
},new StopModel()
{
Name="Ул. Даме Груев ",
Kod="1920",
s="1022020"
},new StopModel()
{
Name="Ул. Алеко Константинов ",
Kod="445",
s="1022028"
},new StopModel()
{
Name="Стопанство Михайлово ",
Kod="1673",
s="1022034"
},new StopModel()
{
Name="Начало кв. Михайлово ",
Kod="1424",
s="1022040"
},new StopModel()
{
Name="Ул. Родина ",
Kod="1432",
s="1022046"
},new StopModel()
{
Name="Ул. Странджа ",
Kod="964",
s="1022055"
},new StopModel()
{
Name=" Центъра Банкя ",
Kod="502",
s="1021907"
},new StopModel()
{
Name=" Автостанция Банкя ",
Kod="50",
s="1022111"
},new StopModel()
{
Name=" Стадиона Банкя ",
Kod="1618",
s="1021910"
},new StopModel()
{
Name=" Гробищен парк Банкя ",
Kod="107",
s="1019928"
},new StopModel()
{
Name=" Гара Иваняне ",
Kod="454",
s="1019942"
},new StopModel()
{
Name=" Къмпинга ",
Kod="996",
s="1021945"
},new StopModel()
{
Name=" Махала Иваняне ",
Kod="1024",
s="1021949"
},new StopModel()
{
Name=" Кантона ",
Kod="790",
s="1021957"
},new StopModel()
{
Name=" Хиподрума Банкя ",
Kod="2307",
s="1021928"
},new StopModel()
{
Name=" Разклона за с. Гурмазово ",
Kod="1430",
s="1021973"
},new StopModel()
{
Name=" Екобулсорт ",
Kod="2520",
s="1021981"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1685",
s="1021985"
},new StopModel()
{
Name=" Институт Пушкаров ",
Kod="771",
s="1021993"
},new StopModel()
{
Name=" Кв. Република ",
Kod="895",
s="1010864"
},new StopModel()
{
Name=" ПП Успех ",
Kod="1751",
s="1010583"
},new StopModel()
{
Name=" НЕСТЛЕ София ",
Kod="1140",
s="1010595"
},new StopModel()
{
Name=" Метростанция Сливница ",
Kod="1061",
s="1021873"
},}
},}},

new BusModel()
{
Number = "49",
lid = "1000195",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Кв.Клисура - Метростанция Сливница",
rid="1001593",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв.Клисура",
Kod="850",
s="1022191"
},new StopModel()
{
Name="Мостът ",
Kod="1084",
s="1022190"
},new StopModel()
{
Name="Начало кв.Клисура ",
Kod="1126",
s="1022188"
},new StopModel()
{
Name="Овчарски кошари ",
Kod="1167",
s="1022330"
},new StopModel()
{
Name="По желание ",
Kod="2497",
s="1022185"
},new StopModel()
{
Name="Кв.Вердикал ",
Kod="817",
s="1022170"
},new StopModel()
{
Name="Ул.Ручей ",
Kod="1642",
s="1022157"
},new StopModel()
{
Name="Ул.Царибродска ",
Kod="2201",
s="1022115"
},new StopModel()
{
Name="Ул. Стара планина ",
Kod="1942",
s="1022113"
},new StopModel()
{
Name=" Центъра Банкя ",
Kod="502",
s="1021907"
},new StopModel()
{
Name=" Автостанция Банкя ",
Kod="50",
s="1022111"
},new StopModel()
{
Name=" Стадиона Банкя ",
Kod="1618",
s="1021910"
},new StopModel()
{
Name=" Гробищен парк Банкя ",
Kod="107",
s="1019928"
},new StopModel()
{
Name=" Гара Иваняне ",
Kod="454",
s="1019942"
},new StopModel()
{
Name=" Къмпинга ",
Kod="996",
s="1021945"
},new StopModel()
{
Name=" Махала Иваняне ",
Kod="1024",
s="1021949"
},new StopModel()
{
Name=" Кантона ",
Kod="790",
s="1021957"
},new StopModel()
{
Name=" Хиподрума Банкя ",
Kod="2307",
s="1021928"
},new StopModel()
{
Name=" Разклона за с. Гурмазово ",
Kod="1430",
s="1021973"
},new StopModel()
{
Name=" Екобулсорт ",
Kod="2520",
s="1021981"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1685",
s="1021985"
},new StopModel()
{
Name=" Институт Пушкаров ",
Kod="771",
s="1021993"
},new StopModel()
{
Name=" Кв. Република ",
Kod="895",
s="1010864"
},new StopModel()
{
Name=" ПП Успех ",
Kod="1751",
s="1010583"
},new StopModel()
{
Name=" НЕСТЛЕ София ",
Kod="1140",
s="1010595"
},new StopModel()
{
Name=" Метростанция Сливница ",
Kod="1061",
s="1021873"
},}
},new DirectionModel()
{
Name ="Метростанция Сливница - Кв.Клисура",
rid="1001594",
Stops=new StopModel[]
{new StopModel()
{
Name="Метростанция Сливница",
Kod="1063",
s="1010770"
},new StopModel()
{
Name="Нестле София ",
Kod="1141",
s="1010590"
},new StopModel()
{
Name="ПП Успех ",
Kod="1752",
s="1010580"
},new StopModel()
{
Name="Кв. Република ",
Kod="896",
s="1022002"
},new StopModel()
{
Name="Институт Пушкаров ",
Kod="772",
s="1021992"
},new StopModel()
{
Name="Промишлена зона ",
Kod="1686",
s="1021984"
},new StopModel()
{
Name="Екобулсорт ",
Kod="2521",
s="1021980"
},new StopModel()
{
Name="Разклона за с. Гурмазово ",
Kod="1431",
s="1021972"
},new StopModel()
{
Name="Хиподрума Банкя ",
Kod="2308",
s="1021874"
},new StopModel()
{
Name=" Кантона ",
Kod="789",
s="1021956"
},new StopModel()
{
Name=" Махала Иваняне ",
Kod="1027",
s="1021948"
},new StopModel()
{
Name=" Къмпинга ",
Kod="997",
s="1021944"
},new StopModel()
{
Name=" Гара Иваняне ",
Kod="453",
s="1019939"
},new StopModel()
{
Name=" Гробищен парк Банкя ",
Kod="106",
s="1019925"
},new StopModel()
{
Name=" Стадиона Банкя ",
Kod="1617",
s="1021911"
},new StopModel()
{
Name=" Ул.Хисаря ",
Kod="1403",
s="1021908"
},new StopModel()
{
Name=" Автостанция Банкя ",
Kod="2675",
s="1021912"
},new StopModel()
{
Name=" Центъра Банкя ",
Kod="503",
s="1021906"
},new StopModel()
{
Name=" Ул. Стара планина ",
Kod="1943",
s="1022112"
},new StopModel()
{
Name=" Ул. Царибродска ",
Kod="2202",
s="1022114"
},new StopModel()
{
Name=" Ул. Ручей ",
Kod="1643",
s="1022158"
},new StopModel()
{
Name=" Кв.Вердикал ",
Kod="818",
s="1022169"
},new StopModel()
{
Name=" По желание ",
Kod="2496",
s="1022184"
},new StopModel()
{
Name=" Овчарски кошари ",
Kod="1168",
s="1022329"
},new StopModel()
{
Name=" Начало кв.Клисура ",
Kod="1127",
s="1022187"
},new StopModel()
{
Name=" Мостът ",
Kod="1083",
s="1022189"
},new StopModel()
{
Name=" Кв.Клисура ",
Kod="850",
s="1022191"
},}
},}},

new BusModel()
{
Number = "54",
lid = "1000098",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Метростанция Сливница - Пътен възел Калотина",
rid="1001364",
Stops=new StopModel[]
{new StopModel()
{
Name="Метростанция Сливница",
Kod="1063",
s="1010770"
},new StopModel()
{
Name="Нестле София ",
Kod="1141",
s="1010590"
},new StopModel()
{
Name="ПП Успех ",
Kod="1752",
s="1010580"
},new StopModel()
{
Name="кв.Република ",
Kod="894",
s="1010865"
},new StopModel()
{
Name="Кв. Република 2 ",
Kod="2527",
s="1010903"
},new StopModel()
{
Name="Магазин МЕТРО-2 ",
Kod="1020",
s="1010909"
},new StopModel()
{
Name="Начало Толева махала ",
Kod="2501",
s="1010933"
},new StopModel()
{
Name="Толева махала ",
Kod="1758",
s="1010943"
},new StopModel()
{
Name="Ж.п.прелез ",
Kod="704",
s="1010961"
},new StopModel()
{
Name=" Военноремонтен завод ",
Kod="915",
s="1010967"
},new StopModel()
{
Name=" Ул.Георги Бенковски ",
Kod="1907",
s="1010973"
},new StopModel()
{
Name=" Ул.Христо Ботев ",
Kod="2239",
s="1010981"
},new StopModel()
{
Name=" Кметство Божурище ",
Kod="934",
s="1010991"
},new StopModel()
{
Name=" Ул. Искър Божурище ",
Kod="2602",
s="1028264"
},new StopModel()
{
Name=" Ул. Хан Тервел кв. Максим Горки ",
Kod="2502",
s="1028268"
},new StopModel()
{
Name=" Ул. Хан Крум кв. Максим Горки ",
Kod="2504",
s="1028272"
},new StopModel()
{
Name=" Пътен възел Калотина ",
Kod="2506",
s="1028275"
},}
},new DirectionModel()
{
Name ="Пътен възел Калотина - Метростанция Сливница",
rid="1001365",
Stops=new StopModel[]
{new StopModel()
{
Name="Пътен възел Калотина",
Kod="2603",
s="1028278"
},new StopModel()
{
Name="Ул. Хан Крум кв. Максим Горки ",
Kod="2505",
s="1028282"
},new StopModel()
{
Name="Ул. Хан Тервел кв. Максим Горки ",
Kod="2503",
s="1028286"
},new StopModel()
{
Name="Ул. Искър Божурище ",
Kod="2604",
s="1028290"
},new StopModel()
{
Name="Кметство Божурище ",
Kod="2605",
s="1028295"
},new StopModel()
{
Name="Ул.Христо Ботев ",
Kod="2238",
s="1010980"
},new StopModel()
{
Name="Ул.Георги Бенковски ",
Kod="1906",
s="1010974"
},new StopModel()
{
Name="Военноремонтен завод ",
Kod="916",
s="1010968"
},new StopModel()
{
Name="Ж.п.прелез ",
Kod="705",
s="1010958"
},new StopModel()
{
Name=" Толева махала ",
Kod="1757",
s="1010938"
},new StopModel()
{
Name=" Мотел Божур ",
Kod="1106",
s="1010916"
},new StopModel()
{
Name=" Магазин Метро-2 ",
Kod="1019",
s="1010904"
},new StopModel()
{
Name=" Кв. Република ",
Kod="895",
s="1010864"
},new StopModel()
{
Name=" ПП Успех ",
Kod="1751",
s="1010583"
},new StopModel()
{
Name=" НЕСТЛЕ София ",
Kod="1140",
s="1010595"
},new StopModel()
{
Name=" Метростанция Сливница ",
Kod="1061",
s="1021873"
},}
},}},

new BusModel()
{
Number = "56",
lid = "1000022",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Метростанция Вардар - Село Мало Бучино",
rid="1001203",
Stops=new StopModel[]
{new StopModel()
{
Name="Метростанция Вардар",
Kod="2572",
s="1028102"
},new StopModel()
{
Name="Ул.Булина ливада ",
Kod="2573",
s="1027821"
},new StopModel()
{
Name="Бл.13 ж.к.Западен парк ",
Kod="2570",
s="1027822"
},new StopModel()
{
Name="Ж.к.Западен парк ",
Kod="2568",
s="1027824"
},new StopModel()
{
Name="кв.Факултета ",
Kod="1228",
s="1011331"
},new StopModel()
{
Name="Селскостопанска академия ",
Kod="2289",
s="1011321"
},new StopModel()
{
Name="Махала Коньовица ",
Kod="966",
s="1011311"
},new StopModel()
{
Name="Ул.Монтевидео ",
Kod="1030",
s="1011299"
},new StopModel()
{
Name="ВСУ Л.Каравелов ",
Kod="417",
s="1011293"
},new StopModel()
{
Name=" Простор ",
Kod="1419",
s="1011287"
},new StopModel()
{
Name=" Моста на р.Струбел ",
Kod="1085",
s="1011279"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1181",
s="1011263"
},new StopModel()
{
Name=" Читалище Просвета ",
Kod="942",
s="1011259"
},new StopModel()
{
Name=" Църквата Св.Георги ",
Kod="2370",
s="1011249"
},new StopModel()
{
Name=" Ул.Прилеп ",
Kod="1681",
s="1011235"
},new StopModel()
{
Name=" Митница Суходол ",
Kod="1071",
s="1011360"
},new StopModel()
{
Name=" В.З.Суходол ",
Kod="433",
s="1011197"
},new StopModel()
{
Name=" Местност Малинов дол ",
Kod="918",
s="1011187"
},new StopModel()
{
Name=" Яз.Мало Бучино ",
Kod="1876",
s="1011181"
},new StopModel()
{
Name=" Разсадник Мало Бучино ",
Kod="1461",
s="1011147"
},new StopModel()
{
Name=" Ул.Липа ",
Kod="1670",
s="1011129"
},new StopModel()
{
Name=" Ул.Демокрация ",
Kod="1797",
s="1011123"
},new StopModel()
{
Name=" Село Мало Бучино ",
Kod="1548",
s="1011115"
},}
},new DirectionModel()
{
Name ="Село Мало Бучино - Метростанция Вардар",
rid="1001202",
Stops=new StopModel[]
{new StopModel()
{
Name="Село Мало Бучино",
Kod="1547",
s="1011116"
},new StopModel()
{
Name="Ул.Демокрация ",
Kod="1796",
s="1011124"
},new StopModel()
{
Name="Ул.Липа ",
Kod="1669",
s="1011132"
},new StopModel()
{
Name="Разсадник Мало Бучино ",
Kod="1460",
s="1011148"
},new StopModel()
{
Name="Яз.Мало Бучино ",
Kod="2384",
s="1011184"
},new StopModel()
{
Name="Местност Малинов дол ",
Kod="917",
s="1011190"
},new StopModel()
{
Name="В.з.Суходол ",
Kod="434",
s="1011198"
},new StopModel()
{
Name="Митница Суходол ",
Kod="1070",
s="1011226"
},new StopModel()
{
Name="Ул.Прилеп ",
Kod="1682",
s="1011238"
},new StopModel()
{
Name=" Църквата Св.Георги ",
Kod="2371",
s="1011252"
},new StopModel()
{
Name=" Читалище Просвета ",
Kod="943",
s="1011260"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1180",
s="1011266"
},new StopModel()
{
Name=" Моста на р.Струбел ",
Kod="1086",
s="1011280"
},new StopModel()
{
Name=" Простор ",
Kod="1418",
s="1011288"
},new StopModel()
{
Name=" ВСУ Л.Каравелов ",
Kod="416",
s="1011294"
},new StopModel()
{
Name=" Ул.Монтевидео ",
Kod="1031",
s="1011300"
},new StopModel()
{
Name=" Махала Коньовица ",
Kod="967",
s="1011312"
},new StopModel()
{
Name=" Селскоктопанска академия ",
Kod="2290",
s="1011324"
},new StopModel()
{
Name=" кв.Факултета ",
Kod="1227",
s="1011332"
},new StopModel()
{
Name=" Ж.к.Западен парк ",
Kod="2567",
s="1027804"
},new StopModel()
{
Name=" Бл.13 ж.к.Западен парк ",
Kod="2569",
s="1027805"
},new StopModel()
{
Name=" Бл.38, ж.к.Западен парк ",
Kod="2571",
s="1028100"
},new StopModel()
{
Name=" Метростанция Вардар ",
Kod="2572",
s="1028102"
},}
},}},

new BusModel()
{
Number = "59",
lid = "1000105",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="С.Мърчаево Толумска махала - Автостанция Княжево",
rid="1001636",
Stops=new StopModel[]
{new StopModel()
{
Name="С.Мърчаево Толумска махала",
Kod="1786",
s="1020133"
},new StopModel()
{
Name="Толумска махала - по желание ",
Kod="2470",
s="1020140"
},new StopModel()
{
Name="Ул. 19 ",
Kod="1677",
s="1020134"
},new StopModel()
{
Name="Кметство Мърчаево ",
Kod="1552",
s="1020154"
},new StopModel()
{
Name="Ул. Кало ",
Kod="2499",
s="1020195"
},new StopModel()
{
Name="152-ро ОУ ",
Kod="2284",
s="1020168"
},new StopModel()
{
Name="Местност Елите ",
Kod="572",
s="1020213"
},new StopModel()
{
Name="Начало с. Мърчаево ",
Kod="1130",
s="1020248"
},new StopModel()
{
Name="СЕЛИМИЦА ",
Kod="1509",
s="1020298"
},new StopModel()
{
Name=" ул.Лесковец ",
Kod="1028",
s="1011492"
},new StopModel()
{
Name=" ул. Китен ",
Kod="1481",
s="1011500"
},new StopModel()
{
Name=" Кметство Владая ",
Kod="1514",
s="1011518"
},new StopModel()
{
Name=" УЛ. ПРОЛЕТ ",
Kod="2411",
s="1011530"
},new StopModel()
{
Name=" Начало с. Владая ",
Kod="1499",
s="1011548"
},new StopModel()
{
Name=" КЪМПИНГ ЧЕРНИЯ КОС ",
Kod="994",
s="1011616"
},new StopModel()
{
Name=" ул. Мала кория ",
Kod="1416",
s="1011628"
},new StopModel()
{
Name=" ул.10-ти километър ",
Kod="521",
s="1011636"
},new StopModel()
{
Name=" УЛ. ВЛАДАЙСКО ВЪСТАНИЕ ",
Kod="1882",
s="1011654"
},new StopModel()
{
Name=" УЛ.СИНЯТА СКАЛА ",
Kod="2174",
s="1011664"
},new StopModel()
{
Name=" Автостанция Княжево ",
Kod="2622",
s="1011683"
},}
},new DirectionModel()
{
Name ="Автостанция Княжево - С.Мърчаево Толумска махала",
rid="1000070",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Княжево",
Kod="853",
s="1011684"
},new StopModel()
{
Name="УЛ.СИНЯТА СКАЛА ",
Kod="2175",
s="1011663"
},new StopModel()
{
Name="УЛ. ВЛАДАЙСКО ВЪСТАНИЕ ",
Kod="1883",
s="1011651"
},new StopModel()
{
Name="ул. 10-ти километър ",
Kod="522",
s="1011635"
},new StopModel()
{
Name="ул. Мала кория ",
Kod="1417",
s="1011629"
},new StopModel()
{
Name="КЪМПИНГ ЧЕРНИЯ КОС ",
Kod="995",
s="1011609"
},new StopModel()
{
Name="Начало с. Владая ",
Kod="1500",
s="1011545"
},new StopModel()
{
Name="УЛ. ПРОЛЕТ ",
Kod="2410",
s="1011529"
},new StopModel()
{
Name="Кметство Владая ",
Kod="1515",
s="1011517"
},new StopModel()
{
Name=" ул. Китен ",
Kod="1480",
s="1011499"
},new StopModel()
{
Name=" ул. Лесковец ",
Kod="1029",
s="1011491"
},new StopModel()
{
Name=" СЕЛИМИЦА ",
Kod="1510",
s="1020297"
},new StopModel()
{
Name=" НАЧАЛО МЪРЧАЕВО ",
Kod="1131",
s="1020249"
},new StopModel()
{
Name=" местност Елите ",
Kod="573",
s="1020214"
},new StopModel()
{
Name=" 152-ро ОУ ",
Kod="2283",
s="1020169"
},new StopModel()
{
Name=" Ул. Кало ",
Kod="2498",
s="1020209"
},new StopModel()
{
Name=" Кметство Мърчаево ",
Kod="1553",
s="1020155"
},new StopModel()
{
Name=" Ул. 19 ",
Kod="1678",
s="1020135"
},new StopModel()
{
Name=" Толумска махала по желание ",
Kod="2469",
s="1020143"
},new StopModel()
{
Name=" С.Мърчаево Толумска махала ",
Kod="1786",
s="1020133"
},}
},}},

new BusModel()
{
Number = "60",
lid = "1000005",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Централна гара - Ж.к. Овча купел 2",
rid="1001240",
Stops=new StopModel[]
{new StopModel()
{
Name="Централна гара",
Kod="6220",
s="1011831"
},new StopModel()
{
Name="Бул.Княгиня Мария Луиза ",
Kod="324",
s="1003531"
},new StopModel()
{
Name="Ул.Охрид ",
Kod="2105",
s="1003536"
},new StopModel()
{
Name="Ул.Св.Св.Кирил и Методий ",
Kod="2171",
s="1011885"
},new StopModel()
{
Name="Ул.Пиротска ",
Kod="2111",
s="1011895"
},new StopModel()
{
Name="Бул.Александър  Стамболийски ",
Kod="280",
s="1023720"
},new StopModel()
{
Name="Ул.Камен Андреев ",
Kod="1976",
s="1023730"
},new StopModel()
{
Name="ДАНОН Сердика АД ",
Kod="1075",
s="1023735"
},new StopModel()
{
Name="Ул. Гюешево ",
Kod="1157",
s="1000241"
},new StopModel()
{
Name=" Бул.Възкресение ",
Kod="304",
s="1000227"
},new StopModel()
{
Name=" Бул.Вардар ",
Kod="292",
s="1000505"
},new StopModel()
{
Name=" Ул.Добротич ",
Kod="1934",
s="1003050"
},new StopModel()
{
Name=" Ж.к.Красна поляна ",
Kod="635",
s="1003060"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="565",
s="1003074"
},new StopModel()
{
Name=" Бул. Овча купел ",
Kod="351",
s="1003096"
},new StopModel()
{
Name=" Ул. Лиляче ",
Kod="2029",
s="1003114"
},new StopModel()
{
Name=" ОЦ Овча купел ",
Kod="1218",
s="1003134"
},new StopModel()
{
Name=" Бл. 519 ж.к. Овча купел 1 ",
Kod="230",
s="1003142"
},new StopModel()
{
Name=" Търговски ц-р Овча купел ",
Kod="212",
s="1003158"
},new StopModel()
{
Name=" Ул. Промишлена ",
Kod="2141",
s="1003170"
},new StopModel()
{
Name=" Бл. 32 ж.к. Овча купел 2 ",
Kod="192",
s="1003178"
},new StopModel()
{
Name=" Бл. 25 ж.к. Овча купел 2 ",
Kod="175",
s="1003186"
},new StopModel()
{
Name=" Пазара Овча купел ",
Kod="1708",
s="1003212"
},new StopModel()
{
Name=" Ж.к. Овча купел 2 ",
Kod="682",
s="1020575"
},}
},new DirectionModel()
{
Name ="Ж.к. Овча купел 2 - Централна гара",
rid="1001244",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Овча купел 2",
Kod="684",
s="1020574"
},new StopModel()
{
Name="Пазара Овча купел ",
Kod="1706",
s="1003211"
},new StopModel()
{
Name="Бл. 25 ж.к. Овча купел 2 ",
Kod="174",
s="1003183"
},new StopModel()
{
Name="Бл. 32 ж.к. Овча купел 2 ",
Kod="191",
s="1003175"
},new StopModel()
{
Name="Ул. Промишлена ",
Kod="2140",
s="1003167"
},new StopModel()
{
Name="Търговски ц-р Овча купел ",
Kod="211",
s="1003155"
},new StopModel()
{
Name="Бл. 519 ж.к. Овча купел 1 ",
Kod="229",
s="1003141"
},new StopModel()
{
Name="ОЦ Овча купел ",
Kod="1219",
s="1003129"
},new StopModel()
{
Name="Ул. Лиляче ",
Kod="2030",
s="1003109"
},new StopModel()
{
Name=" Бул. Овча купел ",
Kod="352",
s="1003095"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="566",
s="1003071"
},new StopModel()
{
Name=" Ж.к.Красна поляна ",
Kod="631",
s="1003057"
},new StopModel()
{
Name=" Ул.Добротич ",
Kod="1931",
s="1003045"
},new StopModel()
{
Name=" Бул.Вардар ",
Kod="293",
s="1000510"
},new StopModel()
{
Name=" Бул.Възкресение ",
Kod="307",
s="1000228"
},new StopModel()
{
Name=" Ул. Гюешево ",
Kod="1156",
s="1023691"
},new StopModel()
{
Name=" Ул.Камен Андреев ",
Kod="1977",
s="1023702"
},new StopModel()
{
Name=" Бул.Александър  Стамболийски ",
Kod="287",
s="1023713"
},new StopModel()
{
Name=" Ул.Пиротска ",
Kod="2114",
s="1011892"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2087",
s="1002851"
},new StopModel()
{
Name=" Ул.Клокотница ",
Kod="1995",
s="1011827"
},new StopModel()
{
Name=" Централна гара ",
Kod="6220",
s="1011831"
},}
},}},

new BusModel()
{
Number = "63",
lid = "1000025",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Бул. Цар Борис ІІІ - Бялата чешма",
rid="1000126",
Stops=new StopModel[]
{new StopModel()
{
Name="Бул. Цар Борис ІІІ",
Kod="393",
s="1000262"
},new StopModel()
{
Name="Ул.Феликс Каниц ",
Kod="2423",
s="1012353"
},new StopModel()
{
Name="Ж.к. Красно село ",
Kod="638",
s="1012528"
},new StopModel()
{
Name="Бул.Братя Бъкстон ",
Kod="289",
s="1012514"
},new StopModel()
{
Name="Ул.Тодор Каблешков ",
Kod="2208",
s="1012498"
},new StopModel()
{
Name="Ул.Вихрен ",
Kod="1878",
s="1012486"
},new StopModel()
{
Name="Параклис Св. Ив. Рилски ",
Kod="1246",
s="1012476"
},new StopModel()
{
Name="ж.к.Бъкстон ",
Kod="586",
s="1012466"
},new StopModel()
{
Name="НИМ ",
Kod="1464",
s="1012460"
},new StopModel()
{
Name=" Гробищен парк Бояна ",
Kod="262",
s="1012404"
},new StopModel()
{
Name=" Резиденция Бояна ",
Kod="1448",
s="1012390"
},new StopModel()
{
Name=" кв.Бояна ",
Kod="808",
s="1012376"
},new StopModel()
{
Name=" Скиорката ",
Kod="1592",
s="1012368"
},new StopModel()
{
Name=" Ул.Баевица ",
Kod="1834",
s="1012362"
},new StopModel()
{
Name=" Ул.Акация ",
Kod="1767",
s="1012626"
},new StopModel()
{
Name=" В.З.Беловодски път ",
Kod="811",
s="1012620"
},new StopModel()
{
Name=" Ул.Меча поляна ",
Kod="981",
s="1012614"
},new StopModel()
{
Name=" Ж.к.Магнолия-по желание ",
Kod="2449",
s="1012600"
},new StopModel()
{
Name=" Ул.Стар Беловодски път ",
Kod="1854",
s="1012586"
},new StopModel()
{
Name=" Бялата чешма ",
Kod="1839",
s="1012560"
},}
},new DirectionModel()
{
Name ="Бялата чешма - Бул. Цар Борис ІІІ",
rid="1000127",
Stops=new StopModel[]
{new StopModel()
{
Name="Бялата чешма",
Kod="1839",
s="1012560"
},new StopModel()
{
Name="Ул.Стар Беловодски път ",
Kod="1855",
s="1012589"
},new StopModel()
{
Name="Ж.к.Магнолия-по желание ",
Kod="2450",
s="1012601"
},new StopModel()
{
Name="Ул.Меча поляна ",
Kod="980",
s="1012617"
},new StopModel()
{
Name="В.З.Беловодски път ",
Kod="810",
s="1012621"
},new StopModel()
{
Name="Ул.Акация ",
Kod="1770",
s="1012627"
},new StopModel()
{
Name="Ул.Баевица ",
Kod="1833",
s="1012363"
},new StopModel()
{
Name="Скиорката ",
Kod="1591",
s="1012373"
},new StopModel()
{
Name="Кв.Бояна ",
Kod="807",
s="1012379"
},new StopModel()
{
Name=" Резиденция Бояна ",
Kod="1439",
s="1012391"
},new StopModel()
{
Name=" Гробищен парк Бояна ",
Kod="263",
s="1012407"
},new StopModel()
{
Name=" НИМ ",
Kod="1465",
s="1012453"
},new StopModel()
{
Name=" ж.к.Бъкстон. ",
Kod="591",
s="1012471"
},new StopModel()
{
Name=" Параклис Св.Ив.Рилски ",
Kod="1245",
s="1012479"
},new StopModel()
{
Name=" Ул.Вихрен ",
Kod="1875",
s="1012491"
},new StopModel()
{
Name=" Ул.Т.Каблешков ",
Kod="2207",
s="1012503"
},new StopModel()
{
Name=" Бул.Братя Бъкстон ",
Kod="288",
s="1012517"
},new StopModel()
{
Name=" Ж.к. Красно село ",
Kod="636",
s="1012533"
},new StopModel()
{
Name=" Бул. Цар Борис ІІІ ",
Kod="393",
s="1000262"
},}
},}},

new BusModel()
{
Number = "64",
lid = "1000006",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Център по Хигиена - Автостанция Хладилника",
rid="1000996",
Stops=new StopModel[]
{new StopModel()
{
Name="Център по Хигиена",
Kod="2343",
s="1012185"
},new StopModel()
{
Name="Бул. Акад.Ив.Е.Гешов ",
Kod="275",
s="1003908"
},new StopModel()
{
Name="Пл.Ручей ",
Kod="1306",
s="1003924"
},new StopModel()
{
Name="Бул.Гоце Делчев ",
Kod="308",
s="1012671"
},new StopModel()
{
Name="Ул.Тодор Каблешков ",
Kod="2206",
s="1012695"
},new StopModel()
{
Name="Кв.Манастирски ливади ",
Kod="866",
s="1012715"
},new StopModel()
{
Name="Гробищен парк Бояна ",
Kod="262",
s="1012404"
},new StopModel()
{
Name="Резиденция Бояна ",
Kod="1448",
s="1012390"
},new StopModel()
{
Name="кв.Бояна ",
Kod="808",
s="1012376"
},new StopModel()
{
Name=" Скиорката ",
Kod="1590",
s="1012854"
},new StopModel()
{
Name=" Ул.Байкал ",
Kod="1836",
s="1012860"
},new StopModel()
{
Name=" Боянско ханче ",
Kod="266",
s="1012870"
},new StopModel()
{
Name=" Ул.Брезите ",
Kod="1377",
s="1012886"
},new StopModel()
{
Name=" В.З.Бояна ",
Kod="435",
s="1012900"
},new StopModel()
{
Name=" Ул.Радецки ",
Kod="2152",
s="1012912"
},new StopModel()
{
Name=" Фохар АД ",
Kod="2294",
s="1012920"
},new StopModel()
{
Name=" Детски дом Киноцентър ",
Kod="531",
s="1012924"
},new StopModel()
{
Name=" Киноцентър Бояна ",
Kod="931",
s="1012930"
},new StopModel()
{
Name=" В.З.Киноцентър ",
Kod="413",
s="1012948"
},new StopModel()
{
Name=" Ул.5 ",
Kod="1803",
s="1012958"
},new StopModel()
{
Name=" Ул.10 ",
Kod="1791",
s="1012968"
},new StopModel()
{
Name=" Ул.Лешникова гора ",
Kod="2026",
s="1012982"
},new StopModel()
{
Name=" Кв.Драгалевци ",
Kod="835",
s="1012988"
},new StopModel()
{
Name=" Гробищен парк Драгалевци ",
Kod="509",
s="1013014"
},new StopModel()
{
Name=" Ж.к.Водолей ",
Kod="2598",
s="1013030"
},new StopModel()
{
Name=" ОКОЛОВРЪСТЕН ПЪТ ",
Kod="1177",
s="1013034"
},new StopModel()
{
Name=" Кв.Кръстова вада ",
Kod="914",
s="1013056"
},new StopModel()
{
Name=" Ул. Асен Йорданов ",
Kod="783",
s="1013064"
},new StopModel()
{
Name=" Кв. Хладилника ",
Kod="912",
s="1013084"
},new StopModel()
{
Name=" Автостанция Хладилника ",
Kod="64",
s="1013095"
},}
},new DirectionModel()
{
Name ="Автостанция Хладилника - Център по Хигиена",
rid="1000128",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Хладилника",
Kod="64",
s="1013095"
},new StopModel()
{
Name="Кв. Хладилника ",
Kod="909",
s="1013085"
},new StopModel()
{
Name="Ул. Асен Йорданов ",
Kod="786",
s="1013061"
},new StopModel()
{
Name="Кв.Кръстова вада ",
Kod="919",
s="1013051"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1176",
s="1013039"
},new StopModel()
{
Name="Ж.к.Водолей ",
Kod="2597",
s="1013031"
},new StopModel()
{
Name="Гробищен парк Драгалевци ",
Kod="510",
s="1013013"
},new StopModel()
{
Name="кв.Драгалевци ",
Kod="836",
s="1012987"
},new StopModel()
{
Name="Ул.Лешникова гора ",
Kod="2025",
s="1012979"
},new StopModel()
{
Name=" Ул.10 ",
Kod="1790",
s="1012965"
},new StopModel()
{
Name=" Ул.5 ",
Kod="1802",
s="1012955"
},new StopModel()
{
Name=" В.З.Киноцентър ",
Kod="412",
s="1012943"
},new StopModel()
{
Name=" Киноцентър Бояна ",
Kod="930",
s="1012929"
},new StopModel()
{
Name=" Детски дом  Киноцентър ",
Kod="532",
s="1012923"
},new StopModel()
{
Name=" Фохар АД ",
Kod="2295",
s="1012919"
},new StopModel()
{
Name=" Ул.Радецки ",
Kod="2153",
s="1012909"
},new StopModel()
{
Name=" В.З.Бояна ",
Kod="429",
s="1012899"
},new StopModel()
{
Name=" Ул.Брезите ",
Kod="1351",
s="1012885"
},new StopModel()
{
Name=" Боянско ханче ",
Kod="265",
s="1012875"
},new StopModel()
{
Name=" Ул.Байкал ",
Kod="1835",
s="1012859"
},new StopModel()
{
Name=" Скиорката ",
Kod="1591",
s="1012373"
},new StopModel()
{
Name=" Кв.Бояна ",
Kod="807",
s="1012379"
},new StopModel()
{
Name=" Резиденция Бояна ",
Kod="1439",
s="1012391"
},new StopModel()
{
Name=" Гробищен парк Бояна ",
Kod="263",
s="1012407"
},new StopModel()
{
Name=" Кв.Манастирски ливади ",
Kod="868",
s="1012714"
},new StopModel()
{
Name=" Ул.Тодор Каблешков ",
Kod="2213",
s="1012690"
},new StopModel()
{
Name=" Бул.Гоце Делчев ",
Kod="314",
s="1003937"
},new StopModel()
{
Name=" Пл.Ручей ",
Kod="1301",
s="1003921"
},new StopModel()
{
Name=" Бул.Акад.Иван Гешов ",
Kod="269",
s="1012173"
},new StopModel()
{
Name=" Център по Хигиена ",
Kod="2342",
s="1012177"
},}
},}},

new BusModel()
{
Number = "65",
lid = "1000007",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к. Гоце Делчев - Кв. Манастирски Ливади",
rid="1001000",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Гоце Делчев",
Kod="600",
s="1014571"
},new StopModel()
{
Name="Ул.Луи Айер ",
Kod="2034",
s="1013154"
},new StopModel()
{
Name="Кв. Манастирски Ливади ",
Kod="867",
s="1013218"
},}
},new DirectionModel()
{
Name ="Кв. Манастирски Ливади - ж.к. Гоце Делчев",
rid="1000074",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Манастирски Ливади",
Kod="867",
s="1013218"
},new StopModel()
{
Name="Ул.Луи Айер ",
Kod="2035",
s="1013153"
},new StopModel()
{
Name="ж.к. Гоце Делчев ",
Kod="599",
s="1020016"
},}
},}},

new BusModel()
{
Number = "67",
lid = "1000077",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Семинарията - Кв. Симеоново",
rid="1001724",
Stops=new StopModel[]
{new StopModel()
{
Name="Семинарията",
Kod="1568",
s="1013464"
},new StopModel()
{
Name="Телевизионна кула ",
Kod="1729",
s="1019372"
},new StopModel()
{
Name="Руско посолство ",
Kod="1496",
s="1019384"
},new StopModel()
{
Name="СТЦ Интерпред ",
Kod="1109",
s="1019404"
},new StopModel()
{
Name="Ж.к.Дианабад ",
Kod="630",
s="1019422"
},new StopModel()
{
Name="СБАЛ по онкология ",
Kod="2542",
s="1017160"
},new StopModel()
{
Name="МГУ Св.Иван Рилски ",
Kod="1033",
s="1017172"
},new StopModel()
{
Name="Бул.д-р Г.М.Димитров ",
Kod="315",
s="1021054"
},new StopModel()
{
Name="Бл.22, ж.к.Дианабад ",
Kod="123",
s="1021058"
},new StopModel()
{
Name=" Ж.к.Дианабад ",
Kod="602",
s="1021074"
},new StopModel()
{
Name=" Моста кв.Витоша ",
Kod="1087",
s="1013414"
},new StopModel()
{
Name=" кв.Витоша ",
Kod="822",
s="1013406"
},new StopModel()
{
Name=" Студентски град ",
Kod="2381",
s="1013394"
},new StopModel()
{
Name=" Хотел Макси ",
Kod="2320",
s="1013384"
},new StopModel()
{
Name=" Хотел Амбасадор ",
Kod="658",
s="1013376"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1172",
s="1013362"
},new StopModel()
{
Name=" Моста на Сухата река ",
Kod="1714",
s="1013356"
},new StopModel()
{
Name=" Ул. Златен век ",
Kod="427",
s="1013330"
},new StopModel()
{
Name=" 64-то ОУ ",
Kod="2279",
s="1013312"
},new StopModel()
{
Name=" Кв. Симеоново ",
Kod="899",
s="1013303"
},}
},new DirectionModel()
{
Name ="Кв. Симеоново - Семинарията",
rid="1001725",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Симеоново",
Kod="899",
s="1013303"
},new StopModel()
{
Name="64-то ОУ ",
Kod="2285",
s="1013313"
},new StopModel()
{
Name="Ул. Златен век ",
Kod="422",
s="1013333"
},new StopModel()
{
Name="Моста на Сухата река ",
Kod="1713",
s="1013357"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1175",
s="1013367"
},new StopModel()
{
Name="Хотел Амбасадор ",
Kod="659",
s="1013377"
},new StopModel()
{
Name="х-л Макси ",
Kod="2321",
s="1013389"
},new StopModel()
{
Name="Студентски град ",
Kod="2382",
s="1013397"
},new StopModel()
{
Name="кв.Витоша ",
Kod="821",
s="1013409"
},new StopModel()
{
Name=" Моста кв.Витоша ",
Kod="1076",
s="1013417"
},new StopModel()
{
Name=" Ж.к.Дианабад ",
Kod="603",
s="1021069"
},new StopModel()
{
Name=" Бл.22, ж.к.Дианабад ",
Kod="124",
s="1021057"
},new StopModel()
{
Name=" Бул.Д-р Г.М.Димитров ",
Kod="316",
s="1017177"
},new StopModel()
{
Name=" МГУ Св.Ив.Рилски ",
Kod="1032",
s="1017169"
},new StopModel()
{
Name=" Метростанция Д-р Г. М. Димитров ",
Kod="2679",
s="1017159"
},new StopModel()
{
Name=" Ж.к.Дианабад ",
Kod="627",
s="1019419"
},new StopModel()
{
Name=" СТЦ Интерпред ",
Kod="1112",
s="1019403"
},new StopModel()
{
Name=" Руско посолство ",
Kod="1493",
s="1019383"
},new StopModel()
{
Name=" Телевизионна кула ",
Kod="1730",
s="1022475"
},new StopModel()
{
Name=" Семинарията ",
Kod="1568",
s="1013464"
},}
},}},

new BusModel()
{
Number = "69",
lid = "1000078",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="СБАЛ по онкология - Царева махала",
rid="1001351",
Stops=new StopModel[]
{new StopModel()
{
Name="СБАЛ по онкология",
Kod="2542",
s="1017160"
},new StopModel()
{
Name="МГУ Св.Иван Рилски ",
Kod="1033",
s="1017172"
},new StopModel()
{
Name="Бул.Д-р Г.М.Димитров ",
Kod="318",
s="1018177"
},new StopModel()
{
Name="Колеж по телекомуникации ",
Kod="1396",
s="1018187"
},new StopModel()
{
Name="Студентска поликлиника ",
Kod="1692",
s="1009993"
},new StopModel()
{
Name="Ж.к.Дървеница ",
Kod="801",
s="1009981"
},new StopModel()
{
Name="Ж.к.Дървеница ",
Kod="1012",
s="1013847"
},new StopModel()
{
Name="СК на НСА ",
Kod="1607",
s="1013827"
},new StopModel()
{
Name="Кв.Малинова долина ",
Kod="426",
s="1013811"
},new StopModel()
{
Name=" Ул.9 ",
Kod="1816",
s="1013801"
},new StopModel()
{
Name=" НЦ по радиобиология ",
Kod="2354",
s="1013793"
},new StopModel()
{
Name=" Ханчето ",
Kod="2304",
s="1013771"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="415",
s="1013759"
},new StopModel()
{
Name=" Моста на Банишка река ",
Kod="1210",
s="1013743"
},new StopModel()
{
Name=" Пречиствателна станция ",
Kod="1413",
s="1013723"
},new StopModel()
{
Name=" В.з. Бункера ",
Kod="409",
s="1013707"
},new StopModel()
{
Name=" В.з. Бункера - по желание ",
Kod="2657",
s="1013697"
},new StopModel()
{
Name=" Ул. 44-та ",
Kod="733",
s="1013691"
},new StopModel()
{
Name=" Ул. 12-та ",
Kod="436",
s="1013671"
},new StopModel()
{
Name=" Бистришки тераси ",
Kod="2546",
s="1013641"
},new StopModel()
{
Name=" Мината ",
Kod="1068",
s="1013629"
},new StopModel()
{
Name=" Начало с. Бистрица ",
Kod="1117",
s="1018543"
},new StopModel()
{
Name=" Село Бистрица ",
Kod="1513",
s="1013950"
},new StopModel()
{
Name=" Края с.Бистрица ",
Kod="1639",
s="1013976"
},new StopModel()
{
Name=" Чешмата ",
Kod="1508",
s="1013988"
},new StopModel()
{
Name=" Манастир Св.Йоаким и Ана ",
Kod="407",
s="1014006"
},new StopModel()
{
Name=" Албена ",
Kod="72",
s="1014032"
},new StopModel()
{
Name=" По желание ",
Kod="1372",
s="1014066"
},new StopModel()
{
Name=" Лифта ",
Kod="1008",
s="1014098"
},new StopModel()
{
Name=" Анева чешма ",
Kod="76",
s="1020430"
},new StopModel()
{
Name=" с.Железница ",
Kod="1530",
s="1020431"
},new StopModel()
{
Name=" Ул.Люляк ",
Kod="1957",
s="1020432"
},new StopModel()
{
Name=" Края с.Железница ",
Kod="1662",
s="1020433"
},new StopModel()
{
Name=" Махала Чемерник ",
Kod="1361",
s="1020434"
},new StopModel()
{
Name=" мотел Бели брези ",
Kod="1104",
s="1020560"
},new StopModel()
{
Name=" Царева махала ",
Kod="2331",
s="1020559"
},}
},new DirectionModel()
{
Name ="Царева махала - СБАЛ по онкология",
rid="1001350",
Stops=new StopModel[]
{new StopModel()
{
Name="Царева махала",
Kod="2331",
s="1020559"
},new StopModel()
{
Name="Мотел Бели брези ",
Kod="1105",
s="1020452"
},new StopModel()
{
Name="Махала Чемерник ",
Kod="1360",
s="1020453"
},new StopModel()
{
Name="Края с.Железница ",
Kod="1661",
s="1020454"
},new StopModel()
{
Name="Ул.Витоша ",
Kod="2500",
s="1020456"
},new StopModel()
{
Name="Кметство Железница ",
Kod="936",
s="1020457"
},new StopModel()
{
Name="Анева чешма ",
Kod="75",
s="1020459"
},new StopModel()
{
Name="Лифта ",
Kod="1007",
s="1014097"
},new StopModel()
{
Name="По желание ",
Kod="1373",
s="1014065"
},new StopModel()
{
Name=" Албена ",
Kod="71",
s="1014033"
},new StopModel()
{
Name=" Манастир Св.Йоаким и Ана ",
Kod="1009",
s="1014005"
},new StopModel()
{
Name=" Чешмата ",
Kod="1507",
s="1013987"
},new StopModel()
{
Name=" Края с.Бистрица ",
Kod="1638",
s="1013971"
},new StopModel()
{
Name=" Село Бистрица ",
Kod="1512",
s="1013949"
},new StopModel()
{
Name=" Начало с. Бистрица ",
Kod="1118",
s="1018542"
},new StopModel()
{
Name=" Мината ",
Kod="1067",
s="1013632"
},new StopModel()
{
Name=" Бистришки тераси - по желание ",
Kod="2547",
s="1013644"
},new StopModel()
{
Name=" Ул. 12-та ",
Kod="437",
s="1013672"
},new StopModel()
{
Name=" Ул. 44-та ",
Kod="734",
s="1013692"
},new StopModel()
{
Name=" В.з. Бункера - по желание ",
Kod="2656",
s="1013698"
},new StopModel()
{
Name=" В.з. Бункера ",
Kod="408",
s="1013710"
},new StopModel()
{
Name=" Пречиствателна станция ",
Kod="1414",
s="1013724"
},new StopModel()
{
Name=" Моста на Банишка река ",
Kod="1211",
s="1013746"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="414",
s="1013760"
},new StopModel()
{
Name=" Ханчето ",
Kod="2300",
s="1013774"
},new StopModel()
{
Name=" НЦ по радиобиология ",
Kod="2353",
s="1013794"
},new StopModel()
{
Name=" Ул.9 ",
Kod="1818",
s="1013802"
},new StopModel()
{
Name=" Кв.Малинова долина ",
Kod="423",
s="1013812"
},new StopModel()
{
Name=" СК на НСА ",
Kod="1608",
s="1013828"
},new StopModel()
{
Name=" Ж.к.Дървеница ",
Kod="1015",
s="1013850"
},new StopModel()
{
Name=" ЛТУ ",
Kod="614",
s="1009963"
},new StopModel()
{
Name=" Технически университет ",
Kod="1743",
s="1009953"
},new StopModel()
{
Name=" СБАЛ по онкология ",
Kod="2542",
s="1017160"
},}
},}},

new BusModel()
{
Number = "72",
lid = "1000001",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Хотел Плиска - Ж.к. Западен парк",
rid="1001058",
Stops=new StopModel[]
{new StopModel()
{
Name="Хотел Плиска",
Kod="2325",
s="1000627"
},new StopModel()
{
Name="бул.Шипченски проход ",
Kod="402",
s="1000611"
},new StopModel()
{
Name="Ул.Гео Милев ",
Kod="1904",
s="1000603"
},new StopModel()
{
Name="Зала Фестивална ",
Kod="729",
s="1000591"
},new StopModel()
{
Name="Ул.Калиманци ",
Kod="1974",
s="1000577"
},new StopModel()
{
Name="ул.Атанас Узунов ",
Kod="1830",
s="1000667"
},new StopModel()
{
Name="Ч-ще Отец Паисий ",
Kod="2367",
s="1000672"
},new StopModel()
{
Name="УЛ.ВЕЛЧО АТАНАСОВ ",
Kod="1866",
s="1000461"
},new StopModel()
{
Name="Гара Подуене ",
Kod="468",
s="1000441"
},new StopModel()
{
Name=" УЛ.ОБОРИЩЕ ",
Kod="2074",
s="1000689"
},new StopModel()
{
Name=" УЛ.ЧЕРКОВНА ",
Kod="2259",
s="1000417"
},new StopModel()
{
Name=" 129-то ОУ ",
Kod="2271",
s="1000694"
},new StopModel()
{
Name=" ВОЕННА АКАДЕМИЯ ",
Kod="442",
s="1000393"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1289",
s="1000695"
},new StopModel()
{
Name=" Ул. Граф Игнатиев ",
Kod="1914",
s="1000357"
},new StopModel()
{
Name=" Ул. 6-ти септември ",
Kod="1808",
s="1000347"
},new StopModel()
{
Name=" Бул.Черни връх ",
Kod="395",
s="1000339"
},new StopModel()
{
Name=" Бул.Витоша ",
Kod="301",
s="1000321"
},new StopModel()
{
Name=" СБАЛ Св.Екатерина ",
Kod="443",
s="1000307"
},new StopModel()
{
Name=" МБАЛ Александровска ",
Kod="1035",
s="1000285"
},new StopModel()
{
Name=" ВМА ",
Kod="418",
s="1000277"
},new StopModel()
{
Name=" Бул. Цар Борис ІІІ ",
Kod="389",
s="1000257"
},new StopModel()
{
Name=" Ул. Гюешево ",
Kod="1157",
s="1000241"
},new StopModel()
{
Name=" Бул.Възкресение ",
Kod="304",
s="1000227"
},new StopModel()
{
Name=" Бул.Вардар ",
Kod="292",
s="1000505"
},new StopModel()
{
Name=" Ул. Проф. Вайганд ",
Kod="2145",
s="1000493"
},new StopModel()
{
Name=" Ж.к. Красна поляна ",
Kod="2162",
s="1000485"
},new StopModel()
{
Name=" Ж.к. Западен парк ",
Kod="620",
s="1011349"
},}
},new DirectionModel()
{
Name ="Ж.к. Западен парк - Хотел Плиска",
rid="1001059",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Западен парк",
Kod="620",
s="1011349"
},new StopModel()
{
Name="Ж.к. Красна поляна ",
Kod="2163",
s="1000486"
},new StopModel()
{
Name="Ул. Проф. Вайганд ",
Kod="2146",
s="1000494"
},new StopModel()
{
Name="Бул.Вардар ",
Kod="293",
s="1000510"
},new StopModel()
{
Name="Бул.Възкресение ",
Kod="307",
s="1000228"
},new StopModel()
{
Name="Ул. Гюешево ",
Kod="1158",
s="1000244"
},new StopModel()
{
Name="ВМА ",
Kod="419",
s="1000278"
},new StopModel()
{
Name="МБАЛ Александровска ",
Kod="1034",
s="1000286"
},new StopModel()
{
Name="СБАЛ Св. Екатерина ",
Kod="444",
s="1000308"
},new StopModel()
{
Name=" бул. Витоша ",
Kod="302",
s="1000320"
},new StopModel()
{
Name=" Бул. Черни връх ",
Kod="398",
s="1000342"
},new StopModel()
{
Name=" Ул. 6-ти септември ",
Kod="1807",
s="1000348"
},new StopModel()
{
Name=" Ул. Граф Игнатиев ",
Kod="1913",
s="1000360"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1290",
s="1000705"
},new StopModel()
{
Name=" Военна академия ",
Kod="440",
s="1000396"
},new StopModel()
{
Name=" 129 -то ОУ ",
Kod="2270",
s="1000408"
},new StopModel()
{
Name=" УЛ.ЧЕРКОВНА ",
Kod="2258",
s="1000420"
},new StopModel()
{
Name=" УЛ.ОБОРИЩЕ ",
Kod="2070",
s="1000432"
},new StopModel()
{
Name=" Гара Подуяне ",
Kod="466",
s="1000448"
},new StopModel()
{
Name=" ул.Велчо Атанасов ",
Kod="1865",
s="1000464"
},new StopModel()
{
Name=" Ч-ще Отец Паисий ",
Kod="2368",
s="1000518"
},new StopModel()
{
Name=" Ул.Георги Минчев ",
Kod="1924",
s="1000534"
},new StopModel()
{
Name=" Ул.Стоил войвода ",
Kod="2189",
s="1000546"
},new StopModel()
{
Name=" ул.Атанас Узунов ",
Kod="1829",
s="1000564"
},new StopModel()
{
Name=" Ул.Калиманци ",
Kod="1973",
s="1000683"
},new StopModel()
{
Name=" Зала Фестивална ",
Kod="730",
s="1000594"
},new StopModel()
{
Name=" ул. Г.Милев ",
Kod="1905",
s="1000606"
},new StopModel()
{
Name=" бул.Шипченски проход ",
Kod="403",
s="1000616"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2324",
s="1000674"
},}
},}},

new BusModel()
{
Number = "73",
lid = "1000107",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к. Гоце Делчев - Ж.к. Овча купел 2",
rid="1000086",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Гоце Делчев",
Kod="600",
s="1014571"
},new StopModel()
{
Name="Ул.Тодор Каблешков ",
Kod="490",
s="1014549"
},new StopModel()
{
Name="29-ти ДКЦ ",
Kod="1226",
s="1014541"
},new StopModel()
{
Name="Ул.Костенски водопад ",
Kod="2011",
s="1014529"
},new StopModel()
{
Name="Ул.Орехова гора ",
Kod="2089",
s="1014521"
},new StopModel()
{
Name="Бул.България ",
Kod="290",
s="1003944"
},new StopModel()
{
Name="Ул. Проф. Д. Атанасов ",
Kod="2135",
s="1003960"
},new StopModel()
{
Name="Ж.к. Красно село ",
Kod="641",
s="1014479"
},new StopModel()
{
Name="АП Земляне ",
Kod="80",
s="1014463"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="564",
s="1014453"
},new StopModel()
{
Name=" Ул.Народно хоро ",
Kod="2054",
s="1014402"
},new StopModel()
{
Name=" НЦ по Рехабилитация ",
Kod="95",
s="1014394"
},new StopModel()
{
Name=" Ул.Любляна ",
Kod="900",
s="1014327"
},new StopModel()
{
Name=" 66-то СОУ ",
Kod="41",
s="1014321"
},new StopModel()
{
Name=" Ул.Калояново ",
Kod="773",
s="1014313"
},new StopModel()
{
Name=" Бул. Никола Петков ",
Kod="347",
s="1014308"
},new StopModel()
{
Name=" Ул.Боряна ",
Kod="1845",
s="1014382"
},new StopModel()
{
Name=" НБУ ",
Kod="69",
s="1014374"
},new StopModel()
{
Name=" ПГСС ",
Kod="1566",
s="1014368"
},new StopModel()
{
Name=" КВ.БУЗЕМА ",
Kod="813",
s="1014362"
},new StopModel()
{
Name=" БЛ.505 Ж.К. ОВЧА КУПЕЛ-1 ",
Kod="227",
s="1014350"
},new StopModel()
{
Name=" БЛ. 527 Ж.К. ОВЧА КУПЕЛ-1 ",
Kod="231",
s="1014342"
},new StopModel()
{
Name=" Ул. Промишлена ",
Kod="2141",
s="1003170"
},new StopModel()
{
Name=" Бл. 32 ж.к. Овча купел 2 ",
Kod="192",
s="1003178"
},new StopModel()
{
Name=" Бл. 25 ж.к. Овча купел 2 ",
Kod="175",
s="1003186"
},new StopModel()
{
Name=" Пазара Овча купел ",
Kod="1708",
s="1003212"
},new StopModel()
{
Name=" Ж.к. Овча купел 2 ",
Kod="682",
s="1020575"
},}
},new DirectionModel()
{
Name ="Ж.к. Овча купел 2 - Ж.К.ГОЦЕ ДЕЛЧЕВ",
rid="1000085",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Овча купел 2",
Kod="684",
s="1020574"
},new StopModel()
{
Name="Пазара Овча купел ",
Kod="1706",
s="1003211"
},new StopModel()
{
Name="Бл. 25 ж.к. Овча купел 2 ",
Kod="174",
s="1003183"
},new StopModel()
{
Name="Бл. 32 ж.к. Овча купел 2 ",
Kod="191",
s="1003175"
},new StopModel()
{
Name="Ул. Промишлена ",
Kod="2140",
s="1003167"
},new StopModel()
{
Name="БЛ. 527 Ж.К. ОВЧА КУПЕЛ-1 ",
Kod="232",
s="1014345"
},new StopModel()
{
Name="БЛ.505 Ж.К. ОВЧА КУПЕЛ-1 ",
Kod="228",
s="1014355"
},new StopModel()
{
Name="Кв.Бузема ",
Kod="812",
s="1014363"
},new StopModel()
{
Name="ПГСС ",
Kod="1567",
s="1014371"
},new StopModel()
{
Name=" НБУ ",
Kod="67",
s="1014377"
},new StopModel()
{
Name=" Ул.Боряна ",
Kod="1844",
s="1014428"
},new StopModel()
{
Name=" Ул.Народен герой ",
Kod="2053",
s="1014422"
},new StopModel()
{
Name=" Ул.Любляна ",
Kod="2037",
s="1014417"
},new StopModel()
{
Name=" НЦ по Рехабилитация ",
Kod="98",
s="1014397"
},new StopModel()
{
Name=" Ул.Народно хоро ",
Kod="2057",
s="1014405"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="569",
s="1014456"
},new StopModel()
{
Name=" АП Земляне ",
Kod="79",
s="1014462"
},new StopModel()
{
Name=" Ж.к. Красно село ",
Kod="637",
s="1014482"
},new StopModel()
{
Name=" Ул.Проф.Д.Атанасов ",
Kod="2134",
s="1003955"
},new StopModel()
{
Name=" Бул.България ",
Kod="291",
s="1014518"
},new StopModel()
{
Name=" Ул.Орехова гора ",
Kod="2088",
s="1014524"
},new StopModel()
{
Name=" Ул.Костенски водопад ",
Kod="2008",
s="1014536"
},new StopModel()
{
Name=" 29-ти ДКЦ ",
Kod="1224",
s="1014544"
},new StopModel()
{
Name=" Ул.Тодор Каблешков ",
Kod="484",
s="1014550"
},new StopModel()
{
Name=" Ж.К.ГОЦЕ ДЕЛЧЕВ ",
Kod="599",
s="1014569"
},}
},}},

new BusModel()
{
Number = "74",
lid = "1000102",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Пл. Централна гара - Ж.К.ГОЦЕ ДЕЛЧЕВ",
rid="1000170",
Stops=new StopModel[]
{new StopModel()
{
Name="Пл. Централна гара",
Kod="1328",
s="1015026"
},new StopModel()
{
Name="Бул. Христо Ботев ",
Kod="382",
s="1002844"
},new StopModel()
{
Name="Ул.Св.Св.Кирил и Методий ",
Kod="2171",
s="1011885"
},new StopModel()
{
Name="Ул.Пиротска ",
Kod="2111",
s="1011895"
},new StopModel()
{
Name="Бул.Ал.Стамболийски ",
Kod="283",
s="1014666"
},new StopModel()
{
Name="Пл.Руски паметник ",
Kod="1295",
s="1014648"
},new StopModel()
{
Name="Бул. Цар Борис ІІІ ",
Kod="393",
s="1000262"
},new StopModel()
{
Name="Център по Хигиена ",
Kod="2343",
s="1012185"
},new StopModel()
{
Name="Бул.Акад.Ив.Гешов ",
Kod="270",
s="1013214"
},new StopModel()
{
Name=" Ж.к.Иван Вазов ",
Kod="626",
s="1013204"
},new StopModel()
{
Name=" Ул.Нишава ",
Kod="2063",
s="1013190"
},new StopModel()
{
Name=" Бул.Гоце Делчев ",
Kod="309",
s="1014582"
},new StopModel()
{
Name=" Ул.Костенски водопад ",
Kod="2008",
s="1014536"
},new StopModel()
{
Name=" 29-ти ДКЦ ",
Kod="1224",
s="1014544"
},new StopModel()
{
Name=" Ул.Тодор Каблешков ",
Kod="484",
s="1014550"
},new StopModel()
{
Name=" Ж.К.ГОЦЕ ДЕЛЧЕВ ",
Kod="599",
s="1014569"
},}
},new DirectionModel()
{
Name ="Ж.к. Гоце Делчев - Пл. Централна гара",
rid="1000171",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Гоце Делчев",
Kod="600",
s="1014571"
},new StopModel()
{
Name="Ул.Тодор Каблешков ",
Kod="490",
s="1014549"
},new StopModel()
{
Name="29-ти ДКЦ ",
Kod="1226",
s="1014541"
},new StopModel()
{
Name="Ул.Костенски водопад ",
Kod="2010",
s="1027530"
},new StopModel()
{
Name="Бул.Гоце Делчев ",
Kod="310",
s="1013185"
},new StopModel()
{
Name="Ул.Нишава ",
Kod="2062",
s="1013193"
},new StopModel()
{
Name="Ж.к.Иван Вазов ",
Kod="623",
s="1013211"
},new StopModel()
{
Name="Бул.Акад.Иван Гешов ",
Kod="269",
s="1012173"
},new StopModel()
{
Name="Център по Хигиена ",
Kod="2342",
s="1012177"
},new StopModel()
{
Name=" Бул. Цар Борис ІІІ ",
Kod="392",
s="1012205"
},new StopModel()
{
Name=" Пл.Руски паметник ",
Kod="1300",
s="1014649"
},new StopModel()
{
Name=" Бул.Александър Стамболийски ",
Kod="284",
s="1014667"
},new StopModel()
{
Name=" Ул.Пиротска ",
Kod="2114",
s="1011892"
},new StopModel()
{
Name=" Ул.Св.Св.Кирил и Методий ",
Kod="2170",
s="1011882"
},new StopModel()
{
Name=" Ул. Охрид ",
Kod="2101",
s="1016896"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2079",
s="1006608"
},new StopModel()
{
Name=" Пл. Централна гара ",
Kod="1328",
s="1015026"
},}
},}},

new BusModel()
{
Number = "75",
lid = "1000080",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Гео Милев - Пл.Орлов мост",
rid="1000840",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Гео Милев",
Kod="53",
s="1002618"
},new StopModel()
{
Name="Ж.к.Слатина ",
Kod="690",
s="1000891"
},new StopModel()
{
Name="бл.15 ж.к.Хр.Смирненски ",
Kod="140",
s="1014736"
},new StopModel()
{
Name="бл. 7 ж.к. Хр. Смирненски ",
Kod="250",
s="1014726"
},new StopModel()
{
Name="бл.33 ж.к. Слатина ",
Kod="105",
s="1014708"
},new StopModel()
{
Name="ул. Иван Щерев ",
Kod="1954",
s="1014700"
},new StopModel()
{
Name="УЛ.БОЯН МАГЕСНИК ",
Kod="1847",
s="1001171"
},new StopModel()
{
Name="УЛ.ВЕЛЧО АТАНАСОВ ",
Kod="1866",
s="1000461"
},new StopModel()
{
Name="Гара Подуене ",
Kod="471",
s="1001275"
},new StopModel()
{
Name=" Театър София ",
Kod="1724",
s="1001061"
},new StopModel()
{
Name=" ВОЕННА АКАДЕМИЯ ",
Kod="442",
s="1000393"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1289",
s="1000695"
},}
},new DirectionModel()
{
Name ="Пл.Орлов мост - Автостанция Гео Милев",
rid="1000839",
Stops=new StopModel[]
{new StopModel()
{
Name="Пл.Орлов мост",
Kod="1290",
s="1000705"
},new StopModel()
{
Name="Военна академия ",
Kod="440",
s="1000396"
},new StopModel()
{
Name="Театър София ",
Kod="1728",
s="1001056"
},new StopModel()
{
Name="Гара Подуяне ",
Kod="466",
s="1000448"
},new StopModel()
{
Name="УЛ.ВЕЛЧО АТАНАСОВ ",
Kod="1867",
s="1001166"
},new StopModel()
{
Name="УЛ.БОЯН МАГЕСНИК ",
Kod="1846",
s="1001172"
},new StopModel()
{
Name="ул.Иван Щерев ",
Kod="1955",
s="1014703"
},new StopModel()
{
Name="бл. 33 ж.к. Слатина ",
Kod="109",
s="1014711"
},new StopModel()
{
Name="бл. 7 ж.к. Хр. Смирненски ",
Kod="249",
s="1014731"
},new StopModel()
{
Name=" бл.15 ж.к. Хр. Смирненски ",
Kod="139",
s="1014739"
},new StopModel()
{
Name=" Ж.к.Слатина ",
Kod="687",
s="1002627"
},new StopModel()
{
Name=" Автостанция Гео Милев ",
Kod="52",
s="1002619"
},}
},}},

new BusModel()
{
Number = "76",
lid = "1000081",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="ж.к. Младост 4 - Ж.к. Гоце Делчев",
rid="1001810",
Stops=new StopModel[]
{new StopModel()
{
Name="ж.к. Младост 4",
Kod="670",
s="1018547"
},new StopModel()
{
Name="бл.465 ж.к.Младост 4 ",
Kod="224",
s="1003272"
},new StopModel()
{
Name="115-ти пощенски клон ",
Kod="1759",
s="1003331"
},new StopModel()
{
Name="бл. 427 ж.к.Младост 4 ",
Kod="213",
s="1014827"
},new StopModel()
{
Name="Бл.325 ж.к.Младост 3 ",
Kod="2489",
s="1027614"
},new StopModel()
{
Name="Бл.323 ж.к.Младост 3 ",
Kod="2487",
s="1027725"
},new StopModel()
{
Name="Ул. Д-р Ат. Москов ",
Kod="1917",
s="1009077"
},new StopModel()
{
Name="Бл. 222 ж.к. Младост 2 ",
Kod="168",
s="1009067"
},new StopModel()
{
Name="Бл. 56 ж.к. Младост 1 ",
Kod="234",
s="1017085"
},new StopModel()
{
Name=" Бл.43 ж.к.Младост 1 ",
Kod="218",
s="1003285"
},new StopModel()
{
Name=" ХМС ",
Kod="2319",
s="1003279"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="555",
s="1001968"
},new StopModel()
{
Name=" Хермес парк ",
Kod="2593",
s="1001978"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1196",
s="1001988"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2327",
s="1003436"
},new StopModel()
{
Name=" Полиграфически комбинат ",
Kod="1395",
s="1003488"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1289",
s="1000695"
},new StopModel()
{
Name=" Ул. Граф Игнатиев ",
Kod="1914",
s="1000357"
},new StopModel()
{
Name=" Ул. 6-ти септември ",
Kod="1808",
s="1000347"
},new StopModel()
{
Name=" Бул. Черни връх ",
Kod="401",
s="1000343"
},new StopModel()
{
Name=" ПГ Текстил и моден дизайн ",
Kod="1739",
s="1003894"
},new StopModel()
{
Name=" Бул.Акад.Ив.Гешов ",
Kod="270",
s="1013214"
},new StopModel()
{
Name=" Ж.к.Иван Вазов ",
Kod="626",
s="1013204"
},new StopModel()
{
Name=" Ул.Нишава ",
Kod="2063",
s="1013190"
},new StopModel()
{
Name=" Бул.Гоце Делчев ",
Kod="309",
s="1014582"
},new StopModel()
{
Name=" Ул.Костенски водопад ",
Kod="2008",
s="1014536"
},new StopModel()
{
Name=" 29-ти ДКЦ ",
Kod="1224",
s="1014544"
},new StopModel()
{
Name=" Ул.Тодор Каблешков ",
Kod="484",
s="1014550"
},new StopModel()
{
Name=" Ж.к. Гоце Делчев ",
Kod="600",
s="1014571"
},}
},new DirectionModel()
{
Name ="Ж.к. Гоце Делчев - ж.к. Младост 4",
rid="1001811",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Гоце Делчев",
Kod="600",
s="1014571"
},new StopModel()
{
Name="Ул.Тодор Каблешков ",
Kod="490",
s="1014549"
},new StopModel()
{
Name="29-ти ДКЦ ",
Kod="1226",
s="1014541"
},new StopModel()
{
Name="Ул.Костенски водопад ",
Kod="2010",
s="1027530"
},new StopModel()
{
Name="Бул.Гоце Делчев ",
Kod="310",
s="1013185"
},new StopModel()
{
Name="Ул.Нишава ",
Kod="2062",
s="1013193"
},new StopModel()
{
Name="Ж.к.Иван Вазов ",
Kod="623",
s="1013211"
},new StopModel()
{
Name="Бул.Акад.Ив.Гешов ",
Kod="268",
s="1003901"
},new StopModel()
{
Name="ПГ Текстил и моден дизайн ",
Kod="1736",
s="1003893"
},new StopModel()
{
Name=" Бул. Черни връх ",
Kod="398",
s="1000342"
},new StopModel()
{
Name=" Ул. 6-ти септември ",
Kod="1807",
s="1000348"
},new StopModel()
{
Name=" Ул. Граф Игнатиев ",
Kod="1913",
s="1000360"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1287",
s="1003503"
},new StopModel()
{
Name=" Полиграфически комбинат ",
Kod="1394",
s="1003489"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2326",
s="1003435"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name=" ХМС ",
Kod="2318",
s="1003282"
},new StopModel()
{
Name=" Бл.43 ж.к.Младост 1 ",
Kod="217",
s="1003288"
},new StopModel()
{
Name=" Бл. 56 ж.к. Младост 1 ",
Kod="233",
s="1017086"
},new StopModel()
{
Name=" Бл. 223 ж.к. Младост 2 ",
Kod="169",
s="1009062"
},new StopModel()
{
Name=" Бл. 222 ж.к. Младост 2 ",
Kod="167",
s="1009068"
},new StopModel()
{
Name=" Ул.д-р Атанас Москов ",
Kod="1918",
s="1009082"
},new StopModel()
{
Name=" Бл.323 ж.к.Младост 3 ",
Kod="2486",
s="1027716"
},new StopModel()
{
Name=" Бл.325 ж.к.Младост 3 ",
Kod="2488",
s="1027605"
},new StopModel()
{
Name=" бл.427 ж.к. Младост 4 ",
Kod="214",
s="1014830"
},new StopModel()
{
Name=" 115-ти пощенски клон ",
Kod="1760",
s="1003332"
},new StopModel()
{
Name=" бл.465 ж.к. Младост 4 ",
Kod="223",
s="1014841"
},new StopModel()
{
Name=" ж.к. Младост 4 ",
Kod="669",
s="1018551"
},}
},}},

new BusModel()
{
Number = "77",
lid = "1000008",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к. Западен парк - Пл. Централна гара",
rid="1001075",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Западен парк",
Kod="620",
s="1011349"
},new StopModel()
{
Name="Ж.к. Красна поляна ",
Kod="2163",
s="1000486"
},new StopModel()
{
Name="Ул. Проф. Вайганд ",
Kod="2146",
s="1000494"
},new StopModel()
{
Name="Бул.Вардар ",
Kod="296",
s="1015006"
},new StopModel()
{
Name="бул. Ал. Стамболийски ",
Kod="281",
s="1014990"
},new StopModel()
{
Name="Метростанция Вардар ",
Kod="1044",
s="1014976"
},new StopModel()
{
Name="Ул. Хайдут Сидер ",
Kod="2229",
s="1014966"
},new StopModel()
{
Name="Гара Захарна фабрика ",
Kod="451",
s="1014944"
},new StopModel()
{
Name="УЛ.КРУМ СТОЯНОВ ",
Kod="2016",
s="1010747"
},new StopModel()
{
Name=" УЛ.ЙОСИФ ЩРОСМАЙЕР ",
Kod="1968",
s="1014889"
},new StopModel()
{
Name=" Ул. Иван Йосифов ",
Kod="1951",
s="1014881"
},new StopModel()
{
Name=" Надлез Надежда ",
Kod="2116",
s="1014867"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2079",
s="1006608"
},new StopModel()
{
Name=" Пл. Централна гара ",
Kod="1328",
s="1015026"
},}
},new DirectionModel()
{
Name ="Пл. Централна гара - Ж.к. Западен парк",
rid="1001074",
Stops=new StopModel[]
{new StopModel()
{
Name="Пл. Централна гара",
Kod="1328",
s="1015026"
},new StopModel()
{
Name="Ул.Клокотница ",
Kod="1326",
s="1015029"
},new StopModel()
{
Name="Бул. Христо Ботев ",
Kod="382",
s="1002844"
},new StopModel()
{
Name="Ул. Опълченска ",
Kod="2081",
s="1002854"
},new StopModel()
{
Name="Ул. Охрид ",
Kod="2101",
s="1016896"
},new StopModel()
{
Name="Бул. Княгиня Мария Луиза ",
Kod="323",
s="1016899"
},new StopModel()
{
Name="Надлез Надежда ",
Kod="1114",
s="1006463"
},new StopModel()
{
Name="Надлез Надежда ",
Kod="2115",
s="1014878"
},new StopModel()
{
Name="Ул. Иван Йосифов ",
Kod="1950",
s="1014884"
},new StopModel()
{
Name=" Ул. Йосиф Щросмайер ",
Kod="1971",
s="1010750"
},new StopModel()
{
Name=" УЛ.КРУМ СТОЯНОВ ",
Kod="2015",
s="1010744"
},new StopModel()
{
Name=" Гара Захарна фабрика ",
Kod="452",
s="1014947"
},new StopModel()
{
Name=" Ул. Хайдут Сидер ",
Kod="2226",
s="1014967"
},new StopModel()
{
Name=" Метростанция Вардар ",
Kod="1047",
s="1014979"
},new StopModel()
{
Name=" Бул.Ал.Стамболийски ",
Kod="282",
s="1014997"
},new StopModel()
{
Name=" Бул.Вардар ",
Kod="292",
s="1000505"
},new StopModel()
{
Name=" Ул. Проф. Вайганд ",
Kod="2145",
s="1000493"
},new StopModel()
{
Name=" Ж.к. Красна поляна ",
Kod="2162",
s="1000485"
},new StopModel()
{
Name=" Ж.к. Западен парк ",
Kod="620",
s="1011349"
},}
},}},

new BusModel()
{
Number = "78",
lid = "1000052",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Площада кв.Враждебна - Централна гара",
rid="1001193",
Stops=new StopModel[]
{new StopModel()
{
Name="Площада кв.Враждебна",
Kod="2459",
s="1026399"
},new StopModel()
{
Name="кв. Враждебна ",
Kod="824",
s="1004548"
},new StopModel()
{
Name="Моста кв.Враждебна ",
Kod="1093",
s="1004532"
},new StopModel()
{
Name="Ул.3 ",
Kod="1795",
s="1004512"
},new StopModel()
{
Name="ул.61 ",
Kod="1811",
s="1004490"
},new StopModel()
{
Name="Сервиз Изток ",
Kod="1581",
s="1005539"
},new StopModel()
{
Name="СЕРВИЗ Изток ",
Kod="1580",
s="1017923"
},new StopModel()
{
Name="Автостанция Изток ",
Kod="2427",
s="1004381"
},new StopModel()
{
Name="Ул. Ст. Доспевски ",
Kod="2180",
s="1004403"
},new StopModel()
{
Name=" Бл. 11 ж.к. Левски В ",
Kod="130",
s="1004413"
},new StopModel()
{
Name=" Бл. 28 ж.к.Левски-Г ",
Kod="181",
s="1015190"
},new StopModel()
{
Name=" Бл. 10 ж.к. Левски-Г ",
Kod="127",
s="1015178"
},new StopModel()
{
Name=" Ул. Поп Грую ",
Kod="2124",
s="1015166"
},new StopModel()
{
Name=" Ул. Витиня ",
Kod="1754",
s="1015144"
},new StopModel()
{
Name=" Стадион Г.Аспарухов ",
Kod="1613",
s="1015126"
},new StopModel()
{
Name=" Ул.Васил Кънчев ",
Kod="1862",
s="1001029"
},new StopModel()
{
Name=" Хипермаркет Била ",
Kod="2108",
s="1001035"
},new StopModel()
{
Name=" Мостът Чавдар ",
Kod="1103",
s="1015065"
},new StopModel()
{
Name=" Ул. Бяло море ",
Kod="1856",
s="1015047"
},new StopModel()
{
Name=" Бул.Васил Левски ",
Kod="297",
s="1015043"
},new StopModel()
{
Name=" Ул.Искър ",
Kod="1965",
s="1015039"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1313",
s="1015035"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1311",
s="1002810"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1275",
s="1002828"
},new StopModel()
{
Name=" Централна гара ",
Kod="1327",
s="1003523"
},}
},new DirectionModel()
{
Name ="Централна гара - Площада кв.Враждебна",
rid="1001192",
Stops=new StopModel[]
{new StopModel()
{
Name="Централна гара",
Kod="1327",
s="1003523"
},new StopModel()
{
Name="Ул.Клокотница ",
Kod="1326",
s="1015029"
},new StopModel()
{
Name="Пл.Лъвов мост ",
Kod="1278",
s="1002825"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1316",
s="1002791"
},new StopModel()
{
Name="Ул.Бяло море ",
Kod="1859",
s="1002775"
},new StopModel()
{
Name="Мостът Чавдар ",
Kod="1102",
s="1015066"
},new StopModel()
{
Name="Бул. Владимир Вазов ",
Kod="303",
s="1001034"
},new StopModel()
{
Name="Хипермаркет Била ",
Kod="2107",
s="1001030"
},new StopModel()
{
Name="Ул.Васил Кънчев ",
Kod="1863",
s="1015121"
},new StopModel()
{
Name=" Стадион Г.Аспарухов ",
Kod="1615",
s="1015133"
},new StopModel()
{
Name=" Ул.Витиня ",
Kod="1753",
s="1015145"
},new StopModel()
{
Name=" Ж.к. Левски -В ",
Kod="2125",
s="1015163"
},new StopModel()
{
Name=" Ж.к.Левски-Г ",
Kod="660",
s="1015173"
},new StopModel()
{
Name=" Бл. 10 ж.к. Левски-Г ",
Kod="126",
s="1015181"
},new StopModel()
{
Name=" Бл. 28 ж.к. Левски-Г ",
Kod="179",
s="1015191"
},new StopModel()
{
Name=" Бл. 11 ж.к. Левски В ",
Kod="131",
s="1004410"
},new StopModel()
{
Name=" Ул. Ст. Доспевски ",
Kod="2181",
s="1022595"
},new StopModel()
{
Name=" Автостанция Изток ",
Kod="2428",
s="1004378"
},new StopModel()
{
Name=" СЕРВИЗ Изток ",
Kod="1583",
s="1017922"
},new StopModel()
{
Name=" ПЪТЯ ЗА ЛЕТИЩЕ ВРАЖДЕБНА ",
Kod="2407",
s="1017890"
},new StopModel()
{
Name=" Сервиз Изток ",
Kod="1582",
s="1004469"
},new StopModel()
{
Name=" Ул.61 ",
Kod="1812",
s="1004491"
},new StopModel()
{
Name=" Ул.3 ",
Kod="1794",
s="1004515"
},new StopModel()
{
Name=" Моста кв. Враждебна ",
Kod="1092",
s="1004533"
},new StopModel()
{
Name=" Кв. Враждебна ",
Kod="823",
s="1004549"
},new StopModel()
{
Name=" Площада кв.Враждебна ",
Kod="2459",
s="1026399"
},}
},}},

new BusModel()
{
Number = "79",
lid = "1000053",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Кв. Христо Ботев - Стинд 2",
rid="1000089",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Христо Ботев",
Kod="913",
s="1015442"
},new StopModel()
{
Name="Ул. 507 ",
Kod="1804",
s="1015450"
},new StopModel()
{
Name="Ул.503 ",
Kod="1065",
s="1015505"
},new StopModel()
{
Name="Ул.Княгиня Косара ",
Kod="711",
s="1015489"
},new StopModel()
{
Name="Ул.Бесарабия ",
Kod="1841",
s="1015483"
},new StopModel()
{
Name="УЛ.ВИТИНЯ ",
Kod="1874",
s="1015475"
},new StopModel()
{
Name="Бл.6 ж.к.Сухата река ",
Kod="1476",
s="1015471"
},new StopModel()
{
Name="Бл.4 ж.к.Сухата река ",
Kod="1470",
s="1015463"
},new StopModel()
{
Name="Пл.Пирдоп ",
Kod="1291",
s="1015455"
},new StopModel()
{
Name=" Ул.Тодорини кукли ",
Kod="2217",
s="1001149"
},new StopModel()
{
Name=" Ул.Васил Кънчев ",
Kod="1862",
s="1001029"
},new StopModel()
{
Name=" Хипермаркет Била ",
Kod="2108",
s="1001035"
},new StopModel()
{
Name=" Мостът Чавдар ",
Kod="1103",
s="1015065"
},new StopModel()
{
Name=" Ул. Бяло море ",
Kod="1856",
s="1015047"
},new StopModel()
{
Name=" Бул.Васил Левски ",
Kod="297",
s="1015043"
},new StopModel()
{
Name=" Ул.Искър ",
Kod="1965",
s="1015039"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1313",
s="1015035"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1312",
s="1015264"
},new StopModel()
{
Name=" Хладилен завод ",
Kod="2309",
s="1015282"
},new StopModel()
{
Name=" Централен гробищен парк ",
Kod="1945",
s="1015294"
},new StopModel()
{
Name=" Ул.202 ",
Kod="65",
s="1015316"
},new StopModel()
{
Name=" ТЕЦ София ",
Kod="1747",
s="1015320"
},new StopModel()
{
Name=" Котлостроене АД ",
Kod="718",
s="1015328"
},new StopModel()
{
Name=" Бул. Илиянци - подлеза ",
Kod="1384",
s="1015344"
},new StopModel()
{
Name=" УЛ.ПРОСВЕТА ",
Kod="2519",
s="1015352"
},new StopModel()
{
Name=" Ул. Локомотив ",
Kod="1000",
s="1015364"
},new StopModel()
{
Name=" ПГВАД ",
Kod="1723",
s="1015376"
},new StopModel()
{
Name=" Производствен к-с Москва ",
Kod="537",
s="1015380"
},new StopModel()
{
Name=" Стинд 1 ",
Kod="549",
s="1015384"
},new StopModel()
{
Name=" Стинд 2 ",
Kod="551",
s="1015391"
},}
},new DirectionModel()
{
Name ="Стинд 2 - Кв. Христо Ботев",
rid="1000090",
Stops=new StopModel[]
{new StopModel()
{
Name="Стинд 2",
Kod="551",
s="1015391"
},new StopModel()
{
Name="Стинд 1 ",
Kod="550",
s="1015383"
},new StopModel()
{
Name="Производстен к-с Москва ",
Kod="538",
s="1015379"
},new StopModel()
{
Name="ПГВАД ",
Kod="1722",
s="1015371"
},new StopModel()
{
Name="Ул. Локомотив ",
Kod="1001",
s="1015361"
},new StopModel()
{
Name="Ул. Просвета ",
Kod="2143",
s="1015351"
},new StopModel()
{
Name="Бул.Илиянци-подлеза ",
Kod="1385",
s="1015339"
},new StopModel()
{
Name="Котлостроене АД ",
Kod="717",
s="1015327"
},new StopModel()
{
Name="ТЕЦ София ",
Kod="1748",
s="1015319"
},new StopModel()
{
Name=" Ул.202 ",
Kod="66",
s="1015311"
},new StopModel()
{
Name=" Централен гробищен парк ",
Kod="1944",
s="1015291"
},new StopModel()
{
Name=" Хладилен завод ",
Kod="2312",
s="1015281"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1316",
s="1002791"
},new StopModel()
{
Name=" Ул.Бяло море ",
Kod="1859",
s="1002775"
},new StopModel()
{
Name=" Мостът Чавдар ",
Kod="1102",
s="1015066"
},new StopModel()
{
Name=" Бул. Владимир Вазов ",
Kod="303",
s="1001034"
},new StopModel()
{
Name=" 143-то ОУ ",
Kod="2396",
s="1015399"
},new StopModel()
{
Name=" Ул.Тодорини кукли ",
Kod="2215",
s="1001152"
},new StopModel()
{
Name=" Пл.Пирдоп ",
Kod="1294",
s="1015462"
},new StopModel()
{
Name=" Бл.4 ж.к.Сухата река ",
Kod="1469",
s="1015466"
},new StopModel()
{
Name=" Бл.6 ж.к. Сухата река ",
Kod="1475",
s="1015472"
},new StopModel()
{
Name=" УЛ.ВИТИНЯ ",
Kod="1870",
s="1015478"
},new StopModel()
{
Name=" Ул.Бесарабия ",
Kod="1843",
s="1015486"
},new StopModel()
{
Name=" Ул. Княгиня Косара ",
Kod="712",
s="1015492"
},new StopModel()
{
Name=" Ул. 503 ",
Kod="1064",
s="1015508"
},new StopModel()
{
Name=" Ул. 507 ",
Kod="1805",
s="1015437"
},new StopModel()
{
Name=" Кв. Христо Ботев ",
Kod="913",
s="1015442"
},}
},}},

new BusModel()
{
Number = "81",
lid = "1000027",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Кв. Иваняне - Гара Обеля",
rid="1000423",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Иваняне",
Kod="840",
s="1016019"
},new StopModel()
{
Name="Кметство Иваняне ",
Kod="960",
s="1016011"
},new StopModel()
{
Name="Начало кв.Иваняне ",
Kod="1380",
s="1016003"
},new StopModel()
{
Name="По желание ",
Kod="1378",
s="1015987"
},new StopModel()
{
Name="Ул. Драва ",
Kod="1938",
s="1015927"
},new StopModel()
{
Name="Центъра кв. Филиповци ",
Kod="2347",
s="1015915"
},new StopModel()
{
Name="Ул.Български войн ",
Kod="1852",
s="1015909"
},new StopModel()
{
Name="Ул.Детелина ",
Kod="1482",
s="1015905"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1169",
s="1015895"
},new StopModel()
{
Name=" Ул.Филиповско шосе ",
Kod="908",
s="1015887"
},new StopModel()
{
Name=" Бл.402 ж.к.Люлин 4 ",
Kod="208",
s="1015875"
},new StopModel()
{
Name=" Бл.350 ж.к.Люлин 3 ",
Kod="197",
s="1015859"
},new StopModel()
{
Name=" Бл.264 ж.к.Люлин 2 ",
Kod="152",
s="1015853"
},new StopModel()
{
Name=" Бл.11 ж.к.Люлин-1 ",
Kod="1388",
s="1010565"
},new StopModel()
{
Name=" ПП Успех ",
Kod="1751",
s="1010583"
},new StopModel()
{
Name=" НЕСТЛЕ София ",
Kod="1140",
s="1010595"
},new StopModel()
{
Name=" Метростанция Сливница ",
Kod="1062",
s="1015758"
},new StopModel()
{
Name=" Хит маркет Люлин ",
Kod="2065",
s="1015750"
},new StopModel()
{
Name=" Бл.119 ж.к.Обеля-1 ",
Kod="2443",
s="1026002"
},new StopModel()
{
Name=" Метростанция Обеля ",
Kod="6240",
s="1028322"
},new StopModel()
{
Name=" Ул.2 ",
Kod="1792",
s="1006502"
},new StopModel()
{
Name=" Ул.9 ",
Kod="1817",
s="1006506"
},new StopModel()
{
Name=" Кв. Обеля ",
Kod="871",
s="1015707"
},new StopModel()
{
Name=" Гара Обеля ",
Kod="461",
s="1015721"
},}
},new DirectionModel()
{
Name ="Гара Обеля - Кв. Иваняне",
rid="1000422",
Stops=new StopModel[]
{new StopModel()
{
Name="Гара Обеля",
Kod="460",
s="1015718"
},new StopModel()
{
Name="Кв. Обеля ",
Kod="874",
s="1015706"
},new StopModel()
{
Name="Ул.9 ",
Kod="1815",
s="1006509"
},new StopModel()
{
Name="Ул.2 ",
Kod="1793",
s="1006501"
},new StopModel()
{
Name="Метростанция Обеля ",
Kod="6241",
s="1026043"
},new StopModel()
{
Name="Бл.119 ж.к.Обеля-1 ",
Kod="2442",
s="1026005"
},new StopModel()
{
Name="Хит маркет Люлин ",
Kod="2064",
s="1015753"
},new StopModel()
{
Name="Метростанция Сливница ",
Kod="1059",
s="1010598"
},new StopModel()
{
Name="Нестле София ",
Kod="1141",
s="1010590"
},new StopModel()
{
Name=" ПП Успех ",
Kod="1752",
s="1010580"
},new StopModel()
{
Name=" Мосю Бриколаж ",
Kod="2385",
s="1010568"
},new StopModel()
{
Name=" Бл. 11 ж.к. Люлин 1 ",
Kod="1391",
s="1010562"
},new StopModel()
{
Name=" Бл.264 ж.к.Люлин-2 ",
Kod="153",
s="1015854"
},new StopModel()
{
Name=" Бл.350 ж.к.Люлин-3 ",
Kod="200",
s="1015864"
},new StopModel()
{
Name=" Ж.к.Люлин-3 ",
Kod="654",
s="1015874"
},new StopModel()
{
Name=" Ул.Филиповско шосе ",
Kod="907",
s="1015888"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1191",
s="1015898"
},new StopModel()
{
Name=" Ул.Детелина ",
Kod="1477",
s="1015906"
},new StopModel()
{
Name=" Ул. Български войн ",
Kod="1853",
s="1015912"
},new StopModel()
{
Name=" Център кв. Филиповци ",
Kod="2346",
s="1015922"
},new StopModel()
{
Name=" Ул. Драва ",
Kod="1937",
s="1015930"
},new StopModel()
{
Name=" По желание ",
Kod="1379",
s="1015988"
},new StopModel()
{
Name=" Начало кв.Иваняне ",
Kod="1381",
s="1016004"
},new StopModel()
{
Name=" Кметство Иваняне ",
Kod="959",
s="1016012"
},new StopModel()
{
Name=" Кв. Иваняне ",
Kod="840",
s="1016019"
},}
},}},

new BusModel()
{
Number = "82",
lid = "1000054",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Пл. Централна гара - ж.к. Люлин -5",
rid="1001731",
Stops=new StopModel[]
{new StopModel()
{
Name="Пл. Централна гара",
Kod="1328",
s="1015026"
},new StopModel()
{
Name="Ул.Клокотница ",
Kod="1326",
s="1015029"
},new StopModel()
{
Name="Бул. Христо Ботев ",
Kod="382",
s="1002844"
},new StopModel()
{
Name="Ул. Опълченска ",
Kod="2081",
s="1002854"
},new StopModel()
{
Name="Ул. Охрид ",
Kod="2101",
s="1016896"
},new StopModel()
{
Name="Бул. Княгиня Мария Луиза ",
Kod="323",
s="1016899"
},new StopModel()
{
Name="Надлез Надежда ",
Kod="1114",
s="1006463"
},new StopModel()
{
Name="Надлез Надежда ",
Kod="2115",
s="1014878"
},new StopModel()
{
Name="Ул. Иван Йосифов ",
Kod="1950",
s="1014884"
},new StopModel()
{
Name=" Ул. Йосиф Щросмайер ",
Kod="1971",
s="1010750"
},new StopModel()
{
Name=" УЛ.КРУМ СТОЯНОВ ",
Kod="2015",
s="1010744"
},new StopModel()
{
Name=" М-ТЕЛ ",
Kod="752",
s="1010734"
},new StopModel()
{
Name=" ИНЖСТРОЙ София АД ",
Kod="757",
s="1010724"
},new StopModel()
{
Name=" БЛ. 35 ж.к. Захарна фабрика ",
Kod="195",
s="1010710"
},new StopModel()
{
Name=" СПИИДО ЕООД ",
Kod="715",
s="1010692"
},new StopModel()
{
Name=" ул. Връх Манчо ",
Kod="1199",
s="1010674"
},new StopModel()
{
Name=" УЛ.ОРИОН ",
Kod="2091",
s="1003662"
},new StopModel()
{
Name=" ул. Луи Пастьор ",
Kod="2166",
s="1003652"
},new StopModel()
{
Name=" Читалище св.св. Кирил и Методий ",
Kod="511",
s="1003648"
},new StopModel()
{
Name=" ТРИЪГЪЛНИКА-ЛЮЛИН ",
Kod="1781",
s="1003638"
},new StopModel()
{
Name=" Метростанция Сливница ",
Kod="1061",
s="1021873"
},new StopModel()
{
Name=" Бул.Панчо Владигеров ",
Kod="1782",
s="1003618"
},new StopModel()
{
Name=" 26-ти ДКЦ ",
Kod="20",
s="1003612"
},new StopModel()
{
Name=" 90-то СОУ ",
Kod="2272",
s="1003608"
},new StopModel()
{
Name=" Бл.21 ж.к.Люлин-1 ",
Kod="1163",
s="1003600"
},new StopModel()
{
Name=" Бл.264 ж.к.Люлин-2 ",
Kod="153",
s="1015854"
},new StopModel()
{
Name=" Бл.350 ж.к.Люлин-3 ",
Kod="200",
s="1015864"
},new StopModel()
{
Name=" Ж.к.Люлин-3 ",
Kod="654",
s="1015874"
},new StopModel()
{
Name=" ж.к. Люлин -5 ",
Kod="657",
s="1016046"
},}
},new DirectionModel()
{
Name ="ж.к. Люлин -5 - Пл. Централна гара",
rid="1001732",
Stops=new StopModel[]
{new StopModel()
{
Name="ж.к. Люлин -5",
Kod="657",
s="1016048"
},new StopModel()
{
Name="Ж.к.Люлин 3 ",
Kod="651",
s="1015871"
},new StopModel()
{
Name="Бл.350 ж.к.Люлин 3 ",
Kod="197",
s="1015859"
},new StopModel()
{
Name="Бл.264 ж.к.Люлин 2 ",
Kod="152",
s="1015853"
},new StopModel()
{
Name="Бл.21 ж.к.Люлин 1 ",
Kod="1164",
s="1003601"
},new StopModel()
{
Name="90-то СОУ ",
Kod="2277",
s="1003609"
},new StopModel()
{
Name="26-ти ДКЦ ",
Kod="21",
s="1003613"
},new StopModel()
{
Name="Ул.Проф.А.Станишев ",
Kod="2357",
s="1003625"
},new StopModel()
{
Name="МЕТРОСТАНЦИЯ СЛИВНИЦА ",
Kod="1060",
s="1003635"
},new StopModel()
{
Name=" ТРИЪГЪЛНИКА-ЛЮЛИН ",
Kod="1783",
s="1003641"
},new StopModel()
{
Name=" Читалище св.св. Кирил и Методий ",
Kod="512",
s="1003647"
},new StopModel()
{
Name=" ул. Луи Пастьор ",
Kod="2167",
s="1003655"
},new StopModel()
{
Name=" Ул.Орион ",
Kod="2090",
s="1010663"
},new StopModel()
{
Name=" ул. Връх Манчо ",
Kod="1200",
s="1010679"
},new StopModel()
{
Name=" СПИИДО ЕООД ",
Kod="716",
s="1010691"
},new StopModel()
{
Name=" БЛ. 35 ж.к. Захарна фабрика ",
Kod="196",
s="1010711"
},new StopModel()
{
Name=" ИНЖСТРОЙ София АД ",
Kod="756",
s="1010725"
},new StopModel()
{
Name=" М-ТЕЛ ",
Kod="753",
s="1010739"
},new StopModel()
{
Name=" УЛ.КРУМ СТОЯНОВ ",
Kod="2016",
s="1010747"
},new StopModel()
{
Name=" УЛ.ЙОСИФ ЩРОСМАЙЕР ",
Kod="1968",
s="1014889"
},new StopModel()
{
Name=" Ул. Иван Йосифов ",
Kod="1951",
s="1014881"
},new StopModel()
{
Name=" Надлез Надежда ",
Kod="2116",
s="1014867"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2079",
s="1006608"
},new StopModel()
{
Name=" Пл. Централна гара ",
Kod="1328",
s="1015026"
},}
},}},

new BusModel()
{
Number = "83",
lid = "1000009",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Зоопарка - Хюндай България",
rid="1000654",
Stops=new StopModel[]
{new StopModel()
{
Name="Зоопарка",
Kod="749",
s="1016359"
},new StopModel()
{
Name="КП Бенакс ",
Kod="977",
s="1016353"
},new StopModel()
{
Name="Хлебозавода ",
Kod="2314",
s="1016335"
},new StopModel()
{
Name="Кв. Хладилника ",
Kod="909",
s="1013085"
},new StopModel()
{
Name="Ул. Иван Андонов ",
Kod="1801",
s="1016300"
},new StopModel()
{
Name="Южен парк ",
Kod="860",
s="1016282"
},new StopModel()
{
Name="Ул.Луи Айер ",
Kod="2033",
s="1016268"
},new StopModel()
{
Name="Ул.Костенски водопад ",
Kod="2011",
s="1014529"
},new StopModel()
{
Name="Ул.Орехова гора ",
Kod="2089",
s="1014521"
},new StopModel()
{
Name=" Бул.България ",
Kod="290",
s="1003944"
},new StopModel()
{
Name=" Ул. Проф. Д. Атанасов ",
Kod="2135",
s="1003960"
},new StopModel()
{
Name=" Ж.к. Красно село ",
Kod="641",
s="1014479"
},new StopModel()
{
Name=" АП Земляне ",
Kod="80",
s="1014463"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="564",
s="1014453"
},new StopModel()
{
Name=" Ж.к.Красна поляна ",
Kod="631",
s="1003057"
},new StopModel()
{
Name=" Ул.Добротич ",
Kod="1931",
s="1003045"
},new StopModel()
{
Name=" Бул.Вардар ",
Kod="293",
s="1000510"
},new StopModel()
{
Name=" Бул.Възкресение ",
Kod="307",
s="1000228"
},new StopModel()
{
Name=" Парк Св.Св.Петър и Павел ",
Kod="1250",
s="1002931"
},new StopModel()
{
Name=" Метростанция К. Величков ",
Kod="1052",
s="1002911"
},new StopModel()
{
Name=" Ул. Цар Симеон ",
Kod="2247",
s="1002899"
},new StopModel()
{
Name=" Ул.Оряхово ",
Kod="2096",
s="1003688"
},new StopModel()
{
Name=" Западен парк ",
Kod="1253",
s="1003674"
},new StopModel()
{
Name=" Ул.Орион ",
Kod="2090",
s="1010663"
},new StopModel()
{
Name=" Ул.Връх Манчо ",
Kod="1201",
s="1016239"
},new StopModel()
{
Name=" Ул. Надежда ",
Kod="2051",
s="1016231"
},new StopModel()
{
Name=" Община Връбница ",
Kod="676",
s="1006352"
},new StopModel()
{
Name=" Ул. Хан Кубрат ",
Kod="2232",
s="1006345"
},new StopModel()
{
Name=" 8-ми ДКЦ ",
Kod="44",
s="1006339"
},new StopModel()
{
Name=" Бул. Ломско шосе ",
Kod="332",
s="1016150"
},new StopModel()
{
Name=" Ул. Патриарх Дамян ",
Kod="1231",
s="1016136"
},new StopModel()
{
Name=" Ул. Ген. НиколаЖеков ",
Kod="1899",
s="1016124"
},new StopModel()
{
Name=" ПГХМБТ Проф. П.Райков ",
Kod="1763",
s="1016116"
},new StopModel()
{
Name=" ЗАГ Динамик ",
Kod="725",
s="1016102"
},new StopModel()
{
Name=" Софарма АД ",
Kod="746",
s="1016096"
},new StopModel()
{
Name=" Стоков базар Илиянци ",
Kod="2456",
s="1026549"
},new StopModel()
{
Name=" Хюндай България ",
Kod="1637",
s="1016153"
},}
},new DirectionModel()
{
Name ="Хюндай България - Зоопарка",
rid="1000655",
Stops=new StopModel[]
{new StopModel()
{
Name="Хюндай България",
Kod="1637",
s="1016153"
},new StopModel()
{
Name="Стоков базар Илиянци ",
Kod="2457",
s="1027116"
},new StopModel()
{
Name="Софарма АД ",
Kod="743",
s="1016097"
},new StopModel()
{
Name="ЗАГ Динамик АД ",
Kod="726",
s="1016103"
},new StopModel()
{
Name="ПГХМБТ Проф.П.Райков ",
Kod="1764",
s="1016117"
},new StopModel()
{
Name="Ул. Ген. Никола Жеков ",
Kod="1898",
s="1016127"
},new StopModel()
{
Name="Ул. Патриарх Дамян ",
Kod="1225",
s="1016137"
},new StopModel()
{
Name="Бул. Ломско шосе ",
Kod="329",
s="1016151"
},new StopModel()
{
Name="Ул. Царевец - временна ",
Kod="6217",
s="1016161"
},new StopModel()
{
Name=" 8-ми ДКЦ ",
Kod="43",
s="1016165"
},new StopModel()
{
Name=" Ул. Хан Кубрат ",
Kod="2233",
s="1016168"
},new StopModel()
{
Name=" Община Връбница ",
Kod="675",
s="1016200"
},new StopModel()
{
Name=" Ул. Надежда ",
Kod="2052",
s="1016232"
},new StopModel()
{
Name=" ул. Връх Манчо ",
Kod="1199",
s="1010674"
},new StopModel()
{
Name=" Ул.Орион ",
Kod="2093",
s="1003667"
},new StopModel()
{
Name=" Западен парк ",
Kod="1251",
s="1003675"
},new StopModel()
{
Name=" Ул.Оряхово ",
Kod="2097",
s="1003691"
},new StopModel()
{
Name=" Ул. Цар Симеон ",
Kod="2252",
s="1002902"
},new StopModel()
{
Name=" Метростанция К. Величков ",
Kod="1053",
s="1002914"
},new StopModel()
{
Name=" Парк Св. Св. Петър и Павел ",
Kod="1249",
s="1002934"
},new StopModel()
{
Name=" Бул.Възкресение ",
Kod="304",
s="1000227"
},new StopModel()
{
Name=" Бул.Вардар ",
Kod="292",
s="1000505"
},new StopModel()
{
Name=" Ул.Добротич ",
Kod="1934",
s="1003050"
},new StopModel()
{
Name=" Ж.к.Красна поляна ",
Kod="635",
s="1003060"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="569",
s="1014456"
},new StopModel()
{
Name=" АП Земляне ",
Kod="79",
s="1014462"
},new StopModel()
{
Name=" Ж.к. Красно село ",
Kod="637",
s="1014482"
},new StopModel()
{
Name=" Ул.Проф.Д.Атанасов ",
Kod="2134",
s="1003955"
},new StopModel()
{
Name=" Бул.България ",
Kod="291",
s="1014518"
},new StopModel()
{
Name=" Ул.Орехова гора ",
Kod="2088",
s="1014524"
},new StopModel()
{
Name=" Ул.Костенски Водопад ",
Kod="2009",
s="1014585"
},new StopModel()
{
Name=" Ул.Луи Айер ",
Kod="2036",
s="1013178"
},new StopModel()
{
Name=" Южен парк ",
Kod="861",
s="1016287"
},new StopModel()
{
Name=" Ул.Иван Андонов ",
Kod="1800",
s="1016303"
},new StopModel()
{
Name=" Кв. Хладилника ",
Kod="912",
s="1013084"
},new StopModel()
{
Name=" Хлебозавода ",
Kod="2313",
s="1016336"
},new StopModel()
{
Name=" КП Бенакс ",
Kod="976",
s="1016352"
},new StopModel()
{
Name=" Зоопарка ",
Kod="749",
s="1016359"
},}
},}},

new BusModel()
{
Number = "84",
lid = "1000099",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Летище София Терминал 2 - Ул. Ген Гурко",
rid="1001568",
Stops=new StopModel[]
{new StopModel()
{
Name="Летище София Терминал 2",
Kod="2455",
s="1026632"
},new StopModel()
{
Name="РВД ",
Kod="2453",
s="1026649"
},new StopModel()
{
Name="Р-т Александрия ",
Kod="1462",
s="1016507"
},new StopModel()
{
Name="Летище София Терминал 1 ",
Kod="1006",
s="1016452"
},new StopModel()
{
Name="Р-т Александрия ",
Kod="1463",
s="1016502"
},new StopModel()
{
Name="Нова телевизия ",
Kod="2474",
s="1026708"
},new StopModel()
{
Name="Технотест ",
Kod="90",
s="1016478"
},new StopModel()
{
Name="Разклона за летището ",
Kod="1455",
s="1012058"
},new StopModel()
{
Name="Бл.108 ж.к.Дружба 1 ",
Kod="129",
s="1012046"
},new StopModel()
{
Name=" Бл.3 ж.к.Дружба 1 ",
Kod="184",
s="1012040"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="553",
s="1016396"
},new StopModel()
{
Name=" МБАЛ Св. Ана ",
Kod="1192",
s="1016399"
},new StopModel()
{
Name=" Бл.30 ж.к.Младост 1 ",
Kod="576",
s="1016382"
},new StopModel()
{
Name=" Площад на авиацията ",
Kod="1258",
s="1002013"
},new StopModel()
{
Name=" Ж.к. Изток ",
Kod="1695",
s="1003420"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2327",
s="1003436"
},new StopModel()
{
Name=" УЛ.АЛ.ЖЕНДОВ ",
Kod="1819",
s="1003448"
},new StopModel()
{
Name=" бул. Пейо Яворов ",
Kod="73",
s="1003474"
},new StopModel()
{
Name=" Полиграфически комбинат ",
Kod="1395",
s="1003488"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1289",
s="1000695"
},new StopModel()
{
Name=" Ул. Ген Гурко ",
Kod="2601",
s="1000738"
},}
},new DirectionModel()
{
Name ="Ул. Ген. Гурко - Летище София Терминал 2",
rid="1001567",
Stops=new StopModel[]
{new StopModel()
{
Name="Ул. Ген. Гурко",
Kod="1903",
s="1000741"
},new StopModel()
{
Name="СУ Св.КЛИМЕНТ ОХРИДСКИ ",
Kod="1700",
s="1016370"
},new StopModel()
{
Name="Пл.Орлов мост ",
Kod="1287",
s="1003503"
},new StopModel()
{
Name="Полиграфически комбинат ",
Kod="1394",
s="1003489"
},new StopModel()
{
Name="Бул.Пейо Яворов ",
Kod="74",
s="1003471"
},new StopModel()
{
Name="Ул.Ал.Жендов ",
Kod="1820",
s="1003445"
},new StopModel()
{
Name="Хотел Плиска ",
Kod="2326",
s="1003435"
},new StopModel()
{
Name="Ж.к. Изток ",
Kod="1696",
s="1003421"
},new StopModel()
{
Name="Площад на авиацията ",
Kod="1257",
s="1002063"
},new StopModel()
{
Name=" Бл.30 ж.к.Младост 1 ",
Kod="579",
s="1001997"
},new StopModel()
{
Name=" МБАЛ Св. Анна ",
Kod="1193",
s="1016402"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="554",
s="1001965"
},new StopModel()
{
Name=" Бл.3 ж.к.Дружба 1 ",
Kod="182",
s="1012043"
},new StopModel()
{
Name=" Бл.128 ж.к. Дружба 1 ",
Kod="128",
s="1012049"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1452",
s="1016465"
},new StopModel()
{
Name=" Технотест ",
Kod="91",
s="1026678"
},new StopModel()
{
Name=" Нова телевизия ",
Kod="2473",
s="1026682"
},new StopModel()
{
Name=" Р-т Александрия ",
Kod="2451",
s="1026638"
},new StopModel()
{
Name=" РВД ",
Kod="2452",
s="1026650"
},new StopModel()
{
Name=" Летище София Терминал 2 ",
Kod="2454",
s="1026631"
},}
},}},

new BusModel()
{
Number = "85",
lid = "1000055",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к.Стефан Караджа - Ж.к. Връбница 2",
rid="1000197",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Стефан Караджа",
Kod="691",
s="1016810"
},new StopModel()
{
Name="Ул.Гинци ",
Kod="1910",
s="1016815"
},new StopModel()
{
Name="Ул. Проф. Иван Шишманов ",
Kod="2147",
s="1016821"
},new StopModel()
{
Name="Ул. Златица ",
Kod="1947",
s="1016779"
},new StopModel()
{
Name="Ул.Макгахан ",
Kod="2042",
s="1016751"
},new StopModel()
{
Name="Ул.Уошбърн ",
Kod="2223",
s="1016737"
},new StopModel()
{
Name="СОФИЯ МЕЛ АД ",
Kod="698",
s="1016719"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1311",
s="1002810"
},new StopModel()
{
Name="Пл.Лъвов мост ",
Kod="1275",
s="1002828"
},new StopModel()
{
Name=" Централна гара ",
Kod="1327",
s="1003523"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2080",
s="1006471"
},new StopModel()
{
Name=" Надлез Надежда ",
Kod="1114",
s="1006463"
},new StopModel()
{
Name=" Модна къща Агресия ",
Kod="539",
s="1016545"
},new StopModel()
{
Name=" ПГХМБТ Проф.П.Райков ",
Kod="1764",
s="1016117"
},new StopModel()
{
Name=" Ул. Ген. Никола Жеков ",
Kod="1900",
s="1016597"
},new StopModel()
{
Name=" 102-ро ОУ ",
Kod="2578",
s="1016603"
},new StopModel()
{
Name=" 24-ти ДКЦ ",
Kod="18",
s="1016613"
},new StopModel()
{
Name=" Бл. 458 ж.к. Надежда 4 ",
Kod="221",
s="1016629"
},new StopModel()
{
Name=" Бл. 603 ж.к. Връбница 2 ",
Kod="240",
s="1016643"
},new StopModel()
{
Name=" Ж.к. Връбница 2 ",
Kod="594",
s="1016590"
},}
},new DirectionModel()
{
Name ="Ж.к. Връбница 2 - Ж.к.Стефан Караджа",
rid="1000196",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Връбница 2",
Kod="594",
s="1016590"
},new StopModel()
{
Name="Бл. 603 ж.к. Връбница 2 ",
Kod="239",
s="1016638"
},new StopModel()
{
Name="Бул. 458 ж.к. Надежда 4 ",
Kod="222",
s="1016620"
},new StopModel()
{
Name="24-ти ДКЦ ",
Kod="19",
s="1016610"
},new StopModel()
{
Name="102-ро ОУ ",
Kod="2",
s="1016602"
},new StopModel()
{
Name="Ул. Ген. Никола Жеков ",
Kod="1901",
s="1016596"
},new StopModel()
{
Name="ПГХМБТ Проф. П.Райков ",
Kod="1763",
s="1016116"
},new StopModel()
{
Name="Модна къща Агресия ",
Kod="542",
s="1016542"
},new StopModel()
{
Name="Ул. Опълченска ",
Kod="2079",
s="1006608"
},new StopModel()
{
Name=" Пл. Централна гара ",
Kod="1328",
s="1015026"
},new StopModel()
{
Name=" Бул.Христо Ботев ",
Kod="385",
s="1002839"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1278",
s="1002825"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1315",
s="1016700"
},new StopModel()
{
Name=" СОФИЯ МЕЛ АД ",
Kod="701",
s="1016722"
},new StopModel()
{
Name=" Ул.Видини кули ",
Kod="1868",
s="1016740"
},new StopModel()
{
Name=" Ул.В.Петлешков ",
Kod="1864",
s="1016746"
},new StopModel()
{
Name=" Ул. Макгахан ",
Kod="2040",
s="1016758"
},new StopModel()
{
Name=" Ул.Златица ",
Kod="1946",
s="1016784"
},new StopModel()
{
Name=" УЛ.АНГЕЛ ВОЙВОДА ",
Kod="1825",
s="1020595"
},new StopModel()
{
Name=" Ул. Теофил Ганев ",
Kod="2204",
s="1016793"
},new StopModel()
{
Name=" Ж.к.Стефан Караджа ",
Kod="691",
s="1016810"
},}
},}},

new BusModel()
{
Number = "86",
lid = "1000056",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="ж.к. Свобода - АП Малашевци",
rid="1001497",
Stops=new StopModel[]
{new StopModel()
{
Name="ж.к. Свобода",
Kod="686",
s="1016960"
},new StopModel()
{
Name="Бл.20, ж.к.Свобода ",
Kod="148",
s="1016954"
},new StopModel()
{
Name="Стоков базар Илиянци ",
Kod="491",
s="1016938"
},new StopModel()
{
Name="153-та гимназия ",
Kod="2275",
s="1016928"
},new StopModel()
{
Name="Ул. Ген. Никола Жеков ",
Kod="1898",
s="1016127"
},new StopModel()
{
Name="Ул. Патриарх Дамян ",
Kod="1225",
s="1016137"
},new StopModel()
{
Name="Ул. Христо Силянов ",
Kod="2429",
s="1025640"
},new StopModel()
{
Name="Ул.Сава Филаретов ",
Kod="6274",
s="1025648"
},new StopModel()
{
Name="Търговски к-с Надежда ",
Kod="2299",
s="1025660"
},new StopModel()
{
Name=" Ул. Хан Кубрат - временна ",
Kod="6270",
s="1025664"
},new StopModel()
{
Name=" Метростанция Хан Кубрат ",
Kod="2661",
s="1006436"
},new StopModel()
{
Name=" Бул.Княгиня Мария Луиза ",
Kod="324",
s="1003531"
},new StopModel()
{
Name=" Ул.Охрид ",
Kod="2105",
s="1003536"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2087",
s="1002851"
},new StopModel()
{
Name=" Бул.Христо Ботев ",
Kod="385",
s="1002839"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1278",
s="1002825"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1315",
s="1016700"
},new StopModel()
{
Name=" СОФИЯ МЕЛ АД ",
Kod="701",
s="1016722"
},new StopModel()
{
Name=" Ул.Ресенска поляна ",
Kod="2156",
s="1016848"
},new StopModel()
{
Name=" Балканстар ",
Kod="1599",
s="1016866"
},new StopModel()
{
Name=" УЛ.ВАСИЛ КЪНЧЕВ ",
Kod="1860",
s="1001010"
},new StopModel()
{
Name=" Автосервиз ",
Kod="514",
s="1016873"
},new StopModel()
{
Name=" АП Малашевци ",
Kod="81",
s="1016881"
},}
},new DirectionModel()
{
Name ="АП Малашевци - ж.к. Свобода",
rid="1001496",
Stops=new StopModel[]
{new StopModel()
{
Name="АП Малашевци",
Kod="81",
s="1016885"
},new StopModel()
{
Name="Автосервиз ",
Kod="513",
s="1001007"
},new StopModel()
{
Name="УЛ.ВАСИЛ КЪНЧЕВ ",
Kod="1861",
s="1016869"
},new StopModel()
{
Name="Балканстар ",
Kod="1598",
s="1016863"
},new StopModel()
{
Name="Ул.Ресенска поляна ",
Kod="2157",
s="1016849"
},new StopModel()
{
Name="СОФИЯ МЕЛ АД ",
Kod="698",
s="1016719"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1311",
s="1002810"
},new StopModel()
{
Name="Пл.Лъвов мост ",
Kod="1275",
s="1002828"
},new StopModel()
{
Name="Бул. Христо Ботев ",
Kod="382",
s="1002844"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2081",
s="1002854"
},new StopModel()
{
Name=" Ул. Охрид ",
Kod="2101",
s="1016896"
},new StopModel()
{
Name=" Бул. Княгиня Мария Луиза ",
Kod="323",
s="1016899"
},new StopModel()
{
Name=" Надлез Надежда ",
Kod="1114",
s="1006463"
},new StopModel()
{
Name=" Метростанция Хан Кубрат ",
Kod="2662",
s="1006435"
},new StopModel()
{
Name=" Ул. Хан Кубрат-временна ",
Kod="6269",
s="1025614"
},new StopModel()
{
Name=" Търговски к-с Надежда ",
Kod="2298",
s="1025620"
},new StopModel()
{
Name=" Ул.Сава Филаретов ",
Kod="6273",
s="1025630"
},new StopModel()
{
Name=" Бул. Ломско шосе ",
Kod="332",
s="1016150"
},new StopModel()
{
Name=" Ул. Патриарх Дамян ",
Kod="1231",
s="1016136"
},new StopModel()
{
Name=" Ул. Ген. НиколаЖеков ",
Kod="1899",
s="1016124"
},new StopModel()
{
Name=" 153-та гимназия ",
Kod="2274",
s="1016933"
},new StopModel()
{
Name=" Стоков базар Илиянци ",
Kod="485",
s="1016943"
},new StopModel()
{
Name=" Бл.20, ж.к.Свобода ",
Kod="151",
s="1016955"
},new StopModel()
{
Name=" ж.к. Свобода ",
Kod="686",
s="1016963"
},}
},}},

new BusModel()
{
Number = "87",
lid = "1000010",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Илиянци - Ж.к.Обеля-1",
rid="1001832",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Илиянци",
Kod="58",
s="1007868"
},new StopModel()
{
Name="Центъра кв. Илиянци ",
Kod="939",
s="1017008"
},new StopModel()
{
Name="Хюндай България ",
Kod="1633",
s="1016992"
},new StopModel()
{
Name="Стоков базар Илиянци ",
Kod="2457",
s="1027116"
},new StopModel()
{
Name="Софарма АД ",
Kod="743",
s="1016097"
},new StopModel()
{
Name="ЗАГ Динамик АД ",
Kod="726",
s="1016103"
},new StopModel()
{
Name="ПГХМБТ Проф.П.Райков ",
Kod="1764",
s="1016117"
},new StopModel()
{
Name="Ул. Ген. Никола Жеков ",
Kod="1898",
s="1016127"
},new StopModel()
{
Name="Ул. Патриарх Дамян ",
Kod="1225",
s="1016137"
},new StopModel()
{
Name=" Бул. Ломско шосе ",
Kod="329",
s="1016151"
},new StopModel()
{
Name=" Ул. Царевец - временна ",
Kod="6217",
s="1016161"
},new StopModel()
{
Name=" 8-ми ДКЦ ",
Kod="43",
s="1016165"
},new StopModel()
{
Name=" Ул. Хан Кубрат ",
Kod="2233",
s="1016168"
},new StopModel()
{
Name=" Община Връбница-временна ",
Kod="6216",
s="1016173"
},new StopModel()
{
Name=" Бл.302 ж.к.Надежда-3 ",
Kod="187",
s="1022974"
},new StopModel()
{
Name=" Бул.Ломско шосе-временна ",
Kod="6215",
s="1022962"
},new StopModel()
{
Name=" 61-во ОУ ",
Kod="2280",
s="1006597"
},new StopModel()
{
Name=" Метростанция Ломско шосе ",
Kod="2659",
s="1006585"
},new StopModel()
{
Name=" Ж.к. Обеля 2 ",
Kod="678",
s="1008968"
},new StopModel()
{
Name=" Бл. 245 ж.к. Обеля 2 ",
Kod="173",
s="1006559"
},new StopModel()
{
Name=" Бл. 241 ж.к. Обеля 2 ",
Kod="171",
s="1006547"
},new StopModel()
{
Name=" Бл. 207 ж.к. Обеля 2 ",
Kod="162",
s="1006525"
},new StopModel()
{
Name=" Ул.9 ",
Kod="1815",
s="1006509"
},new StopModel()
{
Name=" Ул.2 ",
Kod="1793",
s="1006501"
},new StopModel()
{
Name=" Метростанция Обеля ",
Kod="6241",
s="1026043"
},new StopModel()
{
Name=" Бл.119 ж.к.Обеля-1 ",
Kod="2448",
s="1026553"
},new StopModel()
{
Name=" Бл.111 ж.к. Обеля-1 ",
Kod="133",
s="1006479"
},new StopModel()
{
Name=" Ж.к.Обеля-1 ",
Kod="677",
s="1006294"
},}
},new DirectionModel()
{
Name ="Ж.к.Обеля-1 - Автостанция Илиянци",
rid="1001833",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Обеля-1",
Kod="2434",
s="1006296"
},new StopModel()
{
Name="Бл.111 ж.к.Обеля-1 ",
Kod="132",
s="1006480"
},new StopModel()
{
Name="Бл.119 ж.к.Обеля-1 ",
Kod="2443",
s="1026002"
},new StopModel()
{
Name="Метростанция Обеля ",
Kod="6240",
s="1028322"
},new StopModel()
{
Name="Ул.2 ",
Kod="1792",
s="1006502"
},new StopModel()
{
Name="Ул.9 ",
Kod="1817",
s="1006506"
},new StopModel()
{
Name="Бл. 207 ж.к. Обеля 2 ",
Kod="163",
s="1006526"
},new StopModel()
{
Name="Бл. 241 ж.к. Обеля ",
Kod="172",
s="1006550"
},new StopModel()
{
Name="Ж.к.Обеля 2 ",
Kod="681",
s="1008971"
},new StopModel()
{
Name=" Метростанция Ломско шосе ",
Kod="2660",
s="1006592"
},new StopModel()
{
Name=" 61-во ОУ ",
Kod="2278",
s="1006600"
},new StopModel()
{
Name=" Бул.Ломско шосе ",
Kod="330",
s="1022967"
},new StopModel()
{
Name=" Бл.302 ж.к.Надежда 3 ",
Kod="188",
s="1022975"
},new StopModel()
{
Name=" Община Връбница ",
Kod="676",
s="1006352"
},new StopModel()
{
Name=" Ул. Хан Кубрат ",
Kod="2232",
s="1006345"
},new StopModel()
{
Name=" 8-ми ДКЦ ",
Kod="44",
s="1006339"
},new StopModel()
{
Name=" Бул. Ломско шосе ",
Kod="332",
s="1016150"
},new StopModel()
{
Name=" Ул. Патриарх Дамян ",
Kod="1231",
s="1016136"
},new StopModel()
{
Name=" Ул. Ген. НиколаЖеков ",
Kod="1899",
s="1016124"
},new StopModel()
{
Name=" ПГХМБТ Проф. П.Райков ",
Kod="1763",
s="1016116"
},new StopModel()
{
Name=" ЗАГ Динамик ",
Kod="725",
s="1016102"
},new StopModel()
{
Name=" Софарма АД ",
Kod="746",
s="1016096"
},new StopModel()
{
Name=" Стоков базар Илиянци ",
Kod="2456",
s="1026549"
},new StopModel()
{
Name=" Хюндай България ",
Kod="1634",
s="1016993"
},new StopModel()
{
Name=" Центъра кв. Илиянци ",
Kod="938",
s="1017011"
},new StopModel()
{
Name=" Автостанция Илиянци ",
Kod="2608",
s="1007867"
},}
},}},

new BusModel()
{
Number = "88",
lid = "1000082",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Зоопарка - Ж.к. Дружба 2",
rid="1001220",
Stops=new StopModel[]
{new StopModel()
{
Name="Зоопарка",
Kod="749",
s="1016359"
},new StopModel()
{
Name="КП Бенакс ",
Kod="977",
s="1016353"
},new StopModel()
{
Name="Хлебозавода ",
Kod="2314",
s="1016335"
},new StopModel()
{
Name="Кв. Хладилника ",
Kod="909",
s="1013085"
},new StopModel()
{
Name="БУЛ.НИКОЛА Й. ВАПЦАРОВ ",
Kod="344",
s="1017292"
},new StopModel()
{
Name="МБАЛ Токуда болница ",
Kod="206",
s="1017274"
},new StopModel()
{
Name="НПМГ Акад.Любомир Чакалов ",
Kod="1605",
s="1017268"
},new StopModel()
{
Name="УЛ.СТОЯН МИХАЙЛОВСКИ ",
Kod="2191",
s="1028855"
},new StopModel()
{
Name="Гара Пионер ",
Kod="462",
s="1017217"
},new StopModel()
{
Name=" ПК Диана ",
Kod="1343",
s="1017203"
},new StopModel()
{
Name=" Читалище Д. Чинтулов ",
Kod="2365",
s="1017193"
},new StopModel()
{
Name=" Бул.Д-р Г.М.Димитров ",
Kod="316",
s="1017177"
},new StopModel()
{
Name=" МГУ Св.Ив.Рилски ",
Kod="1032",
s="1017169"
},new StopModel()
{
Name=" СБАЛ по онкология ",
Kod="764",
s="1009942"
},new StopModel()
{
Name=" Технически университет ",
Kod="1740",
s="1009956"
},new StopModel()
{
Name=" ЛТУ ",
Kod="617",
s="1009968"
},new StopModel()
{
Name=" Ж.к.Дървеница ",
Kod="1012",
s="1013847"
},new StopModel()
{
Name=" Бл. 49 ж.к. Дървеница ",
Kod="1589",
s="1017109"
},new StopModel()
{
Name=" Ж.к.Младост-1 ",
Kod="661",
s="1018869"
},new StopModel()
{
Name=" Посолствата ",
Kod="1401",
s="1018859"
},new StopModel()
{
Name=" Онкологичен диспансер ",
Kod="22",
s="1027323"
},new StopModel()
{
Name=" Пазара Младост 1 ",
Kod="968",
s="1018835"
},new StopModel()
{
Name=" Бл. 66 ж.к. Младост 1 ",
Kod="245",
s="1018825"
},new StopModel()
{
Name=" Бл.43 ж.к.Младост 1 ",
Kod="218",
s="1003285"
},new StopModel()
{
Name=" ХМС ",
Kod="2319",
s="1003279"
},new StopModel()
{
Name=" Бл.3 ж.к.Дружба 1 ",
Kod="182",
s="1012043"
},new StopModel()
{
Name=" Бл.128 ж.к. Дружба 1 ",
Kod="128",
s="1012049"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1451",
s="1012063"
},new StopModel()
{
Name=" Ж.к.Дружба 1 ",
Kod="604",
s="1012071"
},new StopModel()
{
Name=" Бул.Кръстьо Пастухов ",
Kod="1632",
s="1017056"
},new StopModel()
{
Name=" 28-ми ДКЦ ",
Kod="28",
s="1017046"
},new StopModel()
{
Name=" 28-ми пощенски клон ",
Kod="1406",
s="1012169"
},new StopModel()
{
Name=" Кв. ГараИскър ",
Kod="34",
s="1014274"
},new StopModel()
{
Name=" София мед АД ",
Kod="975",
s="1014260"
},new StopModel()
{
Name=" Депо Искър ",
Kod="520",
s="1014256"
},new StopModel()
{
Name=" ТЕЦ Изток ",
Kod="1750",
s="1014238"
},new StopModel()
{
Name=" РАЗКЛОНА ЗА АП ДРУЖБА ",
Kod="1450",
s="1014234"
},new StopModel()
{
Name=" БЛ. 501 ж.к. Дружба-2 ",
Kod="226",
s="1004184"
},new StopModel()
{
Name=" Ул. Димитър Пешев ",
Kod="1929",
s="1004213"
},new StopModel()
{
Name=" Ж.к. Дружба 2 ",
Kod="612",
s="1004217"
},}
},new DirectionModel()
{
Name ="Ж.к. Дружба 2 - Зоопарка",
rid="1001219",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Дружба 2",
Kod="611",
s="1004228"
},new StopModel()
{
Name="Ул. Димитър Пешев ",
Kod="1930",
s="1004191"
},new StopModel()
{
Name="БЛ. 501 ж.к. Дружба-2 ",
Kod="225",
s="1004181"
},new StopModel()
{
Name="РАЗКЛОНА ЗА АП ДРУЖБА ",
Kod="1449",
s="1014237"
},new StopModel()
{
Name="ТЕЦ Изток ",
Kod="1749",
s="1014241"
},new StopModel()
{
Name="Депо Искър ",
Kod="515",
s="1014255"
},new StopModel()
{
Name="София мед АД ",
Kod="974",
s="1014263"
},new StopModel()
{
Name="Кв. Гара Искър ",
Kod="33",
s="1014275"
},new StopModel()
{
Name="28-ми пощенски клон ",
Kod="1411",
s="1017037"
},new StopModel()
{
Name=" 28-ми ДКЦ ",
Kod="25",
s="1017051"
},new StopModel()
{
Name=" Бул. Кръстьо Пастухов ",
Kod="1629",
s="1012078"
},new StopModel()
{
Name=" Ж.к.Дружба 1 ",
Kod="608",
s="1012068"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1455",
s="1012058"
},new StopModel()
{
Name=" Бл.108 ж.к.Дружба 1 ",
Kod="129",
s="1012046"
},new StopModel()
{
Name=" Бл.3 ж.к.Дружба 1 ",
Kod="184",
s="1012040"
},new StopModel()
{
Name=" ХМС ",
Kod="2318",
s="1003282"
},new StopModel()
{
Name=" Бл.43 ж.к.Младост 1 ",
Kod="217",
s="1003288"
},new StopModel()
{
Name=" Бл. 66 ж.к. Младост 1 ",
Kod="246",
s="1018826"
},new StopModel()
{
Name=" Пазара Младост 1 ",
Kod="969",
s="1018836"
},new StopModel()
{
Name=" Ул.Йерусалим ",
Kod="2471",
s="1018842"
},new StopModel()
{
Name=" Онкологичен диспансер ",
Kod="23",
s="1018852"
},new StopModel()
{
Name=" Посолствата ",
Kod="1400",
s="1018860"
},new StopModel()
{
Name=" Ж.к.Младост-1 ",
Kod="2463",
s="1025732"
},new StopModel()
{
Name=" Бл. 49 ж.к. Дървеница ",
Kod="1588",
s="1017112"
},new StopModel()
{
Name=" Ж.к.Дървеница ",
Kod="1015",
s="1013850"
},new StopModel()
{
Name=" ЛТУ ",
Kod="614",
s="1009963"
},new StopModel()
{
Name=" Технически университет ",
Kod="1743",
s="1009953"
},new StopModel()
{
Name=" СБАЛ по онкология ",
Kod="2542",
s="1017160"
},new StopModel()
{
Name=" МГУ Св.Иван Рилски ",
Kod="1033",
s="1017172"
},new StopModel()
{
Name=" Бул. Д-р Г. М. Димитров ",
Kod="317",
s="1017186"
},new StopModel()
{
Name=" Читалище Д. Чинтулов ",
Kod="2366",
s="1017196"
},new StopModel()
{
Name=" ПК Диана ",
Kod="1342",
s="1017206"
},new StopModel()
{
Name=" Гара Пионер ",
Kod="465",
s="1013439"
},new StopModel()
{
Name=" Ул. Стоян Михайловски ",
Kod="2190",
s="1028854"
},new StopModel()
{
Name=" НПМГ Акад. Любомир Чакалов ",
Kod="1604",
s="1017271"
},new StopModel()
{
Name=" МБАЛ Токуда болница ",
Kod="205",
s="1017279"
},new StopModel()
{
Name=" Бул. Никола Вапцаров ",
Kod="341",
s="1017291"
},new StopModel()
{
Name=" Кв. Хладилника ",
Kod="912",
s="1013084"
},new StopModel()
{
Name=" Хлебозавода ",
Kod="2313",
s="1016336"
},new StopModel()
{
Name=" КП Бенакс ",
Kod="976",
s="1016352"
},new StopModel()
{
Name=" Зоопарка ",
Kod="749",
s="1016359"
},}
},}},

new BusModel()
{
Number = "90",
lid = "1000110",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="АП Малашевци - град Бухово",
rid="1000052",
Stops=new StopModel[]
{new StopModel()
{
Name="АП Малашевци",
Kod="81",
s="1016885"
},new StopModel()
{
Name="Автосервиз ",
Kod="513",
s="1001007"
},new StopModel()
{
Name="УЛ.РЕЗБАРСКА ",
Kod="2155",
s="1001017"
},new StopModel()
{
Name="Ул. Ангел войвода ",
Kod="1826",
s="1001023"
},new StopModel()
{
Name="Ул.Тодорини кукли ",
Kod="2215",
s="1001152"
},new StopModel()
{
Name="Пл.Пирдоп ",
Kod="1294",
s="1015462"
},new StopModel()
{
Name="Бл.6 ж.к. Сухата река ",
Kod="1475",
s="1015472"
},new StopModel()
{
Name="УЛ.ВИТИНЯ ",
Kod="1870",
s="1015478"
},new StopModel()
{
Name="УЛ.РИЛСКА ОБИТЕЛ ",
Kod="2158",
s="1017964"
},new StopModel()
{
Name=" УЛ.ПОП ГРУЙО ",
Kod="2131",
s="1017956"
},new StopModel()
{
Name=" Автостанция Изток ",
Kod="2021",
s="1017946"
},new StopModel()
{
Name=" СЕРВИЗ Изток ",
Kod="1583",
s="1017922"
},new StopModel()
{
Name=" ПЪТЯ ЗА ЛЕТИЩЕ ВРАЖДЕБНА ",
Kod="2407",
s="1017890"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1434",
s="1005515"
},new StopModel()
{
Name=" СПИ ПРОФ. ПЕТЪР МУТАФЧИЕВ ",
Kod="1600",
s="1005511"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР ",
Kod="1097",
s="1005549"
},new StopModel()
{
Name=" Махала Батареята ",
Kod="1649",
s="1004615"
},new StopModel()
{
Name=" КАНТОНА ",
Kod="788",
s="1004643"
},new StopModel()
{
Name=" Езерото ",
Kod="1658",
s="1017833"
},new StopModel()
{
Name=" Разклон за Д.Богров ",
Kod="1212",
s="1017805"
},new StopModel()
{
Name=" Моста на Леновска река ",
Kod="1080",
s="1017777"
},new StopModel()
{
Name=" ХАНЧЕТО ",
Kod="2301",
s="1017733"
},new StopModel()
{
Name=" СЕЛО ГОРНИ БОГРОВ ",
Kod="1522",
s="1017695"
},new StopModel()
{
Name=" КАВАЦИТЕ ",
Kod="781",
s="1017675"
},new StopModel()
{
Name=" ГАРА ЯНА ",
Kod="478",
s="1017625"
},new StopModel()
{
Name=" Ул.Юри Гагарин ",
Kod="1148",
s="1017601"
},new StopModel()
{
Name=" ШЛАКОВ ЦЕХ ",
Kod="2375",
s="1017591"
},new StopModel()
{
Name=" ПО ЖЕЛАНИЕ ",
Kod="1357",
s="1017577"
},new StopModel()
{
Name=" Културен дом ",
Kod="993",
s="1017515"
},new StopModel()
{
Name=" Ул. Захари Попов ",
Kod="2683",
s="1017503"
},new StopModel()
{
Name=" град Бухово ",
Kod="504",
s="1017881"
},}
},new DirectionModel()
{
Name ="град Бухово - АП Малашевци",
rid="1000051",
Stops=new StopModel[]
{new StopModel()
{
Name="град Бухово",
Kod="504",
s="1017881"
},new StopModel()
{
Name="Ул. Захари Попов ",
Kod="2684",
s="1017504"
},new StopModel()
{
Name="КУЛТУРЕН ДОМ ",
Kod="992",
s="1017516"
},new StopModel()
{
Name="ПО ЖЕЛАНИЕ ",
Kod="1356",
s="1017576"
},new StopModel()
{
Name="ШЛАКОВ ЦЕХ ",
Kod="2376",
s="1017592"
},new StopModel()
{
Name="Ул.Юри Гагарин ",
Kod="1149",
s="1017604"
},new StopModel()
{
Name="ГАРА ЯНА ",
Kod="479",
s="1017626"
},new StopModel()
{
Name="КАВАЦИТЕ ",
Kod="780",
s="1017678"
},new StopModel()
{
Name="СЕЛО ГОРНИ БОГРОВ ",
Kod="1520",
s="1017696"
},new StopModel()
{
Name=" ХАНЧЕТО ",
Kod="2302",
s="1017736"
},new StopModel()
{
Name=" Моста на Лесновска река ",
Kod="1079",
s="1017780"
},new StopModel()
{
Name=" Разклона за Д.Богров ",
Kod="1213",
s="1017802"
},new StopModel()
{
Name=" Езерото ",
Kod="1659",
s="1017836"
},new StopModel()
{
Name=" Кантона ",
Kod="787",
s="1004642"
},new StopModel()
{
Name=" Махала Батареята ",
Kod="1648",
s="1004616"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР ",
Kod="1098",
s="1005502"
},new StopModel()
{
Name=" СПИ ПРОФ. ПЕТЪР МУТАФЧИЕВ ",
Kod="1601",
s="1005514"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1435",
s="1005520"
},new StopModel()
{
Name=" СЕРВИЗ Изток ",
Kod="1580",
s="1017923"
},new StopModel()
{
Name=" Автостанция Изток ",
Kod="2024",
s="1017951"
},new StopModel()
{
Name=" УЛ.ПОП ГРУЙО ",
Kod="2126",
s="1017959"
},new StopModel()
{
Name=" УЛ.РИЛСКА ОБИТЕЛ ",
Kod="2161",
s="1017965"
},new StopModel()
{
Name=" УЛ.ВИТИНЯ ",
Kod="1874",
s="1015475"
},new StopModel()
{
Name=" Бл.6 ж.к.Сухата река ",
Kod="1476",
s="1015471"
},new StopModel()
{
Name=" Пл.Пирдоп ",
Kod="1291",
s="1015455"
},new StopModel()
{
Name=" Ул.Тодорини кукли ",
Kod="2217",
s="1001149"
},new StopModel()
{
Name=" УЛ.АНГЕЛ ВОЙВОДА ",
Kod="1825",
s="1020595"
},new StopModel()
{
Name=" Ул.Резбарска ",
Kod="2154",
s="1020125"
},new StopModel()
{
Name=" УЛ.ВАСИЛ КЪНЧЕВ ",
Kod="1860",
s="1001010"
},new StopModel()
{
Name=" Автосервиз ",
Kod="514",
s="1016873"
},new StopModel()
{
Name=" АП Малашевци ",
Kod="81",
s="1016881"
},}
},}},

new BusModel()
{
Number = "93",
lid = "1000011",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="ЛИФТА-ДРАГАЛЕВЦИ - Автостанция Хладилника",
rid="1000983",
Stops=new StopModel[]
{new StopModel()
{
Name="ЛИФТА-ДРАГАЛЕВЦИ",
Kod="1010",
s="1018063"
},new StopModel()
{
Name="Разклона за лифта ",
Kod="1216",
s="1018056"
},new StopModel()
{
Name="Воденичарски механи ",
Kod="1472",
s="1018034"
},new StopModel()
{
Name="Ул.Маестро Атанасов ",
Kod="2642",
s="1018024"
},new StopModel()
{
Name="КВ.ДРАГАЛЕВЦИ ",
Kod="837",
s="1018002"
},new StopModel()
{
Name="Гробищен парк Драгалевци ",
Kod="509",
s="1013014"
},new StopModel()
{
Name="Ж.к.Водолей ",
Kod="2598",
s="1013030"
},new StopModel()
{
Name="ОКОЛОВРЪСТЕН ПЪТ ",
Kod="1177",
s="1013034"
},new StopModel()
{
Name="Кв.Кръстова вада ",
Kod="914",
s="1013056"
},new StopModel()
{
Name=" Ул. Асен Йорданов ",
Kod="783",
s="1013064"
},new StopModel()
{
Name=" Кв. Хладилника ",
Kod="912",
s="1013084"
},new StopModel()
{
Name=" Автостанция Хладилника ",
Kod="64",
s="1013095"
},}
},new DirectionModel()
{
Name ="Автостанция Хладилника - Лифта Драгалевци",
rid="1000982",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Хладилника",
Kod="64",
s="1013095"
},new StopModel()
{
Name="Кв. Хладилника ",
Kod="909",
s="1013085"
},new StopModel()
{
Name="Ул. Асен Йорданов ",
Kod="786",
s="1013061"
},new StopModel()
{
Name="Кв.Кръстова вада ",
Kod="919",
s="1013051"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1176",
s="1013039"
},new StopModel()
{
Name="Ж.к.Водолей ",
Kod="2597",
s="1013031"
},new StopModel()
{
Name="Гробищен парк Драгалевци ",
Kod="510",
s="1013013"
},new StopModel()
{
Name="КВ.ДРАГАЛЕВЦИ ",
Kod="834",
s="1018003"
},new StopModel()
{
Name="Ул.Маестро Атанасов ",
Kod="2641",
s="1028615"
},new StopModel()
{
Name=" Воденичарски механи ",
Kod="1471",
s="1018037"
},new StopModel()
{
Name=" Разклонение за лифт Драгалевци ",
Kod="1217",
s="1018057"
},new StopModel()
{
Name=" Лифта Драгалевци ",
Kod="2466",
s="1020120"
},}
},}},

new BusModel()
{
Number = "94",
lid = "1000057",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="СУ Св.КЛИМЕНТ ОХРИДСКИ - Студентски град",
rid="1000140",
Stops=new StopModel[]
{new StopModel()
{
Name="СУ Св.КЛИМЕНТ ОХРИДСКИ",
Kod="1700",
s="1016370"
},new StopModel()
{
Name="Пл.Орлов мост ",
Kod="1289",
s="1000695"
},new StopModel()
{
Name="Ул. Граф Игнатиев ",
Kod="1914",
s="1000357"
},new StopModel()
{
Name="Ул. 6-ти септември ",
Kod="1808",
s="1000347"
},new StopModel()
{
Name="Хотел Хилтън ",
Kod="397",
s="1018115"
},new StopModel()
{
Name="Хотел Хемус ",
Kod="2329",
s="1018127"
},new StopModel()
{
Name="Семинарията ",
Kod="1569",
s="1018155"
},new StopModel()
{
Name="Гара Пионер ",
Kod="462",
s="1017217"
},new StopModel()
{
Name="ПК Диана ",
Kod="1343",
s="1017203"
},new StopModel()
{
Name=" Читалище Д. Чинтулов ",
Kod="2365",
s="1017193"
},new StopModel()
{
Name=" Бул.Д-р Г.М.Димитров ",
Kod="318",
s="1018177"
},new StopModel()
{
Name=" Колеж по телекомуникации ",
Kod="1396",
s="1018187"
},new StopModel()
{
Name=" Детски дом ",
Kod="524",
s="1010008"
},new StopModel()
{
Name=" Спортна зала Христо Ботев ",
Kod="1610",
s="1010026"
},new StopModel()
{
Name=" Детски ясли ",
Kod="533",
s="1010036"
},new StopModel()
{
Name=" Зимен дворец на спорта ",
Kod="741",
s="1010052"
},new StopModel()
{
Name=" СК на НСА ",
Kod="1606",
s="1010092"
},new StopModel()
{
Name=" Студентски град ",
Kod="1694",
s="1010081"
},}
},new DirectionModel()
{
Name ="Студентски град - СУ Св.КЛИМЕНТ ОХРИДСКИ",
rid="1000141",
Stops=new StopModel[]
{new StopModel()
{
Name="Студентски град",
Kod="1693",
s="1010086"
},new StopModel()
{
Name="СК на НСА ",
Kod="1609",
s="1010091"
},new StopModel()
{
Name="Зимен дворец на спорта ",
Kod="742",
s="1010053"
},new StopModel()
{
Name="Детски ясли ",
Kod="534",
s="1010033"
},new StopModel()
{
Name="Спортна зала Христо Ботев ",
Kod="1611",
s="1010021"
},new StopModel()
{
Name="Детски дом ",
Kod="530",
s="1010011"
},new StopModel()
{
Name="Колеж по телекомуникации ",
Kod="1397",
s="1018186"
},new StopModel()
{
Name="Бул. Д-р Г. М. Димитров ",
Kod="317",
s="1017186"
},new StopModel()
{
Name="Читалище Д. Чинтулов ",
Kod="2366",
s="1017196"
},new StopModel()
{
Name=" ПК Диана ",
Kod="1342",
s="1017206"
},new StopModel()
{
Name=" Гара Пионер ",
Kod="465",
s="1013439"
},new StopModel()
{
Name=" Семинарията ",
Kod="1574",
s="1018146"
},new StopModel()
{
Name=" Хотел Хемус ",
Kod="2330",
s="1018120"
},new StopModel()
{
Name=" Хотел Хилтън ",
Kod="396",
s="1018071"
},new StopModel()
{
Name=" ул. 6-ти септември ",
Kod="1806",
s="1018077"
},new StopModel()
{
Name=" Кино Одеон ",
Kod="927",
s="1018082"
},new StopModel()
{
Name=" Ул. Ген. Гурко ",
Kod="1903",
s="1000741"
},new StopModel()
{
Name=" СУ Св.КЛИМЕНТ ОХРИДСКИ ",
Kod="1700",
s="1016370"
},}
},}},

new BusModel()
{
Number = "98",
lid = "1000028",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Семинарията - КМЕТСТВО СЕЛО ЖЕЛЕЗНИЦА",
rid="1001655",
Stops=new StopModel[]
{new StopModel()
{
Name="Семинарията",
Kod="1569",
s="1018155"
},new StopModel()
{
Name="НПМГ Акад. Любомир Чакалов ",
Kod="1604",
s="1017271"
},new StopModel()
{
Name="МБАЛ Токуда болница ",
Kod="205",
s="1017279"
},new StopModel()
{
Name="Бул. Никола Вапцаров ",
Kod="341",
s="1017291"
},new StopModel()
{
Name="Кв.Хладилника ",
Kod="2655",
s="1017311"
},new StopModel()
{
Name="Ул. Асен Йорданов ",
Kod="786",
s="1013061"
},new StopModel()
{
Name="Кв.Кръстова вада ",
Kod="919",
s="1013051"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1176",
s="1013039"
},new StopModel()
{
Name="Ж.к.Водолей ",
Kod="2597",
s="1013031"
},new StopModel()
{
Name=" Гробищен парк Драгалевци ",
Kod="510",
s="1013013"
},new StopModel()
{
Name=" Ул. Лагадина ",
Kod="523",
s="1018255"
},new StopModel()
{
Name=" Ул. Герена ",
Kod="424",
s="1018271"
},new StopModel()
{
Name=" В.З. Симеоново - Драгалевци ",
Kod="779",
s="1018287"
},new StopModel()
{
Name=" Моста на Сухата река ",
Kod="1484",
s="1018305"
},new StopModel()
{
Name=" Моста на Симеоновска река ",
Kod="1346",
s="1018325"
},new StopModel()
{
Name=" 64-то ОУ ",
Kod="2279",
s="1013312"
},new StopModel()
{
Name=" Кв. Симеоново ",
Kod="901",
s="1018407"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1041",
s="1018419"
},new StopModel()
{
Name=" Ул. Златен бор ",
Kod="259",
s="1018441"
},new StopModel()
{
Name=" Шумако ",
Kod="2378",
s="1018473"
},new StopModel()
{
Name=" Хайдушки чукар ",
Kod="1442",
s="1018499"
},new StopModel()
{
Name=" Калфин дол ",
Kod="2269",
s="1018517"
},new StopModel()
{
Name=" Начало с. Бистрица ",
Kod="1117",
s="1018543"
},new StopModel()
{
Name=" Село Бистрица ",
Kod="1513",
s="1013950"
},new StopModel()
{
Name=" Края с.Бистрица ",
Kod="1639",
s="1013976"
},new StopModel()
{
Name=" Чешмата ",
Kod="1508",
s="1013988"
},new StopModel()
{
Name=" Манастир Св.Йоаким и Ана ",
Kod="407",
s="1014006"
},new StopModel()
{
Name=" Албена ",
Kod="72",
s="1014032"
},new StopModel()
{
Name=" По желание ",
Kod="1372",
s="1014066"
},new StopModel()
{
Name=" Лифта ",
Kod="1008",
s="1014098"
},new StopModel()
{
Name=" Анева чешма ",
Kod="76",
s="1020430"
},new StopModel()
{
Name=" КМЕТСТВО СЕЛО ЖЕЛЕЗНИЦА ",
Kod="937",
s="1023690"
},}
},new DirectionModel()
{
Name ="КМЕТСТВО СЕЛО ЖЕЛЕЗНИЦА - Семинарията",
rid="1001657",
Stops=new StopModel[]
{new StopModel()
{
Name="КМЕТСТВО СЕЛО ЖЕЛЕЗНИЦА",
Kod="937",
s="1023690"
},new StopModel()
{
Name="Анева чешма ",
Kod="75",
s="1020459"
},new StopModel()
{
Name="Лифта ",
Kod="1007",
s="1014097"
},new StopModel()
{
Name="По желание ",
Kod="1373",
s="1014065"
},new StopModel()
{
Name="Албена ",
Kod="71",
s="1014033"
},new StopModel()
{
Name="Манастир Св.Йоаким и Ана ",
Kod="1009",
s="1014005"
},new StopModel()
{
Name="Чешмата ",
Kod="1507",
s="1013987"
},new StopModel()
{
Name="Края с.Бистрица ",
Kod="1638",
s="1013971"
},new StopModel()
{
Name="Село Бистрица ",
Kod="1512",
s="1013949"
},new StopModel()
{
Name=" Начало с. Бистрица ",
Kod="1118",
s="1018542"
},new StopModel()
{
Name=" Калфин дол ",
Kod="2268",
s="1018516"
},new StopModel()
{
Name=" Хайдушки чукар ",
Kod="1443",
s="1018498"
},new StopModel()
{
Name=" Шумако ",
Kod="2377",
s="1018472"
},new StopModel()
{
Name=" Ул. Зелен бор ",
Kod="260",
s="1018440"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1040",
s="1018416"
},new StopModel()
{
Name=" Кв. Симеоново ",
Kod="899",
s="1013303"
},new StopModel()
{
Name=" 64-то ОУ ",
Kod="2285",
s="1013313"
},new StopModel()
{
Name=" Моста на Симеоновска река ",
Kod="1350",
s="1018322"
},new StopModel()
{
Name=" Моста на Сухата река ",
Kod="1483",
s="1018302"
},new StopModel()
{
Name=" В.З. Симеоново - Драгалевци ",
Kod="782",
s="1018284"
},new StopModel()
{
Name=" Ул. Герена ",
Kod="428",
s="1018270"
},new StopModel()
{
Name=" Ул. Лагадина ",
Kod="526",
s="1018254"
},new StopModel()
{
Name=" Гробищен парк Драгалевци ",
Kod="509",
s="1013014"
},new StopModel()
{
Name=" Ж.к.Водолей ",
Kod="2598",
s="1013030"
},new StopModel()
{
Name=" ОКОЛОВРЪСТЕН ПЪТ ",
Kod="1177",
s="1013034"
},new StopModel()
{
Name=" Кв.Кръстова вада ",
Kod="914",
s="1013056"
},new StopModel()
{
Name=" Ул. Асен Йорданов ",
Kod="783",
s="1013064"
},new StopModel()
{
Name=" Кв.Хладилника ",
Kod="2654",
s="1017308"
},new StopModel()
{
Name=" Бул. Никола Вапцаров ",
Kod="342",
s="1017294"
},new StopModel()
{
Name=" Ул. Люботрън ",
Kod="2039",
s="1025748"
},new StopModel()
{
Name=" Кемпински хотел Зографски ",
Kod="923",
s="1026999"
},new StopModel()
{
Name=" Енергопроект ",
Kod="575",
s="1026969"
},new StopModel()
{
Name=" Ул. Милин камък ",
Kod="2046",
s="1026983"
},new StopModel()
{
Name=" Семинарията ",
Kod="1572",
s="1026995"
},new StopModel()
{
Name=" Семинарията ",
Kod="1569",
s="1018155"
},}
},}},

new BusModel()
{
Number = "100",
lid = "1000032",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Пътностроителна техника - Кв. Бенковски",
rid="1000718",
Stops=new StopModel[]
{new StopModel()
{
Name="Пътностроителна техника",
Kod="2483",
s="1027347"
},new StopModel()
{
Name="Ул.Витиня ",
Kod="2482",
s="1027356"
},new StopModel()
{
Name="Стадион Г.Аспарухов ",
Kod="1613",
s="1015126"
},new StopModel()
{
Name="Ул.Васил Кънчев ",
Kod="1862",
s="1001029"
},new StopModel()
{
Name="Ул.Острово ",
Kod="2100",
s="1021771"
},new StopModel()
{
Name="Ул. Макгахан ",
Kod="2040",
s="1016758"
},new StopModel()
{
Name="Балканстар ",
Kod="1597",
s="1021780"
},new StopModel()
{
Name="Ул. Рояк ",
Kod="2164",
s="1023429"
},new StopModel()
{
Name="кв. Орландовци ",
Kod="887",
s="1021757"
},new StopModel()
{
Name=" Ул. Ком ",
Kod="2599",
s="1028257"
},new StopModel()
{
Name=" Ул.Снежник ",
Kod="2177",
s="1021741"
},new StopModel()
{
Name=" Моста на Суходолска река ",
Kod="1505",
s="1021727"
},new StopModel()
{
Name=" Ул.проф.И.Георгов ",
Kod="2148",
s="1021703"
},new StopModel()
{
Name=" УЛ.ПРОСВЕТА ",
Kod="2144",
s="1021696"
},new StopModel()
{
Name=" Ул. Локомотив ",
Kod="1000",
s="1015364"
},new StopModel()
{
Name=" ПГВАД ",
Kod="1723",
s="1015376"
},new StopModel()
{
Name=" Производствен к-с Москва ",
Kod="537",
s="1015380"
},new StopModel()
{
Name=" Стинд 1 ",
Kod="549",
s="1015384"
},new StopModel()
{
Name=" ТПК Хемус ",
Kod="1761",
s="1021674"
},new StopModel()
{
Name=" ТЕРСНАБ ",
Kod="1734",
s="1021668"
},new StopModel()
{
Name=" Ул.Пробуда ",
Kod="2139",
s="1021658"
},new StopModel()
{
Name=" МЕТАЛСНАБ-ХОЛДИНГ ",
Kod="1042",
s="1021646"
},new StopModel()
{
Name=" Ул. Хоризонт ",
Kod="2236",
s="1021624"
},new StopModel()
{
Name=" Ул.Иван Кралича ",
Kod="1952",
s="1021570"
},new StopModel()
{
Name=" Площад Биримирци ",
Kod="1266",
s="1021579"
},new StopModel()
{
Name=" 60-то ОУ кв. Бенковски ",
Kod="39",
s="1007065"
},new StopModel()
{
Name=" Кв. Бенковски ",
Kod="806",
s="1007053"
},}
},new DirectionModel()
{
Name ="Кв. Бенковски - Пътностроителна техника",
rid="1000717",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Бенковски",
Kod="805",
s="1007056"
},new StopModel()
{
Name="60-то ОУ кв. Бенковски ",
Kod="40",
s="1007068"
},new StopModel()
{
Name="Пл. Биримирци ",
Kod="1267",
s="1007084"
},new StopModel()
{
Name="Ул.Иван Кралича ",
Kod="1953",
s="1021569"
},new StopModel()
{
Name="Ул. Хоризонт ",
Kod="2237",
s="1021625"
},new StopModel()
{
Name="МЕТАЛСНАБ ХОЛДИНГ ",
Kod="1043",
s="1021645"
},new StopModel()
{
Name="Ул.Пробуда ",
Kod="2138",
s="1021659"
},new StopModel()
{
Name="ТЕРСНАБ ",
Kod="1735",
s="1021671"
},new StopModel()
{
Name="ТПК Хемус ",
Kod="1762",
s="1021675"
},new StopModel()
{
Name=" Стинд 1 ",
Kod="550",
s="1015383"
},new StopModel()
{
Name=" Производстен к-с Москва ",
Kod="538",
s="1015379"
},new StopModel()
{
Name=" ПГВАД ",
Kod="1722",
s="1015371"
},new StopModel()
{
Name=" Ул. Локомотив ",
Kod="1001",
s="1015361"
},new StopModel()
{
Name=" Ул.Просвета ",
Kod="2142",
s="1021692"
},new StopModel()
{
Name=" Ул.проф.И.Георго ",
Kod="2149",
s="1021678"
},new StopModel()
{
Name=" Моста на река Суходолска река ",
Kod="1506",
s="1021732"
},new StopModel()
{
Name=" Ул.Снежник ",
Kod="2176",
s="1021744"
},new StopModel()
{
Name=" Ул. Ком ",
Kod="2600",
s="1021748"
},new StopModel()
{
Name=" Кв. Орландовци ",
Kod="883",
s="1021754"
},new StopModel()
{
Name=" Ул.Каменоделска ",
Kod="1978",
s="1006794"
},new StopModel()
{
Name=" Ул. Рояк ",
Kod="2165",
s="1021761"
},new StopModel()
{
Name=" БАЛКАН СТАР ",
Kod="2480",
s="1027328"
},new StopModel()
{
Name=" Ул.Макгахан ",
Kod="2481",
s="1027332"
},new StopModel()
{
Name=" Хипермаркет Била ",
Kod="2107",
s="1001030"
},new StopModel()
{
Name=" Ул.Васил Кънчев ",
Kod="1863",
s="1015121"
},new StopModel()
{
Name=" Стадион Г.Аспарухов ",
Kod="1615",
s="1015133"
},new StopModel()
{
Name=" Ул.Витиня ",
Kod="1753",
s="1015145"
},new StopModel()
{
Name=" Ул.Бесарабия ",
Kod="2540",
s="1027341"
},new StopModel()
{
Name=" Пътностроителна техника ",
Kod="2483",
s="1027347"
},}
},}},

new BusModel()
{
Number = "101",
lid = "1000044",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="ФОНДОВИ ЖИЛИЩА - Пл. Централна гара",
rid="1001071",
Stops=new StopModel[]
{new StopModel()
{
Name="ФОНДОВИ ЖИЛИЩА",
Kod="2292",
s="1021799"
},new StopModel()
{
Name="БУЛАВТО ",
Kod="405",
s="1021831"
},new StopModel()
{
Name="СОВ Геопроучване ",
Kod="2484",
s="1021825"
},new StopModel()
{
Name="МЕТАЛСНАБ ХОЛДИНГ ",
Kod="1043",
s="1021645"
},new StopModel()
{
Name="БЕТОНОВ ВЪЗЕЛ ",
Kod="115",
s="1021865"
},new StopModel()
{
Name="Ж.П.ПРЕЛЕЗ ",
Kod="700",
s="1021861"
},new StopModel()
{
Name="Ул. Локомотив ",
Kod="1001",
s="1015361"
},new StopModel()
{
Name="Ул. Просвета ",
Kod="2143",
s="1015351"
},new StopModel()
{
Name="Ул. Опълченска ",
Kod="2079",
s="1006608"
},new StopModel()
{
Name=" Пл. Централна гара ",
Kod="1328",
s="1015026"
},}
},new DirectionModel()
{
Name ="Пл. Централна гара - ФОНДОВИ ЖИЛИЩА",
rid="1001070",
Stops=new StopModel[]
{new StopModel()
{
Name="Пл. Централна гара",
Kod="1328",
s="1015026"
},new StopModel()
{
Name="Бул. Христо Ботев ",
Kod="382",
s="1002844"
},new StopModel()
{
Name="Ул. Опълченска ",
Kod="2081",
s="1002854"
},new StopModel()
{
Name="Ул. Охрид ",
Kod="2101",
s="1016896"
},new StopModel()
{
Name="Бул. Княгиня Мария Луиза ",
Kod="323",
s="1016899"
},new StopModel()
{
Name="Надлез Надежда ",
Kod="1114",
s="1006463"
},new StopModel()
{
Name="Бул. Илиянци - подлеза ",
Kod="1384",
s="1015344"
},new StopModel()
{
Name="УЛ.ПРОСВЕТА ",
Kod="2519",
s="1015352"
},new StopModel()
{
Name="Ул. Локомотив ",
Kod="1000",
s="1015364"
},new StopModel()
{
Name=" Ж.П.ПРЕЛЕЗ ",
Kod="699",
s="1021862"
},new StopModel()
{
Name=" БЕТОНОВ ВЪЗЕЛ ",
Kod="110",
s="1021868"
},new StopModel()
{
Name=" МЕТАЛСНАБ-ХОЛДИНГ ",
Kod="1042",
s="1021646"
},new StopModel()
{
Name=" СОВ Геопроучване ",
Kod="2485",
s="1021826"
},new StopModel()
{
Name=" БУЛАВТО ",
Kod="404",
s="1021832"
},new StopModel()
{
Name=" ФОНДОВИ ЖИЛИЩА ",
Kod="2293",
s="1021798"
},}
},}},

new BusModel()
{
Number = "102",
lid = "1000012",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Студентски град - Ж.к. Овча купел 2",
rid="1000860",
Stops=new StopModel[]
{new StopModel()
{
Name="Студентски град",
Kod="1693",
s="1010086"
},new StopModel()
{
Name="СК на НСА ",
Kod="1609",
s="1010091"
},new StopModel()
{
Name="Бл. 60 Студентски град ",
Kod="2507",
s="1027592"
},new StopModel()
{
Name="х-л Макси ",
Kod="2321",
s="1013389"
},new StopModel()
{
Name="Студентски град ",
Kod="2382",
s="1013397"
},new StopModel()
{
Name="кв.Витоша ",
Kod="821",
s="1013409"
},new StopModel()
{
Name="Моста кв.Витоша ",
Kod="1076",
s="1013417"
},new StopModel()
{
Name="Ж.к.Дианабад ",
Kod="603",
s="1021069"
},new StopModel()
{
Name="Бл.22, ж.к.Дианабад ",
Kod="124",
s="1021057"
},new StopModel()
{
Name=" Бул. Д-р Г. М. Димитров ",
Kod="317",
s="1017186"
},new StopModel()
{
Name=" Читалище Д. Чинтулов ",
Kod="2366",
s="1017196"
},new StopModel()
{
Name=" ПК Диана ",
Kod="1342",
s="1017206"
},new StopModel()
{
Name=" Гара Пионер ",
Kod="465",
s="1013439"
},new StopModel()
{
Name=" Семинарията ",
Kod="1574",
s="1018146"
},new StopModel()
{
Name=" Хотел Хемус ",
Kod="2328",
s="1021025"
},new StopModel()
{
Name=" ПК Спартак ",
Kod="1344",
s="1021011"
},new StopModel()
{
Name=" Южен парк ",
Kod="2379",
s="1020989"
},new StopModel()
{
Name=" Ж.к.Иван Вазов ",
Kod="623",
s="1013211"
},new StopModel()
{
Name=" Бул. Акад.Ив.Е.Гешов ",
Kod="275",
s="1003908"
},new StopModel()
{
Name=" Пл.Ручей ",
Kod="1306",
s="1003924"
},new StopModel()
{
Name=" Бул.България ",
Kod="290",
s="1003944"
},new StopModel()
{
Name=" Ул. Проф. Д. Атанасов ",
Kod="2135",
s="1003960"
},new StopModel()
{
Name=" Ж.к. Красно село ",
Kod="641",
s="1014479"
},new StopModel()
{
Name=" АП Земляне ",
Kod="80",
s="1014463"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="564",
s="1014453"
},new StopModel()
{
Name=" Ул. Лиляче ",
Kod="2031",
s="1025786"
},new StopModel()
{
Name=" ОЦ Овча купел ",
Kod="1218",
s="1003134"
},new StopModel()
{
Name=" Бл. 519 ж.к. Овча купел 1 ",
Kod="230",
s="1003142"
},new StopModel()
{
Name=" Търговски ц-р Овча купел ",
Kod="212",
s="1003158"
},new StopModel()
{
Name=" Ул. Промишлена ",
Kod="2141",
s="1003170"
},new StopModel()
{
Name=" Бл. 32 ж.к. Овча купел 2 ",
Kod="192",
s="1003178"
},new StopModel()
{
Name=" Бл. 25 ж.к. Овча купел 2 ",
Kod="175",
s="1003186"
},new StopModel()
{
Name=" Пазара Овча купел ",
Kod="1708",
s="1003212"
},new StopModel()
{
Name=" Ж.к. Овча купел 2 ",
Kod="682",
s="1020575"
},}
},new DirectionModel()
{
Name ="Ж.к. Овча купел 2 - Студентски град",
rid="1000859",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Овча купел 2",
Kod="684",
s="1020574"
},new StopModel()
{
Name="Пазара Овча купел ",
Kod="1706",
s="1003211"
},new StopModel()
{
Name="Бл. 25 ж.к. Овча купел 2 ",
Kod="174",
s="1003183"
},new StopModel()
{
Name="Бл. 32 ж.к. Овча купел 2 ",
Kod="191",
s="1003175"
},new StopModel()
{
Name="Ул. Промишлена ",
Kod="2140",
s="1003167"
},new StopModel()
{
Name="Търговски ц-р Овча купел ",
Kod="211",
s="1003155"
},new StopModel()
{
Name="Бл. 519 ж.к. Овча купел 1 ",
Kod="229",
s="1003141"
},new StopModel()
{
Name="ОЦ Овча купел ",
Kod="1219",
s="1003129"
},new StopModel()
{
Name="Ул.Лиляче ",
Kod="2032",
s="1025789"
},new StopModel()
{
Name=" Балканкар АД ",
Kod="569",
s="1014456"
},new StopModel()
{
Name=" АП Земляне ",
Kod="79",
s="1014462"
},new StopModel()
{
Name=" Ж.к. Красно село ",
Kod="637",
s="1014482"
},new StopModel()
{
Name=" Ул.Проф.Д.Атанасов ",
Kod="2134",
s="1003955"
},new StopModel()
{
Name=" Бул.Гоце Делчев ",
Kod="314",
s="1003937"
},new StopModel()
{
Name=" Пл.Ручей ",
Kod="1301",
s="1003921"
},new StopModel()
{
Name=" Бул.Акад.Ив.Гешов ",
Kod="270",
s="1013214"
},new StopModel()
{
Name=" Ж.к.Иван Вазов ",
Kod="626",
s="1013204"
},new StopModel()
{
Name=" Южен парк ",
Kod="2380",
s="1020994"
},new StopModel()
{
Name=" ПК Спартак ",
Kod="1345",
s="1021012"
},new StopModel()
{
Name=" Хотел Хемус ",
Kod="2329",
s="1018127"
},new StopModel()
{
Name=" Семинарията ",
Kod="1569",
s="1018155"
},new StopModel()
{
Name=" Гара Пионер ",
Kod="462",
s="1017217"
},new StopModel()
{
Name=" ПК Диана ",
Kod="1343",
s="1017203"
},new StopModel()
{
Name=" Читалище Д. Чинтулов ",
Kod="2365",
s="1017193"
},new StopModel()
{
Name=" Бул.д-р Г.М.Димитров ",
Kod="315",
s="1021054"
},new StopModel()
{
Name=" Бл.22, ж.к.Дианабад ",
Kod="123",
s="1021058"
},new StopModel()
{
Name=" Ж.к.Дианабад ",
Kod="602",
s="1021074"
},new StopModel()
{
Name=" Моста кв.Витоша ",
Kod="1087",
s="1013414"
},new StopModel()
{
Name=" кв.Витоша ",
Kod="822",
s="1013406"
},new StopModel()
{
Name=" Студентски град ",
Kod="2381",
s="1013394"
},new StopModel()
{
Name=" Хотел Макси ",
Kod="2509",
s="1027601"
},new StopModel()
{
Name=" Бл.60 Студентски град ",
Kod="2508",
s="1027598"
},new StopModel()
{
Name=" СК на НСА ",
Kod="1606",
s="1010092"
},new StopModel()
{
Name=" Студентски град ",
Kod="1694",
s="1010081"
},}
},}},

new BusModel()
{
Number = "107",
lid = "1000029",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Боянско ханче - Кв. Карпузица",
rid="1001836",
Stops=new StopModel[]
{new StopModel()
{
Name="Боянско ханче",
Kod="267",
s="1023408"
},new StopModel()
{
Name="Ул.Байкал ",
Kod="1835",
s="1012859"
},new StopModel()
{
Name="Скиорката ",
Kod="1591",
s="1012373"
},new StopModel()
{
Name="Кв.Бояна ",
Kod="807",
s="1012379"
},new StopModel()
{
Name="Ул. Маломир ",
Kod="2043",
s="1023389"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1178",
s="1023373"
},new StopModel()
{
Name="Бул.Ал.Пушкин ",
Kod="276",
s="1023361"
},new StopModel()
{
Name="Кв. Павлово ",
Kod="890",
s="1023342"
},new StopModel()
{
Name="Кв. Овча купел ",
Kod="882",
s="1023338"
},new StopModel()
{
Name=" НЦ по Рехабилитация ",
Kod="95",
s="1014394"
},new StopModel()
{
Name=" Ул.Любляна ",
Kod="900",
s="1014327"
},new StopModel()
{
Name=" 66-то СОУ ",
Kod="41",
s="1014321"
},new StopModel()
{
Name=" Ул.Калояново ",
Kod="773",
s="1014313"
},new StopModel()
{
Name=" бул.Никола Петков ",
Kod="345",
s="1023314"
},new StopModel()
{
Name=" Ул.Дамяница ",
Kod="1922",
s="1023306"
},new StopModel()
{
Name=" Ул.Арбанаси ",
Kod="1827",
s="1023290"
},new StopModel()
{
Name=" Пл. Сред село ",
Kod="1310",
s="1023284"
},new StopModel()
{
Name=" Ул.полк.Ст.Бачийски ",
Kod="2120",
s="1023276"
},new StopModel()
{
Name=" Ул.Стефан  Пешев ",
Kod="2192",
s="1023270"
},new StopModel()
{
Name=" Ул. Буря ",
Kod="1848",
s="1023260"
},new StopModel()
{
Name=" Кв. Карпузица ",
Kod="849",
s="1023162"
},}
},new DirectionModel()
{
Name ="Кв. Карпузица - Боянско ханче",
rid="1001837",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Карпузица",
Kod="849",
s="1023162"
},new StopModel()
{
Name="Ул. Буря ",
Kod="1849",
s="1023265"
},new StopModel()
{
Name="Ул.Стефан  Пешев ",
Kod="2193",
s="1023273"
},new StopModel()
{
Name="Ул.полк.Ст.Бачийски ",
Kod="2119",
s="1023277"
},new StopModel()
{
Name="Пл. Сред село ",
Kod="1309",
s="1023283"
},new StopModel()
{
Name="Ул.Арбанаси ",
Kod="1828",
s="1023293"
},new StopModel()
{
Name="Ул.Дамяница ",
Kod="1923",
s="1023309"
},new StopModel()
{
Name="Бул.Никола Петков ",
Kod="346",
s="1023245"
},new StopModel()
{
Name="Ул.Калояново ",
Kod="776",
s="1023247"
},new StopModel()
{
Name=" 66-то СОУ ",
Kod="42",
s="1023253"
},new StopModel()
{
Name=" Ул. Любляна ",
Kod="2541",
s="1014415"
},new StopModel()
{
Name=" НЦ по рехабилитация ",
Kod="94",
s="1023321"
},new StopModel()
{
Name=" Кв.Овча купел ",
Kod="875",
s="1022734"
},new StopModel()
{
Name=" кв. Павлово ",
Kod="893",
s="1023343"
},new StopModel()
{
Name=" Бул.Александър Пушкин ",
Kod="278",
s="1023364"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="1179",
s="1023376"
},new StopModel()
{
Name=" Ул. Маломир ",
Kod="2044",
s="1023392"
},new StopModel()
{
Name=" кв.Бояна ",
Kod="808",
s="1012376"
},new StopModel()
{
Name=" Скиорката ",
Kod="1590",
s="1012854"
},new StopModel()
{
Name=" Ул.Байкал ",
Kod="1836",
s="1012860"
},new StopModel()
{
Name=" Боянско ханче ",
Kod="264",
s="1023407"
},}
},}},

new BusModel()
{
Number = "108",
lid = "1000026",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Хюндай България - ж.к. Люлин -5",
rid="1000658",
Stops=new StopModel[]
{new StopModel()
{
Name="Хюндай България",
Kod="1637",
s="1016153"
},new StopModel()
{
Name="Стоков базар Илиянци ",
Kod="2457",
s="1027116"
},new StopModel()
{
Name="Софарма АД ",
Kod="743",
s="1016097"
},new StopModel()
{
Name="ЗАГ Динамик АД ",
Kod="726",
s="1016103"
},new StopModel()
{
Name="ПГХМБТ Проф.П.Райков ",
Kod="1764",
s="1016117"
},new StopModel()
{
Name="Ул. Ген. Никола Жеков ",
Kod="1900",
s="1016597"
},new StopModel()
{
Name="102-ро ОУ ",
Kod="2578",
s="1016603"
},new StopModel()
{
Name="24-ти ДКЦ ",
Kod="18",
s="1016613"
},new StopModel()
{
Name="Бл. 458 ж.к. Надежда 4 ",
Kod="221",
s="1016629"
},new StopModel()
{
Name=" Бул. Ломско шосе ",
Kod="333",
s="1016975"
},new StopModel()
{
Name=" Бул.Ломско шосе ",
Kod="330",
s="1022967"
},new StopModel()
{
Name=" Бл.302 ж.к.Надежда 3 ",
Kod="188",
s="1022975"
},new StopModel()
{
Name=" Община Връбница ",
Kod="675",
s="1016200"
},new StopModel()
{
Name=" Ул. Надежда ",
Kod="2052",
s="1016232"
},new StopModel()
{
Name=" ул. Връх Манчо ",
Kod="1200",
s="1010679"
},new StopModel()
{
Name=" СПИИДО ЕООД ",
Kod="716",
s="1010691"
},new StopModel()
{
Name=" Западен парк ",
Kod="2399",
s="1022947"
},new StopModel()
{
Name=" УЛ.ОРИОН ",
Kod="2091",
s="1003662"
},new StopModel()
{
Name=" ул. Луи Пастьор ",
Kod="2166",
s="1003652"
},new StopModel()
{
Name=" Читалище св.св. Кирил и Методий ",
Kod="511",
s="1003648"
},new StopModel()
{
Name=" ТРИЪГЪЛНИКА-ЛЮЛИН ",
Kod="1781",
s="1003638"
},new StopModel()
{
Name=" Метростанция Сливница ",
Kod="1061",
s="1021873"
},new StopModel()
{
Name=" Ул.проф. Ал. Станишев ",
Kod="2364",
s="1020952"
},new StopModel()
{
Name=" 36-ти пощенски код ",
Kod="30",
s="1022936"
},new StopModel()
{
Name=" Бл.301, ж.к.Люлин-3 ",
Kod="185",
s="1022922"
},new StopModel()
{
Name=" Бл. 350 ж.к.Люлин-3 ",
Kod="198",
s="1022916"
},new StopModel()
{
Name=" Ж.к.Люлин-3 ",
Kod="654",
s="1015874"
},new StopModel()
{
Name=" ж.к. Люлин -5 ",
Kod="657",
s="1016046"
},}
},new DirectionModel()
{
Name ="ж.к. Люлин -5 - Хюндай България",
rid="1000659",
Stops=new StopModel[]
{new StopModel()
{
Name="ж.к. Люлин -5",
Kod="657",
s="1016048"
},new StopModel()
{
Name="Бл.402 ж.к.Люлин 4 ",
Kod="208",
s="1015875"
},new StopModel()
{
Name="Бл.350, ж.к.Люлин-3 ",
Kod="199",
s="1022915"
},new StopModel()
{
Name="Бл.301, ж.к.Люлин-3 ",
Kod="186",
s="1022925"
},new StopModel()
{
Name="36-ти пощенски клон ",
Kod="29",
s="1022937"
},new StopModel()
{
Name="Хипермаркет Била ",
Kod="2306",
s="1020943"
},new StopModel()
{
Name="Ул.Проф.А.Станишев ",
Kod="2357",
s="1003625"
},new StopModel()
{
Name="МЕТРОСТАНЦИЯ СЛИВНИЦА ",
Kod="1060",
s="1003635"
},new StopModel()
{
Name="ТРИЪГЪЛНИКА-ЛЮЛИН ",
Kod="1783",
s="1003641"
},new StopModel()
{
Name=" Читалище св.св. Кирил и Методий ",
Kod="512",
s="1003647"
},new StopModel()
{
Name=" ул. Луи Пастьор ",
Kod="2167",
s="1003655"
},new StopModel()
{
Name=" Ул.Орион ",
Kod="2093",
s="1003667"
},new StopModel()
{
Name=" Западен парк ",
Kod="1252",
s="1022952"
},new StopModel()
{
Name=" СПИИДО ЕООД ",
Kod="715",
s="1010692"
},new StopModel()
{
Name=" Ул.Връх Манчо ",
Kod="1201",
s="1016239"
},new StopModel()
{
Name=" Ул. Надежда ",
Kod="2051",
s="1016231"
},new StopModel()
{
Name=" Бл.302 ж.к.Надежда-3 ",
Kod="187",
s="1022974"
},new StopModel()
{
Name=" Бул. Ломско шосе ",
Kod="334",
s="1016970"
},new StopModel()
{
Name=" Бул. 458 ж.к. Надежда 4 ",
Kod="222",
s="1016620"
},new StopModel()
{
Name=" 24-ти ДКЦ ",
Kod="19",
s="1016610"
},new StopModel()
{
Name=" 102-ро ОУ ",
Kod="2",
s="1016602"
},new StopModel()
{
Name=" Ул. Ген. Никола Жеков ",
Kod="1901",
s="1016596"
},new StopModel()
{
Name=" ПГХМБТ Проф. П.Райков ",
Kod="1763",
s="1016116"
},new StopModel()
{
Name=" ЗАГ Динамик ",
Kod="725",
s="1016102"
},new StopModel()
{
Name=" Софарма АД ",
Kod="746",
s="1016096"
},new StopModel()
{
Name=" Стоков базар Илиянци ",
Kod="2456",
s="1026549"
},new StopModel()
{
Name=" Хюндай България ",
Kod="1637",
s="1016153"
},}
},}},

new BusModel()
{
Number = "111",
lid = "1000003",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к.Младост-1 - Ж.к.Люлин-1,2",
rid="1001805",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Младост-1",
Kod="661",
s="1018869"
},new StopModel()
{
Name="Посолствата ",
Kod="1401",
s="1018859"
},new StopModel()
{
Name="Онкологичен диспансер ",
Kod="22",
s="1027323"
},new StopModel()
{
Name="Пазара Младост 1 ",
Kod="968",
s="1018835"
},new StopModel()
{
Name="Бл. 66 ж.к. Младост 1 ",
Kod="245",
s="1018825"
},new StopModel()
{
Name="Бл. 56 ж.к. Младост 1 ",
Kod="233",
s="1017086"
},new StopModel()
{
Name="Бл. 223 ж.к. Младост 2 ",
Kod="169",
s="1009062"
},new StopModel()
{
Name="Бл. 222 ж.к. Младост 2 ",
Kod="167",
s="1009068"
},new StopModel()
{
Name="Ул.д-р Атанас Москов ",
Kod="1919",
s="1014776"
},new StopModel()
{
Name=" Бл.202 ж.к.Младост 2 ",
Kod="154",
s="1014786"
},new StopModel()
{
Name=" МВР Академия ",
Kod="2374",
s="1014808"
},new StopModel()
{
Name=" Бизнес парк София ",
Kod="2490",
s="1027727"
},new StopModel()
{
Name=" Кино Арена 2 ",
Kod="2648",
s="1027732"
},new StopModel()
{
Name=" Бизнес парк София ",
Kod="2625",
s="1020647"
},new StopModel()
{
Name=" В.з. Малинова долина ",
Kod="1374",
s="1020605"
},new StopModel()
{
Name=" Ул.Бистришко шосе ",
Kod="864",
s="1020606"
},new StopModel()
{
Name=" Разклона за кв. Симеоново ",
Kod="1458",
s="1020607"
},new StopModel()
{
Name=" Разклона за кв. Драгалевци ",
Kod="1456",
s="1020608"
},new StopModel()
{
Name=" Кв.Киноцентъра ",
Kod="1966",
s="1020609"
},new StopModel()
{
Name=" НИМ ",
Kod="1465",
s="1012453"
},new StopModel()
{
Name=" Бул.Ал.Пушкин ",
Kod="277",
s="1020741"
},new StopModel()
{
Name=" Бул.Цар Борис ІІІ ",
Kod="388",
s="1020742"
},new StopModel()
{
Name=" Бул. Никола Петков ",
Kod="347",
s="1014308"
},new StopModel()
{
Name=" Ул. Монтевидео ",
Kod="2049",
s="1014305"
},new StopModel()
{
Name=" РЦ по Протезиране ",
Kod="68",
s="1020745"
},new StopModel()
{
Name=" Ул. 640 ",
Kod="1813",
s="1020746"
},new StopModel()
{
Name=" ж.к.Овча купел-2 ",
Kod="685",
s="1020747"
},new StopModel()
{
Name=" Ул.Н.Хрелков ",
Kod="82",
s="1020748"
},new StopModel()
{
Name=" кв.Суходол ",
Kod="1170",
s="1020858"
},new StopModel()
{
Name=" Яз.Суходол ",
Kod="2383",
s="1020894"
},new StopModel()
{
Name=" Ул.Филиповско шосе ",
Kod="908",
s="1015887"
},new StopModel()
{
Name=" Бл.402 ж.к.Люлин 4 ",
Kod="208",
s="1015875"
},new StopModel()
{
Name=" Ж.к.Люлин 3 ",
Kod="652",
s="1020927"
},new StopModel()
{
Name=" Ул.308 ",
Kod="1799",
s="1020915"
},new StopModel()
{
Name=" Община Люлин ",
Kod="1719",
s="1020907"
},new StopModel()
{
Name=" Търговски ц-р Люлин ",
Kod="1789",
s="1019645"
},new StopModel()
{
Name=" Хипермаркет Била ",
Kod="2306",
s="1020943"
},new StopModel()
{
Name=" Бул.Панчо Владигеров ",
Kod="1782",
s="1003618"
},new StopModel()
{
Name=" 26-ти ДКЦ ",
Kod="20",
s="1003612"
},new StopModel()
{
Name=" 90-то СОУ ",
Kod="2272",
s="1003608"
},new StopModel()
{
Name=" Бл.21 ж.к.Люлин-1 ",
Kod="1163",
s="1003600"
},new StopModel()
{
Name=" Ж.к.Люлин-1,2 ",
Kod="649",
s="1003596"
},}
},new DirectionModel()
{
Name ="Ж.к.Люлин-1,2 - Ж.к.Младост 1",
rid="1001804",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Люлин-1,2",
Kod="650",
s="1003597"
},new StopModel()
{
Name="Бл.21 ж.к.Люлин 1 ",
Kod="1164",
s="1003601"
},new StopModel()
{
Name="90-то СОУ ",
Kod="2277",
s="1003609"
},new StopModel()
{
Name="26-ти ДКЦ ",
Kod="21",
s="1003613"
},new StopModel()
{
Name="Ул.проф. Ал. Станишев ",
Kod="2364",
s="1020952"
},new StopModel()
{
Name="Хипермаркет Била ",
Kod="2681",
s="1028720"
},new StopModel()
{
Name="Търговски център Люлин ",
Kod="1788",
s="1019644"
},new StopModel()
{
Name="Община Люлин ",
Kod="1716",
s="1020908"
},new StopModel()
{
Name="Ул.308 ",
Kod="1798",
s="1020916"
},new StopModel()
{
Name=" Ж.к.Люлин 3 ",
Kod="653",
s="1020928"
},new StopModel()
{
Name=" Бл.402 ж.к.Люлин 4 ",
Kod="207",
s="1015880"
},new StopModel()
{
Name=" Ул.Филиповско шосе ",
Kod="907",
s="1015888"
},new StopModel()
{
Name=" Яз.Суходол ",
Kod="1877",
s="1020893"
},new StopModel()
{
Name=" кв.Суходол ",
Kod="1173",
s="1020859"
},new StopModel()
{
Name=" Ул.Н.Хрелков ",
Kod="83",
s="1020852"
},new StopModel()
{
Name=" ж.к.Овча купел-2 ",
Kod="683",
s="1020755"
},new StopModel()
{
Name=" Ул.640 ",
Kod="1814",
s="1020754"
},new StopModel()
{
Name=" РЦ по Протезиране ",
Kod="70",
s="1020753"
},new StopModel()
{
Name=" Ул. Монтевидео ",
Kod="2050",
s="1020752"
},new StopModel()
{
Name=" Бул. Никола Петков ",
Kod="350",
s="1020751"
},new StopModel()
{
Name=" Бул. Цар Борис ІІІ ",
Kod="390",
s="1020750"
},new StopModel()
{
Name=" Бул.Александър Пушкин ",
Kod="279",
s="1020749"
},new StopModel()
{
Name=" НИМ ",
Kod="1464",
s="1012460"
},new StopModel()
{
Name=" Кв.Киноцентъра ",
Kod="1967",
s="1020610"
},new StopModel()
{
Name=" Ботаническа градина ",
Kod="2685",
s="1020697"
},new StopModel()
{
Name=" Разклона за кв.Драгалевци ",
Kod="1457",
s="1020611"
},new StopModel()
{
Name=" Разклона за кв. Симеоново ",
Kod="1459",
s="1027546"
},new StopModel()
{
Name=" Ул.Бистришко шосе ",
Kod="865",
s="1020653"
},new StopModel()
{
Name=" В.З.Малинова долина ",
Kod="2623",
s="1020645"
},new StopModel()
{
Name=" Резиденшъл Парк София ",
Kod="2624",
s="1028338"
},new StopModel()
{
Name=" Местност Камбаните ",
Kod="2649",
s="1028340"
},new StopModel()
{
Name=" Бизнес парк София ",
Kod="2491",
s="1027754"
},new StopModel()
{
Name=" МВР Академия ",
Kod="2373",
s="1014805"
},new StopModel()
{
Name=" Бл.202,ж.к.Младост-2 ",
Kod="155",
s="1014783"
},new StopModel()
{
Name=" Ул. Д-р Ат. Москов ",
Kod="1917",
s="1009077"
},new StopModel()
{
Name=" Бл. 222 ж.к. Младост 2 ",
Kod="168",
s="1009067"
},new StopModel()
{
Name=" Бл. 56 ж.к. Младост 1 ",
Kod="234",
s="1017085"
},new StopModel()
{
Name=" Бл. 66 ж.к. Младост 1 ",
Kod="246",
s="1018826"
},new StopModel()
{
Name=" Пазара Младост 1 ",
Kod="969",
s="1018836"
},new StopModel()
{
Name=" Ул.Йерусалим ",
Kod="2471",
s="1018842"
},new StopModel()
{
Name=" Онкологичен диспансер ",
Kod="23",
s="1018852"
},new StopModel()
{
Name=" Посолствата ",
Kod="1400",
s="1018860"
},new StopModel()
{
Name=" Ж.к.Младост 1 ",
Kod="662",
s="1018870"
},}
},}},

new BusModel()
{
Number = "113",
lid = "1000148",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="бл. 480 ж.к. Младост 4 - Ж.к.Младост 1",
rid="1001809",
Stops=new StopModel[]
{new StopModel()
{
Name="бл. 480 ж.к. Младост 4",
Kod="2395",
s="1003265"
},new StopModel()
{
Name="бл.465 ж.к.Младост 4 ",
Kod="224",
s="1003272"
},new StopModel()
{
Name="115-ти пощенски клон ",
Kod="1759",
s="1003331"
},new StopModel()
{
Name="131-во ОУ ",
Kod="9",
s="1003323"
},new StopModel()
{
Name="Бл. 411 ж.к. Младост 4 ",
Kod="4",
s="1003319"
},new StopModel()
{
Name="Община МЛАДОСТ ",
Kod="944",
s="1003311"
},new StopModel()
{
Name="144-то СОУ ",
Kod="2276",
s="1003303"
},new StopModel()
{
Name="Бл. 56 ж.к. Младост 1 ",
Kod="234",
s="1017085"
},new StopModel()
{
Name="Бл. 66 ж.к. Младост 1 ",
Kod="246",
s="1018826"
},new StopModel()
{
Name=" Пазара Младост 1 ",
Kod="969",
s="1018836"
},new StopModel()
{
Name=" Ул.Йерусалим ",
Kod="2471",
s="1018842"
},new StopModel()
{
Name=" Онкологичен диспансер ",
Kod="23",
s="1018852"
},new StopModel()
{
Name=" Посолствата ",
Kod="1400",
s="1018860"
},new StopModel()
{
Name=" Ж.к.Младост 1 ",
Kod="662",
s="1018870"
},}
},new DirectionModel()
{
Name ="Ж.к.Младост-1 - бл. 480 ж.к. Младост 4",
rid="1001808",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Младост-1",
Kod="661",
s="1018869"
},new StopModel()
{
Name="Посолствата ",
Kod="1401",
s="1018859"
},new StopModel()
{
Name="Онкологичен диспансер ",
Kod="22",
s="1027323"
},new StopModel()
{
Name="Пазара Младост 1 ",
Kod="968",
s="1018835"
},new StopModel()
{
Name="Бл. 66 ж.к. Младост 1 ",
Kod="245",
s="1018825"
},new StopModel()
{
Name="Бл. 56 ж.к. Младост 1 ",
Kod="233",
s="1017086"
},new StopModel()
{
Name="144-то СОУ ",
Kod="2273",
s="1003306"
},new StopModel()
{
Name="Община Младост ",
Kod="947",
s="1003314"
},new StopModel()
{
Name="Бл.411 ж.к.Младост 4 ",
Kod="3",
s="1003322"
},new StopModel()
{
Name=" 131-во ОУ ",
Kod="8",
s="1003326"
},new StopModel()
{
Name=" 115-ти пощенски клон ",
Kod="1760",
s="1003332"
},new StopModel()
{
Name=" Бл.442 ж.к.Младост 4 ",
Kod="2389",
s="1003249"
},new StopModel()
{
Name=" Бизнеспарк София ",
Kod="2391",
s="1003253"
},new StopModel()
{
Name=" бл.472 ж.к. Младост 4 ",
Kod="2393",
s="1003261"
},new StopModel()
{
Name=" бл. 480 ж.к. Младост 4 ",
Kod="2395",
s="1003265"
},}
},}},

new BusModel()
{
Number = "114",
lid = "1000033",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Метростанция Цариградско шосе - Бл.255 ж.к.Дружба 2",
rid="1001753",
Stops=new StopModel[]
{new StopModel()
{
Name="Метростанция Цариградско шосе",
Kod="1017",
s="1001939"
},new StopModel()
{
Name="Корабчето ",
Kod="970",
s="1002252"
},new StopModel()
{
Name="Хипермаркет Практикер ",
Kod="2408",
s="1019128"
},new StopModel()
{
Name="Бл.405 ж.к.Дружба 2 ",
Kod="1487",
s="1019118"
},new StopModel()
{
Name="163-то ОУ ",
Kod="14",
s="1019106"
},new StopModel()
{
Name="Ул.Обиколна ",
Kod="2069",
s="1019088"
},new StopModel()
{
Name="Бл.255 ж.к.Дружба 2 ",
Kod="176",
s="1004147"
},}
},new DirectionModel()
{
Name ="Бл.255 ж.к.Дружба 2 - Метростанция Цариградско шосе (крайна)",
rid="1001752",
Stops=new StopModel[]
{new StopModel()
{
Name="Бл.255 ж.к.Дружба 2",
Kod="176",
s="1004147"
},new StopModel()
{
Name="Бл. 155ж.к. Дружба 1 ",
Kod="141",
s="1012120"
},new StopModel()
{
Name="Бл. 59 ж.к. Дружба 1 ",
Kod="236",
s="1019039"
},new StopModel()
{
Name="Държавна печатница ",
Kod="553",
s="1016396"
},new StopModel()
{
Name="Държавна печатница ",
Kod="554",
s="1001965"
},new StopModel()
{
Name="Комплекс на БАН ",
Kod="2682",
s="1001951"
},new StopModel()
{
Name="Метростанция Цариградско шосе ",
Kod="крайна)",
s="1001943"
},}
},}},

new BusModel()
{
Number = "117",
lid = "1000034",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="град Бухово - Автостанция Изток",
rid="1001598",
Stops=new StopModel[]
{new StopModel()
{
Name="град Бухово",
Kod="504",
s="1017881"
},new StopModel()
{
Name="Ул. Захари Попов ",
Kod="2684",
s="1017504"
},new StopModel()
{
Name="КУЛТУРЕН ДОМ ",
Kod="992",
s="1017516"
},new StopModel()
{
Name="117-то СОУ ",
Kod="1162",
s="1023053"
},new StopModel()
{
Name="РУДНИКА ",
Kod="1486",
s="1023061"
},new StopModel()
{
Name="КАРИЕРАТА ",
Kod="795",
s="1023065"
},new StopModel()
{
Name="Подстанция металургична ",
Kod="1387",
s="1023075"
},new StopModel()
{
Name="Ул. Липа ",
Kod="2534",
s="1023079"
},new StopModel()
{
Name="ул. Гергана ",
Kod="2513",
s="1023081"
},new StopModel()
{
Name=" Ул. Стара планина ",
Kod="2536",
s="1027850"
},new StopModel()
{
Name=" КВ. СЕСЛАВЦИ ",
Kod="898",
s="1027854"
},new StopModel()
{
Name=" Разклона за кв. Сеславци ",
Kod="2530",
s="1023091"
},new StopModel()
{
Name=" Гробищен парк Кремиковци ",
Kod="2628",
s="1023093"
},new StopModel()
{
Name=" Бл. 8 ж.к. Кремиковци ",
Kod="2640",
s="1028517"
},new StopModel()
{
Name=" 156-то ОУ ",
Kod="2638",
s="1028523"
},new StopModel()
{
Name=" Ул. Света Петка ",
Kod="2636",
s="1028528"
},new StopModel()
{
Name=" Ул. Радивоя ",
Kod="2634",
s="1028532"
},new StopModel()
{
Name=" КВ. КРЕМИКОВЦИ ",
Kod="855",
s="1023113"
},new StopModel()
{
Name=" ГАРА РУДНИЧНА ",
Kod="475",
s="1023125"
},new StopModel()
{
Name=" УНИКАЛНИ КОНСТРУКЦИИ ",
Kod="2264",
s="1023129"
},new StopModel()
{
Name=" ЗСК Кремиковци АД ",
Kod="751",
s="1023135"
},new StopModel()
{
Name=" По желание - ШОЛЦ България ",
Kod="2532",
s="1023139"
},new StopModel()
{
Name=" Ж.П.ПРЕЛЕЗ ",
Kod="703",
s="1023155"
},new StopModel()
{
Name=" ЕЛЕКТРОТЕРМИЯ ",
Kod="570",
s="1023159"
},new StopModel()
{
Name=" ИНСТИТУТ ПО ЧЕРНА МЕТАЛУРГИЯ ",
Kod="767",
s="1023161"
},new StopModel()
{
Name=" Ж.к.Ботунец 2 ",
Kod="585",
s="1005334"
},new StopModel()
{
Name=" Община Кремиковци ",
Kod="1755",
s="1005360"
},new StopModel()
{
Name=" разклона кв. Кремиковци ",
Kod="1375",
s="1021528"
},new StopModel()
{
Name=" моста на Лесновска река ",
Kod="1690",
s="1005408"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1645",
s="1005452"
},new StopModel()
{
Name=" По желание ",
Kod="1354",
s="1005460"
},new StopModel()
{
Name=" Махала Япаджа ",
Kod="1440",
s="1005470"
},new StopModel()
{
Name=" Махала Батареята ",
Kod="1648",
s="1004616"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР ",
Kod="1098",
s="1005502"
},new StopModel()
{
Name=" СПИ ПРОФ. ПЕТЪР МУТАФЧИЕВ ",
Kod="1601",
s="1005514"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1435",
s="1005520"
},new StopModel()
{
Name=" СЕРВИЗ Изток ",
Kod="1580",
s="1017923"
},new StopModel()
{
Name=" Автостанция Изток ",
Kod="56",
s="1005187"
},}
},new DirectionModel()
{
Name ="Автостанция Изток - град Бухово",
rid="1001597",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Изток",
Kod="57",
s="1005189"
},new StopModel()
{
Name="СЕРВИЗ Изток ",
Kod="1583",
s="1017922"
},new StopModel()
{
Name="ПЪТЯ ЗА ЛЕТИЩЕ ВРАЖДЕБНА ",
Kod="2407",
s="1017890"
},new StopModel()
{
Name="Разклона за летището ",
Kod="1434",
s="1005515"
},new StopModel()
{
Name="СПИ ПРОФ. ПЕТЪР МУТАФЧИЕВ ",
Kod="1600",
s="1005511"
},new StopModel()
{
Name="МОСТА НА р. ИСКЪР ",
Kod="1097",
s="1005549"
},new StopModel()
{
Name="Махала Батареята ",
Kod="1649",
s="1004615"
},new StopModel()
{
Name="Махала Япаджа ",
Kod="1441",
s="1005469"
},new StopModel()
{
Name="По желание ",
Kod="1355",
s="1005459"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1644",
s="1005451"
},new StopModel()
{
Name=" Моста на Лесновска река ",
Kod="1687",
s="1021523"
},new StopModel()
{
Name=" разклона кв. Кремиковци ",
Kod="1376",
s="1021529"
},new StopModel()
{
Name=" Община Кремиковци ",
Kod="1756",
s="1005359"
},new StopModel()
{
Name=" ж. к. Ботунец-2 ",
Kod="584",
s="1005331"
},new StopModel()
{
Name=" Институт по черна металургия ",
Kod="770",
s="1023160"
},new StopModel()
{
Name=" Електротермия ",
Kod="571",
s="1023158"
},new StopModel()
{
Name=" ж. п. прелез ",
Kod="702",
s="1023154"
},new StopModel()
{
Name=" По желание-ШОЛЦ България ",
Kod="2533",
s="1023138"
},new StopModel()
{
Name=" Уникални конструкции ",
Kod="2265",
s="1023130"
},new StopModel()
{
Name=" гара Руднична ",
Kod="474",
s="1023124"
},new StopModel()
{
Name=" кв. Кремиковци ",
Kod="854",
s="1023112"
},new StopModel()
{
Name=" ул. Радивоя ",
Kod="2633",
s="1028500"
},new StopModel()
{
Name=" ул. Св. Петка ",
Kod="2635",
s="1028504"
},new StopModel()
{
Name=" 156-то СОУ ",
Kod="2637",
s="1028508"
},new StopModel()
{
Name=" бл. 8 ж. к. Кремиковци ",
Kod="2639",
s="1028516"
},new StopModel()
{
Name=" Гробищен парк Кремиковци ",
Kod="2627",
s="1023092"
},new StopModel()
{
Name=" Разклона за кв. Сеславци ",
Kod="2531",
s="1023090"
},new StopModel()
{
Name=" кв. Сеславци ",
Kod="897",
s="1023086"
},new StopModel()
{
Name=" ул. Стара планина ",
Kod="2537",
s="1027863"
},new StopModel()
{
Name=" ул. Гергана ",
Kod="2514",
s="1023082"
},new StopModel()
{
Name=" ул. Липа ",
Kod="2535",
s="1023078"
},new StopModel()
{
Name=" Подстанция Металургична ",
Kod="1386",
s="1023074"
},new StopModel()
{
Name=" Кариерата ",
Kod="794",
s="1023064"
},new StopModel()
{
Name=" Рудника ",
Kod="1485",
s="1023060"
},new StopModel()
{
Name=" 117-то СОУ ",
Kod="1161",
s="1023052"
},new StopModel()
{
Name=" Културен дом ",
Kod="993",
s="1017515"
},new StopModel()
{
Name=" Ул. Захари Попов ",
Kod="2683",
s="1017503"
},new StopModel()
{
Name=" град Бухово ",
Kod="504",
s="1017881"
},}
},}},

new BusModel()
{
Number = "118",
lid = "1000035",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="СЕЛО ЖЕЛЯВА - Автостанция Изток",
rid="1001002",
Stops=new StopModel[]
{new StopModel()
{
Name="СЕЛО ЖЕЛЯВА",
Kod="1532",
s="1021489"
},new StopModel()
{
Name="начало с. Желява ",
Kod="1663",
s="1021484"
},new StopModel()
{
Name="разклона магистрала Хемус ",
Kod="1444",
s="1021473"
},new StopModel()
{
Name="база Газстрой ",
Kod="88",
s="1021466"
},new StopModel()
{
Name="УЛ. СТАРА ПЛАНИНА ",
Kod="2185",
s="1021454"
},new StopModel()
{
Name="КМЕТСТВО СЕЛО ЯНА ",
Kod="950",
s="1021424"
},new StopModel()
{
Name="УЛ. ЮРИЙ ГАГАРИН ",
Kod="2262",
s="1021422"
},new StopModel()
{
Name="ГАРА ЯНА ",
Kod="479",
s="1017626"
},new StopModel()
{
Name="КАВАЦИТЕ ",
Kod="780",
s="1017678"
},new StopModel()
{
Name=" СЕЛО ГОРНИ БОГРОВ ",
Kod="1521",
s="1021415"
},new StopModel()
{
Name=" 115-то ОУ ",
Kod="1887",
s="1021387"
},new StopModel()
{
Name=" Металика ООД ",
Kod="1160",
s="1021345"
},new StopModel()
{
Name=" Център кв. Ботунец ",
Kod="1235",
s="1021327"
},new StopModel()
{
Name=" 16-ти ДКЦ ",
Kod="1774",
s="1021336"
},new StopModel()
{
Name=" Община Кремиковци ",
Kod="1755",
s="1005360"
},new StopModel()
{
Name=" разклона кв. Кремиковци ",
Kod="1375",
s="1021528"
},new StopModel()
{
Name=" моста на Лесновска река ",
Kod="1690",
s="1005408"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1645",
s="1005452"
},new StopModel()
{
Name=" По желание ",
Kod="1354",
s="1005460"
},new StopModel()
{
Name=" Махала Япаджа ",
Kod="1440",
s="1005470"
},new StopModel()
{
Name=" Махала Батареята ",
Kod="1648",
s="1004616"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР ",
Kod="1098",
s="1005502"
},new StopModel()
{
Name=" СПИ ПРОФ. ПЕТЪР МУТАФЧИЕВ ",
Kod="1601",
s="1005514"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1435",
s="1005520"
},new StopModel()
{
Name=" СЕРВИЗ Изток ",
Kod="1580",
s="1017923"
},new StopModel()
{
Name=" Автостанция Изток ",
Kod="56",
s="1005187"
},}
},new DirectionModel()
{
Name ="Автостанция Изток - СЕЛО ЖЕЛЯВА",
rid="1000103",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Изток",
Kod="57",
s="1005189"
},new StopModel()
{
Name="СЕРВИЗ Изток ",
Kod="1583",
s="1017922"
},new StopModel()
{
Name="ПЪТЯ ЗА ЛЕТИЩЕ ВРАЖДЕБНА ",
Kod="2407",
s="1017890"
},new StopModel()
{
Name="Разклона за летището ",
Kod="1434",
s="1005515"
},new StopModel()
{
Name="СПИ ПРОФ. ПЕТЪР МУТАФЧИЕВ ",
Kod="1600",
s="1005511"
},new StopModel()
{
Name="МОСТА НА р. ИСКЪР ",
Kod="1097",
s="1005549"
},new StopModel()
{
Name="Махала Батареята ",
Kod="1649",
s="1004615"
},new StopModel()
{
Name="Махала Япаджа ",
Kod="1441",
s="1005469"
},new StopModel()
{
Name="По желание ",
Kod="1355",
s="1005459"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1644",
s="1005451"
},new StopModel()
{
Name=" Моста на Лесновска река ",
Kod="1687",
s="1021523"
},new StopModel()
{
Name=" разклона кв. Кремиковци ",
Kod="1376",
s="1021529"
},new StopModel()
{
Name=" Община Кремиковци ",
Kod="1756",
s="1005359"
},new StopModel()
{
Name=" 16-ти ДКЦ ",
Kod="1773",
s="1021337"
},new StopModel()
{
Name=" Център кв. Ботунец ",
Kod="1236",
s="1021328"
},new StopModel()
{
Name=" Металика ООД ",
Kod="1159",
s="1021344"
},new StopModel()
{
Name=" 115-то ОУ ",
Kod="1888",
s="1021386"
},new StopModel()
{
Name=" СЕЛО ГОРНИ БОГРОВ ",
Kod="1520",
s="1017696"
},new StopModel()
{
Name=" СЕЛО ГОРНИ БОГРОВ ",
Kod="1522",
s="1017695"
},new StopModel()
{
Name=" КАВАЦИТЕ ",
Kod="781",
s="1017675"
},new StopModel()
{
Name=" ГАРА ЯНА ",
Kod="478",
s="1017625"
},new StopModel()
{
Name=" УЛ. ЮРИЙ ГАГАРИН ",
Kod="2263",
s="1021421"
},new StopModel()
{
Name=" КМЕТСТВО СЕЛО ЯНА ",
Kod="951",
s="1021423"
},new StopModel()
{
Name=" УЛ. СТАРА ПЛАНИНА ",
Kod="2184",
s="1021453"
},new StopModel()
{
Name=" База Газстрой ",
Kod="87",
s="1021465"
},new StopModel()
{
Name=" Разклона магистрала Хемус ",
Kod="1445",
s="1021474"
},new StopModel()
{
Name=" Начало с. Желява ",
Kod="1664",
s="1021485"
},new StopModel()
{
Name=" СЕЛО ЖЕЛЯВА ",
Kod="1532",
s="1021489"
},}
},}},

new BusModel()
{
Number = "119",
lid = "1000036",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Изток - Супермаркет",
rid="1001427",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Изток",
Kod="2427",
s="1004381"
},new StopModel()
{
Name="Ул. Ст. Доспевски ",
Kod="2180",
s="1004403"
},new StopModel()
{
Name="Бл. 11 ж.к. Левски В ",
Kod="130",
s="1004413"
},new StopModel()
{
Name="Сервиз Изток ",
Kod="1581",
s="1005539"
},new StopModel()
{
Name="Разклона за летището ",
Kod="1434",
s="1005515"
},new StopModel()
{
Name="СПИ ПРОФ. ПЕТЪР МУТАФЧИЕВ ",
Kod="1600",
s="1005511"
},new StopModel()
{
Name="МОСТА НА р. ИСКЪР ",
Kod="1097",
s="1005549"
},new StopModel()
{
Name="Махала Батареята ",
Kod="1649",
s="1004615"
},new StopModel()
{
Name="Махала Япаджа ",
Kod="1441",
s="1005469"
},new StopModel()
{
Name=" По желание ",
Kod="1355",
s="1005459"
},new StopModel()
{
Name=" Промишлена зона ",
Kod="1644",
s="1005451"
},new StopModel()
{
Name=" Моста на Лесновска река ",
Kod="1689",
s="1005405"
},new StopModel()
{
Name=" Кв.Челопечене ",
Kod="1561",
s="1005389"
},new StopModel()
{
Name=" Община Кремиковци ",
Kod="1756",
s="1005359"
},new StopModel()
{
Name=" 16-ти ДКЦ ",
Kod="1773",
s="1021337"
},new StopModel()
{
Name=" Хлебозавод Ботунец ",
Kod="2315",
s="1021550"
},new StopModel()
{
Name=" Бл.3 ж.к.Ботунец 1 ",
Kod="183",
s="1021551"
},new StopModel()
{
Name=" Супермаркет ",
Kod="1707",
s="1021552"
},}
},new DirectionModel()
{
Name ="Супермаркет - Автостанция Изток",
rid="1001428",
Stops=new StopModel[]
{new StopModel()
{
Name="Супермаркет",
Kod="1707",
s="1021552"
},new StopModel()
{
Name="Център кв. Ботунец ",
Kod="1235",
s="1021327"
},new StopModel()
{
Name="16-ти ДКЦ ",
Kod="1774",
s="1021336"
},new StopModel()
{
Name="Община Кремиковци ",
Kod="1755",
s="1005360"
},new StopModel()
{
Name="Кв.Челопечене ",
Kod="1560",
s="1005390"
},new StopModel()
{
Name="Моста на Лесновска река ",
Kod="1688",
s="1005406"
},new StopModel()
{
Name="Промишлена зона ",
Kod="1645",
s="1005452"
},new StopModel()
{
Name="По желание ",
Kod="1354",
s="1005460"
},new StopModel()
{
Name="Махала Япаджа ",
Kod="1440",
s="1005470"
},new StopModel()
{
Name=" Махала Батареята ",
Kod="1648",
s="1004616"
},new StopModel()
{
Name=" МОСТА НА р. ИСКЪР ",
Kod="1098",
s="1005502"
},new StopModel()
{
Name=" СПИ ПРОФ. ПЕТЪР МУТАФЧИЕВ ",
Kod="1601",
s="1005514"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1435",
s="1005520"
},new StopModel()
{
Name=" Сервиз Изток ",
Kod="1579",
s="1004454"
},new StopModel()
{
Name=" Бл. 11 ж.к. Левски В ",
Kod="131",
s="1004410"
},new StopModel()
{
Name=" Ул. Ст. Доспевски ",
Kod="2181",
s="1022595"
},new StopModel()
{
Name=" Автостанция Изток ",
Kod="2428",
s="1004378"
},}
},}},

new BusModel()
{
Number = "120",
lid = "1000037",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Зоопарка - ж.к. Левски-Г",
rid="1000213",
Stops=new StopModel[]
{new StopModel()
{
Name="Зоопарка",
Kod="749",
s="1016359"
},new StopModel()
{
Name="КП Бенакс ",
Kod="977",
s="1016353"
},new StopModel()
{
Name="Хлебозавода ",
Kod="2314",
s="1016335"
},new StopModel()
{
Name="Кв. Хладилника ",
Kod="909",
s="1013085"
},new StopModel()
{
Name="БУЛ.НИКОЛА Й. ВАПЦАРОВ ",
Kod="344",
s="1017292"
},new StopModel()
{
Name="МБАЛ Токуда болница ",
Kod="206",
s="1017274"
},new StopModel()
{
Name="НПМГ Акад.Любомир Чакалов ",
Kod="1605",
s="1017268"
},new StopModel()
{
Name="УЛ.СТОЯН МИХАЙЛОВСКИ ",
Kod="2692",
s="1022456"
},new StopModel()
{
Name="Телевизионна кула ",
Kod="1733",
s="1019365"
},new StopModel()
{
Name=" Румънско посолство ",
Kod="1489",
s="1001108"
},new StopModel()
{
Name=" Ул.Султан Тепе ",
Kod="2195",
s="1022508"
},new StopModel()
{
Name=" Бул.Мадрид ",
Kod="337",
s="1022522"
},new StopModel()
{
Name=" Ул.Подуенска ",
Kod="2117",
s="1001044"
},new StopModel()
{
Name=" Бул. Владимир Вазов ",
Kod="303",
s="1001034"
},new StopModel()
{
Name=" 143-то ОУ ",
Kod="2396",
s="1015399"
},new StopModel()
{
Name=" Ул.Тодорини кукли ",
Kod="2216",
s="1022552"
},new StopModel()
{
Name=" Стадион Георги Аспарухов ",
Kod="1612",
s="1022558"
},new StopModel()
{
Name=" Ул. Витиня ",
Kod="1869",
s="1022570"
},new StopModel()
{
Name=" Ул.Бесарабия ",
Kod="1840",
s="1022582"
},new StopModel()
{
Name=" Ул.Поп Груйо ",
Kod="2123",
s="1022592"
},new StopModel()
{
Name=" Ул. Ст. Доспевски ",
Kod="2180",
s="1004403"
},new StopModel()
{
Name=" Бл. 11 ж.к. Левски В ",
Kod="130",
s="1004413"
},new StopModel()
{
Name=" Бл. 28 ж.к.Левски-Г ",
Kod="181",
s="1015190"
},new StopModel()
{
Name=" Бл. 10 ж.к. Левски-Г ",
Kod="127",
s="1015178"
},new StopModel()
{
Name=" ж.к. Левски-Г ",
Kod="2430",
s="1015172"
},}
},new DirectionModel()
{
Name ="Ж.к.Левски-Г - Зоопарка",
rid="1001191",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Левски-Г",
Kod="660",
s="1015173"
},new StopModel()
{
Name="Бл. 10 ж.к. Левски-Г ",
Kod="126",
s="1015181"
},new StopModel()
{
Name="Бл. 28 ж.к. Левски-Г ",
Kod="179",
s="1015191"
},new StopModel()
{
Name="Бл. 11 ж.к. Левски В ",
Kod="131",
s="1004410"
},new StopModel()
{
Name="Ул. Ст. Доспевски ",
Kod="2181",
s="1022595"
},new StopModel()
{
Name="Ул.Поп Груйо ",
Kod="2127",
s="1022589"
},new StopModel()
{
Name="Ул.Бесарабия ",
Kod="1842",
s="1022579"
},new StopModel()
{
Name="Ул. Витиня ",
Kod="1871",
s="1022567"
},new StopModel()
{
Name="Стадион Георги Аспарухов ",
Kod="1614",
s="1022557"
},new StopModel()
{
Name=" Ул.Тодорини кукли ",
Kod="2214",
s="1022597"
},new StopModel()
{
Name=" 143-тоОУ ",
Kod="166",
s="1022598"
},new StopModel()
{
Name=" Хипермаркет Била ",
Kod="2108",
s="1001035"
},new StopModel()
{
Name=" Ул.Подуенска ",
Kod="2118",
s="1001045"
},new StopModel()
{
Name=" Бул.Мадрид ",
Kod="338",
s="1022523"
},new StopModel()
{
Name=" Ул.Султан Тепе ",
Kod="2194",
s="1022509"
},new StopModel()
{
Name=" Румънско посолство ",
Kod="1492",
s="1018767"
},new StopModel()
{
Name=" Телевизионна кула ",
Kod="1730",
s="1022475"
},new StopModel()
{
Name=" Ул. Стоян Михайловски ",
Kod="2190",
s="1028854"
},new StopModel()
{
Name=" НПМГ Акад. Любомир Чакалов ",
Kod="1604",
s="1017271"
},new StopModel()
{
Name=" МБАЛ Токуда болница ",
Kod="205",
s="1017279"
},new StopModel()
{
Name=" Бул. Никола Вапцаров ",
Kod="341",
s="1017291"
},new StopModel()
{
Name=" Кв. Хладилника ",
Kod="912",
s="1013084"
},new StopModel()
{
Name=" Хлебозавода ",
Kod="2313",
s="1016336"
},new StopModel()
{
Name=" КП Бенакс ",
Kod="976",
s="1016352"
},new StopModel()
{
Name=" Зоопарка ",
Kod="749",
s="1016359"
},}
},}},

new BusModel()
{
Number = "122",
lid = "1000030",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Автостанция Хладилника - Лифта Симеоново",
rid="1000113",
Stops=new StopModel[]
{new StopModel()
{
Name="Автостанция Хладилника",
Kod="64",
s="1013095"
},new StopModel()
{
Name="Кв. Хладилника ",
Kod="909",
s="1013085"
},new StopModel()
{
Name="Ул. Асен Йорданов ",
Kod="786",
s="1013061"
},new StopModel()
{
Name="Кв.Кръстова вада ",
Kod="919",
s="1013051"
},new StopModel()
{
Name="Околовръстен път ",
Kod="1176",
s="1013039"
},new StopModel()
{
Name="Разклона за кв. Симеоново ",
Kod="1459",
s="1027546"
},new StopModel()
{
Name="Лифта Симеоново ",
Kod="1011",
s="1022388"
},}
},new DirectionModel()
{
Name ="Лифта Симеоново - Автостанция Хладилника",
rid="1001051",
Stops=new StopModel[]
{new StopModel()
{
Name="Лифта Симеоново",
Kod="1011",
s="1022388"
},new StopModel()
{
Name="Разклона за кв. Симеоново ",
Kod="1458",
s="1020607"
},new StopModel()
{
Name="Кв.Кръстова вада ",
Kod="914",
s="1013056"
},new StopModel()
{
Name="Ул. Асен Йорданов ",
Kod="783",
s="1013064"
},new StopModel()
{
Name="Кв. Хладилника ",
Kod="912",
s="1013084"
},new StopModel()
{
Name="Автостанция Хладилника ",
Kod="64",
s="1013095"
},}
},}},

new BusModel()
{
Number = "123",
lid = "1000083",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Лифта Симеоново - СБАЛ по онкология",
rid="1001703",
Stops=new StopModel[]
{new StopModel()
{
Name="Лифта Симеоново",
Kod="1011",
s="1022388"
},new StopModel()
{
Name="Ул.Бистришко шосе ",
Kod="865",
s="1020653"
},new StopModel()
{
Name="Ханчето ",
Kod="2300",
s="1013774"
},new StopModel()
{
Name="НЦ по радиобиология ",
Kod="2353",
s="1013794"
},new StopModel()
{
Name="Ул.9 ",
Kod="1818",
s="1013802"
},new StopModel()
{
Name="Кв.Малинова долина ",
Kod="423",
s="1013812"
},new StopModel()
{
Name="СК на НСА ",
Kod="1608",
s="1013828"
},new StopModel()
{
Name="Ж.к.Дървеница ",
Kod="1015",
s="1013850"
},new StopModel()
{
Name="ЛТУ ",
Kod="614",
s="1009963"
},new StopModel()
{
Name=" Технически университет ",
Kod="1743",
s="1009953"
},new StopModel()
{
Name=" СБАЛ по онкология ",
Kod="2542",
s="1017160"
},}
},new DirectionModel()
{
Name ="СБАЛ по онкология - Лифта Симеоново",
rid="1001703",
Stops=new StopModel[]{

new StopModel()
{
Name="СБАЛ по онкология",
Kod="2434",
s="1017160"
},
new StopModel()
{
Name="МГУ Св.Иван Рилски",
Kod="2434",
s="1017172"
},
new StopModel()
{
Name="Бул.Д-р Г.М.Димитров",
Kod="2434",
s="1018177"
},
new StopModel()
{
Name="Колеж по телекомуникации",
Kod="2434",
s="1018187"
},
new StopModel()
{
Name="Студентска поликлиника",
Kod="2434",
s="1009993"
},
new StopModel()
{
Name="Ж.к.Дървеница",
Kod="2434",
s="1009981"
},
new StopModel()
{
Name="Ж.к.Дървеница",
Kod="2434",
s="1013847"
},
new StopModel()
{
Name="СК на НСА",
Kod="2434",
s="1013827"
},
new StopModel()
{
Name="Кв.Малинова долина",
Kod="2434",
s="1013811"
},
new StopModel()
{
Name="Ул.9",
Kod="2434",
s="1013801"
},
new StopModel()
{
Name="НЦ по радиобиология",
Kod="2434",
s="1013793"
},
new StopModel()
{
Name="Ханчето",
Kod="2434",
s="1013771"
},
new StopModel()
{
Name="Ул.Бистришко шосе",
Kod="2434",
s="1020606"
},
new StopModel()
{
Name="Лифта Симеоново",
Kod="2434",
s="1022388"
},
} 
},}},

new BusModel()
{
Number = "150",
lid = "1000103",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к.Обеля-1 - Плодохранилище",
rid="1001738",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Обеля-1",
Kod="2434",
s="1006296"
},new StopModel()
{
Name="Бл.111 ж.к.Обеля-1 ",
Kod="132",
s="1006480"
},new StopModel()
{
Name="Бл.119 ж.к.Обеля-1 ",
Kod="2443",
s="1026002"
},new StopModel()
{
Name="Метростанция Обеля ",
Kod="6240",
s="1028322"
},new StopModel()
{
Name="Ул.2 ",
Kod="1792",
s="1006502"
},new StopModel()
{
Name="Ул.9 ",
Kod="1817",
s="1006506"
},new StopModel()
{
Name="Бл. 207 ж.к. Обеля 2 ",
Kod="163",
s="1006526"
},new StopModel()
{
Name="Бл. 241 ж.к. Обеля ",
Kod="172",
s="1006550"
},new StopModel()
{
Name="Бл.245 ж.к. Обеля 2 ",
Kod="2676",
s="1006560"
},new StopModel()
{
Name=" ТРД ",
Kod="1771",
s="1019214"
},new StopModel()
{
Name=" Промишлена зона Ломско шосе ",
Kod="1190",
s="1019220"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="2686",
s="1019230"
},new StopModel()
{
Name=" Разклона за Волуяк ",
Kod="1215",
s="1019288"
},new StopModel()
{
Name=" Ул. Дружба ",
Kod="784",
s="1019296"
},new StopModel()
{
Name=" Площада с. Волуяк ",
Kod="1339",
s="1019482"
},new StopModel()
{
Name=" Моста на селска река ",
Kod="1081",
s="1019500"
},new StopModel()
{
Name=" Махала Джулюница ",
Kod="1023",
s="1019512"
},new StopModel()
{
Name=" Ул.Зорница ",
Kod="1221",
s="1019522"
},new StopModel()
{
Name=" По желание ",
Kod="1369",
s="1019530"
},new StopModel()
{
Name=" Гара Волуяк ",
Kod="450",
s="1019542"
},new StopModel()
{
Name=" Плодохранилище ",
Kod="1337",
s="1019558"
},}
},new DirectionModel()
{
Name ="Плодохранилище - Ж.к.Обеля-1",
rid="1001737",
Stops=new StopModel[]
{new StopModel()
{
Name="Плодохранилище",
Kod="1337",
s="1019558"
},new StopModel()
{
Name="Гара Волуяк ",
Kod="449",
s="1019541"
},new StopModel()
{
Name="По желание ",
Kod="1368",
s="1019529"
},new StopModel()
{
Name="Ул. Зорница ",
Kod="1220",
s="1019519"
},new StopModel()
{
Name="Махала Джюлници ",
Kod="1022",
s="1019509"
},new StopModel()
{
Name="Моста на Селска река ",
Kod="1082",
s="1019499"
},new StopModel()
{
Name="Площада с. Волуяк ",
Kod="1340",
s="1019481"
},new StopModel()
{
Name="Ул. Дружба ",
Kod="785",
s="1019295"
},new StopModel()
{
Name="Разклона за Волуяк ",
Kod="1214",
s="1019287"
},new StopModel()
{
Name=" Околовръстен път ",
Kod="2687",
s="1019227"
},new StopModel()
{
Name=" Промишлена зона Ломско шосе ",
Kod="1189",
s="1019217"
},new StopModel()
{
Name=" ТРД ",
Kod="1772",
s="1019213"
},new StopModel()
{
Name=" Бл. 245 ж.к. Обеля 2 ",
Kod="173",
s="1006559"
},new StopModel()
{
Name=" Бл. 241 ж.к. Обеля 2 ",
Kod="171",
s="1006547"
},new StopModel()
{
Name=" Бл. 207 ж.к. Обеля 2 ",
Kod="162",
s="1006525"
},new StopModel()
{
Name=" Ул.9 ",
Kod="1815",
s="1006509"
},new StopModel()
{
Name=" Ул.2 ",
Kod="1793",
s="1006501"
},new StopModel()
{
Name=" Метростанция Обеля ",
Kod="6241",
s="1026043"
},new StopModel()
{
Name=" Бл.119 ж.к.Обеля-1 ",
Kod="2448",
s="1026553"
},new StopModel()
{
Name=" Бл.111 ж.к. Обеля-1 ",
Kod="133",
s="1006479"
},new StopModel()
{
Name=" Ж.к.Обеля-1 ",
Kod="677",
s="1006294"
},}
},}},

new BusModel()
{
Number = "204",
lid = "1000084",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к. Дружба 2 - ж.к.Борово",
rid="1000065",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Дружба 2",
Kod="611",
s="1004228"
},new StopModel()
{
Name="Ул. Димитър Пешев ",
Kod="1930",
s="1004191"
},new StopModel()
{
Name="БЛ. 501 ж.к. Дружба-2 ",
Kod="225",
s="1004181"
},new StopModel()
{
Name="Бл.304ж.к.Дружба-2 ",
Kod="189",
s="1004159"
},new StopModel()
{
Name="Бл.255 ж.к.Дружба 2 ",
Kod="176",
s="1004147"
},new StopModel()
{
Name="Бл.206 ж.к.Дружба-2 ",
Kod="160",
s="1004133"
},new StopModel()
{
Name="Бул.Христофор Колумб ",
Kod="372",
s="1004107"
},new StopModel()
{
Name="Хермес парк ",
Kod="2593",
s="1001978"
},new StopModel()
{
Name="УМБАЛ Св.Анна ",
Kod="1196",
s="1001988"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2327",
s="1003436"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1289",
s="1000695"
},new StopModel()
{
Name=" Ул. Граф Игнатиев ",
Kod="1914",
s="1000357"
},new StopModel()
{
Name=" Бул. Черни връх ",
Kod="401",
s="1000343"
},new StopModel()
{
Name=" ПГ Текстил и моден дизайн ",
Kod="1739",
s="1003894"
},new StopModel()
{
Name=" Бул. Акад.Ив.Е.Гешов ",
Kod="275",
s="1003908"
},new StopModel()
{
Name=" Пл.Ручей ",
Kod="1306",
s="1003924"
},new StopModel()
{
Name=" Бул.България ",
Kod="290",
s="1003944"
},new StopModel()
{
Name=" Бул.Гоце Делчев ",
Kod="2136",
s="1003966"
},new StopModel()
{
Name=" 36-то ОУ ",
Kod="32",
s="1003972"
},new StopModel()
{
Name=" 20-ти ДКЦ ",
Kod="17",
s="1003982"
},new StopModel()
{
Name=" Бл.214 ж.к.Борово ",
Kod="165",
s="1003990"
},new StopModel()
{
Name=" ж.к.Борово ",
Kod="583",
s="1004023"
},}
},new DirectionModel()
{
Name ="ж.к.Борово - Ж.к. Дружба 2",
rid="1000066",
Stops=new StopModel[]
{new StopModel()
{
Name="ж.к.Борово",
Kod="583",
s="1004023"
},new StopModel()
{
Name="Бл.214,ж.к.Борово ",
Kod="164",
s="1003989"
},new StopModel()
{
Name="20-ти ДКЦ ",
Kod="16",
s="1003979"
},new StopModel()
{
Name="36-то ОУ ",
Kod="31",
s="1003969"
},new StopModel()
{
Name="Ул.Проф.Д.Атанасов ",
Kod="2134",
s="1003955"
},new StopModel()
{
Name="Бул.Гоце Делчев ",
Kod="314",
s="1003937"
},new StopModel()
{
Name="Пл.Ручей ",
Kod="1301",
s="1003921"
},new StopModel()
{
Name="Бул.Акад.Ив.Гешов ",
Kod="268",
s="1003901"
},new StopModel()
{
Name="ПГ Текстил и моден дизайн ",
Kod="1736",
s="1003893"
},new StopModel()
{
Name=" Бул. Черни връх ",
Kod="398",
s="1000342"
},new StopModel()
{
Name=" Ул. Граф Игнатиев ",
Kod="1913",
s="1000360"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1287",
s="1003503"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2326",
s="1003435"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="554",
s="1001965"
},new StopModel()
{
Name=" Бул.Христофор Колумб ",
Kod="373",
s="1004108"
},new StopModel()
{
Name=" Бл.206 ж.к.Дружба-2 ",
Kod="159",
s="1004138"
},new StopModel()
{
Name=" Бл. 226 ж.к. Дружба 2 ",
Kod="2417",
s="1004144"
},new StopModel()
{
Name=" Бл. 255 ж.к. Дружба 2 ",
Kod="178",
s="1004152"
},new StopModel()
{
Name=" Бл.304ж.к.Дружба-2 ",
Kod="190",
s="1004162"
},new StopModel()
{
Name=" БЛ. 501 ж.к. Дружба-2 ",
Kod="226",
s="1004184"
},new StopModel()
{
Name=" Ул. Димитър Пешев ",
Kod="1929",
s="1004213"
},new StopModel()
{
Name=" Ж.к. Дружба 2 ",
Kod="612",
s="1004217"
},}
},}},

new BusModel()
{
Number = "213",
lid = "1000085",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="ж.к. Младост 4 - Централна гара",
rid="1001802",
Stops=new StopModel[]
{new StopModel()
{
Name="ж.к. Младост 4",
Kod="670",
s="1018547"
},new StopModel()
{
Name="Бл.480 ж.к.Младост 4 ",
Kod="2394",
s="1020026"
},new StopModel()
{
Name="Бл.472 ж.к.Младост 4 ",
Kod="2392",
s="1020029"
},new StopModel()
{
Name="Бизнеспарк София ",
Kod="2390",
s="1020036"
},new StopModel()
{
Name="Бл.442 ж.к.Младост 4 ",
Kod="2388",
s="1020042"
},new StopModel()
{
Name="115-ти пощенски клон ",
Kod="1759",
s="1003331"
},new StopModel()
{
Name="131-во ОУ ",
Kod="9",
s="1003323"
},new StopModel()
{
Name="Бл. 411 ж.к. Младост 4 ",
Kod="4",
s="1003319"
},new StopModel()
{
Name="Община МЛАДОСТ ",
Kod="944",
s="1003311"
},new StopModel()
{
Name=" 144-то СОУ ",
Kod="2276",
s="1003303"
},new StopModel()
{
Name=" Бл. 56 ж.к. Младост 1 ",
Kod="234",
s="1017085"
},new StopModel()
{
Name=" Бл.43 ж.к.Младост 1 ",
Kod="218",
s="1003285"
},new StopModel()
{
Name=" ХМС ",
Kod="2319",
s="1003279"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="555",
s="1001968"
},new StopModel()
{
Name=" Хермес парк ",
Kod="2593",
s="1001978"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1196",
s="1001988"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2327",
s="1003436"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1290",
s="1000705"
},new StopModel()
{
Name=" Военна академия ",
Kod="440",
s="1000396"
},new StopModel()
{
Name=" Театър София ",
Kod="1725",
s="1002632"
},new StopModel()
{
Name=" Ул.Бяло море ",
Kod="1857",
s="1002778"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1314",
s="1002794"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1275",
s="1002828"
},new StopModel()
{
Name=" Централна гара ",
Kod="1327",
s="1003523"
},}
},new DirectionModel()
{
Name ="Централна гара - ж.к. Младост 4",
rid="1001803",
Stops=new StopModel[]
{new StopModel()
{
Name="Централна гара",
Kod="1327",
s="1003523"
},new StopModel()
{
Name="Ул.Клокотница ",
Kod="1326",
s="1015029"
},new StopModel()
{
Name="Пл.Лъвов мост ",
Kod="1278",
s="1002825"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1316",
s="1002791"
},new StopModel()
{
Name="Ул.Бяло море ",
Kod="1859",
s="1002775"
},new StopModel()
{
Name="Театър София ",
Kod="1724",
s="1001061"
},new StopModel()
{
Name="ВОЕННА АКАДЕМИЯ ",
Kod="442",
s="1000393"
},new StopModel()
{
Name="Пл.Орлов мост ",
Kod="1287",
s="1003503"
},new StopModel()
{
Name="Хотел Плиска ",
Kod="2326",
s="1003435"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name=" ХМС ",
Kod="2318",
s="1003282"
},new StopModel()
{
Name=" Бл.43 ж.к.Младост 1 ",
Kod="217",
s="1003288"
},new StopModel()
{
Name=" Бл. 56 ж.к. Младост 1 ",
Kod="233",
s="1017086"
},new StopModel()
{
Name=" 144-то СОУ ",
Kod="2273",
s="1003306"
},new StopModel()
{
Name=" Община Младост ",
Kod="947",
s="1003314"
},new StopModel()
{
Name=" Бл.411 ж.к.Младост 4 ",
Kod="3",
s="1003322"
},new StopModel()
{
Name=" 131-во ОУ ",
Kod="8",
s="1003326"
},new StopModel()
{
Name=" 115-ти пощенски клон ",
Kod="1760",
s="1003332"
},new StopModel()
{
Name=" Бл.442 ж.к.Младост 4 ",
Kod="2389",
s="1003249"
},new StopModel()
{
Name=" Бизнеспарк София ",
Kod="2391",
s="1003253"
},new StopModel()
{
Name=" бл.472 ж.к. Младост 4 ",
Kod="2393",
s="1003261"
},new StopModel()
{
Name=" бл. 480 ж.к. Младост 4 ",
Kod="2395",
s="1003265"
},new StopModel()
{
Name=" ж.к. Младост 4 ",
Kod="669",
s="1018551"
},}
},}},

new BusModel()
{
Number = "260",
lid = "1000108",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Кв. Горна баня - Бул. Прага",
rid="1000407",
Stops=new StopModel[]
{new StopModel()
{
Name="Кв. Горна баня",
Kod="829",
s="1022815"
},new StopModel()
{
Name="Ул. Мак ",
Kod="2465",
s="1022854"
},new StopModel()
{
Name="53-то ОУ ",
Kod="38",
s="1022850"
},new StopModel()
{
Name="хотел Горна баня ",
Kod="2323",
s="1022865"
},new StopModel()
{
Name="Гара Горна баня ",
Kod="483",
s="1022842"
},new StopModel()
{
Name="Институт по ортопедия ",
Kod="493",
s="1022828"
},new StopModel()
{
Name="Дипломатически клуб ",
Kod="765",
s="1022822"
},new StopModel()
{
Name="Ул. Монтевидео ",
Kod="2050",
s="1020752"
},new StopModel()
{
Name="Бул. Никола Петков ",
Kod="350",
s="1020751"
},new StopModel()
{
Name=" Бул. Цар Борис ІІІ ",
Kod="391",
s="1022754"
},new StopModel()
{
Name=" КВ. ПАВЛОВО ",
Kod="891",
s="1022758"
},new StopModel()
{
Name=" Кв.Овча купел ",
Kod="876",
s="1022772"
},new StopModel()
{
Name=" Ж.к. Красно село ",
Kod="636",
s="1012533"
},new StopModel()
{
Name=" Бул. Цар Борис ІІІ ",
Kod="392",
s="1012205"
},new StopModel()
{
Name=" Пл.Руски паметник ",
Kod="1296",
s="1022636"
},new StopModel()
{
Name=" Бул. Прага ",
Kod="366",
s="1022656"
},}
},new DirectionModel()
{
Name ="Бул. Прага - Кв. Горна баня",
rid="1000408",
Stops=new StopModel[]
{new StopModel()
{
Name="Бул. Прага",
Kod="366",
s="1022656"
},new StopModel()
{
Name="Бул.Цар Борис ІІІ ",
Kod="2543",
s="1022785"
},new StopModel()
{
Name="Ж.к. Красно село ",
Kod="638",
s="1012528"
},new StopModel()
{
Name="Кв.Овча купел ",
Kod="875",
s="1022734"
},new StopModel()
{
Name="Кв. Павлово ",
Kod="888",
s="1022748"
},new StopModel()
{
Name="Бул.Цар Борис ІІІ ",
Kod="388",
s="1020742"
},new StopModel()
{
Name="Бул. Никола Петков ",
Kod="347",
s="1014308"
},new StopModel()
{
Name="Ул. Монтевидео ",
Kod="2049",
s="1014305"
},new StopModel()
{
Name="Институт по ортопедия ",
Kod="766",
s="1022825"
},new StopModel()
{
Name=" Гара Горна баня ",
Kod="480",
s="1022841"
},new StopModel()
{
Name=" Ул.Урал ",
Kod="2224",
s="1022803"
},new StopModel()
{
Name=" Хотел Горна баня ",
Kod="2322",
s="1022807"
},new StopModel()
{
Name=" 53-то ОУ ",
Kod="37",
s="1022851"
},new StopModel()
{
Name=" Ул. Мак ",
Kod="2464",
s="1022855"
},new StopModel()
{
Name=" Кв. Горна баня ",
Kod="829",
s="1022815"
},}
},}},

new BusModel()
{
Number = "280",
lid = "1000058",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Студентски град - СУ Св. Климент Охридски",
rid="1000097",
Stops=new StopModel[]
{new StopModel()
{
Name="Студентски град",
Kod="1693",
s="1010086"
},new StopModel()
{
Name="СК на НСА ",
Kod="1609",
s="1010091"
},new StopModel()
{
Name="Зимен дворец на спорта ",
Kod="742",
s="1010053"
},new StopModel()
{
Name="Детски ясли ",
Kod="534",
s="1010033"
},new StopModel()
{
Name="Спортна зала Христо Ботев ",
Kod="1611",
s="1010021"
},new StopModel()
{
Name="Детски дом ",
Kod="530",
s="1010011"
},new StopModel()
{
Name="Студентска поликлиника ",
Kod="1692",
s="1009993"
},new StopModel()
{
Name="Ж.к.Дървеница ",
Kod="801",
s="1009981"
},new StopModel()
{
Name="ЛТУ ",
Kod="614",
s="1009963"
},new StopModel()
{
Name=" Технически университет ",
Kod="1743",
s="1009953"
},new StopModel()
{
Name=" СБАЛ по онкология ",
Kod="761",
s="1009939"
},new StopModel()
{
Name=" Техническа библиотека ",
Kod="2351",
s="1009925"
},new StopModel()
{
Name=" Републикански диспансер ",
Kod="492",
s="1009911"
},new StopModel()
{
Name=" Площад на авиацията ",
Kod="1258",
s="1002013"
},new StopModel()
{
Name=" Ж.к. Изток ",
Kod="1695",
s="1003420"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2327",
s="1003436"
},new StopModel()
{
Name=" Пл. Орлов мост ",
Kod="1288",
s="1003506"
},new StopModel()
{
Name=" СУ Св. Климент Охридски ",
Kod="1697",
s="1000747"
},}
},new DirectionModel()
{
Name ="СУ Св. Климент Охридски - Студентски град",
rid="1000096",
Stops=new StopModel[]
{new StopModel()
{
Name="СУ Св. Климент Охридски",
Kod="1697",
s="1000747"
},new StopModel()
{
Name="Военна академия ",
Kod="441",
s="1000750"
},new StopModel()
{
Name="Пл.Орлов мост ",
Kod="1287",
s="1003503"
},new StopModel()
{
Name="Хотел Плиска ",
Kod="2326",
s="1003435"
},new StopModel()
{
Name="Ж.к. Изток ",
Kod="1696",
s="1003421"
},new StopModel()
{
Name="Републикански невродиспансер ",
Kod="494",
s="1009914"
},new StopModel()
{
Name="Техническа библиотека ",
Kod="2352",
s="1009928"
},new StopModel()
{
Name="СБАЛ по онкология ",
Kod="764",
s="1009942"
},new StopModel()
{
Name="Технически университет ",
Kod="1740",
s="1009956"
},new StopModel()
{
Name=" ЛТУ ",
Kod="617",
s="1009968"
},new StopModel()
{
Name=" Ж.к.Дървеница ",
Kod="800",
s="1009978"
},new StopModel()
{
Name=" Студентска поликлиника ",
Kod="1691",
s="1009994"
},new StopModel()
{
Name=" Детски дом ",
Kod="524",
s="1010008"
},new StopModel()
{
Name=" Спортна зала Христо Ботев ",
Kod="1610",
s="1010026"
},new StopModel()
{
Name=" Детски ясли ",
Kod="533",
s="1010036"
},new StopModel()
{
Name=" Зимен дворец на спорта ",
Kod="741",
s="1010052"
},new StopModel()
{
Name=" СК на НСА ",
Kod="1606",
s="1010092"
},new StopModel()
{
Name=" Студентски град ",
Kod="1694",
s="1010081"
},}
},}},

new BusModel()
{
Number = "285",
lid = "1000201",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к. Връбница 2 - Ж.к.Стефан Караджа",
rid="1001671",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Връбница 2",
Kod="594",
s="1016590"
},new StopModel()
{
Name="Бл. 603 ж.к. Връбница 2 ",
Kod="239",
s="1016638"
},new StopModel()
{
Name="Бул. Ломско шосе ",
Kod="333",
s="1016975"
},new StopModel()
{
Name="Ул.Христо Силянов ",
Kod="2658",
s="1028593"
},new StopModel()
{
Name="Ул. Царевец - временна ",
Kod="6217",
s="1016161"
},new StopModel()
{
Name="8-ми ДКЦ ",
Kod="43",
s="1016165"
},new StopModel()
{
Name="Ул.Хан Кубрат ",
Kod="2231",
s="1006402"
},new StopModel()
{
Name="Ул.Константин Бодин ",
Kod="2005",
s="1006408"
},new StopModel()
{
Name="Ул.Възрожденска ",
Kod="1885",
s="1006426"
},new StopModel()
{
Name=" Метростанция Хан Кубрат ",
Kod="2661",
s="1006436"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2079",
s="1006608"
},new StopModel()
{
Name=" Пл. Централна гара ",
Kod="1328",
s="1015026"
},new StopModel()
{
Name=" Бул.Христо Ботев ",
Kod="385",
s="1002839"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1278",
s="1002825"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1315",
s="1016700"
},new StopModel()
{
Name=" СОФИЯ МЕЛ АД ",
Kod="701",
s="1016722"
},new StopModel()
{
Name=" Ул.Видини кули ",
Kod="1868",
s="1016740"
},new StopModel()
{
Name=" Ул.В.Петлешков ",
Kod="1864",
s="1016746"
},new StopModel()
{
Name=" Ул. Макгахан ",
Kod="2040",
s="1016758"
},new StopModel()
{
Name=" Ул.Златица ",
Kod="1946",
s="1016784"
},new StopModel()
{
Name=" УЛ.АНГЕЛ ВОЙВОДА ",
Kod="1825",
s="1020595"
},new StopModel()
{
Name=" Ул. Теофил Ганев ",
Kod="2204",
s="1016793"
},new StopModel()
{
Name=" Ж.к.Стефан Караджа ",
Kod="691",
s="1016810"
},}
},new DirectionModel()
{
Name ="Ж.к.Стефан Караджа - Ж.к. Връбница 2",
rid="1001672",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Стефан Караджа",
Kod="691",
s="1016810"
},new StopModel()
{
Name="Ул.Гинци ",
Kod="1910",
s="1016815"
},new StopModel()
{
Name="Ул. Проф. Иван Шишманов ",
Kod="2147",
s="1016821"
},new StopModel()
{
Name="Ул. Златица ",
Kod="1947",
s="1016779"
},new StopModel()
{
Name="Ул.Макгахан ",
Kod="2042",
s="1016751"
},new StopModel()
{
Name="Ул.Уошбърн ",
Kod="2223",
s="1016737"
},new StopModel()
{
Name="СОФИЯ МЕЛ АД ",
Kod="698",
s="1016719"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1311",
s="1002810"
},new StopModel()
{
Name="Пл.Лъвов мост ",
Kod="1275",
s="1002828"
},new StopModel()
{
Name=" Централна гара ",
Kod="1327",
s="1003523"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2080",
s="1006471"
},new StopModel()
{
Name=" Надлез Надежда ",
Kod="1114",
s="1006463"
},new StopModel()
{
Name=" Метростанция Хан Кубрат ",
Kod="2662",
s="1006435"
},new StopModel()
{
Name=" Ул.Република-временна ",
Kod="6218",
s="1006429"
},new StopModel()
{
Name=" Ул.Възрожденска ",
Kod="1884",
s="1006425"
},new StopModel()
{
Name=" Ул.Константин Бодин ",
Kod="2004",
s="1006405"
},new StopModel()
{
Name=" Ул. Хан Кубрат ",
Kod="2232",
s="1006345"
},new StopModel()
{
Name=" 8-ми ДКЦ ",
Kod="44",
s="1006339"
},new StopModel()
{
Name=" Ул.Христо Силянов ",
Kod="331",
s="1006333"
},new StopModel()
{
Name=" Бул. Ломско шосе ",
Kod="334",
s="1016970"
},new StopModel()
{
Name=" Бл. 603 ж.к. Връбница 2 ",
Kod="240",
s="1016643"
},new StopModel()
{
Name=" Ж.к. Връбница 2 ",
Kod="594",
s="1016590"
},}
},}},

new BusModel()
{
Number = "294",
lid = "1000167",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Студентски град - Площад на авиацията",
rid="1001755",
Stops=new StopModel[]
{new StopModel()
{
Name="Студентски град",
Kod="1693",
s="1010086"
},new StopModel()
{
Name="СК на НСА ",
Kod="1609",
s="1010091"
},new StopModel()
{
Name="Зимен дворец на спорта ",
Kod="742",
s="1010053"
},new StopModel()
{
Name="Детски ясли ",
Kod="534",
s="1010033"
},new StopModel()
{
Name="Спортна зала Христо Ботев ",
Kod="1611",
s="1010021"
},new StopModel()
{
Name="Детски дом ",
Kod="530",
s="1010011"
},new StopModel()
{
Name="Студентска поликлиника ",
Kod="1692",
s="1009993"
},new StopModel()
{
Name="Ж.к.Дървеница ",
Kod="801",
s="1009981"
},new StopModel()
{
Name="ЛТУ ",
Kod="614",
s="1009963"
},new StopModel()
{
Name=" Технически университет ",
Kod="1743",
s="1009953"
},new StopModel()
{
Name=" СБАЛ по онкология ",
Kod="761",
s="1009939"
},new StopModel()
{
Name=" Техническа библиотека ",
Kod="2351",
s="1009925"
},new StopModel()
{
Name=" Републикански диспансер ",
Kod="492",
s="1009911"
},new StopModel()
{
Name=" Площад на авиацията ",
Kod="1258",
s="1002013"
},}
},new DirectionModel()
{
Name ="Площад на авиацията - Студентски град",
rid="1001754",
Stops=new StopModel[]
{new StopModel()
{
Name="Площад на авиацията",
Kod="1258",
s="1002013"
},new StopModel()
{
Name="Републикански невродиспансер ",
Kod="494",
s="1009914"
},new StopModel()
{
Name="Техническа библиотека ",
Kod="2352",
s="1009928"
},new StopModel()
{
Name="СБАЛ по онкология ",
Kod="764",
s="1009942"
},new StopModel()
{
Name="Технически университет ",
Kod="1740",
s="1009956"
},new StopModel()
{
Name="ЛТУ ",
Kod="617",
s="1009968"
},new StopModel()
{
Name="Ж.к.Дървеница ",
Kod="800",
s="1009978"
},new StopModel()
{
Name="Студентска поликлиника ",
Kod="1691",
s="1009994"
},new StopModel()
{
Name="Детски дом ",
Kod="524",
s="1010008"
},new StopModel()
{
Name=" Спортна зала Христо Ботев ",
Kod="1610",
s="1010026"
},new StopModel()
{
Name=" Детски ясли ",
Kod="533",
s="1010036"
},new StopModel()
{
Name=" Зимен дворец на спорта ",
Kod="741",
s="1010052"
},new StopModel()
{
Name=" СК на НСА ",
Kod="1606",
s="1010092"
},new StopModel()
{
Name=" Студентски град ",
Kod="1694",
s="1010081"
},}
},}},

new BusModel()
{
Number = "305",
lid = "1000087",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Централна гара - КУЛИНАРЕН К-Т ПЕЙФИЛ",
rid="1001813",
Stops=new StopModel[]
{new StopModel()
{
Name="Централна гара",
Kod="1327",
s="1003523"
},new StopModel()
{
Name="Ул.Клокотница ",
Kod="1326",
s="1015029"
},new StopModel()
{
Name="Пл.Лъвов мост ",
Kod="1278",
s="1002825"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1316",
s="1002791"
},new StopModel()
{
Name="Ул.Бяло море ",
Kod="1859",
s="1002775"
},new StopModel()
{
Name="Гара Подуене ",
Kod="468",
s="1000441"
},new StopModel()
{
Name="Ул.Оборище ",
Kod="2071",
s="1000773"
},new StopModel()
{
Name="Ул.Калиманци ",
Kod="1975",
s="1000791"
},new StopModel()
{
Name="Румънско посолство ",
Kod="1492",
s="1018767"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2326",
s="1003435"
},new StopModel()
{
Name=" Площад на авиацията ",
Kod="1257",
s="1002063"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name=" ХМС ",
Kod="2318",
s="1003282"
},new StopModel()
{
Name=" Бл.43 ж.к.Младост 1 ",
Kod="217",
s="1003288"
},new StopModel()
{
Name=" Бл. 56 ж.к. Младост 1 ",
Kod="233",
s="1017086"
},new StopModel()
{
Name=" Бл. 223 ж.к. Младост 2 ",
Kod="169",
s="1009062"
},new StopModel()
{
Name=" Бл. 222 ж.к. Младост 2 ",
Kod="167",
s="1009068"
},new StopModel()
{
Name=" Ул.д-р Атанас Москов ",
Kod="1918",
s="1009082"
},new StopModel()
{
Name=" бл.327 ж.к. Младост-3 ",
Kod="193",
s="1009094"
},new StopModel()
{
Name=" Община Младост ",
Kod="947",
s="1003314"
},new StopModel()
{
Name=" Бл.411 ж.к.Младост-4 ",
Kod="5",
s="1009178"
},new StopModel()
{
Name=" БЛ. 351Б ж.к.Младост-3 ",
Kod="201",
s="1009144"
},new StopModel()
{
Name=" Ж.К.МЛАДОСТ-3 ",
Kod="665",
s="1009154"
},new StopModel()
{
Name=" СОФИЙСКА ВОДА ",
Kod="1603",
s="1009164"
},new StopModel()
{
Name=" КУЛИНАРЕН К-Т ПЕЙФИЛ ",
Kod="991",
s="1009176"
},}
},new DirectionModel()
{
Name ="КУЛИНАРЕН К-Т ПЕЙФИЛ - Централна гара",
rid="1001812",
Stops=new StopModel[]
{new StopModel()
{
Name="КУЛИНАРЕН К-Т ПЕЙФИЛ",
Kod="990",
s="1009182"
},new StopModel()
{
Name="СОФИЙСКА ВОДА ",
Kod="1602",
s="1009167"
},new StopModel()
{
Name="Ж.К.МЛАДОСТ-3 ",
Kod="666",
s="1009153"
},new StopModel()
{
Name="БЛ. 351Б ж.к.Младост-3 ",
Kod="202",
s="1009141"
},new StopModel()
{
Name="Бл. 411 ж.к. Младост 4 ",
Kod="4",
s="1003319"
},new StopModel()
{
Name="Община Младост ",
Kod="946",
s="1009101"
},new StopModel()
{
Name="бл.327 ж.к. Младост-3 ",
Kod="194",
s="1009091"
},new StopModel()
{
Name="Ул. Д-р Ат. Москов ",
Kod="1917",
s="1009077"
},new StopModel()
{
Name="Бл. 222 ж.к. Младост 2 ",
Kod="168",
s="1009067"
},new StopModel()
{
Name=" Бл. 56 ж.к. Младост 1 ",
Kod="234",
s="1017085"
},new StopModel()
{
Name=" Бл.43 ж.к.Младост 1 ",
Kod="218",
s="1003285"
},new StopModel()
{
Name=" ХМС ",
Kod="2319",
s="1003279"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="555",
s="1001968"
},new StopModel()
{
Name=" Хермес парк ",
Kod="2593",
s="1001978"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1196",
s="1001988"
},new StopModel()
{
Name=" Площад на авиацията ",
Kod="1258",
s="1002013"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2327",
s="1003436"
},new StopModel()
{
Name=" Румънско посолство ",
Kod="1489",
s="1001108"
},new StopModel()
{
Name=" Ул.Калиманци ",
Kod="1972",
s="1000790"
},new StopModel()
{
Name=" УЛ.ОБОРИЩЕ ",
Kod="2070",
s="1000432"
},new StopModel()
{
Name=" Гара Подуяне ",
Kod="467",
s="1018783"
},new StopModel()
{
Name=" Ул.Бяло море ",
Kod="1857",
s="1002778"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1314",
s="1002794"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1275",
s="1002828"
},new StopModel()
{
Name=" Централна гара ",
Kod="1327",
s="1003523"
},}
},}},

new BusModel()
{
Number = "306",
lid = "1000088",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="СУ Св. Климент Охридски - Ж.к.Младост-2",
rid="1001783",
Stops=new StopModel[]
{new StopModel()
{
Name="СУ Св. Климент Охридски",
Kod="1697",
s="1000747"
},new StopModel()
{
Name="Военна академия ",
Kod="441",
s="1000750"
},new StopModel()
{
Name="Пл.Орлов мост ",
Kod="1287",
s="1003503"
},new StopModel()
{
Name="Хотел Плиска ",
Kod="2326",
s="1003435"
},new StopModel()
{
Name="УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name="Бл.6 ж.к.Младост-1 ",
Kod="238",
s="1027955"
},new StopModel()
{
Name="Бл.41 ж.к.Младост-1 ",
Kod="210",
s="1027951"
},new StopModel()
{
Name="Ул.Йерусалим ",
Kod="2471",
s="1018842"
},new StopModel()
{
Name="Онкологичен диспансер ",
Kod="23",
s="1018852"
},new StopModel()
{
Name=" Посолствата ",
Kod="1400",
s="1018860"
},new StopModel()
{
Name=" Ж.к.Младост-1 ",
Kod="2463",
s="1025732"
},new StopModel()
{
Name=" 102-ро ОУ ",
Kod="2678",
s="1022876"
},new StopModel()
{
Name=" Ж.к.Младост-2 ",
Kod="664",
s="1028810"
},}
},new DirectionModel()
{
Name ="Ж.к.Младост-2 - СУ Св. Климент Охридски",
rid="1001784",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Младост-2",
Kod="664",
s="1028810"
},new StopModel()
{
Name="Бл.245 ж.к.Младост-2 ",
Kod="2677",
s="1028685"
},new StopModel()
{
Name="Ж.к.Младост-1 ",
Kod="661",
s="1018869"
},new StopModel()
{
Name="Посолствата ",
Kod="1401",
s="1018859"
},new StopModel()
{
Name="Онкологичен диспансер ",
Kod="22",
s="1027323"
},new StopModel()
{
Name="Ул. Йерусалим ",
Kod="447",
s="1027965"
},new StopModel()
{
Name="Бл.41 ж.к.Младост-1 ",
Kod="209",
s="1027961"
},new StopModel()
{
Name="Бл.6 ж.к.Младост-1 ",
Kod="237",
s="1027958"
},new StopModel()
{
Name="МБАЛ Св. Ана ",
Kod="1192",
s="1016399"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2327",
s="1003436"
},new StopModel()
{
Name=" Пл. Орлов мост ",
Kod="1288",
s="1003506"
},new StopModel()
{
Name=" СУ Св. Климент Охридски ",
Kod="1697",
s="1000747"
},}
},}},

new BusModel()
{
Number = "309",
lid = "1000059",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к.Люлин-1,2 - Бул.Илиянци-подлеза",
rid="1001734",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к.Люлин-1,2",
Kod="650",
s="1003597"
},new StopModel()
{
Name="Бл.11 ж.к.Люлин-1 ",
Kod="1388",
s="1010565"
},new StopModel()
{
Name="ПП Успех ",
Kod="1751",
s="1010583"
},new StopModel()
{
Name="НЕСТЛЕ София ",
Kod="1140",
s="1010595"
},new StopModel()
{
Name="МЕТРОСТАНЦИЯ СЛИВНИЦА ",
Kod="1060",
s="1003635"
},new StopModel()
{
Name="ТРИЪГЪЛНИКА-ЛЮЛИН ",
Kod="1783",
s="1003641"
},new StopModel()
{
Name="Читалище св.св. Кирил и Методий ",
Kod="512",
s="1003647"
},new StopModel()
{
Name="ул. Луи Пастьор ",
Kod="2167",
s="1003655"
},new StopModel()
{
Name="Ул.Орион ",
Kod="2093",
s="1003667"
},new StopModel()
{
Name=" Западен парк ",
Kod="1251",
s="1003675"
},new StopModel()
{
Name=" Ул.Оряхово ",
Kod="2097",
s="1003691"
},new StopModel()
{
Name=" Бул. К. Величков ",
Kod="328",
s="1003705"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2087",
s="1002851"
},new StopModel()
{
Name=" Бул.Христо Ботев ",
Kod="385",
s="1002839"
},new StopModel()
{
Name=" Ул. Княз Борис І ",
Kod="1998",
s="1002833"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1321",
s="1002809"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1312",
s="1015264"
},new StopModel()
{
Name=" Хладилен завод ",
Kod="2309",
s="1015282"
},new StopModel()
{
Name=" Централен гробищен парк ",
Kod="1945",
s="1015294"
},new StopModel()
{
Name=" Ул.202 ",
Kod="65",
s="1015316"
},new StopModel()
{
Name=" ТЕЦ София ",
Kod="1747",
s="1015320"
},new StopModel()
{
Name=" Котлостроене АД ",
Kod="718",
s="1015328"
},new StopModel()
{
Name=" Бул.Илиянци-подлеза ",
Kod="1385",
s="1015339"
},}
},new DirectionModel()
{
Name ="Бул.Илиянци-подлеза - Ж.к.Люлин-1,2",
rid="1001735",
Stops=new StopModel[]
{new StopModel()
{
Name="Бул.Илиянци-подлеза",
Kod="1385",
s="1015339"
},new StopModel()
{
Name="Котлостроене АД ",
Kod="717",
s="1015327"
},new StopModel()
{
Name="ТЕЦ София ",
Kod="1748",
s="1015319"
},new StopModel()
{
Name="Ул.202 ",
Kod="66",
s="1015311"
},new StopModel()
{
Name="Централен гробищен парк ",
Kod="1944",
s="1015291"
},new StopModel()
{
Name="Хладилен завод ",
Kod="2312",
s="1015281"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1318",
s="1015263"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1311",
s="1002810"
},new StopModel()
{
Name="Ул. Княз Борис І ",
Kod="1999",
s="1002834"
},new StopModel()
{
Name=" Бул. Христо Ботев ",
Kod="382",
s="1002844"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2082",
s="1002858"
},new StopModel()
{
Name=" Бул. К. Величков ",
Kod="325",
s="1002888"
},new StopModel()
{
Name=" Ул.Оряхово ",
Kod="2096",
s="1003688"
},new StopModel()
{
Name=" Западен парк ",
Kod="1253",
s="1003674"
},new StopModel()
{
Name=" УЛ.ОРИОН ",
Kod="2091",
s="1003662"
},new StopModel()
{
Name=" ул. Луи Пастьор ",
Kod="2166",
s="1003652"
},new StopModel()
{
Name=" Читалище св.св. Кирил и Методий ",
Kod="511",
s="1003648"
},new StopModel()
{
Name=" ТРИЪГЪЛНИКА-ЛЮЛИН ",
Kod="1781",
s="1003638"
},new StopModel()
{
Name=" Метростанция Сливница ",
Kod="1059",
s="1010598"
},new StopModel()
{
Name=" Нестле София ",
Kod="1141",
s="1010590"
},new StopModel()
{
Name=" ПП Успех ",
Kod="1752",
s="1010580"
},new StopModel()
{
Name=" Мосю Бриколаж ",
Kod="2385",
s="1010568"
},new StopModel()
{
Name=" Ж.к.Люлин-1,2 ",
Kod="649",
s="1003596"
},}
},}},

new BusModel()
{
Number = "310",
lid = "1000060",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="ж.к. Люлин -5 - Пл.Сточна гара",
rid="1000190",
Stops=new StopModel[]
{new StopModel()
{
Name="ж.к. Люлин -5",
Kod="657",
s="1016048"
},new StopModel()
{
Name="Ул.Поручик Задгорски ",
Kod="2132",
s="1018737"
},new StopModel()
{
Name="Ул.Кап.В.Данаджиев ",
Kod="1981",
s="1018719"
},new StopModel()
{
Name="Магазин Витоша ",
Kod="1704",
s="1018709"
},new StopModel()
{
Name="Бл. 620, Люлин-6 ",
Kod="242",
s="1018691"
},new StopModel()
{
Name="Бл. 630, Люлин-6 ",
Kod="243",
s="1018685"
},new StopModel()
{
Name="Ул.Индира Ганди ",
Kod="1960",
s="1018669"
},new StopModel()
{
Name="Бл.703, Люлин-7 ",
Kod="1108",
s="1018659"
},new StopModel()
{
Name="Бул. Царица Йоана ",
Kod="2418",
s="1018641"
},new StopModel()
{
Name=" ул. Гоце Делчев ",
Kod="1911",
s="1018635"
},new StopModel()
{
Name=" бл. 135 ж.к. Люлин 10 ",
Kod="136",
s="1018627"
},new StopModel()
{
Name=" Ул.Орион ",
Kod="2093",
s="1003667"
},new StopModel()
{
Name=" Западен парк ",
Kod="1251",
s="1003675"
},new StopModel()
{
Name=" Ул.Оряхово ",
Kod="2097",
s="1003691"
},new StopModel()
{
Name=" Бул. К. Величков ",
Kod="328",
s="1003705"
},new StopModel()
{
Name=" Ул. Опълченска ",
Kod="2087",
s="1002851"
},new StopModel()
{
Name=" Бул.Христо Ботев ",
Kod="385",
s="1002839"
},new StopModel()
{
Name=" Ул. Княз Борис І ",
Kod="1998",
s="1002833"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1321",
s="1002809"
},}
},new DirectionModel()
{
Name ="Пл.Сточна гара - ж.к. Люлин -5",
rid="1000191",
Stops=new StopModel[]
{new StopModel()
{
Name="Пл.Сточна гара",
Kod="1311",
s="1002810"
},new StopModel()
{
Name="Ул. Княз Борис І ",
Kod="1999",
s="1002834"
},new StopModel()
{
Name="Бул. Христо Ботев ",
Kod="382",
s="1002844"
},new StopModel()
{
Name="Ул. Опълченска ",
Kod="2082",
s="1002858"
},new StopModel()
{
Name="Бул. К. Величков ",
Kod="325",
s="1002888"
},new StopModel()
{
Name="Ул.Оряхово ",
Kod="2096",
s="1003688"
},new StopModel()
{
Name="Западен парк ",
Kod="1253",
s="1003674"
},new StopModel()
{
Name="Ул. Орион ",
Kod="2092",
s="1018622"
},new StopModel()
{
Name="Бл.135 ж.к. Люлин 10 ",
Kod="138",
s="1018628"
},new StopModel()
{
Name=" ул. Гоце Делчев ",
Kod="1912",
s="1018638"
},new StopModel()
{
Name=" Бул. Царица Йоана ",
Kod="2419",
s="1018644"
},new StopModel()
{
Name=" Бл.703, Люлин-7 ",
Kod="1107",
s="1018662"
},new StopModel()
{
Name=" Ул.Индира Ганди ",
Kod="1961",
s="1018670"
},new StopModel()
{
Name=" Бл. 630, Люлин-6 ",
Kod="244",
s="1018686"
},new StopModel()
{
Name=" Бл. 620, Люлин-6 ",
Kod="241",
s="1018696"
},new StopModel()
{
Name=" Бул. Д-р Петър Дертлиев ",
Kod="2610",
s="1018706"
},new StopModel()
{
Name=" Магазин Витоша ",
Kod="1705",
s="1018716"
},new StopModel()
{
Name=" Ул.Капитан В.Данаджиев ",
Kod="1982",
s="1018722"
},new StopModel()
{
Name=" Ул.Поручик Гр.Загорски ",
Kod="2133",
s="1018740"
},new StopModel()
{
Name=" ж.к. Люлин -5 ",
Kod="657",
s="1016046"
},}
},}},

new BusModel()
{
Number = "314",
lid = "1000200",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к. София парк - Пазара Младост 1",
rid="1001779",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. София парк",
Kod="2653",
s="1028334"
},new StopModel()
{
Name="Ул. Рачо Петров казанджията ",
Kod="2651",
s="1028336"
},new StopModel()
{
Name="Местност Камбаните ",
Kod="2649",
s="1028340"
},new StopModel()
{
Name="Бизнес парк София ",
Kod="2491",
s="1027754"
},new StopModel()
{
Name="Бл. 437 ж.к. Младост 4 ",
Kod="219",
s="1014818"
},new StopModel()
{
Name="Бл.325 ж.к.Младост 3 ",
Kod="2489",
s="1027614"
},new StopModel()
{
Name="Бл.323 ж.к.Младост 3 ",
Kod="2487",
s="1027725"
},new StopModel()
{
Name="Бл.205 ж.к.Младост-2 ",
Kod="157",
s="1022871"
},new StopModel()
{
Name="Бл.206 ж.к. Младост-2 ",
Kod="158",
s="1022873"
},new StopModel()
{
Name=" Ж.к.Младост-2 ",
Kod="663",
s="1022875"
},new StopModel()
{
Name=" Бл.245 ж.к.Младост-2 ",
Kod="2677",
s="1028685"
},new StopModel()
{
Name=" Ж.к.Младост-1 ",
Kod="661",
s="1018869"
},new StopModel()
{
Name=" Посолствата ",
Kod="1401",
s="1018859"
},new StopModel()
{
Name=" 27-ма поликлиника ",
Kod="22",
s="1018845"
},new StopModel()
{
Name=" Пазара Младост 1 ",
Kod="968",
s="1018835"
},}
},new DirectionModel()
{
Name ="Пазара Младост 1 - Ж.к. София парк",
rid="1001795",
Stops=new StopModel[]
{new StopModel()
{
Name="Пазара Младост 1",
Kod="968",
s="1018835"
},new StopModel()
{
Name="Бл. 66 ж.к. Младост 1 ",
Kod="245",
s="1018825"
},new StopModel()
{
Name="Бл. 56 ж.к. Младост 1 ",
Kod="233",
s="1017086"
},new StopModel()
{
Name="Бл.69 ж.к.Младост 1 ",
Kod="247",
s="1017098"
},new StopModel()
{
Name="102-ро ОУ ",
Kod="2678",
s="1022876"
},new StopModel()
{
Name="Бл.206 ж.к.Младост-2 ",
Kod="161",
s="1022874"
},new StopModel()
{
Name="Ул.д-р Атанас Москов ",
Kod="1919",
s="1014776"
},new StopModel()
{
Name="Бл.202 ж.к.Младост 2 ",
Kod="154",
s="1014786"
},new StopModel()
{
Name="МВР Академия ",
Kod="2374",
s="1014808"
},new StopModel()
{
Name=" Бизнес парк София ",
Kod="2490",
s="1027727"
},new StopModel()
{
Name=" Кино Арена 2 ",
Kod="2648",
s="1027732"
},new StopModel()
{
Name=" Ул. Рачо Петков казанджията ",
Kod="2650",
s="1028797"
},new StopModel()
{
Name=" Ж.к. София парк ",
Kod="2652",
s="1028353"
},}
},}},

new BusModel()
{
Number = "384",
lid = "1000182",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Ж.к. Младост 1 (бл. 70) - Летище София Терминал 2",
rid="1001682",
Stops=new StopModel[]
{new StopModel()
{
Name="Ж.к. Младост 1 ",
Kod="бл. 70",
s="1028052"
},new StopModel()
{
Name="Ул. Йерусалим ",
Kod="447",
s="1027965"
},new StopModel()
{
Name="Бл.41 ж.к.Младост-1 ",
Kod="209",
s="1027961"
},new StopModel()
{
Name="Бл.6 ж.к.Младост-1 ",
Kod="237",
s="1027958"
},new StopModel()
{
Name="Държавна печатница ",
Kod="554",
s="1001965"
},new StopModel()
{
Name="Бл.3 ж.к.Дружба 1 ",
Kod="182",
s="1012043"
},new StopModel()
{
Name="Бл.128 ж.к. Дружба 1 ",
Kod="128",
s="1012049"
},new StopModel()
{
Name="Разклона за летището ",
Kod="1452",
s="1016465"
},new StopModel()
{
Name="Технотест ",
Kod="91",
s="1026678"
},new StopModel()
{
Name=" Нова телевизия ",
Kod="2473",
s="1026682"
},new StopModel()
{
Name=" Р-т Александрия ",
Kod="1462",
s="1016507"
},new StopModel()
{
Name=" Летище София Терминал 1 ",
Kod="1006",
s="1016452"
},new StopModel()
{
Name=" Р-т Александрия ",
Kod="2451",
s="1026638"
},new StopModel()
{
Name=" РВД ",
Kod="2452",
s="1026650"
},new StopModel()
{
Name=" Летище София Терминал 2 ",
Kod="2454",
s="1026631"
},}
},new DirectionModel()
{
Name ="Летище София Терминал 2 - Ж.к. Младост 1 (бл. 70)",
rid="1001683",
Stops=new StopModel[]
{new StopModel()
{
Name="Летище София Терминал 2",
Kod="2455",
s="1026632"
},new StopModel()
{
Name="РВД ",
Kod="2453",
s="1026649"
},new StopModel()
{
Name="Р-т Александрия ",
Kod="1463",
s="1016502"
},new StopModel()
{
Name="Нова телевизия ",
Kod="2474",
s="1026708"
},new StopModel()
{
Name="Технотест ",
Kod="90",
s="1016478"
},new StopModel()
{
Name="Разклона за летището ",
Kod="1455",
s="1012058"
},new StopModel()
{
Name="Бл.108 ж.к.Дружба 1 ",
Kod="129",
s="1012046"
},new StopModel()
{
Name="Бл.3 ж.к.Дружба 1 ",
Kod="184",
s="1012040"
},new StopModel()
{
Name="Държавна печатница ",
Kod="553",
s="1016396"
},new StopModel()
{
Name=" Бл.6 ж.к.Младост-1 ",
Kod="238",
s="1027955"
},new StopModel()
{
Name=" Бл.41 ж.к.Младост-1 ",
Kod="210",
s="1027951"
},new StopModel()
{
Name=" Ул.Йерусалим ",
Kod="2471",
s="1018842"
},new StopModel()
{
Name=" Ж.к. Младост 1 ",
Kod="бл. 70)",
s="1028052"
},}
},}},

new BusModel()
{
Number = "404",
lid = "1000100",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="АП Дружба - Централна гара",
rid="1000674",
Stops=new StopModel[]
{new StopModel()
{
Name="АП Дружба",
Kod="77",
s="1019151"
},new StopModel()
{
Name="БЛ. 501 ж.к. Дружба-2 ",
Kod="226",
s="1004184"
},new StopModel()
{
Name="Хипермаркет Практикер ",
Kod="2408",
s="1019128"
},new StopModel()
{
Name="Бл.405 ж.к.Дружба 2 ",
Kod="1487",
s="1019118"
},new StopModel()
{
Name="163-то ОУ ",
Kod="14",
s="1019106"
},new StopModel()
{
Name="Ул.Обиколна ",
Kod="2069",
s="1019088"
},new StopModel()
{
Name="Бл.255 ж.к.Дружба 2 ",
Kod="176",
s="1004147"
},new StopModel()
{
Name="Бл. 155ж.к. Дружба 1 ",
Kod="141",
s="1012120"
},new StopModel()
{
Name="Бл. 59 ж.к. Дружба 1 ",
Kod="236",
s="1019039"
},new StopModel()
{
Name=" Бул.Брюксел ",
Kod="2432",
s="1027238"
},new StopModel()
{
Name=" Ул.кап.Д.Списаревски ",
Kod="1985",
s="1027242"
},new StopModel()
{
Name=" Автобаза Орбита-турс ",
Kod="177",
s="1027245"
},new StopModel()
{
Name=" Бул. Проф. Цв. Лазаров ",
Kod="2647",
s="1028327"
},new StopModel()
{
Name=" ВТУ Т.Каблешков ",
Kod="2013",
s="1000904"
},new StopModel()
{
Name=" бл.15 ж.к.Хр.Смирненски ",
Kod="140",
s="1014736"
},new StopModel()
{
Name=" бл. 7 ж.к. Хр. Смирненски ",
Kod="250",
s="1014726"
},new StopModel()
{
Name=" бл.33 ж.к. Слатина ",
Kod="105",
s="1014708"
},new StopModel()
{
Name=" УЛ.БОЯН МАГЕСНИК ",
Kod="1847",
s="1001171"
},new StopModel()
{
Name=" УЛ.ВЕЛЧО АТАНАСОВ ",
Kod="1866",
s="1000461"
},new StopModel()
{
Name=" Гара Подуене ",
Kod="471",
s="1001275"
},new StopModel()
{
Name=" Театър София ",
Kod="1725",
s="1002632"
},new StopModel()
{
Name=" Ул.Бяло море ",
Kod="1857",
s="1002778"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1314",
s="1002794"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1311",
s="1002810"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1275",
s="1002828"
},new StopModel()
{
Name=" Централна гара ",
Kod="1327",
s="1003523"
},}
},new DirectionModel()
{
Name ="Централна гара - АП Дружба",
rid="1000675",
Stops=new StopModel[]
{new StopModel()
{
Name="Централна гара",
Kod="1327",
s="1003523"
},new StopModel()
{
Name="Ул.Клокотница ",
Kod="1326",
s="1015029"
},new StopModel()
{
Name="Бул.Христо Ботев ",
Kod="385",
s="1002839"
},new StopModel()
{
Name="Пл.Лъвов мост ",
Kod="1278",
s="1002825"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1316",
s="1002791"
},new StopModel()
{
Name="Ул.Бяло море ",
Kod="1859",
s="1002775"
},new StopModel()
{
Name="Театър София ",
Kod="1728",
s="1001056"
},new StopModel()
{
Name="Гара Подуяне ",
Kod="466",
s="1000448"
},new StopModel()
{
Name="УЛ.ВЕЛЧО АТАНАСОВ ",
Kod="1867",
s="1001166"
},new StopModel()
{
Name=" УЛ.БОЯН МАГЕСНИК ",
Kod="1846",
s="1001172"
},new StopModel()
{
Name=" ул.Иван Щерев ",
Kod="1955",
s="1014703"
},new StopModel()
{
Name=" бл. 33 ж.к. Слатина ",
Kod="109",
s="1014711"
},new StopModel()
{
Name=" бл. 7 ж.к. Хр. Смирненски ",
Kod="249",
s="1014731"
},new StopModel()
{
Name=" бл.15 ж.к. Хр. Смирненски ",
Kod="139",
s="1014739"
},new StopModel()
{
Name=" ВТУ Т.Каблешков ",
Kod="2014",
s="1000905"
},new StopModel()
{
Name=" Бул.проф.Цв.Лазаров ",
Kod="369",
s="1027257"
},new StopModel()
{
Name=" Ул.кап.Д.Списаревски ",
Kod="1984",
s="1027263"
},new StopModel()
{
Name=" Бул.Брюксел ",
Kod="2433",
s="1027268"
},new StopModel()
{
Name=" Бл. 59 ж.к. Дружба 1 ",
Kod="235",
s="1019034"
},new StopModel()
{
Name=" Бл. 155 ж.к. Дружба 1 ",
Kod="142",
s="1012119"
},new StopModel()
{
Name=" Бл. 226 ж.к. Дружба 2 ",
Kod="2417",
s="1004144"
},new StopModel()
{
Name=" Бл. 255 ж.к. Дружба 2 ",
Kod="178",
s="1004152"
},new StopModel()
{
Name=" Ул. Обиколна ",
Kod="2066",
s="1019091"
},new StopModel()
{
Name=" 163-то ОУ ",
Kod="15",
s="1019103"
},new StopModel()
{
Name=" Бл. 405 ж.к. Дружба 2 ",
Kod="1488",
s="1019121"
},new StopModel()
{
Name=" Хипермаркет Практикер ",
Kod="2409",
s="1019129"
},new StopModel()
{
Name=" БЛ. 501 ж.к. Дружба-2 ",
Kod="225",
s="1004181"
},new StopModel()
{
Name=" АП Дружба ",
Kod="78",
s="1019144"
},}
},}},

new BusModel()
{
Number = "413",
lid = "1000090",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="Технополис ж.к.Младост - Централна гара",
rid="1001786",
Stops=new StopModel[]
{new StopModel()
{
Name="Технополис ж.к.Младост",
Kod="2495",
s="1027744"
},new StopModel()
{
Name="Кино Арена ",
Kod="2493",
s="1027747"
},new StopModel()
{
Name="Бизнес парк София ",
Kod="2491",
s="1027754"
},new StopModel()
{
Name="Бл. 437 ж.к. Младост 4 ",
Kod="219",
s="1014818"
},new StopModel()
{
Name="Бл.325 ж.к.Младост 3 ",
Kod="2489",
s="1027614"
},new StopModel()
{
Name="Бл.323 ж.к.Младост 3 ",
Kod="2487",
s="1027725"
},new StopModel()
{
Name="Бл.205 ж.к.Младост-2 ",
Kod="157",
s="1022871"
},new StopModel()
{
Name="Бл.206 ж.к. Младост-2 ",
Kod="158",
s="1022873"
},new StopModel()
{
Name="Ж.к.Младост-2 ",
Kod="663",
s="1022875"
},new StopModel()
{
Name=" Бл.245 ж.к.Младост-2 ",
Kod="2677",
s="1028685"
},new StopModel()
{
Name=" Естакада ж.к.Младост-2 ",
Kod="6544",
s="1017102"
},new StopModel()
{
Name=" Бл. 49 ж.к. Дървеница ",
Kod="1588",
s="1017112"
},new StopModel()
{
Name=" Ж.к.Дървеница ",
Kod="800",
s="1009978"
},new StopModel()
{
Name=" Студентска поликлиника ",
Kod="1691",
s="1009994"
},new StopModel()
{
Name=" Колеж по телекомуникации ",
Kod="1397",
s="1018186"
},new StopModel()
{
Name=" Бул.Д-р Г.М.Димитров ",
Kod="316",
s="1017177"
},new StopModel()
{
Name=" МГУ Св.Ив.Рилски ",
Kod="1032",
s="1017169"
},new StopModel()
{
Name=" Метростанция Д-р Г. М. Димитров ",
Kod="2679",
s="1017159"
},new StopModel()
{
Name=" Ж.к.Дианабад ",
Kod="627",
s="1019419"
},new StopModel()
{
Name=" СТЦ Интерпред ",
Kod="1112",
s="1019403"
},new StopModel()
{
Name=" Руско посолство ",
Kod="1493",
s="1019383"
},new StopModel()
{
Name=" Телевизионна кула ",
Kod="1733",
s="1019365"
},new StopModel()
{
Name=" Румънско посолство ",
Kod="1489",
s="1001108"
},new StopModel()
{
Name=" УЛ.ОБОРИЩЕ ",
Kod="2070",
s="1000432"
},new StopModel()
{
Name=" Гара Подуяне ",
Kod="467",
s="1018783"
},new StopModel()
{
Name=" Ул.Бяло море ",
Kod="1857",
s="1002778"
},new StopModel()
{
Name=" Пл.Сточна гара ",
Kod="1314",
s="1002794"
},new StopModel()
{
Name=" Пл.Лъвов мост ",
Kod="1275",
s="1002828"
},new StopModel()
{
Name=" Централна гара ",
Kod="1327",
s="1003523"
},}
},new DirectionModel()
{
Name ="Централна гара - Технополис ж.к.Младост",
rid="1001797",
Stops=new StopModel[]
{new StopModel()
{
Name="Централна гара",
Kod="1327",
s="1003523"
},new StopModel()
{
Name="Ул.Клокотница ",
Kod="1326",
s="1015029"
},new StopModel()
{
Name="Пл.Лъвов мост ",
Kod="1278",
s="1002825"
},new StopModel()
{
Name="Пл.Сточна гара ",
Kod="1316",
s="1002791"
},new StopModel()
{
Name="Ул.Бяло море ",
Kod="1859",
s="1002775"
},new StopModel()
{
Name="Гара Подуене ",
Kod="468",
s="1000441"
},new StopModel()
{
Name="Ул.Оборище ",
Kod="2071",
s="1000773"
},new StopModel()
{
Name="Румънско посолство ",
Kod="1492",
s="1018767"
},new StopModel()
{
Name="Телевизионна кула ",
Kod="1729",
s="1019372"
},new StopModel()
{
Name=" Руско посолство ",
Kod="1496",
s="1019384"
},new StopModel()
{
Name=" СТЦ Интерпред ",
Kod="1109",
s="1019404"
},new StopModel()
{
Name=" Ж.к.Дианабад ",
Kod="630",
s="1019422"
},new StopModel()
{
Name=" СБАЛ по онкология ",
Kod="2542",
s="1017160"
},new StopModel()
{
Name=" МГУ Св.Иван Рилски ",
Kod="1033",
s="1017172"
},new StopModel()
{
Name=" Бул.Д-р Г.М.Димитров ",
Kod="318",
s="1018177"
},new StopModel()
{
Name=" Колеж по телекомуникации ",
Kod="1396",
s="1018187"
},new StopModel()
{
Name=" Студентска поликлиника ",
Kod="1692",
s="1009993"
},new StopModel()
{
Name=" Ж.к.Дървеница ",
Kod="801",
s="1009981"
},new StopModel()
{
Name=" Ж.к.Дървеница ",
Kod="1012",
s="1013847"
},new StopModel()
{
Name=" Бл. 49 ж.к. Дървеница ",
Kod="1589",
s="1017109"
},new StopModel()
{
Name=" Естакада ж.к.Младост-2 ",
Kod="6545",
s="1028695"
},new StopModel()
{
Name=" 102-ро ОУ ",
Kod="2678",
s="1022876"
},new StopModel()
{
Name=" Бл.206 ж.к.Младост-2 ",
Kod="161",
s="1022874"
},new StopModel()
{
Name=" Ул.д-р Атанас Москов ",
Kod="1919",
s="1014776"
},new StopModel()
{
Name=" Бл.202 ж.к.Младост 2 ",
Kod="154",
s="1014786"
},new StopModel()
{
Name=" МВР Академия ",
Kod="2374",
s="1014808"
},new StopModel()
{
Name=" Бизнес парк София ",
Kod="2490",
s="1027727"
},new StopModel()
{
Name=" Кино Арена 2 ",
Kod="2492",
s="1027736"
},new StopModel()
{
Name=" Технополис ж.к.Младост ",
Kod="2494",
s="1027738"
},}
},}},

new BusModel()
{
Number = "604",
lid = "1000091",
Directions= new DirectionModel[]
{
new DirectionModel()
{
Name ="МБАЛСМ Пирогов - Гара Искър",
rid="1001761",
Stops=new StopModel[]
{new StopModel()
{
Name="МБАЛСМ Пирогов",
Kod="760",
s="1027827"
},new StopModel()
{
Name="МБАЛ Александровска ",
Kod="1035",
s="1000285"
},new StopModel()
{
Name="ВМА ",
Kod="418",
s="1000277"
},new StopModel()
{
Name="Център по Хигиена ",
Kod="2343",
s="1012185"
},new StopModel()
{
Name="Бул.Акад.Ив.Гешов ",
Kod="268",
s="1003901"
},new StopModel()
{
Name="ПГ Текстил и моден дизайн ",
Kod="1736",
s="1003893"
},new StopModel()
{
Name="Бул. Черни връх ",
Kod="398",
s="1000342"
},new StopModel()
{
Name="Ул. Граф Игнатиев ",
Kod="1913",
s="1000360"
},new StopModel()
{
Name="Пл.Орлов мост ",
Kod="1287",
s="1003503"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2326",
s="1003435"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1194",
s="1001987"
},new StopModel()
{
Name=" Държавна печатница ",
Kod="554",
s="1001965"
},new StopModel()
{
Name=" Бл.3 ж.к.Дружба 1 ",
Kod="182",
s="1012043"
},new StopModel()
{
Name=" Бл.128 ж.к. Дружба 1 ",
Kod="128",
s="1012049"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1451",
s="1012063"
},new StopModel()
{
Name=" Ж.к.Дружба 1 ",
Kod="604",
s="1012071"
},new StopModel()
{
Name=" Бул.Кръстьо Пастухов ",
Kod="1632",
s="1017056"
},new StopModel()
{
Name=" 28-ми ДКЦ ",
Kod="24",
s="1012160"
},new StopModel()
{
Name=" Ул. Илия Бешков ",
Kod="1958",
s="1012154"
},new StopModel()
{
Name=" Бл. 162 ж.к. Дружба 1 ",
Kod="144",
s="1028386"
},new StopModel()
{
Name=" Бл. 170 ж.к. Дружба 1 ",
Kod="146",
s="1028382"
},new StopModel()
{
Name=" Депо Искър ",
Kod="516",
s="1028379"
},new StopModel()
{
Name=" Депо Искър ",
Kod="515",
s="1014255"
},new StopModel()
{
Name=" София мед АД ",
Kod="974",
s="1014263"
},new StopModel()
{
Name=" Кв. Гара Искър ",
Kod="33",
s="1014275"
},new StopModel()
{
Name=" Гара Искър ",
Kod="825",
s="1014279"
},}
},new DirectionModel()
{
Name ="Гара Искър - МБАЛСМ Пирогов",
rid="1001762",
Stops=new StopModel[]
{new StopModel()
{
Name="Гара Искър",
Kod="825",
s="1014279"
},new StopModel()
{
Name="Кв. ГараИскър ",
Kod="34",
s="1014274"
},new StopModel()
{
Name="София мед АД ",
Kod="975",
s="1014260"
},new StopModel()
{
Name="Депо Искър ",
Kod="520",
s="1014256"
},new StopModel()
{
Name="ДепоИскър ",
Kod="517",
s="1028376"
},new StopModel()
{
Name="Бл. 170 ж.к. Дружба 1 ",
Kod="147",
s="1028372"
},new StopModel()
{
Name="Бл. 162 ж.к. Дружба 1 ",
Kod="145",
s="1012143"
},new StopModel()
{
Name="Ул. Илия Бешков ",
Kod="1959",
s="1012155"
},new StopModel()
{
Name="28-ми ДКЦ ",
Kod="25",
s="1017051"
},new StopModel()
{
Name=" Бул. Кръстьо Пастухов ",
Kod="1629",
s="1012078"
},new StopModel()
{
Name=" Ж.к.Дружба 1 ",
Kod="608",
s="1012068"
},new StopModel()
{
Name=" Разклона за летището ",
Kod="1455",
s="1012058"
},new StopModel()
{
Name=" Бл.108 ж.к.Дружба 1 ",
Kod="129",
s="1012046"
},new StopModel()
{
Name=" Бл.3 ж.к.Дружба 1 ",
Kod="184",
s="1012040"
},new StopModel()
{
Name=" Хермес парк ",
Kod="2593",
s="1001978"
},new StopModel()
{
Name=" УМБАЛ Св.Анна ",
Kod="1196",
s="1001988"
},new StopModel()
{
Name=" Хотел Плиска ",
Kod="2327",
s="1003436"
},new StopModel()
{
Name=" Пл.Орлов мост ",
Kod="1289",
s="1000695"
},new StopModel()
{
Name=" Ул. Граф Игнатиев ",
Kod="1914",
s="1000357"
},new StopModel()
{
Name=" Бул.Черни връх ",
Kod="395",
s="1000339"
},new StopModel()
{
Name=" ПГ Текстил и моден дизайн ",
Kod="1739",
s="1003894"
},new StopModel()
{
Name=" Бул.Акад.Иван Гешов ",
Kod="269",
s="1012173"
},new StopModel()
{
Name=" Център по Хигиена ",
Kod="2342",
s="1012177"
},new StopModel()
{
Name=" БУЛ.ЦАР БОРИС ІІІ ",
Kod="394",
s="1027825"
},new StopModel()
{
Name=" МБАЛСМ Пирогов ",
Kod="760",
s="1027827"
},}
},}},
            };
            return buses;
        }
    }
}