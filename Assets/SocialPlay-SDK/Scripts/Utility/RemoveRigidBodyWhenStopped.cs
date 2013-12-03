using UnityEngine;
using System.Collections;

public class RemoveRigidBodyWhenStopped : MonoBehaviour
{
    public bool makeTrigger = true;

    void Update()
    {
        if (rigidbody.IsSleeping())
        {
            Destroy(rigidbody);
            Destroy(gameObject.GetIComponent<RemoveRigidBodyWhenStopped>());

            if (makeTrigger)
                gameObject.GetIComponentInChildren<Collider>().isTrigger = true;

        }
    }
}
