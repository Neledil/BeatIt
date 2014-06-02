using UnityEngine;
using System.Collections;

public class CharacterControllerBeatEm : MonoBehaviour {


	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.DownArrow)){
			this.transform.Translate(new Vector3(0.0f, -0.01f));
			//anim.SetInteger("Direction", 1);
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			this.transform.Translate(new Vector3(0.0f, 0.01f));
			//anim.SetInteger("Direction", 1);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			this.transform.Translate(new Vector3(-0.01f, 0.0f));
			anim.SetInteger("Direction", 1);
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			this.transform.Translate(new Vector3(0.01f, 0.0f));
			anim.SetInteger("Direction", 2);
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow)){
			anim.SetInteger("Direction", 0);
		}
		if (Input.GetKeyUp (KeyCode.RightArrow)){
			anim.SetInteger("Direction", 0);
		}

	}
}
