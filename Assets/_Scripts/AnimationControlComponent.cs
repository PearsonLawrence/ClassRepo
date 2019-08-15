using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControlComponent : MonoBehaviour {

    public Animator Anim;
    public Rigidbody RigidBodyPhyiscicsMM;

    //public PlayerMovementComponent Player;

    public PlayerMovementComponent Player;
	// Use this for initialization
	void Start () {
        RigidBodyPhyiscicsMM = Player.RB;
    }
	
	// Update is called once per frame
	void Update () {

        
        Vector3 LocalVelocity = transform.InverseTransformDirection(RigidBodyPhyiscicsMM.velocity);

        Anim.SetFloat("HorzSpeed", LocalVelocity.x);
        Anim.SetFloat("VertSpeed", LocalVelocity.z);
     
        Anim.SetBool("IsSprintingAnim", Player.IsSprinting);

        if(Input.GetMouseButtonDown(0))
        {
            Anim.SetTrigger("DoAttack");
        }

    }

    public void StepEvent()
    {
        Debug.Log("StepEvent");
    }

    public void StartDamage()
    {
        //Activate Hitbox
        Debug.Log("StartDamage");
    }

    public void EndDamage()
    {
        //Deactivate Hitbox
        Debug.Log("StopDamage");
    }

   
}
