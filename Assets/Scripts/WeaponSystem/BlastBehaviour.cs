using System.Threading.Tasks;
using UnityEngine;

public class BlastBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private ushort cooldownTimeMs = 3000;

    private bool canBeDestroyed = false;

     void Start()
     {
         Task.Run(async () =>
         {
             await Task.Delay(cooldownTimeMs);
             canBeDestroyed = true;
         });
     }

    void Update()
    {
        if (canBeDestroyed)
        {
            Destroy(gameObject);

            return;
        }

        gameObject.transform.Translate(Vector3.right * (speed * Time.deltaTime), Space.Self);
    }
    
}
