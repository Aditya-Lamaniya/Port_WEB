using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacle : MonoBehaviour
{
    [SerializeField]
    float rate = 2f;
    float next = 0;
    [SerializeField]
    GameObject obstacle;
    [SerializeField]
    GameObject obstacleContainer;
    void Update()
    {
        if(Time.time>next)
        {
            next = Time.time + rate;
            Instantiate(obstacle,obstacleContainer.transform);
        }
    }
}
