// See https://aka.ms/new-console-template for more information
using Boolean.CSharp.Main;
using Boolean.CSharp.Main.Misc;

Core core = new Core();
Extension extension = new Extension();
//extension.add(1,2);
extension.subtract("hej", 'e');
extension.multiply("yo", 3);
string[] input = ["2", "32", "16"];
extension.multiply(input, 2);