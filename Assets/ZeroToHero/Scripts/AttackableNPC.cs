using UnityEngine;
using System.Collections;
using SocialPlay.ItemSystems;
using System;
using SocialPlay.Data;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;


public class AttackableNPC : MonoBehaviour {

    public ItemGetter gameItemGetter;

    public AudioClip hitSound;
    public AudioClip deathsound;

    int health = 10;

    public void Damage(int damage)
    {
        if (health > 0)
        {
            health -= damage;

            CheckIfDead();
        }
    }

    void CheckIfDead()
    {
        if (health <= 0)
        {
            audio.PlayOneShot(deathsound);
            Death();
        }
        else
            audio.PlayOneShot(hitSound);
    }

    void Death()
    {
        DropLoot();
    }

    void DropLoot()
    {
        gameItemGetter.GetItems();

        if (gameObject.GetComponent<SpawnParticleEffect>())
            gameObject.GetComponent<SpawnParticleEffect>().NodeDestroyed();

        Destroy(this.gameObject);
    }

}
