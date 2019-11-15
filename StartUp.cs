namespace ProektKursova
{
    using System;
    using System.Windows.Forms;

    public static class StartUp
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Scene());


            var square = new Square(2);
            var SquarePerimetur=  square.FindPerimeter();
            Console.WriteLine(SquarePerimetur);
        }
    }
}
