using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class AddTargetToGroup : MonoBehaviour
{
    public GameObject Character;
    private CinemachineTargetGroup targetGroup;
    public Transform player;

    void Awake()
    {
        GameObject Hero = Instantiate(Character);
        player = Hero.transform;
        targetGroup = Hero.GetComponent<CinemachineTargetGroup>();
            //GameObject.Find("TargetGroupPlayer").GetComponent<CinemachineTargetGroup>();

        //Add members to follow group
        targetGroup.AddMember(player, 1f, 0f);
    }
}

