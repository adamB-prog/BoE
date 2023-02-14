using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



[RequireComponent(typeof(NavigationSystem))]
public class PropulsionSystem : MonoBehaviour
{

    [SerializeField] private NavigationSystem naviSystem;
    
    [SerializeField] private float speed;
    [SerializeField] private float speedMultiplier;
    
    [SerializeField] private float changeDistance;
    [SerializeField] private float yRotationSpeed;


    void Start()
    {
        naviSystem = GetComponent<NavigationSystem>();
    }
    

    void Update()
    {
        
        HandleTurning();
        Move();
    }
    
    private void Move()
    {
        this.gameObject.transform.Translate(Vector3.forward * speed * speedMultiplier * Time.deltaTime);
    }

    private void HandleTurning()
    {
        var euler = transform.rotation.eulerAngles;


        var angleX = naviSystem.CorrectionAngleYZ();
        if (angleX > 45f)
        {
            angleX = 0;
        }
        var angleY = naviSystem.CorrectionAngleXZ();

        //var s = string.Format("angleX: {0}, angleY: {1}", angleX.ToString(), angleY.ToString());
        
        //Debug.Log(s);
        
        this.gameObject.transform.eulerAngles = new Vector3(euler.x + angleX, euler.y + angleY, euler.z);
        
    }

    
}
