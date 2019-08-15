using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Image Healthbar;
    public Image StaminaBar;

    public PlayerMovementComponent PMC; // Short for player movement component

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        StaminaBar.fillAmount = PMC.CurrentStamina / PMC.MaxStamina;
	}
}
