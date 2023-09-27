using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkOrGrow : MonoBehaviour
{
    public GameObject tPlayer;
    [SerializeField] private Vector3 scalepos;

    // Use this for initialization
    void Start()
    {
        tPlayer = GameObject.FindWithTag("Player");
        tPlayer.transform.localScale = scalepos;
    }
}
