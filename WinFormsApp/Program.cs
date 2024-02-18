
namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //string filePath = (@"c:\Users\Notebook HP\Desktop\Sonic.jpg");

            //if (File.Exists(filePath))
            //{
            //    FileInfo fileInfo = new FileInfo(filePath);

            //    Console.WriteLine("File Name: " + fileInfo.Name);
            //    Console.WriteLine("File Size: " + fileInfo.Length + " bytes");
            //    Console.WriteLine("Creation Time: " + fileInfo.CreationTime);
            //    Console.WriteLine("Last Access Time: " + fileInfo.LastAccessTime);
            //    Console.WriteLine("Last Write Time: " + fileInfo.LastWriteTime);
            //    Console.WriteLine("Attributes: " + fileInfo.Attributes);
            //}
            //else
            //{
            //    Console.WriteLine("File not found.");
            //}


        }
    }
}