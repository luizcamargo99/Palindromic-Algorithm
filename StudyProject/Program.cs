using BenchmarkDotNet.Running;
using StudyProject;

Console.WriteLine("rodador".IsPalindrome()); // true
Console.WriteLine("mamam".IsPalindrome()); // true
Console.WriteLine("rir".IsPalindrome()); // true
Console.WriteLine("Livre do poder vil".IsPalindrome()); // true
Console.WriteLine("O trote torto".IsPalindrome()); // true

Console.WriteLine("amor".IsPalindrome()); // false
Console.WriteLine("celular".IsPalindrome()); // false
Console.WriteLine("caneta".IsPalindrome()); // false
Console.WriteLine("pc".IsPalindrome()); // false
Console.WriteLine("abac".IsPalindrome()); // false

//var resultado = BenchmarkRunner.Run<BenchmarkPalindrome>();




