using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class DoubleFireWeaponMode : MonoBehaviour, IWeaponMode
{

    private int _index;

    public int CooldownTime { get; } = 666;

    public void Shoot(List<RawImage> indicators, List<GameObject> projectileSpawners, GameObject blast, Color inActive, Color active)
    {
        
        switch (_index)
        {
            case 0:
                Instantiate(blast, projectileSpawners[1].transform.position, projectileSpawners[1].transform.rotation);
                Instantiate(blast, projectileSpawners[2].transform.position, projectileSpawners[2].transform.rotation);
                indicators[1].color = inActive;
                indicators[2].color = inActive;
                indicators[0].color = active;
                indicators[3].color = active;
                _index = 1;
                break;
            case 1:
                Instantiate(blast, projectileSpawners[0].transform.position, projectileSpawners[0].transform.rotation);
                Instantiate(blast, projectileSpawners[3].transform.position, projectileSpawners[3].transform.rotation);
                indicators[0].color = inActive;
                indicators[3].color = inActive;
                indicators[1].color = active;
                indicators[2].color = active;
                _index = 0;
                break;
        }
        
    }

    public IWeaponMode ChangeState()
    {
        return new FullFireWeaponMode();
    }

    public void ResetIndicators(List<RawImage> indicators, Color inActive, Color active)
    {
        _index = 0;
        indicators[1].color = inActive;
        indicators[2].color = inActive;
        indicators[0].color = active;
        indicators[3].color = active;
    }
    
}
