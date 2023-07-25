using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TopKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public float hiz = 10;
    Rigidbody fizik;
    int sayac;
    public int toplamSkor;
    public TMPro.TextMeshProUGUI sayacText;
    public TMPro.TextMeshProUGUI oyunBittiText;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay,0,dikey);
        fizik.AddForce(vec * hiz);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.tag == "Topla")
        //{
        //    Destroy(other.gameObject);
        //}

        if (other.gameObject.tag == "Topla")
        {
            other.gameObject.SetActive(false);
            sayac++;

            sayacText.text = "Skor: " + sayac;
            
            if (sayac == toplamSkor)
            {
                oyunBittiText.text = "Oyun Bitti";
            }
        }
      
    }
}
