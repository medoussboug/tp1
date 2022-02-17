namespace ConsoleApp1;

public class Repertoire
{
    private string Nom = "dossier";
    private int Nbr_fichier = 0;
    private List<Fichier> fichiers = new List<Fichier>(30);
    

    public void afficher()
    {
        Console.WriteLine(Nom);
        foreach (var p in fichiers)
        {
            Console.WriteLine(p.Nom);
        }
    }
    
    public int rechercher(string name)
    {
        int x = 0;
        foreach (var p in fichiers)
        {
            if (p.Nom == name)
            {
                return x;
            }
            x++;
        }

        return -1;
    }

    public void Ajouter(Fichier file)
    {
        fichiers.Add(file);
        Nbr_fichier++;
    }

    public void rechercher()
    {
        foreach (var p in fichiers)
        {
            if (p.Extention == "pdf")
            {
                Console.WriteLine(p.Nom);
            }
        }
    }

    public void updateSize(double size, string name)
    {
        fichiers[rechercher(name)].Taille = size;
    }

    public void renommer(string name)
    {
        fichiers[rechercher(name)].Nom = name;
    }

    public double getTaille()
    {
        double size = 0;
        foreach (var fichier in fichiers)
        {
            size += fichier.Taille;
        }

        return size / (double) 1024;
    }
}