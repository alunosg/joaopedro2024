using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnTouch : MonoBehaviour
{
    public GameObject target;

    public void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player"))
        {
            target.SetActive(true);
        }
    }
}