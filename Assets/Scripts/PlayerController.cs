using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator wAnimator = new Animator();
    // Start is called before the first frame update
    void Start()
    {
        wAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
    {
        wAnimator.SetTrigger("walking_walk");
        
    }

     else if (Input.GetKey(KeyCode.A))
    {
        wAnimator.SetTrigger("walking_walk");
        wAnimator.SetFloat("speed",1);
    }

    else if (Input.GetKey(KeyCode.S))
    {
        wAnimator.SetTrigger("walking_walk");
        
    }

  else   if (Input.GetKey(KeyCode.W))
    {
        wAnimator.SetTrigger("walking_walk");
        wAnimator.SetFloat("speed",1);
        
    }else
    {
        wAnimator.SetTrigger("go_idle");
        wAnimator.SetFloat("speed",0);
        
    }
    }

}
