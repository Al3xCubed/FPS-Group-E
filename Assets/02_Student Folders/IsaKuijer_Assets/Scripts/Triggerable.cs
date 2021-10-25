using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggerable : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider coll;
    public UnityEvent ontrigger;
    public void Trigger()

    {
        ontrigger.Invoke();
        GetComponent<ProjectileStandard>().OnHit(transform.position, Vector3.forward, coll);
    }
}
