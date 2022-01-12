using UnityEngine;

public class MonsterGunController : MonoBehaviour
{
    public GameObject bullet;
    public float fireRate = 2f;
    public Transform bulletSpawnPoint;

    private float secondsSinceLastFire = 0;

    // Update is called once per frame
    void Update()
    {
        secondsSinceLastFire += Time.deltaTime;

        if (secondsSinceLastFire > fireRate)
        {
            GameObject spawnedBullet = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Destroy(spawnedBullet, 5);

            secondsSinceLastFire = 0;
        }
    }
}
