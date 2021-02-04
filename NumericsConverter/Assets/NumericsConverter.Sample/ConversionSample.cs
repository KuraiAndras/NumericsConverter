using UnityEngine;
using UnityEngine.UI;

namespace NumericsConverter.Sample
{
    public sealed class ConversionSample : MonoBehaviour
    {
        private void Start()
        {
            var text = GetComponent<Text>();

            var value = new Vector4(1f, 2f, 3f, 4f).ToSystemGeneric();

            text.text = $"Values: {value[0]} {value[1]} {value[2]} {value[3]}";
        }
    }
}
