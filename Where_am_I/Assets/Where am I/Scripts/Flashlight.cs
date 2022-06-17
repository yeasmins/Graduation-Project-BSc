using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour
{
    public Light flashlightLightSource;
    public bool lightOn = true;
    public float lightDrain = 0.1f;
    public float batteryLife = 0.0f;
    public float maxBatteryLife = 20.0f;
    public float batteryPower = 1.0f;

    void Start()
    {
        batteryLife = maxBatteryLife;
        flashlightLightSource = GetComponent<Light>();
    }

    void Update()
    {
        if (lightOn && batteryLife >= 0)
        {
            batteryLife -= Time.deltaTime * lightDrain;
        }
        if (lightOn && batteryLife <= 0.4f)
        {
            flashlightLightSource.GetComponent<Light>().intensity = 5;
        }
        if (lightOn && batteryLife <= 0.3f)
        {
            flashlightLightSource.GetComponent<Light>().intensity = 4;
        }
        if (lightOn && batteryLife <= 0.2f)
        {
            flashlightLightSource.GetComponent<Light>().intensity = 3;
        }
        if (lightOn && batteryLife <= 0.1f)
        {
            flashlightLightSource.GetComponent<Light>().intensity = 2;
        }
        if (lightOn && batteryLife <= 0)
        {
            flashlightLightSource.GetComponent<Light>().intensity = 0;
        }

        if (batteryLife <= 0)
        {
            batteryLife = 0;
            lightOn = false;
        }
    }
}
