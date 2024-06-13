using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Attack : StateMachineBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D box;
    PolygonCollider2D polygon;

    float speed = 15f;
    Devil boss;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<Devil>();
        polygon = animator.GetComponent<PolygonCollider2D>();
        box = animator.GetComponent<BoxCollider2D>();
        box.enabled = true;
        polygon.enabled = !polygon.enabled;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (boss.isFlipped)
        {
            rb.velocity = new Vector2(speed, 0);
        }

        else
        {
            rb.velocity = new Vector2(-speed, 0);
        } 
    }


    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = new Vector2(0, 0);
        box.enabled = !box.enabled;
        polygon.enabled = !polygon.enabled;
    }
}
