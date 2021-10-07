using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    public const string RUN = "Run";
    public const string ATTACK = "Attack1";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RunAni()
    {
        GetComponent<Animation>().CrossFade(RUN);
    }

    public void AttackAni()
    {
        GetComponent<Animation>().CrossFade(ATTACK);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
