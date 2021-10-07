using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTargetAnimationChange : MonoBehaviour
{
    public float distance = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dog = this.transform.GetChild(0).GetChild(0);
        var eagle = this.transform.GetChild(1).GetChild(0);
         
        float xDog = dog.transform.position.x;
        float xEagle = eagle.transform.position.x;

        if (System.Math.Abs(xDog - xEagle) != 0 && System.Math.Abs(xDog - xEagle) <= distance)
        {
            dog.transform.GetComponent<Animation>().CrossFade("Attack01");
            eagle.transform.GetComponent<Animation>().CrossFade("Attack1");
        }
        else
        {
            dog.transform.GetComponent<Animation>().CrossFade("Idle_Battle");
            eagle.transform.GetComponent<Animation>().CrossFade("Run");
        }
    }
}
