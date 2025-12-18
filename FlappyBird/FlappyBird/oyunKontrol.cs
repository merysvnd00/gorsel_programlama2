using UnityEngine;

public class oyunKontrol : MonoBehaviour
{
    public GameObject gokyuzu1;

    public GameObject gokyuzu2;

    Rigidbody2D rigidbody1_;

    Rigidbody2D rigidbody2_;

    public float arkaPlanHiz = -1.5f;

    float uzunluk;

    public GameObject engel;
    public int kacAdetEngel = 5;
    GameObject []engeller;


    public float zamanSayac;
    int sayac = 0;

    void Start()
    {
        rigidbody1_ = gokyuzu1.GetComponent<Rigidbody2D>();
        rigidbody2_ = gokyuzu2.GetComponent<Rigidbody2D>();

        rigidbody1_.linearVelocity = new Vector2(arkaPlanHiz, 0);
        rigidbody2_.linearVelocity = new Vector2(arkaPlanHiz, 0);


        uzunluk = gokyuzu1.GetComponent<BoxCollider2D>().size.x * gokyuzu1.transform.localScale.x;
        // uzunluk = gokyuzu1.GetComponent<BoxCollider2D>().size.x;
    
        engeller = new GameObject[kacAdetEngel];

        for (int i = 0; i < engeller.Length; i++)
        {
            engeller[i] = Instantiate(engel, new Vector3(-20,-20),Quaternion.identity);
            //ekranda gorunmeyen kisimda olusturuyoruz...
            Rigidbody2D rigidbodyEngel = engeller[i].AddComponent<Rigidbody2D>();
            rigidbodyEngel.linearVelocity = new Vector2(arkaPlanHiz, 0);
            rigidbodyEngel.gravityScale = 0;
            
        }
    }


    void Update()
    {
        ArkaPlanHareket();
        EngelHareket();
    }

    void ArkaPlanHareket()
    {
        if (gokyuzu1.transform.position.x <= -uzunluk)
        {
            gokyuzu1.transform.position += new Vector3(uzunluk * 2, 0);
        }
        if (gokyuzu2.transform.position.x <= -uzunluk)
        {
            gokyuzu2.transform.position += new Vector3(uzunluk * 2, 0);
        }

    }

    void EngelHareket()
    {

        zamanSayac += Time.deltaTime;
        if (zamanSayac >= 1)
        {
            zamanSayac = 0;
            float Yekseni = Random.Range(-0.1f,1.24f);
            engeller[sayac].transform.position = new Vector3(3.13f, Yekseni);
            //alt tarafta olusturdugumuz 5 tanesini getirip yerlerini degistiriyoruz...
            sayac++;
            if (sayac == 5)
            {
                sayac = 0;
            }
        }
    }

    public void OyunBitti()
    {
        rigidbody1_.linearVelocity = new Vector2(0, 0);
        rigidbody2_.linearVelocity = new Vector2(0, 0);
        // simdide engelleri durduracagiz

        for (int i = 0; i < engeller.Length; i++)
        {
            Rigidbody2D rigidbodyEngel = engeller[i].GetComponent<Rigidbody2D>();
            rigidbodyEngel.linearVelocity = new Vector2(0, 0);
            rigidbodyEngel.gravityScale = 0;
        }
    }
}
