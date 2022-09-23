using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GAME3D.Scripts.Asteroid{
public class Asteroid : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _minScale= 0.8f;
    [SerializeField] private float _maxScale=1.2f;
    [SerializeField] private float _rotationOffSet = 50f;

    
    Transform myT;
    Vector3 randomRotation;
    #endregion
   

   void Awake()
   {
    myT= transform;
   }
    void Start()
    {
        Vector3 scale = Vector3.one;
        scale.x = Random.Range(_minScale,_maxScale);
        scale.y = Random.Range(_minScale,_maxScale);
        scale.z = Random.Range(_minScale, _maxScale);

        myT.localScale =scale;

        randomRotation.x= Random.Range(-_rotationOffSet,_rotationOffSet);
        randomRotation.y= Random.Range(-_rotationOffSet,_rotationOffSet);
        randomRotation.z = Random.Range(-_rotationOffSet,_rotationOffSet);

    }

    void Update()
    {
        myT.Rotate(randomRotation * Time.deltaTime);
    }

}

}
