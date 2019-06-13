using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    //Variables del juego
    [Header("Tiempo para jugar: ")] public float tiempoInicial;
    private float tiempo;
    private int nivel;
    private Scene _scene;
    private GameStates gameState;
    public float TiempoInicial { get => tiempo; set => tiempo = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public Scene GaScene { get => _scene; set => _scene = value; }
    public GameStates GameState { get => gameState; set => gameState = value; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else if (instance != null) {
            Destroy(gameObject);
            DontDestroyOnLoad(gameObject);
        }
        
        
    }

    public enum GameStates
    {
        PLAYING,
        WIN,
        LOSE
        
    }

    // Start is called before the first frame update
    void Start()
    {
        TiempoInicial = tiempoInicial;
        GaScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameState.Equals(GameStates.LOSE))
        {
            tiempo = 0f;
        }

        if (GaScene.name.Equals("Juego"))
            tiempo = 0f;
    }
}
