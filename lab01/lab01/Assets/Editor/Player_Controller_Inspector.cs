using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(PlayerController))]
public class Player_Inspector_Inspector : Editor
{
    public VisualTreeAsset m_InspectorUXML;

    public override VisualElement CreateInspectorGUI()
    {
        // Create a new VisualElement to be the root of our Inspector UI.
        VisualElement myInspector = new VisualElement();

        // Fill the Inspector with the default GUI.
        InspectorElement.FillDefaultInspector(myInspector, serializedObject, this);

        var button = new Button(() =>
        {
            Debug.Log("Wciœniêto Przycisk");
        })
        { text = "Wyœwitl tekst w konsoli" };


        // Add a simple label.
        myInspector.Add(new Label("This is a custom Inspector"));
        myInspector.Add(button);

        if (m_InspectorUXML != null)
        {
            VisualElement uxmlContent = m_InspectorUXML.CloneTree();
            myInspector.Add(uxmlContent);
        }
        // Return the finished Inspector UI.
        return myInspector;
    }
}