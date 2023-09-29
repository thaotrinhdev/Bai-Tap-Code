using System.Text;

class ScoreManager
{
    private int playerScore;
    private int computerScore;

    public ScoreManager()
    {
        playerScore = 0;
        computerScore = 0;
    }

    public void UpdateScores(int player, int computer)
    {
        playerScore += player;
        computerScore += computer;
    }

    public void DisplayScores()
    {
        Console.WriteLine($"Player: {playerScore} - Computer: {computerScore}");
    }

    public void SaveScoresToFile(string filePath)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Player,Computer");
        sb.AppendLine($"{playerScore},{computerScore}");

        File.WriteAllText(filePath, sb.ToString());
    }

    public void LoadScoresFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 1)
            {
                string[] scores = lines[1].Split(',');
                if (scores.Length == 2)
                {
                    int.TryParse(scores[0], out playerScore);
                    int.TryParse(scores[1], out computerScore);
                }
            }
        }
    }
}
