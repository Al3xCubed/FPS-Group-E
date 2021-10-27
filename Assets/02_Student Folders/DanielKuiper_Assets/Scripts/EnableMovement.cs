using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableMovement : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ModdedPlayerCharacterController>())
        {
            other.GetComponent<ModdedPlayerCharacterController>().MovementEnabled = true;
        }
    }
}
