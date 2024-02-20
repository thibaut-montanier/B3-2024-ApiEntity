namespace ApiEntity.Data {
    public class ParticipeCours {

        public int Id { get; set; }
        public Personne Personne { get; set; }

        public Cours Cours { get; set; }
    }
}
