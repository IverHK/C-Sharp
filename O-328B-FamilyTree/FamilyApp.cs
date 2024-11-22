using System.Text;

namespace O_328B_FamilyTree;
public class FamilyApp
{
    private List<Person> _people;
    internal string CommandPrompt = "What do you want to see? Write:vis Id-Number. Example: vis 3 ";

    public FamilyApp(params Person[] people)
    {
        _people = new List<Person>(people);
    }
    
    public string WelcomeMessage()
    {
        return $"Welcome all {_people.Count} people!";
    }

    public string HandleCommand(string command)
    {
        string[] parts = command.Split(' ');
        int extractedNumber = int.Parse(parts[1]);
        Person currentPerson = new Person();
        string personDescription = null;
        List<Person> childrenNames = new List<Person>();

        foreach (Person person in _people)
        {
            if (person.Id == extractedNumber)
            {
                currentPerson = person;
                personDescription = currentPerson.GetDescription();
            }
        }
        
        foreach (Person person in _people)
        {
            if (person.Father != null && person.Father.Id == currentPerson.Id )
            {
                childrenNames.Add(person);
            }
            if (person.Mother != null && person.Mother.Id == currentPerson.Id )
            {
                childrenNames.Add(person);
            }
        }
        
        var commandString = new StringBuilder();
        if(!string.IsNullOrEmpty(personDescription)) 
        {
            commandString.Append($"{personDescription}\n");
        }
        
        if(!string.IsNullOrEmpty(childrenNames[0].FirstName)) 
        {
            commandString.Append("  Barn:\n");
        }
        
        if(!string.IsNullOrEmpty(childrenNames[0].FirstName)) 
        {
            foreach (Person person in childrenNames)
            {
                commandString.Append($"    {person.FirstName} {person.LastName}(Id={person.Id}) Født: {person.BirthYear}\n");
            }
        }
        
        return commandString.ToString();
    }
}