using Cours.Models;

namespace Cours.View
{
    public abstract class EtudiantView
    {
        public static void ListEtudiants(List<Etudiant> etudiants)
        {
            foreach (var etudiant in etudiants)
            {
                Console.WriteLine($"Matricule: {etudiant.Matricule}, Nom: {etudiant.NomComplet}, Adresse: {etudiant.Adresse}");
            }
        }
    }
}
