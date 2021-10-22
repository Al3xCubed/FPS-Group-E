using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutomaticOpening : MonoBehaviour
{
    int number = 3;
    public float speed = 3f;
    bool isOpen = false;

    public Transform door_1_right;
    public Transform door_2_left;

    public Collider triggerzone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isOpen) door_1_right.GetComponent<Transform>().Translate(Vector3.left * Time.deltaTime * speed);
    }

    void OnTriggerEnter (Collider other)
    {
        if (isOpen)
        {
            isOpen = true;
        }
    }
}
