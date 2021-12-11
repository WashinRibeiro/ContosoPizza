namespace ContosoPizza.Models
{
    public class Pizza // Uma classe de modelo é necessária para representar uma pizza no inventário, contendo propriedades que representam as características de uma pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsGlutenFree { get; set; }
    }
}