using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowInfo : MonoBehaviour
{
    [SerializeField] string type;

    public string GetType()
    {
        return type;
    }
}
