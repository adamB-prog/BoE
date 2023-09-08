
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SingleFireWeaponMode : MonoBehaviour, IWeaponMode
{
    private int _index = 0;

    public int CooldownTime { get; } = 333;

    public void Shoot(List<RawImage> indicators, List<GameObject> projectileSpawners, GameObject blast, Color inActive, Color active)
    {
        
        switch (_index)
        {
            case 0:
                Instantiate(blast, projectileSpawners[_index].transform.position, projectileSpawners[_index].transform.rotation);
                indicators[0].color = inActive;
                indicators[1].color = active;
                _index = 1;
                break;
            case 1:
                Instantiate(blast, projectileSpawners[_index].transform.position, projectileSpawners[_index].transform.rotation);
                indicators[1].color = inActive;
                indicators[2].color = active;
                _index = 2;
                break;
            case 2:
                Instantiate(blast, projectileSpawners[_index].transform.position, projectileSpawners[_index].transform.rotation);
                indicators[2].color = inActive;
                indicators[3].color = active;
                _index = 3;
                break;
            case 3:
                Instantiate(blast, projectileSpawners[_index].transform.position, projectileSpawners[_index].transform.rotation);
                indicators[3].color = inActive;
                indicators[0].color = active;
                _index = 0;
                break;
        }
        
    }

    public IWeaponMode ChangeState()
    {
        return new DoubleFireWeaponMode();
    }

    public void ResetIndicators(List<RawImage> indicators, Color inActive, Color active)
    {
        _index = 0;
        foreach (var indicator in indicators)
        {
            indicator.color = inActive;
        }

        indicators[0].color = active;
    }
}
