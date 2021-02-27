using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string myText;
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }
    void OnGUI (){
    	GUILayout.BeginArea(new Rect(10,10,200,200));
    	GUILayout.Label(myText);
    	GUILayout.EndArea();
    }
}
