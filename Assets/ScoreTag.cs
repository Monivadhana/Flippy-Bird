using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTag : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Text;
    [SerializeField] ScoreUpdate scoreupdate;

    private void Update()
    {
        Text.text =  scoreupdate.currentScore.ToString();
    }
}
