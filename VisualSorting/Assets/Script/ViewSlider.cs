using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewSlider : MonoBehaviour {

    [SerializeField]
    private float TargetValue = 0;
    private Slider mySlider = null;

	// Use this for initialization
	void Start () {
	}

    public bool _Init() {
        try
        {
            mySlider = this.GetComponent<Slider>();
            mySlider.maxValue = 100;
        }
        catch {
            return false;
        }
        return true;
    }

    public bool _Init(float maxValue) {
        try
        {
            mySlider = this.GetComponent<Slider>();
            mySlider.maxValue = maxValue;
        }
        catch {
            return false;
        }
        return true;
    }

    public void UpdateSliderValue() {
    }

    // Update is called once per frame
    void Update () {
		
	}
}
