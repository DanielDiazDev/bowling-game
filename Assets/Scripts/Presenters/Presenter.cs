using System;
using System.Collections;
using UnityEngine;

public class Presenter
{
    IBowlingView bowlingView;
    Match match;
    StartMatchWithValues startMatch;
    PlayerDoesRoll playerDoesRoll;
    EndOfMatch endOfMatch;
    int numberOfFrames = 10;
    int numberOfPinsToHitDownPerFrame = 10;
    int numberOfShotsPerFrame = 2;

    public void Initialize( IBowlingView bowlingView)
    {
       this.bowlingView = bowlingView;
        this.bowlingView.OnStartMatch += StartMatch;
        this.bowlingView.OnPlayerDoesRoll += PlayerDoesRoll;


        startMatch = new StartMatchWithValues();
        playerDoesRoll = new PlayerDoesRoll();
        endOfMatch = new EndOfMatch(new MatchScorer());
    }



    void StartMatch(object sender, EventArgs e)
    {
        startMatch.Create(numberOfFrames, numberOfPinsToHitDownPerFrame, numberOfShotsPerFrame);
    }

    void PlayerDoesRoll (object sender, int roll)
    {
        playerDoesRoll.ResolveRoll(roll, match);
        if (endOfMatch.CheckEndOfMatch(match)) EndOfMatch();    
    }

    void EndOfMatch()
    {
        bowlingView.SetFramesFinalScore(endOfMatch.ScoreEndOfMatch(match));
    }
}
