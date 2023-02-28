using System;
using System.Collections.Generic;

public interface IBowlingView
{
    void SetFramesFinalScore(List<int> finalScores);

    public event EventHandler OnStartMatch;
    public event EventHandler<int> OnPlayerDoesRoll;
}
