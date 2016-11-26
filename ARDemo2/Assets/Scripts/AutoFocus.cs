using UnityEngine;
using Vuforia;
using System.Collections;

public class AutoFocus : MonoBehaviour {

    [SerializeField]
    CameraDevice.FocusMode focusmode = CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO;
    void Awake()
    {
        Util.Debugger.Debugger.DebugEnabled = true;

        CameraDevice.Instance.SetFocusMode(focusmode);
    }
}
