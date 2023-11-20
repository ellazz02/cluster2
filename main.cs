using System;

class Program {
  
  public static void Main (string[] args) {
    string nama,a;
    int harian, UTS, UAS,rata2=0;
    Console.WriteLine("Pemrograman Menghitung Nilai Rata-Rata");
    Console.Write ("Nama".PadRight(15)+"= ");
    nama = Console.ReadLine();

    Console.Write("Nilai Harian".PadRight(15)+"= ");
    harian = int.Parse(Console.ReadLine());

    Console.Write("Nilai UTS".PadRight(15)+"= ");
    UTS = int.Parse(Console.ReadLine());

    Console.Write("Nilai UAS".PadRight(15)+"= ");
    UAS = int.Parse(Console.ReadLine());

    rata2 = (harian+UTS+UAS)/3;
    if (rata2>=80){
      a = "A";
    }
    else if (rata2 >= 70){
      a = "B";
    }
    else if (rata2 >= 60){
      a = "C";
    }
    else if (rata2 >= 50){
      a = "D";
    }
    else{
      a = "E";
    }
    Console.WriteLine("");
    Console.WriteLine("========================");
    Console.WriteLine("");
    Console.WriteLine("Nama".PadRight(15)+"= "+nama);
    Console.WriteLine("Nilai Harian".PadRight(15)+"= "+harian);
    Console.WriteLine("Nilai UTS".PadRight(15)+"= "+UTS);
    Console.WriteLine("Nilai UAS".PadRight(15)+"= "+UAS);
    Console.WriteLine("Rata-rata".PadRight(15)+"= "+rata2);
    Console.WriteLine("Predikat".PadRight(15)+"= "+a);
    
  }
}