using System.Collections.Generic;
using System.Xml.Serialization;


namespace Lesson15_1.Models;



// [Serializable]
public class Translator
{
    [XmlArray(elementName: "TranslatedSubjects")]
    public List<Subject>? Subjects { get; set; }

    [XmlAttribute]
    public string? Name { get; set; }

    [XmlAttribute]
    public string? Surname { get; set; }

    [XmlAttribute(AttributeName = "Identification")]
    public int Id { get; set; }

    public string Fullname => $"{Name} {Surname}";




    public override string ToString() => $"{Id} {Fullname}";

    public Translator() { }

    public Translator(string name, string surname, int id)
    {
        Name = name;
        Surname = surname;
        Id = id;
    }
}