using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traderdialog : MonoBehaviour
{
    
    [SerializeField] private GameObject m_cursor;
    [SerializeField] private GameObject item1;
    [SerializeField] private GameObject item2;
    private BoxCollider2D dialog_box;
    private BoxCollider2D cursor_box;

    private BoxCollider2D item1_box;
    private BoxCollider2D item2_box;
    // Start is called before the first frame update
    void Start()
    {
        dialog_box = GetComponent<BoxCollider2D>();
        cursor_box = m_cursor.GetComponent<BoxCollider2D>();
        item1_box = item1.GetComponent<BoxCollider2D>();
        item2_box = item2.GetComponent<BoxCollider2D>();
    }

    
    
    // Update is called once per frame
    void Update()
    {
        if (enabled)
        {
            if (Input.GetKeyDown(KeyCode.S) && !cursor_box.IsTouching(dialog_box))
            {
                m_cursor.transform.position = m_cursor.transform.position - new Vector3(0, +0.3f, 0);
            }
            if (Input.GetKeyDown(KeyCode.W) && !cursor_box.IsTouching(dialog_box))
            {
                m_cursor.transform.position = m_cursor.transform.position - new Vector3(0, -0.3f, 0);
            }

            //if (Input.GetKeyDown(KeyCode.Space))
           // {
                if (cursor_box.IsTouching(item1_box))
                {
                    Debug.Log("EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
                }
           // }
        }
    }
}
