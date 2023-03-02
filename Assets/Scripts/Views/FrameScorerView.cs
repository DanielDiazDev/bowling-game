using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FrameScorerView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] scorersText;

    public void SetScoreWithIndex(int index, int score)
    {
        Debug.Log(score);
        scorersText[index].text = score.ToString();
    }

}
