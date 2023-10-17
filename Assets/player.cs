using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private int Health = 3;
    private void OnTriggerEnter(Collider other)
    {
        Health--;
        if(Health<0)
        {
            Destroy(this.gameObject);
            Health = 3;
        }
    }
}
