using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        this._animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        this._animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
            
        if (Input.GetKeyDown(KeyCode.Space))
            this._animator.SetBool("jump", true);
        else
            this._animator.SetBool("jump", false);
    }
}



