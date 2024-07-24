using System.Windows.Forms;
using System.Xml.Linq;

namespace HebrowDate
{
    public partial class Form1 : Form
    {
        public Dictionary<int, string> Days = new Dictionary<int, string>
        {
            {1, "יום אחד"},
            {2, "שני ימים"},
            {3, "שלשה ימים"},
            {4, "ארבעה ימים"},
            {5, "חמישה ימים"},
            {6, "שישה ימים"},
            {7, "שבעה ימים"},
            {8, "שמונה ימים"},
            {9, "תשעה ימים"},
            {10, "עשרה ימים"},
            {11, "אחד עשר יום"},
            {12, "שנים עשר יום"},
            {13, "שלשה עשר יום"},
            {14, "ארבעה עשר יום"},
            {15, "חמישה עשר יום"},
            {16, "ששה עשר יום"},
            {17, "שבעה עשר יום"},
            {18, "שמונה עשר יום"},
            {19, "תשעה עשר יום"},
            {20, "עשרים יום"},
            {21, "אחד ועשרים יום"},
            {22, "שניים ועשרים יום"},
            {23, "שלושה ועשרים יום"},
            {24, "ארבעה ועשרים יום"},
            {25, "חמישה ועשרים יום"},
            {26, "ששה ועשרים יום"},
            {27, "שבעה ועשרים יום"},
            {28, "שמונה ועשרים יום"},
            {29, "תשעה ועשרים יום"},
            {30, "יום שלשים"}
        };
        public Dictionary<int, string>  Months = new Dictionary<int, string>
        {
            {1, "תשרי"},
            {2, "מרחשון"},
            {3, "כסלו"},
            {4, "טבת"},
            {5, "שבט"},
            {6, "אדר"},
            {7, "אדר הראשון"},
            {8, "אדר השני"},
            {9, "ניסן"},
            {10, "אייר"},
            {11, "סיון"},
            {12, "תמוז"},
            {13, "אב"},
            {14, "אלול"}
        };
        public Dictionary<string, string> Years = new Dictionary<string, string>
        {
            {"תשפ\"ד", "חמשת אלפים ושבע מאות ושמנים וארבע"},
            {"תשפ\"ה", "חמשת אלפים ושבע מאות ושמנים וחמש"},
            {"תשפ\"ו", "חמשת אלפים ושבע מאות ושמנים ושש"},
            {"תשפ\"ז", "חמשת אלפים ושבע מאות ושמנים ושבע"},
            {"תשפ\"ח", "חמשת אלפים ושבע מאות ושמנים ושמונה"},
            {"תשפ\"ט", "חמשת אלפים ושבע מאות ושמנים ותשע"},
            {"תש\"צ", "חמשת אלפים ותשעים"},
            {"תשצ\"א", "חמשת אלפים ותשעים ואחת"},
            {"תשצ\"ב", "חמשת אלפים ותשעים ושתיים"},
            {"תשצ\"ג", "חמשת אלפים ותשעים ושלוש"}
        };


        public Form1()
        {
            InitializeComponent();
            IntializeComboBoxes();
        }
        public void IntializeComboBoxes()
        {
            //add days of the week
            comboBox_days.Items.Add("ראשון");
            comboBox_days.Items.Add("שני");
            comboBox_days.Items.Add("שלישי");
            comboBox_days.Items.Add("רביעי");
            comboBox_days.Items.Add("חמישי");
            comboBox_days.Items.Add("שישי");

            //add days of the month
            for (int i = 1; i <= 30; i++)
            {
                comboBox_month_days.Items.Add(i);
            }

            //add months
            List<string> months = new List<string>(Months.Values);
            foreach (string month in months)
            {
                comboBox_month.Items.Add(month);
            }


            //add years
            List<string> years = new List<string>(Years.Keys);
            foreach (string year in years)
            {
                comboBox_year.Items.Add(year);
            }


        }
        public string CreateQuery()
        {
            string dayOfWeek = comboBox_days.Text;
            string monthDay = Days[Convert.ToInt16(comboBox_month_days.Text)];
            string month = comboBox_month.Text;
            string year = Years[comboBox_year.Text];
            string fullQuery;

            if (dayOfWeek == "ראשון")
            {
                dayOfWeek = "אחד";
            }


            if (monthDay == "יום שלשים")
            {
                int monthIndex = comboBox_month.SelectedIndex;
                int indexToJmp = 0;
                switch (monthIndex)
                {
                    case 5:
                        indexToJmp = 4; 
                        break;
                    case 13:
                        indexToJmp = -12;
                        break;
                    default:
                        indexToJmp = 2;
                        break;
                }
                string newChodesh = Months[monthIndex + indexToJmp];
            
                fullQuery = $"ב{dayOfWeek} בשבת יום שלשים לחודש {month} שהוא ראש חודש {newChodesh} שנת {year} לבריאת העולם";
            }
            else
            {
                fullQuery = $"ב{dayOfWeek} בשבת {monthDay} לירח {month} שנת {year} לבריאת העולם";
            }
            return fullQuery;
        }
        public void writeTofile(string day, string monthDay, string month, string year, string query)
        {
            string path = "C:\\Users\\Owner\\source\\repos\\HebrowDate\\HebrowDate\\data.xml";

            XElement element = new XElement("Query", new XElement("Day", day), new XElement("DayMonth", monthDay),
                new XElement("Month", month), new XElement("Year", year), new XElement("Result", query)
                );

            XDocument doc = XDocument.Load(path);
            doc.Root.Add(element);
            doc.Save(path);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = CreateQuery();
            writeTofile(comboBox_days.Text, comboBox_month_days.Text, comboBox_month.Text, comboBox_year.Text, query);
            MessageBox.Show(query);

        }
    }
}
