using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public float health;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {   
        health = health - 25;       //25 is bullet damage   

        //decrease health or destroy object on collition
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (other.gameObject == player)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log("Game Over");
        }
    }
}
