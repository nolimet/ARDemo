using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.

u

	void Awake()
    {

            // Get activity instance (standard way, solid)
            var pl_class = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            var currentActivity = pl_class.GetStatic<AndroidJavaObject>("currentActivity");

            // Get instance of UnityPlayer (hacky but will live)
            var pl_inst = currentActivity.Get<AndroidJavaObject>("mUnityPlayer");

            // Get list of camera wrappers in UnityPlayer (very hacky, will die if D becomes C tomorrow)
            var list = pl_inst.Get<AndroidJavaObject>("y");
            x = list.Call<int>("size");

            if (x == 0) return;

            // Get the first element of list (active camera wrapper)
            var cam_holder = list.Call<AndroidJavaObject>("get", 0);

            // get camera (this is totally insane, again if "a" becomes not-"a" one day )
            var cam = cam_holder.Get<AndroidJavaObject>("a");

            // Call my setup camera routine in Android plugin  (will set params and call autoFocus)
            var jc = new AndroidJavaClass("org.example.ScriptBridge.JavaClass");
            jc.CallStatic("enableAutofocus", new[] { cam });
    }
}
