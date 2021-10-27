using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyToggle : MonoBehaviour
{
    public bool Toggle = false;
    public float TimeToRecharge = -3;
    public float timer = 0;
    public AudioClip startSFX;
    public AudioClip stopSFX;
    bool Sounded = false;

    public DecoyFollow2 Decoyscript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Tech") && timer == 0) {
            Decoyscript.Following = false;
            timer = TimeToRecharge;
            AudioUtility.CreateSFX(startSFX, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
            Sounded = false;
        }
        if (timer < 0)
        {
            timer += Time.deltaTime;
            


        }

        

        if (timer >= 0)
        {
            timer = 0;
            
        }
        else if (timer >= TimeToRecharge / 2) {
            Decoyscript.Following = true;
            if (Sounded == false)
            {
                Sounded = true;
                AudioUtility.CreateSFX(stopSFX, transform.position, AudioUtility.AudioGroups.WeaponOverheat, -2f);
            }
        }
    }
}
