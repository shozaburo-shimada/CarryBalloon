using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuWindow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public GUIStyle textStyle;
    //public GUIStyle buttonStyle;
    public float gravityValue = 1.0F;

    private void OnGUI() {
        if (GUI.Button(new Rect(20, 10, 100, 30), "Reset")) {
            SceneManager.LoadScene(0);
        }
        //GUI.Label(new Rect(20, 20, 100, 20), "MenuWindow", textStyle);

        // スライダー（水平）を表示する
        gravityValue = GUI.HorizontalSlider(new Rect(20, 60, 100, 30), gravityValue, 0.0F, 20.0F);
        // ラベルにhSliderValueの値を表示する
        GUI.Label(new Rect(20, 70, 100, 20), "Gravity:" + gravityValue, textStyle);
    }
}
