using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	/// <summary>
	/// main class 
	/// </summary>
    class Program
    {
    	/// <summary>
    	/// operasi pertambahan
    	/// </summary>
    	/// <param name="args"></param>
        /// <remarks>class math dapat membuat operasi penambahan (add), pengurangan (subtract)</remarks>
        static void Main(string[] args)
        {

            ushort hari, bulan, tahun;
            Console.WriteLine("Hitung Usia");
            Console.WriteLine("===========");
            try
            {
                ///class dan input yang nantinya akan dijumlahkan 
                Console.Write("Tanggal Lahir\t : ");
                hari = Convert.ToUInt16(Console.ReadLine());
                Console.Write("Bulan \t \t : ");
                bulan = Convert.ToUInt16(Console.ReadLine());
                Console.Write("Tahun \t \t : ");
                tahun = Convert.ToUInt16(Console.ReadLine());

                ///proses eksekusi Operasi pertambahan 
                DateTime ultah = new DateTime(tahun, bulan, hari);
                DateTime hariini = DateTime.Now;
                TimeSpan usia = hariini.Subtract(ultah);
                Console.WriteLine(".....................");
                ///hasil dari penjumlahan antara tahun , bulan ,dan hari
                Console.WriteLine("Umur kamu adalah {0} hari, {1} jam " + " {2} menit", usia.Days, usia.Hours, usia.Minutes);
            }
            catch (FormatException e)
            {
                ///Peringatan jika memasukkan selain angka
                Console.WriteLine("Data tanggal, bulan, tahun harus berupa angka ");
            }
            catch (Exception e)
            {
                ///peringatan ketika terjadi eror
                Console.WriteLine("Terjadi kesalahan : ", e.Message);
            }
            Console.ReadKey();
        }
     
    }
}