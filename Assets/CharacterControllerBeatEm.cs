using UnityEngine;
using System.Collections;

public class CharacterControllerBeatEm : MonoBehaviour {

	public GameObject gameobject;
	public Animation walkLeftAnim;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.DownArrow)){
			gameobject.transform.Translate(new Vector3(0.0f, -0.01f));
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			gameobject.transform.Translate(new Vector3(0.0f, 0.01f));
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			gameobject.transform.Translate(new Vector3(-0.01f, 0.0f));
			walkLeftAnim.Play("playerWalkLeft2",PlayMode.StopAll);
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			gameobject.transform.Translate(new Vector3(0.01f, 0.0f));

		}

	}
}
