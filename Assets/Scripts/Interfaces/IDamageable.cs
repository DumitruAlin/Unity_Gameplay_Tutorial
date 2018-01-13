using UnityEngine;

namespace Interfaces
{
    public interface IDamageable
    {
        // RaycastHit used for passing hit data (location, direction .. etc ) to the object that was hit
        void TakeHit(float damage, RaycastHit hit);
    }
}
