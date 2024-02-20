namespace ApiEntity.Data {
    public class Personne {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Prenom { get; set; }

        public List<ParticipeCours> Cours { get; set; }
    }
}
