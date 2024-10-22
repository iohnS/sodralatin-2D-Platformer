﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }

    public void TakeDamage (int damage)
	{
        currentHealth -= damage;

        //Play hurt animation

        animator.SetTrigger("Hurt");



        if (currentHealth <= 0 )
		{
            Die();

		}
	}

    void Die()
	{

        Debug.Log("Enemy died)");


        //Die animation

        animator.SetBool("IsDead", true);


        //Disable enemy = dissable this script

        //GetComponent<CircleCollider2D>().enabled = false; 
        //GetComponent<Seeker>().enabled = false;
        //GetComponent<Rigidbody2D>().enabled = false;

        GetComponent<Rigidbody2D>().isKinematic = true;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        GetComponent<EnemyAI1>().enabled = false;

        this.enabled = false;


	}
}
