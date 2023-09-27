using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerSpecific : MonoBehaviour
{
    public string levelName;
    [SerializeField] private Vector3 startPos;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(levelName);
            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = startPos;
        }
    }
}
