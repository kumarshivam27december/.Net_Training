class CricketMatchScore
{
    public static void Demo()
    {
        CricketMatch cricketMatch = new CricketMatch();
        string input = Console.ReadLine() ?? "";
        string[] inputArr = input.Split(" ");
        try
        {
            int[] newArr = new int[inputArr.Length];
            int index = 0;
            foreach (var item in inputArr)
            {
                newArr[index++] = Convert.ToInt32(item);
            }

            foreach (var item in newArr)
            {
                cricketMatch.AddPlayerScore(item);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        Console.WriteLine($"Total score of the cricket team: {cricketMatch.CalculateTotalScore()}");
        
    }
}