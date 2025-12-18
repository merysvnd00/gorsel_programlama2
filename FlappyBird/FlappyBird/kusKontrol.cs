using UnityEngine;
using UnityEngine.UI;

public class kusKontrol : MonoBehaviour
{
    public Sprite []kusSprites;

    SpriteRenderer spriteRenderer;

    bool ileriHareket = true;

    int kusSayacHareket = 0;

    float kusAnimasyonZaman = 0;

    Rigidbody2D rigidbody_;

    public Text sayacText;

    int sayacPuan = 0;

    bool oyunDevamEdiyor = true;

    public GameObject oyunKontrol;

    void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
       rigidbody_ = GetComponent<Rigidbody2D>();
        oyunKontrol = GameObject.FindGameObjectWithTag("oyunKontrol");
    }

    void Update()
    {
        KusAnimasyon();
        KusHareket();
    }
    void KusAnimasyon()
    {
        kusAnimasyonZaman += Time.deltaTime;
        if (kusAnimasyonZaman > 0.1f)
        {
            kusAnimasyonZaman = 0;
            if (ileriHareket)
            {
                spriteRenderer.sprite = kusSprites[kusSayacHareket];
                kusSayacHareket++;

                if (kusSayacHareket == 3)
                {
                    kusSayacHareket--;
                    ileriHareket = false;
                    //bundan sonra geri gelecek yani kusun hareketi
                    //resimlerde 1-2-3 daha sonra 2-1 2-3 2-1 sekl�nde olacak
                }
               
            }
            else
            {
                spriteRenderer.sprite = kusSprites[kusSayacHareket];
                kusSayacHareket--;
                if (kusSayacHareket == 0)
                {
                    kusSayacHareket++;
                    ileriHareket = true;
                }
            }
        }
        
    }

    void KusHareket()
    {
        if (Input.GetMouseButtonDown(0) && oyunDevamEdiyor)
        {
            // oyun devam ettigi surece butona tiklayabilecek
            //sol tik
            // yer cekimi gittikce arttigi i�cin bir sure sonra duzgun calismiyor...
            rigidbody_.linearVelocity = new Vector2(0, 0);
            rigidbody_.AddForce(new Vector2(0, 200));
        }
        if (rigidbody_.linearVelocity.y > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 30);
        }
       else
        {
            transform.eulerAngles = new Vector3(0, 0, -30);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "puan")
        {
            Debug.Log("Puan Aldı.");
            sayacPuan++;
            sayacText.text = "Puan : " + sayacPuan;
        }
        if (other.gameObject.CompareTag("engel")) // .tag ile de yapilabilir
        {
            Debug.Log("Oyun Bitti.");
            oyunDevamEdiyor = false;
            // simdi de arka planin hareket etmesini duduracagiz..
            oyunKontrol.GetComponent<oyunKontrol>().OyunBitti();
        }
    }
}
