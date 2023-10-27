Console.WriteLine("Prix du produit HT :");
double prixHT = double.Parse(Console.ReadLine());

Console.WriteLine("Taux de TVA :");
double tauxTVA = double.Parse(Console.ReadLine());

double prixTTC = prixHT * (1 + tauxTVA / 100);

Console.WriteLine($"Prix TTC : {prixTTC}");
