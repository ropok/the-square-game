using System.Collections;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public string state;
    [SerializeField] private MapSpawner map;
    [SerializeField] private Movement movement;
    [SerializeField] private Score score;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private ParticleSystem particleSystem;
    [SerializeField] private MusicManager musicManager;
    [SerializeField] private Menu menu;
    [SerializeField] private AdsManager adsManager;
    private int adsWait;
    // Start is called before the first frame update
    void Start()
    {
        state = "Idle";
        movement.ResetGravity(0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }

    private void Die()
    {
        state = "Dead";
        movement.ResetGravity(0);
        score.End();
        spriteRenderer.enabled = false;
        particleSystem.Play();
        musicManager.PlayDie();
        StartCoroutine(Delay());
    }

    private void Respawn()
    {
        menu.ChangeMenu(true);
        transform.position = new Vector3(-8.52f, 1.69f, 0);
    }

    public void StartGame()
    {
        state = "Playing";
        movement.ResetGravity(3);
        map.ClearStorage();
        spriteRenderer.enabled = true;
        menu.ChangeMenu(false);
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        Respawn();
        adsWait++;
        if (adsWait >= 3)
        {
            adsWait = 0;
            adsManager.ShowAd();
        }
    }
}
