using System;

namespace _9994086_assessment3_question2
{
    class Falcon
    {
        private string _FalconName;
        private string _Species;
        private string _Sex;
        private string _Weight;
        private string _BandNumber;

        public string FalconName
        {
            get
            {
                return _FalconName;
            }
            set
            {
                _FalconName = value;
            }
        }

        public string Species
        {
            get
            {
                return _Species;
            }
            set
            {
                _Species = value;
            }
        }

        public string Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                _Sex = value;
            }
        }

        public string Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                _Weight = value;
            }
        }

        public string BandNumber
        {
            get
            {
                return _BandNumber;
            }
            set
            {
                _BandNumber = value;
            }
        }

        public void displayFalcon()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Falcon Data");
            Console.WriteLine("------------");
            Console.WriteLine($"Falcon Name: {FalconName}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Band Number: {BandNumber}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            var falconHisan = new Falcon();
            Console.WriteLine("Enter Falcon Name: ");
            falconHisan.FalconName = Console.ReadLine();
            Console.WriteLine("Enter Falcon Species: ");
            falconHisan.Species = Console.ReadLine();
            Console.WriteLine("Enter Falcon Sex: ");
            falconHisan.Sex = Console.ReadLine();
            Console.WriteLine("Enter Falcon Weight (with unit): ");
            falconHisan.Weight = Console.ReadLine();
            Console.WriteLine("Enter Falcon Band Number: ");
            falconHisan.BandNumber = Console.ReadLine();

            falconHisan.displayFalcon();

            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
