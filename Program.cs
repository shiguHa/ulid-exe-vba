using System;

namespace ULIDConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                // コマンド引数がない場合、ULIDを生成して返す
                string ulid = Ulid.NewUlid().ToString();
                Console.WriteLine(ulid);
            }
            else if (args.Length == 2 && args[0] == "-convertDateTime")
            {
                // コマンドが -convertDateTime で、ULID値が渡された場合
                string ulidString = args[1];
                try
                {
                    Ulid ulid = Ulid.Parse(ulidString);
                    var dateTimeOffset = ulid.Time;
                    Console.WriteLine(dateTimeOffset.ToString("o")); // ISO 8601形式で日時を返す
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid arguments.");
            }
        }
    }
}
