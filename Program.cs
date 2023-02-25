

public class program
{
    public static void main()
    {
        // calculating number of speces from string
        Console.WriteLine("please enter any string");
        var str = Console.ReadLine();
        int spaceCounter = 0;
        foreach (char ch in str)
        {
            if (ch == ' ')
            {
                spaceCounter++;
            }
            Console.WriteLine("Number of spaces =" + spaceCounter);
        }


        static void consontcounter()
        {
            // calculating nuber of consonent
            Console.WriteLine("please enter any string");
            var str = Console.ReadLine();
            int consonentCounter = 0;
            foreach (char ch in str)
            {
                if (!(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == ' ')
                        )
                {
                    consonentCounter++;
                }
                Console.WriteLine("Number of consonent =" + consonentCounter);
            }
        }
        static void numberofword()
        {
            // calculating number of word
            Console.WriteLine("please enter any string");
            var str = Console.ReadLine();
            int WordCounter = 0;
            foreach (char ch in str)
            {
                if (ch == ' ')
                {
                    WordCounter++;
                }
                Console.WriteLine("Number of word =" + WordCounter + 1);
            }
            static void fullname()
            {
                // showing full name
                string FirstName, MiddleName, LastName, FullName;

                Console.WriteLine("Please Enter First Name");
                FirstName = Console.ReadLine();

                Console.WriteLine("Please Enter Middle Name");
                MiddleName = Console.ReadLine();

                Console.WriteLine("Please Enter Last Name");
                LastName = Console.ReadLine();

                FullName = FirstName + " " + MiddleName + " " + LastName;
                Console.WriteLine(FullName);
            }
            static void CalculateVowels()
            {
                //caluculate the vowels from the string

                Console.WriteLine("Please enter any string");
                var str = Console.ReadLine();   //Welcome

                int VowelsCounter = 0;
                foreach (var item in str)
                {

                    if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ||
                        item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
                    {
                        VowelsCounter++;
                    }

                }

                Console.WriteLine("Number of vowels in the string = " + VowelsCounter);
            }
        }
    }

}

   
