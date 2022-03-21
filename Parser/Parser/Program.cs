using System.IO;
string pathOfWantedDirectory = @"C:\Users\Muhammad Musab\Desktop";
string pathOftheMachineStops;
string pathOfTelegramCopy = @"C:\Users\Muhammad Musab\Desktop\TelegramCopy.txt";
FileInfo TelegramCopy = new FileInfo(pathOfTelegramCopy);
FileInfo MachineStopsFile = null;
string ModifiedText= null;

//Set Current Directory to which ever directory you want
try
{
    Directory.SetCurrentDirectory(pathOfWantedDirectory);
    string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
    foreach (string file in files)
    {
        if(file.Contains("theMachineStops")) //get the file you want 
        {
            pathOftheMachineStops = file;
            MachineStopsFile = new FileInfo(pathOftheMachineStops);
        }
    }
}
catch(IOException e)
{
    Console.WriteLine(e.Message);
}
if(MachineStopsFile.Exists)
{
    try
    {
        using(StreamReader reader = MachineStopsFile.OpenText())
        {
            string TheWholeTextOfFile = reader.ReadToEnd();
            ModifiedText = TheWholeTextOfFile.Replace(".", " STOP,");
        }
    }
    catch (IOException e)
    {
        Console.WriteLine(e.Message);
    }
}
if(!TelegramCopy.Exists)
{
    try
    {
        using(StreamWriter writer = TelegramCopy.CreateText())
        {
            writer.Write(ModifiedText);
        }
    }
    catch(IOException e)
    {
        Console.WriteLine(e.Message);
    }
}
Console.ReadLine();

/*
Begin by placing the file somewhere other than the directory of your new program solution, 
perhaps in your Documents or Downloads.

Create a new console application, “Parser.”

Using the Directory class, set your working directory to the same directory as the file you are working with. 
Use this to get the path of that file, and save that path for use in your application.

Finally, create a method that replaces every period in the text file with the word “STOP,”
and outputs the result to a new text file called “TelegramCopy” in the same directory as the original.

the original is in Desktop
 */
