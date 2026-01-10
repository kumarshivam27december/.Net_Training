class CricketMatch
{
    public int[] playerScores = new int[5];
    public int currentIndex = 0;

    public void AddPlayerScore(int score)
    {
        if(score<0 || score > 50)
        {
            throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
        }
        if (currentIndex >= 5)
        {
            throw new InvalidOperationException("Cannot add more than 5 player scores");
        }
        playerScores[currentIndex++]+=score;
    }

    public int CalculateTotalScore()
    {
        int total = 0;
        foreach (var item in playerScores)
        {
            total+=item;   
        }
        return total;
    }
}