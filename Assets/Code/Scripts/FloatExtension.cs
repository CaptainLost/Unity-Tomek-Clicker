using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods
{
    public static float Remap(this float value, float in1, float in2, float out1, float out2)
    {
        return out1 + (value - in1) * (out2 - out1) / (in2 - in1);
    }
}