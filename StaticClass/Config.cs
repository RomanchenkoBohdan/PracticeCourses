using System;
using System.IO;

namespace StaticClass
{
    public static class Config
    {
        public static string Path{ get; set; }
        public static string Text{ get; set; }
        static Config()
        {
            Path = "default.txt";
        }

        public static void WriteLine()
        {
            if (Path != null)
            {
                using (StreamWriter file = new StreamWriter(Path, true))
                {
                    file.WriteLine(Text);
                }
            }
            else
            {
                using (StreamWriter file = new StreamWriter("test.txt", true))
                {
                    file.WriteLine(Text);
                }
            }            

            Console.WriteLine("Good job");
        }

        public static string ReadLine()
        {
            using (StreamReader streamReader = new StreamReader(Path, true))
            {
                var result = streamReader.ReadToEnd();
                //Console.WriteLine(result);

                return result;
            }
        }

    }
}
