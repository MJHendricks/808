using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolFade : MonoBehaviour
{
    public GameObject solhex;
    public Animator animator;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(solhex.activeSelf )
        {
            animator.Play("Fade");
        }
    }
}
