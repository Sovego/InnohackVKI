using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling.Experimental;
using UnityEngine.Serialization;

public class Trader : MonoBehaviour
{
    [SerializeField] private GameObject hero;
    private BoxCollider2D m_boxtriger;
    [SerializeField] private GameObject dialog;
    private BoxCollider2D m_herotriger;
    // Start is called before the first frame update
    void Start()
    {
        m_boxtriger = GetComponent<BoxCollider2D>();
        m_herotriger = hero.GetComponent<BoxCollider2D>();
    }

    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(hero.transform.position);
        Debug.Log(transform.position);
        //Debug.Log("Nuy");
        if (m_boxtriger.IsTouching(m_herotriger) && Input.GetKey("e"))
        {
            //Debug.Log("Da suka");
            dialog.SetActive(true);
            hero.GetComponent<HeroKnight>().enabled = false;
        }

        if (Input.GetKey(KeyCode.Escape) && dialog.activeInHierarchy)
        {
            dialog.SetActive(false);
            hero.GetComponent<HeroKnight>().enabled = true;
        }
    }
}
