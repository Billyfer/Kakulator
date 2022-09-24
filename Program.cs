using System;
namespace SkilvulLearning {
    class Animal {
        static void Main(string[] args) {
            int a = 1;
        while(a > 0){
            string Tambah = "1";
            string Kurang = "2";
            string Bagi = "3";
            string Kali = "4";
            string b = "Yes";
            int Angka1;
            int Angka2;
            int Hasil;

            Console.WriteLine("1 = Tambah");
            Console.WriteLine("2 = Kurang");
            Console.WriteLine("3 = Bagi");
            Console.WriteLine("4 = Kali");
            Console.WriteLine("Masukan Angka 1");
            Angka1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan Angka 2");
            Angka2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukan Angka 1 Sampai 4");
            string Pilihan = Console.ReadLine();
            if (Pilihan == Tambah)
                {
                    Console.WriteLine("Penambahan");
                    Hasil = Angka1 + Angka2;
                    Console.WriteLine(Angka1 + "+" + Angka2 + "=" + Hasil);
                    Console.WriteLine("Apakah Ingin Keluar Dari Kakulator? (Yes/No)");
                    string Pengulangan = Console.ReadLine();
                    if (Pengulangan == b){
                        a --;
                    } 
                    else{
                        
                    }
                }
            else if(Pilihan == Kurang)
                {
                    Console.WriteLine("Pengurangan");
                    Hasil = Angka1 - Angka2;
                    Console.WriteLine(Angka1 + "-" + Angka2 + "=" + Hasil);
                    Console.WriteLine("Apakah Ingin Keluar Dari Kakulator? (Yes/No)");
                    string Pengulangan = Console.ReadLine();
                    if (Pengulangan == b){
                        a --;
                    } 
                    else{
                        
                    }
                }
            else if(Pilihan == Kali)
                {
                    Console.WriteLine("Pekalian");
                    Hasil = Angka1 * Angka2;
                    Console.WriteLine(Angka1 + "*" + Angka2 + "=" + Hasil);
                    Console.WriteLine("Apakah Ingin Keluar Dari Kakulator? (Yes/No)");
                    string Pengulangan = Console.ReadLine();
                    if (Pengulangan == b){
                        a --;
                    } 
                    else{
                        
                    }
                }
            else if(Pilihan == Bagi)
                {
                    Console.WriteLine("Pembagian");
                    Hasil = Angka1 / Angka2;
                    Console.WriteLine(Angka1 + "/" + Angka2 + "=" + Hasil);
                    Console.WriteLine("Apakah Ingin Keluar Dari Kakulator? (Yes/No)");
                    string Pengulangan = Console.ReadLine();
                    if (Pengulangan == b){
                        a --;
                    } 
                    else{
                        
                    }
                }
            else {
                    Console.WriteLine("Tidak ada pilihan");
                    Console.WriteLine("Apakah Ingin Keluar Dari Kakulator? (Yes/No)");
                    string Pengulangan = Console.ReadLine();
                    if (Pengulangan == b){
                        a --;
                    } 
                    else{
                        
                    }
                }
            
            }
            
        }
    }
}




//Contoh
// using System;

// class ProgramInput
// {
//     static void Main(String[] args)
//     {
//         Console.WriteLine("=== PERCOBAAN SINTAKS INPUT ===");
//         Console.Write("Silahkan masukan nama anda: ");
//         string nama = Console.ReadLine();
//         Console.WriteLine("Hi, " + nama + " selamat datang!");
//     }
// }