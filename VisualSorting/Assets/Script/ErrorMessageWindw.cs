using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorMessageWindw : MonoBehaviour {

    [SerializeField]
    private Button Xbutton = null;
    [SerializeField ]
    private Text messageView = null;

	// Use this for initialization
	void Start () {
	}

    public void _Init(string message) {
        if (Xbutton == null) Xbutton = GameObject.Find("Xbutton").GetComponent<Button>();
        if (messageView == null) messageView = GameObject.Find("Content").GetComponent<Text>();

        messageView.text = message;
    }

    public void OnClick() {
        GameObject obj = this.gameObject;
        Destroy(obj);
        obj = null;
    }

}
