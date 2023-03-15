using System;

namespace InheritanceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Animal
    {
        public int age;
        public string gender;
        public bool isMammal()
        {
            return false;
        }
        public void mate()
        {

        }

    }
    class Duck : Animal
    {
        // public string breakColor = "yellow"; //variabel
        private string y = "yellow"; //property
        public string breakColor
        {
            get { return y; }
            set { y = value; }
        }
        public void swim()
        {
            isMammal();
            age = 1;
            gender = "Jantan";
            mate();
        }
        public void quack()
        {

        }

    }
    class Fish : Animal
    {
        private int sizelnFt { get; set; }
        private bool canEat { get; set; }
        private void swim()
        {

        }

    }
    class Zebra : Animal
    {
        public bool is_wild()
        {
            return false;
        }
        public void run()
        {

        }
    }
    class Bidang
    {
        public int x, y;
        public virtual double getLuas()
        {
            return 0;
        }
        public virtual double getKeliling()
        {
            return 0;
        }
    }
    class Segitiga : Bidang
    {
        public int alas=9, tinggi=12,jumlah,sisi;
        public override double getLuas()
        {
            jumlah = 1 / 2 * alas * tinggi;
            return jumlah;
        }
        public override double getKeliling()
        {
            jumlah = sisi*sisi*sisi;
            return jumlah;
        }

    }
    class Lingkaran : Bidang
    {
        public int r=12;
        private double jumlah;

        public override double getLuas()
        {
            jumlah = 2 * 3.14 * r;
            return 3.14*r*r;
        }
        public override double getKeliling()
        {
            jumlah = 3.14 * r * r;
            return jumlah;
        }
    }
}
