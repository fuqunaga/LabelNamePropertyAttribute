# LabelNamePropertyAttribute

```
public class SampleClass : MonoBehaviour
{
	[System.Serializable]
	public class Element
	{
		public GameObject prefab;
	}

	public Element[] NoAttribute;


	[LabelNameProperty("prefab")]
	public Element[] HasAttribute;
}

```
![screenshot](https://raw.githubusercontent.com/fuqunaga/fuqunaga.github.io/master/LabelNamePropertyAttribute/sampleclass.png)
