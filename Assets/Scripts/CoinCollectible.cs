using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        HeroController controller = other.GetComponent<HeroController>();
        if (controller != null)
        {
            UpperCornerManager.instance.AddCoin();
            Destroy(gameObject);

            controller.PlaySound(collectedClip);
        }
    }
}
