using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAME3D.Scripts.Asteroid{
public class AsteroidManager : MonoBehaviour
{
    [SerializeField]  private Asteroid asteroidPrefabs;
    [SerializeField] private int numberOfAsteroidOnAxis = 10;
    [SerializeField]   private int gridSpacing= 100;
   
   
   void Start()
   {
    PlaceAsteroids();
   }
   void PlaceAsteroids()
   {
    for(int x = 0; x < numberOfAsteroidOnAxis; x++)
    {   
        for(int y = 0; y< numberOfAsteroidOnAxis; y++)
        {
            for(int z = 0; z< numberOfAsteroidOnAxis; z++)
                { 
                 InstantiateAsteroid(x,y,z);
                }
        }
       
    }
   }


   void InstantiateAsteroid(int x, int y, int z )
   {
        Instantiate(asteroidPrefabs,new Vector3(transform.position.x+(x*gridSpacing)+AsteroidOffSet(),
        transform.position.y+(y*gridSpacing)+ AsteroidOffSet() ,
        transform.position.z+(z*gridSpacing)+AsteroidOffSet()), 
        Quaternion.identity,transform);
   }

   float AsteroidOffSet()
   {
        return Random.Range(-gridSpacing/2f, gridSpacing/2f);
   }
}
}
