using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveDialogue : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    float timerDisplay;
    float timeDisplayStart;
    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(true);
        timeDisplayStart = displayTime;
        timerDisplay = -1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeDisplayStart >= 0)
        {
            timeDisplayStart -= Time.deltaTime;
            if (timeDisplayStart < 0)
            {
                dialogBox.SetActive(false);
            }
        }
    }

    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        dialogBox.SetActive(true);
    }
}
