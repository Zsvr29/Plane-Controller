using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float dakika, saniye;

    
    void Start()
    {
        dakika = 1;
        saniye = 29;
    }

    
    void Update()
    {
        saniye-=Time.deltaTime;
        text.text = "" + dakika + ":" + (int)saniye;
        if (saniye <= 0)
        {
            dakika--;
            saniye = 59;

        }
    }
}
