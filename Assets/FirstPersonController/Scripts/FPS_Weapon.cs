using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FPS_Weapon : MonoBehaviour
{
    protected AudioSource _as;
    public AudioClip shootSnd;


    protected Animator _ac;
    protected GameObject _player;

    [Tooltip("Times per second this weapon can be shot/activated.")]
    public float cadence;   
    protected bool canShoot = true;

    [Tooltip("Damage amount per hit.")]
    [Range(1, 100)]
    public int damage;

    [Tooltip("Time (in seconds) that player has to wait between showing the weapon and shooting.")]
    [Range(0.2f, 1.0f)]
    public float equipTime;



    protected void Awake()
    {
        _ac = GetComponent<Animator>();
        _as = GetComponent<AudioSource>();
        _player = transform.parent.parent.parent.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void Fire();

    public virtual void ShowWeapon() {

        _ac.Play("Show");

        canShoot = false;
        Invoke("EnableShoot", equipTime);
    }

    public abstract void Reload();

    protected void EnableShoot() { canShoot = true; }
}
