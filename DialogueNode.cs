[System.Serializable]
public class DialogueNode
{
    public string Text;
    public DialogueOption[] Options;
}

[System.Serializable]
public class DialogueOption
{
    public string Text;
    public DialogueNode NextNode;
}
