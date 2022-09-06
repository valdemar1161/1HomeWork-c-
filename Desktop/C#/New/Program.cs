int a, b, c ;
 
        Console.WriteLine("Введите три числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());

        c = Convert.ToInt32(Console.ReadLine());
        if (a > b)
          

 
        {
 
            Console.WriteLine("{0} наибольшее число ", a);
            
            

        }
 
        if (c > b)
 
        {
 
            Console.WriteLine("{0} наибольшее число ", c);
            
        }
 
        if (b > c)
        {

            Console.WriteLine("{0} наибольшее число ", b);

        }    
        Console.ReadLine();