using UnityEngine;
using System.Collections;

public class TossGameObjects : MonoBehaviour, IGameObjectAction
{
    public float Force = 200.0f;
    public float SpawnRadius = 1.0f;
    public float ThrowRadius = 5.0f;
    public float HeigtOffset = 1.0f;

    public void DoGameObjectAction(GameObject gameObject)
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<RemoveRigidBodyWhenStopped>();

        //we need to offset the initial position so they dont get compresion force

        gameObject.transform.position += Random.insideUnitSphere * SpawnRadius;

        gameObject.transform.position += new Vector3(0.0f, HeigtOffset, 0.0f);
        gameObject.rigidbody.AddExplosionForce(Force, gameObject.transform.position, SpawnRadius);
    }
}
