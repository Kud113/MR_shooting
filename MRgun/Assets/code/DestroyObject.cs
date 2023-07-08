using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public int damage;          
    private GameObject enemy;   
    private HP hp;
    public GameObject hitEffectPrefab;
    public Vector3 pos;

    void Start()
    {
        enemy = GameObject.Find("Enemy");   
        hp = enemy.GetComponent<HP>();      
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Shell"))
        {
            GameObject hitEffect = Instantiate(hitEffectPrefab, transform.position, transform.rotation);
            Destroy(hitEffect, 1.5f);
            pos = transform.position;
            Sounds sePlay = GameObject.Find("SePlayer").GetComponent<Sounds>();
            sePlay.Play("SE2");
            hp.Damage(damage);
            Destroy(other.gameObject);
        }
    }
}