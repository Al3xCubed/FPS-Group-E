using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOrbit : MonoBehaviour
{
    public float Gravity;
    public bool inverted;
    public bool fixedDirection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ModdedPlayerCharacterController>())
        {
            other.GetComponent<ModdedPlayerCharacterController>().gravityField = this.GetComponent<GravityOrbit>();
        }
    }
}
