using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool actionFlag = false;
    public Animator anim;
    public float speed;
    float hAxis;
    float VAxis;
    Vector3 moveVec;
    float lastTriggerTime;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        hAxis = Input.GetAxisRaw("Horizontal");
        VAxis = Input.GetAxisRaw("Vertical");
        moveVec = new Vector3(hAxis, 0, VAxis).normalized;

        if (!actionFlag) {

            transform.position += moveVec * speed * Time.deltaTime;

            transform.LookAt(transform.position + moveVec);
        }
    }
}

