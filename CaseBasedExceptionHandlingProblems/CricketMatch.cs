class CricketMatch
{
    public int[] playerScores = new int[5];
    public int currentIndex = 0;

    public void AddPlayerScore(int score)
    {

        if (score < 0 || score > 50)
        {
            throw new ArgumentOutOfRangeException("score", "should be between 0 to 50");
        }

        if (currentIndex >= 5)
        {
            throw new InvalidOperationException("Cannot add more than 5 player scores.");
        }

        playerScores[currentIndex] = score;
        currentIndex++;
    }


    public int CalculateScore()
    {
        int cnt = 0;
        int temp = 0;
        foreach (var item in playerScores)
        {
            cnt++;
            temp += item;
        }
        return temp;
    }
}