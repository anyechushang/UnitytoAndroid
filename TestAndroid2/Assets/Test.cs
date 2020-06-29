using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TestOne()
    {
        AndroidJavaObject jo = new AndroidJavaObject("com.aycs.unitytoandroid.testandroid");
        jo.Call("NoParm");
    }

    public void TestTwo()
    {
        AndroidJavaObject jo = new AndroidJavaObject("com.aycs.unitytoandroid.testandroid");
        int result = jo.Call<int>("OneParm","This is OneParm");
        Debug.Log("TestTwo=" + result);
    }

    public void TestThree()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.aycs.unitytoandroid.testandroid");
        int result = jc.CallStatic<int>("sOneParm","This is sOneParm");
        Debug.Log("TestThree=" + result);
    }
}
