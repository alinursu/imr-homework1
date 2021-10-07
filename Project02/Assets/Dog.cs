using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public const string IDLE = "Idle_Battle";
    public const string ATTACK = "Attack01";

    private Animation animation;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    public void IdleAni()
    {
        animation.CrossFade(IDLE);
    }

    public void AttackAni()
    {
        animation.CrossFade(ATTACK);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
