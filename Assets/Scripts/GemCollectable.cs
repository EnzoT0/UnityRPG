using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollectable : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        HeroController controller = other.GetComponent<HeroController>();
        if (controller != null)
        {
            UpperCornerManager.instance.AddGem();
            Destroy(gameObject);

            controller.PlaySound(collectedClip);
        }
    }
}
