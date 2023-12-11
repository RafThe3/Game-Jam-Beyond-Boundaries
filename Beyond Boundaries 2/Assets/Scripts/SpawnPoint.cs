using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPoint : MonoBehaviour
{
    private Basket basket;
    [Min(0), SerializeField] private int scene;

    // Start is called before the first frame update
    void Awake()
    {
        basket = FindObjectOfType<Basket>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (basket.isFull)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
