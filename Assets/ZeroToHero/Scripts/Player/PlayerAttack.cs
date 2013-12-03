using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

    int playerAttack = 5;
    public AudioClip swingSound;
    public GameObject particleHitNPC;
    public GameObject particleHitNode;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(swingSound);

            RaycastHit hit;
            if (Physics.Raycast(transform.position + new Vector3(0, -0.5f, 0), transform.forward, out hit))
            {
                if (hit.distance < 2 && hit.collider.gameObject.tag == "Attackable")
                {
                    AttackableNPC attackable = hit.collider.gameObject.GetComponent<AttackableNPC>();

                    attackable.Damage(playerAttack);
                    Debug.Log("HIT " + attackable.gameObject.name);

                    SpawnParticleEffect(hit, attackable);
                }
            }
        }
	
	}

    void SpawnParticleEffect(RaycastHit hit, AttackableNPC attackable)
    {
        GameObject particles;

        if (attackable.gameObject.name.Contains("NPC"))
            particles = Instantiate(particleHitNPC, hit.point, Quaternion.identity) as GameObject;
        else
            particles = Instantiate(particleHitNode, hit.point, Quaternion.identity) as GameObject;
    }
}
