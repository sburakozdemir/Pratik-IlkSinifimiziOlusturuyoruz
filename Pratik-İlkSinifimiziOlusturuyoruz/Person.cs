// Person sınıfı, öğrenci ve öğretmen bilgilerini tutmak için kullanılır
namespace Pratik_İlkSinifimiziOlusturuyoruz
{
    internal class Person
    {
        // Kişinin adını tutan özel değişken
        private string name;
        // Kişinin soyadını tutan özel değişken
        private string surname;
        // Kişinin doğum tarihini tutan özel değişken
        private DateTime dateOfBirth;

        // Ad özelliği için public property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Soyad özelliği için public property
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        // Doğum tarihi özelliği için public property
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        // Kişinin bilgilerini konsola yazdıran metot
        public void Yazdır()
        {
            Console.WriteLine($"Adı: {name} \nSoyadı: {surname} \nDoğum Tarihi: {dateOfBirth.ToShortDateString()}");
            Console.WriteLine("**********************************************************");
        }
    }
}