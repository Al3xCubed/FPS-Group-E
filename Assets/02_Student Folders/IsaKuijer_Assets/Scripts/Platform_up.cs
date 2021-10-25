using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_up : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 target;
    public Vector3 direction;
    private Vector3 origin;
    private bool isMoving = false;
  public void Move()
    {
        isMoving = true;
        Debug.Log("hoi");
    }
    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }
    void Start()
    {
        origin = transform.position;
        target = origin + direction;

    }
   
}