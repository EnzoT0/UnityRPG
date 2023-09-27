using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour
{

    public GameObject tPlayer;
    public int Layer;
    
    // Start is called before the first frame update
    void Start()
    {
        tPlayer = GameObject.FindWithTag("Player");
        tPlayer.layer = Layer;
        tPlayer.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Layer 1");
    }
}
