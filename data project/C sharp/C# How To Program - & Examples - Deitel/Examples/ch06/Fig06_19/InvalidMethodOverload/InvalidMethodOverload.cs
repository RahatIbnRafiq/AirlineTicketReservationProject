// Fig. 6.19: InvalidMethodOverload.cs
// Demonstrating incorrect method overloading.

public class InvalidMethodOverload
{
   public int Square( double x )
   {
      return x * x;
   }

   // ERROR! Second Square method takes same number, order
   // and types of arguments.
   public double Square( double y )
   {
      return y * y;
   }
} 
