package com.aycs.unitytoandroid;

import android.util.Log;

public class testandroid {

    public void NoParm()
    {
        Log.i("Unity","This is NOParm");
    }

    public int OneParm(String val)
    {
        Log.i("Unity",val);
        return 10;
    }

    public static int sOneParm(String val)
    {
        Log.i("Unity" , "sOneParm" + val);
        return 20;
    }
}
