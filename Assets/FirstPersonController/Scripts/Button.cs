using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Usable
{
    private Animator _ac;


    void Awake() {
        _ac = GetComponent<Animator>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Usable methods
    public override void Use() {
        _ac.Play("Button_Press");

    }
    #endregion
}
