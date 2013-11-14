using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SofiaTransport.Models;

namespace SofiaTransport.ViewModels
{
    class TrolleysViewModel
    {
        private static ObservableCollection<BusModel> trolleys;

        public static IEnumerable<BusModel> Trolleys
        {
            get
            {
                if (trolleys == null)
                {
                    Trolleys = GetGeneratedTrolleys();
                }
                return trolleys;
            }
            set
            {
                if (trolleys != value)
                {
                    if (trolleys == null)
                    {
                        trolleys = new ObservableCollection<BusModel>();
                    }
                    trolleys.Clear();
                    foreach (var item in value)
                    {
                        trolleys.Add(item);
                    }
                }
            }
        }

        public static IEnumerable<BusModel> GetTrolleys()
        {
            return Trolleys;
        }
        public TrolleysViewModel()
        {
        }

        private static IEnumerable<BusModel> GetGeneratedTrolleys()
        {
            BusModel[] trolleys =
            {
                            new BusModel()
            {
            Number = "1",
            lid = "2000010",
            Directions= new DirectionModel[]
            {
            new DirectionModel()
            {
            Name ="ж.к. Левски-Г - Пета градска болница",
            rid="2000011",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="ж.к. Левски-Г",
            Kod="646",
            s="2000783"
            },new StopModel()
            {
            Name="бл. 28 ж.к. Левски -Г ",
            Kod="180",
            s="2000787"
            },new StopModel()
            {
            Name="бл. 10 ж.к. Левски-Г ",
            Kod="127",
            s="2000791"
            },new StopModel()
            {
            Name="ул. Поп Грую ",
            Kod="2124",
            s="2002168"
            },new StopModel()
            {
            Name="ул. Витиня ",
            Kod="1754",
            s="2000809"
            },new StopModel()
            {
            Name="Стадион Г.Аспарухов ",
            Kod="1613",
            s="2000845"
            },new StopModel()
            {
            Name="Ул.Васил Кънчев ",
            Kod="1862",
            s="2000833"
            },new StopModel()
            {
            Name="Хипермаркет Била ",
            Kod="2108",
            s="2000595"
            },new StopModel()
            {
            Name="Мостът Чавдар ",
            Kod="1103",
            s="2002167"
            },new StopModel()
            {
            Name=" Ул. Бяло море ",
            Kod="1856",
            s="2000502"
            },new StopModel()
            {
            Name=" Ул.Кракра ",
            Kod="2012",
            s="2000535"
            },new StopModel()
            {
            Name=" СУ Св. Климент Охридски ",
            Kod="1698",
            s="2000469"
            },new StopModel()
            {
            Name=" Ул. Ген. Гурко ",
            Kod="1902",
            s="2000444"
            },new StopModel()
            {
            Name=" Кино Одеон ",
            Kod="926",
            s="2000874"
            },new StopModel()
            {
            Name=" НДК ",
            Kod="1136",
            s="2000880"
            },new StopModel()
            {
            Name=" Бул.Прага ",
            Kod="362",
            s="2002164"
            },new StopModel()
            {
            Name=" Пл.Руски паметник ",
            Kod="1297",
            s="2000899"
            },new StopModel()
            {
            Name=" Пл.Руски паметник ",
            Kod="1300",
            s="2000922"
            },new StopModel()
            {
            Name=" Бул.Александър Стамболийски ",
            Kod="284",
            s="2000993"
            },new StopModel()
            {
            Name=" Ул.Пиротска ",
            Kod="2114",
            s="2002161"
            },new StopModel()
            {
            Name=" Ул.Св.Св.Кирил и Методий ",
            Kod="2170",
            s="2001005"
            },new StopModel()
            {
            Name=" Ул.Охрид ",
            Kod="2102",
            s="2001143"
            },new StopModel()
            {
            Name=" Бул.Ген.Николай Столетов ",
            Kod="339",
            s="2001167"
            },new StopModel()
            {
            Name=" Пета градска болница ",
            Kod="2596",
            s="2001165"
            },}
            },new DirectionModel()
            {
            Name ="Пета градска болница - ж.к. Левски-Г",
            rid="2000010",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Пета градска болница",
            Kod="1256",
            s="2002159"
            },new StopModel()
            {
            Name="Бул.Княгиня Мария Луиза ",
            Kod="324",
            s="2001141"
            },new StopModel()
            {
            Name="Ул.Охрид ",
            Kod="2105",
            s="2001137"
            },new StopModel()
            {
            Name="Ул.Св.Св.Кирил и Методий ",
            Kod="2171",
            s="2001004"
            },new StopModel()
            {
            Name="Ул.Пиротска ",
            Kod="2111",
            s="2002160"
            },new StopModel()
            {
            Name="Бул.Ал.Стамболийски ",
            Kod="283",
            s="2000992"
            },new StopModel()
            {
            Name="Пл.Руски паметник ",
            Kod="1295",
            s="2000921"
            },new StopModel()
            {
            Name="Пл.Руски паметник ",
            Kod="1296",
            s="2000898"
            },new StopModel()
            {
            Name="Бул. Прага ",
            Kod="363",
            s="2000416"
            },new StopModel()
            {
            Name=" ул. 6-ти септември ",
            Kod="1806",
            s="2000430"
            },new StopModel()
            {
            Name=" Кино Одеон ",
            Kod="927",
            s="2000441"
            },new StopModel()
            {
            Name=" Ул. Ген. Гурко ",
            Kod="1903",
            s="2000445"
            },new StopModel()
            {
            Name=" СУ Св.Климент Охридски ",
            Kod="1699",
            s="2000470"
            },new StopModel()
            {
            Name=" Паметника Левски ",
            Kod="1241",
            s="2002166"
            },new StopModel()
            {
            Name=" Ул. Бяло море ",
            Kod="1858",
            s="2000503"
            },new StopModel()
            {
            Name=" Мостът Чавдар ",
            Kod="1102",
            s="2000567"
            },new StopModel()
            {
            Name=" Бул. Владимир Вазов ",
            Kod="303",
            s="2000592"
            },new StopModel()
            {
            Name=" Хипермаркет Била ",
            Kod="2107",
            s="2000822"
            },new StopModel()
            {
            Name=" Ул.Васил Кънчев ",
            Kod="1863",
            s="2000838"
            },new StopModel()
            {
            Name=" Стадион Г.Аспарухов ",
            Kod="1615",
            s="2000846"
            },new StopModel()
            {
            Name=" Ул.Витиня ",
            Kod="1753",
            s="2000812"
            },new StopModel()
            {
            Name=" ж.к. Левски -В ",
            Kod="2125",
            s="2000820"
            },new StopModel()
            {
            Name=" ул. Поп Груйо ",
            Kod="2128",
            s="2000777"
            },new StopModel()
            {
            Name=" ул. Ст. Доспевски ",
            Kod="2182",
            s="2000779"
            },new StopModel()
            {
            Name=" ж.к. Левски-Г ",
            Kod="646",
            s="2000783"
            },}
            },}},
                            new BusModel()
            {
            Number = "2",
            lid = "2000009",
            Directions= new DirectionModel[]
            {
            new DirectionModel()
            {
            Name ="Ж.К. Хаджи Димитър - Ж.к.Бъкстон",
            rid="2000012",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Ж.К. Хаджи Димитър",
            Kod="692",
            s="2000662"
            },new StopModel()
            {
            Name="Ул. Уошбърн ",
            Kod="2222",
            s="2000721"
            },new StopModel()
            {
            Name="Ул. Панайот Хитов ",
            Kod="2106",
            s="2002170"
            },new StopModel()
            {
            Name="Ул. Макгахан ",
            Kod="2041",
            s="2000741"
            },new StopModel()
            {
            Name="Мостът Чавдар ",
            Kod="1103",
            s="2002167"
            },new StopModel()
            {
            Name="Ул. Бяло море ",
            Kod="1856",
            s="2000502"
            },new StopModel()
            {
            Name="Ул.Кракра ",
            Kod="2012",
            s="2000535"
            },new StopModel()
            {
            Name="СУ Св. Климент Охридски ",
            Kod="1698",
            s="2000469"
            },new StopModel()
            {
            Name="Ул. Ген. Гурко ",
            Kod="1902",
            s="2000444"
            },new StopModel()
            {
            Name=" Кино Одеон ",
            Kod="926",
            s="2000874"
            },new StopModel()
            {
            Name=" НДК ",
            Kod="1136",
            s="2000880"
            },new StopModel()
            {
            Name=" Бул. Прага ",
            Kod="366",
            s="2000405"
            },new StopModel()
            {
            Name=" Бул. Пенчо Славейков ",
            Kod="355",
            s="2000399"
            },new StopModel()
            {
            Name=" МБАЛ Александровска ",
            Kod="1035",
            s="2000373"
            },new StopModel()
            {
            Name=" ВМА ",
            Kod="418",
            s="2000367"
            },new StopModel()
            {
            Name=" Център по Хигиена ",
            Kod="2343",
            s="2002175"
            },new StopModel()
            {
            Name=" Пл.Ручей ",
            Kod="1302",
            s="2000311"
            },new StopModel()
            {
            Name=" Ул.Дойран ",
            Kod="1936",
            s="2000266"
            },new StopModel()
            {
            Name=" Бул.Гоце Делчев ",
            Kod="2136",
            s="2000260"
            },new StopModel()
            {
            Name=" 36-то ОУ ",
            Kod="32",
            s="2000256"
            },new StopModel()
            {
            Name=" 20-ти ДКЦ ",
            Kod="17",
            s="2000250"
            },new StopModel()
            {
            Name=" Бл.214 ж.к.Борово ",
            Kod="165",
            s="2000242"
            },new StopModel()
            {
            Name=" Ул.Тодор Каблешков ",
            Kod="2208",
            s="2000209"
            },new StopModel()
            {
            Name=" Ул.Вихрен ",
            Kod="1878",
            s="2000186"
            },new StopModel()
            {
            Name=" Параклис Св. Ив. Рилски ",
            Kod="1246",
            s="2000182"
            },new StopModel()
            {
            Name=" Ж.к.Бъкстон ",
            Kod="588",
            s="2000178"
            },}
            },new DirectionModel()
            {
            Name ="Ж.к.Бъкстон - Ж.К. Хаджи Димитър",
            rid="2000013",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Ж.к.Бъкстон",
            Kod="587",
            s="2000179"
            },new StopModel()
            {
            Name="Параклис Св.Ив.Рилски ",
            Kod="1245",
            s="2000183"
            },new StopModel()
            {
            Name="Ул.Вихрен ",
            Kod="1875",
            s="2000202"
            },new StopModel()
            {
            Name="Ул.Тодор Каблешков ",
            Kod="2210",
            s="2000215"
            },new StopModel()
            {
            Name="Бл.214,ж.к.Борово-временна ",
            Kod="164",
            s="2002305"
            },new StopModel()
            {
            Name="20-ти ДКЦ ",
            Kod="16",
            s="2000253"
            },new StopModel()
            {
            Name="36-то ОУ ",
            Kod="31",
            s="2000259"
            },new StopModel()
            {
            Name="Бул.Гоце Делчев ",
            Kod="311",
            s="2000263"
            },new StopModel()
            {
            Name="Ул.Дойран ",
            Kod="1935",
            s="2000287"
            },new StopModel()
            {
            Name=" Пл.Ручей ",
            Kod="1303",
            s="2000312"
            },new StopModel()
            {
            Name=" Център по Хигиена ",
            Kod="2342",
            s="2000342"
            },new StopModel()
            {
            Name=" ВМА ",
            Kod="419",
            s="2002174"
            },new StopModel()
            {
            Name=" МБАЛ Александровска ",
            Kod="1034",
            s="2000376"
            },new StopModel()
            {
            Name=" Бул. Пенчо Славейков ",
            Kod="358",
            s="2000400"
            },new StopModel()
            {
            Name=" Бул. Прага ",
            Kod="363",
            s="2000416"
            },new StopModel()
            {
            Name=" ул. 6-ти септември ",
            Kod="1806",
            s="2000430"
            },new StopModel()
            {
            Name=" Кино Одеон ",
            Kod="927",
            s="2000441"
            },new StopModel()
            {
            Name=" Ул. Ген. Гурко ",
            Kod="1903",
            s="2000445"
            },new StopModel()
            {
            Name=" СУ Св.Климент Охридски ",
            Kod="1699",
            s="2000470"
            },new StopModel()
            {
            Name=" Паметника Левски ",
            Kod="1241",
            s="2002166"
            },new StopModel()
            {
            Name=" Ул. Бяло море ",
            Kod="1858",
            s="2000503"
            },new StopModel()
            {
            Name=" Мостът Чавдар ",
            Kod="1102",
            s="2000567"
            },new StopModel()
            {
            Name=" Бул. Владимир Вазов ",
            Kod="303",
            s="2000592"
            },new StopModel()
            {
            Name=" Ул. Острово ",
            Kod="2100",
            s="2000613"
            },new StopModel()
            {
            Name=" Ул. Макгахан ",
            Kod="2040",
            s="2000638"
            },new StopModel()
            {
            Name=" Ж.К. Хаджи Димитър ",
            Kod="692",
            s="2000660"
            },}
            },}},
                        new BusModel()
            {
            Number = "4",
            lid = "2000001",
            Directions= new DirectionModel[]
            {
            new DirectionModel()
            {
            Name ="Ж.К. Хаджи Димитър - Ж.к. Дружба 2",
            rid="2000002",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Ж.К. Хаджи Димитър",
            Kod="692",
            s="2000662"
            },new StopModel()
            {
            Name="Ул. Уошбърн ",
            Kod="2222",
            s="2000721"
            },new StopModel()
            {
            Name="Ул. Панайот Хитов ",
            Kod="2106",
            s="2002170"
            },new StopModel()
            {
            Name="Ул. Макгахан ",
            Kod="2041",
            s="2000741"
            },new StopModel()
            {
            Name="Мостът Чавдар ",
            Kod="1103",
            s="2002167"
            },new StopModel()
            {
            Name="Ул. Бяло море ",
            Kod="1856",
            s="2000502"
            },new StopModel()
            {
            Name="Ул.Кракра ",
            Kod="2012",
            s="2000535"
            },new StopModel()
            {
            Name="СУ Св. Климент Охридски ",
            Kod="1698",
            s="2000469"
            },new StopModel()
            {
            Name="Пл.Орлов мост ",
            Kod="1287",
            s="2001765"
            },new StopModel()
            {
            Name=" Полиграфически комбинат ",
            Kod="1394",
            s="2001771"
            },new StopModel()
            {
            Name=" Бул.Пейо Яворов ",
            Kod="74",
            s="2002177"
            },new StopModel()
            {
            Name=" Ул.Ал.Жендов ",
            Kod="1820",
            s="2001999"
            },new StopModel()
            {
            Name=" Хотел Плиска ",
            Kod="2326",
            s="2002179"
            },new StopModel()
            {
            Name=" Ж.к. Изток ",
            Kod="1696",
            s="2001992"
            },new StopModel()
            {
            Name=" Площад на авиацията ",
            Kod="1257",
            s="2001929"
            },new StopModel()
            {
            Name=" Площад на авиацията ",
            Kod="1260",
            s="2001687"
            },new StopModel()
            {
            Name=" Спортна зала Арена Армеец ",
            Kod="2615",
            s="2001688"
            },new StopModel()
            {
            Name=" СК ЦСКА ",
            Kod="1152",
            s="2002026"
            },new StopModel()
            {
            Name=" Бул.проф.Цв.Лазаров ",
            Kod="369",
            s="2001801"
            },new StopModel()
            {
            Name=" Ул.кап.Д.Списаревски ",
            Kod="1984",
            s="2001807"
            },new StopModel()
            {
            Name=" Бул.Брюксел ",
            Kod="2433",
            s="2001811"
            },new StopModel()
            {
            Name=" Бул.Христофор Колумб ",
            Kod="373",
            s="2001813"
            },new StopModel()
            {
            Name=" Бл.206 ж.к.Дружба-2 ",
            Kod="159",
            s="2002068"
            },new StopModel()
            {
            Name=" Бл. 226 ж.к. Дружба 2 ",
            Kod="2417",
            s="2002071"
            },new StopModel()
            {
            Name=" Бл. 255 ж.к. Дружба 2 ",
            Kod="178",
            s="2002307"
            },new StopModel()
            {
            Name=" Ул. Обиколна ",
            Kod="2066",
            s="2001907"
            },new StopModel()
            {
            Name=" 163-то ОУ ",
            Kod="15",
            s="2002241"
            },new StopModel()
            {
            Name=" Бл. 405 ж.к. Дружба 2 ",
            Kod="1488",
            s="2001915"
            },new StopModel()
            {
            Name=" Хипермаркет Практикер ",
            Kod="2409",
            s="2002129"
            },new StopModel()
            {
            Name=" Ул. Димитър Пешев ",
            Kod="1929",
            s="2002257"
            },new StopModel()
            {
            Name=" Ж.к. Дружба 2 ",
            Kod="612",
            s="2001921"
            },}
            },new DirectionModel()
            {
            Name ="Ж.к. Дружба 2 - Ж.К. Хаджи Димитър",
            rid="2000003",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Ж.к. Дружба 2",
            Kod="611",
            s="2001920"
            },new StopModel()
            {
            Name="Ул. Димитър Пешев ",
            Kod="1930",
            s="2002256"
            },new StopModel()
            {
            Name="Хипермаркет Практикер ",
            Kod="2408",
            s="2002314"
            },new StopModel()
            {
            Name="Бл.405 ж.к.Дружба 2 ",
            Kod="1487",
            s="2002127"
            },new StopModel()
            {
            Name="163-то ОУ ",
            Kod="14",
            s="2002242"
            },new StopModel()
            {
            Name="Ул.Обиколна ",
            Kod="2069",
            s="2001906"
            },new StopModel()
            {
            Name="Бл.255 ж.к.Дружба 2 ",
            Kod="176",
            s="2001820"
            },new StopModel()
            {
            Name="Бл.206 ж.к.Дружба-2 ",
            Kod="160",
            s="2002063"
            },new StopModel()
            {
            Name="Бул.Христофор Колумб ",
            Kod="372",
            s="2001812"
            },new StopModel()
            {
            Name=" Бул.Брюксел ",
            Kod="2432",
            s="2001810"
            },new StopModel()
            {
            Name=" Ул.кап.Д.Списаревски ",
            Kod="1985",
            s="2001804"
            },new StopModel()
            {
            Name=" Автобаза Орбита-турс ",
            Kod="177",
            s="2002315"
            },new StopModel()
            {
            Name=" Бул.проф.Цв.Лазаров ",
            Kod="371",
            s="2002180"
            },new StopModel()
            {
            Name=" СК ЦСКА ",
            Kod="1151",
            s="2002020"
            },new StopModel()
            {
            Name=" Спортна зала Арена Армеец ",
            Kod="2616",
            s="2002019"
            },new StopModel()
            {
            Name=" Ж.к. Изток ",
            Kod="1695",
            s="2001990"
            },new StopModel()
            {
            Name=" Хотел Плиска ",
            Kod="2327",
            s="2001995"
            },new StopModel()
            {
            Name=" УЛ.АЛ.ЖЕНДОВ ",
            Kod="1819",
            s="2002178"
            },new StopModel()
            {
            Name=" бул. Пейо Яворов ",
            Kod="73",
            s="2002002"
            },new StopModel()
            {
            Name=" Полиграфически комбинат ",
            Kod="1395",
            s="2001770"
            },new StopModel()
            {
            Name=" Пл. Орлов мост ",
            Kod="1288",
            s="2001764"
            },new StopModel()
            {
            Name=" СУ Св.Климент Охридски ",
            Kod="1699",
            s="2000470"
            },new StopModel()
            {
            Name=" Паметника Левски ",
            Kod="1241",
            s="2002166"
            },new StopModel()
            {
            Name=" Ул. Бяло море ",
            Kod="1858",
            s="2000503"
            },new StopModel()
            {
            Name=" Мостът Чавдар ",
            Kod="1102",
            s="2000567"
            },new StopModel()
            {
            Name=" Бул. Владимир Вазов ",
            Kod="303",
            s="2000592"
            },new StopModel()
            {
            Name=" Ул. Острово ",
            Kod="2100",
            s="2000613"
            },new StopModel()
            {
            Name=" Ул. Макгахан ",
            Kod="2040",
            s="2000638"
            },new StopModel()
            {
            Name=" Ж.К. Хаджи Димитър ",
            Kod="692",
            s="2000660"
            },}
            },}},
                        new BusModel()
            {
            Number = "5",
            lid = "2000003",
            Directions= new DirectionModel[]
            {
            new DirectionModel()
            {
            Name ="Ж.к.Младост-1 - Надлез Надежда",
            rid="2000499",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Ж.к.Младост-1",
            Kod="661",
            s="2001884"
            },new StopModel()
            {
            Name="Посолствата ",
            Kod="1401",
            s="2001880"
            },new StopModel()
            {
            Name="Онкологичен диспансер ",
            Kod="22",
            s="2001872"
            },new StopModel()
            {
            Name="Ул. Йерусалим ",
            Kod="447",
            s="2001866"
            },new StopModel()
            {
            Name="Бл.41 ж.к.Младост-1 ",
            Kod="209",
            s="2001862"
            },new StopModel()
            {
            Name="Бл.6 ж.к.Младост-1 ",
            Kod="237",
            s="2001860"
            },new StopModel()
            {
            Name="МБАЛ Св. Ана ",
            Kod="1192",
            s="2001898"
            },new StopModel()
            {
            Name="Бл.30 ж.к.Младост 1 ",
            Kod="576",
            s="2001894"
            },new StopModel()
            {
            Name="Площад на авиацията ",
            Kod="1258",
            s="2001944"
            },new StopModel()
            {
            Name=" Ж.к. Изток ",
            Kod="1695",
            s="2001990"
            },new StopModel()
            {
            Name=" Хотел Плиска ",
            Kod="2327",
            s="2001995"
            },new StopModel()
            {
            Name=" УЛ.АЛ.ЖЕНДОВ ",
            Kod="1819",
            s="2002178"
            },new StopModel()
            {
            Name=" бул. Пейо Яворов ",
            Kod="73",
            s="2002002"
            },new StopModel()
            {
            Name=" Полиграфически комбинат ",
            Kod="1395",
            s="2001770"
            },new StopModel()
            {
            Name=" Пл. Орлов мост ",
            Kod="1288",
            s="2001764"
            },new StopModel()
            {
            Name=" Ул. Ген. Гурко ",
            Kod="1902",
            s="2000444"
            },new StopModel()
            {
            Name=" Кино Одеон ",
            Kod="926",
            s="2000874"
            },new StopModel()
            {
            Name=" НДК ",
            Kod="1136",
            s="2000880"
            },new StopModel()
            {
            Name=" Бул.Прага ",
            Kod="362",
            s="2002164"
            },new StopModel()
            {
            Name=" Пл.Руски паметник ",
            Kod="1297",
            s="2000899"
            },new StopModel()
            {
            Name=" Пл.Руски паметник ",
            Kod="1300",
            s="2000922"
            },new StopModel()
            {
            Name=" Бул.Александър Стамболийски ",
            Kod="284",
            s="2000993"
            },new StopModel()
            {
            Name=" Ул.Пиротска ",
            Kod="2114",
            s="2002161"
            },new StopModel()
            {
            Name=" Ул.Св.Св.Кирил и Методий ",
            Kod="2170",
            s="2001005"
            },new StopModel()
            {
            Name=" Ул.Охрид ",
            Kod="2102",
            s="2001143"
            },new StopModel()
            {
            Name=" Бул.Ген.Н.Столетов ",
            Kod="340",
            s="2001148"
            },new StopModel()
            {
            Name=" Ул.Вишовград ",
            Kod="1881",
            s="2001150"
            },new StopModel()
            {
            Name=" Надлез Надежда ",
            Kod="2116",
            s="2001154"
            },}
            },new DirectionModel()
            {
            Name ="Надлез Надежда - Ж.к.Младост 1",
            rid="2000037",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Надлез Надежда",
            Kod="2116",
            s="2001154"
            },new StopModel()
            {
            Name="Бул.Княгиня Мария Луиза ",
            Kod="324",
            s="2001141"
            },new StopModel()
            {
            Name="Ул.Охрид ",
            Kod="2105",
            s="2001137"
            },new StopModel()
            {
            Name="Ул.Св.Св.Кирил и Методий ",
            Kod="2171",
            s="2001004"
            },new StopModel()
            {
            Name="Ул.Пиротска ",
            Kod="2111",
            s="2002160"
            },new StopModel()
            {
            Name="Бул.Ал.Стамболийски ",
            Kod="283",
            s="2000992"
            },new StopModel()
            {
            Name="Пл.Руски паметник ",
            Kod="1295",
            s="2000921"
            },new StopModel()
            {
            Name="Пл.Руски паметник ",
            Kod="1296",
            s="2000898"
            },new StopModel()
            {
            Name="Бул. Прага ",
            Kod="363",
            s="2000416"
            },new StopModel()
            {
            Name=" ул. 6-ти септември ",
            Kod="1806",
            s="2000430"
            },new StopModel()
            {
            Name=" Кино Одеон ",
            Kod="927",
            s="2000441"
            },new StopModel()
            {
            Name=" Ул. Ген. Гурко ",
            Kod="1903",
            s="2000445"
            },new StopModel()
            {
            Name=" Пл.Орлов мост ",
            Kod="1287",
            s="2001765"
            },new StopModel()
            {
            Name=" Полиграфически комбинат ",
            Kod="1394",
            s="2001771"
            },new StopModel()
            {
            Name=" Бул.Пейо Яворов ",
            Kod="74",
            s="2002177"
            },new StopModel()
            {
            Name=" Ул.Ал.Жендов ",
            Kod="1820",
            s="2001999"
            },new StopModel()
            {
            Name=" Хотел Плиска ",
            Kod="2326",
            s="2002179"
            },new StopModel()
            {
            Name=" Ж.к. Изток ",
            Kod="1696",
            s="2001992"
            },new StopModel()
            {
            Name=" Площад на авиацията ",
            Kod="1257",
            s="2001929"
            },new StopModel()
            {
            Name=" Бл.30 ж.к.Младост 1 ",
            Kod="579",
            s="2001895"
            },new StopModel()
            {
            Name=" МБАЛ Св. Анна ",
            Kod="1193",
            s="2002261"
            },new StopModel()
            {
            Name=" Бл.6 ж.к.Младост-1 ",
            Kod="238",
            s="2001859"
            },new StopModel()
            {
            Name=" Бл.41 ж.к.Младост-1 ",
            Kod="210",
            s="2001863"
            },new StopModel()
            {
            Name=" Ул.Йерусалим ",
            Kod="2471",
            s="2002917"
            },new StopModel()
            {
            Name=" Онкологичен диспансер ",
            Kod="23",
            s="2001875"
            },new StopModel()
            {
            Name=" Посолствата ",
            Kod="1400",
            s="2001881"
            },new StopModel()
            {
            Name=" Ж.к.Младост 1 ",
            Kod="662",
            s="2001885"
            },}
            },}},
                        new BusModel()
            {
            Number = "6",
            lid = "2000006",
            Directions= new DirectionModel[]
            {
            new DirectionModel()
            {
            Name ="Ж.к.Люлин 3 - ухо - Пл.Сточна Гара",
            rid="2000509",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Ж.к.Люлин 3 - ухо",
            Kod="610",
            s="2001327"
            },new StopModel()
            {
            Name="Ж.к.Люлин 3 ",
            Kod="651",
            s="2001338"
            },new StopModel()
            {
            Name="Бл.350 ж.к.Люлин 3 ",
            Kod="197",
            s="2001452"
            },new StopModel()
            {
            Name="Бл.264 ж.к.Люлин 2 ",
            Kod="152",
            s="2001446"
            },new StopModel()
            {
            Name="Бл.21 ж.к.Люлин 1 ",
            Kod="1164",
            s="2001440"
            },new StopModel()
            {
            Name="90-то СОУ ",
            Kod="2277",
            s="2001434"
            },new StopModel()
            {
            Name="26-ти ДКЦ ",
            Kod="21",
            s="2001428"
            },new StopModel()
            {
            Name="Бул.Панчо Владигеров ",
            Kod="406",
            s="2001422"
            },new StopModel()
            {
            Name="Ул.Търново ",
            Kod="2220",
            s="2001410"
            },new StopModel()
            {
            Name=" Ул.Ген.Ас.Николов ",
            Kod="1890",
            s="2001404"
            },new StopModel()
            {
            Name=" 12-ти ДКЦ ",
            Kod="7",
            s="2001398"
            },new StopModel()
            {
            Name=" Ул. Ген. Вл. Динчев ",
            Kod="1893",
            s="2001384"
            },new StopModel()
            {
            Name=" Ул.Орион ",
            Kod="2093",
            s="2001259"
            },new StopModel()
            {
            Name=" Западен парк ",
            Kod="1251",
            s="2001255"
            },new StopModel()
            {
            Name=" Ул.Оряхово ",
            Kod="2097",
            s="2001243"
            },new StopModel()
            {
            Name=" Бул. К. Величков ",
            Kod="328",
            s="2001233"
            },new StopModel()
            {
            Name=" Ж.к. Банишора ",
            Kod="804",
            s="2001262"
            },new StopModel()
            {
            Name=" Ул. Опълченска ",
            Kod="2087",
            s="2000947"
            },new StopModel()
            {
            Name=" Бул.Христо Ботев ",
            Kod="385",
            s="2000951"
            },new StopModel()
            {
            Name=" Ул. Княз Борис І ",
            Kod="1998",
            s="2000954"
            },new StopModel()
            {
            Name=" Пл.Сточна Гара ",
            Kod="1317",
            s="2000971"
            },}
            },new DirectionModel()
            {
            Name ="Пл. Сточна гара - Ж.к.Люлин 3 - ухо",
            rid="2000014",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Пл. Сточна гара",
            Kod="1320",
            s="2000973"
            },new StopModel()
            {
            Name="Ул. Княз Борис І ",
            Kod="1999",
            s="2000962"
            },new StopModel()
            {
            Name="Бул. Христо Ботев ",
            Kod="382",
            s="2000958"
            },new StopModel()
            {
            Name="Ул. Опълченска ",
            Kod="2082",
            s="2001190"
            },new StopModel()
            {
            Name="Кв.Банишора ",
            Kod="803",
            s="2001194"
            },new StopModel()
            {
            Name="Бул. К. Величков ",
            Kod="325",
            s="2001234"
            },new StopModel()
            {
            Name="Ул.Оряхово ",
            Kod="2096",
            s="2001244"
            },new StopModel()
            {
            Name="Западен парк ",
            Kod="1253",
            s="2002267"
            },new StopModel()
            {
            Name="Ул. Орион ",
            Kod="2092",
            s="2001369"
            },new StopModel()
            {
            Name=" Бл. 115 ж.к. Люлин 10 ",
            Kod="137",
            s="2001381"
            },new StopModel()
            {
            Name=" Ул. Ген. Вл. Динчев ",
            Kod="1892",
            s="2001385"
            },new StopModel()
            {
            Name=" 12-ти ДКЦ ",
            Kod="6",
            s="2001399"
            },new StopModel()
            {
            Name=" Ул.Ген.Ас.Николов ",
            Kod="1891",
            s="2001407"
            },new StopModel()
            {
            Name=" Ул.Търново ",
            Kod="2221",
            s="2002272"
            },new StopModel()
            {
            Name=" Бул.Панчо Владигеров ",
            Kod="1782",
            s="2001425"
            },new StopModel()
            {
            Name=" 26-ти ДКЦ ",
            Kod="20",
            s="2001429"
            },new StopModel()
            {
            Name=" 90-то СОУ ",
            Kod="2272",
            s="2001435"
            },new StopModel()
            {
            Name=" Бл.21 ж.к.Люлин-1 ",
            Kod="1163",
            s="2001441"
            },new StopModel()
            {
            Name=" Бл.264 ж.к.Люлин-2 ",
            Kod="153",
            s="2001447"
            },new StopModel()
            {
            Name=" Бл.350 ж.к.Люлин-3 ",
            Kod="200",
            s="2001453"
            },new StopModel()
            {
            Name=" Ж.к.Люлин 3 - ухо ",
            Kod="610",
            s="2001327"
            },}
            },}},
                        new BusModel()
            {
            Number = "7",
            lid = "2000007",
            Directions= new DirectionModel[]
            {
            new DirectionModel()
            {
            Name ="Ж.к.Люлин 3 - ухо - Пл.Сточна Гара",
            rid="2000513",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Ж.к.Люлин 3 - ухо",
            Kod="610",
            s="2001327"
            },new StopModel()
            {
            Name="Ж.к.Люлин 3 ",
            Kod="652",
            s="2001465"
            },new StopModel()
            {
            Name="Ул.308 ",
            Kod="1799",
            s="2001471"
            },new StopModel()
            {
            Name="Община Люлин ",
            Kod="1719",
            s="2001479"
            },new StopModel()
            {
            Name="Ул.605 ",
            Kod="1809",
            s="2001483"
            },new StopModel()
            {
            Name="Бл.715 ж.к.Люлин-7 ",
            Kod="253",
            s="2001491"
            },new StopModel()
            {
            Name="Бл.706 ж.к.Люлин-7 ",
            Kod="251",
            s="2001499"
            },new StopModel()
            {
            Name="Ул.ген.Н.Генев ",
            Kod="1894",
            s="2001506"
            },new StopModel()
            {
            Name="Ул. Ген. Вл. Динчев ",
            Kod="1893",
            s="2001384"
            },new StopModel()
            {
            Name=" Ул.Орион ",
            Kod="2093",
            s="2001259"
            },new StopModel()
            {
            Name=" Западен парк ",
            Kod="1251",
            s="2001255"
            },new StopModel()
            {
            Name=" Ул.Оряхово ",
            Kod="2097",
            s="2001243"
            },new StopModel()
            {
            Name=" Бул. К. Величков ",
            Kod="328",
            s="2001233"
            },new StopModel()
            {
            Name=" Ж.к. Банишора ",
            Kod="804",
            s="2001262"
            },new StopModel()
            {
            Name=" Ул. Опълченска ",
            Kod="2087",
            s="2000947"
            },new StopModel()
            {
            Name=" Бул.Христо Ботев ",
            Kod="385",
            s="2000951"
            },new StopModel()
            {
            Name=" Ул. Княз Борис І ",
            Kod="1998",
            s="2000954"
            },new StopModel()
            {
            Name=" Пл.Сточна Гара ",
            Kod="1317",
            s="2000971"
            },}
            },new DirectionModel()
            {
            Name ="Пл. Сточна гара - Ж.к.Люлин 3 - ухо",
            rid="2000016",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Пл. Сточна гара",
            Kod="1320",
            s="2000973"
            },new StopModel()
            {
            Name="Ул. Княз Борис І ",
            Kod="1999",
            s="2000962"
            },new StopModel()
            {
            Name="Бул. Христо Ботев ",
            Kod="382",
            s="2000958"
            },new StopModel()
            {
            Name="Ул. Опълченска ",
            Kod="2082",
            s="2001190"
            },new StopModel()
            {
            Name="Кв.Банишора ",
            Kod="803",
            s="2001194"
            },new StopModel()
            {
            Name="Бул. К. Величков ",
            Kod="325",
            s="2001234"
            },new StopModel()
            {
            Name="Ул.Оряхово ",
            Kod="2096",
            s="2001244"
            },new StopModel()
            {
            Name="Западен парк ",
            Kod="1253",
            s="2002267"
            },new StopModel()
            {
            Name="Ул. Орион ",
            Kod="2092",
            s="2001369"
            },new StopModel()
            {
            Name=" Бл. 115 ж.к. Люлин 10 ",
            Kod="137",
            s="2001381"
            },new StopModel()
            {
            Name=" Ул. Ген. Вл. Динчев ",
            Kod="1892",
            s="2001385"
            },new StopModel()
            {
            Name=" Ул. Ген. Никола Генев ",
            Kod="1895",
            s="2001505"
            },new StopModel()
            {
            Name=" Бл. 706 ж.к. Люлин 7 ",
            Kod="252",
            s="2002277"
            },new StopModel()
            {
            Name=" Бл. 715 ж.к. Люлин 7 ",
            Kod="254",
            s="2001490"
            },new StopModel()
            {
            Name=" Ул. 605 ",
            Kod="1810",
            s="2001482"
            },new StopModel()
            {
            Name=" Община Люлин ",
            Kod="1716",
            s="2001478"
            },new StopModel()
            {
            Name=" Ул.308 ",
            Kod="1798",
            s="2001470"
            },new StopModel()
            {
            Name=" Ж.к.Люлин 3 ",
            Kod="653",
            s="2001464"
            },new StopModel()
            {
            Name=" Ж.к.Люлин 3 - ухо ",
            Kod="610",
            s="2001327"
            },}
            },}},

                        new BusModel()
            {
            Number = "8",
            lid = "2000004",
            Directions= new DirectionModel[]
            {
            new DirectionModel()
            {
            Name ="Ж.к. Гоце Делчев - МБАЛ Св.Анна-ухо",
            rid="2000046",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Ж.к. Гоце Делчев",
            Kod="600",
            s="2001602"
            },new StopModel()
            {
            Name="Ул.Тодор Каблешков ",
            Kod="490",
            s="2002280"
            },new StopModel()
            {
            Name="29-ти ДКЦ ",
            Kod="1226",
            s="2002281"
            },new StopModel()
            {
            Name="Ул.Костенски водопад ",
            Kod="2010",
            s="2001604"
            },new StopModel()
            {
            Name="Бул.Гоце Делчев ",
            Kod="310",
            s="2002283"
            },new StopModel()
            {
            Name="Ул.Нишава ",
            Kod="2062",
            s="2001634"
            },new StopModel()
            {
            Name="Ж.к.Иван Вазов ",
            Kod="623",
            s="2001552"
            },new StopModel()
            {
            Name="Бул.Акад.Иван Гешов ",
            Kod="269",
            s="2000338"
            },new StopModel()
            {
            Name="Център по Хигиена ",
            Kod="2342",
            s="2000342"
            },new StopModel()
            {
            Name=" ВМА ",
            Kod="419",
            s="2002174"
            },new StopModel()
            {
            Name=" МБАЛ Александровска ",
            Kod="1034",
            s="2000376"
            },new StopModel()
            {
            Name=" Бул. Пенчо Славейков ",
            Kod="358",
            s="2000400"
            },new StopModel()
            {
            Name=" Бул. Прага ",
            Kod="363",
            s="2000416"
            },new StopModel()
            {
            Name=" ул. 6-ти септември ",
            Kod="1806",
            s="2000430"
            },new StopModel()
            {
            Name=" Кино Одеон ",
            Kod="927",
            s="2000441"
            },new StopModel()
            {
            Name=" Ул. Ген. Гурко ",
            Kod="1903",
            s="2000445"
            },new StopModel()
            {
            Name=" Пл.Орлов мост ",
            Kod="1287",
            s="2001765"
            },new StopModel()
            {
            Name=" Полиграфически комбинат ",
            Kod="1394",
            s="2001771"
            },new StopModel()
            {
            Name=" Бул.Пейо Яворов ",
            Kod="74",
            s="2002177"
            },new StopModel()
            {
            Name=" Ул.Ал.Жендов ",
            Kod="1820",
            s="2001999"
            },new StopModel()
            {
            Name=" Хотел Плиска ",
            Kod="2326",
            s="2002179"
            },new StopModel()
            {
            Name=" Ж.к. Изток ",
            Kod="1696",
            s="2001992"
            },new StopModel()
            {
            Name=" Площад на авиацията ",
            Kod="1257",
            s="2001929"
            },new StopModel()
            {
            Name=" Бл.30 ж.к.Младост 1 ",
            Kod="579",
            s="2001895"
            },new StopModel()
            {
            Name=" МБАЛ Света  Ана ",
            Kod="1195",
            s="2002284"
            },new StopModel()
            {
            Name=" МБАЛ Св.Анна-ухо ",
            Kod="1197",
            s="2001891"
            },}
            },new DirectionModel()
            {
            Name ="МБАЛ Св.Анна-ухо - Ж.к. Гоце Делчев",
            rid="2000007",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="МБАЛ Св.Анна-ухо",
            Kod="1198",
            s="2001890"
            },new StopModel()
            {
            Name="МБАЛ Св. Ана ",
            Kod="1192",
            s="2001898"
            },new StopModel()
            {
            Name="Бл.30 ж.к.Младост 1 ",
            Kod="576",
            s="2001894"
            },new StopModel()
            {
            Name="Площад на авиацията ",
            Kod="1258",
            s="2001944"
            },new StopModel()
            {
            Name="Ж.к. Изток ",
            Kod="1695",
            s="2001990"
            },new StopModel()
            {
            Name="Хотел Плиска ",
            Kod="2327",
            s="2001995"
            },new StopModel()
            {
            Name="УЛ.АЛ.ЖЕНДОВ ",
            Kod="1819",
            s="2002178"
            },new StopModel()
            {
            Name="бул. Пейо Яворов ",
            Kod="73",
            s="2002002"
            },new StopModel()
            {
            Name="Полиграфически комбинат ",
            Kod="1395",
            s="2001770"
            },new StopModel()
            {
            Name=" Пл. Орлов мост ",
            Kod="1288",
            s="2001764"
            },new StopModel()
            {
            Name=" Ул. Ген. Гурко ",
            Kod="1902",
            s="2000444"
            },new StopModel()
            {
            Name=" Кино Одеон ",
            Kod="926",
            s="2000874"
            },new StopModel()
            {
            Name=" НДК ",
            Kod="1136",
            s="2000880"
            },new StopModel()
            {
            Name=" Бул. Прага ",
            Kod="366",
            s="2000405"
            },new StopModel()
            {
            Name=" Бул. Пенчо Славейков ",
            Kod="355",
            s="2000399"
            },new StopModel()
            {
            Name=" МБАЛ Александровска ",
            Kod="1035",
            s="2000373"
            },new StopModel()
            {
            Name=" ВМА ",
            Kod="418",
            s="2000367"
            },new StopModel()
            {
            Name=" Център по Хигиена ",
            Kod="2343",
            s="2002175"
            },new StopModel()
            {
            Name=" Бул.Акад.Ив.Гешов ",
            Kod="270",
            s="2001545"
            },new StopModel()
            {
            Name=" Ж.к.Иван Вазов ",
            Kod="626",
            s="2001621"
            },new StopModel()
            {
            Name=" Ул.Нишава ",
            Kod="2063",
            s="2001635"
            },new StopModel()
            {
            Name=" Бул.Гоце Делчев ",
            Kod="309",
            s="2001617"
            },new StopModel()
            {
            Name=" Ул.Костенски водопад ",
            Kod="2008",
            s="2002282"
            },new StopModel()
            {
            Name=" 29-ти ДКЦ ",
            Kod="1224",
            s="2001611"
            },new StopModel()
            {
            Name=" Ул.Тодор Каблешков ",
            Kod="484",
            s="2002279"
            },new StopModel()
            {
            Name=" Ж.к. Гоце Делчев ",
            Kod="599",
            s="2001603"
            },}
            },}},

                        new BusModel()
            {
            Number = "9",
            lid = "2000008",
            Directions= new DirectionModel[]
            {
            new DirectionModel()
            {
            Name ="Пл.Сточна гара - ж. к. Борово",
            rid="2000018",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Пл.Сточна гара",
            Kod="1318",
            s="2001044"
            },new StopModel()
            {
            Name="Ул.Поп Богомил ",
            Kod="2122",
            s="2001094"
            },new StopModel()
            {
            Name="Ул.Искър ",
            Kod="1962",
            s="2001088"
            },new StopModel()
            {
            Name="Пл.Ал.Невски ",
            Kod="1265",
            s="2001082"
            },new StopModel()
            {
            Name="Сатиричен театър ",
            Kod="1502",
            s="2002285"
            },new StopModel()
            {
            Name="Първа градска болница ",
            Kod="1422",
            s="2001104"
            },new StopModel()
            {
            Name="НДК ",
            Kod="1136",
            s="2000880"
            },new StopModel()
            {
            Name="Бул. Прага ",
            Kod="366",
            s="2000405"
            },new StopModel()
            {
            Name="Бул. Пенчо Славейков ",
            Kod="355",
            s="2000399"
            },new StopModel()
            {
            Name=" МБАЛ Александровска ",
            Kod="1035",
            s="2000373"
            },new StopModel()
            {
            Name=" ВМА ",
            Kod="418",
            s="2000367"
            },new StopModel()
            {
            Name=" Център по Хигиена ",
            Kod="2343",
            s="2002175"
            },new StopModel()
            {
            Name=" Пл.Ручей ",
            Kod="1302",
            s="2000311"
            },new StopModel()
            {
            Name=" Ул.Дойран ",
            Kod="1936",
            s="2000266"
            },new StopModel()
            {
            Name=" Бул.Гоце Делчев ",
            Kod="2136",
            s="2000260"
            },new StopModel()
            {
            Name=" 36-то ОУ ",
            Kod="32",
            s="2000256"
            },new StopModel()
            {
            Name=" 20-ти ДКЦ ",
            Kod="17",
            s="2000250"
            },new StopModel()
            {
            Name=" ж. к. Борово ",
            Kod="580",
            s="2000269"
            },}
            },new DirectionModel()
            {
            Name ="ж. к. Борово - Пл.Сточна гара",
            rid="2000518",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="ж. к. Борово",
            Kod="580",
            s="2000269"
            },new StopModel()
            {
            Name="20-ти ДКЦ ",
            Kod="16",
            s="2000253"
            },new StopModel()
            {
            Name="36-то ОУ ",
            Kod="31",
            s="2000259"
            },new StopModel()
            {
            Name="Бул.Гоце Делчев ",
            Kod="311",
            s="2000263"
            },new StopModel()
            {
            Name="Ул.Дойран ",
            Kod="1935",
            s="2000287"
            },new StopModel()
            {
            Name="Пл.Ручей ",
            Kod="1303",
            s="2000312"
            },new StopModel()
            {
            Name="Център по Хигиена ",
            Kod="2342",
            s="2000342"
            },new StopModel()
            {
            Name="ВМА ",
            Kod="419",
            s="2002174"
            },new StopModel()
            {
            Name="МБАЛ Александровска ",
            Kod="1034",
            s="2000376"
            },new StopModel()
            {
            Name=" Бул. Пенчо Славейков ",
            Kod="358",
            s="2000400"
            },new StopModel()
            {
            Name=" Бул. Прага ",
            Kod="363",
            s="2000416"
            },new StopModel()
            {
            Name=" Ул.Г.Раковски ",
            Kod="1886",
            s="2002286"
            },new StopModel()
            {
            Name=" Първа градска болница ",
            Kod="1423",
            s="2001105"
            },new StopModel()
            {
            Name=" Сатиричен театър ",
            Kod="1501",
            s="2001115"
            },new StopModel()
            {
            Name=" Пл.Ал.Невски ",
            Kod="1264",
            s="2001083"
            },new StopModel()
            {
            Name=" Ул.Искър ",
            Kod="1963",
            s="2001089"
            },new StopModel()
            {
            Name=" Ул. Поп Богомил ",
            Kod="2121",
            s="2001095"
            },new StopModel()
            {
            Name=" Ул. Тимок ",
            Kod="2205",
            s="2001056"
            },new StopModel()
            {
            Name=" Ул. Дунав ",
            Kod="1941",
            s="2001050"
            },new StopModel()
            {
            Name=" Пл.Сточна гара ",
            Kod="1318",
            s="2001044"
            },}
            },}},
                        new BusModel()
            {
            Number = "11",
            lid = "2000002",
            Directions= new DirectionModel[]
            {
            new DirectionModel()
            {
            Name ="Пл.Сточна гара - Ж.к. Дружба 1",
            rid="2000612",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="Пл.Сточна гара",
            Kod="1319",
            s="2001038"
            },new StopModel()
            {
            Name="Ул.Искър ",
            Kod="1964",
            s="2001030"
            },new StopModel()
            {
            Name="Паметника Левски ",
            Kod="1242",
            s="2000483"
            },new StopModel()
            {
            Name="СУ Св. Климент Охридски ",
            Kod="1698",
            s="2000469"
            },new StopModel()
            {
            Name="Пл.Орлов мост ",
            Kod="1287",
            s="2001765"
            },new StopModel()
            {
            Name="Полиграфически комбинат ",
            Kod="1394",
            s="2001771"
            },new StopModel()
            {
            Name="Бул.Пейо Яворов ",
            Kod="74",
            s="2002177"
            },new StopModel()
            {
            Name="Ул.Ал.Жендов ",
            Kod="1820",
            s="2001999"
            },new StopModel()
            {
            Name="Хотел Плиска ",
            Kod="2326",
            s="2002179"
            },new StopModel()
            {
            Name=" Ж.к. Изток ",
            Kod="1696",
            s="2001992"
            },new StopModel()
            {
            Name=" Площад на авиацията ",
            Kod="1257",
            s="2001929"
            },new StopModel()
            {
            Name=" Площад на авиацията ",
            Kod="1260",
            s="2001687"
            },new StopModel()
            {
            Name=" Спортна зала Арена Армеец ",
            Kod="2615",
            s="2001688"
            },new StopModel()
            {
            Name=" СК ЦСКА ",
            Kod="1152",
            s="2002026"
            },new StopModel()
            {
            Name=" Бул.Цв.Лазаров ",
            Kod="370",
            s="2001793"
            },new StopModel()
            {
            Name=" Ул.кап.Д.Списаревски ",
            Kod="1986",
            s="2002197"
            },new StopModel()
            {
            Name=" Бл.98 ж.к.Дружба-1 ",
            Kod="256",
            s="2002207"
            },new StopModel()
            {
            Name=" Бул.Христофор Колумб ",
            Kod="578",
            s="2001837"
            },new StopModel()
            {
            Name=" Бл. 59 ж.к. Дружба 1 ",
            Kod="235",
            s="2001841"
            },new StopModel()
            {
            Name=" Бл. 155 ж.к. Дружба 1 ",
            Kod="142",
            s="2001845"
            },new StopModel()
            {
            Name=" Бл. 162 ж.к. Дружба 1 ",
            Kod="144",
            s="2002291"
            },new StopModel()
            {
            Name=" Бл. 170 ж.к. Дружба 1 ",
            Kod="146",
            s="2002292"
            },new StopModel()
            {
            Name=" Депо Искър ",
            Kod="516",
            s="2001829"
            },new StopModel()
            {
            Name=" Ж.к.Дружба 1 ",
            Kod="605",
            s="2001834"
            },new StopModel()
            {
            Name=" Ж.к. Дружба 1 ",
            Kod="2424",
            s="2002928"
            },}
            },new DirectionModel()
            {
            Name ="ДепоИскър - Пл.Сточна гара",
            rid="2000613",
            Stops=new StopModel[]
            {new StopModel()
            {
            Name="ДепоИскър",
            Kod="517",
            s="2001828"
            },new StopModel()
            {
            Name="Бл. 170 ж.к. Дружба 1 ",
            Kod="147",
            s="2002293"
            },new StopModel()
            {
            Name="Бл.162, ж.к.Дружба 1 ",
            Kod="143",
            s="2002290"
            },new StopModel()
            {
            Name="Бл. 155ж.к. Дружба 1 ",
            Kod="141",
            s="2001844"
            },new StopModel()
            {
            Name="Бл. 59 ж.к. Дружба 1 ",
            Kod="236",
            s="2001840"
            },new StopModel()
            {
            Name="Бул.Христофор Колумб ",
            Kod="577",
            s="2002218"
            },new StopModel()
            {
            Name="Бл.98 ж.к.Дружба-1 ",
            Kod="257",
            s="2002206"
            },new StopModel()
            {
            Name="Бл.89, ж.к.Дружба 1 ",
            Kod="255",
            s="2002198"
            },new StopModel()
            {
            Name="Ул.кап.Д.Списаревси ",
            Kod="1983",
            s="2001794"
            },new StopModel()
            {
            Name=" Бул.проф.Цв.Лазаров ",
            Kod="371",
            s="2002180"
            },new StopModel()
            {
            Name=" СК ЦСКА ",
            Kod="1151",
            s="2002020"
            },new StopModel()
            {
            Name=" Спортна зала Арена Армеец ",
            Kod="2616",
            s="2002019"
            },new StopModel()
            {
            Name=" Ж.к. Изток ",
            Kod="1695",
            s="2001990"
            },new StopModel()
            {
            Name=" Хотел Плиска ",
            Kod="2327",
            s="2001995"
            },new StopModel()
            {
            Name=" УЛ.АЛ.ЖЕНДОВ ",
            Kod="1819",
            s="2002178"
            },new StopModel()
            {
            Name=" бул. Пейо Яворов ",
            Kod="73",
            s="2002002"
            },new StopModel()
            {
            Name=" Полиграфически комбинат ",
            Kod="1395",
            s="2001770"
            },new StopModel()
            {
            Name=" Пл. Орлов мост ",
            Kod="1288",
            s="2001764"
            },new StopModel()
            {
            Name=" СУ Св.Климент Охридски ",
            Kod="1699",
            s="2000470"
            },new StopModel()
            {
            Name=" Паметника Левски ",
            Kod="1241",
            s="2002166"
            },new StopModel()
            {
            Name=" Ул.Искър ",
            Kod="1965",
            s="2001031"
            },new StopModel()
            {
            Name=" Пл.Сточна гара ",
            Kod="1313",
            s="2001039"
            },}
            },}},
            };
            return trolleys;
        }
    }
}
