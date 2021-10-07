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
        var cactus = this.transform.GetChild(0).GetChild(0);
        var fox = this.transform.GetChild(1).GetChild(0);
         
        float xCactus = cactus.transform.position.x;
        float xFox = fox.transform.position.x;

        if (System.Math.Abs(xCactus - xFox) != 0 && System.Math.Abs(xCactus - xFox) <= distance)
        {
            cactus.transform.GetComponent<Animation>().CrossFade("Attack01");
            fox.transform.GetComponent<Animation>().CrossFade("Fox_Attack_Paws");
        }
        else
        {
            cactus.transform.GetComponent<Animation>().CrossFade("Idle_Battle");
            fox.transform.GetComponent<Animation>().CrossFade("Fox_Idle");
        }
    }
}
