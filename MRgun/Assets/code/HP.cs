using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{

    public static int score = 0;
    public int hitPoint = 100;  //HP
    private Explosion explosion;

    void Start()
    {
        explosion = GameObject.FindWithTag("Explosion").GetComponent<Explosion>();
    }
    // Update is called once per frame
    void Update()
    {   
        if (hitPoint <= 0)
        {
            explosion.Exp();
            Sounds sePlay = GameObject.Find("SePlayer").GetComponent<Sounds>();
            sePlay.Play("SE1");
            Destroy(gameObject);
        }

    }

    
    public void Damage(int damage)
    {

        hitPoint -= damage;
        score += damage;
    }
}