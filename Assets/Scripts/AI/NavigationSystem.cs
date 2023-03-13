using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Extensions;
using UnityEngine;
using Random = System.Random;

public class NavigationSystem : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float changeDistance = 1f;
    private static Random rnd = new Random();

    void Start()
    {
        target = new GameObject(string.Format("{0}'s target", gameObject.name));
        target.transform.position = new Vector3(rnd.NextFloat(-10f, -40f), rnd.NextFloat(-350f, -370f),
            rnd.NextFloat(-300f, -400f));
    }

    void Update()
    {
        HandleTargetChanging();
        Debug.DrawLine(transform.position, target.transform.position);
    }

    void HandleTargetChanging()
    {
        Vector3 targetDir = target.transform.position - transform.position;
        if (target is null || targetDir.magnitude <= changeDistance)
        {
            Destroy(target);
            target = new GameObject(string.Format("{0}'s target", gameObject.name));
            target.transform.position = new Vector3(rnd.NextFloat(-10f, -40f), rnd.NextFloat(-355f, -365f),
                rnd.NextFloat(-300f, -400f));
        }
    }
    

    public float CorrectionAngleXZ()
    {
        Vector2 targetXZ = new Vector2(target.transform.position.x, target.transform.position.z);
        Vector2 localXZ = new Vector2(transform.position.x, transform.position.z);


        Vector2 targetDir = targetXZ - localXZ;

        Vector2 forward = new Vector2(transform.forward.x, transform.forward.z);

        float angle = Vector2.SignedAngle(targetDir, forward);

        return angle;
    }
    //Need to check
    public float CorrectionAngleYZ()
    {
        Vector2 targetYZ = new Vector2(target.transform.position.y, target.transform.position.z);
        Vector2 localYZ = new Vector2(transform.position.y, transform.position.z);


        Vector2 targetDir = targetYZ - localYZ;

        Vector2 forward = new Vector2(transform.forward.y, transform.forward.z);

        float angle = Vector2.SignedAngle(targetDir, forward);

        return angle;
    }

}