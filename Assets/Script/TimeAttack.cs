using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public float LimitTime;
    public TextMeshProUGUI text_timer;

    void Update()
    {
        LimitTime -= Time.deltaTime;
        text_timer.text = "Time : " + Mathf.Round(LimitTime);
    }
}
