using System;
using f2d;


class Program {
    public static void Main(string[] args) {
        Converter cv = new Converter();
        
        Console.WriteLine(cv.Convert(1, 10));
    }
}
