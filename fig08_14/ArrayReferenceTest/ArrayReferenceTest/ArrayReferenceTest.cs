﻿// Fig. 8.14: ArrayReferenceTest.cs
// Testing the effects of passing array references
// by value and by reference.
using System;

public class ArrayReferenceTest
{
   public static void Main(string[] args)
   {
      int[] firstArray = { 1, 2, 3 };  // create and initialize firstArray

      int[] firstArrayCopy = firstArray;  // copy the reference in variable firstArray

      Console.WriteLine("Test passing firstArray reference by value");
      Console.Write("\nContents of firstArray " +
         "before calling FirstDouble:\n\t");

      // display contents of firstArray
      for (int i = 0; i < firstArray.Length; ++i) Console.Write("{0,3} ", firstArray[i]);

      FirstDouble(firstArray); // pass variable firstArray by value to FirstDouble
      Console.Write("\n\nContents of firstArray after " +
         "calling FirstDouble\n\t");

      // display contents of firstArray
      for (int i = 0; i < firstArray.Length; ++i) Console.Write("{0} ", firstArray[i]);

      Console.Write("\n\nContents of firstArrayCopy after " +
        "calling FirstDouble\n\t");

      // display contents of firstArray
      for (int i = 0; i < firstArrayCopy.Length; ++i) Console.Write("{0} ", firstArrayCopy[i]);


      if (firstArray == firstArrayCopy)  // test whether reference was changed by FirstDouble
         Console.WriteLine("\n\nThe references refer to the same array");
      else
         Console.WriteLine("\n\nThe references refer to different arrays");

      int[] secondArray = { 1, 2, 3 }; // create and initialize secondArray     
      int[] secondArrayCopy = secondArray;  // copy the reference in variable secondArray

      Console.WriteLine("\nTest passing secondArray reference by reference");
      Console.Write("\nContents of secondArray before calling SecondDouble:\n\t");

      // display contents of secondArray before method call
      for (int i = 0; i < secondArray.Length; ++i) Console.Write("{0} ", secondArray[i]);

      // pass variable secondArray by reference to SecondDouble
      SecondDouble(ref secondArray);

      Console.Write("\n\nContents of secondArray after calling SecondDouble:\n\t");

      // display contents of secondArray after method call
      for (int i = 0; i < secondArray.Length; ++i) Console.Write("{0} ", secondArray[i]);

      Console.Write("\n\nContents of secondArrayCopy after calling SecondDouble:\n\t");

      // display contents of secondArray after method call
      for (int i = 0; i < secondArrayCopy.Length; ++i) Console.Write("{0} ", secondArrayCopy[i]);

      // test whether reference was changed by SecondDouble
      if (secondArray == secondArrayCopy)
         Console.WriteLine("\n\nThe references refer to the same array");
      else
         Console.WriteLine("\n\nThe references refer to different arrays");

      Console.WriteLine("\nTecle qualquer tecla para finalizar...");
      Console.ReadKey();
   } // end Main

   // modify elements of array and attempt to modify reference
   public static void FirstDouble(int[] array)
   {
      // double each element's value                          
      for (int i = 0; i < array.Length; ++i)
         array[i] *= 2;

      Console.Write("\nContents of firstArray inside FirstDouble:");
      // display contents of firstArray
      Console.Write("\n\t");
      for (int i = 0; i < array.Length; ++i) Console.Write("{0,3} ", array[i]);

      // create new object and assign its reference to array
      array = new int[] { 11, 12, 13 };

      Console.Write("\nContents of firstArray inside FirstDouble:");
      // display contents of firstArray
      Console.Write("\n\t");
      for (int i = 0; i < array.Length; ++i) Console.Write("{0,3} ", array[i]);
   } // end method FirstDouble                                

   // modify elements of array and change reference array
   // to refer to a new array                            
   public static void SecondDouble(ref int[] array)
   {
      // double each element's value                     
      for (int i = 0; i < array.Length; ++i)
         array[i] *= 2;

      // create new object and assign its reference to array
      array = new int[] { 11, 12, 13 };
   } // end method SecondDouble                          
} // end class ArrayReferenceTest


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
