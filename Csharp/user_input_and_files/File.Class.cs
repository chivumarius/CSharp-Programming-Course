using System.IO;
using System.Text;

namespace CSharp.user_input_and_files;

public class FileClass
{
    public static void FileMethod()
    {
        // ▼ "Relative Path" ▼
        //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";
        
        // ▼ "Absolute Path" ▼
        string path = "C:/Users/mariu/RiderProjects/Csharp/Csharp/user_input_and_files/Example.txt";
        
        
        // ▼ Check if the "File" exists ▼
        if(!File.Exists(path)){
            
            // ▼ "Create" a "File" ▼
            File.Create(path);
        }
        
        
        
        //────────────────────────────────────────────────────────────
        // ▼ Open the "File" & Add "Text" to It ▼
        FileStream fileStream = File.Open(path, FileMode.Append);
         
         
   
    
        //────────────────────────────────────────────────────────────
        // ▼ Add "Text" to the "File" ▼        
        byte[] info = new UTF8Encoding(true).GetBytes("Hello World!");
            
        // ▼ Write "Text" to the "File" ▼
        fileStream.Write(info, 0, info.Length);
        
         // ▼ Close the "File" ▼
        fileStream.Close();
        
        
        
        //────────────────────────────────────────────────────────────
        // ▼ "Read" from a "File" ▼
        StreamReader streamReader = new StreamReader(path);
        
        // ▼ "Read All" the "Text" ▼
        string fileText = streamReader.ReadToEnd();
        
        // ▼ "Print" the "Read Text" ▼
        Console.WriteLine(fileText);
    }
}