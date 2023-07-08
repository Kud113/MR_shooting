using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public static bool trigger = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Appear()
    {
        trigger = true;
    }
    public void Disppear()
    {
        trigger = false;
    }
}
