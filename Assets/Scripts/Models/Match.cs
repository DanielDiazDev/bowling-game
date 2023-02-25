using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Match 
{
    public List<Frame> Frames { get; }
    int currentFrameIndex = 0;

    public Match(List<Frame> frames)
    {
        Frames = frames;
    }

    public Frame CurrentFrame()
    {
        return Frames[currentFrameIndex];
    }

    public void MoveToNextFrame()
    {
        if(currentFrameIndex < Frames.Count -1 )currentFrameIndex++;
    }

    public bool IsLastFrame()
    {
        return currentFrameIndex == Frames.Count - 1;
    }
}
