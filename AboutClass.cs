using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class AboutClass
    {
        public string name;

        public static string UrName()
        {
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            return name;
        }

        public static string UrName(string name){ return name; }
    }

    class Constructor
    {
        public int code;
        public string name;

        public Constructor(string name, int code) //Constructor
        {
            this.name = name;
            this.code = code;
        }

        public void UrName1()
        {
            Console.Write($"your name is {name} and ");
        }

        public void UrCode1()
        {
            Console.WriteLine($"your code is {code}");
        }
    }

    class Cars //Static
    {
        string model;
        public int numberOfCar;
        public static int numberOfCarClass;

        public Cars(string model)
        {
            this.model = model;
            numberOfCar++;
            numberOfCarClass++;

        }
    }

    class DaftarMenu //Overloaded Constructor
    {
        public string makanan, minuman, dessert, snacks;

        public DaftarMenu(string makanan, string minuman, string dessert, string snacks)
        {
            this.makanan = makanan;
            this.minuman = minuman;
            this.dessert = dessert;
            this.snacks = snacks;

            Console.WriteLine($"Pesanannya : {makanan}, {minuman}, {dessert} dan {snacks}");
        }

        public DaftarMenu(string makanan, string minuman, string dessert)
        {
            this.makanan = makanan;
            this.minuman = minuman;
            this.dessert = dessert;

            Console.WriteLine($"Pesanannya : {makanan}, {minuman} dan {dessert}");
        }

        public DaftarMenu(string makanan, string minuman)
        {
            this.makanan = makanan;
            this.minuman = minuman;

            Console.WriteLine($"Pesanannya : {makanan} dan {minuman}");
        }

        public DaftarMenu(string makanan)
        {
            this.makanan = makanan;
            Console.WriteLine($"Pesanannya : {makanan}");
        }
    }

    //inheritance dari ExampleMyClass
    class ExClass : ExampleMyClass 
    {
        public ExClass(string nama)
        {
            int code = ExampleMyClass.UrCode2();
            this.code = code;

            Console.WriteLine($"{code} / {nama}");
        }
    }

    abstract class AbsClass //Abstract
    {
        public string kalimat = "Hi";
    }

    class AbsClassEx :AbsClass
    {
        public void AbsCetakEx()
        {
            Console.WriteLine(kalimat);
        }
    }

    class ArraysOfObjectEx
    {
        public string dataString;
        public int dataInt;

        public ArraysOfObjectEx(string dataString , int dataInt)
        {
            this.dataString = dataString;
            this.dataInt = dataInt;
        }
    }

    class CodePromo //Object As Parameter
    {
        public string promoCode;
        public string promo(DaftarMenu menu ,string promoCode)
        {
            this.promoCode = promoCode;

            if (menu.makanan == "ayam goreng") { promoCode = "promo"; }
            else promoCode = "off";

            return promoCode;
        }
    }

    class CodePromo2
    {
        public DaftarMenu BonusPromo(CodePromo bonus, DaftarMenu menu)
        {
            if (bonus.promoCode == "off" && menu.minuman == "aqua")
            {
                menu.makanan = 2 + menu.makanan;
            }
            return menu;
        }
    }

    class Animal //Method Overriding jadikan Abstract jika ingin jadikan method abstract Speak()
    {
        public virtual void Speak() // jadikan virtual agar bisa di override
        {
            Console.WriteLine("The animal goes *brr");
        }

    }

    class Dog : Animal
    {
        override public void Speak() // melakukan override
        {
            Console.WriteLine("The dog goes *guk guk");
        }
    }

    class Cat : Animal
    {
        override public void Speak() //melakukan override
        {
            Console.WriteLine("The cat goes *meow meow");
        }
    }

    class Car2 //To String
    {
        public string make, model, color;
        public int year;

        public Car2(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString() //Override To String
        {
            return $"Spesifikasi mobil : {make}, {model}, {year} dan {color}";
        }
    }

    class Player
    {
        public string name;

        public Player(string name)
        {
            this.name = name;
        }

        public override string ToString() //dengan override ToString
        {
            return name;
        }
    }

    class Motorcycle //GettersnSetters
    {
        private int speed;

        public Motorcycle(int speed)
        {
            SpeedGettersnSetters = speed;
        }

        public int SpeedGettersnSetters //properties
        {
            get { return speed; } //read
            set
            {
                if (value > 220)
                {
                    speed = 220;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }

    class Car4 //AutoImplementedProperties
    {
        /*String model; // jgn buat field jadi public

        public String Model //properties
        {
            get { return model; }
            set { model = value; }
        }
        */

        public String Model { get; set; } //sama seperti properties yang diatas

        public Car4(String model)
        {
            this.Model = model;
        }
    }

}
