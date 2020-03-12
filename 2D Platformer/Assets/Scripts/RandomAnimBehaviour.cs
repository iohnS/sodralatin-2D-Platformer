using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimBehaviour : StateMachineBehaviour
{
    //Genom att byta "flickerAnimID" till någon annan animation så kan man animera en random annan animation (t.ex. attack)

	public string m_parameterName = "flickerAnimID";
	public int[] m_stateIDArray = { 0, 1, 2, 3 };



    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    //OnStateMachineEnter is called when entering a state machine via its Entry Node
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
   {
        if (m_stateIDArray.Length <= 0)
		{
			animator.SetInteger(m_parameterName, 0);

		}
		else
		{
			int index = Random.Range(0, m_stateIDArray.Length);
			Debug.Log(m_parameterName + "->" + m_stateIDArray[index]);

			animator.SetInteger(m_parameterName, m_stateIDArray[index]);

		}


        //animator.SetInteger(n_parameterName, Random.Range(0, 4));

	}

    // OnStateMachineExit is called when exiting a state machine via its Exit Node
    // override public void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    //{
	//
    //}
}
