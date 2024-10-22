
using UnityEngine;


public class DamageBullet : MonoBehaviour
{
    [SerializeField] HealthBar HealthBarScript;
    [SerializeField] int Damage;
    [SerializeField] Transform Enemy;
    void Start()
    {
        
    }


    void Update()
    {

    }

    void TakeDamage(int TheDamage)
    {
        HealthBarScript.Health -= Damage; 
           
    }

    private void OnTriggerEnter(Collider Colliders)
    {
        
        if (Colliders.CompareTag("Enemy"))
        {
            Debug.Log("Coll hit!!");
            TakeDamage(Damage);
        }
    }


}
