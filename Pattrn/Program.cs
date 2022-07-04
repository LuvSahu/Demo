namespace PraticeProblems
{
    class program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Choose a number to go to the respective problem \n");
            Console.WriteLine("1 for Pattern");
            Console.WriteLine("2 for Swapping without third variable");
            Console.WriteLine("3 for Multiply number");
            Console.WriteLine("4 for Find Max Min and Avg of num");
            Console.WriteLine("5 for Check character is Vowel and consonant");



            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Pattern pt = new Pattern();
                    pt.Pttrn();
                    break;

                case 2:
                    SwappingWithoutUsingThirdvariable swap = new SwappingWithoutUsingThirdvariable();
                    swap.Swap();
                    break;

                case 3:
                    Multiply multi = new Multiply();
                    multi.Mul();
                    break;

                case 4:
                    FindNumber findNumber = new FindNumber();
                    findNumber.Number();
                    break;

                case 5:
                    CheckVowelsConsonant vowelsConsonant = new CheckVowelsConsonant();
                    vowelsConsonant.VwlConsonant();
                    break;
            }
        }

    }
}
