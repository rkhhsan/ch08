// Fig. 8.2: InitArray.cs
// Creating an array.
using System;

public class InitArray
{
   public static void Main(string[] args)
   {
      int[] array; // declare array named array

      // create the space for array and initialize to default zeros
      array = new int[5]; // 5 int elements

      Console.WriteLine("{0,6}{1,7}", "Index", "Value"); // headings

      // output each array element's value 
      for (int counter = 0; counter < array.Length; ++counter)
         Console.WriteLine("{0,6}{1,7}", counter, array[counter]);

      Console.WriteLine("\nTecle qualquer tecla para finalizar...");
      Console.ReadKey();
   } // end Main
} // end class InitArray


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
