using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyFollow2 : MonoBehaviour
{

    public GameObject FollowTarget;

    Vector3 TargetLocation;
    public Vector3 LastPosition;
    public bool Following = true;


    // Start is called before the first frame update
    void Start()
    {
        TargetLocation = FollowTarget.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Following == true)
        {
            TargetLocation = FollowTarget.transform.position;


        }
        else if (Following == false)
        {
            TargetLocation = LastPosition;

        }

        transform.position = TargetLocation;
        LastPosition = transform.position;
    }
}
