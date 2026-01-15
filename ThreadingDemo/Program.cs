using System.Collections.Generic;

public class Mythread
{
    public void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public void Thread2()
    {
        for (int i = 20; i < 40; i++)
        {
            Console.WriteLine(i);
        }
    }
}
public class ThreadExample
{
    public static void Main(string[] args)
    {
        /*
        Thread t = Thread.CurrentThread;

        t.Name = "main thread";
        Console.WriteLine(t.Name);

        */
        Mythread mythread = new Mythread();
        Thread t1 = new Thread(new ThreadStart(mythread.Thread1));
        Thread t2 = new Thread(new ThreadStart(mythread.Thread2));
        t1.Start();
        t2.Start();

    }
}