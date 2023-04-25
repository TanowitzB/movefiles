using System;
using System.Diagnostics;
using System.IO;

class Program
{


    static void Main(string[] args)
    {
        moveFiles(@"SourceFolder");



    }
    static void moveFiles(string source)
    {
        string destFolder = @"DestinationFolder";
        string sourceFolder = source;
        string[] files = Directory.GetFiles(sourceFolder);
        string[] folders = Directory.GetDirectories(sourceFolder);
        foreach (string folder in folders)
        {
            moveFiles(folder);
        }
        foreach (string file in files)
        {
            //change pdf to whatever file extension
            if (Path.GetExtension(file).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
               
                //File.Copy(file, @destFolder + "\\" + @changeString(file));
                //use copy to copy and move to move
                File.Move(file, @destFolder + "\\" + @changeString(file));
            }
        }
    }

    static string changeString(string str)
    {
        int index = -1;
        for(int i = 0; i < str.Length; i++) 
        {
            if (str[i] == '\\') 
            {
                index = i;
            }
            
        }
        string temp = str.Substring(index + 1);


        return temp;
    }
}



