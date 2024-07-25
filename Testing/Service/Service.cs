using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Testing.Confuguration.Configuration;
using Testing.Model;

namespace Testing.Service
    {

    public static class Service
        {
        public static void CreateIfNotExsis()
            {
            if (!File.Exists(Dates))
                {
                XDocument Document = new();
                XElement Element = new("Queries");
                Document.Add(Element);
                Document.Save(Dates);
                }
            }
        public static string AddElementService(DateModel model)
            {

            XDocument document = XDocument.Load(Dates);
            XElement? Date = document.Descendants("Queries")?.FirstOrDefault();
            if (Date is null)
                {
                return "";
                }
            Date.Add(new XElement("Query",new XElement("Day", model.Day),
            new XElement("DayMonth", model.DayMonth),
            new XElement("Month", model.Month),
            new XElement("Year", model.Year),
            new XElement("Result", model.Result)));
            document.Save(Dates);
            return $"{model.Result}";

            }
        public static string Days(string Day)
            {
            string day;
            switch (Day)
                {
                case "ראשון":
                    day = "באחד בשבת"; break;
                case "שני":
                    day = "בשני "; break;

                case "שלישי":
                    day = "בשלישי "; break;
                case "רביעי":
                    day = "רביעי "; break;
                case "חמישי":
                    day = "בחמישי "; break;
                case "שישי":
                    day = "בששי "; break;
                default:
                    day = "";
                    break;
                }
            return $"{day} בשבת";
            }
        public static string DayMonth(string month)
            {
            int Days;
            int.TryParse(month, out Days);
            Dictionary<int, string> DayMonth = new()
                {

                    {1,"יום אחד" },
                    {2,"שני ימים" },
                    {3,"שלשה ימים" },
                    {4,"ארבעה ימים" },
                    {5,"חמישה ימים" },


                };

            return $"{DayMonth[Days]} לירח";

            }
        public static string Month(string month)
            {

            int Days;
            switch (month)
                {
                case "תשרי":
                    Days = 1; break;
                case "חשוון":
                    Days = 2; break; ;

                case "כסליו":
                    Days = 3; break;
                case "טבת":
                    Days = 4; break;
                case "שבט":
                    Days = 5; break;
                case "אדר ראשון":
                    Days = 6; break;
                case "אדר שני":
                    Days = 7; break;
                default:
                    Days = 0;
                    break;
                }

            Dictionary<int, string> Month = new()
                {
                    {1,"תשרי" },
                    {2,"חשוון" },
                    {3,"כסליו" },
                    {4,"טבת" },
                    {5,"שבט" },
                    {6,"אדר ראשון" },
                    {7,"אדר שני" },
                    {8,"ניסן" },
                    {9,"אייר" },
                    {10,"סיוון" },
                    {11,"תמוז" },
                    {12,"אב" },
                    {13,"אלול" },

                };
            if (month == "30")//חישוב השלושים לחודש שהוא ראש חודש הבא
                {
                if (Days < 13)
                    {
                    Days++;
                    }
                Days = 1;
                }
            return $"{Month[Days]}";


            }
        public static string Year(string years)
            {

            string convertToAlfabate;
            switch (years)
                {
                case @"תשפ""ד":
                    convertToAlfabate = "חמשת אלפים ושבע מאות ושמנים וארבע";
                    break;
                case @"תשפ""ה":
                    convertToAlfabate = "חמשת אלפים ושמונה מאות וחמישה";
                    break;
                case @"תשפ""ו":
                    convertToAlfabate = "חמשת אלפים ושמונה מאות וששה";
                    break;
                default:
                    convertToAlfabate = "";
                    break;
                }
            return convertToAlfabate;




            }
        public static string ResultDate(string Day, string dayMonth, string month, string year)
            {

            return $"{Days(Day)} {DayMonth(dayMonth)} {Month(month)} {Year(year)} לבריאת העולם";
            }
        public static string CreateNewModelDate(string day, string dayMonth, string month, string year)
            {
            string resultDate = ResultDate(day, dayMonth, month, year);
            DateModel NawDate = new(
                 Day: day, DayMonth: dayMonth, Month: month, Year: year, Result: resultDate);
            string res = AddElementService(NawDate);
            return res;
            //test comment
            }

        }
    }