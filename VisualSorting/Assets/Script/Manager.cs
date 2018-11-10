using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public class Manager : MonoBehaviour {

//    [SerializeField]
//    private static GameObject MessageView = null;
//    [SerializeField]
//    private static Canvas canvas = null;

//    // Use this for initialization
//    void Start () {
		
//	}
	
//	// Update is called once per frame
//	void Update () {
		
//	}

//    //public static class Message
//    //{     

//    //    public static void _Init()
//    //    {
//    //        if (MessageView == null) MessageView = (GameObject)Resources.Load("ErrorMessageWindow");
//    //        if (canvas == null) canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
//    //    }

//    //    public static void ShowMessage(string message)
//    //    {
//    //        GameObject obj = Instantiate(MessageView, Vector3.zero, Quaternion.identity);
//    //        ErrorMessageWindw messageWindw = obj.GetComponent<ErrorMessageWindw>();

//    //        obj.transform.parent = canvas.transform;
//    //        messageWindw._Init(message);
//    //    }
//    //}

//}

namespace Manager {


    public class Message : MonoBehaviour 
    {
        public static void ShowMessage(string message)
        {
            Debug.Log(Application.dataPath);
            GameObject eMessageWindow = Instantiate((GameObject)Resources.Load("ErrorMessageWindow"), Vector3.zero, Quaternion.identity);
            GameObject canvas = GameObject.Find("Canvas");

            if (eMessageWindow == null && canvas == null) return;

            ErrorMessageWindw messageWindow = eMessageWindow.GetComponent<ErrorMessageWindw>();
            RectTransform rectTransform = eMessageWindow.GetComponent<RectTransform>();
            eMessageWindow.transform.parent = canvas.transform;
            rectTransform.offsetMax = Vector2.zero;
            rectTransform.offsetMin = Vector2.zero;
            messageWindow._Init(message);

            Debug.Log(eMessageWindow.GetComponent<RectTransform>().transform);
        }

    }
}
