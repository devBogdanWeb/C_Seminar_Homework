using System;

class MainClass {
  public static void Main (string[] args) {
    int n = 8;
    PrintNumbers(n);
  }

  public static void PrintNumbers(int n) {
    if (n < 1) {
      return;
    }
    Console.Write(n + " ");
    PrintNumbers(n - 1);
  }
}