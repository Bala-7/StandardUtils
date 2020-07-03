using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_MeleeWeapon : FPS_Weapon
{

    private FPS_Camera _cam;

    [Range(0.2f, 5.0f)]
    public float hitDistance;

    protected new void Awake()
    {
        base.Awake();
        _cam = transform.parent.parent.parent.GetComponent<FPS_Camera>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Fire()
    {
        // Plays weapon's shooting animation
        _ac.Play("Shoot");

        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, _cam.GetForwardDirection(), out hit, hitDistance, layerMask))
        {
            //hit.transform.gameObject.GetComponent<Usable>().Use();


            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
        }
    }

    public override void Reload()
    {
        
    }
}
