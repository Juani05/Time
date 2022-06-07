using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txt_time;
    public Text txt_timeFloored;
    public float elapsedTime;
    public bool isCounting;
    public GameObject txt_perdiste;
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        isCounting = false;
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;
        txt_time.text = Time.time.ToString();
        txt_timeFloored.text = Mathf. Floor (currentTime).ToString();
        if (isCounting)
        {
            elapsedTime += Time.deltaTime;
        }
        if (currentTime > 3)
        {
            txt_perdiste.SetActive(true);
        }
    }
}
