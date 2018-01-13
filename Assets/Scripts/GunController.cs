using UnityEngine;

public class GunController : MonoBehaviour
{

    public     Transform   WeaponHold;
    public     Gun         StartingGun;
    private    Gun         _equippedGun;

    private void Start() {
        if (StartingGun != null) {
            EquipGun(StartingGun);
        }
    }

    private void EquipGun(Gun gunToEquip)
    {
        if (_equippedGun != null)
        {
            Destroy(_equippedGun.gameObject);
        }
        _equippedGun = Instantiate(gunToEquip, WeaponHold.position, WeaponHold.rotation);
        _equippedGun.transform.parent = WeaponHold;
    }

    public void Shoot()
    {
        if (_equippedGun != null)
        {
            _equippedGun.Shoot();
        }
    }

}
