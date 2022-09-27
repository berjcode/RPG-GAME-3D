using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GAME3D.Scripts.Weapon{
public class Bullet : MonoBehaviour
{
   #region Variables 
       [SerializeField] private float bulletSpeed;
       [SerializeField] private float bulletDestroyTime;
   #endregion




    void Update()
    {
        gameObject.transform.Translate(new Vector3 (0,0,bulletSpeed * Time.deltaTime));


        Destroy(gameObject, bulletDestroyTime);
    
    }


}
}