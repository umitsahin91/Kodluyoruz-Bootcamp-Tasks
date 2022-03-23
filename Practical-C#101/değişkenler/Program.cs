using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte _byte=5;                  //1 byte
            sbyte _sbyte=5;                //1 byte
            short _short=5;                 //2 byte
            ushort _ushort=5;                //2 byte

            Int16 _ınt16=2;                  //2 byte
            int _int=2;                  //4 byte
            Int32 _int32=2;     //4 byte
            Int64 _int64=2;     //8 byte

            uint _uint=2;       //4 byte
            long _long=2;       //8 byte
            ulong _ulong=2;     //8 byte

            //Reel Sayılar

            float _float = 2;   //4 byte
            double _double = 2; //8 byte
            decimal _decimal=2; //16 byte

            char _char='2';     //2 byte
            string _string="Ümit Şahin";  //Sınırsız

            bool _booltrue=true;
            bool _boolfalse=false;
            DateTime _dateTime=DateTime.Now;
            Console.WriteLine(_dateTime);

            object _objectString="Ümit Şahin";
            object _objectChar='2';
            object _objectInteger=2;
            object _objectDecimal=2.2;

            //String İfadeler

            string _stringEmpty=string.Empty;
            string adSoyad="Ümit Şahin";
            string ad="Ümit";
            string soyad="Şahin";
            string tamAd=ad + " " + soyad;

            //İnteger Tanımlama Şekilleri

            int sayi1=5;
            int sayi2=3;
            int carpim =sayi1*sayi2;

            //Boolen Tanımlama Şekilleri

            bool _boolen = 10<2;//false

            //Değişken Dönüşümleri

            string stringDeger="20";
            int integerDeger=20;

            string yeniStringDeger = stringDeger+integerDeger.ToString();
            Console.WriteLine(yeniStringDeger);//Çıktısı "2020"

            int yeniIntegerDeger = integerDeger+Convert.ToInt32(stringDeger);
            Console.WriteLine(yeniIntegerDeger);//Çıktısı "40"

            int intParse = integerDeger+int.Parse(stringDeger);//Çıktısı "40"
            //DateTime
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);
            string dateTime1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime1);
            //Saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);



















            
        }
    }
}
