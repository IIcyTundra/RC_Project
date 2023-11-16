using UnityEditor;
using UnityEngine;


namespace RoguelikeGeneratorPro
{
    public class MenuTest : MonoBehaviour
    {
        [MenuItem("RoguelikeGeneratorPro/Rigenerate level  %g")]
        static void DoSomethingWithAShortcutKey()
        {
            RoguelikeGeneratorPro[] levelGenerators = (RoguelikeGeneratorPro[])FindObjectsOfType(typeof(RoguelikeGeneratorPro));
            if (levelGenerators != null) for (int i = 0; i < levelGenerators.Length; i++) levelGenerators[i].RigenenerateLevel();
        }
    }
}