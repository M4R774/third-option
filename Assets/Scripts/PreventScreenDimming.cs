using UnityEngine;

public class PreventScreenDimming : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Disable screen dimming
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
