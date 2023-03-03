using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class View : MonoBehaviour, IBowlingView
{
    [SerializeField] FrameScorerView[] frameScorerViews;
    [SerializeField] Transform pinSpawnTransform;
    [SerializeField] GameObject pinControllerPrefab;
    [SerializeField] Pin pinController;
    [SerializeField] Ball ballScript;
    
    public event EventHandler OnStartMatch;
    public event EventHandler<int> OnPlayerDoesRoll;
    private Presenter presenter;
    // Start is called before the first frame update
    void Start()
    {
        presenter = new Presenter();
        presenter.Initialize(this);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SetRoll(pinController.GetNumberOfPinsHitDown());
            if(pinController != null)pinController.ResetCount();
            ballScript.SetStartPosition();
        }
    }


    // Update is called once per frame
    //private void Update()
    //{

    //    pinController.CheckPinsDown();
    //}



    public void StarMatch()
    {
        OnStartMatch?.Invoke(this, EventArgs.Empty);
    }

    public void StartNewFrame()
    {
        Destroy(pinController.gameObject);
        Invoke("InstatiatePinController", 0.1f);
    }
    void InstatiatePinController()
    {
        pinController = Instantiate(pinControllerPrefab, pinSpawnTransform.position, pinSpawnTransform.rotation).GetComponent<Pin>();
        Debug.Log("instancio");
        Debug.Log(pinController);
    }
    public void SetRoll(int roll)
    {
        OnPlayerDoesRoll?.Invoke(this, roll);
    }


    public void SetFrameRollScore(int currentFrameIndex, int currentFrameLastRollIndex, int roll)
    {
        frameScorerViews[currentFrameIndex].SetScoreWithIndex(currentFrameLastRollIndex, roll);
    }

    public void SetFramesFinalScore(List<int> finalScores)
    {
        for(int i = 0; i < finalScores.Count; i++)
        {
            frameScorerViews[i].SetScoreLast(finalScores[i]);
        }
    }
}
