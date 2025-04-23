using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Awake()
    {
        // Debug.Log(DateTime.Now);
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * DateTime.Now.Hour); // 30 degree clockwise rotation around Z-axis
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * DateTime.Now.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * DateTime.Now.Second);
    }
}
