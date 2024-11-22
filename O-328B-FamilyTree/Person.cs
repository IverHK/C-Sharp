using System.Data.Common;
using System.Text;

namespace O_328B_FamilyTree;

public class Person
{

    public int Id;
    public string LastName;
    public string FirstName;
    public int BirthYear;
    public int DeathYear;
    public Person Father;  
    public Person Mother;

    public Person(         
        int id = 0, 
        string lastName = null, 
        string firstName = null, 
        int birthYear = 0, 
        int deathYear = 0, 
        Person father = null, 
        Person mother = null)
    {
        Id = id;
        LastName = lastName;
        FirstName = firstName;
        BirthYear = birthYear;
        DeathYear = deathYear;
        Father = father;
        Mother = mother;
    }


    public string GetDescription()
    {
        string idString = Id != 0 ? Id.ToString() : null;
        string birthYearString = BirthYear != 0 ? BirthYear.ToString() : null;
        string deathYearString = DeathYear != 0 ? DeathYear.ToString() : null;
        
        var stringBuilder = new StringBuilder();
        if(!string.IsNullOrEmpty(FirstName)) 
        {
            stringBuilder.Append($"{FirstName} ");
        }
		
        if(!string.IsNullOrEmpty(LastName)) 
        {
            stringBuilder.Append($"{LastName} ");
        }
		
        if(!string.IsNullOrEmpty(idString)) 
        {
            stringBuilder.Append($"(Id={idString}) ");
        }
        
        if(!string.IsNullOrEmpty(birthYearString)) 
        {
            stringBuilder.Append($"Født: {birthYearString} ");
        }
		
        if(!string.IsNullOrEmpty(deathYearString)) 
        {
            stringBuilder.Append($"Død: {deathYearString} ");
        }
				
        if(Father != null && !string.IsNullOrEmpty(Father.FirstName)) 
        {
            stringBuilder.Append($"Far: {Father.FirstName} (Id={Father.Id}) ");
        }
		
        if(Mother != null && !string.IsNullOrEmpty(Mother.FirstName)) 
        {
            stringBuilder.Append($"Mor: {Mother.FirstName} (Id={Mother.Id})");
        }
		
        return stringBuilder.ToString();
    }







}
