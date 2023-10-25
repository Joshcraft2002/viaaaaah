using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100;
    public Animator animator;

    public void Hit(float damage)
    {
        this.health -= damage;

        if(health < 0 )
        {
            Dead();
        }
    }

    private void Dead()
    {

            animator.SetTrigger("")
    }
}
