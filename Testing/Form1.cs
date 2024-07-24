using System.Windows.Forms;
using static Testing.Service.Service;
using static Testing.Model.DateModel;
using Testing.Model;
using System.Security.Cryptography.X509Certificates;
namespace Testing
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();

            }

        public string Days()
            {
            string day;
            switch (DayBox.Text)
                {
                case "�����":
                    day = "���� ����"; break;
                case "���":
                    day = "���� "; break;

                case "�����":
                    day = "������ "; break;
                case "�����":
                    day = "����� "; break;
                case "�����":
                    day = "������ "; break;
                case "����":
                    day = "���� "; break;
                default:
                    day = "";
                    break;
                }
            return $"{day} ����";
            }
        public string DayMonth()
            {
            int Days;
            int.TryParse(DayMonthBox.Text, out Days);
            Dictionary<int, string> DayMonth = new()
                {

                    {1,"��� ���" },
                    {2,"��� ����" },
                    {3,"���� ����" },
                    {4,"����� ����" },
                    {5,"����� ����" },


                };

            return $"{DayMonth[Days]} ����";

            }
        public string Month()
            {
            string DAEY = DayMonthBox.Text;
            int Days;
            switch (MonthBox.Text)
                {
                case "����":
                    Days = 1; break;
                case "�����":
                    Days = 2; break; ;

                case "�����":
                    Days = 3; break;
                case "���":
                    Days = 4; break;
                case "���":
                    Days = 5; break;
                case "��� �����":
                    Days = 6; break;
                case "��� ���":
                    Days = 7; break;
                default:
                    Days = 0;
                    break;
                }

            Dictionary<int, string> Month = new()
                {
                    {1,"����" },
                    {2,"�����" },
                    {3,"�����" },
                    {4,"���" },
                    {5,"���" },
                    {6,"��� �����" },
                    {7,"��� ���" },
                    {8,"����" },
                    {9,"����" },
                    {10,"�����" },
                    {11,"����" },
                    {12,"��" },
                    {13,"����" },

                };
            if (DAEY == "30")//����� ������� ����� ���� ��� ���� ���
                {
                if (Days < 13)
                    {
                    Days++;
                    }
                Days = 1;
                }
            return $"{Month[Days]}";


            }
        public string Years()
            {
            string years = YearBox.Text;
            string convertToAlfabate;
            switch (years)
                {
                case @"���""�":
                    convertToAlfabate = "���� ����� ���� ���� ������ �����";
                    break;
                case @"���""�":
                    convertToAlfabate = "���� ����� ������ ���� ������";
                    break;
                case @"���""�":
                    convertToAlfabate = "���� ����� ������ ���� ����";
                    break;
                default:
                    convertToAlfabate = "";
                    break;
                }
            return convertToAlfabate;




            }
        public string ResultDate()
            {
            MessageBox.Show($"{Days()} {DayMonth()} {Month()} {Years()} ������ �����");
            return $"{Days()} {DayMonth()} {Month()} {Years()} ������ �����";
            }
        public void CreateNewModelDate(object sender, EventArgs e)
            {
            string resultDate = ResultDate();
            DateModel NawDate = new(
                 Day: DayBox.Text, DayMonth: DayMonthBox.Text, Month: MonthBox.Text, Year: YearBox.Text, Result: resultDate);
            AddElementService(NawDate);

            }


        }

    }


