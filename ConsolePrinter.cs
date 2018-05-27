using System;

namespace ConsolePrinters {
    public static class Printers {
        public static void print(string message) {
            System.Console.WriteLine(message);
        }

        public static void printBackwards(string message) {
            string backwordString = "";
            for(int charIndex = message.Length - 1; charIndex >= 0; charIndex--) {
                backwordString += message[charIndex];
            }
            System.Console.WriteLine(backwordString);
        }
    }
}