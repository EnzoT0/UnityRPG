using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FollowPlayerWithoutCoordinates : MonoBehaviour
{
    public GameObject tPlayer;
    public Transform tFollowTarget;
    private CinemachineVirtualCamera vcam;
    //[SerializeField] private Vector3 startPos;

    // Use this for initialization
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
        tPlayer = GameObject.FindWithTag("Player");
        //tPlayer.transform.position = startPos;
        tFollowTarget = tPlayer.transform;
        //vcam.LookAt = tFollowTarget;
        vcam.Follow = tFollowTarget;
    }

}

