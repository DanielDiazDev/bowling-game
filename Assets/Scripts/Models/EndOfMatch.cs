using System.Collections.Generic;

public class EndOfMatch
{
    MatchScorer matchScorer;

    public EndOfMatch(MatchScorer matchScorer)
    {
        this.matchScorer = matchScorer;
    }

    public bool CheckEndOfMatch(Match match)
    {
        return (match.IsLastFrame() && IsFrameComplete(match.CurrentFrame()));
    }

    bool IsFrameComplete(Frame frame)
    {
        return !frame.AreThereAnyPinsToHitDown() || !frame.HaveRollsToDo();
    }


    public List<int> ScoreEndOfMatch(Match match)
    {
        return matchScorer.Score(match);
    }
}

