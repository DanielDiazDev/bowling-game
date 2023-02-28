using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour, IBowlingView
{
    
    public event EventHandler OnStartMatch;
    public event EventHandler<int> OnPlayerDoesRoll;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void SetFramesFinalScore(List<int> finalScores)
    {
        throw new NotImplementedException();
    }

    void IBowlingView.SetFramesFinalScore(List<int> finalScores)
    {
        throw new NotImplementedException();
    }
}
