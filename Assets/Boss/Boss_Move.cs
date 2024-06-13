using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Move : StateMachineBehaviour
{
    Transform Player;
    Rigidbody2D rb;
    Devil boss;

    float speed = 2f;
    float attackRange = 10f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<Devil>();
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        boss.LookAtPlayer();

        Vector2 target = new Vector2(Player.position.x, rb .position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);

        if (Vector2.Distance(Player.position, rb.position) <= attackRange)
        {
            animator.SetTrigger("PreAttack");
        }
    }


    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("PreAttack");
    }
}
