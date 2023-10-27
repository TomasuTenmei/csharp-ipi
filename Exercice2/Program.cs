Console.WriteLine("Quel est votre jour de naissance ? ");
var birthDay = Console.ReadLine();

Console.WriteLine("Quel est votre mois de naissance ? ");
var birthMonth = Console.ReadLine();

Console.WriteLine("Quel est votre année de naissance ? ");
var birthYear = Console.ReadLine();

var date = DateTime.Now;
Console.WriteLine("Vous avez " + (date.Year - int.Parse(birthYear)) + " ans");

var ageYear = date.Year - int.Parse(birthYear);
var ageMonth = 0;
var ageDay = 0;

if (int.Parse(birthMonth) > date.Month)
{
    ageMonth = (12 - int.Parse(birthMonth)) + date.Month;
}
else
{
    ageMonth = date.Month - int.Parse(birthMonth);
}

if (int.Parse(birthDay) > date.Day)
{
    ageDay = (30 - int.Parse(birthDay)) + date.Day;
    ageMonth--;
}
else
{
    ageDay = date.Day - int.Parse(birthDay);
}

Console.WriteLine("Vous avez " + ageYear + " ans, " + ageMonth + " mois et " + ageDay + " jours");