#region 1
// string path = @"c:\Users\admin\Desktop\exam.txt";
// using (FileStream stream = new FileStream(path, FileMode.Append))
// {
//     using (StreamWriter writer = new StreamWriter(stream))
//     {
//         writer.WriteLine("Hello World");
//     }
// }
#endregion


#region 3

// using System.Net.WebSockets;

// string path = @"c:\Users\admin\Desktop\Examen\";
// Directory.CreateDirectory(path);
// string path2 = @"c:\Users\admin\Desktop\Examen\Exam.txt";
// File.Create(path2);
// foreach (var item in Directory.GetFiles(path))
// {
//     System.Console.WriteLine(item);
// }

//Напишите программу, которая создает папку, создает внутри неё несколько файлов, а затем выводит список всех файлов в папке.
#endregion


#region 4
// using System.IO.Compression;

// string path = @"c:\Users\admin\Desktop\Examen";

// ZipFile.CreateFromDirectory(path,@"c:\Users\admin\Desktop\Examen.zip");

//Напишите программу, которая берет все файлы в папке и архивирует их в ZIP-архив с именем `backup.zip`.
#endregion


#region 7

// string path2 = @"C:\Users\admin\Desktop\Exam\test.txt";

// using (StreamReader reader = new StreamReader(path2))
// {
//     System.Console.WriteLine(reader.ReadToEnd());
// }

//Реализуйте программу, которая читает текстовый файл построчно и выводит содержимое на консоль.
#endregion


#region 8
// string path = @"C:\Users\admin\Desktop\Examen\Exam.txt";
// string path2 = @"C:\Users\admin\Desktop\Examen\newExam.txt";

// File.Copy(path, path2);

// File.Delete(path);
#endregion


#region 12
// foreach (var item in Directory.GetFiles(@"C:\Users\admin\Desktop\Examen"))
// {
//     System.Console.WriteLine(item);
// }

#endregion


#region 15
// using System.IO.Compression;

// string path = @"c:\Users\admin\Desktop\Examen.zip";

// ZipFile.ExtractToDirectory(path, @"c:\Users\admin\Desktop\NewZipFile.zip");
#endregion


#region 16

// byte[] e = File.ReadAllBytes(@"c:\Users\admin\Desktop\Examen\newExam.txt");
// foreach (var i in e)
// {
//     System.Console.Write(i);
// }
#endregion


#region 17
// System.Console.WriteLine(File.GetLastAccessTime(@"c:\Users\admin\Desktop\Examen\newExam.txt"));
#endregion


#region 19
// string path = @"c:\Users\admin\Desktop\exam.txt";
// using (FileStream stream = new FileStream(path, FileMode.Append))
// {
//     using (StreamWriter writer = new StreamWriter(stream))
//     {
//         writer.WriteLine("Hello World");
//     }
// }
#endregion


#region 9
string path = @"C:\Users\admin\Desktop\Examen\Exam.txt";
string path2 = @"C:\Users\admin\Desktop\Examen\newExam.txt";

File.Copy(path, path2);
#endregion