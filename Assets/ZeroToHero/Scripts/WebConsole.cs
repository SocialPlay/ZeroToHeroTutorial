using UnityEngine;
using System.Collections;

public class WebConsole : MonoBehaviour {

    // Static singleton property
    public static WebConsole Instance { get; private set; }

    void Awake()
    {
        // Save a reference to the AudioHandler component as our singleton instance
        Instance = this;
    }

    public UILabel label;

    public void Debug(string message)
    {
        label.text = message;
    }
}
