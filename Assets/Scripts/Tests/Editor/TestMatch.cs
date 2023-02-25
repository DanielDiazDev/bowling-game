using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
//using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class TestMatch
{
    /*
     * Deberia inicializar con cantidad de turnos, 
       cantidad de tiradas por turno y cantidad de pinos a tirar por turno.
     * Deberia cambiar al siguiente turno
     * Deberia saber si es el ultimo el ultimo turno
     * 
     *
     */

    [SetUp]
    public void Setup()
    {
       
    }
    [Test]
    public void InicializeWithAListOfFrames()
    {
        List<Frame> frames = new List<Frame>() { new Frame(10, 2) };
        Match match = new Match(frames);

        var result = match.Frames;

        Assert.AreEqual(frames, result);
    }
    [Test]
    public void CurrentFrame_WhenInicialize_ReturnFirstFrame()
    {
        Frame frame1 = new Frame(10, 2);
        Frame frame2 = new Frame(10, 2);
        List<Frame> frames = new List<Frame>() { frame1, frame2 };
        Match match = new Match(frames);

        var result = match.CurrentFrame();

        Assert.AreEqual(frame1, result);
    }
    [Test]
    public void MoveToNextFrame_WhenActualIsFirstFrame_ActualFrameWillBeSecond()
    {
        //Arrange
        Frame frame1 = new Frame(10, 2);
        Frame frame2 = new Frame(10, 2);
        List<Frame> frames = new List<Frame>() { frame1, frame2 };
             
        Match match = new Match(frames);
        
        //Act
        Assert.AreEqual(frame1, match.CurrentFrame());
        match.MoveToNextFrame();
        var result = match.CurrentFrame();
        //Assert
        Assert.AreEqual(frame2, result);
    }
    [Test]
    public void IsLastFrame_WhenCurrentFrameIsLast_ReturnTrue()
    {
        //Arrange
        Frame frame1 = new Frame(10, 2);
        Frame frame2 = new Frame(10, 2);
        List<Frame> frames = new List<Frame>() { frame1, frame2 };

        Match match = new Match(frames);

        //Act
        match.MoveToNextFrame();
        bool result = match.IsLastFrame();

        //Assert
        Assert.AreEqual(frames.Last(), match.CurrentFrame());
        Assert.IsTrue(result);
    }



}