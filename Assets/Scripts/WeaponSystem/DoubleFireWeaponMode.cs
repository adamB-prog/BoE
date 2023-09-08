using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class DoubleFireWeaponMode : MonoBehaviour, IWeaponMode
{

    private int _index;

    private bool _canShoot = true;
    public void Shoot(List<RawImage> indicators, List<GameObject> projectileSpawners, GameObject blast, Color inActive, Color active)
    {
        if (!_canShoot) return;
        
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
        
        CoolDown();
    }

    public IWeaponMode ChangeState()
    {
        // ReSharper disable once Unity.IncorrectMonoBehaviourInstantiation
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

    public void CoolDown()
    {
        _canShoot = false;
        Task.Run(async () =>
        {
            await Task.Delay(666);
            _canShoot = true;
        });
    }
}
