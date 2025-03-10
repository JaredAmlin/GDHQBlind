using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "TankWeapon", menuName = "Tank/TankWeapon", order = 2)]
public class TankWeapon : ScriptableObject
{
    public GameObject GunProjectile;
    public Sprite DisplayImage;
    public float MuzzleVelocity = 100f;
    public float FireDelay = 0.1f;
    public float ReloadDelay = 2f;
    public int ClipSize = 1;
    public int currentAmmo;
    public int maxAmmo;

    public int soundNum;

    public void Start()

    {
    
        currentAmmo = maxAmmo;
    }


}
