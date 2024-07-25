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

        
       
        public  void SendDateToService(object sender, EventArgs e)

            {
            string  Day = DayBox.Text;
            string DayMonth = DayMonthBox.Text;
            string Month = MonthBox.Text;
            string Year = YearBox.Text;

           string result = CreateNewModelDate(Day, DayMonth, Month, Year);
            MessageBox.Show(result);
            }
        }

    }


