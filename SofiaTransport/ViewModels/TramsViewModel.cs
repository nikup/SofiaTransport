using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SofiaTransport.Models;

namespace SofiaTransport.ViewModels
{
    class TramsViewModel
    {
        private static ObservableCollection<BusModel> trams;

        public static IEnumerable<BusModel> Trams
        {
            get
            {
                if (trams == null)
                {
                    Trams = GetGeneratedTrams();
                }
                return trams;
            }
            set
            {
                if (trams != value)
                {
                    if (trams == null)
                    {
                        trams = new ObservableCollection<BusModel>();
                    }
                    trams.Clear();
                    foreach (var item in value)
                    {
                        trams.Add(item);
                    }
                }
            }
        }

        public static IEnumerable<BusModel> GetTrams()
        {
            return Trams;
        }
        public TramsViewModel()
        {
        }

        private static IEnumerable<BusModel> GetGeneratedTrams()
        {

            BusModel[] trams =
            {
                new BusModel()
                {
                    Number = "1",
                    lid = "3000027",
                     Directions= new DirectionModel[]
                     {
                     new DirectionModel()
                     {
                     Name ="Надлез Надежда - Ж.к.Ив.Вазов",
                     rid="3001209",
                     Stops=new StopModel[]
                     {new StopModel()
                     {
                     Name="Надлез Надежда",
                     Kod="1113",
                     s="3001241"
                     },new StopModel()
                     {
                     Name="Пета градска болница ",
                     Kod="1254",
                     s="3001226"
                     },new StopModel()
                     {
                     Name="Пл.Централна гара ",
                     Kod="1331",
                     s="3004498"
                     },new StopModel()
                     {
                     Name="Ул.Клокотница ",
                     Kod="1993",
                     s="3001170"
                     },new StopModel()
                     {
                     Name="Бул.Сливница ",
                     Kod="377",
                     s="3001158"
                     },new StopModel()
                     {
                     Name="Ул. Пиротска ",
                     Kod="2112",
                     s="3001136"
                     },new StopModel()
                     {
                     Name="Пл.Македония ",
                     Kod="1282",
                     s="3001094"
                     },new StopModel()
                     {
                     Name="Бул.Прага ",
                     Kod="364",
                     s="3001064"
                     },new StopModel()
                     {
                     Name="НДК ",
                     Kod="1134",
                     s="3002601"
                     },new StopModel()
                     {
                     Name=" Бул. П. Славейков ",
                     Kod="356",
                     s="3002611"
                     },new StopModel()
                     {
                     Name=" 14-ти ДКЦ ",
                     Kod="11",
                     s="3004842"
                     },new StopModel()
                     {
                     Name=" Читалище Петър Берон ",
                     Kod="929",
                     s="3002659"
                     },new StopModel()
                     {
                     Name=" Ж.к.Ив.Вазов ",
                     Kod="625",
                     s="3002675"
                     },}},
                     new DirectionModel()
                     {
                     Name ="Ж.к.Ив.Вазов - Надлез Надежда",
                     rid="3001297",
                     Stops=new StopModel[]
                     {new StopModel()
                     {
                     Name="Ж.к.Ив.Вазов",
                     Kod="625",
                     s="3002675"
                     },new StopModel()
                     {
                     Name="Читалище Петър Берон ",
                     Kod="928",
                     s="3002658"
                     },new StopModel()
                     {
                     Name="14-ти ДКЦ ",
                     Kod="10",
                     s="3002640"
                     },new StopModel()
                     {
                     Name="Бул.Пенчо Славейков ",
                     Kod="357",
                     s="3002606"
                     },new StopModel()
                     {
                     Name="НДК ",
                     Kod="1135",
                     s="3002598"
                     },new StopModel()
                     {
                     Name="Бул.Прага ",
                     Kod="365",
                     s="3001067"
                     },new StopModel()
                     {
                     Name="Пл.Македония ",
                     Kod="1281",
                     s="3001095"
                     },new StopModel()
                     {
                     Name="Ул.Пиротска ",
                     Kod="2113",
                     s="3001135"
                     },new StopModel()
                     {
                     Name="Бул.Сливница ",
                     Kod="376",
                     s="3001155"
                     },new StopModel()
                     {
                     Name=" Ул. Клокотница ",
                     Kod="1994",
                     s="3001171"
                     },new StopModel()
                     {
                     Name=" Централна автогара ",
                     Kod="2665",
                     s="3005353"
                     },new StopModel()
                     {
                     Name=" Площад Централна гара ",
                     Kod="1332",
                     s="3004833"
                     },new StopModel()
                     {
                     Name=" Пета градска болница ",
                     Kod="1255",
                     s="3001227"
                     },new StopModel()
                     {
                     Name=" Надлез Надежда ",
                     Kod="1113",
                     s="3001241"
                     },}
                     }}},
                                new BusModel()
                {
                Number = "3",
                lid = "3000028",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Кв.Орландовци - Гара Захарна фабрика",
                rid="3000251",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Кв.Орландовци",
                Kod="886",
                s="3003151"
                },new StopModel()
                {
                Name="Католически гробищен парк ",
                Kod="796",
                s="3003071"
                },new StopModel()
                {
                Name="Централен гробищен парк ",
                Kod="2332",
                s="3003085"
                },new StopModel()
                {
                Name="Хладилен завод ",
                Kod="2311",
                s="3003101"
                },new StopModel()
                {
                Name="Ул. Дунав ",
                Kod="1940",
                s="3003127"
                },new StopModel()
                {
                Name="Ул.Козлодуй ",
                Kod="2000",
                s="3004530"
                },new StopModel()
                {
                Name="Площад Централна гара ",
                Kod="1332",
                s="3004833"
                },new StopModel()
                {
                Name="Пл.Централна гара ",
                Kod="1331",
                s="3004498"
                },new StopModel()
                {
                Name="Ул.Клокотница ",
                Kod="1993",
                s="3001170"
                },new StopModel()
                {
                Name=" Бул.Сливница ",
                Kod="377",
                s="3001158"
                },new StopModel()
                {
                Name=" Ул. Пиротска ",
                Kod="2112",
                s="3001136"
                },new StopModel()
                {
                Name=" Пл.Възраждане ",
                Kod="1272",
                s="3001322"
                },new StopModel()
                {
                Name=" Ул. Опълченска ",
                Kod="2085",
                s="3001255"
                },new StopModel()
                {
                Name=" Ул.Одрин ",
                Kod="2076",
                s="3001269"
                },new StopModel()
                {
                Name=" Ул.Димитър Петков ",
                Kod="1926",
                s="3001283"
                },new StopModel()
                {
                Name=" Метростанция К.Величков ",
                Kod="1050",
                s="3000681"
                },new StopModel()
                {
                Name=" Ул.Цар Симеон ",
                Kod="2248",
                s="3003707"
                },new StopModel()
                {
                Name=" Ул.Зографски манастир ",
                Kod="1949",
                s="3003719"
                },new StopModel()
                {
                Name=" Ул.Хайдут Сидер ",
                Kod="2227",
                s="3004838"
                },new StopModel()
                {
                Name=" Гара Захарна фабрика ",
                Kod="622",
                s="3003754"
                },}
                },new DirectionModel()
                {
                Name ="Гара Захарна фабрика - Кв.Орландовци",
                rid="3000250",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Гара Захарна фабрика",
                Kod="621",
                s="3003763"
                },new StopModel()
                {
                Name="Ул.Хайдут Сидер ",
                Kod="2228",
                s="3004839"
                },new StopModel()
                {
                Name="Ул.Зографски манастир ",
                Kod="1948",
                s="3003720"
                },new StopModel()
                {
                Name="Ул.Цар Симеон ",
                Kod="2251",
                s="3003704"
                },new StopModel()
                {
                Name="Метростанция К.Величков ",
                Kod="1051",
                s="3000680"
                },new StopModel()
                {
                Name="Ул.Димитър Петков ",
                Kod="1925",
                s="3001284"
                },new StopModel()
                {
                Name="Ул.Одрин ",
                Kod="2075",
                s="3001270"
                },new StopModel()
                {
                Name="Ул.Опълченска ",
                Kod="2084",
                s="3001256"
                },new StopModel()
                {
                Name="Пл. Възраждане ",
                Kod="1271",
                s="3001337"
                },new StopModel()
                {
                Name=" Ул.Пиротска ",
                Kod="2113",
                s="3001135"
                },new StopModel()
                {
                Name=" Бул.Сливница ",
                Kod="376",
                s="3001155"
                },new StopModel()
                {
                Name=" Ул. Клокотница ",
                Kod="1994",
                s="3001171"
                },new StopModel()
                {
                Name=" Пл. Централна гара ",
                Kod="1330",
                s="3001185"
                },new StopModel()
                {
                Name=" Централна гара ",
                Kod="1329",
                s="3003232"
                },new StopModel()
                {
                Name=" Ул.Козлодуй ",
                Kod="2001",
                s="3004529"
                },new StopModel()
                {
                Name=" Ул. Дунав ",
                Kod="1939",
                s="3003126"
                },new StopModel()
                {
                Name=" Хладилен завод ",
                Kod="2310",
                s="3003100"
                },new StopModel()
                {
                Name=" Централен гробищен парк ",
                Kod="2333",
                s="3003084"
                },new StopModel()
                {
                Name=" Католически гробищен парк ",
                Kod="797",
                s="3003070"
                },new StopModel()
                {
                Name=" Кв.Орландовци ",
                Kod="885",
                s="3003149"
                },}
                },}},
                                new BusModel()
                {
                Number = "4",
                lid = "3000051",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="БУЛ. НИКОЛА ПЕТКОВ - Кв.Орландовци",
                rid="3000727",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="БУЛ. НИКОЛА ПЕТКОВ",
                Kod="349",
                s="3002332"
                },new StopModel()
                {
                Name="КВ. ПАВЛОВО ",
                Kod="892",
                s="3002346"
                },new StopModel()
                {
                Name="КВ. ОВЧА КУПЕЛ ",
                Kod="879",
                s="3002490"
                },new StopModel()
                {
                Name="Ж.к.Бъкстон ",
                Kod="590",
                s="3002377"
                },new StopModel()
                {
                Name="Ж.к.Красно село ",
                Kod="640",
                s="3002391"
                },new StopModel()
                {
                Name="Ул.Нишава ",
                Kod="2109",
                s="3002401"
                },new StopModel()
                {
                Name="Ж.к.Хиподрума ",
                Kod="693",
                s="3002405"
                },new StopModel()
                {
                Name="Ж.к.Лагера ",
                Kod="644",
                s="3002413"
                },new StopModel()
                {
                Name="Бул.Акад.Иван Гешов ",
                Kod="274",
                s="3002417"
                },new StopModel()
                {
                Name=" МБАЛСМ Пирогов ",
                Kod="759",
                s="3002431"
                },new StopModel()
                {
                Name=" Пл.Руски паметник ",
                Kod="1299",
                s="3002459"
                },new StopModel()
                {
                Name=" Пл. Македония ",
                Kod="1279",
                s="3002272"
                },new StopModel()
                {
                Name=" Ул.Пиротска ",
                Kod="2113",
                s="3001135"
                },new StopModel()
                {
                Name=" Бул.Сливница ",
                Kod="376",
                s="3001155"
                },new StopModel()
                {
                Name=" Ул. Клокотница ",
                Kod="1994",
                s="3001171"
                },new StopModel()
                {
                Name=" Пл. Централна гара ",
                Kod="1330",
                s="3001185"
                },new StopModel()
                {
                Name=" Централна гара ",
                Kod="1329",
                s="3003232"
                },new StopModel()
                {
                Name=" Ул.Козлодуй ",
                Kod="2001",
                s="3004529"
                },new StopModel()
                {
                Name=" Ул. Дунав ",
                Kod="1939",
                s="3003126"
                },new StopModel()
                {
                Name=" Хладилен завод ",
                Kod="2310",
                s="3003100"
                },new StopModel()
                {
                Name=" Централен гробищен парк ",
                Kod="2333",
                s="3003084"
                },new StopModel()
                {
                Name=" Католически гробищен парк ",
                Kod="797",
                s="3003070"
                },new StopModel()
                {
                Name=" Кв.Орландовци ",
                Kod="885",
                s="3003149"
                },}
                },new DirectionModel()
                {
                Name ="Кв.Орландовци - БУЛ. НИКОЛА ПЕТКОВ",
                rid="3000726",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Кв.Орландовци",
                Kod="886",
                s="3003151"
                },new StopModel()
                {
                Name="Католически гробищен парк ",
                Kod="796",
                s="3003071"
                },new StopModel()
                {
                Name="Централен гробищен парк ",
                Kod="2332",
                s="3003085"
                },new StopModel()
                {
                Name="Хладилен завод ",
                Kod="2311",
                s="3003101"
                },new StopModel()
                {
                Name="Ул. Дунав ",
                Kod="1940",
                s="3003127"
                },new StopModel()
                {
                Name="Ул.Козлодуй ",
                Kod="2000",
                s="3004530"
                },new StopModel()
                {
                Name="Площад Централна гара ",
                Kod="1332",
                s="3004833"
                },new StopModel()
                {
                Name="Пл.Централна гара ",
                Kod="1331",
                s="3004498"
                },new StopModel()
                {
                Name="Ул.Клокотница ",
                Kod="1993",
                s="3001170"
                },new StopModel()
                {
                Name=" Бул.Сливница ",
                Kod="377",
                s="3001158"
                },new StopModel()
                {
                Name=" Ул. Пиротска ",
                Kod="2112",
                s="3001136"
                },new StopModel()
                {
                Name=" Пл.Македония ",
                Kod="1280",
                s="3002269"
                },new StopModel()
                {
                Name=" Пл.Руски паметник ",
                Kod="1298",
                s="3002261"
                },new StopModel()
                {
                Name=" МБАЛСМ Пирогов ",
                Kod="758",
                s="3002428"
                },new StopModel()
                {
                Name=" Бул.Акад.Иван Гешов ",
                Kod="273",
                s="3002418"
                },new StopModel()
                {
                Name=" Ж.к.Лагера ",
                Kod="645",
                s="3002410"
                },new StopModel()
                {
                Name=" Ж.к.Хиподрума ",
                Kod="694",
                s="3002404"
                },new StopModel()
                {
                Name=" Ул.Нишава ",
                Kod="2110",
                s="3004840"
                },new StopModel()
                {
                Name=" Ж.к.Красно село ",
                Kod="639",
                s="3002392"
                },new StopModel()
                {
                Name=" Ж.к.Бъкстон ",
                Kod="589",
                s="3002376"
                },new StopModel()
                {
                Name=" Кв.Овча купел ",
                Kod="880",
                s="3002360"
                },new StopModel()
                {
                Name=" КВ. ПАВЛОВО ",
                Kod="891",
                s="3002345"
                },new StopModel()
                {
                Name=" БУЛ. НИКОЛА ПЕТКОВ ",
                Kod="348",
                s="3002333"
                },}
                },}},
                                new BusModel()
                {
                Number = "5",
                lid = "3000025",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Съдебна палата - Кв.Княжево",
                rid="3000086",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Съдебна палата",
                Kod="1721",
                s="3002229"
                },new StopModel()
                {
                Name="Пл.Македония ",
                Kod="1284",
                s="3002219"
                },new StopModel()
                {
                Name="Пл.Македония ",
                Kod="1280",
                s="3002269"
                },new StopModel()
                {
                Name="Пл.Руски паметник ",
                Kod="1298",
                s="3002261"
                },new StopModel()
                {
                Name="МБАЛСМ Пирогов ",
                Kod="758",
                s="3002428"
                },new StopModel()
                {
                Name="Бул.Акад.Иван Гешов ",
                Kod="273",
                s="3002418"
                },new StopModel()
                {
                Name="Ж.к.Лагера ",
                Kod="645",
                s="3002410"
                },new StopModel()
                {
                Name="Ж.к.Хиподрума ",
                Kod="694",
                s="3002404"
                },new StopModel()
                {
                Name="Ул.Нишава ",
                Kod="2110",
                s="3004840"
                },new StopModel()
                {
                Name=" Ж.к.Красно село ",
                Kod="639",
                s="3002392"
                },new StopModel()
                {
                Name=" Ж.к.Бъкстон ",
                Kod="589",
                s="3002376"
                },new StopModel()
                {
                Name=" Кв.Овча купел ",
                Kod="880",
                s="3002360"
                },new StopModel()
                {
                Name=" КВ. ПАВЛОВО ",
                Kod="891",
                s="3002345"
                },new StopModel()
                {
                Name=" БУЛ. НИКОЛА ПЕТКОВ ",
                Kod="348",
                s="3002333"
                },new StopModel()
                {
                Name=" Ул.Планинец ",
                Kod="2103",
                s="3002548"
                },new StopModel()
                {
                Name=" Райска градина ",
                Kod="2261",
                s="3002538"
                },new StopModel()
                {
                Name=" Кв.Княжево ",
                Kod="851",
                s="3002558"
                },}
                },new DirectionModel()
                {
                Name ="Кв.Княжево - Съдебна палата",
                rid="3000085",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Кв.Княжево",
                Kod="852",
                s="3002568"
                },new StopModel()
                {
                Name="Райска градина ",
                Kod="2260",
                s="3002541"
                },new StopModel()
                {
                Name="Ул.Планинец ",
                Kod="2104",
                s="3002547"
                },new StopModel()
                {
                Name="БУЛ. НИКОЛА ПЕТКОВ ",
                Kod="349",
                s="3002332"
                },new StopModel()
                {
                Name="КВ. ПАВЛОВО ",
                Kod="892",
                s="3002346"
                },new StopModel()
                {
                Name="КВ. ОВЧА КУПЕЛ ",
                Kod="879",
                s="3002490"
                },new StopModel()
                {
                Name="Ж.к.Бъкстон ",
                Kod="590",
                s="3002377"
                },new StopModel()
                {
                Name="Ж.к.Красно село ",
                Kod="640",
                s="3002391"
                },new StopModel()
                {
                Name="Ул.Нишава ",
                Kod="2109",
                s="3002401"
                },new StopModel()
                {
                Name=" Ж.к.Хиподрума ",
                Kod="693",
                s="3002405"
                },new StopModel()
                {
                Name=" Ж.к.Лагера ",
                Kod="644",
                s="3002413"
                },new StopModel()
                {
                Name=" Бул.Акад.Иван Гешов ",
                Kod="274",
                s="3002417"
                },new StopModel()
                {
                Name=" МБАЛСМ Пирогов ",
                Kod="759",
                s="3002431"
                },new StopModel()
                {
                Name=" Пл.Руски паметник ",
                Kod="1299",
                s="3002459"
                },new StopModel()
                {
                Name=" Пл. Македония ",
                Kod="1279",
                s="3002272"
                },new StopModel()
                {
                Name=" Пл.Македония ",
                Kod="1283",
                s="3002222"
                },new StopModel()
                {
                Name=" Съдебна палата ",
                Kod="1720",
                s="3002235"
                },}
                },}},
                                new BusModel()
                {
                Number = "6",
                lid = "3000032",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Ж.к.Лозенец - Хюндай България-временна",
                rid="3001206",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Ж.к.Лозенец",
                Kod="647",
                s="3002881"
                },new StopModel()
                {
                Name="Хотел Хемус ",
                Kod="1324",
                s="3002898"
                },new StopModel()
                {
                Name="Хотел Хилтън ",
                Kod="400",
                s="3001027"
                },new StopModel()
                {
                Name="Бул.Прага ",
                Kod="365",
                s="3001067"
                },new StopModel()
                {
                Name="Пл.Македония ",
                Kod="1281",
                s="3001095"
                },new StopModel()
                {
                Name="Ул.Пиротска ",
                Kod="2113",
                s="3001135"
                },new StopModel()
                {
                Name="Бул.Сливница ",
                Kod="376",
                s="3001155"
                },new StopModel()
                {
                Name="Ул. Клокотница ",
                Kod="1994",
                s="3001171"
                },new StopModel()
                {
                Name="Пл. Централна гара ",
                Kod="1330",
                s="3001185"
                },new StopModel()
                {
                Name=" Пета градска болница ",
                Kod="1255",
                s="3001227"
                },new StopModel()
                {
                Name=" Кв.Триъгълника ",
                Kod="1775",
                s="3004169"
                },new StopModel()
                {
                Name=" Модна къща Агресия ",
                Kod="541",
                s="3003997"
                },new StopModel()
                {
                Name=" Бул.Рожен ",
                Kod="547",
                s="3004005"
                },new StopModel()
                {
                Name=" ЗАГ Динамик ",
                Kod="727",
                s="3004025"
                },new StopModel()
                {
                Name=" Софарма АД ",
                Kod="745",
                s="3004031"
                },new StopModel()
                {
                Name=" Стоков базар Илиянци ",
                Kod="754",
                s="3004039"
                },new StopModel()
                {
                Name=" Хюндай България-временна ",
                Kod="6238",
                s="3003963"
                },}
                },new DirectionModel()
                {
                Name ="Хюндай България-временна - Ж.к.Лозенец",
                rid="3001207",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Хюндай България-временна",
                Kod="6239",
                s="3003956"
                },new StopModel()
                {
                Name="Стоков базар Илиянци ",
                Kod="755",
                s="3004036"
                },new StopModel()
                {
                Name="Софарма АД ",
                Kod="744",
                s="3004030"
                },new StopModel()
                {
                Name="ЗАГ Динамик ",
                Kod="728",
                s="3004022"
                },new StopModel()
                {
                Name="Бул.Рожен ",
                Kod="546",
                s="3004008"
                },new StopModel()
                {
                Name="Модна къща Агресия ",
                Kod="540",
                s="3003996"
                },new StopModel()
                {
                Name="Кв.Триъгълника ",
                Kod="1776",
                s="3004171"
                },new StopModel()
                {
                Name="Пета градска болница ",
                Kod="1254",
                s="3001226"
                },new StopModel()
                {
                Name="Пл.Централна гара ",
                Kod="1331",
                s="3004498"
                },new StopModel()
                {
                Name=" Ул.Клокотница ",
                Kod="1993",
                s="3001170"
                },new StopModel()
                {
                Name=" Бул.Сливница ",
                Kod="377",
                s="3001158"
                },new StopModel()
                {
                Name=" Ул. Пиротска ",
                Kod="2112",
                s="3001136"
                },new StopModel()
                {
                Name=" Пл.Македония ",
                Kod="1282",
                s="3001094"
                },new StopModel()
                {
                Name=" Бул.Прага ",
                Kod="364",
                s="3001064"
                },new StopModel()
                {
                Name=" Хотел Хилтън ",
                Kod="399",
                s="3001024"
                },new StopModel()
                {
                Name=" Хотел Хемус ",
                Kod="1325",
                s="3002862"
                },new StopModel()
                {
                Name=" Ж.к.Лозенец ",
                Kod="648",
                s="3002884"
                },}
                },}},
                     new BusModel()
                {
                Number = "7",
                lid = "3000030",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Метрост. Хан Кубрат - Ж.к.Борово",
                rid="3001299",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Метрост. Хан Кубрат",
                Kod="2477",
                s="3004233"
                },new StopModel()
                {
                Name="Кв. Триъгълника ",
                Kod="1778",
                s="3004189"
                },new StopModel()
                {
                Name="Пета градска болница ",
                Kod="1254",
                s="3001226"
                },new StopModel()
                {
                Name="Пл.Централна гара ",
                Kod="1331",
                s="3004498"
                },new StopModel()
                {
                Name="Ул.Клокотница ",
                Kod="1993",
                s="3001170"
                },new StopModel()
                {
                Name="Бул.Сливница ",
                Kod="377",
                s="3001158"
                },new StopModel()
                {
                Name="Ул. Пиротска ",
                Kod="2112",
                s="3001136"
                },new StopModel()
                {
                Name="Пл.Македония ",
                Kod="1282",
                s="3001094"
                },new StopModel()
                {
                Name="Бул.Прага ",
                Kod="364",
                s="3001064"
                },new StopModel()
                {
                Name=" НДК ",
                Kod="1134",
                s="3002601"
                },new StopModel()
                {
                Name=" Бул. П. Славейков ",
                Kod="356",
                s="3002611"
                },new StopModel()
                {
                Name=" ПГ Текстил и моден дизайн ",
                Kod="1737",
                s="3002737"
                },new StopModel()
                {
                Name=" Бул.акад.Ив.Гешов ",
                Kod="271",
                s="3002751"
                },new StopModel()
                {
                Name=" Пл.Ручей ",
                Kod="1304",
                s="3002763"
                },new StopModel()
                {
                Name=" Бул.Гоце Делчев ",
                Kod="312",
                s="3002781"
                },new StopModel()
                {
                Name=" Хипермаркет Била ",
                Kod="672",
                s="3002787"
                },new StopModel()
                {
                Name=" Ул.Т.Каблешков ",
                Kod="2212",
                s="3002805"
                },new StopModel()
                {
                Name=" Ж.к.Борово ",
                Kod="581",
                s="3002823"
                },}
                },new DirectionModel()
                {
                Name ="Ж.к.Борово - Метростанция Хан Кубрат",
                rid="3001298",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Ж.к.Борово",
                Kod="582",
                s="3002830"
                },new StopModel()
                {
                Name="Ул.т.Каблешков ",
                Kod="2211",
                s="3002798"
                },new StopModel()
                {
                Name="Хипермаркет Била ",
                Kod="671",
                s="3002786"
                },new StopModel()
                {
                Name="Бул.Гоце Делчев ",
                Kod="313",
                s="3002776"
                },new StopModel()
                {
                Name="Пл.Ручей ",
                Kod="1305",
                s="3002760"
                },new StopModel()
                {
                Name="Бул.акад Ив.Гешов ",
                Kod="272",
                s="3002744"
                },new StopModel()
                {
                Name="ПГ Текстил и моден дизайн ",
                Kod="1738",
                s="3002736"
                },new StopModel()
                {
                Name="Бул.Пенчо Славейков ",
                Kod="357",
                s="3002606"
                },new StopModel()
                {
                Name="НДК ",
                Kod="1135",
                s="3002598"
                },new StopModel()
                {
                Name=" Бул.Прага ",
                Kod="365",
                s="3001067"
                },new StopModel()
                {
                Name=" Пл.Македония ",
                Kod="1281",
                s="3001095"
                },new StopModel()
                {
                Name=" Ул.Пиротска ",
                Kod="2113",
                s="3001135"
                },new StopModel()
                {
                Name=" Бул.Сливница ",
                Kod="376",
                s="3001155"
                },new StopModel()
                {
                Name=" Ул. Клокотница ",
                Kod="1994",
                s="3001171"
                },new StopModel()
                {
                Name=" Пл. Централна гара ",
                Kod="1330",
                s="3001185"
                },new StopModel()
                {
                Name=" Пета градска болница ",
                Kod="1255",
                s="3001227"
                },new StopModel()
                {
                Name=" Кв. Триъгълника ",
                Kod="1777",
                s="3004192"
                },new StopModel()
                {
                Name=" Метростанция Хан Кубрат ",
                Kod="2663",
                s="3004901"
                },}
                },}},
                                new BusModel()
                {
                Number = "8",
                lid = "3000023",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="ж.к.Люлин-5 - Съдебна палата",
                rid="3000505",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="ж.к.Люлин-5",
                Kod="655",
                s="3003652"
                },new StopModel()
                {
                Name="Бл. 539 ж.к. Люлин 5 ",
                Kod="108",
                s="3003467"
                },new StopModel()
                {
                Name="Бул. Петър Дертлиев ",
                Kod="321",
                s="3004837"
                },new StopModel()
                {
                Name="Магазин Витоша ",
                Kod="1711",
                s="3003481"
                },new StopModel()
                {
                Name="Община Люлин ",
                Kod="1718",
                s="3003489"
                },new StopModel()
                {
                Name="Метростанция Люлин ",
                Kod="1056",
                s="3003509"
                },new StopModel()
                {
                Name="Бул. Джавахарлал Неру ",
                Kod="319",
                s="3003521"
                },new StopModel()
                {
                Name="Ул. Луи Пастьор ",
                Kod="335",
                s="3004836"
                },new StopModel()
                {
                Name="Метростанция Западен парк ",
                Kod="1049",
                s="3003533"
                },new StopModel()
                {
                Name=" Метростанция Вардар ",
                Kod="1046",
                s="3003617"
                },new StopModel()
                {
                Name=" Бул.Ал.Стамболийски ",
                Kod="708",
                s="3003635"
                },new StopModel()
                {
                Name=" Бул. Вардар ",
                Kod="707",
                s="3003359"
                },new StopModel()
                {
                Name=" 10-ти ДКЦ ",
                Kod="1165",
                s="3003343"
                },new StopModel()
                {
                Name=" Бул. К. Величков ",
                Kod="327",
                s="3003329"
                },new StopModel()
                {
                Name=" Ул.Димитър Петков ",
                Kod="1925",
                s="3001284"
                },new StopModel()
                {
                Name=" Ул.Одрин ",
                Kod="2075",
                s="3001270"
                },new StopModel()
                {
                Name=" Ул.Опълченска ",
                Kod="2084",
                s="3001256"
                },new StopModel()
                {
                Name=" Пл.Възраждане ",
                Kod="1269",
                s="3002719"
                },new StopModel()
                {
                Name=" Пл.Македония ",
                Kod="1283",
                s="3002222"
                },new StopModel()
                {
                Name=" Съдебна палата ",
                Kod="1720",
                s="3002235"
                },}
                },new DirectionModel()
                {
                Name ="Съдебна палата - ж.к. Люлин-5",
                rid="3000506",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Съдебна палата",
                Kod="1721",
                s="3002229"
                },new StopModel()
                {
                Name="Пл.Македония ",
                Kod="1284",
                s="3002219"
                },new StopModel()
                {
                Name="Пл.Възраждане ",
                Kod="1270",
                s="3001310"
                },new StopModel()
                {
                Name="Ул. Опълченска ",
                Kod="2085",
                s="3001255"
                },new StopModel()
                {
                Name="Ул.Одрин ",
                Kod="2076",
                s="3001269"
                },new StopModel()
                {
                Name="Ул.Димитър Петков ",
                Kod="1926",
                s="3001283"
                },new StopModel()
                {
                Name="Бул. К. Величков ",
                Kod="326",
                s="3004835"
                },new StopModel()
                {
                Name="10-ти ДКЦ ",
                Kod="1166",
                s="3003342"
                },new StopModel()
                {
                Name="Бул. Вардар ",
                Kod="706",
                s="3003362"
                },new StopModel()
                {
                Name=" Бул.Ал.Стамболийски ",
                Kod="709",
                s="3003632"
                },new StopModel()
                {
                Name=" Метростанция Вардар ",
                Kod="1045",
                s="3003612"
                },new StopModel()
                {
                Name=" Метростанция Западен парк ",
                Kod="1048",
                s="3003532"
                },new StopModel()
                {
                Name=" Ул.Луи Пастьор ",
                Kod="336",
                s="3003524"
                },new StopModel()
                {
                Name=" Бул. Джавахарлал Неру ",
                Kod="320",
                s="3003520"
                },new StopModel()
                {
                Name=" Метростанция Люлин ",
                Kod="1055",
                s="3003510"
                },new StopModel()
                {
                Name=" Община Люлин ",
                Kod="1717",
                s="3003486"
                },new StopModel()
                {
                Name=" Магазин Витоша ",
                Kod="1712",
                s="3003478"
                },new StopModel()
                {
                Name=" Бул. Петър Дертлиев ",
                Kod="322",
                s="3003470"
                },new StopModel()
                {
                Name=" Бл. 539 ж.к. Люлин 5 ",
                Kod="2398",
                s="3003466"
                },new StopModel()
                {
                Name=" ж.к. Люлин-5 ",
                Kod="656",
                s="3003443"
                },}
                },}},
                                new BusModel()
                {
                Number = "10",
                lid = "3000024",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Ж.к. Западен парк - кв. Хладилника",
                rid="3000874",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Ж.к. Западен парк",
                Kod="619",
                s="3003306"
                },new StopModel()
                {
                Name="Бл. 13 ж.к. Западен парк ",
                Kod="2196",
                s="3003298"
                },new StopModel()
                {
                Name="Бул. Вардар ",
                Kod="707",
                s="3003359"
                },new StopModel()
                {
                Name="10-ти ДКЦ ",
                Kod="1165",
                s="3003343"
                },new StopModel()
                {
                Name="Бул. К. Величков ",
                Kod="327",
                s="3003329"
                },new StopModel()
                {
                Name="Ул.Димитър Петков ",
                Kod="1925",
                s="3001284"
                },new StopModel()
                {
                Name="Ул.Одрин ",
                Kod="2075",
                s="3001270"
                },new StopModel()
                {
                Name="Ул.Опълченска ",
                Kod="2084",
                s="3001256"
                },new StopModel()
                {
                Name="Пл.Възраждане ",
                Kod="1269",
                s="3002719"
                },new StopModel()
                {
                Name=" Пл.Македония ",
                Kod="1283",
                s="3002222"
                },new StopModel()
                {
                Name=" Пл. Гарибалди ",
                Kod="1996",
                s="3002075"
                },new StopModel()
                {
                Name=" Пл. Славейков ",
                Kod="1908",
                s="3002061"
                },new StopModel()
                {
                Name=" Бул.Васил Левски ",
                Kod="299",
                s="3002041"
                },new StopModel()
                {
                Name=" УАСГ ",
                Kod="386",
                s="3004533"
                },new StopModel()
                {
                Name=" Пл.Журналист ",
                Kod="1273",
                s="3002091"
                },new StopModel()
                {
                Name=" Ул.Вишнева ",
                Kod="1880",
                s="3001516"
                },new StopModel()
                {
                Name=" Семинарията ",
                Kod="1571",
                s="3001461"
                },new StopModel()
                {
                Name=" Ул.Милин камък ",
                Kod="2045",
                s="3001443"
                },new StopModel()
                {
                Name=" Енергопроект ",
                Kod="574",
                s="3001421"
                },new StopModel()
                {
                Name=" Кемпингски хотел Зографски ",
                Kod="922",
                s="3000962"
                },new StopModel()
                {
                Name=" Ул.Люботрън ",
                Kod="2038",
                s="3000952"
                },new StopModel()
                {
                Name=" Бул.Никола Вапцаров ",
                Kod="343",
                s="3000936"
                },new StopModel()
                {
                Name=" кв. Хладилника ",
                Kod="911",
                s="3000720"
                },}
                },new DirectionModel()
                {
                Name ="кв. Хладилника - Ж.к. Западен парк",
                rid="3000873",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="кв. Хладилника",
                Kod="910",
                s="3001099"
                },new StopModel()
                {
                Name="Бул. Никола Вапцаров ",
                Kod="342",
                s="3000937"
                },new StopModel()
                {
                Name="Ул. Люботрън ",
                Kod="2039",
                s="3000953"
                },new StopModel()
                {
                Name="Кемпински хотел Зографски ",
                Kod="923",
                s="3000963"
                },new StopModel()
                {
                Name="Енергопроект ",
                Kod="575",
                s="3001422"
                },new StopModel()
                {
                Name="Ул. Милин камък ",
                Kod="2046",
                s="3001444"
                },new StopModel()
                {
                Name="Семинарията ",
                Kod="1572",
                s="3001464"
                },new StopModel()
                {
                Name="Ул.Вишнева ",
                Kod="1879",
                s="3004535"
                },new StopModel()
                {
                Name="Пл.Журналист ",
                Kod="1274",
                s="3001994"
                },new StopModel()
                {
                Name=" УАСГ ",
                Kod="387",
                s="3004534"
                },new StopModel()
                {
                Name=" Бул.Васил Левски ",
                Kod="300",
                s="3002038"
                },new StopModel()
                {
                Name=" Пл. Славейков ",
                Kod="1909",
                s="3002060"
                },new StopModel()
                {
                Name=" Пл. Гарибалди ",
                Kod="1997",
                s="3002076"
                },new StopModel()
                {
                Name=" Пл.Македония ",
                Kod="1284",
                s="3002219"
                },new StopModel()
                {
                Name=" Пл.Възраждане ",
                Kod="1270",
                s="3001310"
                },new StopModel()
                {
                Name=" Ул. Опълченска ",
                Kod="2085",
                s="3001255"
                },new StopModel()
                {
                Name=" Ул.Одрин ",
                Kod="2076",
                s="3001269"
                },new StopModel()
                {
                Name=" Ул.Димитър Петков ",
                Kod="1926",
                s="3001283"
                },new StopModel()
                {
                Name=" Бул. К. Величков ",
                Kod="326",
                s="3004835"
                },new StopModel()
                {
                Name=" 10-ти ДКЦ ",
                Kod="1166",
                s="3003342"
                },new StopModel()
                {
                Name=" Бул. Вардар ",
                Kod="706",
                s="3003362"
                },new StopModel()
                {
                Name=" Бл. 13 ж.к. Западен парк ",
                Kod="2197",
                s="3003299"
                },new StopModel()
                {
                Name=" Ж.к. Западен парк ",
                Kod="618",
                s="3003310"
                },}
                },}},
                                new BusModel()
                {
                Number = "11",
                lid = "3000029",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="БУЛ. НИКОЛА ПЕТКОВ - Кв.Илиянци",
                rid="3000256",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="БУЛ. НИКОЛА ПЕТКОВ",
                Kod="349",
                s="3002332"
                },new StopModel()
                {
                Name="КВ. ПАВЛОВО ",
                Kod="892",
                s="3002346"
                },new StopModel()
                {
                Name="КВ. ОВЧА КУПЕЛ ",
                Kod="879",
                s="3002490"
                },new StopModel()
                {
                Name="НЦ по рехабилитация ",
                Kod="97",
                s="3002978"
                },new StopModel()
                {
                Name="УЛ. НАРОДНО ХОРО ",
                Kod="2056",
                s="3002964"
                },new StopModel()
                {
                Name="ул. Президент Линкълн ",
                Kod="2068",
                s="3002956"
                },new StopModel()
                {
                Name="Балканкар АД ",
                Kod="568",
                s="3002944"
                },new StopModel()
                {
                Name="Ж.К. КРАСНА ПОЛЯНА ",
                Kod="634",
                s="3002930"
                },new StopModel()
                {
                Name="УЛ. ДОБРОТИЧ ",
                Kod="1933",
                s="3000679"
                },new StopModel()
                {
                Name=" БУЛ. ВАРДАР ",
                Kod="295",
                s="3000423"
                },new StopModel()
                {
                Name=" УЛ.ОСВОБОЖДЕНИЕ ",
                Kod="2098",
                s="3000441"
                },new StopModel()
                {
                Name=" БУЛ. ВЪЗКРЕСЕНИЕ ",
                Kod="306",
                s="3000447"
                },new StopModel()
                {
                Name=" ПАРК СВ. СВ. ПЕТЪР И ПАВЕЛ ",
                Kod="1247",
                s="3000459"
                },new StopModel()
                {
                Name=" БУЛ. АЛЕКСАНДЪР СТАМБОЛИЙСКИ ",
                Kod="286",
                s="3000467"
                },new StopModel()
                {
                Name=" Метростанция К.Величков ",
                Kod="1050",
                s="3000681"
                },new StopModel()
                {
                Name=" Ул.Цар Симеон ",
                Kod="2249",
                s="3003769"
                },new StopModel()
                {
                Name=" Ул.Пловдив ",
                Kod="2421",
                s="3003773"
                },new StopModel()
                {
                Name=" Ул.Йосиф Щросмайер ",
                Kod="1970",
                s="3003781"
                },new StopModel()
                {
                Name=" Надлез Надежда ",
                Kod="359",
                s="3003801"
                },new StopModel()
                {
                Name=" Кв.Триъгълника ",
                Kod="1775",
                s="3004169"
                },new StopModel()
                {
                Name=" Модна къща Агресия ",
                Kod="541",
                s="3003997"
                },new StopModel()
                {
                Name=" Бул.Рожен ",
                Kod="547",
                s="3004005"
                },new StopModel()
                {
                Name=" ЗАГ Динамик ",
                Kod="727",
                s="3004025"
                },new StopModel()
                {
                Name=" Софарма АД ",
                Kod="745",
                s="3004031"
                },new StopModel()
                {
                Name=" Стоков базар Илиянци ",
                Kod="754",
                s="3004039"
                },new StopModel()
                {
                Name=" Хюндай България ",
                Kod="1636",
                s="3004104"
                },new StopModel()
                {
                Name=" Ул.Грозден ",
                Kod="1915",
                s="3004124"
                },new StopModel()
                {
                Name=" Ул.Кирил Благоев ",
                Kod="1987",
                s="3004136"
                },new StopModel()
                {
                Name=" Кв.Илиянци ",
                Kod="847",
                s="3004150"
                },}
                },new DirectionModel()
                {
                Name ="Кв.Илиянци - БУЛ. НИКОЛА ПЕТКОВ",
                rid="3000257",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Кв.Илиянци",
                Kod="848",
                s="3004145"
                },new StopModel()
                {
                Name="Ул.Кирил Благоев ",
                Kod="1988",
                s="3004135"
                },new StopModel()
                {
                Name="Ул.Грозден ",
                Kod="1916",
                s="3004123"
                },new StopModel()
                {
                Name="Хюндай България ",
                Kod="1635",
                s="3004101"
                },new StopModel()
                {
                Name="Стоков базар Илиянци ",
                Kod="755",
                s="3004036"
                },new StopModel()
                {
                Name="Софарма АД ",
                Kod="744",
                s="3004030"
                },new StopModel()
                {
                Name="ЗАГ Динамик ",
                Kod="728",
                s="3004022"
                },new StopModel()
                {
                Name="Бул.Рожен ",
                Kod="546",
                s="3004008"
                },new StopModel()
                {
                Name="Модна къща Агресия ",
                Kod="540",
                s="3003996"
                },new StopModel()
                {
                Name=" Кв.Триъгълника ",
                Kod="1776",
                s="3004171"
                },new StopModel()
                {
                Name=" Надлез Надежда ",
                Kod="2115",
                s="3003792"
                },new StopModel()
                {
                Name=" Ул.Йосиф Щросмайер ",
                Kod="1969",
                s="3003784"
                },new StopModel()
                {
                Name=" Ул.Пловдив ",
                Kod="2420",
                s="3003772"
                },new StopModel()
                {
                Name=" Ул.Цар Симеон ",
                Kod="2250",
                s="3003768"
                },new StopModel()
                {
                Name=" Метростанция К.Величков ",
                Kod="1051",
                s="3000680"
                },new StopModel()
                {
                Name=" БУЛ. АЛЕКСАНДЪР СТАМБОЛИЙСКИ ",
                Kod="285",
                s="3000466"
                },new StopModel()
                {
                Name=" ПАРК СВ.СВ. ПЕТЪР И ПАВЕЛ ",
                Kod="1248",
                s="3000458"
                },new StopModel()
                {
                Name=" БУЛ. ВЪЗКРЕСЕНИЕ ",
                Kod="305",
                s="3000506"
                },new StopModel()
                {
                Name=" УЛ.ОСВОБОЖДЕНИЕ ",
                Kod="2099",
                s="3000440"
                },new StopModel()
                {
                Name=" БУЛ. ВАРДАР ",
                Kod="294",
                s="3000424"
                },new StopModel()
                {
                Name=" УЛ. ДОБРОТИЧ ",
                Kod="1932",
                s="3000678"
                },new StopModel()
                {
                Name=" сп. Красна Поляна ",
                Kod="632",
                s="3004494"
                },new StopModel()
                {
                Name=" Балканкар АД ",
                Kod="567",
                s="3002945"
                },new StopModel()
                {
                Name=" ул. Президент Линкълн ",
                Kod="2067",
                s="3002957"
                },new StopModel()
                {
                Name=" УЛ. НАРОДНО ХОРО ",
                Kod="2055",
                s="3002965"
                },new StopModel()
                {
                Name=" НЦ по Рехабилитация ",
                Kod="96",
                s="3002981"
                },new StopModel()
                {
                Name=" КВ. ОВЧА КУПЕЛ ",
                Kod="881",
                s="3002476"
                },new StopModel()
                {
                Name=" КВ. ПАВЛОВО ",
                Kod="891",
                s="3002345"
                },new StopModel()
                {
                Name=" БУЛ. НИКОЛА ПЕТКОВ ",
                Kod="348",
                s="3002333"
                },}
                },}},
                                new BusModel()
                {
                Number = "12",
                lid = "3000033",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Кв.Илиянци - Пл.Журналист",
                rid="3000553",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Кв.Илиянци",
                Kod="848",
                s="3004145"
                },new StopModel()
                {
                Name="Ул.Кирил Благоев ",
                Kod="1988",
                s="3004135"
                },new StopModel()
                {
                Name="Ул.Грозден ",
                Kod="1916",
                s="3004123"
                },new StopModel()
                {
                Name="Хюндай България ",
                Kod="1635",
                s="3004101"
                },new StopModel()
                {
                Name="Стоков базар Илиянци ",
                Kod="755",
                s="3004036"
                },new StopModel()
                {
                Name="Софарма АД ",
                Kod="744",
                s="3004030"
                },new StopModel()
                {
                Name="ЗАГ Динамик ",
                Kod="728",
                s="3004022"
                },new StopModel()
                {
                Name="Бул.Рожен ",
                Kod="546",
                s="3004008"
                },new StopModel()
                {
                Name="Модна къща Агресия ",
                Kod="540",
                s="3003996"
                },new StopModel()
                {
                Name=" Кв.Триъгълника ",
                Kod="1776",
                s="3004171"
                },new StopModel()
                {
                Name=" Пета градска болница ",
                Kod="1254",
                s="3001226"
                },new StopModel()
                {
                Name=" Централна гара ",
                Kod="1329",
                s="3003232"
                },new StopModel()
                {
                Name=" Ул.Козлодуй ",
                Kod="2003",
                s="3003258"
                },new StopModel()
                {
                Name=" Пл.Лъвов мост ",
                Kod="1276",
                s="3003201"
                },new StopModel()
                {
                Name=" Централни хали ",
                Kod="2337",
                s="3003183"
                },new StopModel()
                {
                Name=" Пл.Света Неделя ",
                Kod="1308",
                s="3002171"
                },new StopModel()
                {
                Name=" Пл. Гарибалди ",
                Kod="1996",
                s="3002075"
                },new StopModel()
                {
                Name=" Пл. Славейков ",
                Kod="1908",
                s="3002061"
                },new StopModel()
                {
                Name=" Бул.Васил Левски ",
                Kod="299",
                s="3002041"
                },new StopModel()
                {
                Name=" УАСГ ",
                Kod="386",
                s="3004533"
                },new StopModel()
                {
                Name=" Пл.Журналист ",
                Kod="1273",
                s="3002091"
                },}
                },new DirectionModel()
                {
                Name ="Пл.Журналист - Кв.Илиянци",
                rid="3000554",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Пл.Журналист",
                Kod="1274",
                s="3001994"
                },new StopModel()
                {
                Name="УАСГ ",
                Kod="387",
                s="3004534"
                },new StopModel()
                {
                Name="Бул.Васил Левски ",
                Kod="300",
                s="3002038"
                },new StopModel()
                {
                Name="Пл. Славейков ",
                Kod="1909",
                s="3002060"
                },new StopModel()
                {
                Name="Пл. Гарибалди ",
                Kod="1997",
                s="3002076"
                },new StopModel()
                {
                Name="Пл.Света Неделя ",
                Kod="1307",
                s="3002170"
                },new StopModel()
                {
                Name="Централни хали ",
                Kod="2336",
                s="3003180"
                },new StopModel()
                {
                Name="Пл.Лъвов мост ",
                Kod="1277",
                s="3003202"
                },new StopModel()
                {
                Name="Ул.Козлодуй ",
                Kod="2002",
                s="3003255"
                },new StopModel()
                {
                Name=" Площад Централна гара ",
                Kod="1332",
                s="3004833"
                },new StopModel()
                {
                Name=" Пета градска болница ",
                Kod="1255",
                s="3001227"
                },new StopModel()
                {
                Name=" Кв.Триъгълника ",
                Kod="1775",
                s="3004169"
                },new StopModel()
                {
                Name=" Модна къща Агресия ",
                Kod="541",
                s="3003997"
                },new StopModel()
                {
                Name=" Бул.Рожен ",
                Kod="547",
                s="3004005"
                },new StopModel()
                {
                Name=" ЗАГ Динамик ",
                Kod="727",
                s="3004025"
                },new StopModel()
                {
                Name=" Софарма АД ",
                Kod="745",
                s="3004031"
                },new StopModel()
                {
                Name=" Стоков базар Илиянци ",
                Kod="754",
                s="3004039"
                },new StopModel()
                {
                Name=" Хюндай България ",
                Kod="1636",
                s="3004104"
                },new StopModel()
                {
                Name=" Ул.Грозден ",
                Kod="1915",
                s="3004124"
                },new StopModel()
                {
                Name=" Ул.Кирил Благоев ",
                Kod="1987",
                s="3004136"
                },new StopModel()
                {
                Name=" Кв.Илиянци ",
                Kod="847",
                s="3004150"
                },}
                },}},
                                new BusModel()
                {
                Number = "18",
                lid = "3000034",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Руско посолство - Кв.Орландовци",
                rid="3000660",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Руско посолство",
                Kod="1494",
                s="3001820"
                },new StopModel()
                {
                Name="Телевизионна кула ",
                Kod="1731",
                s="3001794"
                },new StopModel()
                {
                Name="Семинарията ",
                Kod="1570",
                s="3001594"
                },new StopModel()
                {
                Name="Ул.Вишнева ",
                Kod="1879",
                s="3004535"
                },new StopModel()
                {
                Name="Пл.Журналист ",
                Kod="1274",
                s="3001994"
                },new StopModel()
                {
                Name="УАСГ ",
                Kod="387",
                s="3004534"
                },new StopModel()
                {
                Name="Бул.Васил Левски ",
                Kod="300",
                s="3002038"
                },new StopModel()
                {
                Name="Пл. Славейков ",
                Kod="1909",
                s="3002060"
                },new StopModel()
                {
                Name="Пл. Гарибалди ",
                Kod="1997",
                s="3002076"
                },new StopModel()
                {
                Name=" Пл.Света Неделя ",
                Kod="1307",
                s="3002170"
                },new StopModel()
                {
                Name=" Централни хали ",
                Kod="2336",
                s="3003180"
                },new StopModel()
                {
                Name=" Пл.Лъвов мост ",
                Kod="1277",
                s="3003202"
                },new StopModel()
                {
                Name=" Ул.Козлодуй ",
                Kod="2001",
                s="3004529"
                },new StopModel()
                {
                Name=" Ул. Дунав ",
                Kod="1939",
                s="3003126"
                },new StopModel()
                {
                Name=" Хладилен завод ",
                Kod="2310",
                s="3003100"
                },new StopModel()
                {
                Name=" Централен гробищен парк ",
                Kod="2333",
                s="3003084"
                },new StopModel()
                {
                Name=" Католически гробищен парк ",
                Kod="797",
                s="3003070"
                },new StopModel()
                {
                Name=" Кв.Орландовци ",
                Kod="885",
                s="3003149"
                },}
                },new DirectionModel()
                {
                Name ="Кв.Орландовци - Руско посолство",
                rid="3000659",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Кв.Орландовци",
                Kod="886",
                s="3003151"
                },new StopModel()
                {
                Name="Католически гробищен парк ",
                Kod="796",
                s="3003071"
                },new StopModel()
                {
                Name="Централен гробищен парк ",
                Kod="2332",
                s="3003085"
                },new StopModel()
                {
                Name="Хладилен завод ",
                Kod="2311",
                s="3003101"
                },new StopModel()
                {
                Name="Ул. Дунав ",
                Kod="1940",
                s="3003127"
                },new StopModel()
                {
                Name="Ул.Козлодуй ",
                Kod="2000",
                s="3004530"
                },new StopModel()
                {
                Name="Пл.Лъвов мост ",
                Kod="1276",
                s="3003201"
                },new StopModel()
                {
                Name="Централни хали ",
                Kod="2337",
                s="3003183"
                },new StopModel()
                {
                Name="Пл.Света Неделя ",
                Kod="1308",
                s="3002171"
                },new StopModel()
                {
                Name=" Пл. Гарибалди ",
                Kod="1996",
                s="3002075"
                },new StopModel()
                {
                Name=" Пл. Славейков ",
                Kod="1908",
                s="3002061"
                },new StopModel()
                {
                Name=" Бул.Васил Левски ",
                Kod="299",
                s="3002041"
                },new StopModel()
                {
                Name=" УАСГ ",
                Kod="386",
                s="3004533"
                },new StopModel()
                {
                Name=" Пл.Журналист ",
                Kod="1273",
                s="3002091"
                },new StopModel()
                {
                Name=" Ул.Вишнева ",
                Kod="1880",
                s="3001516"
                },new StopModel()
                {
                Name=" Семинарията ",
                Kod="1573",
                s="3001595"
                },new StopModel()
                {
                Name=" Телевизионна кула ",
                Kod="1732",
                s="3001795"
                },new StopModel()
                {
                Name=" Руско посолство ",
                Kod="1495",
                s="3001821"
                },}
                },}},
                                new BusModel()
                {
                Number = "19",
                lid = "3000031",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Гара София север - Кв.Княжево",
                rid="3001042",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Гара София север",
                Kod="476",
                s="3003986"
                },new StopModel()
                {
                Name="Модна къща Агресия ",
                Kod="375",
                s="3004088"
                },new StopModel()
                {
                Name="Кв.Триъгълника ",
                Kod="1776",
                s="3004171"
                },new StopModel()
                {
                Name="Надлез Надежда ",
                Kod="2115",
                s="3003792"
                },new StopModel()
                {
                Name="Ул.Йосиф Щросмайер ",
                Kod="1969",
                s="3003784"
                },new StopModel()
                {
                Name="Ул.Пловдив ",
                Kod="2420",
                s="3003772"
                },new StopModel()
                {
                Name="Ул.Цар Симеон ",
                Kod="2250",
                s="3003768"
                },new StopModel()
                {
                Name="Метростанция К.Величков ",
                Kod="1051",
                s="3000680"
                },new StopModel()
                {
                Name="БУЛ. АЛЕКСАНДЪР СТАМБОЛИЙСКИ ",
                Kod="285",
                s="3000466"
                },new StopModel()
                {
                Name=" ПАРК СВ.СВ. ПЕТЪР И ПАВЕЛ ",
                Kod="1248",
                s="3000458"
                },new StopModel()
                {
                Name=" БУЛ. ВЪЗКРЕСЕНИЕ ",
                Kod="305",
                s="3000506"
                },new StopModel()
                {
                Name=" УЛ.ОСВОБОЖДЕНИЕ ",
                Kod="2099",
                s="3000440"
                },new StopModel()
                {
                Name=" БУЛ. ВАРДАР ",
                Kod="294",
                s="3000424"
                },new StopModel()
                {
                Name=" УЛ. ДОБРОТИЧ ",
                Kod="1932",
                s="3000678"
                },new StopModel()
                {
                Name=" сп. Красна Поляна ",
                Kod="632",
                s="3004494"
                },new StopModel()
                {
                Name=" Балканкар АД ",
                Kod="567",
                s="3002945"
                },new StopModel()
                {
                Name=" ул. Президент Линкълн ",
                Kod="2067",
                s="3002957"
                },new StopModel()
                {
                Name=" УЛ. НАРОДНО ХОРО ",
                Kod="2055",
                s="3002965"
                },new StopModel()
                {
                Name=" НЦ по Рехабилитация ",
                Kod="96",
                s="3002981"
                },new StopModel()
                {
                Name=" КВ. ОВЧА КУПЕЛ ",
                Kod="881",
                s="3002476"
                },new StopModel()
                {
                Name=" КВ. ПАВЛОВО ",
                Kod="891",
                s="3002345"
                },new StopModel()
                {
                Name=" БУЛ. НИКОЛА ПЕТКОВ ",
                Kod="348",
                s="3002333"
                },new StopModel()
                {
                Name=" Ул.Планинец ",
                Kod="2103",
                s="3002548"
                },new StopModel()
                {
                Name=" Райска градина ",
                Kod="2261",
                s="3002538"
                },new StopModel()
                {
                Name=" Кв.Княжево ",
                Kod="851",
                s="3002558"
                },}
                },new DirectionModel()
                {
                Name ="Кв.Княжево - Гара София север",
                rid="3001043",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Кв.Княжево",
                Kod="852",
                s="3002568"
                },new StopModel()
                {
                Name="Райска градина ",
                Kod="2260",
                s="3002541"
                },new StopModel()
                {
                Name="Ул.Планинец ",
                Kod="2104",
                s="3002547"
                },new StopModel()
                {
                Name="БУЛ. НИКОЛА ПЕТКОВ ",
                Kod="349",
                s="3002332"
                },new StopModel()
                {
                Name="КВ. ПАВЛОВО ",
                Kod="892",
                s="3002346"
                },new StopModel()
                {
                Name="КВ. ОВЧА КУПЕЛ ",
                Kod="879",
                s="3002490"
                },new StopModel()
                {
                Name="НЦ по рехабилитация ",
                Kod="97",
                s="3002978"
                },new StopModel()
                {
                Name="УЛ. НАРОДНО ХОРО ",
                Kod="2056",
                s="3002964"
                },new StopModel()
                {
                Name="ул. Президент Линкълн ",
                Kod="2068",
                s="3002956"
                },new StopModel()
                {
                Name=" Балканкар АД ",
                Kod="568",
                s="3002944"
                },new StopModel()
                {
                Name=" Ж.К. КРАСНА ПОЛЯНА ",
                Kod="634",
                s="3002930"
                },new StopModel()
                {
                Name=" УЛ. ДОБРОТИЧ ",
                Kod="1933",
                s="3000679"
                },new StopModel()
                {
                Name=" БУЛ. ВАРДАР ",
                Kod="295",
                s="3000423"
                },new StopModel()
                {
                Name=" УЛ.ОСВОБОЖДЕНИЕ ",
                Kod="2098",
                s="3000441"
                },new StopModel()
                {
                Name=" БУЛ. ВЪЗКРЕСЕНИЕ ",
                Kod="306",
                s="3000447"
                },new StopModel()
                {
                Name=" ПАРК СВ. СВ. ПЕТЪР И ПАВЕЛ ",
                Kod="1247",
                s="3000459"
                },new StopModel()
                {
                Name=" БУЛ. АЛЕКСАНДЪР СТАМБОЛИЙСКИ ",
                Kod="286",
                s="3000467"
                },new StopModel()
                {
                Name=" Метростанция К.Величков ",
                Kod="1050",
                s="3000681"
                },new StopModel()
                {
                Name=" Ул.Цар Симеон ",
                Kod="2249",
                s="3003769"
                },new StopModel()
                {
                Name=" Ул.Пловдив ",
                Kod="2421",
                s="3003773"
                },new StopModel()
                {
                Name=" Ул.Йосиф Щросмайер ",
                Kod="1970",
                s="3003781"
                },new StopModel()
                {
                Name=" Надлез Надежда ",
                Kod="359",
                s="3003801"
                },new StopModel()
                {
                Name=" Кв.Триъгълника ",
                Kod="1775",
                s="3004169"
                },new StopModel()
                {
                Name=" Модна къща Агресия ",
                Kod="374",
                s="3003993"
                },new StopModel()
                {
                Name=" Гара София север ",
                Kod="477",
                s="3003982"
                },}
                },}},
                                new BusModel()
                {
                Number = "20",
                lid = "3000020",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Метростанция Опълченска - Депо Искър",
                rid="3000008",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Метростанция Опълченска",
                Kod="1058",
                s="3000338"
                },new StopModel()
                {
                Name="Бул.Христо Ботев ",
                Kod="384",
                s="3000076"
                },new StopModel()
                {
                Name="Женски пазар ",
                Kod="378",
                s="3000079"
                },new StopModel()
                {
                Name="Централни хали ",
                Kod="2334",
                s="3000085"
                },new StopModel()
                {
                Name="Младежки театър ",
                Kod="1073",
                s="3000389"
                },new StopModel()
                {
                Name="Народна опера ",
                Kod="1115",
                s="3000090"
                },new StopModel()
                {
                Name="Бул.Васил Левски ",
                Kod="298",
                s="3000092"
                },new StopModel()
                {
                Name="Ул.Сан Стефано ",
                Kod="2168",
                s="3000095"
                },new StopModel()
                {
                Name="Театър София ",
                Kod="1727",
                s="3000097"
                },new StopModel()
                {
                Name=" Ул.Алеко Константинов ",
                Kod="1821",
                s="3000099"
                },new StopModel()
                {
                Name=" Гара Подуяне ",
                Kod="470",
                s="3000101"
                },new StopModel()
                {
                Name=" Ул.Оборище ",
                Kod="2073",
                s="3000106"
                },new StopModel()
                {
                Name=" Румънско посолство ",
                Kod="1491",
                s="3000114"
                },new StopModel()
                {
                Name=" Ул.Хемус ",
                Kod="2235",
                s="3000116"
                },new StopModel()
                {
                Name=" Ул.Александър Жендов ",
                Kod="1823",
                s="3000119"
                },new StopModel()
                {
                Name=" Ул.Н.Коперник ",
                Kod="2060",
                s="3000124"
                },new StopModel()
                {
                Name=" НУ по танцово изкуство ",
                Kod="720",
                s="3000129"
                },new StopModel()
                {
                Name=" Ж.к.Гео Милев ",
                Kod="595",
                s="3000132"
                },new StopModel()
                {
                Name=" СК ЦСКА ",
                Kod="1154",
                s="3000138"
                },new StopModel()
                {
                Name=" Бул.проф.Цв.Лазаров ",
                Kod="367",
                s="3000141"
                },new StopModel()
                {
                Name=" Ул.кап.Д.Списаревси ",
                Kod="1979",
                s="3000143"
                },new StopModel()
                {
                Name=" Разклона за летището ",
                Kod="1454",
                s="3000145"
                },new StopModel()
                {
                Name=" Ж.к.Дружба-1 ",
                Kod="606",
                s="3000148"
                },new StopModel()
                {
                Name=" Бул.Кръстьо Пастухов ",
                Kod="1630",
                s="3000150"
                },new StopModel()
                {
                Name=" 28-ми ДКЦ ",
                Kod="27",
                s="3000152"
                },new StopModel()
                {
                Name=" 28-ми пощенски клон ",
                Kod="1409",
                s="3000155"
                },new StopModel()
                {
                Name=" кв.Гара Искър ",
                Kod="36",
                s="3000157"
                },new StopModel()
                {
                Name=" София МЕД АД ",
                Kod="1593",
                s="3000159"
                },new StopModel()
                {
                Name=" Депо Искър ",
                Kod="519",
                s="3000160"
                },}
                },new DirectionModel()
                {
                Name ="Депо Искър - Метростанция Опълченска",
                rid="3000652",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Депо Искър",
                Kod="518",
                s="3000161"
                },new StopModel()
                {
                Name="София МЕД АД ",
                Kod="1594",
                s="3000162"
                },new StopModel()
                {
                Name="кв.Гара Искър ",
                Kod="35",
                s="3000164"
                },new StopModel()
                {
                Name="28-ми пощенски клон ",
                Kod="1410",
                s="3000166"
                },new StopModel()
                {
                Name="28-ми ДКЦ ",
                Kod="26",
                s="3000169"
                },new StopModel()
                {
                Name="Бул.Кръстю Пастухов ",
                Kod="1631",
                s="3000171"
                },new StopModel()
                {
                Name="Ж.к.Дружба-1 ",
                Kod="607",
                s="3000173"
                },new StopModel()
                {
                Name="Разклона за летището ",
                Kod="1453",
                s="3000176"
                },new StopModel()
                {
                Name="Ул.кап.Д.Списаревски ",
                Kod="1980",
                s="3000178"
                },new StopModel()
                {
                Name=" Бул.проф.Цв.Лазаров ",
                Kod="368",
                s="3000180"
                },new StopModel()
                {
                Name=" СК ЦСКА ",
                Kod="1153",
                s="3000183"
                },new StopModel()
                {
                Name=" Ж.к.Гео Милев ",
                Kod="597",
                s="3000188"
                },new StopModel()
                {
                Name=" НУ за танцово изкуство ",
                Kod="719",
                s="3000191"
                },new StopModel()
                {
                Name=" Ул.Н.Коперник ",
                Kod="2059",
                s="3000197"
                },new StopModel()
                {
                Name=" Ул.Александър Жендов ",
                Kod="1824",
                s="3000202"
                },new StopModel()
                {
                Name=" Ул.Хемус ",
                Kod="2234",
                s="3000205"
                },new StopModel()
                {
                Name=" Румънско посолство ",
                Kod="1490",
                s="3000207"
                },new StopModel()
                {
                Name=" Ул.Оборище ",
                Kod="2072",
                s="3000215"
                },new StopModel()
                {
                Name=" Гара Подуяне ",
                Kod="469",
                s="3000373"
                },new StopModel()
                {
                Name=" Ул.Алеко Константинов ",
                Kod="1822",
                s="3000222"
                },new StopModel()
                {
                Name=" Театър София ",
                Kod="1726",
                s="3000224"
                },new StopModel()
                {
                Name=" Ул.Сан Стефано ",
                Kod="2169",
                s="3000226"
                },new StopModel()
                {
                Name=" Бул.Васил Левски ",
                Kod="297",
                s="3000229"
                },new StopModel()
                {
                Name=" Народна опера ",
                Kod="1116",
                s="3000231"
                },new StopModel()
                {
                Name=" Младежки театър ",
                Kod="1074",
                s="3000343"
                },new StopModel()
                {
                Name=" Централни хали ",
                Kod="2335",
                s="3000236"
                },new StopModel()
                {
                Name=" Женски пазар ",
                Kod="379",
                s="3000242"
                },new StopModel()
                {
                Name=" Бул.Христо Ботев ",
                Kod="383",
                s="3000244"
                },new StopModel()
                {
                Name=" Метростанция Опълченска ",
                Kod="1058",
                s="3000338"
                },}
                },}},
                                new BusModel()
                {
                Number = "22",
                lid = "3000022",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="ж.к. Красна Поляна - Автостанция Изток",
                rid="3000004",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="ж.к. Красна Поляна",
                Kod="633",
                s="3000501"
                },new StopModel()
                {
                Name="УЛ. ДОБРОТИЧ ",
                Kod="1933",
                s="3000679"
                },new StopModel()
                {
                Name="БУЛ. ВАРДАР ",
                Kod="295",
                s="3000423"
                },new StopModel()
                {
                Name="УЛ.ОСВОБОЖДЕНИЕ ",
                Kod="2098",
                s="3000441"
                },new StopModel()
                {
                Name="БУЛ. ВЪЗКРЕСЕНИЕ ",
                Kod="306",
                s="3000447"
                },new StopModel()
                {
                Name="ПАРК СВ. СВ. ПЕТЪР И ПАВЕЛ ",
                Kod="1247",
                s="3000459"
                },new StopModel()
                {
                Name="БУЛ. АЛЕКСАНДЪР СТАМБОЛИЙСКИ ",
                Kod="286",
                s="3000467"
                },new StopModel()
                {
                Name="Метростанция К.Величков ",
                Kod="1050",
                s="3000681"
                },new StopModel()
                {
                Name="Ул.Димитър Петков ",
                Kod="1927",
                s="3000479"
                },new StopModel()
                {
                Name=" Ул.Одрин ",
                Kod="2077",
                s="3000485"
                },new StopModel()
                {
                Name=" Ул.Опълченска ",
                Kod="2086",
                s="3000493"
                },new StopModel()
                {
                Name=" Бул.Христо Ботев ",
                Kod="384",
                s="3000076"
                },new StopModel()
                {
                Name=" Женски пазар ",
                Kod="378",
                s="3000079"
                },new StopModel()
                {
                Name=" Централни хали ",
                Kod="2334",
                s="3000085"
                },new StopModel()
                {
                Name=" Младежки театър ",
                Kod="1073",
                s="3000389"
                },new StopModel()
                {
                Name=" Народна опера ",
                Kod="1115",
                s="3000090"
                },new StopModel()
                {
                Name=" Бул.Васил Левски ",
                Kod="298",
                s="3000092"
                },new StopModel()
                {
                Name=" Ул.Сан Стефано ",
                Kod="2168",
                s="3000095"
                },new StopModel()
                {
                Name=" Театър София ",
                Kod="1727",
                s="3000097"
                },new StopModel()
                {
                Name=" Ул.Алеко Константинов ",
                Kod="1821",
                s="3000099"
                },new StopModel()
                {
                Name=" Гара Подуяне ",
                Kod="470",
                s="3000101"
                },new StopModel()
                {
                Name=" Гара Подуяне ",
                Kod="472",
                s="3000393"
                },new StopModel()
                {
                Name=" Пл. Пирдоп ",
                Kod="1293",
                s="3000684"
                },new StopModel()
                {
                Name=" Бл.4 ж.к.Сухата река ",
                Kod="410",
                s="3000549"
                },new StopModel()
                {
                Name=" Ул. Витиня ",
                Kod="1873",
                s="3000557"
                },new StopModel()
                {
                Name=" Ул. Рилска Обител ",
                Kod="2160",
                s="3000685"
                },new StopModel()
                {
                Name=" Ул.Поп Груйо ",
                Kod="2130",
                s="3000687"
                },new StopModel()
                {
                Name=" Автостанция Изток ",
                Kod="2023",
                s="3000577"
                },}
                },new DirectionModel()
                {
                Name ="Автостанция Изток - депо Кр. поляна",
                rid="3000003",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Автостанция Изток",
                Kod="2022",
                s="3000677"
                },new StopModel()
                {
                Name="Ул.Поп Груйо ",
                Kod="2129",
                s="3000686"
                },new StopModel()
                {
                Name="Ул. Рилска Обител ",
                Kod="2159",
                s="3000562"
                },new StopModel()
                {
                Name="Ул. Витиня ",
                Kod="1872",
                s="3000554"
                },new StopModel()
                {
                Name="Бл.4 ж.к.Сухата река ",
                Kod="411",
                s="3000548"
                },new StopModel()
                {
                Name="Пл. Пирдоп ",
                Kod="1292",
                s="3000683"
                },new StopModel()
                {
                Name="Гара Подуяне ",
                Kod="473",
                s="3000220"
                },new StopModel()
                {
                Name="Гара Подуяне ",
                Kod="469",
                s="3000373"
                },new StopModel()
                {
                Name="Ул.Алеко Константинов ",
                Kod="1822",
                s="3000222"
                },new StopModel()
                {
                Name=" Театър София ",
                Kod="1726",
                s="3000224"
                },new StopModel()
                {
                Name=" Ул.Сан Стефано ",
                Kod="2169",
                s="3000226"
                },new StopModel()
                {
                Name=" Бул.Васил Левски ",
                Kod="297",
                s="3000229"
                },new StopModel()
                {
                Name=" Народна опера ",
                Kod="1116",
                s="3000231"
                },new StopModel()
                {
                Name=" Младежки театър ",
                Kod="1074",
                s="3000343"
                },new StopModel()
                {
                Name=" Централни хали ",
                Kod="2335",
                s="3000236"
                },new StopModel()
                {
                Name=" Женски пазар ",
                Kod="379",
                s="3000242"
                },new StopModel()
                {
                Name=" Бул.Христо Ботев ",
                Kod="383",
                s="3000244"
                },new StopModel()
                {
                Name=" Ул.Опълченска ",
                Kod="2083",
                s="3000492"
                },new StopModel()
                {
                Name=" Ул.Одрин ",
                Kod="2078",
                s="3000484"
                },new StopModel()
                {
                Name=" Ул.Димитър Петков ",
                Kod="1928",
                s="3000682"
                },new StopModel()
                {
                Name=" Метростанция К.Величков ",
                Kod="1051",
                s="3000680"
                },new StopModel()
                {
                Name=" БУЛ. АЛЕКСАНДЪР СТАМБОЛИЙСКИ ",
                Kod="285",
                s="3000466"
                },new StopModel()
                {
                Name=" ПАРК СВ.СВ. ПЕТЪР И ПАВЕЛ ",
                Kod="1248",
                s="3000458"
                },new StopModel()
                {
                Name=" БУЛ. ВЪЗКРЕСЕНИЕ ",
                Kod="305",
                s="3000506"
                },new StopModel()
                {
                Name=" УЛ.ОСВОБОЖДЕНИЕ ",
                Kod="2099",
                s="3000440"
                },new StopModel()
                {
                Name=" БУЛ. ВАРДАР ",
                Kod="294",
                s="3000424"
                },new StopModel()
                {
                Name=" УЛ. ДОБРОТИЧ ",
                Kod="1932",
                s="3000678"
                },new StopModel()
                {
                Name=" депо Кр. поляна ",
                Kod="632",
                s="3000660"
                },}
                },}},
                                new BusModel()
                {
                Number = "23",
                lid = "3000050",
                Directions= new DirectionModel[]
                {
                new DirectionModel()
                {
                Name ="Младежки театър - Ж.к.Дружба 2",
                rid="3001196",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Младежки театър",
                Kod="1073",
                s="3000389"
                },new StopModel()
                {
                Name="Народна опера ",
                Kod="1115",
                s="3000090"
                },new StopModel()
                {
                Name="Бул.Васил Левски ",
                Kod="298",
                s="3000092"
                },new StopModel()
                {
                Name="Ул.Сан Стефано ",
                Kod="2168",
                s="3000095"
                },new StopModel()
                {
                Name="Театър София ",
                Kod="1727",
                s="3000097"
                },new StopModel()
                {
                Name="Ул.Алеко Константинов ",
                Kod="1821",
                s="3000099"
                },new StopModel()
                {
                Name="Гара Подуяне ",
                Kod="470",
                s="3000101"
                },new StopModel()
                {
                Name="Ул.Оборище ",
                Kod="2073",
                s="3000106"
                },new StopModel()
                {
                Name="Румънско посолство ",
                Kod="1491",
                s="3000114"
                },new StopModel()
                {
                Name=" Ул.Хемус ",
                Kod="2235",
                s="3000116"
                },new StopModel()
                {
                Name=" Ул.Александър Жендов ",
                Kod="1823",
                s="3000119"
                },new StopModel()
                {
                Name=" Ул.Н.Коперник ",
                Kod="2060",
                s="3000124"
                },new StopModel()
                {
                Name=" НУ по танцово изкуство ",
                Kod="720",
                s="3000129"
                },new StopModel()
                {
                Name=" Ж.к.Гео Милев ",
                Kod="595",
                s="3000132"
                },new StopModel()
                {
                Name=" СК ЦСКА ",
                Kod="1154",
                s="3000138"
                },new StopModel()
                {
                Name=" Бул.проф.Цв.Лазаров ",
                Kod="367",
                s="3000141"
                },new StopModel()
                {
                Name=" Ул.кап.Д.Списаревси ",
                Kod="1979",
                s="3000143"
                },new StopModel()
                {
                Name=" Разклона за летището ",
                Kod="1454",
                s="3000145"
                },new StopModel()
                {
                Name=" Ж.к.Дружба-1 ",
                Kod="606",
                s="3000148"
                },new StopModel()
                {
                Name=" Бул.Кръстьо Пастухов ",
                Kod="1630",
                s="3000150"
                },new StopModel()
                {
                Name=" 28-ми ДКЦ ",
                Kod="27",
                s="3000152"
                },new StopModel()
                {
                Name=" 28-ми пощенски клон ",
                Kod="1409",
                s="3000155"
                },new StopModel()
                {
                Name=" Ул.Искърско шосе ",
                Kod="2583",
                s="3005419"
                },new StopModel()
                {
                Name=" Ул.Мюнхен ",
                Kod="2585",
                s="3005423"
                },new StopModel()
                {
                Name=" Ул.Амстердам ",
                Kod="2587",
                s="3005428"
                },new StopModel()
                {
                Name=" Бул.проф.Цв.Лазаров ",
                Kod="2589",
                s="3005433"
                },new StopModel()
                {
                Name=" Ж.к.Дружба 2 ",
                Kod="6213",
                s="3005401"
                },}
                },new DirectionModel()
                {
                Name ="Ж.к.Дружба 2 - Младежки театър",
                rid="3001197",
                Stops=new StopModel[]
                {new StopModel()
                {
                Name="Младежки театър",
                Kod="1074",
                s="3000343"
                },new StopModel()
                {
                Name="Бул.проф.Цветан Лазаров ",
                Kod="2588",
                s="3005402"
                },new StopModel()
                {
                Name="Ул.Амстердам ",
                Kod="2586",
                s="3005403"
                },new StopModel()
                {
                Name="Ул.Мюнхен ",
                Kod="2584",
                s="3005404"
                },new StopModel()
                {
                Name="Ул.Искърско шосе ",
                Kod="2582",
                s="3005405"
                },new StopModel()
                {
                Name="28-ми пощенски клон ",
                Kod="1410",
                s="3000166"
                },new StopModel()
                {
                Name="28-ми ДКЦ ",
                Kod="26",
                s="3000169"
                },new StopModel()
                {
                Name="Бул.Кръстю Пастухов ",
                Kod="1631",
                s="3000171"
                },new StopModel()
                {
                Name="Ж.к.Дружба-1 ",
                Kod="607",
                s="3000173"
                },new StopModel()
                {
                Name=" Разклона за летището ",
                Kod="1453",
                s="3000176"
                },new StopModel()
                {
                Name=" Ул.кап.Д.Списаревски ",
                Kod="1980",
                s="3000178"
                },new StopModel()
                {
                Name=" Бул.проф.Цв.Лазаров ",
                Kod="368",
                s="3000180"
                },new StopModel()
                {
                Name=" СК ЦСКА ",
                Kod="1153",
                s="3000183"
                },new StopModel()
                {
                Name=" Ж.к.Гео Милев ",
                Kod="597",
                s="3000188"
                },new StopModel()
                {
                Name=" НУ за танцово изкуство ",
                Kod="719",
                s="3000191"
                },new StopModel()
                {
                Name=" Ул.Н.Коперник ",
                Kod="2059",
                s="3000197"
                },new StopModel()
                {
                Name=" Ул.Александър Жендов ",
                Kod="1824",
                s="3000202"
                },new StopModel()
                {
                Name=" Ул.Хемус ",
                Kod="2234",
                s="3000205"
                },new StopModel()
                {
                Name=" Румънско посолство ",
                Kod="1490",
                s="3000207"
                },new StopModel()
                {
                Name=" Ул.Оборище ",
                Kod="2072",
                s="3000215"
                },new StopModel()
                {
                Name=" Гара Подуяне ",
                Kod="469",
                s="3000373"
                },new StopModel()
                {
                Name=" Ул.Алеко Константинов ",
                Kod="1822",
                s="3000222"
                },new StopModel()
                {
                Name=" Театър София ",
                Kod="1726",
                s="3000224"
                },new StopModel()
                {
                Name=" Ул.Сан Стефано ",
                Kod="2169",
                s="3000226"
                },new StopModel()
                {
                Name=" Бул.Васил Левски ",
                Kod="297",
                s="3000229"
                },new StopModel()
                {
                Name=" Народна опера ",
                Kod="1116",
                s="3000231"
                },new StopModel()
                {
                Name="Младежки театър",
                Kod="1074",
                s="3000389"
                },}
                },}},
            };
            return trams;
        }
    }
}
