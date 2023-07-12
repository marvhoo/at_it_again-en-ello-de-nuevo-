
namespace Goals
{
    public class Score
    {
    private int _score;


    public Score()
    {
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int scoreIncrease)
    {
        _score += scoreIncrease;
    }
    }
}