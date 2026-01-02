using System.Globalization;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        StringBuilder stringBuilder = new StringBuilder("Hello world");
        for(int i = 0; i < stringBuilder.Length; i++)
        {
            Console.Write(stringBuilder[i]);
        }

        StringBuilder stringBuilder1 = new StringBuilder();
        stringBuilder1.Append("World1");
        stringBuilder1.Append("Hello ");
        stringBuilder1.AppendLine("World!");
        stringBuilder1.AppendLine("Hello C#");
        Console.WriteLine(stringBuilder1);

        StringBuilder sbAmount = new StringBuilder("Your total amount is ");
        sbAmount.AppendFormat("{0:C}",25);
        Console.WriteLine(sbAmount);

        CultureInfo india = new CultureInfo("en-IN");
        sbAmount.AppendFormat(india,"{0:C}",232112);
        Console.WriteLine(sbAmount);

        StringBuilder sb = new StringBuilder("Hello world");
        sb.Insert(5,"C#");
        Console.WriteLine(sb);

        StringBuilder sb1 = new StringBuilder("Hello world!",50);
        sb1.Remove(6,6);
        Console.WriteLine(sb1);

    }
}
