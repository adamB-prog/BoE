using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AI;
using Extensions;
using UnityEngine;
using Random = System.Random;

public class NavigationSystem : MonoBehaviour, INavigationSystem
{
    [SerializeField] private GameObject target = null;
    [SerializeField] private float changeDistance = 1f;

    [SerializeField] private bool debugLine = false;
    private static Random rnd = new Random();

    void Start()
    {
        CreateNewSpacePoint();
    }

    void Update()
    {
        HandleTargetChanging();
        if (debugLine)
        {
            Debug.DrawLine(transform.position, target.transform.position);
        }
    }

    public void ChangeTarget(GameObject obj)
    {
        if (target.CompareTag("SpacePoint"))
        {
            Destroy(target);
        }

        target = obj;
    }

    public GameObject GetTarget()
    {
        return target;
    }

    void HandleTargetChanging()
    {
        Vector3 targetDir = target.transform.position - transform.position;
        if (target == null || targetDir.magnitude <= changeDistance)
        {
            CreateNewSpacePoint();
        }
    }

    void CreateNewSpacePoint()
    {
        if (target == null)
        {
            target = new GameObject(string.Format("{0}'s target", gameObject.name));
            target.tag = "SpacePoint";
        }

        if (target.CompareTag("SpacePoint"))
        {
            target.transform.position = new Vector3(rnd.NextFloat(-10f, -40f), rnd.NextFloat(-355f, -365f),
                rnd.NextFloat(-300f, -400f));
        }
        else
        {
            target = null;
            CreateNewSpacePoint();
        }
    }

    public float CorrectionAngleOnY()
    {
        Vector2 targetXZ = new Vector2(target.transform.position.x, target.transform.position.z);
        Vector2 localXZ = new Vector2(transform.position.x, transform.position.z);


        Vector2 targetDir = targetXZ - localXZ;

        Vector2 forward = new Vector2(transform.forward.x, transform.forward.z);

        float angle = Vector2.SignedAngle(targetDir, forward);

        return angle;
    }

    //Need to check
    public float CorrectionAngleOnX()
    {
        Vector2 targetYZ = new Vector2(target.transform.position.y, target.transform.position.z);
        Vector2 localYZ = new Vector2(transform.position.y, transform.position.z);


        Vector2 targetDir = targetYZ - localYZ;

        Vector2 forward = new Vector2(transform.forward.y, transform.forward.z);

        float angle = Vector2.SignedAngle(targetDir, forward);
        return angle;
    }
}