using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpperCornerManager : MonoBehaviour
{
    public static UpperCornerManager instance;

    public Text coinText;
    public Text gemText;

    int amount = 0;
    int gemAmount = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Coins: " + amount.ToString();
        gemText.text = "Gems: " + gemAmount.ToString();
    }

    public void AddCoin()
    {
        amount += 1;
        coinText.text = "Coins: " + amount.ToString();
    }

    public void AddGem()
    {
        gemAmount += 1;
        gemText.text = "Gems: " + gemAmount.ToString();
    }
}
