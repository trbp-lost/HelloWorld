using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        // Bagian Materi
        #region Materi
        private static void Hello()
        {
            Console.WriteLine("\n----------Hello World----------");
            Console.WriteLine("Hello World");
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            Console.WriteLine("\tHello Komodo");    // horizontal tab
            Console.WriteLine("\vHello Komodo");    // vertical tab
            Console.WriteLine("Hello \fKomodo");    // form feed
            Console.WriteLine("Hello \rKomodo");    // carriage return
            Console.WriteLine("Hello Ko\bmo\bdo");  // backspace
            Console.WriteLine("\aError Sound");     // alert sound

        }

        private static void Variabel()
        {
            Console.WriteLine("----------Variable----------");
            int x; // declaration
            x = 2; // initialization

            int y = 3; // declaration & initialization
            int z = x * y;

            Console.WriteLine("\nThe data is " + z);

            double height = 160.1;
            bool alive = true;
            short numCode = 1;
            char userCode = '~';
            string name = "Komodo";

            const double pi = 3.14159; // immutable values which are known at compile time and 
                                       // do not change for the life program

            Console.WriteLine("Your height about " + height);
            Console.WriteLine("Your condition " + alive);
            Console.WriteLine("Your number code is " + numCode);
            Console.WriteLine("Your user code is " + userCode);
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your username is " + userCode + name);
            Console.WriteLine("pi = " + pi);

        }

        private static void TypeCasting()
        {
            double piDouble = 3.14159;

            int piInt = Convert.ToInt32(piDouble); // double -> int
            long piLong = Convert.ToInt64(piDouble); // double -> long
            char piChar= Convert.ToChar(Convert.ToString(Convert.ToInt32(piDouble))); // double -> char
            string piString = Convert.ToString(piDouble); // double -> string
            float piFloat= Convert.ToSingle(piDouble); // double -> float

            Console.WriteLine("pi double -> int    : " + piInt + "       tipe datanya : " + piInt.GetType());
            Console.WriteLine("pi double -> long   : " + piLong + "       tipe datanya : " + piLong.GetType());
            Console.WriteLine("pi double -> char   : " + piChar + "       tipe datanya : " + piChar.GetType());
            Console.WriteLine("pi double -> string : " + piString + " tipe datanya : " + piString.GetType());
            Console.WriteLine("pi double -> float  : " + piFloat + " tipe datanya : " + piFloat.GetType());
        }

        private static void MathClass()
        {
            int angka = 3,
                angka2 = 9,
                angka3 = -81;

            Console.WriteLine(Math.Pow(angka,angka2));
            Console.WriteLine(Math.Sqrt(angka2));
            Console.WriteLine(Math.Abs(angka3));
            Console.WriteLine(Math.PI);

            Console.WriteLine(Math.Round(Math.PI));
            Console.WriteLine(Math.Ceiling(Math.PI));
            Console.WriteLine(Math.Floor(Math.PI));

            Console.WriteLine(Math.Max(angka, Math.Max(angka2,angka3)));
            Console.WriteLine(Math.Min(angka, Math.Min(angka2,angka3)));
        }

        private static void Pseudorandom()
        {
            Random random = new Random();

            int randInt = random.Next(1, 91); // 1 <-> 90
            double randDouble = random.NextDouble();

            Console.WriteLine(randInt); // 0 between >2000000
            Console.WriteLine(randDouble); // 0 between 1
        }
        
        private static void SisiMirirngSegitiga()
        {
            Console.Write("\nMasukkan Alas  : ");
            double alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nMasukkan Tinggi: ");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            double sisiMiring = Math.Sqrt(Math.Pow(alas,2)+Math.Pow(tinggi,2));

            Console.WriteLine("hasilnya adalah " + sisiMiring);
        }

        private static void StringMethod()
        {
            Console.Write("Masukkan Nama Panjang : ");
            string fullName = Console.ReadLine();

            Console.Write("Masukkan Nomor Hp (+62): ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(phoneNumber.Replace("+62", "0"));
            Console.WriteLine(fullName.Insert(0,"@"));
            Console.WriteLine(fullName.Length);
            Console.WriteLine(fullName.Substring(0, (fullName.Length - 1)));
        }

        private static void BatuGuntingKertas()
        {
            Console.Clear();
            Console.WriteLine("\nPermainan Batu Gunting Kertas dengan Tenary");  
            Console.WriteLine("1. Batu");  
            Console.WriteLine("2. Gunting");  
            Console.WriteLine("3. Kertas");  
            Console.Write("Masukkan Pilihan : ");
            int guessUser = Convert.ToInt32(Console.ReadLine());
            
            Random random = new Random();
            int guessAI = random.Next(1,4);

            var pilUser = BatuGuntingKertasTambahan(guessUser, 1);
            var pilAI = BatuGuntingKertasTambahan(guessAI, 0);

            //nested tenary
            var hasil = guessUser == guessAI ? "Seri" :
                        guessUser == (guessAI-1) || guessUser == (guessAI+2) ? "Menang" : "Kalah";

            Console.WriteLine("\nKamu memilih " + guessUser + " artinya " + pilUser);
            Console.WriteLine("AI   memilih " + guessAI + " artinya " + pilAI);
            Console.WriteLine("Kamu "+ hasil);

            while (true)
            {
                Console.Write("\ningin bermain lagi? (y/n) ");
                string pil = Console.ReadLine();

                if (pil.ToLower() == "y") BatuGuntingKertas();
                else break;

            }
        }

        private static void ForeachnFor4Array()
        {
            String[] cars = { "BMW", "Mustang", "Corvette" };

            // bersifat fleksibel karena bisa diatur i nya dan lain2
            Console.WriteLine("Versi For");
            for (int i = 0; i < cars.Length; i++) 
            {
                Console.WriteLine(cars[i]);
            }

            // tidak fleksibel karena tidak bisa diatur sifatnya increment mulai dari 0
            Console.WriteLine("\nVersi Foreach");
            foreach (var itemCar in cars) 
            {
                Console.WriteLine(itemCar);
            }
        }

        private static void Method()
        {
            Console.WriteLine("Method ada 2 yaitu: (cek codingan file ini)");
            Console.WriteLine("1.Method tanpa parameter seperti bagian Materi dan bagian menu");
            Console.WriteLine("2.Method berparameter seperti Bagian Tambahan\n");

            Console.WriteLine("Method overloading adalah method yang namanya sama tapi memiliki keunikan masing-masing/berbeda");
        }

        private static void ParamsMethod()
        {
            Console.WriteLine("params adalah sebuah method parameter yang mampu menampung banyak parameter ke dalam array.");
            
            int value = ParamsTambahan(1,2,3,4,5,6);
            Console.WriteLine(value);
        }

        private static void ExceptionFunction(){
            /* try     = mencoba kode yang mungkin akan error
             * catch   = penanganan jika terjadi error
             * finally =  akan berjalan walaupun error
             */

            //try-catch-finally
            try
            {
                Console.Write("Masukkan angka pertama :");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan angka kedua   :");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("hasilnya " + x/y);
            }
            catch( FormatException e) //  menangkap error tertentu
            {
                Console.WriteLine("Masukkan angka");
                Console.WriteLine(e);
            }
            catch (DivideByZeroException e) //  menangkap error tertentu
            {
                Console.WriteLine("Tidak bisa dibagi 0");
                Console.WriteLine(e);
            }
            catch (Exception e) // menangkap semua error
            {
                Console.WriteLine("Bukan angka");
                Console.WriteLine(e);
                //throw;
            }
            finally
            {
                Console.WriteLine("Thanks for use this program");
            }
        }

        private static void StringInterpolation()
        {
            //seperti print format tapi berbeda dengan menggunakan $ dan {}

            string firstName = "Lost", lastName = "Dragon";
            int code = 3;

            // cara normal
            Console.WriteLine("Nama saya " + firstName + " " + lastName + ".");

            // cara String Interpolation
            Console.WriteLine($"Nama saya {firstName} {lastName}.");
            Console.WriteLine($"My code {code,5}.");
            Console.WriteLine($"My code {code,-5}.");
        }

        private static void MultiDimensional()
        {
            int?[,] number = { {1,2,3,4,5,6},
                               {7,8,9,null,null,null},
                               {10,11,12,13,14,null}
                             };
            Console.WriteLine("dengan Foreach");
            foreach (var values in number)
            {
                Console.Write(values+ " ");
            }

            Console.WriteLine();
            Console.WriteLine("dengan For");
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    Console.Write(number[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(number.Length);
            Console.WriteLine(number.GetLength(1));
        }

        public static void Class()
        {
            string name = AboutClass.UrName();
            int code = ExampleMyClass.UrCode();

            Console.WriteLine($"Your name is {name} and your code is {code}");
        }

        public static void Object()
        {
            //object
            AboutClass aboutClass1 = new AboutClass();
            ExampleMyClass exampleMyClass1 = new ExampleMyClass();

            aboutClass1.name = "Lost";
            exampleMyClass1.code = 3;

            Console.WriteLine($"Your name is {AboutClass.UrName(aboutClass1.name)} " +
                              $"your code is {ExampleMyClass.UrCode(exampleMyClass1.code)}");
        }

        private static void Constructor()
        {
            /* Constructor = spesial method dalam class
             *               namanya sama seperti nama class
             */
            Constructor constructor1 = new Constructor("Lost",2);
            Constructor constructor2 = new Constructor("Dragon",3);

            constructor1.UrName1();
            constructor1.UrCode1();
            constructor2.UrName1();
            constructor2.UrCode1();
        }

        private static void Static()
        {
            Cars car1 = new Cars("Mustang");
            Cars car2 = new Cars("Corvette");

            Console.WriteLine(car1.numberOfCar);
            Console.WriteLine(car2.numberOfCar);
            Console.WriteLine();
            Console.WriteLine(Cars.numberOfCarClass);
        }

        private static void OverloadedConstructor()
        {
            DaftarMenu daftarMenu1 = new DaftarMenu("nasi goreng", "boba", "kue coklat panas", "chitatto");
            DaftarMenu daftarMenu2 = new DaftarMenu("nasi kucing", "thai tea", "kentang goreng");
            DaftarMenu daftarMenu3 = new DaftarMenu(null,"thai tea","cimin");
        }

        private static void InheritanceClass()
        {
            ExClass exClass = new ExClass("Lost");
        }

        private static void AbstractClass()
        {
            /*Abstract = tidak bisa membuat objek classnya jadi kalau mau akses harus ada tambahan seperti jadi Inheritance
             *           sehingga diibaratkan kalau berkendara harus ada kendaraanya dulu.
             */

            //Abstract abstract = new Abstract();
            AbsClassEx absClassEx = new AbsClassEx();

            absClassEx.AbsCetakEx();
        }

        private static void ArraysOfObject()
        {
            //cara 1
            ArraysOfObjectEx exClass = new ArraysOfObjectEx("ayam goreng",1);
            ArraysOfObjectEx exClass2 = new ArraysOfObjectEx("ikan goreng",2);
            ArraysOfObjectEx exClass3 = new ArraysOfObjectEx("nasi goreng",3);

            ArraysOfObjectEx[] exClasses = new ArraysOfObjectEx[3]; //array objek

            exClasses[0] = exClass;
            exClasses[1] = exClass2;
            exClasses[2] = exClass3;

            foreach (ArraysOfObjectEx daftar  in exClasses)
            {
                Console.WriteLine($"{daftar.dataString} / {daftar.dataInt}");
            }

            Console.WriteLine();

            //cara 2
            ArraysOfObjectEx[] daftars = { new ArraysOfObjectEx("a",5),
                                           new ArraysOfObjectEx("b",6),
                                         }; //array objek

            foreach (ArraysOfObjectEx daftar in daftars)
            {
                Console.WriteLine($"{daftar.dataString} / {daftar.dataInt}");
            }
        }

        private static void ObjectAsParameter()
        {
            CodePromo codePromo = new CodePromo();
            CodePromo2 codePromo2 = new  CodePromo2();
            DaftarMenu menu = new DaftarMenu("ayam goreng", "aqua");

            Console.WriteLine(codePromo.promo(menu, null));
            Console.WriteLine();
            Console.WriteLine(codePromo2.BonusPromo(codePromo, menu).makanan);
        }

        private static void MethodOverriding()
        {
            /* Method Overriding =  membuat versi baru method dari yang telah dibuat/diwariskan dari kelas parent-nya
             *                      pewarisnya method harus abstract, virtual, polymorphim atau sudah diganti dengan ToString();
             */
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
        }

        private static void ToStringFunction()
        {
            //ToString = mengubah objek menjadi string, bisa di override
            Car2 car2 = new Car2("Chevy","Corvette",2022,"Blue");

            Console.WriteLine(car2.ToString());

        }

        private static void PolymorphismClass()
        {
            /* polymorphism class = memiliki banyak bentuk dan objek yang diidentifikasikan lebih dari satu
             *                      juga memiliki satu kesamaan contohnya pada classnya yaitu Inheritance
             */

            Car3 car3 = new Car3();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Polymorphism[] vehicles = { car3, bicycle, boat };

            foreach (Polymorphism vehicleItem in vehicles)
            {
                vehicleItem.Go();
            }
        }

        private static void InterfaceClass()
        {
            /* Interface = seperti kontrak dimana classes Inheriting/warisannya harus mengikuti
             *           * classes yang diwarisi harus memiliki/implementasi apa yang ada di interface
             *             
             *             keuntungan = aman + bisa buat banyak Inheritance + plug-play
             */

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();
        }

        private static void List()
        {
            /* List = struktur data seperti array dapat diakses dengan index dan ukuran dapat diubah
             *        memerlukan using System.Collections.Generic;
             */

            List<String> food = new List<String>();
            food.Add("Pizza");
            food.Add("Hamburger");
            food.Add("Hotdog");

            foreach (String itemFood in food)
            {
                Console.WriteLine(itemFood);
            }

            food.Remove("Hotdog");
            Console.WriteLine();
            foreach (String itemFood in food)
            {
                Console.WriteLine(itemFood);
            }

            food.Insert(2, "Hotdog");
            Console.WriteLine();
            Console.WriteLine(food[2]);

            food.RemoveAt(2);
            Console.WriteLine();
            foreach (String itemFood in food)
            {
                Console.WriteLine(itemFood);
            }

            food.Add("Hotdog");

            Console.WriteLine();
            Console.WriteLine($"Lebar list {food.Count}");
            Console.WriteLine($"Hamburger berada di list ke-{food.IndexOf("Hamburger")}");
            Console.WriteLine();

            //list->array
            String[] listArray = food.ToArray();
            foreach (var item in listArray)
            {
                Console.WriteLine(item);
            }
        }

        private static void ListOfObject()
        {
            List<Player> players = new List<Player>();

            Player player2 = new Player("pemain2");
            Player player3 = new Player("pemain3");

            players.Add(new Player("pemain1"));
            players.Add(player2);
            players.Add(player3);

            foreach (Player data in players)
            {
                Console.WriteLine(data.name);
            }

            Console.WriteLine();

            foreach (Player data in players) //dengan override ToString
            {
                Console.WriteLine(data);
            }
        }

        private static void GettersnSetters()
        {
            /* Getters dan Setters = menambah keamanan agar tidak diubah seenaknya pada fields by encapsulation
             *                       mereka adalah pengakses yang ditemukan di dalam properti
             * 
             * properties = mengkombinasikan aspek dari kedua fields and methods (share name with a field)
             * getters accessor = digunakan untuk mengembalikan nilai properties
             * setters accessor = digunakan untuk menandai sebuah nilai baru
             * value keyword = mendefinisikan nilai yang telah didefinisikan oleh set (parameter)
             */

            Motorcycle motorcycle = new Motorcycle(1);
            // motorcycle.speed = 1000000000; //kgk bisa akses/dirubah
            motorcycle.SpeedGettersnSetters = 1000000000; //dirubah tapi limitnya 220 karena sudah dikasih Getters dan Setters

            Console.WriteLine(motorcycle.SpeedGettersnSetters);
        }

        private static void AutoImplementedProperties()
        {
            Car4 car4 = new Car4("Toyota");
            Console.WriteLine(car4.Model);
        }

        private static void Enums()
        {

        }

        #endregion

        //Bagian Menu
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n----------Menu----------");
            Console.WriteLine("1.Hello World");
            Console.WriteLine("2.Variable & Constants");
            Console.WriteLine("3.Type Casting");
            Console.WriteLine("4.Math Class");
            Console.WriteLine("5.RNG(pseudorandom)");
            Console.WriteLine("6.Sisi Mirirng Segitiga");
            Console.WriteLine("7.String Method");
            Console.WriteLine("8.Permainan Batu Gunting Kertas dengan Tenary");
            Console.WriteLine("9.Foreach dan For Untuk Array");
            Console.WriteLine("10.Method");
            Console.WriteLine("11.Param");
            Console.WriteLine("12.Exception");
            Console.WriteLine("13.String Interpolation");
            Console.WriteLine("14.Multi Dimensional");
            Console.WriteLine("15.Class");
            Console.WriteLine("16.Object");
            Console.WriteLine("17.Constructor");
            Console.WriteLine("18.Static");
            Console.WriteLine("19.Overloaded Constructor");
            Console.WriteLine("20.Inheritance");
            Console.WriteLine("21.Abstract");
            Console.WriteLine("22.Arrays Of Object");
            Console.WriteLine("23.Object As Parameter");
            Console.WriteLine("24.Method Overriding");
            Console.WriteLine("25.To String");
            Console.WriteLine("26.Polymorphism");
            Console.WriteLine("27.Interface");
            Console.WriteLine("28.List");
            Console.WriteLine("29.List Of Object");
            Console.WriteLine("30.Getters dan Setters");
            Console.WriteLine("31.Auto-Implemented Properties");
            Console.WriteLine("32.Enums");
            Console.WriteLine("------------------------");
            Console.Write("Masukkan Pilihan : ");
            int pil = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");
            if (pil == 1) Hello();
            else if (pil == 2) Variabel();
            else if (pil == 3) TypeCasting();
            else if (pil == 4) MathClass();
            else if (pil == 5) Pseudorandom();
            else if (pil == 6) SisiMirirngSegitiga();
            else if (pil == 7) StringMethod();
            else if (pil == 8) BatuGuntingKertas();
            else if (pil == 9) ForeachnFor4Array();
            else if (pil == 10) Method();
            else if (pil == 11) ParamsMethod();
            else if (pil == 12) ExceptionFunction();
            else if (pil == 13) StringInterpolation();
            else if (pil == 14) MultiDimensional();
            else if (pil == 15) Class();
            else if (pil == 16) Object();
            else if (pil == 17) Constructor();
            else if (pil == 18) Static();
            else if (pil == 19) OverloadedConstructor();
            else if (pil == 20) InheritanceClass();
            else if (pil == 21) AbstractClass();
            else if (pil == 22) ArraysOfObject();
            else if (pil == 23) ObjectAsParameter();
            else if (pil == 24) MethodOverriding();
            else if (pil == 25) ToStringFunction();
            else if (pil == 26) PolymorphismClass();
            else if (pil == 27) InterfaceClass();
            else if (pil == 28) List();
            else if (pil == 29) ListOfObject();
            else if (pil == 30) GettersnSetters();
            else if (pil == 31) AutoImplementedProperties();
            else if (pil == 32) Enums();
            else Console.WriteLine("Wrong Input");
        }

        //Bagian Tambahan
        private static void Main(string[] args)
        {
            Menu();
            do
            {
                Console.Write("\nWant go to Menu again? (y/n) ");
                string pil = Console.ReadLine();

                if (pil.ToUpper() == "Y") Menu();
                else break;

            } while (true);

            Console.ReadKey(); // to make console stop
        }

        private static string BatuGuntingKertasTambahan(int angka, int isUser)
        {
            string userStatus = isUser == 1 ? "Salah input Woi" : "RNG tidak sesuai" ;
            var hasilPil = angka == 1 ? "Batu" :
                           angka == 2 ? "Gunting" :
                           angka == 3 ? "Kertas" : userStatus;

            return hasilPil;
        }

        private static int ParamsTambahan(int a, int b) { return a + b; }

        private static int ParamsTambahan(int a, int b, int c) { return a + b + c; }

        private static int ParamsTambahan(params int[] a)
        {
            int data = 0;
            foreach (int itemA in a)
            {
                data += itemA;
            }
            return data;
        }
    }
}

class ExampleMyClass
{
    public int code;
    public static int staticCode;

    public static int UrCode()
    {
        Console.Write("Enter Your Code : ");
        int code = Convert.ToInt32(Console.ReadLine());

        return code;
    }

    public static int UrCode(int code) { return code; }

    public static int UrCode2()
    {
        Console.Write("Enter Your Code : ");
        staticCode = Convert.ToInt32(Console.ReadLine());

        return staticCode;
    }

}
