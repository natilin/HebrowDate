using System.Windows.Forms;
using System.Xml.Linq;

namespace HebrowDate
{
    public partial class Form1 : Form
    {
        public Dictionary<int, string> Days = new Dictionary<int, string>
        {
            {1, "��� ���"},
            {2, "��� ����"},
            {3, "���� ����"},
            {4, "����� ����"},
            {5, "����� ����"},
            {6, "���� ����"},
            {7, "���� ����"},
            {8, "����� ����"},
            {9, "���� ����"},
            {10, "���� ����"},
            {11, "��� ��� ���"},
            {12, "���� ��� ���"},
            {13, "���� ��� ���"},
            {14, "����� ��� ���"},
            {15, "����� ��� ���"},
            {16, "��� ��� ���"},
            {17, "���� ��� ���"},
            {18, "����� ��� ���"},
            {19, "���� ��� ���"},
            {20, "����� ���"},
            {21, "��� ������ ���"},
            {22, "����� ������ ���"},
            {23, "����� ������ ���"},
            {24, "����� ������ ���"},
            {25, "����� ������ ���"},
            {26, "��� ������ ���"},
            {27, "���� ������ ���"},
            {28, "����� ������ ���"},
            {29, "���� ������ ���"},
            {30, "��� �����"}
        };
        public Dictionary<int, string>  Months = new Dictionary<int, string>
        {
            {1, "����"},
            {2, "������"},
            {3, "����"},
            {4, "���"},
            {5, "���"},
            {6, "���"},
            {7, "��� ������"},
            {8, "��� ����"},
            {9, "����"},
            {10, "����"},
            {11, "����"},
            {12, "����"},
            {13, "��"},
            {14, "����"}
        };
        public Dictionary<string, string> Years = new Dictionary<string, string>
        {
            {"���\"�", "���� ����� ���� ���� ������ �����"},
            {"���\"�", "���� ����� ���� ���� ������ ����"},
            {"���\"�", "���� ����� ���� ���� ������ ���"},
            {"���\"�", "���� ����� ���� ���� ������ ����"},
            {"���\"�", "���� ����� ���� ���� ������ ������"},
            {"���\"�", "���� ����� ���� ���� ������ ����"},
            {"��\"�", "���� ����� ������"},
            {"���\"�", "���� ����� ������ ����"},
            {"���\"�", "���� ����� ������ ������"},
            {"���\"�", "���� ����� ������ �����"}
        };


        public Form1()
        {
            InitializeComponent();
            IntializeComboBoxes();
        }
        public void IntializeComboBoxes()
        {
            //add days of the week
            comboBox_days.Items.Add("�����");
            comboBox_days.Items.Add("���");
            comboBox_days.Items.Add("�����");
            comboBox_days.Items.Add("�����");
            comboBox_days.Items.Add("�����");
            comboBox_days.Items.Add("����");

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

            if (dayOfWeek == "�����")
            {
                dayOfWeek = "���";
            }


            if (monthDay == "��� �����")
            {
                int monthIndex = comboBox_month.SelectedIndex;
                //switch (monthDayIndex)
                //{
                //    case 14:
                //        month = "����";
                //        break;
                //    default:
                //        month = comboBox_month.;
                //}
                fullQuery = $"���� ����� ���� {monthDay} ����� {month} ���� ��� ����{year} ������ �����";
            }
            else
            {
                fullQuery = $"�{dayOfWeek} ���� {monthDay} ���� {month} ��� {year} ������ �����";
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
