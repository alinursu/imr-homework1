using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTargetAnimationChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cactus = this.gameObject.transform.GetChild(0).gameObject;
        GameObject fox = this.gameObject.transform.GetChild(1).gameObject;

        float xCactus = cactus.transform.position.x;
        float xFox = fox.transform.position.x;
        /*
        print(xCactus);
        print(xFox);*/
        
        /*
        if (System.Math.Abs(xCactus - xFox) != 0 && System.Math.Abs(xCactus - xFox) <= 100)
        {
            print("close");
        }*/

    }
}