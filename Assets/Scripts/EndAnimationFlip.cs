using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnimationFlip : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    public void EndAnimation()
    {
        if (anim != null)
        {
            anim.SetBool("Flip", false);
        }
    }
}
