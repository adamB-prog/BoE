using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class FullFireWeaponMode : MonoBehaviour, IWeaponMode
{
    public int CooldownTime { get; } = 999;

    public void Shoot(List<RawImage> indicators, List<GameObject> projectileSpawners, GameObject blast, Color inActive, Color active)
    {
        for (int i = 0; i < indicators.Count; i++)
        {
            Instantiate(blast, projectileSpawners[i].transform.position, projectileSpawners[i].transform.rotation);
        }
        
    }

    public IWeaponMode ChangeState()
    {
        return new SingleFireWeaponMode();
    }

    public void ResetIndicators(List<RawImage> indicators, Color inActive, Color active)
    {
        foreach (var t in indicators)
        {
            t.color = active;
        }
    }

   
}
