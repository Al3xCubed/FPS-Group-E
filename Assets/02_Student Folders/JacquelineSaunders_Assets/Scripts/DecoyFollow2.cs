using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyFollow2 : MonoBehaviour
{

    public GameObject FollowTarget;

    Vector3 TargetLocation;
    public Vector3 LastPosition;
    public bool Following = true;
    public GameObject VisualElement;
    public MeshRenderer Mesh;


    Vector3 LoweredVisual = new Vector3(0f, -4.85f, 0f);
    Vector3 UpperVisual = new Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        TargetLocation = FollowTarget.transform.position;
        Mesh = VisualElement.GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Following == true)
        {
            TargetLocation = FollowTarget.transform.position;
            Mesh.enabled = false;
            VisualElement.transform.localPosition = LoweredVisual;

        }
        else if (Following == false)
        {
            TargetLocation = LastPosition;
            Mesh.enabled = true;
            VisualElement.transform.localPosition = UpperVisual;
        }

        transform.position = TargetLocation;
        LastPosition = transform.position;
    }
}
