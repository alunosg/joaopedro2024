using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform targetPosition;

    public void OnTriggerStay(Collider hit)
    {
        if(hit.CompareTag("Player"))
        {
            hit.transform.position = targetPosition.position;
            Debug.Log("teleportei para " + targetPosition.name);
            hit.GetComponent<PlayerController>().Teleport();
        }
    }
}