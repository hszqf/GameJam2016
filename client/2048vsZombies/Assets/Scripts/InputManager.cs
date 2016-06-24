using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Messenger.Broadcast(MessageConst.INPUT_LEFT);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            Messenger.Broadcast(MessageConst.INPUT_RIGHT);
        }
        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            Messenger.Broadcast(MessageConst.INPUT_UP);
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            Messenger.Broadcast(MessageConst.INPUT_DOWN);
        }
	}
}
