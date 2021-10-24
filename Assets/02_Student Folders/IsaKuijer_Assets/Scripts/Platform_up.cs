using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_up : MonoBehaviour
{
    int number = 3;
    public float speed = 3f;
    bool isOpen = false;
    bool opening = false;
    bool closing = false;
    float timer;
    float timerLength = 1f;
    Vector3 platform1DefaultPos = new Vector3(0, 0, 0);
    


    public Transform platform1;
    

    Collider triggerZone;
    public AudioSource soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        triggerZone = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()

    {
        if (opening && timer > 0f)
        {
           platform1.Translate(-Vector3.up * Time.deltaTime * speed);
            
            timer -= Time.deltaTime;
        }
        else if (opening && timer <= 0f)
        {
            opening = false;
            timer = timerLength;
            closing = true;
        }
        if (closing && timer > 0f)
        {
            platform1.Translate(-Vector3.right * Time.deltaTime * speed);
            timer -= Time.deltaTime;
        }
        else if (closing && timer <= 0f)
        {
            closing = false;
            timer = timerLength;
            isOpen = false;
            platform1.localPosition = platform1DefaultPos;
            

        }

    }
    void OnTriggerEnter(Collider other)
    {
        Damageable check = other.GetComponent<Damageable>();

        if (check == null) return;

        if (!isOpen)
        {
            isOpen = true;
            timer = timerLength;
            opening = true;
            soundEffect.Play();
        }
    }
}