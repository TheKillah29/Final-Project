using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public GameObject[] GameObjects;

    protected static string mText;
    public static string MyText
    {
        get { return mText; }
        set { mText = value; }
    }

    void Awake ()
    {
         GameObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
         for (int i= 0; i< GameObjects.Length; i++)
         {
              MyText+= GameObjects[i].name + "-";
         }
    }

    void Update()
    {
         if(Input.GetButtonDown("Jump"))
         {
             Debug.Log(MyText);
         }
    }
}
