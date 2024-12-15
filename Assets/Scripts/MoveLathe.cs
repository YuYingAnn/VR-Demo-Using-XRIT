using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MoveLathe : MonoBehaviour
{
    private Animator latheAnimator;

    private void Start()
    {
        latheAnimator = GetComponent<Animator>();
    }
    public void Move()
    {
        if (latheAnimator.GetBool("forward"))
        {
            latheAnimator.SetBool("forward", false);
        }
        else
        {
            latheAnimator.SetBool("forward", true);
        }
    }

}
