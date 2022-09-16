using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lesson15_1.Models;




// [Serializable]
public class TranslatorArmy
{
    [XmlArray]
    public List<Translator>? Translators { get; set; }

    [XmlAttribute]
    public string? Name { get; set; }

    [XmlAttribute]
    public string? Location { get; set; }


    public override string ToString()
    {
        foreach (var item in Translators)
            Console.WriteLine(item);

        return $"{Name} {Location}\n";
    }
}