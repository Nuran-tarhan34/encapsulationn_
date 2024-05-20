namespace SchoolManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School nisantasiUniversity = new School("Nişantaşı Üniversitesi", 20000, "Gökhan Mutlay", "1234567890123");
            nisantasiUniversity.getUniversityInfo();

            nisantasiUniversity.getUniversityInfo();

            School egeUniversity = new School("Ege Üniversitesi", 550000, "Acun Ilıcalı", "12345");
            egeUniversity.getUniversityInfo();
            //encapsulation  

            School giresunUniversity = new School("Giresun Üniversitesi", 1000, "Furkan Cebeci", "12345");
            giresunUniversity.getUniversityInfo();


        }
    }

    public class School
    {
        private string schoolName;
        private int studentCount;
        private string principalName;
        private string taxNum;

        private string VergiKontrol
        {
            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("Veri Girişi 10'dan Büyük Hatalı Veri Girişi Yaptınız!");
                    this.taxNum = value.Substring(0, 10);
                }
                else
                {
                    this.taxNum = value;
                }
            }
        }

        public School(string schoolName, int studentCount, string principalName, string taxNum)
        {
            this.schoolName = schoolName;
            this.studentCount = studentCount;
            this.principalName = principalName;
            VergiKontrol = taxNum;

        }

        //Methods
        public void getUniversityInfo()
        {
            Console.WriteLine("Üniversite Bilgileri");
            Console.WriteLine("Okul Adı:" + this.schoolName);
            Console.WriteLine("Öğrenci Sayısı:" + this.studentCount);
            Console.WriteLine("Müdür Adı:" + this.principalName);
            Console.WriteLine("Vergi Numarası:" + this.taxNum);
            Console.WriteLine("*");
        }
        //De-Structer

    }
}