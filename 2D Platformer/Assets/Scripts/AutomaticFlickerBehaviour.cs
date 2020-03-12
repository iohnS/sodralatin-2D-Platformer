using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticFlickerBehaviour : StateMachineBehaviour
{

    readonly float flickerMinTime = 1;
	readonly float flickerkMaxTime = 3;

	float flickerTimer = 0;

	string[] flickerTriggers = { "Flicker1", "Flicker2", "Flicker3" };



    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
		if (flickerTimer <= 0)
		{
			FlickerRandomLight(animator);
			flickerTimer = Random.Range(flickerMinTime, flickerkMaxTime);
		}
		else
		{
			flickerTimer -= Time.deltaTime;

		}


    }

	void FlickerRandomLight(Animator animator)
	{
		System.Random rnd = new System.Random();
		int lightPosition = rnd.Next(flickerTriggers.Length);
		string flickerTrigger = flickerTriggers[lightPosition];
		animator.SetTrigger(flickerTrigger);

	}


    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
