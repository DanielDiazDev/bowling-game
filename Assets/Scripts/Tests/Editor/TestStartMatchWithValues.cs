using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestStartMatchWithValues
{
    // A Test behaves as an ordinary method
    [Test]
    public void ShouldReturn_ReturnMatchWithAListOfFrames()
    {
        StartMatchWithValues startMatchWithValues = new StartMatchWithValues();
        int numberOfFrames = 10;
        int numberOfPinsToHitDownPerFrame = 10;
        int numberOfShotsPerFrame = 2;

        var result = startMatchWithValues.Create(numberOfFrames, numberOfPinsToHitDownPerFrame, numberOfShotsPerFrame);

    }  
    
}
