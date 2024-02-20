namespace ApiEntity.Data {
    public class Cours {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<ParticipeCours> Participes { get; set;}
    }
}
