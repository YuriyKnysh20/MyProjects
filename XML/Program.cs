using System.Xml;

XmlDocument xDoc = new XmlDocument();
xDoc.Load("D:\\users.xml");
// получим корневой элемент
XmlElement? xRoot = xDoc.DocumentElement;
if (xRoot != null)
{
    // обход всех узлов в корневом элементе
    foreach (XmlElement xnode in xRoot)
    {
        // получаем атрибут name
        XmlNode? attr = xnode.Attributes.GetNamedItem("name");
        Console.WriteLine(attr?.Value);

        // обходим все дочерние узлы элемента user
        foreach (XmlNode childnode in xnode.ChildNodes)
        {
            // если узел - company
            if (childnode.Name == "company")
            {
                Console.WriteLine($"Компания: {childnode.InnerText}");
            }
            // если узел age
            if (childnode.Name == "age")
            {
                Console.WriteLine($"Возраст: {childnode.InnerText}");
            }
        }
        Console.WriteLine();
    }
}