using System;
using System.Collections.Generic;

public interface IBowlingView
{
    void SetFramesFinalScore(List<int> finalScores);
    void SetFrameRollScore(int currentFrameIndex, int currentFrameLastRollIndex, int roll);

     void StartNewFrame();

    public event EventHandler OnStartMatch;
    public event EventHandler<int> OnPlayerDoesRoll;
}
