using System;
using UnityEngine;

public class NavigationSystem : MonoBehaviour, INavigationSystem
{
    [SerializeField] private GameObject target;
    [SerializeField] private float changeDistance = 1f;
    [SerializeField] private int reached = 0;

    [SerializeField] private bool debugLine = false;
    private static readonly System.Random rnd = new System.Random();

    public void Start()
    {
        target = CreateTargetObject();
    }

    public void Update()
    {
        HandleTargetChanging();
        if (debugLine)
        {
            Debug.DrawLine(transform.position, target.transform.position);
        }
    }

    public void HandleTargetChanging()
    {
        Vector3 targetDir = target.transform.position - transform.position;
        if (target is null || targetDir.magnitude <= changeDistance)
        {
            ++reached;
            DestroyImmediate(target);
            target = CreateTargetObject();
        }
    }
    public void SetTarget(GameObject newTarget)
    {
        target = newTarget;
    }
    

    public GameObject CreateTargetObject()
    {
        GameObject newTarget = new GameObject($"{gameObject.name}'s target");
        newTarget.transform.position = GetRandomTargetPosition();
        return newTarget;
    }

    public Vector3 GetRandomTargetPosition()
    {
        float randomX = UnityEngine.Random.Range(-40f, -10f);
        float randomY = UnityEngine.Random.Range(-370f, -350f);
        float randomZ = UnityEngine.Random.Range(-400f, -300f);
        return new Vector3(randomX, randomY, randomZ);
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

    public float CorrectionAngleOnX()
    {
        Vector2 targetYZ = new Vector2(target.transform.position.y, target.transform.position.z);
        Vector2 localYZ = new Vector2(transform.position.y, transform.position.z);

        Vector2 targetDir = targetYZ - localYZ;
        Vector2 forward = new Vector2(transform.forward.y, transform.forward.z);

        float angle = Vector2.SignedAngle(targetDir, forward);
        return angle;
    }

    public Vector3 GetTargetPosition()
    {
        return target.transform.position;
    }

    public object GetTarget()
    {
        return target;
    }
}
