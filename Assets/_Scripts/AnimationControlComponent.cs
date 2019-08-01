using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControlComponent : MonoBehaviour {

    public Animator Anim;
    public Rigidbody RB;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
                                       
        Vector3 LocalVelocity = transform.InverseTransformDirection(RB.velocity);

        Anim.SetFloat("HorzSpeed", LocalVelocity.x);
        Anim.SetFloat("VertSpeed", LocalVelocity.z);

    }
}
