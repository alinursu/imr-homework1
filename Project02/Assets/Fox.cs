using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    public const string IDLE = "Fox_Idle";
    public const string ATTACK = "Fox_Attack_Paws";

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
