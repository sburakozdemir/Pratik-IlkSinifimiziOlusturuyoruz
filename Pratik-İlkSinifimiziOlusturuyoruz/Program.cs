using Pratik_İlkSinifimiziOlusturuyoruz;

// İlk öğretmen nesnesini oluştur ve bilgilerini ata
Person teacher1 = new Person();
teacher1.Name = "Berk";
teacher1.Surname = "Bayındır";
teacher1.DateOfBirth = new DateTime(1989, 9, 9);
teacher1.Yazdır();

// İkinci öğretmen nesnesini oluştur ve bilgilerini ata
Person teacher2 = new Person();
teacher2.Name = "Ufuk";
teacher2.Surname = "Yıkılmaz";
teacher2.DateOfBirth = new DateTime(1986, 12, 27);
teacher2.Yazdır();

// İlk öğrenci nesnesini oluştur ve bilgilerini ata
Person student1 = new Person();
student1.Name = "Aşkın";
student1.Surname = "Şalcıoğlu";
student1.DateOfBirth = new DateTime(2000, 2, 14);
student1.Yazdır();

// İkinci öğrenci nesnesini oluştur ve bilgilerini ata
Person student2 = new Person();
student2.Name = "Can";
student2.Surname = "Serbes";
student2.DateOfBirth = new DateTime(2000, 5, 18);
student2.Yazdır();
