using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;
    private DestroyObject des;

    // Start is called before the first frame update
    void Start()
    {
        des = GameObject.Find("Target").GetComponent<DestroyObject>();
    }

    // Update is called once per frame
    public void Exp()
    {
        GameObject exp = Instantiate(explosion, des.pos, transform.rotation);
        Destroy(exp, 1.5f);
    }


}
