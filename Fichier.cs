namespace ConsoleApp1;

public class Fichier
{
    string nom;
    string extention;
    double taille;
    

    public Fichier(string nom, string extention, float taille)
    {
        this.nom = nom;
        this.extention = extention;
        this.taille = taille;
    }

    public string Nom
    {
        get => nom;
        set => nom = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Extention
    {
        get => extention;
        set => extention = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Taille
    {
        get => taille;
        set => taille = value;
    }
}