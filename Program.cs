string parola = "";
string parolaFinale = "";
int l = 0;
int p = 0;
Console.WriteLine("Inserisi la stringa di partenza");
parola = Console.ReadLine();
Console.WriteLine("Inserisci l (l e' la lunghezza della stringa che otterrai)");
l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci p (p e' il punto da cui partira' la tringa che otterrai)");
p = Convert.ToInt32(Console.ReadLine());
for(int i = p; i <= l; i++)
{
    parolaFinale = parolaFinale + parola[i];
}
Console.WriteLine(parolaFinale);