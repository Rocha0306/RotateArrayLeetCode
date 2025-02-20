namespace Structures
{
    
    public class Problems
    {
        public static void Main(String[] args)
        {
            int lenght; 
            // Comentário adicional - Victor (ATV1 Eng.Software III)
            Console.WriteLine("Write the lenght: ");
            int.TryParse(Console.ReadLine(), out lenght);

            while(lenght <= 0)
            {
                Console.WriteLine("Deixa de ser palhaço");
                Console.WriteLine("Write the lenght: ");
                int.TryParse(Console.ReadLine(), out lenght);
            }


            int[] array = new int[lenght];
            int[] RotatedArray = new int[lenght];
            int k;
            int positionsoccuped = 0;

        
            int number; 
            // 0, 1, 2, 3, 4, 5

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                int.TryParse(Console.ReadLine(), out number);
                array.SetValue(number, i);
            }

            Console.WriteLine("Write k: ");
            int.TryParse(Console.ReadLine(), out k);
            while (k == array.Length || k <= 0 || k > array.Length) 
            {
                Console.WriteLine("\nPode não chapa");
                Console.WriteLine("Write k: ");
                int.TryParse(Console.ReadLine(), out k);
            }


            //after K
            for(int i = 0; i < array.Length; i++) //array.lenght = 5, i = 1;
            {
                if (k != array.Length - 1)
                {
                    k++;
                    int valueafterk = (int)array.GetValue(k);
                    RotatedArray.SetValue(valueafterk, i);
                    positionsoccuped++;

                }
            }


            //before k
            int x = 0;
            for (int j = positionsoccuped; j < array.Length; j++)
            {
                int valuebeforek = (int)array.GetValue(x); //
                RotatedArray.SetValue(valuebeforek, j);
                x++;

            }



            for (int i = 0; i < RotatedArray.Length; i++)
            {
                Console.WriteLine("\nContent: " + RotatedArray[i]);
            }




          


           

          
        }
    }
}