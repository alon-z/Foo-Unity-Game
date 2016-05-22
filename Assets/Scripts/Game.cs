using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    public Object Enemy;
    public Rigidbody Player;
    private ArrayList Enemies;

	// Use this for initialization
	void Start () {
        Enemies = new ArrayList();

        Vector3 mainV = new Vector3(0, 0.5f, 5);
        Enemies.Add(Instantiate(Enemy, mainV, Quaternion.identity) as GameObject);
    }
	
	// Update is 100% called
	void FixedUpdate () {

        for (int index = 0; index < Enemies.Count; index++)
        {
            GameObject enemy = (GameObject)(Enemies[index]);
            Vector3 movement = new Vector3(0.0f, 0.0f, -0.8f);
            enemy.GetComponent<Rigidbody>().AddForce(movement);
            if (Vector3.Distance(enemy.GetComponent<Rigidbody>().position, Player.position) > 18.0f)
            {
                Destroy(enemy);
                Enemies.Remove(enemy);
                index--;
                Vector3 mainV = new Vector3(0, 0.5f, 5);
                Enemies.Add(Instantiate(Enemy, mainV, Quaternion.identity) as GameObject);
            }
        }
    }
}
