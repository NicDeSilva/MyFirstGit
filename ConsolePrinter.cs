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

        public static void printArray(string[] messages){
            foreach(string word in messages){
                 System.Console.WriteLine(word);
            }
        }

        public static void runAllPrinters() {
            Printers.print("Hello World!");
            Printers.printBackwards("Hello World!");
            Printers.printArray(new string[]{"Hello", "World", "!"});
        }
    }
}