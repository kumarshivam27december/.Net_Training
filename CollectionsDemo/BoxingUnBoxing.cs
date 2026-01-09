using System.Collections;
class BoxingUnBoxing
{
    //var cannot be used at class level but dynamic can be used at class level
    public static void Demo()
    {
        object obj;
        int i = 10;
        obj = i; //boxing

        int j = (int)obj; //unboxing

        ArrayList list = new ArrayList();
        //boxing
        list.Add(10);
        list.Add(false);
        list.Add(65.5f);
        //unboxing
        int k = (int) list[0];
        var v = list[1];
        bool t = (bool)v;
    }
}