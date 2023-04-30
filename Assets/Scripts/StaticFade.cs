using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticFade : MonoBehaviour
{
    public Operations ops;
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ops.CheckIfAllTrue())
        {
            anim.Play("Fade");
        }
    }
}
