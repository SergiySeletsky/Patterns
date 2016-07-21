namespace Patterns.Creational.Prototype
{
    /// <summary>
    ///     Добавляет прототипы в словарь и запрашивает клоны.
    /// </summary>
    internal class Test
    {
        private void Do()
        {
            var colormanager = new PrototypeManager();

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            Color color;

            string name = "red";
            color = colormanager[name].Clone() as Color;

            name = "peace";
            color = colormanager[name].Clone() as Color;

            name = "flame";
            color = colormanager[name].Clone() as Color;
        }
    }
}