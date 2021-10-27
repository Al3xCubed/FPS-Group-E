using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisabler : MonoBehaviour
{
    public GameObject Block1;
    public GameObject Block2;
    public float timer = 0;
    public float time1;
    public float time2;
    private MeshRenderer Mesh1;
    private MeshRenderer Mesh2;

    // Start is called before the first frame update
    void Start()
    {
        Mesh1 = Block1.GetComponent<MeshRenderer>();
        Mesh2 = Block2.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

       
            if (timer >= time1)
            {
                Mesh1.enabled = false;

            }

            if (timer >= time2)
            {
                Mesh2.enabled = false;
            }
        
      
    }
}
