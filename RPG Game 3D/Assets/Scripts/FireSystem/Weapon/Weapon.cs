using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GAME3D.Scripts.Weapon{
public class Weapon : MonoBehaviour
{
    #region  Variables
  public Transform bulletSpawner;

    public GameObject bullets;
    #endregion


    void Update()
    {
        FireOn();
    }


    void FireOn()
    {
        if(Input.GetKeyDown(KeyCode.Space) )
        {
        Instantiate( bullets, bulletSpawner.position,bulletSpawner.rotation);
        
        }
       
    }
}
}