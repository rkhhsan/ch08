using System;

namespace TiposDeArrays
{
   class TiposArrays
   {
      static void Main(string[] args)
      {
         int[] array = new int[5] { 10, -4, 2, 30, 5 };
         Console.Write("---Initial Array Elements---\n");
         foreach (int i in array) Console.Write("  {0}", i);

         Array.Sort(array);
         Console.WriteLine("\n\n---Elements After Sort---");
         foreach (int i in array) Console.Write("  {0}", i);

         Array.Reverse(array);
         Console.WriteLine("\n\n---Elements After Reverse---");
         foreach (int i in array) Console.Write("  {0}", i);

         Console.WriteLine("\n\nPress Enter Key to Exit..");
         Console.ReadLine();

      }//end Main

   }//end class

}//end namespace

