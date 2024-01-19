using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using UnityEditor;

    public class TestEditMode
    {
        //private LevelManager levelManager;
        // A Test behaves as an ordinary method
        [Test]
        public void TestN1_Opening()
        { 
            EditorSceneManager.OpenScene("Assets/Scenes/Open1.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("Open1", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        }


        // A Test behaves as an ordinary method
        [Test]
        public void TestN2_Lab()
        {    
            EditorSceneManager.OpenScene("Assets/Scenes/Lab.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("Lab", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        }
        // A Test behaves as an ordinary method
        [Test]
        public void TestN3_Libros()
        {      
        //Scene contAnimal2             
            EditorSceneManager.OpenScene("Assets/Scenes/contAnimal2.unity");            
            new WaitForSeconds(3);
            Assert.AreEqual("contAnimal2", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        //Scene contCelllBook1
            EditorSceneManager.OpenScene("Assets/Scenes/contCelllBook1.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("contCelllBook1", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        //Scene contCelllBook2
            EditorSceneManager.OpenScene("Assets/Scenes/contCelllBook2.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("contCelllBook2", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        //Scene contCelllTransBook1
            EditorSceneManager.OpenScene("Assets/Scenes/contCelllTransBook1.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("contCelllTransBook1", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        //Scene contCelllTransBook2
            EditorSceneManager.OpenScene("Assets/Scenes/contCelllTransBook2.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("contCelllTransBook2", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        //Scene contCelllTransBook3
            EditorSceneManager.OpenScene("Assets/Scenes/contCelllTransBook3.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("contCelllTransBook3", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        //Scene contCelllTransBook4
            EditorSceneManager.OpenScene("Assets/Scenes/contCelllTransBook4.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("contCelllTransBook4", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        //Scene contCelllTransBook5
            EditorSceneManager.OpenScene("Assets/Scenes/contCelllTransBook5.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("contCelllTransBook5", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
        //Scene bookInfo
            EditorSceneManager.OpenScene("Assets/Scenes/bookInfo.unity");
            new WaitForSeconds(3);
            Assert.AreEqual("bookInfo", SceneManager.GetActiveScene().name);
            EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), true);
    } 

        // A Test behaves as an ordinary method
        [Test]
        public void TestN6_SalidaGame()
        {
        // Inicializa la clase LevelManager        
            NewBehaviourScript level = new NewBehaviourScript();

            // Ejecuta la funcion
            level.salidaGame();

            // Verificar si la aplicación se cerró por completo
            // En el editor, verificamos si la reproducción se detuvo
            #if UNITY_EDITOR
                    Assert.IsFalse(EditorApplication.isPlaying, "La reproducción no se detuvo en el editor");
#else
                        // En la compilación, verificamos si la aplicación se cerró
                        Assert.IsTrue(Application.isEditor, "La aplicación no se cerró");
#endif

        // Verifica que se ejecute la funcion y se pueda realizar el assert con el Log
        LogAssert.Expect(LogType.Log, "Salir del juego!");
    }
}
