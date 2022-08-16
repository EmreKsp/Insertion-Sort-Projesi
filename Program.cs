using System;

namespace neden
{
    class Program
    {
        static void Main(string[] args)
        {

        int deger = 2;
        string degisken = null;
        string Degisken = null;
        string degisken_veri= null;
        byte b = 5;         //1 byte   
        sbyte c = 5;        //1 byte
        
        short s = 5;         //2 byte
        ushort us = 5;       //2 byte

        Int16 i16 = 2;       //2 byte
        int i = 2;           //2 byte
        Int32 i32 = 2;       //4 byte
        Int64 i64 = 2;       //8 byte

        uint iu = 2;         //4 byte
        long l = 2;          //8 byte
        ulong ul = 2;        //8 byte
        //Reel Sayılar
        float f = 5;         //4 byte
        double d = 5 ;       //8 byte
        decimal de = 5;      //16 byte

        char ch = "2"       // 2 byte
        string str = "emre kasap";   //sınırsız

        bool b1 = True;
        bool b2 = False;


        DateTime dt = DateTime.Now;


        object o1 = "x";
        object o2 = 'y';
        object o3 = 4;
        object o4 =4.3;

        string str1 = string.Empty;
        str1 = "Emre KASAP";
        string ad = "Emre";
        string soyad = "Kasap";
        string tamisim = ad + " " + soyad;

        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        bool bool1 = 10>5;

        string str20 = "20";
        int int20 = 20;

        string yeniDeger = int20.ToString() + str20;
        int int21 = int20 + Convert.ToInt32(str20);
        int int22 = int20 + int.Parse(str20);

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        string datetime = DateTime.Now.ToString("dd/MM/yyyy");
        string hour = DateTime.Now.ToString("HH:mm");
        https://app.patika.dev/exthia







        }    
    }
}
