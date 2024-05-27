using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDead : MonoBehaviour
{
    public Animator animator;
    public ParticleSystem blood;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Hit", false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Break()
    {
        blood.gameObject.SetActive(true);
        blood.Play();
        Debug.Log("animation");
        animator.SetBool("Hit", true);
        animator.Play("Z_FallBack");
        
    }
}
