using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class ObstacleBehaviour : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;
    int random = 0;
    private void OnEnable()
    {
        random = Random.Range(1, 13);
        gameObject.transform.GetChild(random - 1).gameObject.SetActive(false);
        gameObject.transform.GetChild(random).gameObject.SetActive(false);
        gameObject.transform.GetChild(random+1).gameObject.SetActive(false);
        gameObject.transform.GetChild(random + 2).gameObject.SetActive(false);
        random = Random.Range(0, 15);

        destroy();
    }
    void Update()
    {
        transform.position += Vector3.back * speed;
    }

    async void destroy()
    {
        await Task.Delay(4000);
        DestroyImmediate(this.gameObject);
    }
}
