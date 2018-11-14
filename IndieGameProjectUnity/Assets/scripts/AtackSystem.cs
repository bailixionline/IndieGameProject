using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackSystem : MonoBehaviour {

    public ParticleSystem P1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        skill();
	}

    public void skill() {
        if (Input.GetKeyDown(KeyCode.J)) {
            P1.Play();
        }
    }
}
