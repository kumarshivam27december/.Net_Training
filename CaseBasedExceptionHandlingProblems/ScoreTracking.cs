class ScoreTracking
{
    public static void Solve()
    {
        CricketMatch cricketMatch = new CricketMatch();

        string input = Console.ReadLine() ?? "";
        string[] inputArr = input.Split(" ");
        foreach (var item in inputArr)
        {
            try
            {

                var num = Convert.ToInt32(item);
                cricketMatch.AddPlayerScore(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return;
            }
        }

        if (inputArr.Length <= 5)
        {

            Console.WriteLine(cricketMatch.CalculateScore());
        }
        else
        {
            return;
        }
    }
}