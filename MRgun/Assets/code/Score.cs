using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    private GUIStyle style;
    private GUIStyleState styleState;

    // Start is called before the first frame update
    void Start()
    {
        style = new GUIStyle();
        styleState = new GUIStyleState();
        style.fontSize = 30;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        styleState.textColor = Color.cyan;
        style.normal = styleState;
        GUI.Label(new Rect(0, 0, 200, 100),"Score : " + HP.score, style);
    }

}
