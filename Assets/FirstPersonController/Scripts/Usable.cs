using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Usable : MonoBehaviour
{
    public virtual void Use() {
        Debug.Log("Using 'Usable' method. This is probably not what you want.");
    }
}
