namespace EduMeetingSuleyman.Tools
{
    public class GeneralTools  //bunu heryerde kullanıcaz name space ini al üsten kopyala viewimports a 
    {
        public static string LinkOlustur(string metin) //static demek instance almadan yapmak. namespace falan yok.
        {
            return metin.ToLower().Replace("", "-").Replace("ö", "o");    //ö yü o yap falan devam ettirebilirsin ü u yap gibi..
        }
    }
}
          //bunu istersen yap. asp name den değişecek ama suanda ugrasmıycam. video: e6 01:51 dk