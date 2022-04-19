using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject PeligroAparece;
    public Vector3 ValorAparece;
    public int TotalPeligros;
    public float Espera;
    public float StartWait;
    public float TiempoEntreOleadas;

    private int score;
    public Text scoreText;

    public GameObject restartGameObject;
    private bool restart;
    public GameObject gameoverGameObject;
    private bool gameover;


    // Start is called before the first frame update
    void Start()
    {
        UpdateSpawnValues();
        restart = false;
        gameover = false;
        gameoverGameObject.SetActive(false);
        restartGameObject.SetActive(false);

        score = 0;
        ActualizaPuntuacion();
        StartCoroutine(SpawnWaves());
    }

    void UpdateSpawnValues(){
        Vector2 mitad = Utils.GetDimensionsInWorldUnits() / 2;
        ValorAparece = new Vector3(mitad.x - 0.7f, 0f, mitad.y + 6f);
    }
    
    // Update is called once per frame
    void Update(){
        if(restart && Input.GetKeyDown(KeyCode.R)){
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            RestartBoton();
        }
    }

    public void RestartBoton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(StartWait);
        while (true){
            for (int i=0; i< TotalPeligros; i++){
                Vector3 LugarAparece = new Vector3(Random.Range(-ValorAparece.x, ValorAparece.x), ValorAparece.y, ValorAparece.z);
                Instantiate(PeligroAparece, LugarAparece, Quaternion.identity);
                yield return new WaitForSeconds(Espera);
            }
            yield return new WaitForSeconds(TiempoEntreOleadas);

            if (gameover){
                restartGameObject.SetActive(true);
                restart = true;
                break;
            }
        }
    }

    void ActualizaPuntuacion(){
        scoreText.text = ("Puntuación: " + score);
    }

    public void AddScore(int valor){
        score += valor;
        ActualizaPuntuacion();
    }

    public void GameOver(){
        //restartText.gameObject.SetActive(true);
        gameoverGameObject.SetActive(true);
        gameover = true;
    }
}
