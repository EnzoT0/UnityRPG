using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOrderInLayer : MonoBehaviour
{
    public GameObject tPlayer;
    public int OrderLayer;

    void Start()
    {
        tPlayer = GameObject.FindWithTag("Player");
        tPlayer.GetComponent<SpriteRenderer>().sortingOrder = OrderLayer;
    }
}
