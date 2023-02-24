using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestFrameShould
{
    /*
     -Deberia inicializar con una cantidad de pinos a tirar, y una cantidad maxima de tiradas a realizar
     -Deberia poder agregar una tirada( agregar un int a una lista de int)
     -Deberia poder devolver la cantidad de pinos tirados (PENDIENTE)
     */
    public int numberOfPins;
    public int numberOfRolls;

    [SetUp]
    public void Setup()
    {
        numberOfPins = 10;
        numberOfRolls = 2;
    }


    // A Test behaves as an ordinary method
    [Test]
    public void InicializeWithANumberOfPinsToHsitDownAndMaxNumberOfRolls()
    {
        var frame = new Frame(numberOfPins, numberOfRolls);

        Assert.AreEqual(numberOfPins, frame.NumberOfPinsToHitDown);
        Assert.AreEqual(numberOfRolls, frame.MaxNumberOfRolls);
    }
    [Test]
    public void AddRoll()
    {
        int roll = 3;
        var frame = new Frame(numberOfPins, numberOfRolls);

        frame.AddRoll(roll);

        Assert.IsNotEmpty(frame.Rolls);
    }
}
