using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectTrue : MonoBehaviour
{
    
    public GameObject tPlayer;
    // Start is called before the first frame update
    void Start()
    {
        tPlayer = GameObject.FindWithTag("Player");
        tPlayer.SetActive(true);
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
