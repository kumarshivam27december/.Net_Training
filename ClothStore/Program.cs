using System;
class Program
{
    public static void Main(string[] args)
    {
        int menid, mensize,womenid,womensize;
        string womenclothmaterialtype;
        int kidid,kidsize;
        menid = Convert.ToInt32(Console.ReadLine());
        mensize = Convert.ToInt32(Console.ReadLine());
        womenid = Convert.ToInt32(Console.ReadLine());
        womensize = Convert.ToInt32(Console.ReadLine());
        womenclothmaterialtype = Console.ReadLine() ?? "";
        kidid = Convert.ToInt32(Console.ReadLine());
        kidsize = Convert.ToInt32(Console.ReadLine());

        Men men = new Men(menid,mensize);
        men.DisplayInfo();

        Women women = new Women(womenid,womensize,womenclothmaterialtype);
        women.DisplayInfo();

        Kid kid = new Kid(kidid,kidsize);
        kid.DisplayInfo();

    }
}