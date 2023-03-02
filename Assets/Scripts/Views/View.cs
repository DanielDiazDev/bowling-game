using System;
using System.Collections;
using System.Collections.Generic;
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
            ballScript.Invoke("SetStartPosition", 0.5f);
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
        Debug.Log("PAso por aca");
        pinController = Instantiate(pinControllerPrefab, pinSpawnTransform.position, pinSpawnTransform.rotation).GetComponent<Pin>();
    }
    public void SetRoll(int roll)
    {
        OnPlayerDoesRoll?.Invoke(this, roll);
    }

    public void SetFramesFinalScore(List<int> finalScores)
    {
        throw new NotImplementedException();
    }

    public void SetFrameRollScore(int currentFrameIndex, int currentFrameLastRollIndex, int roll)
    {
        frameScorerViews[currentFrameIndex].SetScoreWithIndex(currentFrameLastRollIndex, roll);
    }
}
