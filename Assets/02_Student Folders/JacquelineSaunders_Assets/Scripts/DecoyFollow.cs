using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyFollow : MonoBehaviour
{

    public GameObject FollowTarget;

    

    public bool DecoyFollowing = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (DecoyFollowing = true)
            gameObject.transform.SetParent(FollowTarget.transform);
        else
            gameObject.transform.SetParent(null);
         
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      





    }
}
