using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBar : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField]
    private Image bar;
    [SerializeField]
    private Health health;

    // Start is called before the first frame update
    void Start()
    {
        health = transform.parent.parent.GetComponent<Health>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void LateUpdate()
    {
        if (health)//if there is a health component
        {
            float pct = health.health / health.maxHealth;//get a number
            bar.fillAmount = pct;//set fill ammount for bar
        }
        
    }
}