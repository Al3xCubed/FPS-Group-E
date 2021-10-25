using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    private Triggerable[] triggerables;

    // Start is called before the first frame update
    void Start()
    {
        triggerables = Object.FindObjectsOfType<Triggerable>();   
    }

    // Update is called once per frame
    void Update()
    {
      foreach (Triggerable triggerable in triggerables) {
            Vector3 point = triggerable.coll.ClosestPointOnBounds(transform.position);
            bool inCollider = triggerable.coll.bounds.Contains(transform.position);
            float distance = Vector3.Distance(point, transform.position);
            if (distance < 0.5f || inCollider)
            {
                triggerable.Trigger();
            }
      } 
     
    }
}
