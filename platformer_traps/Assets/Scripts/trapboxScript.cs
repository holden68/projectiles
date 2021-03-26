using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapboxScript : MonoBehaviour
{
    public GameObject projectilePrefab;
    Vector2 left = new Vector2(-1, 0);
    float elapsed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= 4f)
        {
            Launch();
        }

    }

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, left * .05f, Quaternion.identity);

        Projectile projectile = projectileObject.GetComponent<Projectile>();
        projectile.Launch(left, 300);
    }
}
